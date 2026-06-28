

using ListaDeCompras.ConsoleApp.Modulos.ModuloProduto;
using ListaDeCompras.ConsoleApp.Utilidades;

namespace ListaDeCompras.ConsoleApp.Modulos.ModuloListaDeCompras
{
    public class ItemListaCompras
    {
        public int Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }

        public decimal PrecoTotal
        {
            get
            {
                return Produto.PrecoAproximado * Quantidade;
            }
        }

        public ItemListaCompras(Produto produto, int quantidade)
        {
            Id = GeradorIds.ObterIdItemListaCompras();
            Produto = produto;
            Quantidade = quantidade;
        }
    }
}