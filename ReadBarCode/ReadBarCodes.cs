using Inlite.ClearImageNet;
using System.Windows.Forms;

namespace ReadBarCode
{
    public partial class ReadBarCodes : Form
    {
        int arquivosRenomeados = 0;
        public ReadBarCodes()
        {
            InitializeComponent();
        }

        private void ReadBarCodes_Load(object sender, EventArgs e)
        {
            lblNomePasta.Text = string.Empty;
            lbQtdeRenomeados.Text = string.Empty;
            toolStripStatusLabel1.Text = string.Empty;
        }


        void ReadBarcode1D_page(string fileName, int page)
        {
            try
            {
                using (BarcodeReader reader = new BarcodeReader())
                {
                    reader.Code39 = true;
                    reader.Code128 = true;
                    // reader.Auto1D = true;
                    Barcode[] barcodes = reader.Read(fileName, page);
                    foreach (Barcode barcode in barcodes)
                    {
                        var newFileName = $"{barcode.Text}.pdf";
                        var newFilePath = Path.Combine(Path.GetDirectoryName(fileName), newFileName);

                        // Verifica se o arquivo original existe antes de tentar renomeá-lo.
                        if (File.Exists(fileName))
                        {
                            try
                            {
                                // Renomeia o arquivo para o novo nome.
                                File.Move(fileName, newFilePath);
                                //Console.WriteLine($"Arquivo renomeado para: {newFilePath}");
                                arquivosRenomeados++;
                                lbQtdeRenomeados.Text = arquivosRenomeados.ToString();
                                // Atualiza a ProgressBar.
                                progressBar1.PerformStep();
                            }
                            catch (IOException ioEx)
                            {
                                // Captura exceções de IO, como problemas de arquivo já existente.
                                
                               MessageBox.Show($"Erro ao renomear o arquivo: {ioEx.Message}","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arquivo original não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu erro:{ex.Message}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = string.Empty;
            arquivosRenomeados = 0;

            fb.Description = "Selecione a pasta que contém os arquivos PDF";
            fb.ShowNewFolderButton = false;

            // Mostra a caixa de diálogo para selecionar a pasta.
            DialogResult result = fb.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fb.SelectedPath))
            {
                // Obtém o caminho da pasta selecionada.
                string selectedPath = fb.SelectedPath;
                lblNomePasta.Text = selectedPath;

                // Lista todos os arquivos PDF na pasta selecionada.
                string[] pdfFiles = Directory.GetFiles(selectedPath, "*.pdf");

                // Configura a ProgressBar.
                progressBar1.Minimum = 0;
                progressBar1.Maximum = pdfFiles.Length;
                progressBar1.Value = 0;
                progressBar1.Step = 1;

                // Exibe os arquivos encontrados no console.
                toolStripStatusLabel1.Text = $"Arquivos encontrados: {pdfFiles.Length}";
                
                foreach (string file in pdfFiles)
                {
                    ReadBarcode1D_page(file, 1);
                    
                }

               
                MessageBox.Show("Processo Finalizado", "Processo finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma pasta foi selecionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
