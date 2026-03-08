using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BadgeSystemRework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "BadgeDefinitions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "BadgeDefinitions");
        }
    }
}
