using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppCadastradorDeEventos.Models
{
    public class Evento
    {
        
        public string NomeEvento { get; set; }
        public string LocalEvento { get; set; }
        // String

        public int Participantes { get; set; }
        public decimal ValorPorParticipante { get; set; }
        // Stepper

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        // Date

        public int DuracaoDias
        {
            get
            {
                return (DataFim - DataInicio).Days;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return Participantes * ValorPorParticipante;
            }
        }
    }
}
