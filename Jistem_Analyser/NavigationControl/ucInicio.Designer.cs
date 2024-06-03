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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbRede = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toggleButton = new System.Windows.Forms.Button();
            this.lblEnderecoIP = new System.Windows.Forms.Label();
            this.tbMACAddress = new System.Windows.Forms.TextBox();
            this.lblEnderecoMAC = new System.Windows.Forms.Label();
            this.lblNomeRede = new System.Windows.Forms.Label();
            this.tbIPAddress2 = new System.Windows.Forms.TextBox();
            this.tbNetworkName = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblCRAM = new System.Windows.Forms.Label();
            this.lblCCPU = new System.Windows.Forms.Label();
            this.pbConsumoRAM = new System.Windows.Forms.ProgressBar();
            this.labelConsumoRAM = new System.Windows.Forms.Label();
            this.labelConsumoCPU = new System.Windows.Forms.Label();
            this.pbConsumoCPU = new System.Windows.Forms.ProgressBar();
            this.lblQuantidadeUSR = new System.Windows.Forms.Label();
            this.tbQuantidadeUSR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdiomaSO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTipoProduto = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInstallDate = new System.Windows.Forms.TextBox();
            this.tbWindowsVersion = new System.Windows.Forms.TextBox();
            this.lblLastBootUpTime = new System.Windows.Forms.Label();
            this.tbLastBootUpTime = new System.Windows.Forms.TextBox();
            this.lblUptime = new System.Windows.Forms.Label();
            this.tbUptime = new System.Windows.Forms.TextBox();
            this.lblWindows11 = new System.Windows.Forms.Label();
            this.pbWindows11 = new System.Windows.Forms.PictureBox();
            this.lblNameMachine = new System.Windows.Forms.Label();
            this.lblDirectX = new System.Windows.Forms.Label();
            this.tbDirectX = new System.Windows.Forms.TextBox();
            this.tbBuild = new System.Windows.Forms.TextBox();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblSO = new System.Windows.Forms.Label();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbBootDevice = new System.Windows.Forms.TextBox();
            this.tbNomeMaquina = new System.Windows.Forms.TextBox();
            this.pbWindows10 = new System.Windows.Forms.PictureBox();
            this.lblWindows10 = new System.Windows.Forms.Label();
            this.uptimeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbRede.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindows11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindows10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.gbRede);
            this.panel1.Controls.Add(this.gbInformacoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 519);
            this.panel1.TabIndex = 0;
            // 
            // gbRede
            // 
            this.gbRede.Controls.Add(this.label4);
            this.gbRede.Controls.Add(this.toggleButton);
            this.gbRede.Controls.Add(this.lblEnderecoIP);
            this.gbRede.Controls.Add(this.tbMACAddress);
            this.gbRede.Controls.Add(this.lblEnderecoMAC);
            this.gbRede.Controls.Add(this.lblNomeRede);
            this.gbRede.Controls.Add(this.tbIPAddress2);
            this.gbRede.Controls.Add(this.tbNetworkName);
            this.gbRede.Controls.Add(this.tbIPAddress);
            this.gbRede.ForeColor = System.Drawing.Color.White;
            this.gbRede.Location = new System.Drawing.Point(16, 340);
            this.gbRede.Name = "gbRede";
            this.gbRede.Size = new System.Drawing.Size(759, 167);
            this.gbRede.TabIndex = 25;
            this.gbRede.TabStop = false;
            this.gbRede.Text = "Rede";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(34, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Informações de rede ocultas por padrão, clique no botão a direita para mostrar as" +
    " informações.";
            // 
            // toggleButton
            // 
            this.toggleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toggleButton.FlatAppearance.BorderSize = 0;
            this.toggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.toggleButton.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton.Image")));
            this.toggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toggleButton.Location = new System.Drawing.Point(652, 19);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toggleButton.Size = new System.Drawing.Size(76, 28);
            this.toggleButton.TabIndex = 25;
            this.toggleButton.Text = "   Mostar";
            this.toggleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toggleButton.UseVisualStyleBackColor = false;
            // 
            // lblEnderecoIP
            // 
            this.lblEnderecoIP.AutoSize = true;
            this.lblEnderecoIP.Location = new System.Drawing.Point(49, 76);
            this.lblEnderecoIP.Name = "lblEnderecoIP";
            this.lblEnderecoIP.Size = new System.Drawing.Size(66, 13);
            this.lblEnderecoIP.TabIndex = 24;
            this.lblEnderecoIP.Text = "Endereço IP";
            // 
            // tbMACAddress
            // 
            this.tbMACAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbMACAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMACAddress.ForeColor = System.Drawing.Color.White;
            this.tbMACAddress.Location = new System.Drawing.Point(121, 100);
            this.tbMACAddress.Name = "tbMACAddress";
            this.tbMACAddress.ReadOnly = true;
            this.tbMACAddress.Size = new System.Drawing.Size(609, 20);
            this.tbMACAddress.TabIndex = 21;
            // 
            // lblEnderecoMAC
            // 
            this.lblEnderecoMAC.AutoSize = true;
            this.lblEnderecoMAC.Location = new System.Drawing.Point(36, 102);
            this.lblEnderecoMAC.Name = "lblEnderecoMAC";
            this.lblEnderecoMAC.Size = new System.Drawing.Size(79, 13);
            this.lblEnderecoMAC.TabIndex = 20;
            this.lblEnderecoMAC.Text = "Endereço MAC";
            // 
            // lblNomeRede
            // 
            this.lblNomeRede.AutoSize = true;
            this.lblNomeRede.Location = new System.Drawing.Point(36, 128);
            this.lblNomeRede.Name = "lblNomeRede";
            this.lblNomeRede.Size = new System.Drawing.Size(79, 13);
            this.lblNomeRede.TabIndex = 19;
            this.lblNomeRede.Text = "Nome da Rede";
            // 
            // tbIPAddress2
            // 
            this.tbIPAddress2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbIPAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIPAddress2.ForeColor = System.Drawing.Color.White;
            this.tbIPAddress2.Location = new System.Drawing.Point(409, 74);
            this.tbIPAddress2.Name = "tbIPAddress2";
            this.tbIPAddress2.ReadOnly = true;
            this.tbIPAddress2.Size = new System.Drawing.Size(321, 20);
            this.tbIPAddress2.TabIndex = 18;
            // 
            // tbNetworkName
            // 
            this.tbNetworkName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbNetworkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNetworkName.ForeColor = System.Drawing.Color.White;
            this.tbNetworkName.Location = new System.Drawing.Point(121, 126);
            this.tbNetworkName.Name = "tbNetworkName";
            this.tbNetworkName.ReadOnly = true;
            this.tbNetworkName.Size = new System.Drawing.Size(609, 20);
            this.tbNetworkName.TabIndex = 17;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIPAddress.ForeColor = System.Drawing.Color.White;
            this.tbIPAddress.Location = new System.Drawing.Point(121, 74);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.ReadOnly = true;
            this.tbIPAddress.Size = new System.Drawing.Size(282, 20);
            this.tbIPAddress.TabIndex = 7;
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.lblCRAM);
            this.gbInformacoes.Controls.Add(this.lblCCPU);
            this.gbInformacoes.Controls.Add(this.pbConsumoRAM);
            this.gbInformacoes.Controls.Add(this.labelConsumoRAM);
            this.gbInformacoes.Controls.Add(this.labelConsumoCPU);
            this.gbInformacoes.Controls.Add(this.pbConsumoCPU);
            this.gbInformacoes.Controls.Add(this.lblQuantidadeUSR);
            this.gbInformacoes.Controls.Add(this.tbQuantidadeUSR);
            this.gbInformacoes.Controls.Add(this.label1);
            this.gbInformacoes.Controls.Add(this.tbIdiomaSO);
            this.gbInformacoes.Controls.Add(this.label2);
            this.gbInformacoes.Controls.Add(this.tbTipoProduto);
            this.gbInformacoes.Controls.Add(this.lblFabricante);
            this.gbInformacoes.Controls.Add(this.tbFabricante);
            this.gbInformacoes.Controls.Add(this.label3);
            this.gbInformacoes.Controls.Add(this.tbInstallDate);
            this.gbInformacoes.Controls.Add(this.tbWindowsVersion);
            this.gbInformacoes.Controls.Add(this.lblLastBootUpTime);
            this.gbInformacoes.Controls.Add(this.tbLastBootUpTime);
            this.gbInformacoes.Controls.Add(this.lblUptime);
            this.gbInformacoes.Controls.Add(this.tbUptime);
            this.gbInformacoes.Controls.Add(this.lblWindows11);
            this.gbInformacoes.Controls.Add(this.pbWindows11);
            this.gbInformacoes.Controls.Add(this.lblNameMachine);
            this.gbInformacoes.Controls.Add(this.lblDirectX);
            this.gbInformacoes.Controls.Add(this.tbDirectX);
            this.gbInformacoes.Controls.Add(this.tbBuild);
            this.gbInformacoes.Controls.Add(this.lblSistema);
            this.gbInformacoes.Controls.Add(this.lblSO);
            this.gbInformacoes.Controls.Add(this.tbOS);
            this.gbInformacoes.Controls.Add(this.tbBootDevice);
            this.gbInformacoes.Controls.Add(this.tbNomeMaquina);
            this.gbInformacoes.Controls.Add(this.pbWindows10);
            this.gbInformacoes.Controls.Add(this.lblWindows10);
            this.gbInformacoes.ForeColor = System.Drawing.Color.White;
            this.gbInformacoes.Location = new System.Drawing.Point(16, 12);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(759, 328);
            this.gbInformacoes.TabIndex = 0;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações Gerais";
            // 
            // lblCRAM
            // 
            this.lblCRAM.AutoSize = true;
            this.lblCRAM.Location = new System.Drawing.Point(683, 291);
            this.lblCRAM.Name = "lblCRAM";
            this.lblCRAM.Size = new System.Drawing.Size(27, 13);
            this.lblCRAM.TabIndex = 51;
            this.lblCRAM.Text = "99%";
            // 
            // lblCCPU
            // 
            this.lblCCPU.AutoSize = true;
            this.lblCCPU.Location = new System.Drawing.Point(683, 265);
            this.lblCCPU.Name = "lblCCPU";
            this.lblCCPU.Size = new System.Drawing.Size(27, 13);
            this.lblCCPU.TabIndex = 50;
            this.lblCCPU.Text = "99%";
            // 
            // pbConsumoRAM
            // 
            this.pbConsumoRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.pbConsumoRAM.Location = new System.Drawing.Point(369, 288);
            this.pbConsumoRAM.Name = "pbConsumoRAM";
            this.pbConsumoRAM.Size = new System.Drawing.Size(308, 20);
            this.pbConsumoRAM.TabIndex = 49;
            // 
            // labelConsumoRAM
            // 
            this.labelConsumoRAM.AutoSize = true;
            this.labelConsumoRAM.Location = new System.Drawing.Point(335, 291);
            this.labelConsumoRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsumoRAM.Name = "labelConsumoRAM";
            this.labelConsumoRAM.Size = new System.Drawing.Size(31, 13);
            this.labelConsumoRAM.TabIndex = 48;
            this.labelConsumoRAM.Text = "RAM";
            // 
            // labelConsumoCPU
            // 
            this.labelConsumoCPU.AutoSize = true;
            this.labelConsumoCPU.Location = new System.Drawing.Point(336, 265);
            this.labelConsumoCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsumoCPU.Name = "labelConsumoCPU";
            this.labelConsumoCPU.Size = new System.Drawing.Size(30, 13);
            this.labelConsumoCPU.TabIndex = 47;
            this.labelConsumoCPU.Text = "GPU";
            // 
            // pbConsumoCPU
            // 
            this.pbConsumoCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.pbConsumoCPU.Location = new System.Drawing.Point(369, 262);
            this.pbConsumoCPU.Name = "pbConsumoCPU";
            this.pbConsumoCPU.Size = new System.Drawing.Size(308, 20);
            this.pbConsumoCPU.TabIndex = 46;
            // 
            // lblQuantidadeUSR
            // 
            this.lblQuantidadeUSR.AutoSize = true;
            this.lblQuantidadeUSR.Location = new System.Drawing.Point(14, 238);
            this.lblQuantidadeUSR.Name = "lblQuantidadeUSR";
            this.lblQuantidadeUSR.Size = new System.Drawing.Size(99, 13);
            this.lblQuantidadeUSR.TabIndex = 45;
            this.lblQuantidadeUSR.Text = "Quantd de usuários";
            // 
            // tbQuantidadeUSR
            // 
            this.tbQuantidadeUSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbQuantidadeUSR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuantidadeUSR.ForeColor = System.Drawing.Color.White;
            this.tbQuantidadeUSR.Location = new System.Drawing.Point(121, 236);
            this.tbQuantidadeUSR.Name = "tbQuantidadeUSR";
            this.tbQuantidadeUSR.ReadOnly = true;
            this.tbQuantidadeUSR.Size = new System.Drawing.Size(587, 20);
            this.tbQuantidadeUSR.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Idioma SO";
            // 
            // tbIdiomaSO
            // 
            this.tbIdiomaSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbIdiomaSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIdiomaSO.ForeColor = System.Drawing.Color.White;
            this.tbIdiomaSO.Location = new System.Drawing.Point(121, 184);
            this.tbIdiomaSO.Name = "tbIdiomaSO";
            this.tbIdiomaSO.ReadOnly = true;
            this.tbIdiomaSO.Size = new System.Drawing.Size(587, 20);
            this.tbIdiomaSO.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tipo do produto";
            // 
            // tbTipoProduto
            // 
            this.tbTipoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbTipoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTipoProduto.ForeColor = System.Drawing.Color.White;
            this.tbTipoProduto.Location = new System.Drawing.Point(121, 210);
            this.tbTipoProduto.Name = "tbTipoProduto";
            this.tbTipoProduto.ReadOnly = true;
            this.tbTipoProduto.Size = new System.Drawing.Size(587, 20);
            this.tbTipoProduto.TabIndex = 40;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(58, 162);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 39;
            this.lblFabricante.Text = "Fabricante";
            // 
            // tbFabricante
            // 
            this.tbFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFabricante.ForeColor = System.Drawing.Color.White;
            this.tbFabricante.Location = new System.Drawing.Point(121, 160);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.ReadOnly = true;
            this.tbFabricante.Size = new System.Drawing.Size(587, 20);
            this.tbFabricante.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Instalado em";
            // 
            // tbInstallDate
            // 
            this.tbInstallDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbInstallDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInstallDate.ForeColor = System.Drawing.Color.White;
            this.tbInstallDate.Location = new System.Drawing.Point(121, 108);
            this.tbInstallDate.Name = "tbInstallDate";
            this.tbInstallDate.ReadOnly = true;
            this.tbInstallDate.Size = new System.Drawing.Size(433, 20);
            this.tbInstallDate.TabIndex = 35;
            // 
            // tbWindowsVersion
            // 
            this.tbWindowsVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbWindowsVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWindowsVersion.ForeColor = System.Drawing.Color.White;
            this.tbWindowsVersion.Location = new System.Drawing.Point(434, 58);
            this.tbWindowsVersion.Name = "tbWindowsVersion";
            this.tbWindowsVersion.ReadOnly = true;
            this.tbWindowsVersion.Size = new System.Drawing.Size(120, 20);
            this.tbWindowsVersion.TabIndex = 33;
            this.tbWindowsVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastBootUpTime
            // 
            this.lblLastBootUpTime.AutoSize = true;
            this.lblLastBootUpTime.Location = new System.Drawing.Point(19, 264);
            this.lblLastBootUpTime.Name = "lblLastBootUpTime";
            this.lblLastBootUpTime.Size = new System.Drawing.Size(96, 13);
            this.lblLastBootUpTime.TabIndex = 32;
            this.lblLastBootUpTime.Text = "Última inicialização";
            // 
            // tbLastBootUpTime
            // 
            this.tbLastBootUpTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbLastBootUpTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastBootUpTime.ForeColor = System.Drawing.Color.White;
            this.tbLastBootUpTime.Location = new System.Drawing.Point(121, 262);
            this.tbLastBootUpTime.Name = "tbLastBootUpTime";
            this.tbLastBootUpTime.ReadOnly = true;
            this.tbLastBootUpTime.Size = new System.Drawing.Size(186, 20);
            this.tbLastBootUpTime.TabIndex = 31;
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(28, 290);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(87, 13);
            this.lblUptime.TabIndex = 30;
            this.lblUptime.Text = "Tempo percorido";
            // 
            // tbUptime
            // 
            this.tbUptime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbUptime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUptime.ForeColor = System.Drawing.Color.White;
            this.tbUptime.Location = new System.Drawing.Point(121, 288);
            this.tbUptime.Name = "tbUptime";
            this.tbUptime.ReadOnly = true;
            this.tbUptime.Size = new System.Drawing.Size(186, 20);
            this.tbUptime.TabIndex = 29;
            // 
            // lblWindows11
            // 
            this.lblWindows11.AutoSize = true;
            this.lblWindows11.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblWindows11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.lblWindows11.Location = new System.Drawing.Point(610, 106);
            this.lblWindows11.Name = "lblWindows11";
            this.lblWindows11.Size = new System.Drawing.Size(98, 21);
            this.lblWindows11.TabIndex = 26;
            this.lblWindows11.Text = "Windows 11";
            // 
            // pbWindows11
            // 
            this.pbWindows11.Image = ((System.Drawing.Image)(resources.GetObject("pbWindows11.Image")));
            this.pbWindows11.Location = new System.Drawing.Point(620, 29);
            this.pbWindows11.Name = "pbWindows11";
            this.pbWindows11.Size = new System.Drawing.Size(77, 71);
            this.pbWindows11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWindows11.TabIndex = 25;
            this.pbWindows11.TabStop = false;
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
            // lblDirectX
            // 
            this.lblDirectX.AutoSize = true;
            this.lblDirectX.Location = new System.Drawing.Point(73, 136);
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
            this.tbDirectX.Location = new System.Drawing.Point(121, 134);
            this.tbDirectX.Name = "tbDirectX";
            this.tbDirectX.ReadOnly = true;
            this.tbDirectX.Size = new System.Drawing.Size(433, 20);
            this.tbDirectX.TabIndex = 22;
            // 
            // tbBuild
            // 
            this.tbBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbBuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuild.ForeColor = System.Drawing.Color.White;
            this.tbBuild.Location = new System.Drawing.Point(313, 58);
            this.tbBuild.Name = "tbBuild";
            this.tbBuild.ReadOnly = true;
            this.tbBuild.Size = new System.Drawing.Size(115, 20);
            this.tbBuild.TabIndex = 21;
            this.tbBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Location = new System.Drawing.Point(13, 61);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(102, 13);
            this.lblSistema.TabIndex = 20;
            this.lblSistema.Text = "Sistema operacional";
            // 
            // lblSO
            // 
            this.lblSO.AutoSize = true;
            this.lblSO.Location = new System.Drawing.Point(27, 86);
            this.lblSO.Name = "lblSO";
            this.lblSO.Size = new System.Drawing.Size(88, 13);
            this.lblSO.TabIndex = 19;
            this.lblSO.Text = "Numero de Serial";
            // 
            // tbOS
            // 
            this.tbOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOS.ForeColor = System.Drawing.Color.White;
            this.tbOS.Location = new System.Drawing.Point(121, 58);
            this.tbOS.Name = "tbOS";
            this.tbOS.ReadOnly = true;
            this.tbOS.Size = new System.Drawing.Size(186, 20);
            this.tbOS.TabIndex = 18;
            // 
            // tbBootDevice
            // 
            this.tbBootDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbBootDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBootDevice.ForeColor = System.Drawing.Color.White;
            this.tbBootDevice.Location = new System.Drawing.Point(121, 84);
            this.tbBootDevice.Name = "tbBootDevice";
            this.tbBootDevice.ReadOnly = true;
            this.tbBootDevice.Size = new System.Drawing.Size(433, 20);
            this.tbBootDevice.TabIndex = 17;
            // 
            // tbNomeMaquina
            // 
            this.tbNomeMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbNomeMaquina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomeMaquina.ForeColor = System.Drawing.Color.White;
            this.tbNomeMaquina.Location = new System.Drawing.Point(121, 32);
            this.tbNomeMaquina.Name = "tbNomeMaquina";
            this.tbNomeMaquina.ReadOnly = true;
            this.tbNomeMaquina.Size = new System.Drawing.Size(433, 20);
            this.tbNomeMaquina.TabIndex = 7;
            // 
            // pbWindows10
            // 
            this.pbWindows10.Image = ((System.Drawing.Image)(resources.GetObject("pbWindows10.Image")));
            this.pbWindows10.Location = new System.Drawing.Point(620, 29);
            this.pbWindows10.Name = "pbWindows10";
            this.pbWindows10.Size = new System.Drawing.Size(77, 71);
            this.pbWindows10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWindows10.TabIndex = 27;
            this.pbWindows10.TabStop = false;
            // 
            // lblWindows10
            // 
            this.lblWindows10.AutoSize = true;
            this.lblWindows10.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblWindows10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(243)))));
            this.lblWindows10.Location = new System.Drawing.Point(610, 106);
            this.lblWindows10.Name = "lblWindows10";
            this.lblWindows10.Size = new System.Drawing.Size(98, 21);
            this.lblWindows10.TabIndex = 28;
            this.lblWindows10.Text = "Windows 10";
            // 
            // uptimeTimer
            // 
            this.uptimeTimer.Enabled = true;
            // 
            // ucInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucInicio";
            this.Size = new System.Drawing.Size(792, 519);
            this.panel1.ResumeLayout(false);
            this.gbRede.ResumeLayout(false);
            this.gbRede.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindows11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWindows10)).EndInit();
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
        private System.Windows.Forms.TextBox tbBootDevice;
        private System.Windows.Forms.Label lblNameMachine;
        private System.Windows.Forms.GroupBox gbRede;
        private System.Windows.Forms.Label lblEnderecoIP;
        private System.Windows.Forms.TextBox tbMACAddress;
        private System.Windows.Forms.Label lblEnderecoMAC;
        private System.Windows.Forms.Label lblNomeRede;
        private System.Windows.Forms.TextBox tbIPAddress2;
        private System.Windows.Forms.TextBox tbNetworkName;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.PictureBox pbWindows11;
        private System.Windows.Forms.Label lblWindows11;
        private System.Windows.Forms.Label lblWindows10;
        private System.Windows.Forms.PictureBox pbWindows10;
        private System.Windows.Forms.Label lblLastBootUpTime;
        private System.Windows.Forms.TextBox tbLastBootUpTime;
        private System.Windows.Forms.Label lblUptime;
        private System.Windows.Forms.TextBox tbUptime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInstallDate;
        private System.Windows.Forms.TextBox tbWindowsVersion;
        private System.Windows.Forms.Timer uptimeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdiomaSO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTipoProduto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.Label lblQuantidadeUSR;
        private System.Windows.Forms.TextBox tbQuantidadeUSR;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbConsumoRAM;
        private System.Windows.Forms.Label labelConsumoRAM;
        private System.Windows.Forms.Label labelConsumoCPU;
        private System.Windows.Forms.ProgressBar pbConsumoCPU;
        private System.Windows.Forms.Label lblCRAM;
        private System.Windows.Forms.Label lblCCPU;
    }
}
