namespace Jistem_Analyser.NavigationControl
{
    partial class ucCPU
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCPU = new System.Windows.Forms.Panel();
            this.gbArquitetura = new System.Windows.Forms.GroupBox();
            this.tbHabilitado = new System.Windows.Forms.TextBox();
            this.labelHabilitado = new System.Windows.Forms.Label();
            this.tbThread = new System.Windows.Forms.TextBox();
            this.labelThread = new System.Windows.Forms.Label();
            this.tbFrequenciaMaxima = new System.Windows.Forms.TextBox();
            this.labelFrequenciaMaxima = new System.Windows.Forms.Label();
            this.tbNucleoL = new System.Windows.Forms.TextBox();
            this.labelNucleoL = new System.Windows.Forms.Label();
            this.tbNucleoF = new System.Windows.Forms.TextBox();
            this.labelNucleoF = new System.Windows.Forms.Label();
            this.tbArquitetura = new System.Windows.Forms.TextBox();
            this.labelArquitetura = new System.Windows.Forms.Label();
            this.gbCache = new System.Windows.Forms.GroupBox();
            this.tbSpeed3 = new System.Windows.Forms.TextBox();
            this.tbSpeed2 = new System.Windows.Forms.TextBox();
            this.tbL2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblL1 = new System.Windows.Forms.Label();
            this.tbL3 = new System.Windows.Forms.TextBox();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.gbGeral = new System.Windows.Forms.GroupBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbSoquete = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblSoquete = new System.Windows.Forms.Label();
            this.pnlCPU.SuspendLayout();
            this.gbArquitetura.SuspendLayout();
            this.gbCache.SuspendLayout();
            this.gbGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCPU
            // 
            this.pnlCPU.Controls.Add(this.gbArquitetura);
            this.pnlCPU.Controls.Add(this.gbCache);
            this.pnlCPU.Controls.Add(this.gbGeral);
            this.pnlCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCPU.Location = new System.Drawing.Point(0, 0);
            this.pnlCPU.Name = "pnlCPU";
            this.pnlCPU.Size = new System.Drawing.Size(792, 519);
            this.pnlCPU.TabIndex = 0;
            // 
            // gbArquitetura
            // 
            this.gbArquitetura.Controls.Add(this.tbHabilitado);
            this.gbArquitetura.Controls.Add(this.labelHabilitado);
            this.gbArquitetura.Controls.Add(this.tbThread);
            this.gbArquitetura.Controls.Add(this.labelThread);
            this.gbArquitetura.Controls.Add(this.tbFrequenciaMaxima);
            this.gbArquitetura.Controls.Add(this.labelFrequenciaMaxima);
            this.gbArquitetura.Controls.Add(this.tbNucleoL);
            this.gbArquitetura.Controls.Add(this.labelNucleoL);
            this.gbArquitetura.Controls.Add(this.tbNucleoF);
            this.gbArquitetura.Controls.Add(this.labelNucleoF);
            this.gbArquitetura.Controls.Add(this.tbArquitetura);
            this.gbArquitetura.Controls.Add(this.labelArquitetura);
            this.gbArquitetura.ForeColor = System.Drawing.Color.White;
            this.gbArquitetura.Location = new System.Drawing.Point(16, 185);
            this.gbArquitetura.Name = "gbArquitetura";
            this.gbArquitetura.Size = new System.Drawing.Size(440, 196);
            this.gbArquitetura.TabIndex = 9;
            this.gbArquitetura.TabStop = false;
            this.gbArquitetura.Text = "Arquitetura";
            // 
            // tbHabilitado
            // 
            this.tbHabilitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbHabilitado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHabilitado.ForeColor = System.Drawing.Color.White;
            this.tbHabilitado.Location = new System.Drawing.Point(121, 54);
            this.tbHabilitado.Margin = new System.Windows.Forms.Padding(2);
            this.tbHabilitado.Name = "tbHabilitado";
            this.tbHabilitado.ReadOnly = true;
            this.tbHabilitado.Size = new System.Drawing.Size(268, 20);
            this.tbHabilitado.TabIndex = 39;
            // 
            // labelHabilitado
            // 
            this.labelHabilitado.AutoSize = true;
            this.labelHabilitado.Location = new System.Drawing.Point(20, 57);
            this.labelHabilitado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHabilitado.Name = "labelHabilitado";
            this.labelHabilitado.Size = new System.Drawing.Size(101, 13);
            this.labelHabilitado.TabIndex = 38;
            this.labelHabilitado.Text = "Núcleos Habilitados";
            // 
            // tbThread
            // 
            this.tbThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbThread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbThread.ForeColor = System.Drawing.Color.White;
            this.tbThread.Location = new System.Drawing.Point(121, 104);
            this.tbThread.Margin = new System.Windows.Forms.Padding(2);
            this.tbThread.Name = "tbThread";
            this.tbThread.ReadOnly = true;
            this.tbThread.Size = new System.Drawing.Size(268, 20);
            this.tbThread.TabIndex = 37;
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Location = new System.Drawing.Point(71, 106);
            this.labelThread.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(46, 13);
            this.labelThread.TabIndex = 36;
            this.labelThread.Text = "Threads";
            // 
            // tbFrequenciaMaxima
            // 
            this.tbFrequenciaMaxima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbFrequenciaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFrequenciaMaxima.ForeColor = System.Drawing.Color.White;
            this.tbFrequenciaMaxima.Location = new System.Drawing.Point(121, 80);
            this.tbFrequenciaMaxima.Margin = new System.Windows.Forms.Padding(2);
            this.tbFrequenciaMaxima.Name = "tbFrequenciaMaxima";
            this.tbFrequenciaMaxima.ReadOnly = true;
            this.tbFrequenciaMaxima.Size = new System.Drawing.Size(268, 20);
            this.tbFrequenciaMaxima.TabIndex = 35;
            // 
            // labelFrequenciaMaxima
            // 
            this.labelFrequenciaMaxima.AutoSize = true;
            this.labelFrequenciaMaxima.Location = new System.Drawing.Point(23, 82);
            this.labelFrequenciaMaxima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrequenciaMaxima.Name = "labelFrequenciaMaxima";
            this.labelFrequenciaMaxima.Size = new System.Drawing.Size(99, 13);
            this.labelFrequenciaMaxima.TabIndex = 34;
            this.labelFrequenciaMaxima.Text = "Frequência Máxima";
            // 
            // tbNucleoL
            // 
            this.tbNucleoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbNucleoL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNucleoL.ForeColor = System.Drawing.Color.White;
            this.tbNucleoL.Location = new System.Drawing.Point(121, 152);
            this.tbNucleoL.Margin = new System.Windows.Forms.Padding(2);
            this.tbNucleoL.Name = "tbNucleoL";
            this.tbNucleoL.ReadOnly = true;
            this.tbNucleoL.Size = new System.Drawing.Size(268, 20);
            this.tbNucleoL.TabIndex = 33;
            // 
            // labelNucleoL
            // 
            this.labelNucleoL.AutoSize = true;
            this.labelNucleoL.Location = new System.Drawing.Point(36, 157);
            this.labelNucleoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNucleoL.Name = "labelNucleoL";
            this.labelNucleoL.Size = new System.Drawing.Size(86, 13);
            this.labelNucleoL.TabIndex = 32;
            this.labelNucleoL.Text = "Núcleos Lógicos";
            // 
            // tbNucleoF
            // 
            this.tbNucleoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbNucleoF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNucleoF.ForeColor = System.Drawing.Color.White;
            this.tbNucleoF.Location = new System.Drawing.Point(121, 128);
            this.tbNucleoF.Margin = new System.Windows.Forms.Padding(2);
            this.tbNucleoF.Name = "tbNucleoF";
            this.tbNucleoF.ReadOnly = true;
            this.tbNucleoF.Size = new System.Drawing.Size(268, 20);
            this.tbNucleoF.TabIndex = 31;
            // 
            // labelNucleoF
            // 
            this.labelNucleoF.AutoSize = true;
            this.labelNucleoF.Location = new System.Drawing.Point(39, 130);
            this.labelNucleoF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNucleoF.Name = "labelNucleoF";
            this.labelNucleoF.Size = new System.Drawing.Size(83, 13);
            this.labelNucleoF.TabIndex = 30;
            this.labelNucleoF.Text = "Núcleos Físicos";
            // 
            // tbArquitetura
            // 
            this.tbArquitetura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbArquitetura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArquitetura.ForeColor = System.Drawing.Color.White;
            this.tbArquitetura.Location = new System.Drawing.Point(121, 28);
            this.tbArquitetura.Margin = new System.Windows.Forms.Padding(2);
            this.tbArquitetura.Name = "tbArquitetura";
            this.tbArquitetura.ReadOnly = true;
            this.tbArquitetura.Size = new System.Drawing.Size(268, 20);
            this.tbArquitetura.TabIndex = 29;
            // 
            // labelArquitetura
            // 
            this.labelArquitetura.AutoSize = true;
            this.labelArquitetura.Location = new System.Drawing.Point(63, 30);
            this.labelArquitetura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArquitetura.Name = "labelArquitetura";
            this.labelArquitetura.Size = new System.Drawing.Size(58, 13);
            this.labelArquitetura.TabIndex = 28;
            this.labelArquitetura.Text = "Arquitetura";
            // 
            // gbCache
            // 
            this.gbCache.Controls.Add(this.tbSpeed3);
            this.gbCache.Controls.Add(this.tbSpeed2);
            this.gbCache.Controls.Add(this.tbL2);
            this.gbCache.Controls.Add(this.label2);
            this.gbCache.Controls.Add(this.label3);
            this.gbCache.Controls.Add(this.lblL1);
            this.gbCache.Controls.Add(this.tbL3);
            this.gbCache.Controls.Add(this.tbL1);
            this.gbCache.ForeColor = System.Drawing.Color.White;
            this.gbCache.Location = new System.Drawing.Point(471, 185);
            this.gbCache.Name = "gbCache";
            this.gbCache.Size = new System.Drawing.Size(304, 196);
            this.gbCache.TabIndex = 8;
            this.gbCache.TabStop = false;
            this.gbCache.Text = "Cache";
            // 
            // tbSpeed3
            // 
            this.tbSpeed3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbSpeed3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpeed3.ForeColor = System.Drawing.Color.White;
            this.tbSpeed3.Location = new System.Drawing.Point(179, 106);
            this.tbSpeed3.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeed3.Name = "tbSpeed3";
            this.tbSpeed3.ReadOnly = true;
            this.tbSpeed3.Size = new System.Drawing.Size(76, 20);
            this.tbSpeed3.TabIndex = 27;
            // 
            // tbSpeed2
            // 
            this.tbSpeed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbSpeed2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSpeed2.ForeColor = System.Drawing.Color.White;
            this.tbSpeed2.Location = new System.Drawing.Point(179, 83);
            this.tbSpeed2.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeed2.Name = "tbSpeed2";
            this.tbSpeed2.ReadOnly = true;
            this.tbSpeed2.Size = new System.Drawing.Size(76, 20);
            this.tbSpeed2.TabIndex = 26;
            // 
            // tbL2
            // 
            this.tbL2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbL2.ForeColor = System.Drawing.Color.White;
            this.tbL2.Location = new System.Drawing.Point(79, 83);
            this.tbL2.Name = "tbL2";
            this.tbL2.ReadOnly = true;
            this.tbL2.Size = new System.Drawing.Size(95, 20);
            this.tbL2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "L2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "L3";
            // 
            // lblL1
            // 
            this.lblL1.AutoSize = true;
            this.lblL1.Location = new System.Drawing.Point(54, 61);
            this.lblL1.Name = "lblL1";
            this.lblL1.Size = new System.Drawing.Size(19, 13);
            this.lblL1.TabIndex = 8;
            this.lblL1.Text = "L1";
            // 
            // tbL3
            // 
            this.tbL3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbL3.ForeColor = System.Drawing.Color.White;
            this.tbL3.Location = new System.Drawing.Point(79, 106);
            this.tbL3.Name = "tbL3";
            this.tbL3.ReadOnly = true;
            this.tbL3.Size = new System.Drawing.Size(95, 20);
            this.tbL3.TabIndex = 7;
            // 
            // tbL1
            // 
            this.tbL1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbL1.ForeColor = System.Drawing.Color.White;
            this.tbL1.Location = new System.Drawing.Point(79, 57);
            this.tbL1.Name = "tbL1";
            this.tbL1.ReadOnly = true;
            this.tbL1.Size = new System.Drawing.Size(95, 20);
            this.tbL1.TabIndex = 6;
            // 
            // gbGeral
            // 
            this.gbGeral.Controls.Add(this.tbDescricao);
            this.gbGeral.Controls.Add(this.lblDescricao);
            this.gbGeral.Controls.Add(this.tbSoquete);
            this.gbGeral.Controls.Add(this.lblFabricante);
            this.gbGeral.Controls.Add(this.lblNome);
            this.gbGeral.Controls.Add(this.tbFabricante);
            this.gbGeral.Controls.Add(this.tbNome);
            this.gbGeral.Controls.Add(this.lblSoquete);
            this.gbGeral.ForeColor = System.Drawing.Color.White;
            this.gbGeral.Location = new System.Drawing.Point(16, 12);
            this.gbGeral.Name = "gbGeral";
            this.gbGeral.Size = new System.Drawing.Size(759, 167);
            this.gbGeral.TabIndex = 7;
            this.gbGeral.TabStop = false;
            this.gbGeral.Text = "Geral";
            // 
            // tbDescricao
            // 
            this.tbDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.ForeColor = System.Drawing.Color.White;
            this.tbDescricao.Location = new System.Drawing.Point(121, 58);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.ReadOnly = true;
            this.tbDescricao.Size = new System.Drawing.Size(533, 20);
            this.tbDescricao.TabIndex = 13;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(60, 60);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição";
            // 
            // tbSoquete
            // 
            this.tbSoquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbSoquete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSoquete.ForeColor = System.Drawing.Color.White;
            this.tbSoquete.Location = new System.Drawing.Point(121, 110);
            this.tbSoquete.Name = "tbSoquete";
            this.tbSoquete.ReadOnly = true;
            this.tbSoquete.Size = new System.Drawing.Size(533, 20);
            this.tbSoquete.TabIndex = 12;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(58, 86);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 9;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(80, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // tbFabricante
            // 
            this.tbFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFabricante.ForeColor = System.Drawing.Color.White;
            this.tbFabricante.Location = new System.Drawing.Point(121, 84);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.ReadOnly = true;
            this.tbFabricante.Size = new System.Drawing.Size(533, 20);
            this.tbFabricante.TabIndex = 7;
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.ForeColor = System.Drawing.Color.White;
            this.tbNome.Location = new System.Drawing.Point(121, 32);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(533, 20);
            this.tbNome.TabIndex = 6;
            // 
            // lblSoquete
            // 
            this.lblSoquete.AutoSize = true;
            this.lblSoquete.ForeColor = System.Drawing.Color.White;
            this.lblSoquete.Location = new System.Drawing.Point(68, 112);
            this.lblSoquete.Name = "lblSoquete";
            this.lblSoquete.Size = new System.Drawing.Size(47, 13);
            this.lblSoquete.TabIndex = 5;
            this.lblSoquete.Text = "Soquete";
            // 
            // ucCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.pnlCPU);
            this.Name = "ucCPU";
            this.Size = new System.Drawing.Size(792, 519);
            this.pnlCPU.ResumeLayout(false);
            this.gbArquitetura.ResumeLayout(false);
            this.gbArquitetura.PerformLayout();
            this.gbCache.ResumeLayout(false);
            this.gbCache.PerformLayout();
            this.gbGeral.ResumeLayout(false);
            this.gbGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCPU;
        private System.Windows.Forms.GroupBox gbGeral;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbSoquete;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblSoquete;
        private System.Windows.Forms.GroupBox gbCache;
        private System.Windows.Forms.TextBox tbL2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblL1;
        private System.Windows.Forms.TextBox tbL3;
        private System.Windows.Forms.TextBox tbL1;
        private System.Windows.Forms.GroupBox gbArquitetura;
        private System.Windows.Forms.TextBox tbHabilitado;
        private System.Windows.Forms.Label labelHabilitado;
        private System.Windows.Forms.TextBox tbThread;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.TextBox tbFrequenciaMaxima;
        private System.Windows.Forms.Label labelFrequenciaMaxima;
        private System.Windows.Forms.TextBox tbNucleoL;
        private System.Windows.Forms.Label labelNucleoL;
        private System.Windows.Forms.TextBox tbNucleoF;
        private System.Windows.Forms.Label labelNucleoF;
        private System.Windows.Forms.TextBox tbArquitetura;
        private System.Windows.Forms.Label labelArquitetura;
        private System.Windows.Forms.TextBox tbSpeed3;
        private System.Windows.Forms.TextBox tbSpeed2;
    }
}
