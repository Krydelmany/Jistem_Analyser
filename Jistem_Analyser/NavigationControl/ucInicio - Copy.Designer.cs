namespace Jistem_Analyser.NavigationControl
{
    partial class ucInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.tbNomeMaquina = new System.Windows.Forms.TextBox();
            this.lblDirectX = new System.Windows.Forms.Label();
            this.tbDirectX = new System.Windows.Forms.TextBox();
            this.tbBuild = new System.Windows.Forms.TextBox();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.Label();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.lblNameMachine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.gbInformacoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 519);
            this.panel1.TabIndex = 0;
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.lblNameMachine);
            this.gbInformacoes.Controls.Add(this.lblDirectX);
            this.gbInformacoes.Controls.Add(this.tbDirectX);
            this.gbInformacoes.Controls.Add(this.tbBuild);
            this.gbInformacoes.Controls.Add(this.lblSistema);
            this.gbInformacoes.Controls.Add(this.lblSO);
            this.gbInformacoes.Controls.Add(this.tbOS);
            this.gbInformacoes.Controls.Add(this.tb);
            this.gbInformacoes.Controls.Add(this.tbNomeMaquina);
            this.gbInformacoes.ForeColor = System.Drawing.Color.White;
            this.gbInformacoes.Location = new System.Drawing.Point(16, 12);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(759, 258);
            this.gbInformacoes.TabIndex = 0;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações Gerais";
            // 
            // tbNomeMaquina
            // 
            this.tbNomeMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbNomeMaquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomeMaquina.ForeColor = System.Drawing.Color.White;
            this.tbNomeMaquina.Location = new System.Drawing.Point(121, 32);
            this.tbNomeMaquina.Name = "tbNomeMaquina";
            this.tbNomeMaquina.ReadOnly = true;
            this.tbNomeMaquina.Size = new System.Drawing.Size(420, 20);
            this.tbNomeMaquina.TabIndex = 7;
            // 
            // lblDirectX
            // 
            this.lblDirectX.AutoSize = true;
            this.lblDirectX.Location = new System.Drawing.Point(73, 113);
            this.lblDirectX.Name = "lblDirectX";
            this.lblDirectX.Size = new System.Drawing.Size(42, 13);
            this.lblDirectX.TabIndex = 23;
            this.lblDirectX.Text = "DirectX";
            // 
            // tbDirectX
            // 
            this.tbDirectX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbDirectX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDirectX.ForeColor = System.Drawing.Color.White;
            this.tbDirectX.Location = new System.Drawing.Point(121, 111);
            this.tbDirectX.Name = "tbDirectX";
            this.tbDirectX.ReadOnly = true;
            this.tbDirectX.Size = new System.Drawing.Size(420, 20);
            this.tbDirectX.TabIndex = 22;
            // 
            // tbBuild
            // 
            this.tbBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuild.ForeColor = System.Drawing.Color.White;
            this.tbBuild.Location = new System.Drawing.Point(409, 85);
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.ReadOnly = true;
            this.tbBuild.Size = new System.Drawing.Size(132, 20);
            this.tbBuild.TabIndex = 21;
            this.tbBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(13, 87);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(102, 13);
            this.lblSistema.TabIndex = 20;
            this.lblSistema.Text = "Sistema operacional";
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Location = new System.Drawing.Point(58, 60);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(57, 13);
            this.lblSO.TabIndex = 19;
            this.lblSO.Text = "Fabricante";
            // 
            // tbOS
            // 
            this.tbOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOS.ForeColor = System.Drawing.Color.White;
            this.tbOS.Location = new System.Drawing.Point(121, 85);
            this.tbOS.Name = "tbOS";
            this.tbOS.ReadOnly = true;
            this.tbOS.Size = new System.Drawing.Size(282, 20);
            this.tbOS.TabIndex = 18;
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb.ForeColor = System.Drawing.Color.White;
            this.tb.Location = new System.Drawing.Point(121, 58);
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(420, 20);
            this.tb.TabIndex = 17;
            // 
            // lblNameMachine
            // 
            this.lblNameMachine.AutoSize = true;
            this.lblNameMachine.Location = new System.Drawing.Point(21, 34);
            this.lblNameMachine.Name = "lblNameMachine";
            this.lblNameMachine.Size = new System.Drawing.Size(94, 13);
            this.lblNameMachine.TabIndex = 24;
            this.lblNameMachine.Text = "Nome da Maquina";
            // 
            // ucInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucInicio";
            this.Size = new System.Drawing.Size(792, 519);
            this.panel1.ResumeLayout(false);
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TextBox tbNomeMaquina;
        private System.Windows.Forms.Label lblDirectX;
        private System.Windows.Forms.TextBox tbDirectX;
        private System.Windows.Forms.TextBox tbBuild;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Label lblSO;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lblNameMachine;
    }
}
