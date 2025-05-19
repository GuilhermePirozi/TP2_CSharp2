using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex2.Pages.CityManager {
    public class CreateCityModel : PageModel {
        public String Mensagem { get; set; }

        public void OnGet() { }
        public void OnPost(String nome) {
            if (!string.IsNullOrEmpty(nome)) {
                Mensagem = $"Cidade cadastrada: {nome}";
            } else {
                Mensagem = "Cadastre uma cidade!";
            }
        }
    }
}
