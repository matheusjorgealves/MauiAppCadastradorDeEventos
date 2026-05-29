using MauiAppCadastradorDeEventos.Models;

namespace MauiAppCadastradorDeEventos.Views;

public partial class Cadastrador : ContentPage
{
	public Cadastrador()
	{
		InitializeComponent();

        dtpk_DataInicio.MinimumDate = DateTime.Today.AddDays(7);

        dtpk_DataFim.MinimumDate = dtpk_DataInicio.Date.Value.AddDays(1);
        dtpk_DataFim.MaximumDate = dtpk_DataInicio.Date.Value.AddDays(30);
    }

    void dtpk_DataInicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtpk_DataFim.MinimumDate = e.NewDate.Value.AddDays(1);
        dtpk_DataFim.MaximumDate = e.NewDate.Value.AddDays(30);

        if (dtpk_DataFim.Date < dtpk_DataFim.MinimumDate)
            dtpk_DataFim.Date = dtpk_DataFim.MinimumDate;
    }

    async void CadastrarEvento(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NomeEvento.Text) ||
            string.IsNullOrWhiteSpace(LocalEvento.Text))
        {
            await DisplayAlertAsync("Erro", "Preencha todos os campos obrigatórios.", "OK");
            return;
        }

        if (dtpk_DataFim.Date < dtpk_DataInicio.Date)
        {
            await DisplayAlertAsync("Erro", "A data final não pode ser antes da data inicial.", "OK");
            return;
        }

        var evento = new Evento
        {
            NomeEvento = NomeEvento.Text,
            LocalEvento = LocalEvento.Text,
            Participantes = (int)stp_Participantes.Value,
            ValorPorParticipante = (decimal)stp_ValorParticipante.Value,
            DataInicio = dtpk_DataInicio.Date.Value,
            DataFim = dtpk_DataFim.Date.Value
        };

        await Shell.Current.GoToAsync(nameof(EventoCadastrado), true, new Dictionary<string, object>
        {
            { "Evento", evento }
        });
    }
}