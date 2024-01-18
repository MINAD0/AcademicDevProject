using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicDev.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProjectToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrjName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false), // Adjust the length as needed
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false), // Adjust the length as needed
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false), // Adjust the length as needed
                    GithubLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false) // Adjust the length as needed
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "PrjName", "Description", "Image", "GithubLink" },
                values: new object[,]
                {
                     { 1, "ChatApp", "Real-time chat application", "chatapp.jpg", "https://github.com/yourusername/ChatApp" },
                     { 2, "TaskManager", "Simple task management system", "taskmanager.png", "https://github.com/yourusername/TaskManager" },
                     { 3, "ECommerceSite", "Online e-commerce platform", "ecommercesite.jpg", "https://github.com/yourusername/ECommerceSite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
