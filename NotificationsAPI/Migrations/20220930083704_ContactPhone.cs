using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotificationsAPI.Migrations
{
    public partial class ContactPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactPhone",
                table: "Notifications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPhone",
                table: "Notifications");
        }
    }
}
