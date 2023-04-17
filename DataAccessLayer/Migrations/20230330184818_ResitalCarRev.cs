using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class ResitalCarRev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonial_Customers_CustomerId",
                table: "Testimonial");

            migrationBuilder.DropTable(
                name: "GuideTour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial");

            migrationBuilder.DropColumn(
                name: "AvailableCar",
                table: "CarCompanies");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CarCompanies");

            migrationBuilder.RenameTable(
                name: "Testimonial",
                newName: "Testimonials");

            migrationBuilder.RenameIndex(
                name: "IX_Testimonial_CustomerId",
                table: "Testimonials",
                newName: "IX_Testimonials_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AvailableCarId",
                table: "CarCompanies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GuideId",
                table: "Tours",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Customers_CustomerId",
                table: "Testimonials",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Guides_GuideId",
                table: "Tours",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Customers_CustomerId",
                table: "Testimonials");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Guides_GuideId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_GuideId",
                table: "Tours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "AvailableCarId",
                table: "CarCompanies");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "Testimonial");

            migrationBuilder.RenameIndex(
                name: "IX_Testimonials_CustomerId",
                table: "Testimonial",
                newName: "IX_Testimonial_CustomerId");

            migrationBuilder.AddColumn<string>(
                name: "AvailableCar",
                table: "CarCompanies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CarCompanies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonial",
                table: "Testimonial",
                column: "TestimonialId");

            migrationBuilder.CreateTable(
                name: "GuideTour",
                columns: table => new
                {
                    GuidesGuideId = table.Column<int>(type: "int", nullable: false),
                    ToursTourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuideTour", x => new { x.GuidesGuideId, x.ToursTourId });
                    table.ForeignKey(
                        name: "FK_GuideTour_Guides_GuidesGuideId",
                        column: x => x.GuidesGuideId,
                        principalTable: "Guides",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuideTour_Tours_ToursTourId",
                        column: x => x.ToursTourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuideTour_ToursTourId",
                table: "GuideTour",
                column: "ToursTourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonial_Customers_CustomerId",
                table: "Testimonial",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
