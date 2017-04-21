using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummiBear.Migrations
{
    public partial class fixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prodcts",
                table: "Prodcts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Prodcts",
                column: "ProductId");

            migrationBuilder.RenameTable(
                name: "Prodcts",
                newName: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prodcts",
                table: "Products",
                column: "ProductId");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Prodcts");
        }
    }
}
