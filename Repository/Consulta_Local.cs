using AgendaPessoal.Model;
using SQLite;

namespace AgendaPessoal.Repository
{
    public class Consulta_Local : IConsulta_Local
    {
        private SQLiteAsyncConnection _dbConnection;

        public Consulta_Local()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            try
            {
                if (_dbConnection == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Agenda.db3");
                    _dbConnection = new SQLiteAsyncConnection(dbPath);
                    await _dbConnection.CreateTablesAsync<UsuarioModel, ContatosModel>();           
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Usuario

        public async Task<int> AddUsuario(UsuarioModel usuarioModel)
        {
            return await _dbConnection.InsertAsync(usuarioModel);
        }

        public async Task<int> DeleteUsuario(UsuarioModel usuarioModel)
        {
            return await _dbConnection.DeleteAsync(usuarioModel);
        }

        public async Task<List<UsuarioModel>> GetAllUsuario()
        {
            return await _dbConnection.Table<UsuarioModel>().ToListAsync();
        }

        public async Task<int> UpdateUsuario(UsuarioModel usuarioModel)
        {
            return await _dbConnection.UpdateAsync(usuarioModel);
        }

        public async Task<UsuarioModel> GetUsuarioByID(int IdUsuario)
        {
            var usuario = await _dbConnection.QueryAsync<UsuarioModel>($"Select * From {nameof(UsuarioModel)} where IdUsuario={IdUsuario}");
            return usuario.FirstOrDefault();
        }

        public async Task<UsuarioModel> GetUsuarioImageByID(int IdUsuario)
        {
            var usuario = await _dbConnection.QueryAsync<UsuarioModel>($"Select UserAvatar From {nameof(UsuarioModel)} where IdUsuario={IdUsuario}");
            return usuario.FirstOrDefault();
        }

        #endregion

        #region Contatos

        public async Task<List<ContatosModel>> GetAllContatos()
        {
            return await _dbConnection.Table<ContatosModel>().ToListAsync();
        }

        public async Task<ContatosModel> GetContatosByID(int ContatoID)
        {
            var contato = await _dbConnection.QueryAsync<ContatosModel>($"Select * From {nameof(ContatosModel)} where ContatoID={ContatoID}");
            return contato.FirstOrDefault();
        }

        public async Task<ContatosModel> GetContatosImageByID(int ContatoID)
        {
            var contato = await _dbConnection.QueryAsync<ContatosModel>($"Select UserAvatar From {nameof(ContatosModel)} where ContatoId={ContatoID}");
            return contato.FirstOrDefault();
        }

        public async Task<int> AddUContatos(ContatosModel contatosModel)
        {
            return await _dbConnection.InsertAsync(contatosModel);
        }

        public async Task<int> UpdateContatos(ContatosModel contatosModel)
        {
            return await _dbConnection.UpdateAsync(contatosModel);
        }

        public async Task<int> DeleteContatos(ContatosModel contatosModel)
        {
            return await _dbConnection.DeleteAsync(contatosModel);
        }

        #endregion
    }
}
