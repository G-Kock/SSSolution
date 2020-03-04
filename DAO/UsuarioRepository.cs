using DAO.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public async Task Create(UsuarioDTO usuario)
        {
            try
            {
                using (var context = new SSContext())
                {
                    context.Usuarios.Add(usuario);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.InnerException.Message.Contains("EMAIL"))
                {
                    throw new Exception("O email já foi cadastrado.");
                }
                //Logar
                //File.WriteAllText(BLABLABLA);
                throw new Exception("Erro no banco de dados");
            }
        }

        public async Task<UsuarioDTO> Authenticate(string email, string password)
        {
            using (var ctx = new SSContext())
            {
                UsuarioDTO user = await ctx.Usuarios.FirstOrDefaultAsync(u => u.Email == email && u.Senha == password); //Tio Celo flw sobre o ConfigureAwait(false);
                if (user == null)
                {
                    throw new Exception("Email e/ou senha inválidos");
                }
                return user;
            }
        }
    }
}
