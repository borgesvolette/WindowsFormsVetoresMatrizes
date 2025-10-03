using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryVetorMatriz;

namespace WindowsFormsVetoresMatrizes
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        // Lista Dinâmica de Produtos
        //privado Biblioteca (LIST) <> _objeto = new List <relacionar com string>
        //private List <string> _produtos = new List<string>(); não precisa mais só add a Biblioteca, pois esta nela 

        private ClassVetorMatriz _gestaoProdutos = new ClassVetorMatriz(new List<string> {""});
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Inicializacao/preparacao 
            string produto = tbxProduct.Text.Trim ();
            //string produtoMaiusculo = produto.ToUpper(); para pesquisar e salvar em maiusculo


            if (produto != "") //produtos. Length != 0

            { 
                _gestaoProdutos.Adicionar (produto); //produtos.Add(produtoMaiusculo); **currentCultureIgnoreCase
                MessageBox.Show($"O produto {produto} foi adicionado. ", "Adição de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxProduct.Clear ();
                tbxProduct.Focus ();
            }
            else
            {
                MessageBox.Show($"Campo Vazio, precisa preencher a caixa de texto ", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxProduct.SelectedItem != null)
            {
                //Inicializacao/preparacao 
                string produto = lbxProduct.SelectedItem.ToString();
                _gestaoProdutos.Remover(produto); //AÇão
                lbxProduct.Items.Remove(produto); //Visual caixa de Lista
                MessageBox.Show($"O produto {produto} foi removido. ", "Remoção de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show($"Selecione um item da caixa de Lista para Remover", "Remoção de Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (_gestaoProdutos.ListarTodos().Count >0)
            {
                _gestaoProdutos.Ordenar();
                MessageBox.Show("A Lista de produtos esta ordenada.", "Ordenação da Produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnList.PerformClick(); //Clique automatico
            }
            else
            {
                MessageBox.Show("A lista de produtos está vazia.", "Ordenação de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Inicializacao 
            string produto =tbxProduct.Text.Trim();

            if (produto != "") //string.Empty
            {
                if (_gestaoProdutos.Pesquisar(produto))
                {
                    MessageBox.Show($"O produto {produto} foi encontrado.", "Pesquisa de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"O produto {produto} não foi encontrado.", "Pesquisa de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else 
            {
                MessageBox.Show("A lista de produtos está vazia.", "Pesquisa de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lbxProduct.Items.Clear ();
            //primeira letra maiuscula e restante minuscula.
            //aplicar *for repetição
            //string textoFormatado = char.ToUpper(TesxtoOriginal[]) + textoOriginal.Substring(1).ToLower();

            if (_gestaoProdutos.ListarTodos().Count > 0)  // Count=Contagem
            {
                foreach (string p in _gestaoProdutos.ListarTodos()) // foreach = um para cada
                    lbxProduct.Items.Add (p); // adição um por um  (foreach)
            }
            else
            {
                MessageBox.Show(" Nenhum produto cadastrado. ");
            }

        }

        private void tbxProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdd_Click(sender, e);
            }
        }

        
    }
}
