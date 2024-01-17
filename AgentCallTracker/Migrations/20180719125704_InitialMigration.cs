using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgentCallTracker.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentCallTrace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgentTraceId = table.Column<Guid>(nullable: false),
                    CallTraceBeginTime = table.Column<DateTime>(nullable: false),
                    CallTraceEndTime = table.Column<DateTime>(nullable: false),
                    AgentId = table.Column<string>(nullable: true),
                    AcdId = table.Column<string>(nullable: true),
                    TelephonyEnterpriseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentCallTrace", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentCallTrace");
        }
    }
}
