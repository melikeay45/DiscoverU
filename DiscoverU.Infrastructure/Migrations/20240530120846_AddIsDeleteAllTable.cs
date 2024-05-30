using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiscoverU.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeleteAllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Question_QuestionId1",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_QuestionId1",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "QuestionId1",
                table: "Options");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Surveys",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Responses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Question",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "QuestionId",
                table: "Options",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Options",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Question_QuestionId",
                table: "Options",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Question_QuestionId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_QuestionId",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Options");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Options",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionId1",
                table: "Options",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId1",
                table: "Options",
                column: "QuestionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Question_QuestionId1",
                table: "Options",
                column: "QuestionId1",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
