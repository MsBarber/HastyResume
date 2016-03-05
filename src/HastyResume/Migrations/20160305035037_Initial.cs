using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace HastyResume.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                nullable: false);
            migrationBuilder.AddColumn<string>(
                name: "Edu1_BodyText",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu1_CompletionDate",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu1_SchoolName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu1_Title",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu2_BodyText",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu2_CompletionDate",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu2_SchoolName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu2_Title",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu3_BodyText",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu3_CompletionDate",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu3_SchoolName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Edu3_Title",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "GithubLink",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "LinkedInLink",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "SecretLink",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSKillTwoPercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillOneName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillThreeName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillTwoName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ParentSkill",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSKillTwoPercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillOneName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillThreeName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillTwoName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ParentSkill",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSKillTwoPercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillOneName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillThreeName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillTwoName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ParentSkill",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk1_BodyText",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk1_CompanyName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk1_CompanyPosition",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "Wrk1_EndDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<DateTime>(
                name: "Wrk1_StartDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<string>(
                name: "Wrk2_BodyText",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk2_CompanyName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk2_CompanyPosition",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "Wrk2_EndDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<DateTime>(
                name: "Wrk2_StartDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<string>(
                name: "Wrk3_BodyText",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk3_CompanyName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Wrk3_CompanyPosition",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "Wrk3_EndDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<DateTime>(
                name: "Wrk3_StartDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropColumn(name: "Edu1_BodyText", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu1_CompletionDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu1_SchoolName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu1_Title", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu2_BodyText", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu2_CompletionDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu2_SchoolName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu2_Title", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu3_BodyText", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu3_CompletionDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu3_SchoolName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Edu3_Title", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "FacebookLink", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "FirstName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "GithubLink", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "LastName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "LinkedInLink", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "SecretLink", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSKillTwoPercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillOneName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillOnePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillThreeName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillThreePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillTwoName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ParentSkill", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSKillTwoPercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillOneName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillOnePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillThreeName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillThreePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillTwoName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ParentSkill", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSKillTwoPercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillOneName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillOnePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillThreeName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillThreePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillTwoName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ParentSkill", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk1_BodyText", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk1_CompanyName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk1_CompanyPosition", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk1_EndDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk1_StartDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk2_BodyText", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk2_CompanyName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk2_CompanyPosition", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk2_EndDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk2_StartDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk3_BodyText", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk3_CompanyName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk3_CompanyPosition", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk3_EndDate", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Wrk3_StartDate", table: "AspNetUsers");
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserLogins",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
