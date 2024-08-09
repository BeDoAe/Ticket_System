using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ticket_System.Migrations
{
    /// <inheritdoc />
    public partial class editing_TicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "073c872b-7656-4ba0-832b-b8b335edf61b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35a95053-c400-4bde-be0e-005008fba2c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40426122-ad9e-417c-b3fb-5f5163f3658d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4e3a122-4f89-4711-955b-a9f85dbda5aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a765c190-f42e-43e8-b6a4-4e9c718c17f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d15093a4-b26f-4f72-b6da-90ffd7945ea0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db678632-9559-4d79-92f7-74e77f8e1e9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4717443-b2b5-4edc-b57a-849f22ef2d37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e67c6059-d986-43ae-9648-433d430c6ec2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f677c56a-75db-427c-bbfb-3b120255f238");

            migrationBuilder.DropColumn(
                name: "HtmlContent",
                table: "Tickets");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16b999d7-bddf-43e6-807c-1689afa9667e", 0, "929436ae-e762-40f3-a115-d07875bbbe11", "user2@example.com", false, "First2", "Last2", false, null, null, null, "AQAAAAIAAYagAAAAEHGbVhi2ZVNmeMWn19OtHAb++WDzsELzJDHv88yCYjJvFjBtNFITp8zcr65Ok4HN2A==", "123-456-7802", false, "25bf25b7-ea88-4f0b-b3d7-77579d807c9f", false, "user2" },
                    { "3bb23328-9d39-4990-a7e4-369c543fd084", 0, "43967235-2bc7-4118-8943-a5c518b15948", "user4@example.com", false, "First4", "Last4", false, null, null, null, "AQAAAAIAAYagAAAAEFuyrNW/BEgMZTmz/P+vW30prIOnUP/OkvNJMXuqz9IE3PPK7j8ErI8b4GAy7Nv+zw==", "123-456-7804", false, "06e2222e-122f-4390-87f5-a61dddc2fa57", false, "user4" },
                    { "3bfa5bc0-4a8d-4648-b437-833c079032b1", 0, "6f380e16-7c3a-4157-aff5-1ef1f57d0701", "user3@example.com", false, "First3", "Last3", false, null, null, null, "AQAAAAIAAYagAAAAEKNjsiEAVtwUFSCjKDgNRGitNfqo5Z19hVj6FSRy5i2XjUmKe5jTnYqMnwgi2jtibg==", "123-456-7803", false, "482d4fc7-392d-466a-b445-8dfbf9375ae7", false, "user3" },
                    { "4f0972eb-34b5-45e2-b559-0eb09e54a315", 0, "fd30556b-c014-4e05-a3d2-82845d0ecf1c", "user7@example.com", false, "First7", "Last7", false, null, null, null, "AQAAAAIAAYagAAAAEHd+l2JbD3X5kaEoSDl0xgbNRD4IJ0HL0R9LPgx4ha1wW6QdTJQiHOAMiNS+7qNTgw==", "123-456-7807", false, "b763db06-4b68-42a2-a704-ebf0c64f4500", false, "user7" },
                    { "54704dcc-a919-4b0d-b4a2-fcc1be07a417", 0, "42f51bbd-8b93-459b-b22a-ff0875f21b03", "user8@example.com", false, "First8", "Last8", false, null, null, null, "AQAAAAIAAYagAAAAEGk2cx/uPl0K9cQYf1OjCFNzeI4PXHXyKNejDzGvcRuF7B/oTUaEEeCoPSYNA1QnMg==", "123-456-7808", false, "6a3bf8a8-67ff-4d19-a733-8aeeee39a5cd", false, "user8" },
                    { "6a9fb333-afec-4bf8-987b-00ed7b4398e7", 0, "31d506a3-f736-4fc2-88d1-eff00080ec43", "user1@example.com", false, "First1", "Last1", false, null, null, null, "AQAAAAIAAYagAAAAEP+mfa70CQxKJQvsZSsjYR/p6dyAnKZWlzIeuOTBrm7CXvT9VPSZRMhLEQNTSxwWjw==", "123-456-7801", false, "8b1b5baa-6e09-4ae6-930e-7a59a572f2d4", false, "user1" },
                    { "7883e821-bd84-452b-bdc5-444289aba14e", 0, "b8264380-b963-47c6-8de8-fa065bc4e64b", "user6@example.com", false, "First6", "Last6", false, null, null, null, "AQAAAAIAAYagAAAAELy5Ifsfcq+u7kecSpUguzkK1SmRbuq0eELyBDcBmKiXzKjoZIFosNdJd5YpmDMtMw==", "123-456-7806", false, "db944d09-f877-4890-833d-9595ae98a4aa", false, "user6" },
                    { "7f928501-869a-4002-99c3-de70087e77ff", 0, "7e7aecd7-9906-4a2a-944b-1e604ebb7ffe", "user9@example.com", false, "First9", "Last9", false, null, null, null, "AQAAAAIAAYagAAAAEPCVNFzAc/JuHBfOVxN0eB1be6MhLqG6AdMhsfi1uYaJd21pKug3VhjVfGLoIB/DVA==", "123-456-7809", false, "04607c7b-e89c-4107-81e0-6acf6e046a89", false, "user9" },
                    { "c5c5234a-b8b1-4495-9be4-bbee52ce306e", 0, "5b18becd-1b3d-4832-aa54-d41840bdb393", "admin@example.com", false, "Admin", "User", false, null, null, null, "AQAAAAIAAYagAAAAEBEKVCnHnZzPNZWn4LkFUFMVajVSNy4MZJlxoz4jYztBntlwT2yyNYYf1EhuiBWp6w==", "123-456-7890", false, "70664c97-19a4-468d-8ad4-c1950e85ceeb", false, "admin" },
                    { "cf82fe9f-4082-4658-8463-9e23833638e4", 0, "e1aa116f-6c30-4f73-8135-f81aeeca3482", "user5@example.com", false, "First5", "Last5", false, null, null, null, "AQAAAAIAAYagAAAAEHwhPWw+EljmjwKpzjMvOUUX8hzA2BhCZb7NEfdkwfJMoM1iqN/0+ZUqpOFw/CZo8w==", "123-456-7805", false, "61150c26-7a85-466a-9e6c-5666103df76a", false, "user5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16b999d7-bddf-43e6-807c-1689afa9667e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bb23328-9d39-4990-a7e4-369c543fd084");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bfa5bc0-4a8d-4648-b437-833c079032b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f0972eb-34b5-45e2-b559-0eb09e54a315");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54704dcc-a919-4b0d-b4a2-fcc1be07a417");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a9fb333-afec-4bf8-987b-00ed7b4398e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7883e821-bd84-452b-bdc5-444289aba14e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f928501-869a-4002-99c3-de70087e77ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5c5234a-b8b1-4495-9be4-bbee52ce306e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf82fe9f-4082-4658-8463-9e23833638e4");

            migrationBuilder.AddColumn<string>(
                name: "HtmlContent",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
        }
    }
}
