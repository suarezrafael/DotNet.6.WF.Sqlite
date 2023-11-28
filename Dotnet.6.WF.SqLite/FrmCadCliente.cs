using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dotnet._6.WF.SqLite
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // variável cpf recebe o valor do txtCpf
            var cpf = txtCpf.Text;
            var nome = txtNome.Text;
            var ativo = chkAtivo.Checked;
            // usar o banco de dados e criar variavel bd
            using (var bd = new BancoDadosContexto())
            {
                // cria uma instancia da variável cliente
                var cliente = new Cliente()
                {
                    Nome = nome,
                    Cpf = cpf,
                    Ativo = ativo
                };
                // adicionando a coleção Clientes um novo cliente
                // banco de dados.Clientes.Adicionar( um novo cliente)
                bd.Clientes.Add(cliente);
                // salva as alterações no banco cliente.db
                bd.SaveChanges();

                // atualizando o grid de clientes
                Listar();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txtId.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
            chkAtivo.Checked = false;
            txtCpf.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            using (var bd = new BancoDadosContexto())
            {
                // busca no banco o cliente pelo ID
                var cliente = bd
                        .Clientes
                        .Where(w => w.Id == Convert.ToInt32( txtId.Text) )
                        .First();

                // seta as propriedades de acordo com os campos da tela
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Ativo = chkAtivo.Checked;
                // salva as alterações
                bd.SaveChanges();
                Listar();
                LimparCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   // valida se id do cliente está vazio
            if(string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Você deve selecionar o cliente que deseja excluir.");
                return; 
            }
            // conectando no banco de dados
            using( var bd = new BancoDadosContexto())
            { 
                // buscando o cliente pelo ID no banco
                var cliente = bd
                    .Clientes
                    .Where(w=>w.Id == Convert.ToInt32( txtId.Text) )
                    .First();
                // removendo do banco esse cliente
                bd.Clientes.Remove(cliente);
                // salvando as alterações no banco
                bd.SaveChanges();
                // atualizando o grid
                Listar();
                LimparCampos();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
            LimparCampos();
        }

        private void Listar()
        {   // apaga as linhas do grid
            gridClientes.Rows.Clear();
            using (var bd = new BancoDadosContexto())
            {
                // acessando a lista de clientes do banco de dados
                var clientes = bd.Clientes.ToList();
                // percore a lista de clientes
                foreach (var cliente in clientes)
                {
                    // adiciona linhas no grid
                    gridClientes.Rows.Add(gridClientes.Rows.Count + 1,
                        cliente.Id,
                        cliente.Cpf,
                        cliente.Nome,
                        cliente.Ativo);
                }
            }
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // obtendo a linha atual que foi clicada e obtendo a celula[posicao]
            txtId.Text = gridClientes.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = gridClientes.CurrentRow.Cells[2].Value.ToString();
            txtNome.Text = gridClientes.CurrentRow.Cells[3].Value.ToString();
            chkAtivo.Checked = (bool)gridClientes.CurrentRow.Cells[4].Value;
        }
    }
}
