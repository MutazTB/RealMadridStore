using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMadridStore.Migrations
{
    public partial class ljf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "bb99cccd-d848-4eea-865c-f55fa8888bdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd586a8f",
                column: "ConcurrencyStamp",
                value: "138b0329-f6bb-46c6-905a-148be0f300cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7661cbad-0136-4fd4-bcc7-db47cddc5511", "AQAAAAEAACcQAAAAEP6r5r07SgzR5NaRQdxX2tPaX5ImfZNAP8niBsYHgeQBve2WDxv1mMykRSbEa1IJRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50ze710",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd8e322f-fc88-4d35-8b3f-300d75819721", "AQAAAAEAACcQAAAAEIO+Ubd1y3M9N62hs3AiqO8iVlmhj8Mrkz2EsuU5lx9Rp69w+nqw0jnSSqh6Gyl+aA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad376a8f",
                column: "ConcurrencyStamp",
                value: "ba6d3d79-7a9f-42d9-b1da-2e531157601f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd586a8f",
                column: "ConcurrencyStamp",
                value: "95f394f7-7501-4d89-a7fc-371d957b8bb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "169808a2-1188-4118-858c-4147c0869565", "AQAAAAEAACcQAAAAEMxAl4AI4cp82h/KmCEaEcZ9aLqEdW2SrVXZWujFGYOaiYbjeMbej3sJ9gMQ4rNOBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a50ze710",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e70a1539-8544-4f11-975a-8fd42ddf18f4", "AQAAAAEAACcQAAAAEEoxV27pPxTrNjUW+HJffn74hw208cu59uLIdpEH68qyG9TV0tm4pUMdIEayAtqG2A==" });
        }
    }
}
