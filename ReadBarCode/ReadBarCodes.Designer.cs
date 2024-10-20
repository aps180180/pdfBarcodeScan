namespace ReadBarCode
{
    partial class ReadBarCodes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelecionarPasta = new Button();
            status = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblNomePasta = new Label();
            label1 = new Label();
            fb = new FolderBrowserDialog();
            lbArquivosRenomeados = new Label();
            lbQtdeRenomeados = new Label();
            progressBar1 = new ProgressBar();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionarPasta
            // 
            btnSelecionarPasta.Location = new Point(12, 12);
            btnSelecionarPasta.Name = "btnSelecionarPasta";
            btnSelecionarPasta.Size = new Size(776, 35);
            btnSelecionarPasta.TabIndex = 0;
            btnSelecionarPasta.Text = "Selecionar Pasta";
            btnSelecionarPasta.UseVisualStyleBackColor = true;
            btnSelecionarPasta.Click += btnSelecionarPasta_Click;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            status.Location = new Point(0, 172);
            status.Name = "status";
            status.Size = new Size(800, 22);
            status.TabIndex = 1;
            status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = Color.DodgerBlue;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(127, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblNomePasta
            // 
            lblNomePasta.AutoSize = true;
            lblNomePasta.Location = new Point(105, 50);
            lblNomePasta.Name = "lblNomePasta";
            lblNomePasta.Size = new Size(38, 15);
            lblNomePasta.TabIndex = 2;
            lblNomePasta.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome da Pasta";
            // 
            // fb
            // 
            fb.InitialDirectory = "c:\\";
            fb.RootFolder = Environment.SpecialFolder.MyComputer;
            // 
            // lbArquivosRenomeados
            // 
            lbArquivosRenomeados.AutoSize = true;
            lbArquivosRenomeados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbArquivosRenomeados.Location = new Point(12, 80);
            lbArquivosRenomeados.Name = "lbArquivosRenomeados";
            lbArquivosRenomeados.Size = new Size(131, 15);
            lbArquivosRenomeados.TabIndex = 5;
            lbArquivosRenomeados.Text = "Arquivos Renomeados";
            // 
            // lbQtdeRenomeados
            // 
            lbQtdeRenomeados.AutoSize = true;
            lbQtdeRenomeados.Location = new Point(149, 80);
            lbQtdeRenomeados.Name = "lbQtdeRenomeados";
            lbQtdeRenomeados.Size = new Size(38, 15);
            lbQtdeRenomeados.TabIndex = 4;
            lbQtdeRenomeados.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 107);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 23);
            progressBar1.TabIndex = 6;
            // 
            // ReadBarCodes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 194);
            Controls.Add(progressBar1);
            Controls.Add(lbArquivosRenomeados);
            Controls.Add(lbQtdeRenomeados);
            Controls.Add(label1);
            Controls.Add(lblNomePasta);
            Controls.Add(status);
            Controls.Add(btnSelecionarPasta);
            MaximizeBox = false;
            Name = "ReadBarCodes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Realiza Leitura de Código de Barras e Renomeia Docs";
            Load += ReadBarCodes_Load;
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecionarPasta;
        private StatusStrip status;
        private Label lblNomePasta;
        private Label label1;
        private FolderBrowserDialog fb;
        private Label lbArquivosRenomeados;
        private Label lbQtdeRenomeados;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ProgressBar progressBar1;
    }
}
