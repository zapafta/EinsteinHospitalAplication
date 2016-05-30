namespace WindowsFormsApplication1
{
    partial class CriarMedicacao
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb100 = new System.Windows.Forms.RadioButton();
            this.radB50 = new System.Windows.Forms.RadioButton();
            this.rbSem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "Criar Medicamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(265, 203);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Preço";
            // 
            // comboMedico
            // 
            this.comboMedico.FormattingEnabled = true;
            this.comboMedico.Items.AddRange(new object[] {
            "Oral",
            "Via intravascular"});
            this.comboMedico.Location = new System.Drawing.Point(265, 176);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(198, 21);
            this.comboMedico.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Medicamentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Administração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nome do Medicamento";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(265, 135);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(198, 20);
            this.txtMedicamento.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dosagem";
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(263, 265);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(100, 20);
            this.txtDos.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Comparticipação";
            // 
            // rb100
            // 
            this.rb100.AutoSize = true;
            this.rb100.Location = new System.Drawing.Point(259, 349);
            this.rb100.Name = "rb100";
            this.rb100.Size = new System.Drawing.Size(51, 17);
            this.rb100.TabIndex = 49;
            this.rb100.TabStop = true;
            this.rb100.Text = "100%";
            this.rb100.UseVisualStyleBackColor = true;
            // 
            // radB50
            // 
            this.radB50.AutoSize = true;
            this.radB50.Location = new System.Drawing.Point(259, 326);
            this.radB50.Name = "radB50";
            this.radB50.Size = new System.Drawing.Size(45, 17);
            this.radB50.TabIndex = 48;
            this.radB50.TabStop = true;
            this.radB50.Text = "50%";
            this.radB50.UseVisualStyleBackColor = true;
            // 
            // rbSem
            // 
            this.rbSem.AutoSize = true;
            this.rbSem.Location = new System.Drawing.Point(259, 303);
            this.rbSem.Name = "rbSem";
            this.rbSem.Size = new System.Drawing.Size(127, 17);
            this.rbSem.TabIndex = 47;
            this.rbSem.TabStop = true;
            this.rbSem.Text = "Sem comparticipação";
            this.rbSem.UseVisualStyleBackColor = true;
            // 
            // CriarMedicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(926, 510);
            this.Controls.Add(this.rb100);
            this.Controls.Add(this.radB50);
            this.Controls.Add(this.rbSem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "CriarMedicacao";
            this.Text = "Criar Medicação";
            this.Load += new System.EventHandler(this.CriarMedicacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb100;
        private System.Windows.Forms.RadioButton radB50;
        private System.Windows.Forms.RadioButton rbSem;
    }
}