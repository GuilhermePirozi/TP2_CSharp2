using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex12.Pages.Models;

namespace Ex12.Pages.CountryManager {
    public class CreateCountryModel : PageModel {
        public class InputModel {

            [Required(ErrorMessage = "Campo obrigatório!")]
            [MinLength(3, ErrorMessage = "O nome do país requer no mínimo 3 letras.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "Campo obrigatório!")]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "O código do país requer no máximo 2 letras.")]
            public string CountryCode { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [BindProperty]
        public string Mensagem { get; set; }

        public void OnGet() { }
        public void OnPost() {

            if (Input.CountryName.Substring(0, 1) == Input.CountryCode.Substring(0, 1)) {
                Country country = new Country(Input.CountryName, Input.CountryCode);
                Mensagem = $"Nome do País: {country.CountryName} | Código do País: {country.CountryCode}";
            } else {
                ModelState.AddModelError("Input.CountryName", "O primeiro caractere de CountryName deve ser igual ao de CountryCode.");
            }
        }
    }
}
