using ListaDeCompras.ConsoleApp.Utilidades;
using ListaDeCompras.ConsoleApp.Compartilhado;

namespace ListaDeCompras.ConsoleApp.Modulos.ModuloCategoria
{
    public enum CorCategoria
    {
        Branco,
        Vermelho,
        Verde,
        Azul
    }
    public class Categoria : EntidadeBase
    {
        public string Nome { get; private set; }
        public CorCategoria Cor { get; private set; }

        // Construtor de Classe
        // Toda instância que for criada PRECISA conter essas informações
        public Categoria(string nome, CorCategoria cor)
        {
            Id = GeradorIds.ObterIdCategoria();

            Nome = nome;
            Cor = cor;
        }

        // sobrescrita / substituição
        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            Categoria categoriaAtualizada = (Categoria)entidadeAtualizada;

            Nome = categoriaAtualizada.Nome;
            Cor = categoriaAtualizada.Cor;
        }
    }
}