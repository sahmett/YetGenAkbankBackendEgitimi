using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReDoReMusic.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class create_new_instrument_brand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "InstrumentsDb");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId",
                table: "InstrumentsDb",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentsDb_BrandId",
                table: "InstrumentsDb",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentsDb_Brands_BrandId",
                table: "InstrumentsDb",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentsDb_Brands_BrandId",
                table: "InstrumentsDb");

            migrationBuilder.DropIndex(
                name: "IX_InstrumentsDb_BrandId",
                table: "InstrumentsDb");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "InstrumentsDb");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "InstrumentsDb",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
