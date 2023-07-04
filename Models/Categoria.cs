using System.ComponentModel.DataAnnotations;

namespace lotusApi.Models{
    
    public class Categoria{

        [Key]
        public int Ramal{get; set;}

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(6, ErrorMessage = "O nome deve ter pelo menos 6 caracteres")]
        public String Nome{get; set;}

        public String Setor{get; set;}

        public String Email{get; set;}

        // public String Cpf{get; set;}

        public String Cell{get; set;}
    }
}