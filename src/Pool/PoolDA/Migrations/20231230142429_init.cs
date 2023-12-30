using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolDA.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Pool");

            migrationBuilder.CreateTable(
                name: "Constant",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActived = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pool",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pool", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sans",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoolId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeekId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<string>(type: "NCHAR(5)", nullable: false),
                    EndTime = table.Column<string>(type: "NCHAR(5)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sans_Pool_PoolId",
                        column: x => x.PoolId,
                        principalSchema: "Pool",
                        principalTable: "Pool",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoolId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(11,2)", precision: 11, scale: 2, nullable: false),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Pool_PoolId",
                        column: x => x.PoolId,
                        principalSchema: "Pool",
                        principalTable: "Pool",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoolId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    TicketTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(11,2)", precision: 11, scale: 2, nullable: false),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Pool",
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ticket_Pool_PoolId",
                        column: x => x.PoolId,
                        principalSchema: "Pool",
                        principalTable: "Pool",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pay",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<string>(type: "NCHAR(10)", nullable: false),
                    CreateTime = table.Column<string>(type: "NCHAR(5)", nullable: false),
                    TicketTypeId = table.Column<int>(type: "int", nullable: false),
                    PayTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateTypeId = table.Column<int>(type: "int", nullable: false),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pay_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalSchema: "Pool",
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserved",
                schema: "Pool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoolId = table.Column<int>(type: "int", nullable: false),
                    SansId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    IsConfirm = table.Column<int>(type: "int", nullable: false),
                    ConfirmDate = table.Column<string>(type: "NCHAR(10)", nullable: false),
                    ConfirmTime = table.Column<string>(type: "NCHAR(5)", nullable: false),
                    CreateDate = table.Column<string>(type: "NCHAR(10)", nullable: false),
                    CreateTime = table.Column<string>(type: "NCHAR(5)", nullable: false),
                    CreateTypeId = table.Column<int>(type: "int", nullable: false),
                    ActivedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserved", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserved_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Pool",
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reserved_Pool_PoolId",
                        column: x => x.PoolId,
                        principalSchema: "Pool",
                        principalTable: "Pool",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reserved_Sans_SansId",
                        column: x => x.SansId,
                        principalSchema: "Pool",
                        principalTable: "Sans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reserved_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalSchema: "Pool",
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserved_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PoolId",
                schema: "Pool",
                table: "Employee",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                schema: "Pool",
                table: "Employee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pay_TicketId",
                schema: "Pool",
                table: "Pay",
                column: "TicketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_EmployeeId",
                schema: "Pool",
                table: "Reserved",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_PoolId",
                schema: "Pool",
                table: "Reserved",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_SansId",
                schema: "Pool",
                table: "Reserved",
                column: "SansId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_TicketId",
                schema: "Pool",
                table: "Reserved",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_UserId",
                schema: "Pool",
                table: "Reserved",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sans_PoolId",
                schema: "Pool",
                table: "Sans",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EmployeeId",
                schema: "Pool",
                table: "Ticket",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PoolId",
                schema: "Pool",
                table: "Ticket",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                schema: "Pool",
                table: "Ticket",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constant",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "Pay",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "Reserved",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "Sans",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "Ticket",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "Pool",
                schema: "Pool");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
