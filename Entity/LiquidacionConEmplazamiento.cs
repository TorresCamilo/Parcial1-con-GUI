using System;
using System.Collections.Generic;


namespace Entity
{
    public class LiquidacionConEmplazamiento : LiquidacionImpuesto
    {
        public const decimal SMLDV = 980657 / 30M;

        public LiquidacionConEmplazamiento(string codigoLiquidacion, decimal ingresosContribuyente, string fechaDeclaracion, string fechaDePlazo) : base(codigoLiquidacion, "CE", ingresosContribuyente, fechaDeclaracion, fechaDePlazo)
        {

        }
        public LiquidacionConEmplazamiento()
        {

        }
        public override void CalcularSancion()
        {
            ValorSancion = (ValorImpuesto * DiasExtemporaneidad) + (4 * SMLDV);
        }
    }
}
