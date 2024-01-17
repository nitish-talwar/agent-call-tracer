using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentCallTracker.API.Migrations
{
    public partial class InitialMigrationChangeFieldType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelephonyEnterpriseId",
                table: "AgentCallTrace",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgentId",
                table: "AgentCallTrace",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AcdId",
                table: "AgentCallTrace",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelephonyEnterpriseId",
                table: "AgentCallTrace",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgentId",
                table: "AgentCallTrace",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AcdId",
                table: "AgentCallTrace",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);
        }
    }
}
