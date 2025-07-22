using Microsoft.EntityFrameworkCore;
using InvoiceApp.Models;

namespace InvoiceApp.Data
{
    public class InvoiceContext : DbContext
    {

        public DbSet<Invoice> Invoices { get; set; }

        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().HasData(
                new Invoice { Id = 1, Number = "100052", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-26"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 10.00m, Quantity = 30, ClientName = "Alaa", Email = "Alaa@gmail.com", Phone = "0583997234", Address = "Riyadh" },
                new Invoice { Id = 2, Number = "100053", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-15"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 50, ClientName = "Nora", Email = "Nora@gmail.com", Phone = "0526679976", Address = "Khobar" },
                new Invoice { Id = 3, Number = "100054", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-22"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 6, ClientName = "Anwar", Email = "Anwar@gmail.com", Phone = "0589654997", Address = "Khobar" },
                new Invoice { Id = 4, Number = "100055", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-11"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 12.00m, Quantity = 12, ClientName = "Hala", Email = "Hala@gmail.com", Phone = "0588283374", Address = "Qassim" },
                new Invoice { Id = 5, Number = "100056", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-03"), DueDate = null, Service = "Proofreading", UnitPrice = 10.00m, Quantity = 16, ClientName = "Samar", Email = "Samar@gmail.com", Phone = "0527763834", Address = "Jeddah" },
                new Invoice { Id = 6, Number = "100057", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-22"), DueDate = DateOnly.Parse("2024-01-30"), Service = "Proofreading", UnitPrice = 12.00m, Quantity = 14, ClientName = "Sara", Email = "Sara@gmail.com", Phone = "0582336556", Address = "Riyadh" },
                new Invoice { Id = 7, Number = "100058", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-10"), DueDate = null, Service = "Proofreading", UnitPrice = 10.00m, Quantity = 15, ClientName = "Shahad", Email = "Shahad@gmail.com", Phone = "0577743112", Address = "Medina" },
                new Invoice { Id = 8, Number = "100059", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-17"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 12.00m, Quantity = 22, ClientName = "Rasha", Email = "Rasha@gmail.com", Phone = "0584455161", Address = "Abha" },
                new Invoice { Id = 9, Number = "100060", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-25"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 21, ClientName = "Aseel", Email = "Aseel@gmail.com", Phone = "0567768899", Address = "Qassim" },
                new Invoice { Id = 10, Number = "100061", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-25"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 13, ClientName = "Razan", Email = "Razan@gmail.com", Phone = "0565567543", Address = "Riyadh" },
                new Invoice { Id = 11, Number = "100062", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-13"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 42, ClientName = "Fai", Email = "Fai@gmail.com", Phone = "0550537233", Address = "Makkah" },
                new Invoice { Id = 12, Number = "100063", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-10"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 10.00m, Quantity = 25, ClientName = "Nouf", Email = "Nouf@gmail.com", Phone = "058557616", Address = "Jeddah" },
                new Invoice { Id = 13, Number = "100064", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-10"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 10.00m, Quantity = 32, ClientName = "Mada", Email = "Mada@gmail.com", Phone = "0582627534", Address = "Riyadh" },
                new Invoice { Id = 14, Number = "100065", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-18"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 36, ClientName = "Abrar", Email = "Abrar@gmail.com", Phone = "0500716634", Address = "Medina" },
                new Invoice { Id = 15, Number = "100066", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-07"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 10.00m, Quantity = 27, ClientName = "Bayan", Email = "Bayan@gmail.com", Phone = "0565566763", Address = "Makkah" },
                new Invoice { Id = 16, Number = "100067", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-03"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 19, ClientName = "Raseel", Email = "Raseel@gmail.com", Phone = "0562923776", Address = "Qassim" },
                new Invoice { Id = 17, Number = "100068", Status = "Pending", IssueDate = DateOnly.Parse("2025-01-07"), DueDate = null, Service = "Proofreading", UnitPrice = 12.00m, Quantity = 17, ClientName = "Sama", Email = "Sama@gmail.com", Phone = "0532726164", Address = "Jeddah" },
                new Invoice { Id = 18, Number = "100069", Status = "Paid", IssueDate = DateOnly.Parse("2024-12-09"), DueDate = DateOnly.Parse("2024-12-30"), Service = "Proofreading", UnitPrice = 12.00m, Quantity = 24, ClientName = "Rama", Email = "Rama@gmail.com", Phone = "0526673176", Address = "Khobar" }
            );
        }
    }
}
