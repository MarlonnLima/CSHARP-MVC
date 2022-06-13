using System;
using System.Drawing;
using System.Windows.Forms;


//Declaração da class View
public class View : Form {
//View adquire as propriedades da classe Form da biblioteca System.Windows.Forms 

    //instancia as classes para só serem iniciadas na View
    public Controler c;
    public TextBox numPeso;
    public TextBox numAltura;    
    public Button btBotaoCalculaImc;    
    public TextBox txResultado;

    public View() 
    {
        // Método construtor da View - Aqui será inserido a Interface 
        c = new Controler(this);
        // Insere um Texto para a Janela
        Text = "Calculadora de IMC";

        // Cria as caixas de texto e um botão(inicia as classes que foram instanciadas acima)
        numPeso = new TextBox();
        numAltura = new TextBox();
        txResultado = new TextBox();
        btBotaoCalculaImc = new Button();

        //insere texto nas caixas de texto com intuito de informar ao usuario o campo correto como um label
        numPeso.Text = "Peso";
        numAltura.Text = "Altura";

        //insere texto ao botão
        btBotaoCalculaImc.Text = "Calcular";

        // põe uma imagem no bg
         Image myimage = new Bitmap(@"bg.jpg");
        this.BackgroundImage = myimage;
        
        // põe um icone na janela
        Icon icon = Icon.ExtractAssociatedIcon("icon.ico");
        this.Icon = icon; 
      

        //define a posição da janela onde irão surgir
        btBotaoCalculaImc.Location = new Point(90, 150);
        numAltura.Location = new Point(50, 60);
        txResultado.Location = new Point(50, 100);
        numPeso.Location = new Point (50, 20);

        // redimenciona o tamanho dos elementos na janela
        btBotaoCalculaImc.Size = new Size(100, 30);
        numAltura.Size = new Size(180, 50);
        txResultado.Size = new Size(180, 50);
        numPeso.Size = new Size(180, 50);

        //adiciona os elementos graficos criados acima na coleção de controle 
        Controls.Add(btBotaoCalculaImc);
        Controls.Add(numPeso);
        Controls.Add(numAltura);
        Controls.Add(txResultado);


       /* 
       Aqui quando clicado o botão a View passa a bola pro controlador
       para que ele realize o método dele de CalcularIMC.
       */

        btBotaoCalculaImc.Click += new System.EventHandler(c.ClicouCalculou);

       
    }


}