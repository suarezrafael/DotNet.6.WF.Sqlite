﻿namespace Dotnet._6.WF.SqLite
{
    partial class FrmCadCliente
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            chkAtivo = new CheckBox();
            groupBox2 = new GroupBox();
            btnAdicionar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            gridClientes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAtivo);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(759, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 32);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(19, 66);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(215, 39);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(19, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(521, 39);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(19, 207);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(91, 36);
            chkAtivo.TabIndex = 4;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnListar);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnAtualizar);
            groupBox2.Controls.Add(btnAdicionar);
            groupBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(759, 101);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(18, 32);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(142, 47);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(175, 32);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(142, 47);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(333, 32);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(142, 47);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(495, 32);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(142, 47);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(14, 387);
            gridClientes.Name = "gridClientes";
            gridClientes.RowHeadersWidth = 51;
            gridClientes.RowTemplate.Height = 29;
            gridClientes.Size = new Size(757, 264);
            gridClientes.TabIndex = 2;
            // 
            // FrmCadCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 663);
            Controls.Add(gridClientes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCadCliente";
            Text = "FrmCadCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCpf;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private CheckBox chkAtivo;
        private GroupBox groupBox2;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private Button btnListar;
        private DataGridView gridClientes;
    }
}