using System;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PresentacionGUI
{
    public partial class FrmRegistroLiquidaciones : Form
    {
        LiquidacionImpuestosService liquidacionService;
        public FrmRegistroLiquidaciones()
        {
            InitializeComponent();
            liquidacionService = new LiquidacionImpuestosService();
            
        }

        //Factorizacion a la loca
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            LiquidacionImpuesto liquidacionImpuesto = CrearLiquidacion();
            liquidacionImpuesto.CalcularValorTotal();

            string messageConfirmacion = liquidacionService.Guardar(liquidacionImpuesto);
            MessageBox.Show(messageConfirmacion);
        }
        private LiquidacionImpuesto CrearLiquidacion()
        {
            LiquidacionImpuesto liquidacionImpuesto;
            string codigoLiquidacion, fechaDeclaracion, fechaMaxima;
            decimal ingresosContribuyente;
            bool IsEmplazado;
            MapearTextIngresadoAVaraibles(out codigoLiquidacion, out fechaDeclaracion, out fechaMaxima, out ingresosContribuyente);

            if (IsSancionable(fechaDeclaracion, fechaMaxima))
            {
                IsEmplazado = RdBtnSi.Checked;
                if (IsEmplazado)
                    liquidacionImpuesto = new LiquidacionConEmplazamiento(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaMaxima);
                else
                    liquidacionImpuesto = new LiquidacionSinEmplazamiento(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaMaxima);
            }
            else
            {
                liquidacionImpuesto = new LiquidacionSinSancion(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaMaxima);
            }

            return liquidacionImpuesto;
        }
        private void MapearTextIngresadoAVaraibles(out string codigoLiquidacion, out string fechaDeclaracion, out string fechaMaxima, out decimal ingresosContribuyente)
        {
            codigoLiquidacion = TxtCodigoLiquidacion.Text;
            ingresosContribuyente = Convert.ToDecimal(TxtIngresosContribuyente.Text);
            fechaDeclaracion = TxtFechaDeclaracion.Text;
            fechaMaxima = TxtFechaMaxima.Text;
        }
        private bool IsSancionable(string fechaDeclaracion, string fechaMaxima)
        {
            DateTime fecha1 = Convert.ToDateTime(fechaDeclaracion);
            DateTime fecha2 = Convert.ToDateTime(fechaMaxima);
            var fecha = fecha1.Subtract(fecha2);
            int diasExtemporaneos = fecha.Days;
            return diasExtemporaneos > 0;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
