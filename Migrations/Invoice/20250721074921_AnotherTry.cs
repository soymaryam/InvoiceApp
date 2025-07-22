using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvoiceApp.Migrations.Invoice
{
    /// <inheritdoc />
    public partial class AnotherTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    IssueDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    DueDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Service = table.Column<string>(type: "TEXT", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", precision: 16, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Address", "ClientName", "DueDate", "Email", "IssueDate", "Number", "Phone", "Quantity", "Service", "Status", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Alaa", new DateOnly(2024, 12, 30), "Alaa@gmail.com", new DateOnly(2024, 12, 26), "100052", "0583997234", 30, "Proofreading", "Paid", 10.00m },
                    { 2, "Khobar", "Nora", null, "Nora@gmail.com", new DateOnly(2025, 1, 15), "100053", "0526679976", 50, "Proofreading", "Pending", 12.00m },
                    { 3, "Khobar", "Anwar", null, "Anwar@gmail.com", new DateOnly(2025, 1, 22), "100054", "0589654997", 6, "Proofreading", "Pending", 12.00m },
                    { 4, "Qassim", "Hala", new DateOnly(2024, 12, 30), "Hala@gmail.com", new DateOnly(2024, 12, 11), "100055", "0588283374", 12, "Proofreading", "Paid", 12.00m },
                    { 5, "Jeddah", "Samar", null, "Samar@gmail.com", new DateOnly(2025, 1, 3), "100056", "0527763834", 16, "Proofreading", "Pending", 10.00m },
                    { 6, "Riyadh", "Sara", new DateOnly(2024, 1, 30), "Sara@gmail.com", new DateOnly(2024, 12, 22), "100057", "0582336556", 14, "Proofreading", "Paid", 12.00m },
                    { 7, "Medina", "Shahad", null, "Shahad@gmail.com", new DateOnly(2025, 1, 10), "100058", "0577743112", 15, "Proofreading", "Pending", 10.00m },
                    { 8, "Abha", "Rasha", new DateOnly(2024, 12, 30), "Rasha@gmail.com", new DateOnly(2024, 12, 17), "100059", "0584455161", 22, "Proofreading", "Paid", 12.00m },
                    { 9, "Qassim", "Aseel", null, "Aseel@gmail.com", new DateOnly(2025, 1, 25), "100060", "0567768899", 21, "Proofreading", "Pending", 12.00m },
                    { 10, "Riyadh", "Razan", null, "Razan@gmail.com", new DateOnly(2025, 1, 25), "100061", "0565567543", 13, "Proofreading", "Pending", 12.00m },
                    { 11, "Makkah", "Fai", null, "Fai@gmail.com", new DateOnly(2025, 1, 13), "100062", "0550537233", 42, "Proofreading", "Pending", 12.00m },
                    { 12, "Jeddah", "Nouf", new DateOnly(2024, 12, 30), "Nouf@gmail.com", new DateOnly(2024, 12, 10), "100063", "058557616", 25, "Proofreading", "Paid", 10.00m },
                    { 13, "Riyadh", "Mada", new DateOnly(2024, 12, 30), "Mada@gmail.com", new DateOnly(2024, 12, 10), "100064", "0582627534", 32, "Proofreading", "Paid", 10.00m },
                    { 14, "Medina", "Abrar", null, "Abrar@gmail.com", new DateOnly(2025, 1, 18), "100065", "0500716634", 36, "Proofreading", "Pending", 12.00m },
                    { 15, "Makkah", "Bayan", new DateOnly(2024, 12, 30), "Bayan@gmail.com", new DateOnly(2024, 12, 7), "100066", "0565566763", 27, "Proofreading", "Paid", 10.00m },
                    { 16, "Qassim", "Raseel", null, "Raseel@gmail.com", new DateOnly(2025, 1, 3), "100067", "0562923776", 19, "Proofreading", "Pending", 12.00m },
                    { 17, "Jeddah", "Sama", null, "Sama@gmail.com", new DateOnly(2025, 1, 7), "100068", "0532726164", 17, "Proofreading", "Pending", 12.00m },
                    { 18, "Khobar", "Rama", new DateOnly(2024, 12, 30), "Rama@gmail.com", new DateOnly(2024, 12, 9), "100069", "0526673176", 24, "Proofreading", "Paid", 12.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
