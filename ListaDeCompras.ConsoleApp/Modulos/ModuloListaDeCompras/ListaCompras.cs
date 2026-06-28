
using ListaDeCompras.ConsoleApp.Compartilhado;
using ListaDeCompras.ConsoleApp.Utilidades;

namespace ListaDeCompras.ConsoleApp.Modulos.ModuloListaDeCompras
{
    public enum StatusListaCompras
    {
        Aberta,
        Concluida
    }
    public class ListaCompras : EntidadeBase
    {
        public string Nome { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public StatusListaCompras Status { get; private set; } = StatusListaCompras.Aberta;
        public ItemListaCompras[] Itens { get; private set; } = new ItemListaCompras[100];

        public ListaCompras(string nome)
        {
            Id = GeradorIds.ObterIdListaDeCompras();
            Nome = nome;
            DataCriacao = DateTime.Now;
        }

        public void AdicionarItem(ItemListaCompras itemLista)
        {
            for (int i = 0; i < Itens.Length; i++)
            {
                if (Itens[i] == null)
                {
                    Itens[i] = itemLista;
                    return;
                }
            }
        }

        public void RemoverItem(int idItemLista)
        {
            for (int i = 0; i < Itens.Length; i++)
            {
                if (Itens[i] == null)
                    continue;

                if (Itens[i].Id == idItemLista)
                {
                    Itens[i] = null;
                    return;
                }
            }
        }

        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            ListaCompras listaAtualizada = (ListaCompras)entidadeAtualizada;

            Nome = listaAtualizada.Nome;
            Status = listaAtualizada.Status;
        }
    }
}