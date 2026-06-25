
using ListaDeCompras.ConsoleApp.Modulos.ModuloCategoria;

namespace ListaDeCompras.ConsoleApp.Modulos.Produto
{
    public class Produto
    {
        public string Nome { get; private set; }
        public int NumeroEdicao { get; private set; }
        public int AnoPublicacao { get; private set; }
        public StatusRevista Status { get; private set; }
        public Categoria Categoria { get; private set; }
        public bool EstaDisponivel
        {
            get
            {
                return Status == StatusRevista.Disponivel;
            }
        }

        public Produto(string titulo, int numeroEdicao, int anoPublicacao, Caixa caixa)
        {
            Id = GeradorIds.ObterIdRevista();

            Nome = titulo;
            NumeroEdicao = numeroEdicao;
            AnoPublicacao = anoPublicacao;
            Categoria = caixa;

            Status = StatusRevista.Disponivel;
        }

        public void Emprestar()
        {
            Status = StatusRevista.Emprestada;
        }

        public void Devolver()
        {
            Status = StatusRevista.Disponivel;
        }

        // substituição de método
        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Revista revistaAtualizada = (Revista)entidadeAtualizada;

            Nome = revistaAtualizada.Titulo;
            NumeroEdicao = revistaAtualizada.NumeroEdicao;
            AnoPublicacao = revistaAtualizada.AnoPublicacao;
            Categoria = revistaAtualizada.Caixa;
        }
    }
}