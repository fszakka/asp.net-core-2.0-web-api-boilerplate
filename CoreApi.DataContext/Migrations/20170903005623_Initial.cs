using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreApi.DataContext.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastAction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UploadedFiles",
                schema: "dbo");
        }
    }
}
