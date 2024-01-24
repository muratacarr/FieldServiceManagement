﻿// <auto-generated />
using System;
using FieldServiceManagement.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FieldServiceManagement.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240124140405_Status-add-props")]
    partial class Statusaddprops
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "1",
                            Name = "musteri",
                            NormalizedName = "MUSTERI"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2",
                            Name = "bayi",
                            NormalizedName = "BAYI"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "3",
                            Name = "teknisyen",
                            NormalizedName = "TEKNISYEN"
                        });
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ZoneId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.CustomerFeedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FeedbackDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("ServiceRequestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceRequestId")
                        .IsUnique();

                    b.ToTable("CustomerFeedbacks");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.JobAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FinishJobDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PlanDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceRequestId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TakeJobDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TechnicianId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceRequestId")
                        .IsUnique();

                    b.HasIndex("TechnicianId");

                    b.ToTable("JobAssignments");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ServiceRequestId")
                        .HasColumnType("int");

                    b.Property<int>("TechnicianId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceRequestId")
                        .IsUnique();

                    b.HasIndex("TechnicianId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 2000,
                            ProductName = "Lavabo Bataryası",
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            Price = 3000,
                            ProductName = "Banyo Bataryası",
                            Quantity = 200
                        },
                        new
                        {
                            Id = 3,
                            Price = 4000,
                            ProductName = "Duş Bataryası",
                            Quantity = 600
                        },
                        new
                        {
                            Id = 4,
                            Price = 7000,
                            ProductName = "Küvet Bataryası",
                            Quantity = 500
                        },
                        new
                        {
                            Id = 5,
                            Price = 2000,
                            ProductName = "Bide Bataryaları",
                            Quantity = 400
                        },
                        new
                        {
                            Id = 6,
                            Price = 9000,
                            ProductName = "Termostatik Bataryalar",
                            Quantity = 200
                        },
                        new
                        {
                            Id = 7,
                            Price = 1000,
                            ProductName = "Musluklar",
                            Quantity = 50
                        });
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.ServiceRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("IssueDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("ServiceRequests");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.Property<bool>("ShowTechnician")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "#fcbdbd",
                            Name = "Açık",
                            Percent = 10,
                            ShowTechnician = false
                        },
                        new
                        {
                            Id = 2,
                            Color = "#fff494",
                            Name = "Onaylandı",
                            Percent = 20,
                            ShowTechnician = false
                        },
                        new
                        {
                            Id = 3,
                            Color = "#fff494",
                            Name = "Atama Bekliyor",
                            Percent = 30,
                            ShowTechnician = false
                        },
                        new
                        {
                            Id = 4,
                            Color = "#fff494",
                            Name = "Teknisyende",
                            Percent = 40,
                            ShowTechnician = true
                        },
                        new
                        {
                            Id = 5,
                            Color = "#c2dfff",
                            Name = "Adrese Geliyor",
                            Percent = 50,
                            ShowTechnician = true
                        },
                        new
                        {
                            Id = 6,
                            Color = "#c2dfff",
                            Name = "Çalışma Yapılıyor",
                            Percent = 60,
                            ShowTechnician = true
                        },
                        new
                        {
                            Id = 7,
                            Color = "#c2dfff",
                            Name = "Ödeme Bekliyor",
                            Percent = 70,
                            ShowTechnician = true
                        },
                        new
                        {
                            Id = 8,
                            Color = "#d2f5b0",
                            Name = "Tamamlandı",
                            Percent = 80,
                            ShowTechnician = true
                        },
                        new
                        {
                            Id = 9,
                            Color = "#d2f5b0",
                            Name = "Oylama Bekliyor",
                            Percent = 90,
                            ShowTechnician = false
                        },
                        new
                        {
                            Id = 10,
                            Color = "#d2f5b0",
                            Name = "Kapandı",
                            Percent = 100,
                            ShowTechnician = false
                        },
                        new
                        {
                            Id = 11,
                            Color = "#c9ccc4",
                            Name = "Reddedildi",
                            Percent = 0,
                            ShowTechnician = false
                        });
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Buca"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Çiğli"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bornova"
                        });
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Models.UserRefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Expriration")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("UserRefreshTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.AppUser", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.Zone", "Zone")
                        .WithMany("AppUsers")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.CustomerFeedback", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.ServiceRequest", "ServiceRequest")
                        .WithOne("CustomerFeedback")
                        .HasForeignKey("FieldServiceManagement.Core.Entities.CustomerFeedback", "ServiceRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceRequest");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.JobAssignment", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.ServiceRequest", "ServiceRequest")
                        .WithOne("JobAssignment")
                        .HasForeignKey("FieldServiceManagement.Core.Entities.JobAssignment", "ServiceRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", "AppUserTechnician")
                        .WithMany("JobAssignments")
                        .HasForeignKey("TechnicianId");

                    b.Navigation("AppUserTechnician");

                    b.Navigation("ServiceRequest");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Payment", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.ServiceRequest", "ServiceRequest")
                        .WithOne("Payment")
                        .HasForeignKey("FieldServiceManagement.Core.Entities.Payment", "ServiceRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", "AppUser")
                        .WithMany("Payments")
                        .HasForeignKey("TechnicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("ServiceRequest");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.ServiceRequest", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", "AppUser")
                        .WithMany("ServiceRequests")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FieldServiceManagement.Core.Entities.Product", "Product")
                        .WithMany("ServiceRequests")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FieldServiceManagement.Core.Entities.Status", "Status")
                        .WithMany("ServiceRequests")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Product");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Models.UserRefreshToken", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", "AppUser")
                        .WithOne("UserRefreshToken")
                        .HasForeignKey("FieldServiceManagement.Core.Models.UserRefreshToken", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FieldServiceManagement.Core.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.AppUser", b =>
                {
                    b.Navigation("JobAssignments");

                    b.Navigation("Payments");

                    b.Navigation("ServiceRequests");

                    b.Navigation("UserRefreshToken");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Product", b =>
                {
                    b.Navigation("ServiceRequests");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.ServiceRequest", b =>
                {
                    b.Navigation("CustomerFeedback");

                    b.Navigation("JobAssignment");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Status", b =>
                {
                    b.Navigation("ServiceRequests");
                });

            modelBuilder.Entity("FieldServiceManagement.Core.Entities.Zone", b =>
                {
                    b.Navigation("AppUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
