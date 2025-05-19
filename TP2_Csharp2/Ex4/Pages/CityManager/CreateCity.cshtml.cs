using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex4.Pages.CityManager {
    public class CreateCityModel : PageModel {
        public class InputModel {
            [Required(ErrorMessage = "Campo obrigat�rio!")]
            [MinLength(3, ErrorMessage = "O nome da cidade precisa ter no m�nimo 3 letras.")]
            public string CityName { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string Mensagem { get; set; }

        public void OnGet() { }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page(); 
            }

            Mensagem = $"Cidade cadastrada: {Input.CityName}";
            return RedirectToPage(); 
        }
    }
}
