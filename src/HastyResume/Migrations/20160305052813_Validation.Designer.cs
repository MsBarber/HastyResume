using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using HastyResume.Models;

namespace HastyResume.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160305052813_Validation")]
    partial class Validation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HastyResume.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("ContactEmail");

                    b.Property<string>("Edu1_BodyText")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<DateTime>("Edu1_CompletionDate");

                    b.Property<string>("Edu1_SchoolName");

                    b.Property<string>("Edu1_Title");

                    b.Property<string>("Edu2_BodyText")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<DateTime>("Edu2_CompletionDate");

                    b.Property<string>("Edu2_SchoolName");

                    b.Property<string>("Edu2_Title");

                    b.Property<string>("Edu3_BodyText")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<DateTime>("Edu3_CompletionDate");

                    b.Property<string>("Edu3_SchoolName");

                    b.Property<string>("Edu3_Title");

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FacebookLink");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("GithubLink");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("LinkedInLink");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecretLink");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Skill1_ChildSkillOneName");

                    b.Property<int>("Skill1_ChildSkillOnePercent");

                    b.Property<string>("Skill1_ChildSkillThreeName");

                    b.Property<int>("Skill1_ChildSkillThreePercent");

                    b.Property<string>("Skill1_ChildSkillTwoName");

                    b.Property<int>("Skill1_ChildSkillTwoPercent");

                    b.Property<string>("Skill1_ParentSkill");

                    b.Property<string>("Skill2_ChildSkillOneName");

                    b.Property<int>("Skill2_ChildSkillOnePercent");

                    b.Property<string>("Skill2_ChildSkillThreeName");

                    b.Property<int>("Skill2_ChildSkillThreePercent");

                    b.Property<string>("Skill2_ChildSkillTwoName");

                    b.Property<int>("Skill2_ChildSkillTwoPercent");

                    b.Property<string>("Skill2_ParentSkill");

                    b.Property<string>("Skill3_ChildSkillOneName");

                    b.Property<int>("Skill3_ChildSkillOnePercent");

                    b.Property<string>("Skill3_ChildSkillThreeName");

                    b.Property<int>("Skill3_ChildSkillThreePercent");

                    b.Property<string>("Skill3_ChildSkillTwoName");

                    b.Property<int>("Skill3_ChildSkillTwoPercent");

                    b.Property<string>("Skill3_ParentSkill");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("Wrk1_BodyText")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("Wrk1_CompanyName");

                    b.Property<string>("Wrk1_CompanyPosition");

                    b.Property<DateTime>("Wrk1_EndDate");

                    b.Property<DateTime>("Wrk1_StartDate");

                    b.Property<string>("Wrk2_BodyText")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("Wrk2_CompanyName");

                    b.Property<string>("Wrk2_CompanyPosition");

                    b.Property<DateTime>("Wrk2_EndDate");

                    b.Property<DateTime>("Wrk2_StartDate");

                    b.Property<string>("Wrk3_BodyText")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("Wrk3_CompanyName");

                    b.Property<string>("Wrk3_CompanyPosition");

                    b.Property<DateTime>("Wrk3_EndDate");

                    b.Property<DateTime>("Wrk3_StartDate");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HastyResume.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HastyResume.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("HastyResume.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
