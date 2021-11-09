using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoDiscursiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxSex.DataSource = Enum.GetNames(typeof(Jovem.Sexo));
            ComboBoxEmployee.DataSource = Enum.GetNames(typeof(Jovem.SituacaoTrabalhista));
            GridJovens.DataSource = Jovem.Consultar();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text.Length == 0)
            {
                MessageBox.Show("O nome não pode ficar vazio!", "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Jovem jovem = new Jovem(
                                TextBoxName.Text,
                                (Jovem.Sexo)ComboBoxSex.SelectedIndex,
                                (Jovem.SituacaoTrabalhista)ComboBoxEmployee.SelectedIndex
                                );
                jovem.Incluir();
                GridJovens.DataSource = "";
                GridJovens.DataSource = Jovem.Consultar();
                LimparCampos();
                MessageBox.Show("Dados Cadastrados com sucesso", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void LimparCampos()
        {
            TextBoxName.Text = "";
            ComboBoxSex.SelectedIndex = 0;
            ComboBoxEmployee.SelectedIndex = 0;
        }

        private void LimparGrid()
        {
            if (GridJovens.Rows.Count != 0)
            {
                const string message = "Tem certeza que deseja limpar a lista?";
                var result = MessageBox.Show(message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GridJovens.DataSource = null;
                    Jovem.Limpar();
                    GridJovens.DataSource = Jovem.Consultar();
                    MessageBox.Show("Lista apagada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("A lista já está vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonAutoComplete_Click(object sender, EventArgs e)
        {
            if (GridJovens.Rows.Count == 0)
            {
                const string message = "Tem certeza que deseja completar automaticamente?";
                var result = MessageBox.Show(message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Jovem.Preencher();
                    GridJovens.DataSource = "";
                    GridJovens.DataSource = Jovem.Consultar();
                }
            }
            else
            {
                const string message = "A lista já possui itens, então não pode preencher automaticamente! \n" +
                   "Deseja limpar a lista e preencher automaticamente?";
                var result = MessageBox.Show(message,
                   "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(result == DialogResult.Yes)
                {
                    LimparGrid();
                    Jovem.Preencher();
                    GridJovens.DataSource = "";
                    GridJovens.DataSource = Jovem.Consultar();
                }
            }
        }


        private void ButtonResult_Click(object sender, EventArgs e)
        {
            FormResultado formResultado;
            formResultado = new FormResultado();
            if (GridJovens.Rows.Count == 0)
            {
                MessageBox.Show("A lista está vazia!\nPor favor, caso não queira digitar, clique no botão Preencher Automaticamente.", "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else
            {
                const string message = "O resultado abrirá em uma nova janela!";
                var result = MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    formResultado.ShowDialog();
                   
                }
            }
        }

        private void buttonLimparLista_Click(object sender, EventArgs e)
        {
            LimparGrid();
        }
    }
}
