using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleHospital.Provider
{
    public class UsuarioProvider
    {

        public Usuario usuario;

        public void InfoUsuario(FrmPai frmPai)
        {
            Conexao conexao = new Conexao();
            // Usuario usuario = new Usuario();

            if (conexao.AbrirConexao() != null)
            {
                frmPai.LblConectado.Text = $"Conectado | Funcionário: {usuario.Nome} | Setor: {usuario.Setor}";
                frmPai.ImgCheck.Visible = true;
            }
        }
    }
}
