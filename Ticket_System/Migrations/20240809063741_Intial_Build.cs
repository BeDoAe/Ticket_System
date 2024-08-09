using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ticket_System.Migrations
{
    /// <inheritdoc />
    public partial class Intial_Build : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "073c872b-7656-4ba0-832b-b8b335edf61b", 0, "b74dae9e-4085-4a72-b983-52cc1c85a2ed", "user9@example.com", false, "First9", "Last9", false, null, null, null, "AQAAAAIAAYagAAAAEFlhym9e8z/j7T7GfZwS6W3iZbWdgw9HmSwunKO5dSu/aVaYSnqRwwtJpsBQfR2tYw==", "123-456-7809", false, "69e824ce-aaeb-439f-b662-ab39be3d3899", false, "user9" },
                    { "35a95053-c400-4bde-be0e-005008fba2c1", 0, "1996a8fa-e981-4c53-87a5-331464b5a3f7", "user3@example.com", false, "First3", "Last3", false, null, null, null, "AQAAAAIAAYagAAAAECsw+PjO44ZC/JvRuDoSi11erJWBgXrMerL138dP9/IUPctDaQICc1V/hALSHpkA4g==", "123-456-7803", false, "2319828c-e942-48b5-9540-47c517381e0d", false, "user3" },
                    { "40426122-ad9e-417c-b3fb-5f5163f3658d", 0, "83e71d87-8846-4e0d-a28d-ea4035748b19", "user7@example.com", false, "First7", "Last7", false, null, null, null, "AQAAAAIAAYagAAAAEHsrAsZ+tgXV1+vgy4k71ay0I2/TnByFR6II/RokCkgOhL6yNaDAhj2RC92ciVg65Q==", "123-456-7807", false, "590ea803-b239-499f-a9f3-49714bf4ab03", false, "user7" },
                    { "a4e3a122-4f89-4711-955b-a9f85dbda5aa", 0, "a7a64cac-97b7-422a-b714-b6b2307dc816", "admin@example.com", false, "Admin", "User", false, null, null, null, "AQAAAAIAAYagAAAAEFdVLkOJPsgx7B3BX80q3hTgxKZRTEjhIFx+0NMhOa7zPMr+/7m592OlTdb8iC9MuQ==", "123-456-7890", false, "bcc718b4-99ae-41aa-9194-d84daceaca27", false, "admin" },
                    { "a765c190-f42e-43e8-b6a4-4e9c718c17f4", 0, "3824d260-68ee-426c-9c9c-7739ba913ca1", "user5@example.com", false, "First5", "Last5", false, null, null, null, "AQAAAAIAAYagAAAAEK2vmasVCIQq+fheoMP+wscgEjCLxFveIGTtuJW+K0U6MtvaphcYUC857iEOtc+KVw==", "123-456-7805", false, "08beaac3-cd16-45f4-9fa0-74ca8adb4aec", false, "user5" },
                    { "d15093a4-b26f-4f72-b6da-90ffd7945ea0", 0, "e3b332f5-8e4f-415b-87c4-a8224a9bbad0", "user4@example.com", false, "First4", "Last4", false, null, null, null, "AQAAAAIAAYagAAAAEFcUtUkeZeXVBBAmA4l0E+orWgyxBONpzeLOjKQ8n42DfjOBLfvy00JxeouLXWJl/w==", "123-456-7804", false, "22b39f61-dc89-4398-87a6-8e1cd95be51b", false, "user4" },
                    { "db678632-9559-4d79-92f7-74e77f8e1e9b", 0, "f7d8d53d-b371-4180-9f2a-2df6e6deba42", "user6@example.com", false, "First6", "Last6", false, null, null, null, "AQAAAAIAAYagAAAAEMiTqO1JbK+wfdMp3borlScG81GVG1Jvq3jtnD6/chgzzp/6eMYFONX6G94v0u2z+A==", "123-456-7806", false, "8ce2b38b-6245-4204-a441-8a21ee03f4ee", false, "user6" },
                    { "e4717443-b2b5-4edc-b57a-849f22ef2d37", 0, "c400ed36-bbe1-4a9b-8d83-5d92381684b0", "user2@example.com", false, "First2", "Last2", false, null, null, null, "AQAAAAIAAYagAAAAEOOihvJ0MxtykbfE/c0ozpfepn7ChHNFm3DjLzf5d44ePggI3ln8nuDFEBa0rxh9aA==", "123-456-7802", false, "b3d56057-0b59-4699-990e-572821558674", false, "user2" },
                    { "e67c6059-d986-43ae-9648-433d430c6ec2", 0, "79fb4b48-4fea-4dbe-a6d5-551d99a47068", "user8@example.com", false, "First8", "Last8", false, null, null, null, "AQAAAAIAAYagAAAAEGLrBg+yh6rPKEeyvNP4UR8kQtRg9fVtOusy/a9FZ7YHCHPosvnoVzkqJgeUM1Atig==", "123-456-7808", false, "fa48b7c6-48a3-46a1-9ae9-348a2651a4cb", false, "user8" },
                    { "f677c56a-75db-427c-bbfb-3b120255f238", 0, "35d09367-4062-4eab-86d7-0a240c9d5a8a", "user1@example.com", false, "First1", "Last1", false, null, null, null, "AQAAAAIAAYagAAAAEMaRk8063sHlAG2uujYKMjKNFtl2AckF0WyV5tpHHV+AXGtZfK7r1IfWB2fNGdVboA==", "123-456-7801", false, "af6a9c78-5e6e-4575-bd61-4d21f4da195f", false, "user1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
