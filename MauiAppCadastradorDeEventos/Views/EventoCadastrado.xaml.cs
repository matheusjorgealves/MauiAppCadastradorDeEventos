using MauiAppCadastradorDeEventos.Models;

namespace MauiAppCadastradorDeEventos.Views;

[QueryProperty(nameof(Evento), "Evento")] // Permite receber o objeto Evento como parâmetro na navegação
public partial class EventoCadastrado : ContentPage
{
    private Evento _evento;

    public Evento Evento
    {
        get => _evento;
        set
        {
            _evento = value;
            BindingContext = _evento;
        }
    } // Propriedade para receber o objeto Evento e definir o BindingContext da página

    public EventoCadastrado()
    {
        InitializeComponent();
    }

    async void VoltarPagina(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    } // Método para voltar à página anterior usando a navegação do Shell
}