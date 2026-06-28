
using System.Diagnostics.CodeAnalysis;
using ListaDeCompras.ConsoleApp.Compartilhado;
using ListaDeCompras.ConsoleApp.Modulos.ModuloCategoria;
using ListaDeCompras.ConsoleApp.Utilidades;
/*
- Nome (2 a 100 caracteres)

- Categoria (seleção obrigatória)
- Unidade de medida (ex: kg, unidade, litro, caixa)
- Preço aproximado
*/
namespace ListaDeCompras.ConsoleApp.Modulos.ModuloProduto
{
    public enum UnidadeMedidaProduto
    {
        Unidade,
        Caixa,
        Duzia,
        Kg,
        L,
        Ml,
        G

    }
    public class Produto : EntidadeBase
    {

        public string Nome { get; private set; }

        public Categoria Categoria { get; private set; }
        public int ValorUnidadeMedida { get; private set; }
        public UnidadeMedidaProduto UnidadeMedida { get; private set; }
        public decimal PrecoAproximado { get; private set; }

        public Produto
        (string nome, 
        Categoria categoria, 
        int valorUnidadeMedida, 
        UnidadeMedidaProduto unidadeMedida, 
        decimal     precoAproximado)
        {
            Id = GeradorIds.ObterIdProduto();
            this.Nome = nome;
            this.Categoria = categoria;
            this.UnidadeMedida = unidadeMedida;
            this.ValorUnidadeMedida = valorUnidadeMedida;        
            this.PrecoAproximado = precoAproximado;
        }
        public override void Atualizar(EntidadeBase entidadeAtualizada)
        {
            throw new NotImplementedException();
        }
    }
}