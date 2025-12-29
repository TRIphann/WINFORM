using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JumpArena.Migrations
{
    /// <inheritdoc />
    public partial class FixModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "FullName", "Password", "Username" },
                values: new object[] { "Bích Đú", "Bich@2025", "BichJAGV0003" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NguoiDung",
                keyColumn: "UserID",
                keyValue: 6,
                columns: new[] { "FullName", "Password", "Username" },
                values: new object[] { "Lý Văn Dũng", "Dung@2025", "DungJAGV0003" });
        }
    }
}
