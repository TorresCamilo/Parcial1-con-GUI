using System;
using BLL;
using Entity;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmModificarLiquidacion : Form
    {
        LiquidacionImpuestosService liquidacionService;

        public FrmModificarLiquidacion()
        {
            InitializeComponent();
            InhabilitarCampos();
            liquidacionService = new LiquidacionImpuestosService();
        }
        private void InhabilitarCampos()
        {
            TxtValorTotal.Enabled = false;
            TxtDiasExtemporaneidad.Enabled = false;
            TxtFechaMaxima.Enabled = false;
            TxtIngresosContribuyente.Enabled = false;
            TxtValorImpuesto.Enabled = false;
            TxtValorSancion.Enabled = false;
            TxtTipoLiquidacion.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string codigoLiquidacion = TxtCodigoLiquidacion.Text;
            TxtCodigoLiquidacion.Enabled = false;
            LiquidacionResponse liquidacionResponse = liquidacionService.BuscarPorCodigo(codigoLiquidacion);
            LiquidacionImpuesto liquidacionEncontrada = liquidacionResponse.LiquidacionEncontrada;
            if (!liquidacionResponse.ExistError)
            {
                RellenarTxtDeForm(liquidacionResponse.LiquidacionEncontrada);
            }
            else
                MessageBox.Show(liquidacionResponse.MessageError);
        }
        private void RellenarTxtDeForm(LiquidacionImpuesto liquidacion)
        {
            TxtIngresosContribuyente.Text = Convert.ToString(liquidacion.IngresosContribuyente);
            TxtFechaDeclaracion.Text = liquidacion.FechaDeclaracion.ToString("d");
            TxtFechaMaxima.Text = liquidacion.FechaDePlazo.ToString("d");
            TxtDiasExtemporaneidad.Text = liquidacion.DiasExtemporaneidad.ToString();
            TxtValorImpuesto.Text = liquidacion.ValorImpuesto.ToString();
            TxtValorSancion.Text = liquidacion.ValorSancion.ToString();
            TxtValorTotal.Text = liquidacion.ValorTotalLiquidacion.ToString();
            MapStringToTxtForm(liquidacion.TipoLiquidacion);
        }
        private void MapStringToTxtForm(string tipoLiquidacion)
        {
            if (tipoLiquidacion.Equals("SS"))
            {
                TxtTipoLiquidacion.Text = "Sin sancion";
            }
            else if (tipoLiquidacion.Equals("CE"))
            {
                TxtTipoLiquidacion.Text = "Con emplazamiento";
            }
            else if (tipoLiquidacion.Equals("SE"))
            {
                TxtTipoLiquidacion.Text = "Sin emplazamiento";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string codigoLiquidacion, fechaDeclaracion, fechaMaxima, tipoLiquidacion;
            decimal ingresosContribuyente;

            codigoLiquidacion = TxtCodigoLiquidacion.Text;
            ingresosContribuyente = Convert.ToDecimal(TxtIngresosContribuyente.Text);
            fechaDeclaracion = TxtFechaDeclaracion.Text;
            fechaMaxima = TxtFechaMaxima.Text;
            tipoLiquidacion = TxtTipoLiquidacion.Text;

            LiquidacionImpuesto liquidacionNew = null;

            if (tipoLiquidacion.Equals("Sin sancion"))
            {
                liquidacionNew = new LiquidacionSinSancion(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaMaxima);
                MessageBox.Show(liquidacionNew.TipoLiquidacion);
            }
            else if (tipoLiquidacion.Equals("Con emplazamiento"))
            {
                liquidacionNew = new LiquidacionConEmplazamiento(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaMaxima);
            }
            else if (tipoLiquidacion.Equals("Sin emplazamiento"))
            {
                liquidacionNew = new LiquidacionSinEmplazamiento(codigoLiquidacion, ingresosContribuyente, fechaDeclaracion, fechaMaxima);
            }

            liquidacionNew.CalcularValorTotal();
            
            liquidacionService.ModificarFechaDeclaracion(liquidacionNew);
            this.RellenarTxtDeForm(liquidacionNew);

        }
    }
}
