using eCommerce.Models;

namespace eCommerce.api.Repositories
{
    public interface IUsuarioRepository
    {
        // Operações básicas que serão usadas diversas vezes
        /*CRUD*/
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(int id);

        void Add(Usuario usuario);

        void Update(Usuario usuario); 
        void Delete(int id);
    }
}
