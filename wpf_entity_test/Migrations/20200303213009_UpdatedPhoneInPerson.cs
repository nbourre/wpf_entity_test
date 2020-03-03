using Microsoft.EntityFrameworkCore.Migrations;

namespace wpf_entity_test.Migrations
{
    public partial class UpdatedPhoneInPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "People");
        }
    }
}
