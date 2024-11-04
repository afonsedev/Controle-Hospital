namespace ControleHospital.Forms
{
    partial class FrmAgendaExame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendaExame));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeExame = new System.Windows.Forms.ComboBox();
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
            this.TxtCodigoAgendamento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
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
            // TxtNomeExame
            // 
            this.TxtNomeExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeExame.FormattingEnabled = true;
            this.TxtNomeExame.Location = new System.Drawing.Point(84, 196);
            this.TxtNomeExame.Name = "TxtNomeExame";
            this.TxtNomeExame.Size = new System.Drawing.Size(162, 28);
            this.TxtNomeExame.TabIndex = 2;
            this.TxtNomeExame.TextChanged += new System.EventHandler(this.TxtNomeExame_TextChanged);
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
            this.TxtCpfPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCpfPaciente.Location = new System.Drawing.Point(117, 52);
            this.TxtCpfPaciente.Multiline = true;
            this.TxtCpfPaciente.Name = "TxtCpfPaciente";
            this.TxtCpfPaciente.Size = new System.Drawing.Size(143, 29);
            this.TxtCpfPaciente.TabIndex = 1;
            this.TxtCpfPaciente.TextChanged += new System.EventHandler(this.TxtCpfPaciente_TextChanged);
            this.TxtCpfPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpfPaciente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Médico";
            // 
            // txtMedicoResponsavelExame
            // 
            this.txtMedicoResponsavelExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicoResponsavelExame.FormattingEnabled = true;
            this.txtMedicoResponsavelExame.Location = new System.Drawing.Point(84, 242);
            this.txtMedicoResponsavelExame.Name = "txtMedicoResponsavelExame";
            this.txtMedicoResponsavelExame.Size = new System.Drawing.Size(162, 24);
            this.txtMedicoResponsavelExame.TabIndex = 3;
            this.txtMedicoResponsavelExame.DropDown += new System.EventHandler(this.TxtMedicoResponsavelExame_DropDown);
            this.txtMedicoResponsavelExame.SelectedIndexChanged += new System.EventHandler(this.TxtMedicoResponsavelExame_SelectedIndexChanged);
            // 
            // txtSalaExame
            // 
            this.txtSalaExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaExame.FormattingEnabled = true;
            this.txtSalaExame.Location = new System.Drawing.Point(446, 242);
            this.txtSalaExame.Name = "txtSalaExame";
            this.txtSalaExame.Size = new System.Drawing.Size(49, 28);
            this.txtSalaExame.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sala";
            // 
            // DateTimeExame
            // 
            this.DateTimeExame.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DateTimeExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeExame.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeExame.Location = new System.Drawing.Point(592, 245);
            this.DateTimeExame.Name = "DateTimeExame";
            this.DateTimeExame.Size = new System.Drawing.Size(151, 22);
            this.DateTimeExame.TabIndex = 5;
            this.DateTimeExame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateTimeExame_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data e Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especialidade";
            // 
            // txtEspecialidadeExame
            // 
            this.txtEspecialidadeExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidadeExame.Location = new System.Drawing.Point(355, 198);
            this.txtEspecialidadeExame.Name = "txtEspecialidadeExame";
            this.txtEspecialidadeExame.ReadOnly = true;
            this.txtEspecialidadeExame.Size = new System.Drawing.Size(144, 26);
            this.txtEspecialidadeExame.TabIndex = 8;
            // 
            // TxtNomePaciente
            // 
            this.TxtNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomePaciente.Location = new System.Drawing.Point(352, 52);
            this.TxtNomePaciente.Multiline = true;
            this.TxtNomePaciente.Name = "TxtNomePaciente";
            this.TxtNomePaciente.ReadOnly = true;
            this.TxtNomePaciente.Size = new System.Drawing.Size(143, 29);
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
            this.TxtCodigoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPaciente.Location = new System.Drawing.Point(117, 93);
            this.TxtCodigoPaciente.Multiline = true;
            this.TxtCodigoPaciente.Name = "TxtCodigoPaciente";
            this.TxtCodigoPaciente.ReadOnly = true;
            this.TxtCodigoPaciente.Size = new System.Drawing.Size(143, 29);
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
            this.BtnAgendaExame.Location = new System.Drawing.Point(621, 312);
            this.BtnAgendaExame.Name = "BtnAgendaExame";
            this.BtnAgendaExame.Size = new System.Drawing.Size(122, 44);
            this.BtnAgendaExame.TabIndex = 5;
            this.BtnAgendaExame.Text = "Agendar";
            this.BtnAgendaExame.UseVisualStyleBackColor = true;
            this.BtnAgendaExame.Click += new System.EventHandler(this.BtnAgendaExame_Click);
            // 
            // TxtDataNascimento
            // 
            this.TxtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataNascimento.Location = new System.Drawing.Point(415, 93);
            this.TxtDataNascimento.Multiline = true;
            this.TxtDataNascimento.Name = "TxtDataNascimento";
            this.TxtDataNascimento.ReadOnly = true;
            this.TxtDataNascimento.Size = new System.Drawing.Size(143, 29);
            this.TxtDataNascimento.TabIndex = 21;
            // 
            // TxtCrmMedico
            // 
            this.TxtCrmMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCrmMedico.Location = new System.Drawing.Point(314, 239);
            this.TxtCrmMedico.Name = "TxtCrmMedico";
            this.TxtCrmMedico.ReadOnly = true;
            this.TxtCrmMedico.Size = new System.Drawing.Size(73, 26);
            this.TxtCrmMedico.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "CRM";
            // 
            // TxtCodigoExame
            // 
            this.TxtCodigoExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoExame.Location = new System.Drawing.Point(561, 196);
            this.TxtCodigoExame.Name = "TxtCodigoExame";
            this.TxtCodigoExame.ReadOnly = true;
            this.TxtCodigoExame.Size = new System.Drawing.Size(40, 26);
            this.TxtCodigoExame.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(515, 204);
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
            // TxtCodigoAgendamento
            // 
            this.TxtCodigoAgendamento.Location = new System.Drawing.Point(243, 309);
            this.TxtCodigoAgendamento.Name = "TxtCodigoAgendamento";
            this.TxtCodigoAgendamento.ReadOnly = true;
            this.TxtCodigoAgendamento.Size = new System.Drawing.Size(40, 20);
            this.TxtCodigoAgendamento.TabIndex = 28;
            this.TxtCodigoAgendamento.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(163, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "CódigoAgend.";
            this.label14.Visible = false;
            // 
            // FrmAgendaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 407);
            this.Controls.Add(this.TxtCodigoAgendamento);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.TxtNomeExame);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgendaExame";
            this.Text = "Agendar Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox TxtNomeExame;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtCpfPaciente;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox txtMedicoResponsavelExame;
        public System.Windows.Forms.ComboBox txtSalaExame;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker DateTimeExame;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtEspecialidadeExame;
        public System.Windows.Forms.TextBox TxtNomePaciente;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtCodigoPaciente;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button BtnAgendaExame;
        public System.Windows.Forms.TextBox TxtDataNascimento;
        public System.Windows.Forms.TextBox TxtCrmMedico;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TxtCodigoExame;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox TxtCodigoEspecialidade;
        public System.Windows.Forms.Label CodigoEspecialidade;
        public System.Windows.Forms.TextBox TxtCodigoAgendamento;
        public System.Windows.Forms.Label label14;
    }
}