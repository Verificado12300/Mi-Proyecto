using System;

namespace SistemaPOS.Models
{
    public class Caja
    {
        public int CajaID { get; set; }
        public int UsuarioID { get; set; }
        public string Turno { get; set; } // MAÑANA, TARDE, NOCHE
        public DateTime FechaApertura { get; set; }
        public TimeSpan HoraApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public TimeSpan? HoraCierre { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal TotalVentas { get; set; }
        public decimal TotalEfectivo { get; set; }
        public decimal TotalYape { get; set; }
        public decimal TotalTarjeta { get; set; }
        public decimal TotalTransferencia { get; set; }
        public decimal TotalCredito { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal EfectivoEsperado { get; set; }
        public decimal EfectivoReal { get; set; }
        public decimal Diferencia { get; set; }
        public string MotivoDiferencia { get; set; }
        public string Estado { get; set; } // ABIERTA, CERRADA
    }
}
