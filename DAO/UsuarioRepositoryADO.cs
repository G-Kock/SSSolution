using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class UsuarioRepositoryADO : IUsuarioRepository
    {
        public Task Create(UsuarioDTO usuario)
        {

        }

        public Task<UsuarioDTO> Authenticate(string email, string password)
        {

        }
    }
}
