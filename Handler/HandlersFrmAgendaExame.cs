using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ControleHospital.Handler
{
    public class HandlersFrmAgendaExame
    {
        public void ExibirCRM(ComboBox medicoResponsavel, TextBox crmMedico, Dictionary<string,int> crmDicionario)
        {
            try
            {
                if (medicoResponsavel.SelectedItem != null)
                {
                    string medicoSelecionado = medicoResponsavel.SelectedItem.ToString();

                    // Verifica se o dicionário foi inicializado e se contém o médico selecionado
                    if (crmDicionario != null)
                    {
                        crmMedico.Clear();
                        crmMedico.Text = crmDicionario[medicoSelecionado].ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
