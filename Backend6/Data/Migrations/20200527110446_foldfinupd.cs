using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Backend6.Data.Migrations
{
    public partial class foldfinupd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folders_AspNetUsers_CreatorId1",
                table: "Folders");

            migrationBuilder.DropIndex(
                name: "IX_Folders_CreatorId1",
                table: "Folders");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Folders");

            migrationBuilder.DropColumn(
                name: "CreatorId1",
                table: "Folders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Folders",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreatorId1",
                table: "Folders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Folders_CreatorId1",
                table: "Folders",
                column: "CreatorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Folders_AspNetUsers_CreatorId1",
                table: "Folders",
                column: "CreatorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
