using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace HastyResume.Migrations
{
    public partial class WordsToNumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillOneName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillOnePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillThreeName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillThreePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillTwoName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkillTwoPercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillOneName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillOnePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillThreeName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillThreePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillTwoName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkillTwoPercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillOneName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillOnePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillThreeName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillThreePercent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillTwoName", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkillTwoPercent", table: "AspNetUsers");
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkill1Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill1_ChildSkill1Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkill2Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill1_ChildSkill2Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkill3Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill1_ChildSkill3Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkill1Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill2_ChildSkill1Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkill2Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill2_ChildSkill2Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkill3Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill2_ChildSkill3Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkill1Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill3_ChildSkill1Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkill2Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill3_ChildSkill2Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkill3Name",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill3_ChildSkill3Percent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
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
            migrationBuilder.DropColumn(name: "Skill1_ChildSkill1Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkill1Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkill2Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkill2Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkill3Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill1_ChildSkill3Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkill1Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkill1Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkill2Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkill2Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkill3Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill2_ChildSkill3Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkill1Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkill1Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkill2Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkill2Percent", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkill3Name", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "Skill3_ChildSkill3Percent", table: "AspNetUsers");
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillOneName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill1_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillThreeName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill1_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill1_ChildSkillTwoName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill1_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillOneName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill2_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillThreeName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill2_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill2_ChildSkillTwoName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill2_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillOneName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill3_ChildSkillOnePercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillThreeName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill3_ChildSkillThreePercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Skill3_ChildSkillTwoName",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Skill3_ChildSkillTwoPercent",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
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
