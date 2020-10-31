using System;
using System.Collections.Generic;


namespace Entity
{
    public class LiquidacionSinEmplazamiento : LiquidacionImpuesto
    {
        public const decimal PORCENTAJE_SIN_EMPLAZAMIENTO = 0.03M;
        public LiquidacionSinEmplazamiento(string codigoLiquidacion, decimal ingresosContribuyente, string fechaDeclaracion, string fechaDePlazo) : base(codigoLiquidacion, "SE", ingresosContribuyente,fechaDeclaracion,fechaDePlazo)
        {
        }
        public LiquidacionSinEmplazamiento()
        {

        }

        public override void CalcularSancion()
        {
            ValorSancion = ValorImpuesto * DiasExtemporaneidad * PORCENTAJE_SIN_EMPLAZAMIENTO;
        }
    }
}
