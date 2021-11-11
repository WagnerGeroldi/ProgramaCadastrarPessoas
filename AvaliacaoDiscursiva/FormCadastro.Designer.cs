
namespace AvaliacaoDiscursiva
{
    partial class FormCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.GridJovens = new System.Windows.Forms.DataGridView();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonAutoComplete = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ComboBoxSex = new System.Windows.Forms.ComboBox();
            this.ComboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.buttonLimparLista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelInstrucao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridJovens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE ENTREVISTADO";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(6, 55);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(53, 18);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Nome:";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSex.Location = new System.Drawing.Point(6, 94);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(46, 18);
            this.LabelSex.TabIndex = 2;
            this.LabelSex.Text = "Sexo:";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployee.Location = new System.Drawing.Point(6, 130);
            this.LabelEmployee.Name = "LabelEmployee";
            this.LabelEmployee.Size = new System.Drawing.Size(146, 18);
            this.LabelEmployee.TabIndex = 3;
            this.LabelEmployee.Text = "Situação Trabalhista:";
            // 
            // GridJovens
            // 
            this.GridJovens.AllowUserToAddRows = false;
            this.GridJovens.AllowUserToDeleteRows = false;
            this.GridJovens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridJovens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.GridJovens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridJovens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridJovens.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridJovens.Location = new System.Drawing.Point(149, 274);
            this.GridJovens.Name = "GridJovens";
            this.GridJovens.ReadOnly = true;
            this.GridJovens.Size = new System.Drawing.Size(458, 164);
            this.GridJovens.TabIndex = 4;
            this.GridJovens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridJovens_CellDoubleClick);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(9, 169);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(101, 33);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "Salvar";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonAutoComplete
            // 
            this.ButtonAutoComplete.Location = new System.Drawing.Point(22, 98);
            this.ButtonAutoComplete.Name = "ButtonAutoComplete";
            this.ButtonAutoComplete.Size = new System.Drawing.Size(186, 41);
            this.ButtonAutoComplete.TabIndex = 6;
            this.ButtonAutoComplete.Text = "Preencher Automaticamente";
            this.ButtonAutoComplete.UseVisualStyleBackColor = true;
            this.ButtonAutoComplete.Click += new System.EventHandler(this.ButtonAutoComplete_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonResult.Location = new System.Drawing.Point(200, 19);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(127, 40);
            this.ButtonResult.TabIndex = 7;
            this.ButtonResult.Text = "Gerar Relatório";
            this.ButtonResult.UseVisualStyleBackColor = false;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(155, 53);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(191, 20);
            this.TextBoxName.TabIndex = 8;
            // 
            // ComboBoxSex
            // 
            this.ComboBoxSex.FormattingEnabled = true;
            this.ComboBoxSex.Location = new System.Drawing.Point(155, 91);
            this.ComboBoxSex.Name = "ComboBoxSex";
            this.ComboBoxSex.Size = new System.Drawing.Size(137, 21);
            this.ComboBoxSex.TabIndex = 9;
            // 
            // ComboBoxEmployee
            // 
            this.ComboBoxEmployee.FormattingEnabled = true;
            this.ComboBoxEmployee.Location = new System.Drawing.Point(155, 127);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(137, 21);
            this.ComboBoxEmployee.TabIndex = 10;
            // 
            // buttonLimparLista
            // 
            this.buttonLimparLista.Location = new System.Drawing.Point(214, 98);
            this.buttonLimparLista.Name = "buttonLimparLista";
            this.buttonLimparLista.Size = new System.Drawing.Size(113, 40);
            this.buttonLimparLista.TabIndex = 12;
            this.buttonLimparLista.Text = "Limpar Lista";
            this.buttonLimparLista.UseVisualStyleBackColor = true;
            this.buttonLimparLista.Click += new System.EventHandler(this.buttonLimparLista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.TextBoxId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LabelName);
            this.groupBox1.Controls.Add(this.LabelSex);
            this.groupBox1.Controls.Add(this.LabelEmployee);
            this.groupBox1.Controls.Add(this.ComboBoxEmployee);
            this.groupBox1.Controls.Add(this.TextBoxName);
            this.groupBox1.Controls.Add(this.ButtonAdd);
            this.groupBox1.Controls.Add(this.ComboBoxSex);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 208);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(116, 169);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(101, 33);
            this.buttonExcluir.TabIndex = 15;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // TextBoxId
            // 
            this.TextBoxId.Enabled = false;
            this.TextBoxId.Location = new System.Drawing.Point(155, 20);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(31, 20);
            this.TextBoxId.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonResult);
            this.groupBox2.Controls.Add(this.buttonLimparLista);
            this.groupBox2.Controls.Add(this.ButtonAutoComplete);
            this.groupBox2.Location = new System.Drawing.Point(441, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 157);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações";
            // 
            // labelInstrucao
            // 
            this.labelInstrucao.AutoSize = true;
            this.labelInstrucao.Location = new System.Drawing.Point(43, 274);
            this.labelInstrucao.Name = "labelInstrucao";
            this.labelInstrucao.Size = new System.Drawing.Size(100, 26);
            this.labelInstrucao.TabIndex = 15;
            this.labelInstrucao.Text = "Para editar um item,\r\n clique 2x nele";
            this.labelInstrucao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInstrucao.Visible = false;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInstrucao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridJovens);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVALIAÇÃO DISCURSIVA | WAGNER LUCAS GEROLDI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridJovens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.DataGridView GridJovens;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonAutoComplete;
        private System.Windows.Forms.Button ButtonResult;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.ComboBox ComboBoxSex;
        private System.Windows.Forms.ComboBox ComboBoxEmployee;
        private System.Windows.Forms.Button buttonLimparLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelInstrucao;
    }
}

