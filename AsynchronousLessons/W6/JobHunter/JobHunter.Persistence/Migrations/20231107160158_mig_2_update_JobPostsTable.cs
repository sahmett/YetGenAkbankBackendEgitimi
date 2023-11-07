using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobHunter.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2_update_JobPostsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "JobPosts",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "JobPosts");
        }
    }
}
