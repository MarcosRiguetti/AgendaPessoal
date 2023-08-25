using SQLite;
using System.ComponentModel.DataAnnotations;

namespace AgendaPessoal.Model
{
    public class UsuarioModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [Required]
        public string Nome { get; set; }

        public string NameImage { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        public byte[] UserAvatar { get; set; }
    }
}
