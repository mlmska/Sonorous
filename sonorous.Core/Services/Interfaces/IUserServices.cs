using sonorous.Core.DTOs;
using sonorous.Datalayer.Entites.User;
using sonorous.Datalayer.Entites.Wallett;
using System;
using System.Collections.Generic;
using System.Text;

namespace sonorous.Core.Services.Interfaces
{
    public interface IUserServices
    {
        bool isExistusername(string username);

        bool isExistemail(string email);

        int adduser(User user);

        User loginuser(LoginViewModel login);

        User getuserbyEmail(string email);

        User getuserbyeactivecode(string activecode);

        User getuserbyusername(string username);

        User getuserbyuserid(int userid);

        int getuseridbyusername(string username);

        void updateuser(User user);

        void Deleteusers(int userid);

        void Restoruser(int userid);

        string getuseremailbyusername(string username);

        bool activeaccount(string activecode);

        #region Userpanel

        InformationViewModel GetUserinformation(string username);
        InformationViewModel GetUserinformation(int userid);
        SidebarUserPanelViewModel getsidebaruserpaneldata(string username);

        EditProfileViewModel GetdataForEditProfileuser(string username);
        void EditProfile(string username,EditProfileViewModel edit);

        bool CompareOldpassword(string oldpassword, string username);

        void ChangeuserPassword(string username, string newpassword);

        InformationViewModel getdeleteduserinformation(int userid);

        #endregion

        #region Wallett

        int balancewallett(string username);

        List<WallettViewModel> GetWalletuser(string username);

        int ChargeWallett(string username, int amount,string description,bool Ispay=false);

        int addwallett(Wallett wallett);

        Wallett GetWallettbywallettid(int wallettid);

        void Updatewallet(Wallett wallett);

        #endregion

        #region Admin Panel

        UserforAdminViewModel GetUsers(int pageid = 1, string filterEmail = "", string filterUserName = "");
        UserforAdminViewModel Getdeleteusers(int pageid = 1, string filterEmail = "", string filterUserName = "");

        int adduserfromadmin(CreateUserViewModel user);

        EditUserViewModel GetUserForShowinEditadmin(int userid);

        void Edituserfromadmin(EditUserViewModel edit);
        #endregion
    }
}
