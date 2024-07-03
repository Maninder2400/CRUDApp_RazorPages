using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Catagories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        //[BindProperty]
        public Catagory? Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
                Category = _db.Catagories.Find(id);
        }

        public IActionResult OnPost()
        {
            Catagory? catagoryFromDb = _db.Catagories.Find(Category.Id);

            if (catagoryFromDb == null) { return NotFound(); }
            _db.Catagories.Remove(catagoryFromDb);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
