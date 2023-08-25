using AgendaPessoal.Model;

namespace AgendaPessoal.Repository
{
    public interface IConsulta_Local
    {
        #region Usuario

        Task<List<UsuarioModel>> GetAllUsuario();

        Task<UsuarioModel> GetUsuarioByID(int usuarioModel);

        Task<UsuarioModel> GetUsuarioImageByID(int usuarioModel);

        Task<int> AddUsuario(UsuarioModel usuarioModel);

        Task<int> UpdateUsuario(UsuarioModel usuarioModel);

        Task<int> DeleteUsuario(UsuarioModel usuarioModel);

        #endregion

        #region Contatos

        Task<List<ContatosModel>> GetAllContatos();

        Task<ContatosModel> GetContatosByID(int contatosModel);

        Task<ContatosModel> GetContatosImageByID(int contatosModel);

        Task<int> AddUContatos(ContatosModel contatosModel);

        Task<int> UpdateContatos(ContatosModel contatosModel);

        Task<int> DeleteContatos(ContatosModel contatosModel);

        #endregion
    }
}
