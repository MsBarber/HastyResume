using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace HastyResume.Migrations
{
    public partial class Validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.AlterColumn<int>(
                name: "Skill3_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill3_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill3_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill2_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill2_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill2_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill1_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill1_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "Skill1_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Edu3_CompletionDate",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Edu2_CompletionDate",
                table: "AspNetUsers",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "Edu1_CompletionDate",
                table: "AspNetUsers",
                nullable: false);
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
            migrationBuilder.AlterColumn<string>(
                name: "Skill3_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill3_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill3_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill2_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill2_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill2_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill1_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill1_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Skill1_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Edu3_CompletionDate",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Edu2_CompletionDate",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Edu1_CompletionDate",
                table: "AspNetUsers",
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
