using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterTestimonialAddSocialMediaLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GitHubUrl",
                table: "Testimonials",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedInUrl",
                table: "Testimonials",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PortfolioUrl",
                table: "Testimonials",
                type: "TEXT",
                maxLength: 200,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GitHubUrl",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "LinkedInUrl",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "PortfolioUrl",
                table: "Testimonials");
        }
    }
}
