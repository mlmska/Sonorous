﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sonorous.Datalayer.Context;

namespace sonorous.Datalayer.Migrations
{
    [DbContext(typeof(SonorousContext))]
    [Migration("20201204165650_mig_proddssssssaaccrsx")]
    partial class mig_proddssssssaaccrsx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("sonorous.Datalayer.Entites.Permissions.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<string>("PermissionTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("PermissionID");

                    b.HasIndex("ParentID");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionID = 1,
                            PermissionTitle = "مدیریت سایت"
                        },
                        new
                        {
                            PermissionID = 2,
                            ParentID = 1,
                            PermissionTitle = "مدیریت کاربران"
                        },
                        new
                        {
                            PermissionID = 3,
                            ParentID = 2,
                            PermissionTitle = "افزودن کاربر"
                        },
                        new
                        {
                            PermissionID = 4,
                            ParentID = 2,
                            PermissionTitle = "ویرایش کاربر"
                        },
                        new
                        {
                            PermissionID = 5,
                            ParentID = 2,
                            PermissionTitle = "حذف کاربر"
                        },
                        new
                        {
                            PermissionID = 6,
                            ParentID = 1,
                            PermissionTitle = "مدیریت نقش ها"
                        },
                        new
                        {
                            PermissionID = 7,
                            ParentID = 6,
                            PermissionTitle = "افزودن نقش"
                        },
                        new
                        {
                            PermissionID = 8,
                            ParentID = 6,
                            PermissionTitle = "ویرایش نقش"
                        },
                        new
                        {
                            PermissionID = 9,
                            ParentID = 6,
                            PermissionTitle = "حذف نقش"
                        });
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Permissions.RolePermission", b =>
                {
                    b.Property<int>("RP_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PermissionID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("RP_ID");

                    b.HasIndex("PermissionID");

                    b.HasIndex("RoleID");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Createdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("LevelID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int?>("SubGroup")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updatedate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductID");

                    b.HasIndex("GroupID");

                    b.HasIndex("LevelID");

                    b.HasIndex("StatusID");

                    b.HasIndex("SubGroup");

                    b.HasIndex("TeacherID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.ProductLevel", b =>
                {
                    b.Property<int>("LevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LevelTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("LevelID");

                    b.ToTable("ProductLevels");

                    b.HasData(
                        new
                        {
                            LevelID = 1,
                            LevelTitle = "ساده"
                        },
                        new
                        {
                            LevelID = 2,
                            LevelTitle = "متوسط"
                        },
                        new
                        {
                            LevelID = 3,
                            LevelTitle = "پیشرفته"
                        },
                        new
                        {
                            LevelID = 4,
                            LevelTitle = "خیلی پیشرفته"
                        });
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.ProductStatus", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StatusTilte")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("StatusID");

                    b.ToTable("ProductStatuses");

                    b.HasData(
                        new
                        {
                            StatusID = 1,
                            StatusTilte = "موجود"
                        },
                        new
                        {
                            StatusID = 2,
                            StatusTilte = "تمام شده"
                        },
                        new
                        {
                            StatusID = 3,
                            StatusTilte = "در حال ساخت"
                        });
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.Product_Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.HasKey("GroupID");

                    b.HasIndex("ParentID");

                    b.ToTable("product_Groups");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.User.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Roletitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Roletitle = "مدیر سایت",
                            isDelete = false
                        },
                        new
                        {
                            RoleID = 2,
                            Roletitle = "ادمین",
                            isDelete = false
                        },
                        new
                        {
                            RoleID = 3,
                            Roletitle = "کاربر عادی",
                            isDelete = false
                        },
                        new
                        {
                            RoleID = 4,
                            Roletitle = "فروشنده",
                            isDelete = false
                        });
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.User.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Activecode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAvatar")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.User.UserRole", b =>
                {
                    b.Property<int>("US_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("US_ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Wallett.Wallett", b =>
                {
                    b.Property<int>("WallettID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("WallettTypeTypeID")
                        .HasColumnType("int");

                    b.Property<bool>("ispay")
                        .HasColumnType("bit");

                    b.HasKey("WallettID");

                    b.HasIndex("UserID");

                    b.HasIndex("WallettTypeTypeID");

                    b.ToTable("Walletts");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Wallett.WallettType", b =>
                {
                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.Property<string>("TypeTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("TypeID");

                    b.ToTable("WallettTypes");

                    b.HasData(
                        new
                        {
                            TypeID = 1,
                            TypeTitle = "واریز"
                        },
                        new
                        {
                            TypeID = 2,
                            TypeTitle = "برداشت"
                        });
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Permissions.Permission", b =>
                {
                    b.HasOne("sonorous.Datalayer.Entites.Permissions.Permission", null)
                        .WithMany("Permissions")
                        .HasForeignKey("ParentID");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Permissions.RolePermission", b =>
                {
                    b.HasOne("sonorous.Datalayer.Entites.Permissions.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sonorous.Datalayer.Entites.User.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.Product", b =>
                {
                    b.HasOne("sonorous.Datalayer.Entites.Product.Product_Group", "Product_Group")
                        .WithMany("Products")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sonorous.Datalayer.Entites.Product.ProductLevel", "ProductLevel")
                        .WithMany("Products")
                        .HasForeignKey("LevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sonorous.Datalayer.Entites.Product.ProductStatus", "ProductStatus")
                        .WithMany("Products")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sonorous.Datalayer.Entites.Product.Product_Group", "Group")
                        .WithMany("SubGroup")
                        .HasForeignKey("SubGroup");

                    b.HasOne("sonorous.Datalayer.Entites.User.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Product_Group");

                    b.Navigation("ProductLevel");

                    b.Navigation("ProductStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.Product_Group", b =>
                {
                    b.HasOne("sonorous.Datalayer.Entites.Product.Product_Group", null)
                        .WithMany("product_Groups")
                        .HasForeignKey("ParentID");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.User.UserRole", b =>
                {
                    b.HasOne("sonorous.Datalayer.Entites.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sonorous.Datalayer.Entites.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Wallett.Wallett", b =>
                {
                    b.HasOne("sonorous.Datalayer.Entites.User.User", "User")
                        .WithMany("Walletts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sonorous.Datalayer.Entites.Wallett.WallettType", "WallettType")
                        .WithMany("Walletts")
                        .HasForeignKey("WallettTypeTypeID");

                    b.Navigation("User");

                    b.Navigation("WallettType");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Permissions.Permission", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.ProductLevel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.ProductStatus", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Product.Product_Group", b =>
                {
                    b.Navigation("product_Groups");

                    b.Navigation("Products");

                    b.Navigation("SubGroup");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.User.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.User.User", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("UserRoles");

                    b.Navigation("Walletts");
                });

            modelBuilder.Entity("sonorous.Datalayer.Entites.Wallett.WallettType", b =>
                {
                    b.Navigation("Walletts");
                });
#pragma warning restore 612, 618
        }
    }
}
