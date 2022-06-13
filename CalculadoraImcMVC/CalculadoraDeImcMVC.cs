using System;
using System.Windows.Forms;

 //Método Main para iniciar a aplicação e passar a bola da vez para a View

public class CalculadoraDeImcMVC
{
    public static void Main()
    {
        View v = new View();
        
        Application.Run(v);
    }
}