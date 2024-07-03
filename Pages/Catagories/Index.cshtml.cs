using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Catagories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Catagory>? CatagoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            CatagoryList = _db.Catagories.ToList(); 
        }
    }
}
