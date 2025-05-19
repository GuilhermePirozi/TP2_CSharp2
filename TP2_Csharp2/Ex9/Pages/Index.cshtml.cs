using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex9.Pages {
    public class IndexModel : PageModel {

        public List<string> Cities = ["Rio", "São Paulo", "Brasília"];
        public void OnGet() {

        }
    }
}
