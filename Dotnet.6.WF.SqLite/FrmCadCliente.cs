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
            using ( var bd = new BancoDadosContexto() ) 
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
                bd.Clientes.Add( cliente );
                // salva as alterações no banco cliente.db
                bd.SaveChanges();

                // atualizando o grid de clientes
                gridClientes.DataSource = bd.Clientes.ToList();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            using( var bd = new BancoDadosContexto())
            {
                // busca no banco o primeiro cliente
                var cliente = bd.Clientes.First();
                // seta as propriedades de acordo com os campos da tela
                cliente.Nome = txtNome.Text;
                cliente.Cpf = txtCpf.Text;
                cliente.Ativo = chkAtivo.Checked;
                // salva as alterações
                bd.SaveChanges();
                gridClientes.DataSource = bd.Clientes.ToList();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            using (var bd = new BancoDadosContexto())
            {
                // determina a origem dos dados do grid
                // obtendo a lista de clientes do banco
                gridClientes.DataSource = bd.Clientes.ToList();
            }
        }

    }
}
