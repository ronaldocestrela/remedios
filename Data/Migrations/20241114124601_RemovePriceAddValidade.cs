using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeRemedio.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovePriceAddValidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Medicamento");

            migrationBuilder.AddColumn<DateTime>(
                name: "Validade",
                table: "Medicamento",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Validade",
                table: "Medicamento");

            migrationBuilder.AddColumn<float>(
                name: "Preco",
                table: "Medicamento",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
