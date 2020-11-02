using BLL;
using Entity;
using System;
using System.Collections.Generic;

namespace Presentacion
{
    class Program
    {
        private static LiquidacionImpuestosService liquidacionService = new LiquidacionImpuestosService();
        static void Main(string[] args)
        {
            int opcionIngresada;
            do
            {
                opcionIngresada = MenuPpal();
                switch (opcionIngresada)
                {
                    case 1:
                        Console.Clear();
                        Registrar(); break;
                    case 2:
                        Console.Clear();
                        Consultar(); break;
                    case 3:
                        Console.Clear();
                        Eliminar(); break;
                    case 4:
                        Console.Clear();
                        Modificar(); break;
                    default: Console.WriteLine("Bye"); break;
                }

            } while (opcionIngresada != 0);
        }
        static int MenuPpal()
        {
            Console.WriteLine("---Menu ppal---");
            Console.WriteLine("1. Registrar");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Modificar");
            Console.WriteLine("0. Exit");

            Console.Write("Seleccione -> ");
            int opcionDigitada = int.Parse(Console.ReadLine());

            return opcionDigitada;
        }
        static void Registrar()
        {
            string codigoLiquidacion, fechaDeclaracion, fechaDePlazo;
            decimal ingresosContribuyente;
            
            Console.WriteLine("Ingrese la siguiente informacion de su liquidacion: ");
            
            Console.Write("Codigo de liquidacion: ");
            codigoLiquidacion = Console.ReadLine();

            Console.Write("Ingresos del contribuyente: ");
            ingresosContribuyente = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Fecha de declaracion: ");
            fechaDeclaracion = Console.ReadLine();

            Console.Write("Fecha de plazo maximo: ");
            fechaDePlazo = Console.ReadLine();


            LiquidacionImpuesto liquidacionImpuesto;
            if (IsSancionable(fechaDeclaracion, fechaDePlazo))
            {
                Console.Write("Fue emplazado? S/N: ");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta.Equals("S"))
                    liquidacionImpuesto = new LiquidacionConEmplazamiento(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaDePlazo);
                else
                    liquidacionImpuesto = new LiquidacionSinEmplazamiento(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaDePlazo);
            }
            else
                liquidacionImpuesto = new LiquidacionSinSancion(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaDePlazo);

            liquidacionImpuesto.CalcularValorTotal();
            Console.WriteLine(liquidacionService.Guardar(liquidacionImpuesto)+'\n');
        }
        static void Consultar()
        {
            Console.WriteLine("Listado de liquidaciones.\n");
            
            var response = liquidacionService.ConsultarTodos();
            if (response.Error)
            {
                Console.WriteLine(response.MensajeDeError);
            }
            else
            {
                foreach (var liquidacion in response.Liquidaciones)
                {
                    Console.WriteLine(liquidacion.ToString());
                    Divisor();
                }
            }

            
        }
        static void Eliminar()
        {
            Consultar();

            Console.Write("Ingrese el codigo de la liquidacion que desea borrar: ");
            string codigoLiquidacion = Console.ReadLine();

            Console.WriteLine(liquidacionService.Eliminar(codigoLiquidacion)+'\n');

            Consultar();
        }
        static void Modificar()
        {
            Consultar();
            Console.Write("Ingrese el codigo de la liquidacion que desea modificar: ");
            string codLiquidacionFirst = Console.ReadLine();
            LiquidacionImpuesto liquidacionFirst = liquidacionService.BuscarPorCodigo(codLiquidacionFirst);

            if ( liquidacionFirst == null)            
                Console.WriteLine("No se ha encontrado una liquidacion registrada con ese codigo!");
            else
            {
                Console.Write("Ingrese la nueva fecha de declaracion: ");
                string fechaDeclaracionNew = Console.ReadLine();
                Console.WriteLine(liquidacionService.ModificarFechaDeclaracion(liquidacionFirst, fechaDeclaracionNew));
            }
            Console.WriteLine();
            Consultar();
        }
        static void Divisor()
        {
            Console.WriteLine("********************************************");
        }
        static bool IsSancionable(string fechaDeclaracion, string fechaDePlazo)
        {
            //Nota. No se si estos nombres(fecha1 y fecha2) y este metodo (IsSancionable) es una buena practica. IsSancionable() es parecido al metodo CalcularDiasExtemporaneidad() de la clase LiquidacionImpuesto
            DateTime fecha1 = Convert.ToDateTime(fechaDeclaracion);
            DateTime fecha2 = Convert.ToDateTime(fechaDePlazo);
            var fecha = fecha1.Subtract(fecha2);
            int diasExtemporaneos = fecha.Days;
            return diasExtemporaneos > 0;
        }
    }
}
