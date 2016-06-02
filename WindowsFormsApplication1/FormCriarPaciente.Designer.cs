namespace WindowsFormsApplication1
{
    partial class FormCriarPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSNS = new System.Windows.Forms.TextBox();
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.radBFem = new System.Windows.Forms.RadioButton();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGlicemia = new System.Windows.Forms.TextBox();
            this.txtTensao = new System.Windows.Forms.TextBox();
            this.txtColestrol = new System.Windows.Forms.TextBox();
            this.txtSaturacao = new System.Windows.Forms.TextBox();
            this.txtBatimento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnImportarMed = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCriarPaciente = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados Não Clínicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dados Clínicos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(944, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Históricos de Exames e Medicação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "nº Sns ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Primeiro Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apelido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Data de Nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Morada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Código Postal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Contacto telefónico";
            // 
            // txtSNS
            // 
            this.txtSNS.Location = new System.Drawing.Point(248, 89);
            this.txtSNS.Name = "txtSNS";
            this.txtSNS.Size = new System.Drawing.Size(100, 20);
            this.txtSNS.TabIndex = 12;
            this.txtSNS.TextChanged += new System.EventHandler(this.txtSNS_TextChanged);
            this.txtSNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSNS_KeyPress);
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.Location = new System.Drawing.Point(248, 123);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(198, 20);
            this.txtPrimeiroNome.TabIndex = 13;
            this.txtPrimeiroNome.TextChanged += new System.EventHandler(this.txtPrimeiroNome_TextChanged);
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(248, 162);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(198, 20);
            this.txtApelido.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(248, 234);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(198, 20);
            this.txtMorada.TabIndex = 16;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(248, 268);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(198, 20);
            this.txtCodigoPostal.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(248, 307);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(248, 348);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 19;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // radBFem
            // 
            this.radBFem.AutoSize = true;
            this.radBFem.Location = new System.Drawing.Point(339, 348);
            this.radBFem.Name = "radBFem";
            this.radBFem.Size = new System.Drawing.Size(67, 17);
            this.radBFem.TabIndex = 20;
            this.radBFem.TabStop = true;
            this.radBFem.Text = "Feminino";
            this.radBFem.UseVisualStyleBackColor = true;
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Location = new System.Drawing.Point(430, 348);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(51, 17);
            this.rbOutro.TabIndex = 21;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(248, 382);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(198, 20);
            this.txtTelefone.TabIndex = 22;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(541, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(592, 87);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(50, 20);
            this.txtPeso.TabIndex = 24;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(648, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(713, 86);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(50, 20);
            this.txtAltura.TabIndex = 26;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(541, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 21);
            this.label15.TabIndex = 27;
            this.label15.Text = "Glicemia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(541, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 21);
            this.label16.TabIndex = 28;
            this.label16.Text = "Tensão Arterial";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(541, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 21);
            this.label17.TabIndex = 29;
            this.label17.Text = "Colestrol";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(541, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 21);
            this.label18.TabIndex = 30;
            this.label18.Text = "Saturação O2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(541, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 21);
            this.label19.TabIndex = 31;
            this.label19.Text = "Batimento Cardíaco";
            // 
            // txtGlicemia
            // 
            this.txtGlicemia.Location = new System.Drawing.Point(713, 126);
            this.txtGlicemia.Name = "txtGlicemia";
            this.txtGlicemia.Size = new System.Drawing.Size(127, 20);
            this.txtGlicemia.TabIndex = 32;
            this.txtGlicemia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGlicemia_KeyPress);
            // 
            // txtTensao
            // 
            this.txtTensao.Location = new System.Drawing.Point(713, 159);
            this.txtTensao.Name = "txtTensao";
            this.txtTensao.Size = new System.Drawing.Size(127, 20);
            this.txtTensao.TabIndex = 33;
            this.txtTensao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTensao_KeyPress);
            // 
            // txtColestrol
            // 
            this.txtColestrol.Location = new System.Drawing.Point(713, 198);
            this.txtColestrol.Name = "txtColestrol";
            this.txtColestrol.Size = new System.Drawing.Size(127, 20);
            this.txtColestrol.TabIndex = 34;
            this.txtColestrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColestrol_KeyPress);
            // 
            // txtSaturacao
            // 
            this.txtSaturacao.Location = new System.Drawing.Point(713, 234);
            this.txtSaturacao.Name = "txtSaturacao";
            this.txtSaturacao.Size = new System.Drawing.Size(127, 20);
            this.txtSaturacao.TabIndex = 35;
            this.txtSaturacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaturacao_KeyPress);
            // 
            // txtBatimento
            // 
            this.txtBatimento.Location = new System.Drawing.Point(713, 268);
            this.txtBatimento.Name = "txtBatimento";
            this.txtBatimento.Size = new System.Drawing.Size(127, 20);
            this.txtBatimento.TabIndex = 36;
            this.txtBatimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatimento_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Criar Medicação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1091, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 38);
            this.button3.TabIndex = 39;
            this.button3.Text = "Criar Exame";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnImportarMed
            // 
            this.btnImportarMed.Location = new System.Drawing.Point(948, 162);
            this.btnImportarMed.Name = "btnImportarMed";
            this.btnImportarMed.Size = new System.Drawing.Size(95, 37);
            this.btnImportarMed.TabIndex = 40;
            this.btnImportarMed.Text = "Carregar Medicação";
            this.btnImportarMed.UseVisualStyleBackColor = true;
            this.btnImportarMed.Click += new System.EventHandler(this.btnImportarMed_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1091, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 37);
            this.button2.TabIndex = 41;
            this.button2.Text = "Carregar Exame";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCriarPaciente
            // 
            this.btnCriarPaciente.Location = new System.Drawing.Point(545, 435);
            this.btnCriarPaciente.Name = "btnCriarPaciente";
            this.btnCriarPaciente.Size = new System.Drawing.Size(89, 43);
            this.btnCriarPaciente.TabIndex = 42;
            this.btnCriarPaciente.Text = "Criar Paciente";
            this.btnCriarPaciente.UseVisualStyleBackColor = true;
            this.btnCriarPaciente.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(652, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 43);
            this.button5.TabIndex = 43;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1271, 504);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCriarPaciente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnImportarMed);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBatimento);
            this.Controls.Add(this.txtSaturacao);
            this.Controls.Add(this.txtColestrol);
            this.Controls.Add(this.txtTensao);
            this.Controls.Add(this.txtGlicemia);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.rbOutro);
            this.Controls.Add(this.radBFem);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtPrimeiroNome);
            this.Controls.Add(this.txtSNS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registar Paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSNS;
        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.RadioButton radBFem;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGlicemia;
        private System.Windows.Forms.TextBox txtTensao;
        private System.Windows.Forms.TextBox txtColestrol;
        private System.Windows.Forms.TextBox txtSaturacao;
        private System.Windows.Forms.TextBox txtBatimento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnImportarMed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCriarPaciente;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

