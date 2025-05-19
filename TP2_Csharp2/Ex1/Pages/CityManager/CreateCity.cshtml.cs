using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex1.Pages.CityManager {
    public class CreateCityModel : PageModel {
        [BindProperty]
        public String CityName { get; set; }

        public void onGet() { }
        public void OnPost() { }
    }
}
