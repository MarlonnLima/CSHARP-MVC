using System;
using System.Windows.Forms;


public class Controler
{
    private View v;
    private CalculadorDeIMC calculadordeimc;


    public Controler(View v)
    {
        this.v = v;
        calculadordeimc = new CalculadorDeIMC();
    }

    public void ClicouCalculou(object origem, EventArgs e)
    {
        double peso = Convert.ToDouble(v.numPeso.Text);
        double altura = Convert.ToDouble(v.numAltura.Text);

        calculadordeimc.SetPeso(peso);
        calculadordeimc.SetAltura(altura); 

        double resultado = Convert.ToDouble(calculadordeimc.CalculaIMC());

        v.txResultado.Text = Convert.ToString(resultado);
    }
}