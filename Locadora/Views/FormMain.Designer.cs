namespace Locadora
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarLocacao = new System.Windows.Forms.Button();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.buttonCadastrarMarca = new System.Windows.Forms.Button();
            this.btnLocacoes = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Locações Realizadas:";
            // 
            // btnIniciarLocacao
            // 
            this.btnIniciarLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIniciarLocacao.Location = new System.Drawing.Point(33, 206);
            this.btnIniciarLocacao.Name = "btnIniciarLocacao";
            this.btnIniciarLocacao.Size = new System.Drawing.Size(110, 23);
            this.btnIniciarLocacao.TabIndex = 2;
            this.btnIniciarLocacao.Text = "Iniciar Locação";
            this.btnIniciarLocacao.UseVisualStyleBackColor = false;
            this.btnIniciarLocacao.Click += new System.EventHandler(this.btnIniciarLocacao_Click);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrarCarro.Location = new System.Drawing.Point(33, 235);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(110, 23);
            this.btnCadastrarCarro.TabIndex = 3;
            this.btnCadastrarCarro.Text = "Carro";
            this.btnCadastrarCarro.UseVisualStyleBackColor = false;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(33, 264);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(111, 23);
            this.btnCadastrarCliente.TabIndex = 4;
            this.btnCadastrarCliente.Text = "Clientes";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(194, 235);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(111, 23);
            this.btnCadastrarCategoria.TabIndex = 5;
            this.btnCadastrarCategoria.Text = "Categoria";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = false;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // buttonCadastrarMarca
            // 
            this.buttonCadastrarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCadastrarMarca.Location = new System.Drawing.Point(194, 264);
            this.buttonCadastrarMarca.Name = "buttonCadastrarMarca";
            this.buttonCadastrarMarca.Size = new System.Drawing.Size(111, 23);
            this.buttonCadastrarMarca.TabIndex = 6;
            this.buttonCadastrarMarca.Text = "Marca";
            this.buttonCadastrarMarca.UseVisualStyleBackColor = false;
            this.buttonCadastrarMarca.Click += new System.EventHandler(this.buttonCadastrarMarca_Click);
            // 
            // btnLocacoes
            // 
            this.btnLocacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLocacoes.Location = new System.Drawing.Point(195, 206);
            this.btnLocacoes.Name = "btnLocacoes";
            this.btnLocacoes.Size = new System.Drawing.Size(110, 23);
            this.btnLocacoes.TabIndex = 7;
            this.btnLocacoes.Text = "Mostrar locações";
            this.btnLocacoes.UseVisualStyleBackColor = false;
            this.btnLocacoes.Click += new System.EventHandler(this.btnLocacoes_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFinalizar.Location = new System.Drawing.Point(194, 26);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(111, 23);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 344);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLocacoes);
            this.Controls.Add(this.buttonCadastrarMarca);
            this.Controls.Add(this.btnCadastrarCategoria);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.btnIniciarLocacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarLocacao;
        private System.Windows.Forms.Button btnCadastrarCarro;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.Button buttonCadastrarMarca;
        private System.Windows.Forms.Button btnLocacoes;
        private System.Windows.Forms.Button btnFinalizar;
    }
}