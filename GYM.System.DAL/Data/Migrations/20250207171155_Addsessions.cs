using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.System.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addsessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "WalletBalance",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subscription",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Action",
                table: "Player",
                newName: "IsStopped");

            migrationBuilder.RenameColumn(
                name: "Advantage",
                table: "Employees",
                newName: "Bonus");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Receptionist",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Player",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Coach",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Subscription",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IsStopped",
                table: "Player",
                newName: "Action");

            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "Employees",
                newName: "Advantage");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Subscription",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Receptionist",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Player",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "WalletBalance",
                table: "Player",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Coach",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Admin",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
