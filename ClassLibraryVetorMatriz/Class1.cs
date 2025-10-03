using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVetorMatriz
{
    public class ClassVetorMatriz
    {
        //propriedades
        private List<string> _produtos = new List<string>();

        //construtor
        //public todos tem acesso 
        //private somente a propria Classe tem acesso
        //protected somente outra classe dentro do mesmo projeto
        public ClassVetorMatriz(List<string> produtos)

        {
            this._produtos = produtos;
        }

        //metodos
        //funçoes VOID é para execução
        //funcoes tipadas (string, int e etc)
        //para alteracoes de valores (return)
        //adicionar
        public void Adicionar(string produto)
        {
            _produtos.Add(produto);
        }
        public void Remover(string produto)
        {
            _produtos.Remove(produto);
        }

        //Arrow Function "=>"
       public List<string> ListarTodos() =>
       
          new List<string>(_produtos);

        public void Ordenar()
        { 
            _produtos.Sort();

        }

        public bool Pesquisar(string produto) 
        {
          return _produtos.Contains(produto, StringComparer.OrdinalIgnoreCase);
        }

    }
}
