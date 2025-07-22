using InvoiceApp.Models;
using InvoiceApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly InvoiceContext context;

        public List<Invoice> invoiceList = new();
        public IndexModel(InvoiceContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            invoiceList = context.Invoices.OrderByDescending(i => i.Id).ToList();
        }
    }
}
