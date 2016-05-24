namespace WindowsFormsApplication1
{
    partial class FormPesquisaUtilizador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxProcurar = new System.Windows.Forms.TextBox();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonSuspensao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxProcurar
            // 
            this.textBoxProcurar.Location = new System.Drawing.Point(13, 7);
            this.textBoxProcurar.Name = "textBoxProcurar";
            this.textBoxProcurar.Size = new System.Drawing.Size(174, 20);
            this.textBoxProcurar.TabIndex = 1;
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcurar.Location = new System.Drawing.Point(193, 5);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurar.TabIndex = 2;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(787, 4);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 3;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(151, 447);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(176, 35);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.Text = "Alterar Utilizador";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonSuspensao
            // 
            this.buttonSuspensao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuspensao.Location = new System.Drawing.Point(517, 447);
            this.buttonSuspensao.Name = "buttonSuspensao";
            this.buttonSuspensao.Size = new System.Drawing.Size(175, 35);
            this.buttonSuspensao.TabIndex = 5;
            this.buttonSuspensao.Text = "Alterar Suspensão";
            this.buttonSuspensao.UseVisualStyleBackColor = true;
            this.buttonSuspensao.Click += new System.EventHandler(this.buttonSuspensao_Click);
            // 
            // FormPesquisaUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 514);
            this.Controls.Add(this.buttonSuspensao);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.textBoxProcurar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPesquisaUtilizador";
            this.Text = "FormPesquisaUtilizador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxProcurar;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonSuspensao;
    }
}