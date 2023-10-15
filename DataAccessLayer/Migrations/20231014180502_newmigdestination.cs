using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class newmigdestination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feature2s");

            migrationBuilder.AddColumn<string>(
                name: "AuthorWord",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailsComment",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailsComment2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "AuthorWord",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DetailsComment",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DetailsComment2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Destinations");

            migrationBuilder.CreateTable(
                name: "Feature2s",
                columns: table => new
                {
                    Feature2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature2s", x => x.Feature2ID);
                });
        }
    }
}
