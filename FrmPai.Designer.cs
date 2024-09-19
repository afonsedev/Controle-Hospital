namespace ControleHospital
{
    partial class FrmPai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPai));
            this.LblConectado = new System.Windows.Forms.Label();
            this.LblInfoColaborador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHemoBanco = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConsultarExame = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImgCheck = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // LblConectado
            // 
            this.LblConectado.AutoSize = true;
            this.LblConectado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblConectado.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConectado.Location = new System.Drawing.Point(30, 19);
            this.LblConectado.Name = "LblConectado";
            this.LblConectado.Size = new System.Drawing.Size(0, 17);
            this.LblConectado.TabIndex = 0;
            // 
            // LblInfoColaborador
            // 
            this.LblInfoColaborador.AutoSize = true;
            this.LblInfoColaborador.Location = new System.Drawing.Point(165, 619);
            this.LblInfoColaborador.Name = "LblInfoColaborador";
            this.LblInfoColaborador.Size = new System.Drawing.Size(0, 13);
            this.LblInfoColaborador.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BtnHemoBanco);
            this.panel1.Controls.Add(this.BtnConsultarExame);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 55);
            this.panel1.TabIndex = 2;
            // 
            // BtnHemoBanco
            // 
            this.BtnHemoBanco.ContextMenuStrip = this.contextMenuStrip1;
            this.BtnHemoBanco.Location = new System.Drawing.Point(168, 13);
            this.BtnHemoBanco.Name = "BtnHemoBanco";
            this.BtnHemoBanco.Size = new System.Drawing.Size(101, 23);
            this.BtnHemoBanco.TabIndex = 2;
            this.BtnHemoBanco.Text = "Hemobanco";
            this.BtnHemoBanco.UseVisualStyleBackColor = true;
            this.BtnHemoBanco.Click += new System.EventHandler(this.BtnHemoBanco_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doaçãoToolStripMenuItem,
            this.transfusãoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 48);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            // 
            // transfusãoToolStripMenuItem
            // 
            this.transfusãoToolStripMenuItem.Name = "transfusãoToolStripMenuItem";
            this.transfusãoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.transfusãoToolStripMenuItem.Text = "Transfusão";
            // 
            // BtnConsultarExame
            // 
            this.BtnConsultarExame.Location = new System.Drawing.Point(33, 13);
            this.BtnConsultarExame.Name = "BtnConsultarExame";
            this.BtnConsultarExame.Size = new System.Drawing.Size(101, 23);
            this.BtnConsultarExame.TabIndex = 1;
            this.BtnConsultarExame.Text = "Consultar Exame";
            this.BtnConsultarExame.UseVisualStyleBackColor = true;
            this.BtnConsultarExame.Click += new System.EventHandler(this.BtnConsultarExame_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.ImgCheck);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LblConectado);
            this.panel2.Location = new System.Drawing.Point(0, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 61);
            this.panel2.TabIndex = 3;
            // 
            // ImgCheck
            // 
            this.ImgCheck.Image = global::ControleHospital.Properties.Resources.tick;
            this.ImgCheck.Location = new System.Drawing.Point(405, 13);
            this.ImgCheck.Name = "ImgCheck";
            this.ImgCheck.Size = new System.Drawing.Size(23, 23);
            this.ImgCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgCheck.TabIndex = 6;
            this.ImgCheck.TabStop = false;
            this.ImgCheck.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // FrmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblInfoColaborador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPai";
            this.Text = "Sistema de Gerenciamento Hospitalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPai_FormClosing);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblConectado;
        private System.Windows.Forms.Label LblInfoColaborador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnConsultarExame;
        private System.Windows.Forms.Button BtnHemoBanco;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfusãoToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ImgCheck;
        private System.Windows.Forms.Label label1;
    }
}