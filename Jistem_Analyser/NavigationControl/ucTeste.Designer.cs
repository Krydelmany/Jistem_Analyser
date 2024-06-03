namespace Jistem_Analyser.NavigationControl
{
    partial class ucTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTeste));
            this.labelArraySize = new System.Windows.Forms.TextBox();
            this.labelWriteTime = new System.Windows.Forms.TextBox();
            this.labelReadTime = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelArraySize
            // 
            this.labelArraySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelArraySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArraySize.ForeColor = System.Drawing.Color.White;
            this.labelArraySize.Location = new System.Drawing.Point(60, 296);
            this.labelArraySize.Name = "labelArraySize";
            this.labelArraySize.Size = new System.Drawing.Size(652, 20);
            this.labelArraySize.TabIndex = 1;
            this.labelArraySize.Text = "Tamanho do array:";
            // 
            // labelWriteTime
            // 
            this.labelWriteTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelWriteTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWriteTime.ForeColor = System.Drawing.Color.White;
            this.labelWriteTime.Location = new System.Drawing.Point(60, 322);
            this.labelWriteTime.Name = "labelWriteTime";
            this.labelWriteTime.Size = new System.Drawing.Size(652, 20);
            this.labelWriteTime.TabIndex = 2;
            this.labelWriteTime.Text = "Tempo de escrita para array de tamanho";
            // 
            // labelReadTime
            // 
            this.labelReadTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelReadTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelReadTime.ForeColor = System.Drawing.Color.White;
            this.labelReadTime.Location = new System.Drawing.Point(60, 348);
            this.labelReadTime.Name = "labelReadTime";
            this.labelReadTime.Size = new System.Drawing.Size(652, 20);
            this.labelReadTime.TabIndex = 3;
            this.labelReadTime.Text = "Tempo de leitura para array de tamanho";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(60, 384);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(652, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(297, 439);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 57);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Iniciar Teste";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(196, 413);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(381, 20);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(60, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(652, 201);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.lblObs.Location = new System.Drawing.Point(57, 266);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(292, 13);
            this.lblObs.TabIndex = 8;
            this.lblObs.Text = "Obs: Você pode alternar entre telas enquanto o teste é feito.";
            // 
            // ucTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelReadTime);
            this.Controls.Add(this.labelWriteTime);
            this.Controls.Add(this.labelArraySize);
            this.Name = "ucTeste";
            this.Size = new System.Drawing.Size(792, 519);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labelArraySize;
        private System.Windows.Forms.TextBox labelWriteTime;
        private System.Windows.Forms.TextBox labelReadTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox labelStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblObs;
    }
}
