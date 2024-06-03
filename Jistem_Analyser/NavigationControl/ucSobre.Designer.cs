namespace Jistem_Analyser.NavigationControl
{
    partial class ucSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSobre));
            this.pnlSobre = new System.Windows.Forms.Panel();
            this.gbSobre = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.linklblSite = new System.Windows.Forms.LinkLabel();
            this.pnlSobre.SuspendLayout();
            this.gbSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSobre
            // 
            this.pnlSobre.Controls.Add(this.linklblSite);
            this.pnlSobre.Controls.Add(this.gbSobre);
            this.pnlSobre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSobre.Location = new System.Drawing.Point(0, 0);
            this.pnlSobre.Name = "pnlSobre";
            this.pnlSobre.Size = new System.Drawing.Size(792, 519);
            this.pnlSobre.TabIndex = 0;
            // 
            // gbSobre
            // 
            this.gbSobre.Controls.Add(this.label2);
            this.gbSobre.Controls.Add(this.label1);
            this.gbSobre.Controls.Add(this.lblModelo);
            this.gbSobre.Controls.Add(this.lblFabricante);
            this.gbSobre.ForeColor = System.Drawing.Color.White;
            this.gbSobre.Location = new System.Drawing.Point(29, 173);
            this.gbSobre.Name = "gbSobre";
            this.gbSobre.Size = new System.Drawing.Size(735, 172);
            this.gbSobre.TabIndex = 19;
            this.gbSobre.TabStop = false;
            this.gbSobre.Text = "Sobre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estudante de Engenharia da Computação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(293, 55);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(139, 13);
            this.lblModelo.TabIndex = 13;
            this.lblModelo.Text = "Autor: Giovani Claro Moraes";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(278, 31);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(168, 13);
            this.lblFabricante.TabIndex = 12;
            this.lblFabricante.Text = "Versão 0.0.1 - 2 de junho de 2024";
            // 
            // linklblSite
            // 
            this.linklblSite.ActiveLinkColor = System.Drawing.Color.White;
            this.linklblSite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.linklblSite.Location = new System.Drawing.Point(26, 357);
            this.linklblSite.Name = "linklblSite";
            this.linklblSite.Size = new System.Drawing.Size(77, 13);
            this.linklblSite.TabIndex = 0;
            this.linklblSite.TabStop = true;
            this.linklblSite.Text = "Site do autor";
            this.linklblSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ucSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.pnlSobre);
            this.Name = "ucSobre";
            this.Size = new System.Drawing.Size(792, 519);
            this.pnlSobre.ResumeLayout(false);
            this.gbSobre.ResumeLayout(false);
            this.gbSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSobre;
        private System.Windows.Forms.GroupBox gbSobre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.LinkLabel linklblSite;
    }
}
