﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ApplicationTEST.Migrations
{
    public partial class access_data7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Langues_Offres_offreid",
                table: "Langues");

            migrationBuilder.AlterColumn<int>(
                name: "offreid",
                table: "Langues",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Langues_Offres_offreid",
                table: "Langues",
                column: "offreid",
                principalTable: "Offres",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Langues_Offres_offreid",
                table: "Langues");

            migrationBuilder.AlterColumn<int>(
                name: "offreid",
                table: "Langues",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Langues_Offres_offreid",
                table: "Langues",
                column: "offreid",
                principalTable: "Offres",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
