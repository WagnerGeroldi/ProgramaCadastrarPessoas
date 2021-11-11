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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
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
                return;
            }

                if (TextBoxId.Text.Length != 0)
                {
                    Jovem alterarJovem = new Jovem(
                                    int.Parse(TextBoxId.Text),
                                    TextBoxName.Text,
                                    (Jovem.Sexo)ComboBoxSex.SelectedIndex,
                                    (Jovem.SituacaoTrabalhista)ComboBoxEmployee.SelectedIndex
                                    );
                    alterarJovem.Alterar();
                    LimparCampos();
                    PreencherGrid(Jovem.Consultar());

                    MessageBox.Show("Dados Alterados com sucesso", "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;

                }
                Jovem jovem = new Jovem(
                                TextBoxName.Text,
                                (Jovem.Sexo)ComboBoxSex.SelectedIndex,
                                (Jovem.SituacaoTrabalhista)ComboBoxEmployee.SelectedIndex
                                );
                jovem.Incluir();
                PreencherGrid(Jovem.Consultar());
                LimparCampos();
                LabelInstrucao();
                MessageBox.Show("Dados Cadastrados com sucesso", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void LimparCampos()
        {
            TextBoxId.Text = "";
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
                    PreencherGrid(Jovem.Consultar());
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
                    PreencherGrid(Jovem.Consultar());
                    LabelInstrucao();
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
                    PreencherGrid(Jovem.Consultar());
                    LabelInstrucao();
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
            LabelInstrucao();
        }

        private void GridJovens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                const string message = "Tem certeza que deseja editar o registro?";
                var result = MessageBox.Show(message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id;
                    id = (int)GridJovens["IdJovem", e.RowIndex].Value;

                    Jovem jovem = new Jovem(id);
                    TextBoxId.Text = jovem.IdJovem.ToString();
                    TextBoxName.Text = jovem.NomeJovem.ToString();
                    ComboBoxSex.SelectedIndex = (int)jovem.SexoJovem;
                    ComboBoxEmployee.SelectedIndex = (int)jovem.SituacaoTrabalhistaJovem;
                }
            } else

                {
                    const string message2 = "Você não pode editar pois a lista está vazia!";
                    MessageBox.Show(message2, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }


        private void PreencherGrid(List<Jovem> lista)
        {
            GridJovens.DataSource = new BindingList<Jovem>(lista);

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (GridJovens.Rows.Count == 0)
            {
                const string message = "A lista está vazia! Não existe itens para excluir.";
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
                if (TextBoxId.Text.Length !=0 )
            {
                const string message = "Tem certeza que deseja excluir o registro?";
                var result = MessageBox.Show(message, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Jovem.Excluir(int.Parse(TextBoxId.Text));
                    LimparCampos();
                    PreencherGrid(Jovem.Consultar());
                    MessageBox.Show("Entrevistado excluído com sucesso!", "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            } else
            {
                const string message = "Dê um clique duplo no item que deseja excluir!";
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LabelInstrucao()

        {   
            labelInstrucao.Visible = GridJovens.Rows.Count != 0;
        }
    }
}
