using Microsoft.Extensions.DependencyInjection;

namespace MauiAppCadastradorDeEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState) // cria a janela principal do aplicativo
        {
            var window = new Window(new AppShell()); // cria uma nova janela e define como principal janela do aplicativo

            window.Width = 400;
            window.Height = 800;

            return window; // retorna a janela criada
        }
    }
}