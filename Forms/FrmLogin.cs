using ControleHospital.Repository;
using System;
using System.Windows.Forms;

namespace ControleHospital
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public string CampoUsuario
        {
            get { return TxtNome.Text; }
        }

        public string CampoSenha
        {
            get { return TxtSenha.Text; }
        }

      
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            LoginRepository loginRepository = new LoginRepository();
            loginRepository.AutenticarUsuario(this);           
        }       
    }
}
