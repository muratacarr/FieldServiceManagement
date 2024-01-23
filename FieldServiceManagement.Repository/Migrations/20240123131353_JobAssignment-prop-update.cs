using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieldServiceManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class JobAssignmentpropupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAssignments_AspNetUsers_TechnicianId",
                table: "JobAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "JobAssignments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_JobAssignments_AspNetUsers_TechnicianId",
                table: "JobAssignments",
                column: "TechnicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobAssignments_AspNetUsers_TechnicianId",
                table: "JobAssignments");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "JobAssignments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobAssignments_AspNetUsers_TechnicianId",
                table: "JobAssignments",
                column: "TechnicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
