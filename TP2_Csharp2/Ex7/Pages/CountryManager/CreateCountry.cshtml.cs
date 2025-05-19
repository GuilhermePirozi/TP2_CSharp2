using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex7.Pages.Models;

namespace Ex7.Pages.CountryManager {
    public class CreateCountryModel : PageModel {
        public class InputModel {

            [Required(ErrorMessage = "Campo obrigatório!")]
            [MinLength(3, ErrorMessage = "O nome do país requer no mínimo 3 letras.")]
            public string CountryName { get; set; }

        }

        [BindProperty]
        public List<InputModel> Inputs { get; set; } = new List<InputModel>();

        [BindProperty]
        public List<Country> Paises { get; set; } = new List<Country>(5);


        public void OnGet() {
            for (int i = 0; i < 5; i++) {
                Inputs.Add(new InputModel());
            }
        }
        public void OnPost() {
            if (!ModelState.IsValid) {
                return;
            }

            foreach (var input in Inputs) {
                if (!string.IsNullOrEmpty(input.CountryName)) {
                    Paises.Add(new Country(input.CountryName));
                }
            }

        }
    }
}