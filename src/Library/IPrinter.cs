using System;
using System.IO;

/*La clase AllInOnePrinter es reemplazada por una interface IPrinter cumpliendo asi LSP.
Las clases ConsolePrinter y FilePrinter deben implementar el mismo metodo (Polimorfismo)
En la clase AllInOnePrinter se preguntaba el destino de la impresion con una condicion
dicho metodo se remueve ya que no es necesario*/

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void Print(Recipe recipe);
    }
}