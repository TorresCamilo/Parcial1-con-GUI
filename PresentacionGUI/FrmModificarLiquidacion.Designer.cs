namespace PresentacionGUI
{
    partial class FrmModificarLiquidacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarLiquidacion));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtValorSancion = new System.Windows.Forms.TextBox();
            this.TxtValorImpuesto = new System.Windows.Forms.TextBox();
            this.TxtDiasExtemporaneidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtFechaMaxima = new System.Windows.Forms.TextBox();
            this.TxtFechaDeclaracion = new System.Windows.Forms.TextBox();
            this.TxtIngresosContribuyente = new System.Windows.Forms.TextBox();
            this.TxtCodigoLiquidacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTipoLiquidacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.label3);
            this.PnlTitulo.Controls.Add(this.label2);
            this.PnlTitulo.Controls.Add(this.label1);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(800, 123);
            this.PnlTitulo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "nuestro sistema hasta el momento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(737, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite el codigo de su liquidacion para observar la informacion que esta registra" +
    "da en ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificacion de Liquidaciones";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtTipoLiquidacion);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.BtnModificar);
            this.panel1.Controls.Add(this.TxtValorTotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtValorSancion);
            this.panel1.Controls.Add(this.TxtValorImpuesto);
            this.panel1.Controls.Add(this.TxtDiasExtemporaneidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtFechaMaxima);
            this.panel1.Controls.Add(this.TxtFechaDeclaracion);
            this.panel1.Controls.Add(this.TxtIngresosContribuyente);
            this.panel1.Controls.Add(this.TxtCodigoLiquidacion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 422);
            this.panel1.TabIndex = 11;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(582, 122);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(162, 55);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar   ";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(582, 191);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(162, 55);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.Location = new System.Drawing.Point(269, 332);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(232, 26);
            this.TxtValorTotal.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label11.Location = new System.Drawing.Point(132, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Valor TOTAL";
            // 
            // TxtValorSancion
            // 
            this.TxtValorSancion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorSancion.Location = new System.Drawing.Point(269, 292);
            this.TxtValorSancion.Name = "TxtValorSancion";
            this.TxtValorSancion.Size = new System.Drawing.Size(232, 26);
            this.TxtValorSancion.TabIndex = 16;
            // 
            // TxtValorImpuesto
            // 
            this.TxtValorImpuesto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorImpuesto.Location = new System.Drawing.Point(269, 252);
            this.TxtValorImpuesto.Name = "TxtValorImpuesto";
            this.TxtValorImpuesto.Size = new System.Drawing.Size(232, 26);
            this.TxtValorImpuesto.TabIndex = 15;
            // 
            // TxtDiasExtemporaneidad
            // 
            this.TxtDiasExtemporaneidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiasExtemporaneidad.Location = new System.Drawing.Point(269, 212);
            this.TxtDiasExtemporaneidad.Name = "TxtDiasExtemporaneidad";
            this.TxtDiasExtemporaneidad.Size = new System.Drawing.Size(232, 26);
            this.TxtDiasExtemporaneidad.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label7.Location = new System.Drawing.Point(76, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor de la sancion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label9.Location = new System.Drawing.Point(79, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Valor del impuesto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label10.Location = new System.Drawing.Point(24, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Dias de extemporaneidad";
            // 
            // TxtFechaMaxima
            // 
            this.TxtFechaMaxima.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaMaxima.Location = new System.Drawing.Point(269, 172);
            this.TxtFechaMaxima.Name = "TxtFechaMaxima";
            this.TxtFechaMaxima.Size = new System.Drawing.Size(232, 26);
            this.TxtFechaMaxima.TabIndex = 8;
            // 
            // TxtFechaDeclaracion
            // 
            this.TxtFechaDeclaracion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaDeclaracion.Location = new System.Drawing.Point(269, 132);
            this.TxtFechaDeclaracion.Name = "TxtFechaDeclaracion";
            this.TxtFechaDeclaracion.Size = new System.Drawing.Size(232, 26);
            this.TxtFechaDeclaracion.TabIndex = 7;
            // 
            // TxtIngresosContribuyente
            // 
            this.TxtIngresosContribuyente.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngresosContribuyente.Location = new System.Drawing.Point(269, 92);
            this.TxtIngresosContribuyente.Name = "TxtIngresosContribuyente";
            this.TxtIngresosContribuyente.Size = new System.Drawing.Size(232, 26);
            this.TxtIngresosContribuyente.TabIndex = 6;
            // 
            // TxtCodigoLiquidacion
            // 
            this.TxtCodigoLiquidacion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoLiquidacion.Location = new System.Drawing.Point(269, 12);
            this.TxtCodigoLiquidacion.Name = "TxtCodigoLiquidacion";
            this.TxtCodigoLiquidacion.Size = new System.Drawing.Size(232, 26);
            this.TxtCodigoLiquidacion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label6.Location = new System.Drawing.Point(41, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de plazo maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label5.Location = new System.Drawing.Point(58, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de declaracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingresos del contribuyente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label8.Location = new System.Drawing.Point(83, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo liquidacion";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12.25F);
            this.label12.Location = new System.Drawing.Point(113, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nota. Solo es posible editar la fecha en que declaro sus impuestos.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTipoLiquidacion
            // 
            this.TxtTipoLiquidacion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoLiquidacion.Location = new System.Drawing.Point(269, 52);
            this.TxtTipoLiquidacion.Name = "TxtTipoLiquidacion";
            this.TxtTipoLiquidacion.Size = new System.Drawing.Size(232, 26);
            this.TxtTipoLiquidacion.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label13.Location = new System.Drawing.Point(80, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tipo de liquidacion";
            // 
            // FrmModificarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarLiquidacion";
            this.Text = "FrmModificarLiquidacion";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtValorSancion;
        private System.Windows.Forms.TextBox TxtValorImpuesto;
        private System.Windows.Forms.TextBox TxtDiasExtemporaneidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtFechaMaxima;
        private System.Windows.Forms.TextBox TxtFechaDeclaracion;
        private System.Windows.Forms.TextBox TxtIngresosContribuyente;
        private System.Windows.Forms.TextBox TxtCodigoLiquidacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTipoLiquidacion;
        private System.Windows.Forms.Label label13;
    }
}