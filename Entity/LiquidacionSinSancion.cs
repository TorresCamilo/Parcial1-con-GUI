using System;
using System.Collections.Generic;


namespace Entity
{
    public class LiquidacionSinSancion : LiquidacionImpuesto
    {
        public LiquidacionSinSancion(string codigoLiquidacion, decimal ingresosContribuyente, string fechaDeclaracion, string fechaDePlazo) : base(codigoLiquidacion, "SS", ingresosContribuyente, fechaDeclaracion, fechaDePlazo)
        {
        }
        public LiquidacionSinSancion()
        {

        }

        public override void CalcularSancion()
        {
            ValorSancion = 0;
        }
        
    }
}
