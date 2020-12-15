using Microsoft.EntityFrameworkCore;
using sonorous.Core.DTOs;
using sonorous.Core.Generators;
using sonorous.Core.Security;
using sonorous.Core.Services.Interfaces;
using sonorous.Datalayer.Context;
using sonorous.Datalayer.Entites.User;
using sonorous.Datalayer.Entites.Wallett;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace sonorous.Core.Services
{
    public class UserServices : IUserServices
    {
        private SonorousContext _db;
        public UserServices(SonorousContext db)
        {
            _db = db;
        }

        public bool activeaccount(string activecode)
        {
            var user = _db.Users.SingleOrDefault(p => p.Activecode == activecode);
            if (user == null || user.isActive)
            {
                return false;
            }
            user.isActive = true;
            user.Activecode = NameGenerator.Generateuniqcode();
            _db.SaveChanges();
            return true;
        }

        public int adduser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user.UserID;
        }

        public int adduserfromadmin(CreateUserViewModel user)
        {
            User Adduser = new User();
            Adduser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            Adduser.Username = user.Username;
            Adduser.Activecode = NameGenerator.Generateuniqcode();
            Adduser.Email = user.Email;
            Adduser.isActive = true;
            Adduser.RegisterDate = DateTime.Now;

            #region saveavatar
            if (user.UserAvatar != null)
            {
                string imagepath = "";
                Adduser.UserAvatar = NameGenerator.Generateuniqcode() + Path.GetExtension(user.UserAvatar.FileName);
                imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar/", Adduser.UserAvatar);
                using (var stream = new FileStream(imagepath, FileMode.Create))
                {
                    user.UserAvatar.CopyTo(stream);
                }

            }
            else
            {
                Adduser.UserAvatar = "Defult.jpg";
            }


            #endregion

            return adduser(Adduser);

        }

        public int addwallett(Wallett wallett)
        {
            _db.Walletts.Add(wallett);
            _db.SaveChanges();
            return wallett.WallettID;
        }

        public int balancewallett(string username)
        {
            int userid = getuseridbyusername(username);

            var deposit = _db.Walletts.Where(p => p.UserID == userid && p.TypeID == 1&&p.ispay).Select(p => p.Amount).ToList();

            var withdraw = _db.Walletts.Where(p => p.UserID == userid && p.TypeID == 2).Select(p => p.Amount).ToList();

            return (deposit.Sum() - withdraw.Sum());
        }

        public void ChangeuserPassword(string username, string newpassword)
        {
            var user = getuserbyusername(username);
            user.Password = PasswordHelper.EncodePasswordMd5(newpassword);
            updateuser(user);
        }

        public int ChargeWallett(string username, int amount,string description, bool Ispay = false)
        {
            Wallett wallett = new Wallett()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = description,
                ispay = Ispay,
                TypeID = 1,
                UserID = getuseridbyusername(username),
            };
            return addwallett(wallett);
        }

        public bool CompareOldpassword(string oldpassword, string username)
        {
            string oldhashpassword = PasswordHelper.EncodePasswordMd5(oldpassword);
            return _db.Users.Any(p => p.Username == username && p.Password == oldhashpassword);
        }

        public void Deleteusers(int userid)
        {
            User user = getuserbyuserid(userid);
            user.isDelete = true;
            updateuser(user);
        }

        public void EditProfile(string username,EditProfileViewModel edit)
        {
            if (edit.Useravatar != null)
            {
                string imagepath = "";
                if (edit.AvatarName != "Defult.jpg")
                {
                    imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar/", edit.AvatarName);
                    if (File.Exists(imagepath))
                    {
                        File.Delete(imagepath);
                    }
                }
                edit.AvatarName = NameGenerator.Generateuniqcode() + Path.GetExtension(edit.Useravatar.FileName);
                imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar/", edit.AvatarName);
                using(var stream=new FileStream(imagepath, FileMode.Create))
                {
                    edit.Useravatar.CopyTo(stream);
                }
            }
            var user = getuserbyusername(username);
            user.Username = edit.Username;
            user.Email = edit.Email;
            user.UserAvatar = edit.AvatarName;

            updateuser(user);


        }

        public void Edituserfromadmin(EditUserViewModel edit)
        {
            User user = getuserbyuserid(edit.UserID);
           
            user.isActive = edit.isactive;
           
            if (edit.UserAvatar != null)
            {
                if (edit.AvatarName == "Defult.jpg")
                {
                   string deletepath= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar/", edit.AvatarName);
                    if (File.Exists(deletepath))
                    {
                        File.Delete(deletepath);
                    }
                }
                
                user.UserAvatar = NameGenerator.Generateuniqcode() + Path.GetExtension(edit.UserAvatar.FileName);
                string imagepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar/", user.UserAvatar);
                using (var stream = new FileStream(imagepath, FileMode.Create))
                {
                    edit.UserAvatar.CopyTo(stream);
                }
            }
            updateuser(user);
        }

        public EditProfileViewModel GetdataForEditProfileuser(string username)
        {
            return _db.Users.Where(p => p.Username == username).Select(p => new EditProfileViewModel()
            {
                AvatarName=p.UserAvatar,
                Email=p.Email,
                Username=p.Username,

            }).Single();
        }

        public InformationViewModel getdeleteduserinformation(int userid)
        {
            IQueryable<User> user = _db.Users.IgnoreQueryFilters().Where(p => p.isDelete);
            return user.Where(p => p.UserID == userid).Select(p => new InformationViewModel()
            {
                Email = p.Email,
                RegisterDate = p.RegisterDate,
                Username = p.Username,
                Wallet = 0
            }).Single();
            
        }

        public UserforAdminViewModel Getdeleteusers(int pageid = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _db.Users.IgnoreQueryFilters().Where(p=>p.isDelete);

            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(p => p.Email.Contains(filterEmail));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(p => p.Username.Contains(filterUserName));
            }

            int take = 10;
            int skip = (pageid - 1) * take;

            UserforAdminViewModel list = new UserforAdminViewModel();

            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;

            list.Users = result.OrderBy(p => p.RegisterDate).Skip(skip).Take(take).ToList();


            return list;
        }

        public SidebarUserPanelViewModel getsidebaruserpaneldata(string username)
        {
            return _db.Users.Where(p => p.Username == username).Select(p => new SidebarUserPanelViewModel()
            {
                Username=p.Username,
                Imagename=p.UserAvatar,
                RegisterDate=p.RegisterDate
            }).Single();
        }

        public User getuserbyeactivecode(string activecode)
        {
            return _db.Users.SingleOrDefault(p => p.Activecode == activecode);
        }

        public User getuserbyEmail(string email)
        {
            return _db.Users.SingleOrDefault(p => p.Email == email);
        }

        public User getuserbyuserid(int userid)
        {
            return _db.Users.Find(userid);
        }

        public User getuserbyusername(string username)
        {
            return _db.Users.SingleOrDefault(p => p.Username == username);
        }

        public string getuseremailbyusername(string username)
        {
           var user= _db.Users.Where(p => p.Username == username && !p.isDelete).SingleOrDefault();

            return user.Email;
        }

        public EditUserViewModel GetUserForShowinEditadmin(int userid)
        {
            return _db.Users.Where(p => p.UserID == userid).Select(p => new EditUserViewModel()
            {
                UserID=p.UserID,
                AvatarName=p.UserAvatar,
                Email=p.Email,
                isactive=p.isActive,
                Username=p.Username,
                UserRoles=p.UserRoles.Select(r=>r.RoleID).ToList()
            }).Single();
        }

        public int getuseridbyusername(string username)
        {
            return _db.Users.Single(p => p.Username == username).UserID;
        }

        public InformationViewModel GetUserinformation(string username)
        {
            var user = getuserbyusername(username);
            InformationViewModel info = new InformationViewModel();
            info.Email = user.Email;
            info.RegisterDate = user.RegisterDate;
            info.Username = user.Username;
            info.Wallet = balancewallett(username);
            return info;
        }

        public InformationViewModel GetUserinformation(int userid)
        {

            
            var user = getuserbyuserid(userid);
            InformationViewModel info = new InformationViewModel();
            info.Email = user.Email;
            info.RegisterDate = user.RegisterDate;
            info.Username = user.Username;
            info.Wallet = balancewallett(user.Username);
            return info;
        }

        public UserforAdminViewModel GetUsers(int pageid = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _db.Users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(p => p.Email.Contains(filterEmail));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(p => p.Username.Contains(filterUserName));
            }

            int take = 10;
            int skip = (pageid - 1) * take;

            UserforAdminViewModel list = new UserforAdminViewModel();

            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            
            list.Users = result.OrderBy(p => p.RegisterDate).Skip(skip).Take(take).ToList();


            return list;
            
        }

        public Wallett GetWallettbywallettid(int wallettid)
        {
            return _db.Walletts.Find(wallettid);
        }

        public List<WallettViewModel> GetWalletuser(string username)
        {
            int userid = getuseridbyusername(username);

            return _db.Walletts.Where(p => p.ispay && p.UserID == userid).Select(p=>new WallettViewModel() { 
            
                Amount=p.Amount,
                Createtime=p.CreateDate,
                Description=p.Description,
                Type=p.TypeID
            
            }).ToList();
        }

        public bool isExistemail(string email)
        {
            return _db.Users.Any(p => p.Email == email);
        }

        public bool isExistusername(string username)
        {
            return _db.Users.Any(p => p.Username == username);
        }

        public User loginuser(LoginViewModel login)
        {
            string hashpassword = PasswordHelper.EncodePasswordMd5(login.Password);
            if (login.emailorusername.Contains("@"))
            {
                return _db.Users.SingleOrDefault(p => p.Email == login.emailorusername && p.Password == hashpassword);
            }
            else
            {
                return _db.Users.SingleOrDefault(p => p.Username == login.emailorusername && p.Password == hashpassword);
            }
        }

        public void Restoruser(int userid)
        {
            var user = getuserbyuserid(userid);
            user.isDelete = false;
            updateuser(user);
        }

        public void updateuser(User user)
        {
            _db.Update(user);
            _db.SaveChanges();
        }

        public void Updatewallet(Wallett wallett)
        {
            _db.Walletts.Update(wallett);
            _db.SaveChanges();
        }
    }
}
