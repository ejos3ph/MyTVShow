using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTVShow.Migrations
{
    public partial class AddReleaseDate_ImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TvShow",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImdbUrl",
                table: "TvShow",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "TvShow",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "TvShow",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "TvShow");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "TvShow");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TvShow",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "ImdbUrl",
                table: "TvShow",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
