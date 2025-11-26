using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoomSkillsWeb.Pages
{
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // For now, just show success message
            // In future, you can add email sending logic here
            TempData["Message"] = "Thank you! We'll get back to you soon.";
            return RedirectToPage();
        }
    }
}
