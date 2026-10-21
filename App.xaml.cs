namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
        //Método para definir o tamanho da janela do aplicativo
        protected override Window CreateWindow(IActivationState activationState)
        {
            // Chama o método base para criar a janela  var = variável
            var window = base.CreateWindow(activationState);

            // Define o tamanho da janela
            window.Width = 400;
            window.Height = 600;

            return window;
        }

    } // Fecha classe -- sempre declarar método dentro da classe
} // Fecha namespace 