using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeCompras.ConsoleApp.Compartilhado
{
    public interface ITelaCrud
    {
        void Cadastrar();
        void Editar();
        void Excluir();
        void VisualizarTodos(bool deveExibirCabecalho);
    }
}