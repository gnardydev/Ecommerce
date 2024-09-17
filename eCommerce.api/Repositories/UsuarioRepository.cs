using eCommerce.Models;

namespace eCommerce.api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public static List<Usuario> _db = new List<Usuario>();

        public List<Usuario> Get()
        {
             return _db;
        }

        public Usuario GetUsuario(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }

        public void Add(Usuario usuario)
        {
            _db.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            _db.Remove(GetUsuario(usuario.Id));
            _db.Add(usuario);
        }

        public void Delete(int id)
        {
            _db.Remove(GetUsuario(id));
        }

        public List<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
