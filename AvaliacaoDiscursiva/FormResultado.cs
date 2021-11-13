using System;
using System.Windows.Forms;

using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace AvaliacaoDiscursiva
{
    public partial class FormResultado : Form
    {
        public void itensResultado()
        {
            TextBoxHomemEmpregado.Text = Jovem.ResultadoMasculinoEmpregado().ToString();
            TextBoxHomemDesempregado.Text = Jovem.ResultadoMasculinoDesempregado().ToString();
            TextBoxMulherEmpregada.Text = Jovem.ResultadoFemininoEmpregado().ToString();
            TextBoxMulherDesempregada.Text = Jovem.ResultadoFemininoDesempregado().ToString();
            TextBoxTotalEntrevistados.Text = Jovem.TotalDeEntrevistados().ToString();
            TextBoxResultadoPorcentagemHomemEmpregado.Text = Jovem.PorcentagemHomemEmpregado().ToString();
            TextBoxResultadoPorcentagemMulherEmpregado.Text = Jovem.PorcentagemMulherEmpregado().ToString();
            TextBoxResultadoPorcentagemHomemDesempregado.Text = Jovem.PorcentagemHomemDesempregado().ToString();
            TextBoxResultadoPorcentagemMulherDesempregado.Text = Jovem.PorcentagemMulherDesempregado().ToString();

        }
        public FormResultado()
        {
            InitializeComponent();
            itensResultado();
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            Jovem.ResultadoMasculinoEmpregado();
        }

        private void ButtonCloseResult_Click(object sender, EventArgs e)
        {
            FormResultado.ActiveForm.Close();
        }

        private void buttonGerarPDF_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja gerar relatório PDF?", "Aviso",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                gerarPDF();
                
            }

        }
        private void gerarPDF()
        {
            Document doc = new Document(PageSize.A4);

            FolderBrowserDialog vSalvar = new FolderBrowserDialog();
            string txtNomeArquivo = "RelatorioPesquisa";
            if (vSalvar.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                // caminho para onde salvar o arquivo
                string path = vSalvar.SelectedPath + "\\" + txtNomeArquivo + ".pdf";


                //criar pdf // configuracao
                PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.SetMargins(40, 40, 40, 80);
                doc.Open();

                //variaveis para compor dados
                string homemDesempregado = Jovem.ResultadoMasculinoDesempregado().ToString();
                string mulherEmpregado = Jovem.ResultadoFemininoEmpregado().ToString();
                string mulherDesempregado = Jovem.ResultadoFemininoDesempregado().ToString();
                string totalEntrevistados = Jovem.TotalDeEntrevistados().ToString();
                string porcentagemMulherEmpregado = Jovem.PorcentagemMulherEmpregado().ToString();
                string porcentagemHomemDesempregado = Jovem.PorcentagemHomemDesempregado().ToString();
                string porcentagemMulherDesempregado = Jovem.PorcentagemMulherDesempregado().ToString();
                string homemEmpregado = Jovem.ResultadoMasculinoEmpregado().ToString();
                string porcentagemHomemEmpregado = Jovem.PorcentagemHomemEmpregado().ToString();

                //criacao de paragrafos
                Paragraph title = new Paragraph();
                Paragraph content = new Paragraph();
                Paragraph quantidadeEntrevistados = new Paragraph();

                //formatacao título
                BaseColor red = BaseColor.RED;
                var fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, red);
                title.Alignment = Element.ALIGN_CENTER;
                title.Font = fonteTitulo;

                //conteudos
                iTextSharp.text.pdf.draw.VerticalPositionMark linha = new iTextSharp.text.pdf.draw.LineSeparator();
                title.Add("Relatório da pesquisa \n\n");
                content.Add("O total de Mulheres Desempregadas é " + mulherDesempregado
                    + " e corresponde a " + porcentagemMulherDesempregado + "%. \n" +
                    "O total de mulheres empregadas é " + mulherEmpregado
                  + " e corresponde a " + porcentagemMulherEmpregado + "%. \n" +
                  "O total de Homens empregados é " + homemEmpregado
                    + " e corresponde a " + porcentagemHomemEmpregado + "%. \n" +
                    "O total de Homens Desempregados é " + homemDesempregado
                    + " e corresponde a " + porcentagemHomemDesempregado + "%. \n");
                quantidadeEntrevistados.Add("O total de entrevistados foi: " + totalEntrevistados + " pessoas.");

                

                //adicionar conteudo
                doc.Add(title);
                doc.Add(new Chunk("\n"));
                doc.Add(linha);
                doc.Add(new Chunk("\n"));
                doc.Add(content);
                doc.Add(new Chunk("\n"));
                doc.Add(linha);
                doc.Add(new Chunk("\n"));
                doc.Add(quantidadeEntrevistados);

                doc.Close();

                var result = MessageBox.Show("Arquivo PDF criado, clique em OK para abrir pasta de destino!", "Aviso",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                if(result == DialogResult.OK) {

                Process.Start(vSalvar.SelectedPath); //abrir a pasta onde está o arquivo salvo
                }
                
            }

        }
    }
}



