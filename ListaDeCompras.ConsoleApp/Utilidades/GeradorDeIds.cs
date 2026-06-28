namespace ListaDeCompras.ConsoleApp.Utilidades;

public static class GeradorIds
{
    private static int contadorIdsCategoria = 1;
    private static int contadorIdsProduto = 1;
    private static int contadorIdsItemListaDeCompras = 1;
    private static int contadorIdsListaDeCompras = 1;

    public static int ObterIdCategoria()
    {
        return contadorIdsCategoria++;
    }

    public static int ObterIdProduto()
    {
        return contadorIdsProduto++;
    }

    public static int ObterIdItemListaCompras()
    {
        return contadorIdsItemListaDeCompras++;
    }

    public static int ObterIdListaDeCompras()
    {
        return contadorIdsListaDeCompras++;
    }
}