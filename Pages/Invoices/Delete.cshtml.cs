using InvoiceApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class DeleteModel : PageModel
    {
        private readonly InvoiceContext context;

        public DeleteModel(InvoiceContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet(int id)
        {
            var invoice = context.Invoices.Find(id);
            if (invoice != null)
            {
                context.Invoices.Remove(invoice);
                context.SaveChanges();
            }

            return RedirectToPage("/Invoices/Index");
        }
    }
}
