namespace ControleHospital.Forms
{
    partial class FrmAgendaExame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendaExame));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeExame = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCpfPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicoResponsavelExame = new System.Windows.Forms.ComboBox();
            this.txtSalaExame = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateTimeExame = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEspecialidadeExame = new System.Windows.Forms.TextBox();
            this.TxtNomePaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnAgendaExame = new System.Windows.Forms.Button();
            this.TxtDataNascimento = new System.Windows.Forms.TextBox();
            this.TxtCrmMedico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCodigoExame = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCodigoEspecialidade = new System.Windows.Forms.TextBox();
            this.CodigoEspecialidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exame";
            // 
            // txtNomeExame
            // 
            this.txtNomeExame.FormattingEnabled = true;
            this.txtNomeExame.Location = new System.Drawing.Point(84, 196);
            this.txtNomeExame.Name = "txtNomeExame";
            this.txtNomeExame.Size = new System.Drawing.Size(162, 21);
            this.txtNomeExame.TabIndex = 2;
            this.txtNomeExame.SelectedIndexChanged += new System.EventHandler(this.txtNomeExame_SelectedIndexChanged);
            this.txtNomeExame.TextChanged += new System.EventHandler(this.txtNomeExame_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // TxtCpfPaciente
            // 
            this.TxtCpfPaciente.Location = new System.Drawing.Point(117, 52);
            this.TxtCpfPaciente.Name = "TxtCpfPaciente";
            this.TxtCpfPaciente.Size = new System.Drawing.Size(120, 20);
            this.TxtCpfPaciente.TabIndex = 1;
            this.TxtCpfPaciente.TextChanged += new System.EventHandler(this.TxtCpfPaciente_TextChanged);
            this.TxtCpfPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpfPaciente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Médico";
            // 
            // txtMedicoResponsavelExame
            // 
            this.txtMedicoResponsavelExame.FormattingEnabled = true;
            this.txtMedicoResponsavelExame.Location = new System.Drawing.Point(84, 233);
            this.txtMedicoResponsavelExame.Name = "txtMedicoResponsavelExame";
            this.txtMedicoResponsavelExame.Size = new System.Drawing.Size(162, 21);
            this.txtMedicoResponsavelExame.TabIndex = 3;
            this.txtMedicoResponsavelExame.DropDown += new System.EventHandler(this.txtMedicoResponsavelExame_DropDown);
            // 
            // txtSalaExame
            // 
            this.txtSalaExame.FormattingEnabled = true;
            this.txtSalaExame.Location = new System.Drawing.Point(446, 236);
            this.txtSalaExame.Name = "txtSalaExame";
            this.txtSalaExame.Size = new System.Drawing.Size(49, 21);
            this.txtSalaExame.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sala";
            // 
            // DateTimeExame
            // 
            this.DateTimeExame.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DateTimeExame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeExame.Location = new System.Drawing.Point(592, 239);
            this.DateTimeExame.Name = "DateTimeExame";
            this.DateTimeExame.Size = new System.Drawing.Size(138, 20);
            this.DateTimeExame.TabIndex = 5;
            this.DateTimeExame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateTimeExame_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data e Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especialidade";
            // 
            // txtEspecialidadeExame
            // 
            this.txtEspecialidadeExame.Location = new System.Drawing.Point(365, 199);
            this.txtEspecialidadeExame.Name = "txtEspecialidadeExame";
            this.txtEspecialidadeExame.ReadOnly = true;
            this.txtEspecialidadeExame.Size = new System.Drawing.Size(144, 20);
            this.txtEspecialidadeExame.TabIndex = 8;
            // 
            // TxtNomePaciente
            // 
            this.TxtNomePaciente.Location = new System.Drawing.Point(352, 52);
            this.TxtNomePaciente.Name = "TxtNomePaciente";
            this.TxtNomePaciente.ReadOnly = true;
            this.TxtNomePaciente.Size = new System.Drawing.Size(120, 20);
            this.TxtNomePaciente.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nome";
            // 
            // TxtCodigoPaciente
            // 
            this.TxtCodigoPaciente.Location = new System.Drawing.Point(117, 93);
            this.TxtCodigoPaciente.Name = "TxtCodigoPaciente";
            this.TxtCodigoPaciente.ReadOnly = true;
            this.TxtCodigoPaciente.Size = new System.Drawing.Size(120, 20);
            this.TxtCodigoPaciente.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Data de Nascimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Paciente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Exame";
            // 
            // BtnAgendaExame
            // 
            this.BtnAgendaExame.Location = new System.Drawing.Point(504, 298);
            this.BtnAgendaExame.Name = "BtnAgendaExame";
            this.BtnAgendaExame.Size = new System.Drawing.Size(107, 33);
            this.BtnAgendaExame.TabIndex = 20;
            this.BtnAgendaExame.Text = "Agendar";
            this.BtnAgendaExame.UseVisualStyleBackColor = true;
            this.BtnAgendaExame.Click += new System.EventHandler(this.BtnAgendaExame_Click);
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Location = new System.Drawing.Point(414, 97);
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.ReadOnly = true;
            this.TxtDataNascimento.Size = new System.Drawing.Size(120, 20);
            this.TxtDataNascimento.TabIndex = 21;
            // 
            // TxtCrmMedico
            // 
            this.TxtCrmMedico.Location = new System.Drawing.Point(333, 239);
            this.TxtCrmMedico.Name = "TxtCrmMedico";
            this.TxtCrmMedico.ReadOnly = true;
            this.TxtCrmMedico.Size = new System.Drawing.Size(40, 20);
            this.TxtCrmMedico.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "CRM";
            // 
            // TxtCodigoExame
            // 
            this.TxtCodigoExame.Location = new System.Drawing.Point(571, 202);
            this.TxtCodigoExame.Name = "TxtCodigoExame";
            this.TxtCodigoExame.ReadOnly = true;
            this.TxtCodigoExame.Size = new System.Drawing.Size(40, 20);
            this.TxtCodigoExame.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(525, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Código";
            // 
            // TxtCodigoEspecialidade
            // 
            this.TxtCodigoEspecialidade.Location = new System.Drawing.Point(92, 305);
            this.TxtCodigoEspecialidade.Name = "TxtCodigoEspecialidade";
            this.TxtCodigoEspecialidade.ReadOnly = true;
            this.TxtCodigoEspecialidade.Size = new System.Drawing.Size(40, 20);
            this.TxtCodigoEspecialidade.TabIndex = 26;
            this.TxtCodigoEspecialidade.Visible = false;
            // 
            // CodigoEspecialidade
            // 
            this.CodigoEspecialidade.AutoSize = true;
            this.CodigoEspecialidade.Location = new System.Drawing.Point(28, 308);
            this.CodigoEspecialidade.Name = "CodigoEspecialidade";
            this.CodigoEspecialidade.Size = new System.Drawing.Size(58, 13);
            this.CodigoEspecialidade.TabIndex = 27;
            this.CodigoEspecialidade.Text = "CódigoEsp";
            this.CodigoEspecialidade.Visible = false;
            // 
            // FrmAgendaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 370);
            this.Controls.Add(this.TxtCodigoEspecialidade);
            this.Controls.Add(this.CodigoEspecialidade);
            this.Controls.Add(this.TxtCodigoExame);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtCrmMedico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtDataNascimento);
            this.Controls.Add(this.BtnAgendaExame);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtCodigoPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNomePaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEspecialidadeExame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTimeExame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalaExame);
            this.Controls.Add(this.txtMedicoResponsavelExame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCpfPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeExame);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgendaExame";
            this.Text = "Agendar Exame";
            this.Load += new System.EventHandler(this.FrmAdicionaAgendamentoExame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtNomeExame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCpfPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtMedicoResponsavelExame;
        private System.Windows.Forms.ComboBox txtSalaExame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateTimeExame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEspecialidadeExame;
        private System.Windows.Forms.TextBox TxtNomePaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCodigoPaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnAgendaExame;
        private System.Windows.Forms.TextBox TxtDataNascimento;
        private System.Windows.Forms.TextBox TxtCrmMedico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCodigoExame;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtCodigoEspecialidade;
        private System.Windows.Forms.Label CodigoEspecialidade;
    }
}