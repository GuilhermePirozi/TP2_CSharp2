using System.ComponentModel.DataAnnotations;
using Ex5.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex5.Pages.CountryManager {
    public class CreateCountryModel : PageModel {
        public class InputModel {

            [Required(ErrorMessage = "Campo obrigat�rio!")]
            [MinLength(3, ErrorMessage = "O nome do pa�s precisa ter no m�nimo 3 letras.")]
            public string CountryName { get; set; }

            [Required(ErrorMessage = "Campo obrigat�rio!")]
            public string CountryCode { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [BindProperty]
        public string Mensagem { get; set; }

        public void OnGet() { }
        public void OnPost() {

            Country country = new Country(Input.CountryName, Input.CountryCode);
            Mensagem = $"Nome do Pa�s: {country.CountryName} | C�digo do Pa�s: {country.CountryCode}";
        }
    }
}
