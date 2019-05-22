using Microsoft.EntityFrameworkCore.Migrations;

namespace efcore_inmemory_webapi.Migrations
{
    public partial class AddPostRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
