using System;
public class Credito
{
    public int IdCredito { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaAprobacion { get; set; }
    public DateTime FechaCierre { get; set; }

    // Constructor
    public Credito(int idCredito, decimal monto, DateTime fechaAprobacion, DateTime fechaCierre)
    {
        IdCredito = idCredito;
        Monto = monto;
        FechaAprobacion = fechaAprobacion;
        FechaCierre = fechaCierre;
    }
}


