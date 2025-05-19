using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex3.Pages.CityManager {
    public class CreateCityModel : PageModel {
        public class InputModel {
            [Required]
            [MinLength(3)]
            public string CityName { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string Mensagem { get; set; }

        public void OnGet() { }

        public void OnPost() {
            if (!ModelState.IsValid) {
                return;
            }
            Mensagem = $"Cidade cadastrada: {Input.CityName}";
        }
    }
}
