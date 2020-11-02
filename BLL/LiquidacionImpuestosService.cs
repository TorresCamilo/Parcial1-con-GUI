using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using DAL;
using Entity;

namespace BLL
{
    public class LiquidacionImpuestosService
    {
        private LiquidacionImpuestoRepository liquidacionRepository;

        public LiquidacionImpuestosService()
        {
            liquidacionRepository = new LiquidacionImpuestoRepository();
        }

        public string Guardar(LiquidacionImpuesto liquidacion)
        {
            try
            {
                if (this.BuscarPorCodigo(liquidacion.CodigoLiquidacion) == null)
                {
                    liquidacionRepository.Guardar(liquidacion);
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
                List<LiquidacionImpuesto> liquidacionesDelFile = liquidacionRepository.ConsultarTodos();
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
                LiquidacionResponse liquidacionResponse = this.BuscarPorCodigo(codigoLiquidacion);
                LiquidacionImpuesto liquidacionParaEliminar = liquidacionResponse.LiquidacionEncontrada;
                if (liquidacionParaEliminar != null)
                {
                    liquidacionRepository.Eliminar(liquidacionParaEliminar);
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
        public string ModificarFechaDeclaracion(LiquidacionImpuesto liquidacionNew)
        {
            try
            {
                liquidacionRepository.ModificarFechaDeclaracion(liquidacionNew);
                return "Se ha modificado correctamente";
            }
            catch (Exception e)
            {
                return "Se ha presentado la excepcion: " + e.Message;
            }
            
        }
        public LiquidacionResponse BuscarPorCodigo(string codigoLiquidacion)
        {
            try
            {
                LiquidacionImpuesto liquidacionFile = liquidacionRepository.Buscar(codigoLiquidacion);
                if (liquidacionFile != null)
                {
                    return new LiquidacionResponse(liquidacionFile);
                }
                else
                    return new LiquidacionResponse("No existe ninguna liquidacion registrada con este codigo.");
            }
            catch (Exception e)
            {
                return new LiquidacionResponse("Se ha presentado la siguiente excepcion: " + e.Message);
            }
        }
    }
    public class LiquidacionResponse
    {
        public LiquidacionImpuesto LiquidacionEncontrada { get; set; }
        public string MessageError { get; set; }
        public bool ExistError { get; set; }
        
        public LiquidacionResponse(LiquidacionImpuesto liquidacion)
        {
            LiquidacionEncontrada = liquidacion;
            ExistError = false;
        }
        public LiquidacionResponse(string messageError)
        {
            MessageError = messageError;
            ExistError = true;
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
