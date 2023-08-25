using SQLite;
using System.ComponentModel.DataAnnotations;

namespace AgendaPessoal.Model
{
    public class ContatosModel
    {
        [PrimaryKey, AutoIncrement]
        public int ContatoID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Telefone { get; set; }

        public string Telefone2 { get; set; }

        public string NameImage { get; set; }

        public byte[] UserAvatar { get; set; }

        public DateTime Aniversario { get; set; }
    }
}
