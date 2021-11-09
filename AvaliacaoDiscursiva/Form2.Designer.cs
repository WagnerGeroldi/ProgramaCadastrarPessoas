
namespace AvaliacaoDiscursiva
{
    partial class FormResultado
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.ButtonCloseResult = new System.Windows.Forms.Button();
            this.TextBoxHomemEmpregado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxResultadoPorcentagemMulherDesempregado = new System.Windows.Forms.TextBox();
            this.TextBoxResultadoPorcentagemMulherEmpregado = new System.Windows.Forms.TextBox();
            this.TextBoxResultadoPorcentagemHomemDesempregado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxResultadoPorcentagemHomemEmpregado = new System.Windows.Forms.TextBox();
            this.TextBoxTotalEntrevistados = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxHomemDesempregado = new System.Windows.Forms.TextBox();
            this.TextBoxMulherEmpregada = new System.Windows.Forms.TextBox();
            this.TextBoxMulherDesempregada = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(296, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "RESULTADO PESQUISA";
            // 
            // ButtonCloseResult
            // 
            this.ButtonCloseResult.Location = new System.Drawing.Point(333, 388);
            this.ButtonCloseResult.Name = "ButtonCloseResult";
            this.ButtonCloseResult.Size = new System.Drawing.Size(147, 34);
            this.ButtonCloseResult.TabIndex = 2;
            this.ButtonCloseResult.Text = "Fechar Resultado";
            this.ButtonCloseResult.UseVisualStyleBackColor = true;
            this.ButtonCloseResult.Click += new System.EventHandler(this.ButtonCloseResult_Click);
            // 
            // TextBoxHomemEmpregado
            // 
            this.TextBoxHomemEmpregado.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxHomemEmpregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxHomemEmpregado.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBoxHomemEmpregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHomemEmpregado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxHomemEmpregado.Location = new System.Drawing.Point(175, 171);
            this.TextBoxHomemEmpregado.Name = "TextBoxHomemEmpregado";
            this.TextBoxHomemEmpregado.ReadOnly = true;
            this.TextBoxHomemEmpregado.Size = new System.Drawing.Size(23, 15);
            this.TextBoxHomemEmpregado.TabIndex = 3;
            this.TextBoxHomemEmpregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "O total de Homens Empregados é";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "O total de Homens Desempregados é";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "O total de Mulheres Empregadas é";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "O total de Mulheres Desempregadas é ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TextBoxResultadoPorcentagemMulherDesempregado);
            this.groupBox1.Controls.Add(this.TextBoxResultadoPorcentagemMulherEmpregado);
            this.groupBox1.Controls.Add(this.TextBoxResultadoPorcentagemHomemDesempregado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextBoxResultadoPorcentagemHomemEmpregado);
            this.groupBox1.Controls.Add(this.TextBoxTotalEntrevistados);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxHomemDesempregado);
            this.groupBox1.Controls.Add(this.TextBoxMulherEmpregada);
            this.groupBox1.Controls.Add(this.TextBoxMulherDesempregada);
            this.groupBox1.Controls.Add(this.TextBoxHomemEmpregado);
            this.groupBox1.Location = new System.Drawing.Point(127, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantidades";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = ". Este valor corresponde a: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = ". Este valor corresponde a: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = ". Este valor corresponde a: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = ". Este valor corresponde a: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(375, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(354, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // TextBoxResultadoPorcentagemMulherDesempregado
            // 
            this.TextBoxResultadoPorcentagemMulherDesempregado.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResultadoPorcentagemMulherDesempregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxResultadoPorcentagemMulherDesempregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadoPorcentagemMulherDesempregado.Location = new System.Drawing.Point(358, 65);
            this.TextBoxResultadoPorcentagemMulherDesempregado.Name = "TextBoxResultadoPorcentagemMulherDesempregado";
            this.TextBoxResultadoPorcentagemMulherDesempregado.Size = new System.Drawing.Size(27, 15);
            this.TextBoxResultadoPorcentagemMulherDesempregado.TabIndex = 21;
            // 
            // TextBoxResultadoPorcentagemMulherEmpregado
            // 
            this.TextBoxResultadoPorcentagemMulherEmpregado.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResultadoPorcentagemMulherEmpregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxResultadoPorcentagemMulherEmpregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadoPorcentagemMulherEmpregado.Location = new System.Drawing.Point(338, 101);
            this.TextBoxResultadoPorcentagemMulherEmpregado.Name = "TextBoxResultadoPorcentagemMulherEmpregado";
            this.TextBoxResultadoPorcentagemMulherEmpregado.Size = new System.Drawing.Size(27, 15);
            this.TextBoxResultadoPorcentagemMulherEmpregado.TabIndex = 20;
            // 
            // TextBoxResultadoPorcentagemHomemDesempregado
            // 
            this.TextBoxResultadoPorcentagemHomemDesempregado.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResultadoPorcentagemHomemDesempregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxResultadoPorcentagemHomemDesempregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadoPorcentagemHomemDesempregado.Location = new System.Drawing.Point(353, 137);
            this.TextBoxResultadoPorcentagemHomemDesempregado.Name = "TextBoxResultadoPorcentagemHomemDesempregado";
            this.TextBoxResultadoPorcentagemHomemDesempregado.Size = new System.Drawing.Size(27, 15);
            this.TextBoxResultadoPorcentagemHomemDesempregado.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "%";
            // 
            // TextBoxResultadoPorcentagemHomemEmpregado
            // 
            this.TextBoxResultadoPorcentagemHomemEmpregado.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxResultadoPorcentagemHomemEmpregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxResultadoPorcentagemHomemEmpregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadoPorcentagemHomemEmpregado.Location = new System.Drawing.Point(340, 171);
            this.TextBoxResultadoPorcentagemHomemEmpregado.Name = "TextBoxResultadoPorcentagemHomemEmpregado";
            this.TextBoxResultadoPorcentagemHomemEmpregado.Size = new System.Drawing.Size(27, 15);
            this.TextBoxResultadoPorcentagemHomemEmpregado.TabIndex = 17;
            // 
            // TextBoxTotalEntrevistados
            // 
            this.TextBoxTotalEntrevistados.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxTotalEntrevistados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTotalEntrevistados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTotalEntrevistados.Location = new System.Drawing.Point(412, 18);
            this.TextBoxTotalEntrevistados.Name = "TextBoxTotalEntrevistados";
            this.TextBoxTotalEntrevistados.Size = new System.Drawing.Size(28, 15);
            this.TextBoxTotalEntrevistados.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total de pessoas entrevistadas: ";
            // 
            // TextBoxHomemDesempregado
            // 
            this.TextBoxHomemDesempregado.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxHomemDesempregado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxHomemDesempregado.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBoxHomemDesempregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHomemDesempregado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxHomemDesempregado.Location = new System.Drawing.Point(191, 136);
            this.TextBoxHomemDesempregado.Name = "TextBoxHomemDesempregado";
            this.TextBoxHomemDesempregado.ReadOnly = true;
            this.TextBoxHomemDesempregado.Size = new System.Drawing.Size(23, 15);
            this.TextBoxHomemDesempregado.TabIndex = 10;
            this.TextBoxHomemDesempregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxMulherEmpregada
            // 
            this.TextBoxMulherEmpregada.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxMulherEmpregada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMulherEmpregada.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBoxMulherEmpregada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMulherEmpregada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxMulherEmpregada.Location = new System.Drawing.Point(178, 100);
            this.TextBoxMulherEmpregada.Name = "TextBoxMulherEmpregada";
            this.TextBoxMulherEmpregada.ReadOnly = true;
            this.TextBoxMulherEmpregada.Size = new System.Drawing.Size(23, 15);
            this.TextBoxMulherEmpregada.TabIndex = 9;
            this.TextBoxMulherEmpregada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxMulherDesempregada
            // 
            this.TextBoxMulherDesempregada.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxMulherDesempregada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMulherDesempregada.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBoxMulherDesempregada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMulherDesempregada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxMulherDesempregada.Location = new System.Drawing.Point(197, 64);
            this.TextBoxMulherDesempregada.Name = "TextBoxMulherDesempregada";
            this.TextBoxMulherDesempregada.ReadOnly = true;
            this.TextBoxMulherDesempregada.Size = new System.Drawing.Size(23, 15);
            this.TextBoxMulherDesempregada.TabIndex = 8;
            this.TextBoxMulherDesempregada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonCloseResult);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADO";
            this.Load += new System.EventHandler(this.FormResultado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button ButtonCloseResult;
        private System.Windows.Forms.TextBox TextBoxHomemEmpregado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxHomemDesempregado;
        private System.Windows.Forms.TextBox TextBoxMulherEmpregada;
        private System.Windows.Forms.TextBox TextBoxMulherDesempregada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxTotalEntrevistados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxResultadoPorcentagemHomemEmpregado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxResultadoPorcentagemMulherDesempregado;
        private System.Windows.Forms.TextBox TextBoxResultadoPorcentagemMulherEmpregado;
        private System.Windows.Forms.TextBox TextBoxResultadoPorcentagemHomemDesempregado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}