using System;
using System.Collections.Generic;

namespace Entity
{
    public abstract class LiquidacionImpuesto
    {

        public string CodigoLiquidacion{ get; set; }
        public string TipoLiquidacion { get; set; }
        public decimal IngresosContribuyente{ get; set; }
        public DateTime FechaDeclaracion{ get; set; }
        public DateTime FechaDePlazo{ get; set; }
        public int DiasExtemporaneidad{ get; set; }
        public decimal ValorImpuesto{ get; set; }
        public decimal ValorSancion{ get; set; }
        public decimal ValorTotalLiquidacion{ get; set; }
        
        public const decimal PORCENTAJE_IMPUESTO = 0.15M;


        public LiquidacionImpuesto(string codigoLiquidacion, string tipoLiquidacion, decimal ingresosContribuyente, string fechaDeclaracion, string fechaDePlazo)
        {
            CodigoLiquidacion = codigoLiquidacion;
            TipoLiquidacion = tipoLiquidacion;
            IngresosContribuyente = ingresosContribuyente;
            FechaDeclaracion = Convert.ToDateTime(fechaDeclaracion);
            FechaDePlazo = Convert.ToDateTime(fechaDePlazo);

            CalcularDiasExtemporaneidad();
            CalcularValorImpuesto();
            CalcularSancion();

        }
        public LiquidacionImpuesto()
        {

        }

        

        public void CalcularValorImpuesto()
        {
            ValorImpuesto = IngresosContribuyente * PORCENTAJE_IMPUESTO;
        }
        public void CalcularValorTotal()
        {
            ValorTotalLiquidacion = ValorImpuesto + ValorSancion;
        }
        public void CalcularDiasExtemporaneidad()
        {
            var fecha = FechaDeclaracion.Subtract(FechaDePlazo);
            DiasExtemporaneidad = fecha.Days;
        }
        public abstract void CalcularSancion();
        public string FormatoParaArchivo()
        {
            return $"{CodigoLiquidacion};{TipoLiquidacion};{IngresosContribuyente};" +
                $"{FechaDeclaracion.ToString("d")};{FechaDePlazo.ToString("d")};" +
                $"{DiasExtemporaneidad};{ValorImpuesto};{ValorSancion};{ValorTotalLiquidacion}";
        }
        public override string ToString()
        {
            return $"Numero de formulario: {CodigoLiquidacion}" + "\n" +
                $"Tipo de liquidacion: {TipoLiquidacion}" + "\n" +
                $"Ingresos del contribuyente: {IngresosContribuyente}" + "\n" +
                $"Fecha de declaracion: {FechaDeclaracion.ToString("d")}" + "\n" +
                $"Fecha de plazo: {FechaDePlazo.ToString("d")}" + "\n" +
                $"Dias de extemporaneidad: {DiasExtemporaneidad}" + "\n" +
                $"Valor del impuesto: {ValorImpuesto}" + "\n" +
                $"Valor sancion: {ValorSancion}" + "\n" +
                $"Valor TOTAL: {ValorTotalLiquidacion}";
        }

        public override bool Equals(object obj)
        {
            return obj is LiquidacionImpuesto impuesto &&
                   CodigoLiquidacion == impuesto.CodigoLiquidacion;
        }
    }
}
