using Microsoft.EntityFrameworkCore;
using sonorous.Datalayer.Entites.Order;
using sonorous.Datalayer.Entites.Permissions;
using sonorous.Datalayer.Entites.Product;
using sonorous.Datalayer.Entites.User;
using sonorous.Datalayer.Entites.Wallett;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sonorous.Datalayer.Context
{
    public class SonorousContext:DbContext
    {
        public SonorousContext(DbContextOptions<SonorousContext> options):base(options)
        {

        }

        #region Permission

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }



        #endregion

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<UserDiscountCode> UserDiscountCodes { get; set; }


        #endregion

        #region Wallett

        public DbSet<WallettType> WallettTypes { get; set; }
        public DbSet<Wallett> Walletts { get; set; }





        #endregion

        #region Product

        public DbSet<Product_Group> product_Groups { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductLevel> ProductLevels { get; set; }
        public DbSet<ProductStatus> ProductStatuses { get; set; }

        public DbSet<UserProducts> UserProducts { get; set; }

        public DbSet<ProductComment> ProductComments { get; set; }






        #endregion

        #region Order

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Discount> Discounts { get; set; }




        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed data

            modelBuilder.Entity<WallettType>().HasData(new WallettType()
            {
                TypeID = 1,
                TypeTitle ="واریز",

            },
            new WallettType()
            {
                TypeID=2,
                TypeTitle="برداشت",
            });

            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleID = 1,
                Roletitle = "مدیر سایت"
            },
            new Role()
            {
                RoleID = 2,
                Roletitle = "ادمین"
            },
            new Role()
            {
                RoleID = 3,
                Roletitle = "کاربر عادی"
            },
            new Role()
            {
                RoleID = 4,
                Roletitle = "فروشنده"
            });


            modelBuilder.Entity<Permission>().HasData(new Permission()
            {
                PermissionID = 1,
                PermissionTitle = "مدیریت سایت",
                ParentID = null
            },
            new Permission()
            {
                PermissionID = 2,
                PermissionTitle = "مدیریت کاربران",
                ParentID = 1
            },
            new Permission()
            {
                PermissionID = 3,
                PermissionTitle = "افزودن کاربر",
                ParentID = 2
            },
            new Permission()
             {
                 PermissionID = 4,
                 PermissionTitle = "ویرایش کاربر",
                 ParentID = 2
             },
            new Permission()
              {
                  PermissionID = 5,
                  PermissionTitle = "حذف کاربر",
                  ParentID = 2
              },
            new Permission()
               {
                   PermissionID = 6,
                   PermissionTitle = "مدیریت نقش ها",
                   ParentID = 1
               },
            new Permission()
                {
                    PermissionID = 7,
                    PermissionTitle = "افزودن نقش",
                    ParentID = 6
                },
            new Permission()
                 {
                     PermissionID = 8,
                     PermissionTitle = "ویرایش نقش",
                     ParentID = 6
                 },
            new Permission()
                 {
                     PermissionID = 9,
                     PermissionTitle = "حذف نقش",
                     ParentID = 6
                 });

            modelBuilder.Entity<ProductLevel>().HasData(new ProductLevel()
            {
                LevelID = 1,
                LevelTitle = "ساده",
            },
            new ProductLevel()
            {
                LevelID = 2,
                LevelTitle = "متوسط",
            },
            new ProductLevel()
            {
                LevelID = 3,
                LevelTitle = "پیشرفته"
            },
            new ProductLevel()
            {
                LevelID = 4,
                LevelTitle = "خیلی پیشرفته"
            });

            modelBuilder.Entity<ProductStatus>().HasData(new ProductStatus()
            {
                StatusID = 1,
                StatusTilte = "موجود",
            },
            new ProductStatus()
            {
                StatusID = 2,
                StatusTilte = "تمام شده"
            },
            new ProductStatus()
            {
                StatusID = 3,
                StatusTilte = "در حال ساخت"
            });
           
                
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.isDelete);

            modelBuilder.Entity<Role>().HasQueryFilter(r => !r.isDelete);
            modelBuilder.Entity<Product_Group>().HasQueryFilter(r => !r.isDelete);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetForeignKeys())
               .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
