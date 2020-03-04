using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAO;
using DTO;

namespace BLL.Impl
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        UsuarioRepository repository = new UsuarioRepository();

        public async Task Create(UsuarioDTO usuario)
        {
            //INÍCIO VALIDAÇÃO
            //EU TE AMO PEDRO ALEX MARTINS
            //FIM VALIDAÇÃO
            await repository.Create(usuario);

        }

        public async Task<UsuarioDTO> Authenticate(string email, string password)
        {
            return await repository.Authenticate(email, password);
        }
    }
}
