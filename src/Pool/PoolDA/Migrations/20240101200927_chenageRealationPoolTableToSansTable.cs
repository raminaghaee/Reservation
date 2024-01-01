using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolDA.Migrations
{
    /// <inheritdoc />
    public partial class chenageRealationPoolTableToSansTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pool_Pool_PoolId",
                schema: "Pool",
                table: "Pool");

            migrationBuilder.DropIndex(
                name: "IX_Pool_PoolId",
                schema: "Pool",
                table: "Pool");

            migrationBuilder.DropColumn(
                name: "PoolId",
                schema: "Pool",
                table: "Pool");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PoolId",
                schema: "Pool",
                table: "Pool",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pool_PoolId",
                schema: "Pool",
                table: "Pool",
                column: "PoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pool_Pool_PoolId",
                schema: "Pool",
                table: "Pool",
                column: "PoolId",
                principalSchema: "Pool",
                principalTable: "Pool",
                principalColumn: "Id");
        }
    }
}
