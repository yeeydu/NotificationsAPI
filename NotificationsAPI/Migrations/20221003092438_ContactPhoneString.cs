using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotificationsAPI.Migrations
{
    public partial class ContactPhoneString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactPhone",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPhone",
                table: "Notifications");
        }
    }
}
