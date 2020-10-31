using System;
using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class LiquidacionImpuestosService
    {
        private LiquidacionImpuestoRepository liquidacionImpuestoRepository;

        public LiquidacionImpuestosService()
        {
            liquidacionImpuestoRepository = new LiquidacionImpuestoRepository();
        }

        public string Guardar(LiquidacionImpuesto liquidacion)
        {
            try
            {
                if (this.Buscar(liquidacion.CodigoLiquidacion) == null)
                {
                    liquidacionImpuestoRepository.Guardar(liquidacion);
                    return "Se ha guardado exitosamente!";

                }
                else
                    return "No se ha podido registrar. Este codigo de liquidacion ya se encuentra registrado";
            }
            catch (Exception e)
            {
                return "Se ha presentado la excepcion: " + e.Message;
            }
        }
        public LiquidacionConsultarResponse ConsultarTodos()
        {
            try
            {
                List<LiquidacionImpuesto> liquidacionesDelFile = liquidacionImpuestoRepository.ConsultarTodos();
                return new LiquidacionConsultarResponse(liquidacionesDelFile);
            }
            catch (Exception e)
            {
                return new LiquidacionConsultarResponse("Se ha presentado la excepcion: " + e.Message);
            }
        }
        public string Eliminar(string codigoLiquidacion)
        {
            try
            {
                LiquidacionImpuesto liquidacionParaEliminar = this.Buscar(codigoLiquidacion);
                if (liquidacionParaEliminar != null)
                {
                    liquidacionImpuestoRepository.Eliminar(liquidacionParaEliminar);
                    return "Se ha eliminado la liquidacion!";
                }
                else
                    return "Este codigo de liquidacion no se encuentra registrado!";
            }
            catch (Exception e)
            {
                return "Se ha presentado la excepcion: " + e.Message;
            }
        }
        
        //Solo modifica la fecha
        public string ModificarFechaDeclaracion(LiquidacionImpuesto liquidacionInicial, string fechaDeclaracionNew)
        {
            try
            {
                DateTime fechaDeclaracion= Convert.ToDateTime(fechaDeclaracionNew);
                liquidacionImpuestoRepository.ModificarFechaDeclaracion(liquidacionInicial, fechaDeclaracion);
                return "Se ha modificado correctamente";
            }
            catch (Exception e)
            {
                return "Se ha presentado la excepcion: " + e.Message;
            }
            
        }
        public LiquidacionImpuesto Buscar(string codigoLiquidacion)
        {
            return liquidacionImpuestoRepository.Buscar(codigoLiquidacion);
        }
    }
    public class LiquidacionConsultarResponse
    {
        public List<LiquidacionImpuesto> Liquidaciones{ get; set; }
        public bool Error { get; set; }
        public string MensajeDeError { get; set; }

        public LiquidacionConsultarResponse(List<LiquidacionImpuesto> liquidaciones)
        {
            Liquidaciones = liquidaciones;
            Error = false;
        }
        public LiquidacionConsultarResponse(string mensajeDeError)
        {
            MensajeDeError = mensajeDeError;
            Error = true;
        }

    }
}
