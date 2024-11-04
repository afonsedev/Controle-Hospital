namespace ControleHospital
{
    partial class FrmConsultaExames
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaExames));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrmMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigoExame = new System.Windows.Forms.TextBox();
            this.LblConectado = new System.Windows.Forms.Label();
            this.ImgCheck = new System.Windows.Forms.PictureBox();
            this.PictureBoxQrCode = new System.Windows.Forms.PictureBox();
            this.BtnEditaExame = new System.Windows.Forms.Button();
            this.BtnApagaExame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomePaciente,
            this.CPF,
            this.CodigoPaciente,
            this.NomeExame,
            this.CodigoExame,
            this.CodigoAgendamento,
            this.DATA,
            this.NomeMedico,
            this.CrmMedico,
            this.Especialidade,
            this.DESCRICAO,
            this.SALA});
            this.dataGridView1.Location = new System.Drawing.Point(34, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(777, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // NomePaciente
            // 
            this.NomePaciente.DataPropertyName = "NOME PACIENTE";
            this.NomePaciente.HeaderText = "NOME PACIENTE";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            this.NomePaciente.Width = 77;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.DataPropertyName = "CÓDIGO PACIENTE";
            this.CodigoPaciente.HeaderText = "CÓDIGO PACIENTE";
            this.CodigoPaciente.Name = "CodigoPaciente";
            this.CodigoPaciente.ReadOnly = true;
            this.CodigoPaciente.Width = 78;
            // 
            // NomeExame
            // 
            this.NomeExame.DataPropertyName = "NOME EXAME";
            this.NomeExame.HeaderText = "NOME EXAME";
            this.NomeExame.Name = "NomeExame";
            this.NomeExame.ReadOnly = true;
            this.NomeExame.Width = 77;
            // 
            // CodigoExame
            // 
            this.CodigoExame.DataPropertyName = "CÓDIGO EXAME";
            this.CodigoExame.HeaderText = "CÓDIGO EXAME";
            this.CodigoExame.Name = "CodigoExame";
            this.CodigoExame.ReadOnly = true;
            this.CodigoExame.Width = 78;
            // 
            // CodigoAgendamento
            // 
            this.CodigoAgendamento.DataPropertyName = "CÓDIGO AGENDAMENTO";
            this.CodigoAgendamento.HeaderText = "CÓDIGO AGENDAMENTO";
            this.CodigoAgendamento.Name = "CodigoAgendamento";
            this.CodigoAgendamento.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 77;
            // 
            // NomeMedico
            // 
            this.NomeMedico.DataPropertyName = "NOME MÉDICO";
            this.NomeMedico.HeaderText = "NOME MÉDICO";
            this.NomeMedico.Name = "NomeMedico";
            this.NomeMedico.ReadOnly = true;
            this.NomeMedico.Width = 77;
            // 
            // CrmMedico
            // 
            this.CrmMedico.DataPropertyName = "CRM MÉDICO";
            this.CrmMedico.HeaderText = "CRM MÉDICO";
            this.CrmMedico.Name = "CrmMedico";
            this.CrmMedico.ReadOnly = true;
            this.CrmMedico.Width = 78;
            // 
            // Especialidade
            // 
            this.Especialidade.DataPropertyName = "ESPECIALIDADE";
            this.Especialidade.HeaderText = "ESPECIALIDADE";
            this.Especialidade.Name = "Especialidade";
            this.Especialidade.ReadOnly = true;
            this.Especialidade.Width = 77;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRIÇÃO";
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 78;
            // 
            // SALA
            // 
            this.SALA.DataPropertyName = "SALA";
            this.SALA.HeaderText = "SALA";
            this.SALA.Name = "SALA";
            this.SALA.ReadOnly = true;
            this.SALA.Width = 77;
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Location = new System.Drawing.Point(397, 19);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(90, 31);
            this.BtnPesquisa.TabIndex = 1;
            this.BtnPesquisa.Text = "Pesquisar";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código do Exame";
            // 
            // TxtCodigoExame
            // 
            this.TxtCodigoExame.Location = new System.Drawing.Point(127, 19);
            this.TxtCodigoExame.Multiline = true;
            this.TxtCodigoExame.Name = "TxtCodigoExame";
            this.TxtCodigoExame.Size = new System.Drawing.Size(175, 23);
            this.TxtCodigoExame.TabIndex = 0;
            this.TxtCodigoExame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoExame_KeyPress);
            // 
            // LblConectado
            // 
            this.LblConectado.AutoSize = true;
            this.LblConectado.Location = new System.Drawing.Point(31, 417);
            this.LblConectado.Name = "LblConectado";
            this.LblConectado.Size = new System.Drawing.Size(0, 13);
            this.LblConectado.TabIndex = 3;
            // 
            // ImgCheck
            // 
            this.ImgCheck.Image = global::ControleHospital.Properties.Resources.iconCheck;
            this.ImgCheck.Location = new System.Drawing.Point(90, 408);
            this.ImgCheck.Name = "ImgCheck";
            this.ImgCheck.Size = new System.Drawing.Size(31, 30);
            this.ImgCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCheck.TabIndex = 4;
            this.ImgCheck.TabStop = false;
            this.ImgCheck.Visible = false;
            // 
            // PictureBoxQrCode
            // 
            this.PictureBoxQrCode.Location = new System.Drawing.Point(876, 125);
            this.PictureBoxQrCode.Name = "PictureBoxQrCode";
            this.PictureBoxQrCode.Size = new System.Drawing.Size(266, 228);
            this.PictureBoxQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxQrCode.TabIndex = 5;
            this.PictureBoxQrCode.TabStop = false;
            // 
            // BtnEditaExame
            // 
            this.BtnEditaExame.Location = new System.Drawing.Point(615, 19);
            this.BtnEditaExame.Name = "BtnEditaExame";
            this.BtnEditaExame.Size = new System.Drawing.Size(90, 31);
            this.BtnEditaExame.TabIndex = 2;
            this.BtnEditaExame.TabStop = false;
            this.BtnEditaExame.Text = "Editar";
            this.BtnEditaExame.UseVisualStyleBackColor = true;
            this.BtnEditaExame.Click += new System.EventHandler(this.BtnEditaExame_Click);
            // 
            // BtnApagaExame
            // 
            this.BtnApagaExame.Location = new System.Drawing.Point(721, 15);
            this.BtnApagaExame.Name = "BtnApagaExame";
            this.BtnApagaExame.Size = new System.Drawing.Size(90, 39);
            this.BtnApagaExame.TabIndex = 3;
            this.BtnApagaExame.TabStop = false;
            this.BtnApagaExame.Text = "Apagar Agendamento";
            this.BtnApagaExame.UseVisualStyleBackColor = true;
            this.BtnApagaExame.Click += new System.EventHandler(this.BtnApagaExame_Click1);
            // 
            // FrmConsultaExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 459);
            this.Controls.Add(this.BtnApagaExame);
            this.Controls.Add(this.BtnEditaExame);
            this.Controls.Add(this.PictureBoxQrCode);
            this.Controls.Add(this.ImgCheck);
            this.Controls.Add(this.LblConectado);
            this.Controls.Add(this.TxtCodigoExame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaExames";
            this.Text = "Consulta de Exames";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoExame;
        private System.Windows.Forms.Label LblConectado;
        private System.Windows.Forms.PictureBox ImgCheck;
        private System.Windows.Forms.Button BtnEditaExame;
        private System.Windows.Forms.Button BtnApagaExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrmMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        public System.Windows.Forms.PictureBox PictureBoxQrCode;
    }
}

