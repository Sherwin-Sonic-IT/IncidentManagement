using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IncidentManagement.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Board_TBL",
                columns: table => new
                {
                    Comment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Resolver_ID = table.Column<int>(type: "int", nullable: false),
                    Incident_ID = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageVideoData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ParentCommentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_TBL", x => x.Comment_ID);
                });

            migrationBuilder.CreateTable(
                name: "Incidents_TBL",
                columns: table => new
                {
                    Incident_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Resolver_ID = table.Column<int>(type: "int", nullable: false),
                    Incident_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Incident_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_Head = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Reported = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reported_By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resolver_From_Dept = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resolver_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Pending")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents_TBL", x => x.Incident_ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroupHeaderM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroupHeaderM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRoleM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRoleM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserM",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    LoginStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleGroupId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_Head = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateStatus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteCodes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChangePassOnLogin = table.Column<bool>(type: "bit", nullable: false),
                    IsCantChangePass = table.Column<bool>(type: "bit", nullable: false),
                    IsPasswordNeverExpires = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserM", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserM_RoleGroupHeaderM_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "RoleGroupHeaderM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserM_StatusM_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroupDetailM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleGroupHeaderMId = table.Column<int>(type: "int", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    SystemRoleId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroupDetailM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleGroupDetailM_ApplicationM_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleGroupDetailM_RoleGroupHeaderM_RoleGroupHeaderMId",
                        column: x => x.RoleGroupHeaderMId,
                        principalTable: "RoleGroupHeaderM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleGroupDetailM_SystemRoleM_SystemRoleId",
                        column: x => x.SystemRoleId,
                        principalTable: "SystemRoleM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StatusM",
                columns: new[] { "Id", "Status_Desc", "Status_Name" },
                values: new object[,]
                {
                    { 1, "Active", "Y" },
                    { 2, "Inactive", "N" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleGroupDetailM_ApplicationId",
                table: "RoleGroupDetailM",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleGroupDetailM_RoleGroupHeaderMId",
                table: "RoleGroupDetailM",
                column: "RoleGroupHeaderMId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleGroupDetailM_SystemRoleId",
                table: "RoleGroupDetailM",
                column: "SystemRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserM_RoleGroupId",
                table: "UserM",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserM_StatusId",
                table: "UserM",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Board_TBL");

            migrationBuilder.DropTable(
                name: "Incidents_TBL");

            migrationBuilder.DropTable(
                name: "RoleGroupDetailM");

            migrationBuilder.DropTable(
                name: "UserM");

            migrationBuilder.DropTable(
                name: "ApplicationM");

            migrationBuilder.DropTable(
                name: "SystemRoleM");

            migrationBuilder.DropTable(
                name: "RoleGroupHeaderM");

            migrationBuilder.DropTable(
                name: "StatusM");
        }
    }
}
