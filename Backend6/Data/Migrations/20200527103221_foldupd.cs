using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Backend6.Data.Migrations
{
    public partial class foldupd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Folders_Folders_ParentId",
                table: "Folders");

            migrationBuilder.DropIndex(
                name: "IX_Folders_ParentId",
                table: "Folders");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Folders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Folders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Folders_ParentId",
                table: "Folders",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Folders_Folders_ParentId",
                table: "Folders",
                column: "ParentId",
                principalTable: "Folders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
