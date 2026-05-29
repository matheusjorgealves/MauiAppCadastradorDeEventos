using MauiAppCadastradorDeEventos.Views;

namespace MauiAppCadastradorDeEventos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EventoCadastrado),
                                  typeof(EventoCadastrado));
        }
    }
}
