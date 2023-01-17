using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace cleanarch.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Logo = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    Commission = table.Column<double>(type: "double precision", nullable: false),
                    CommissionType = table.Column<double>(type: "double precision", nullable: false),
                    OpeningTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClosingTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    OffDay = table.Column<string>(type: "text", nullable: false),
                    DeliveryCharge = table.Column<double>(type: "double precision", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    OrderCount = table.Column<int>(type: "integer", nullable: false),
                    VendorId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ZoneId = table.Column<Guid>(type: "uuid", nullable: false),
                    SurgeZoneId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsUpfrontPayment = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
