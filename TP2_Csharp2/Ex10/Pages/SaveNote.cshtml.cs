using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace Ex10.Pages {
    public class SaveNoteModel : PageModel {
        public class InputModel {
            [Required]
            public string Content { get; set; }
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string Caminho { get; set; }

        public void OnGet() { }

        public void OnPost() {
            if (!ModelState.IsValid)
                return;

            string timestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            string nomeArquivo = $"note-{timestamp}.txt";

            string pasta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string caminhoCompleto = Path.Combine(pasta, nomeArquivo);

            using (StreamWriter escrever = new StreamWriter(caminhoCompleto)) {
                escrever.WriteLine(Input.Content);
            }

            Caminho = $"/files/{nomeArquivo}";
        }
    }
}
