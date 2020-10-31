using System;
using System.Collections.Generic;
using System.IO;
using Entity;

namespace DAL
{
    public class LiquidacionImpuestoRepository
    {
        private readonly string fileName = "LiquidacionesDeImpuestos.txt";
        
        public void Guardar(LiquidacionImpuesto liquidacionImpuesto)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(liquidacionImpuesto.FormatoParaArchivo());
            //CerrarArchivo(file, writer);
            writer.Close();
            file.Close();
        }
        public List<LiquidacionImpuesto> ConsultarTodos()
        {
            List<LiquidacionImpuesto> liquidacionesDelFile = new List<LiquidacionImpuesto>();

            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;

            while ((linea = reader.ReadLine()) != null)
            {
                liquidacionesDelFile.Add(Map(linea));
            }

            reader.Close();
            file.Close();

            return liquidacionesDelFile;
        }
        public LiquidacionImpuesto Buscar(string codigoLiquidacion)
        {
            List<LiquidacionImpuesto> listaLiquidaciones = ConsultarTodos();
            foreach (var liquidacion in listaLiquidaciones)
            {
                if (liquidacion.CodigoLiquidacion.Equals(codigoLiquidacion))
                    return liquidacion;
            }
            return null;
        }
        
        public void Eliminar(LiquidacionImpuesto liquidacionParaEliminar)
        {
            List<LiquidacionImpuesto> listaLiquidaciones = ConsultarTodos();
            FileStream file = new FileStream(fileName, FileMode.Create);
            file.Close();
            
            foreach (var liquidacion in listaLiquidaciones)
            {
                if ( ! (liquidacion.Equals(liquidacionParaEliminar)) )
                {
                    Guardar(liquidacion);
                }
            }

        }
        //Este metodo no supe como aplicarlo.
        public void Modificar(LiquidacionImpuesto liquidacionFirst, LiquidacionImpuesto liquidacionNew)
        {
            List<LiquidacionImpuesto> listaLiquidaciones = ConsultarTodos();
            FileStream file = new FileStream(fileName, FileMode.Create);
            file.Close();
            foreach (var liquidacion in listaLiquidaciones)
            {
                if (!(liquidacion.Equals(liquidacionFirst)))
                    Guardar(liquidacion);
                else
                    Guardar(liquidacionNew);
            }
        }
        public void ModificarFechaDeclaracion(LiquidacionImpuesto liquidacionInicial, DateTime fechaDeclaracionNew)
        {
            List<LiquidacionImpuesto> listaLiquidaciones = ConsultarTodos();
            FileStream file = new FileStream(fileName, FileMode.Create);
            file.Close();
            foreach (var liquidacion in listaLiquidaciones)
            {
                if (!(liquidacion.Equals(liquidacionInicial)))
                    Guardar(liquidacion);
                else
                {
                    liquidacionInicial.FechaDeclaracion = fechaDeclaracionNew;
                    Guardar(liquidacionInicial);
                }
            }
        }


        private LiquidacionImpuesto Map(string linea)
        {
            string[] datoLiquidacion = linea.Split(';');
            LiquidacionImpuesto liquidacionImpuesto = InstanciarPorTipoLiquidacion(datoLiquidacion[1]);

            liquidacionImpuesto.CodigoLiquidacion = datoLiquidacion[0];
            liquidacionImpuesto.TipoLiquidacion = datoLiquidacion[1];
            liquidacionImpuesto.IngresosContribuyente = Convert.ToDecimal(datoLiquidacion[2]);
            liquidacionImpuesto.FechaDeclaracion = Convert.ToDateTime(datoLiquidacion[3]);
            liquidacionImpuesto.FechaDePlazo = Convert.ToDateTime(datoLiquidacion[4]);
            liquidacionImpuesto.DiasExtemporaneidad = Convert.ToInt32(datoLiquidacion[5]);
            liquidacionImpuesto.ValorImpuesto = Convert.ToDecimal(datoLiquidacion[6]);
            liquidacionImpuesto.ValorSancion = Convert.ToDecimal(datoLiquidacion[7]);
            liquidacionImpuesto.ValorTotalLiquidacion = Convert.ToDecimal(datoLiquidacion[8]);

            return liquidacionImpuesto;

        }
        private LiquidacionImpuesto InstanciarPorTipoLiquidacion(string tipoLiquidacion)
        {
            LiquidacionImpuesto liquidacionImpuesto;
            if (tipoLiquidacion.Equals("SS"))
                liquidacionImpuesto = new LiquidacionSinSancion();
            else if (tipoLiquidacion.Equals("SE"))
                liquidacionImpuesto = new LiquidacionSinEmplazamiento();
            else
                liquidacionImpuesto = new LiquidacionConEmplazamiento();
            return liquidacionImpuesto;
        }


    }
}
