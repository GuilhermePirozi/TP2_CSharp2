using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex8.Pages {
    public class CityDetailsModel : PageModel {
        public string CityName { get; set; }
        public void OnGet(string cityName) {
            CityName = cityName;
        }
    }
}
