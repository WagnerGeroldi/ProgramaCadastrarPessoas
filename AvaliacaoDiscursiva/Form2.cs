using System;
using System.Windows.Forms;

namespace AvaliacaoDiscursiva
{
    public partial class FormResultado : Form
    {
        public FormResultado()
        {
            InitializeComponent();
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

        private void FormResultado_Load(object sender, EventArgs e)
        {
            Jovem.ResultadoMasculinoEmpregado();    
        }

        private void ButtonCloseResult_Click(object sender, EventArgs e)
        {
            FormResultado.ActiveForm.Close();
        }
    }
}
