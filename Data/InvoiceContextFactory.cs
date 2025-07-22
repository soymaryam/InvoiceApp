using Microsoft.EntityFrameworkCore;
using InvoiceApp.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace InvoiceApp.Data
{
    public class InvoiceContextFactory : IDesignTimeDbContextFactory<InvoiceContext>
    {
        public InvoiceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<InvoiceContext>();

            optionsBuilder.UseSqlite("Data Source=invoice.db");

            return new InvoiceContext(optionsBuilder.Options);
        }
    }
}
