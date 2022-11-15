using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MillionaireWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddPrizeLevelGuaranteedCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGuaranteed",
                table: "PrizeLevel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGuaranteed",
                table: "PrizeLevel");
        }
    }
}
