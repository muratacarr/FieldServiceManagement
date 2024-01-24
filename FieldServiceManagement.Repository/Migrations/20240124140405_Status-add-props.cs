using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieldServiceManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Statusaddprops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowTechnician",
                table: "Statuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#fcbdbd", false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#fff494", false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#fff494", false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#fff494", true });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#c2dfff", true });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#c2dfff", true });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#c2dfff", true });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#d2f5b0", true });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#d2f5b0", false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#d2f5b0", false });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "ShowTechnician" },
                values: new object[] { "#c9ccc4", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "ShowTechnician",
                table: "Statuses");
        }
    }
}
