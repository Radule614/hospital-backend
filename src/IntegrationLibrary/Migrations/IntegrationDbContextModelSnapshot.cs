﻿// <auto-generated />
using System;
using IntegrationLibrary.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IntegrationLibrary.Migrations
{
    [DbContext(typeof(IntegrationDbContext))]
    partial class IntegrationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("IntegrationLibrary.Features.BloodBank.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AppName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Server")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AppName = "app1",
                            Email = "darkoo59@gmail.com",
                            Password = "123",
                            Server = "localhost:5555"
                        },
                        new
                        {
                            Id = 2,
                            AppName = "app2",
                            Email = "darko.selakovic11@gmail.com",
                            Password = "123",
                            Server = "localhost:6555"
                        },
                        new
                        {
                            Id = 3,
                            AppName = "app3",
                            Email = "darkoo59bet@gmail.com",
                            Password = "123",
                            Server = "localhost:7555"
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.BloodBankNews.Model.BankNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BankNews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "sadrzaj vijesti 1",
                            State = 0,
                            Title = "vijest 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "sadrzaj vijesti 2",
                            State = 2,
                            Title = "vijest 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "sadrzaj vijesti 3",
                            State = 1,
                            Title = "vijest 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "sadrzaj vijesti 4",
                            State = 0,
                            Title = "vijest 4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "sadrzaj vijesti 5",
                            State = 2,
                            Title = "vijest 5"
                        },
                        new
                        {
                            Id = 6,
                            Content = "sadrzaj vijesti 6",
                            State = 0,
                            Title = "vijest 6"
                        },
                        new
                        {
                            Id = 7,
                            Content = "sadrzaj vijesti 7",
                            State = 0,
                            Title = "vijest 7"
                        },
                        new
                        {
                            Id = 8,
                            Content = "sadrzaj vijesti 8",
                            State = 0,
                            Title = "vijest 8"
                        },
                        new
                        {
                            Id = 9,
                            Content = "sadrzaj vijesti 9",
                            State = 1,
                            Title = "vijest 9"
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.BloodRequests.Model.BloodRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("QuantityInLiters")
                        .HasColumnType("double precision");

                    b.Property<string>("ReasonForAdjustment")
                        .HasColumnType("text");

                    b.Property<string>("ReasonForRequest")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<bool>("Urgent")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("BloodRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodType = 0,
                            DoctorId = 1,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 1.0,
                            ReasonForRequest = "treba 1",
                            State = 0,
                            Urgent = false
                        },
                        new
                        {
                            Id = 2,
                            BloodType = 2,
                            DoctorId = 1,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 4.0,
                            ReasonForRequest = "treba 2",
                            State = 1,
                            Urgent = false
                        },
                        new
                        {
                            Id = 3,
                            BloodType = 7,
                            DoctorId = 2,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 9.0,
                            ReasonForRequest = "treba 3",
                            State = 2,
                            Urgent = false
                        },
                        new
                        {
                            Id = 4,
                            BloodType = 7,
                            DoctorId = 3,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 12.0,
                            ReasonForAdjustment = "Ne moze",
                            ReasonForRequest = "treba 4",
                            State = 3,
                            Urgent = false
                        },
                        new
                        {
                            Id = 5,
                            BloodType = 0,
                            DoctorId = 1,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 1.0,
                            ReasonForRequest = "treba 5",
                            State = 0,
                            Urgent = false
                        },
                        new
                        {
                            Id = 6,
                            BloodType = 2,
                            DoctorId = 1,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 4.0,
                            ReasonForRequest = "treba 6",
                            State = 1,
                            Urgent = false
                        },
                        new
                        {
                            Id = 7,
                            BloodType = 7,
                            DoctorId = 2,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 9.0,
                            ReasonForRequest = "treba 7",
                            State = 2,
                            Urgent = false
                        },
                        new
                        {
                            Id = 8,
                            BloodType = 7,
                            DoctorId = 3,
                            FinalDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QuantityInLiters = 12.0,
                            ReasonForAdjustment = "Ne moze 2",
                            ReasonForRequest = "treba 8",
                            State = 3,
                            Urgent = false
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.EquipmentTender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ExpiresOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EquipmentTenders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Congue nisi vitae suscipit tellus mauris. Et leo duis ut diam quam nulla. Porttitor eget dolor morbi non arcu risus quis. Tempor nec feugiat nisl pretium. Pharetra et ultrices neque ornare aenean euismod elementum nisi. Dui sapien eget mi proin sed libero enim sed faucibus. Vitae turpis massa sed elementum tempus. Urna molestie at elementum eu facilisis sed. Nisl nisi scelerisque eu ultrices vitae auctor eu augue ut. Facilisi cras fermentum odio eu feugiat. Rhoncus aenean vel elit scelerisque. Eget nunc scelerisque viverra mauris in aliquam. Blandit libero volutpat sed cras ornare. Tellus elementum sagittis vitae et leo duis. Est lorem ipsum dolor sit amet consectetur. Ullamcorper malesuada proin libero nunc consequat interdum varius.",
                            ExpiresOn = new DateTime(2023, 2, 14, 22, 42, 33, 965, DateTimeKind.Local).AddTicks(8047),
                            State = 0,
                            Title = "Tender 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Egestas congue quisque egestas diam in. Pretium aenean pharetra magna ac placerat. Ultrices neque ornare aenean euismod. Eget felis eget nunc lobortis mattis aliquam faucibus purus. Ac feugiat sed lectus vestibulum. Mi proin sed libero enim sed faucibus turpis in eu. Et molestie ac feugiat sed lectus vestibulum mattis ullamcorper. Enim ut tellus elementum sagittis vitae et.",
                            ExpiresOn = new DateTime(2023, 2, 14, 22, 42, 33, 981, DateTimeKind.Local).AddTicks(1449),
                            State = 0,
                            Title = "Tender 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Nisl nisi scelerisque eu ultrices vitae auctor eu augue ut. Facilisi cras fermentum odio eu feugiat. Rhoncus aenean vel elit scelerisque. Eget nunc scelerisque viverra mauris in aliquam. Blandit libero volutpat sed cras ornare. Tellus elementum sagittis vitae et leo duis. Est lorem ipsum dolor sit amet consectetur. Ullamcorper malesuada proin libero nunc consequat interdum varius.",
                            ExpiresOn = new DateTime(2023, 2, 14, 22, 42, 33, 981, DateTimeKind.Local).AddTicks(1859),
                            State = 0,
                            Title = "Tender 3"
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EquipmentTenderId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Finished")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("HasWon")
                        .HasColumnType("boolean");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentTenderId");

                    b.HasIndex("UserId");

                    b.ToTable("TenderApplications");
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double?>("Money")
                        .HasColumnType("double precision");

                    b.Property<int>("TenderApplicationId")
                        .HasColumnType("integer");

                    b.Property<int>("TenderRequirementId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TenderApplicationId");

                    b.HasIndex("TenderRequirementId");

                    b.ToTable("TenderOffers");
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<int>("EquipmentTenderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentTenderId");

                    b.ToTable("TenderRequirements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 150.0,
                            BloodType = 0,
                            EquipmentTenderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100.0,
                            BloodType = 2,
                            EquipmentTenderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 250.0,
                            BloodType = 1,
                            EquipmentTenderId = 2
                        },
                        new
                        {
                            Id = 4,
                            Amount = 350.0,
                            BloodType = 6,
                            EquipmentTenderId = 2
                        },
                        new
                        {
                            Id = 5,
                            Amount = 120.0,
                            BloodType = 4,
                            EquipmentTenderId = 3
                        },
                        new
                        {
                            Id = 6,
                            Amount = 230.0,
                            BloodType = 5,
                            EquipmentTenderId = 3
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.ManagerNotification.Model.ManagersNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ManagerNotification");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is test notification",
                            Title = "Test notification"
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.MonthlyBloodSubscription.Model.BloodSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BloodBankId")
                        .HasColumnType("integer");

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<double>("QuantityInLiters")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("BloodSubscription");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodBankId = 1,
                            BloodType = 0,
                            QuantityInLiters = 1.0,
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.ReportConfigurations.Model.ReportConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BloodBankId")
                        .HasColumnType("integer");

                    b.Property<string>("ReportFrequency")
                        .HasColumnType("text");

                    b.Property<int>("ReportPeriod")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BloodBankId")
                        .IsUnique();

                    b.ToTable("ReportConfigurations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodBankId = 2,
                            ReportFrequency = "* * * * *",
                            ReportPeriod = 3
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.UrgentBloodOrder.Model.UrgentOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BloodBankName")
                        .HasColumnType("text");

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Quantity")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("UrgentOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BloodBankName = "app2",
                            BloodType = 0,
                            Date = new DateTime(2022, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 100.0
                        },
                        new
                        {
                            Id = 2,
                            BloodBankName = "app1",
                            BloodType = 3,
                            Date = new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 80.0
                        },
                        new
                        {
                            Id = 3,
                            BloodBankName = "app2",
                            BloodType = 6,
                            Date = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 160.0
                        },
                        new
                        {
                            Id = 4,
                            BloodBankName = "app3",
                            BloodType = 4,
                            Date = new DateTime(2022, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quantity = 310.0
                        });
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderApplication", b =>
                {
                    b.HasOne("IntegrationLibrary.Features.EquipmentTenders.Domain.EquipmentTender", "EquipmentTender")
                        .WithMany("TenderApplications")
                        .HasForeignKey("EquipmentTenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntegrationLibrary.Features.BloodBank.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentTender");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderOffer", b =>
                {
                    b.HasOne("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderApplication", null)
                        .WithMany("TenderOffers")
                        .HasForeignKey("TenderApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderRequirement", "TenderRequirement")
                        .WithMany()
                        .HasForeignKey("TenderRequirementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TenderRequirement");
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderRequirement", b =>
                {
                    b.HasOne("IntegrationLibrary.Features.EquipmentTenders.Domain.EquipmentTender", null)
                        .WithMany("TenderRequirements")
                        .HasForeignKey("EquipmentTenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.EquipmentTender", b =>
                {
                    b.Navigation("TenderApplications");

                    b.Navigation("TenderRequirements");
                });

            modelBuilder.Entity("IntegrationLibrary.Features.EquipmentTenders.Domain.TenderApplication", b =>
                {
                    b.Navigation("TenderOffers");
                });
#pragma warning restore 612, 618
        }
    }
}
