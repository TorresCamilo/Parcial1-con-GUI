namespace PresentacionGUI
{
    partial class FrmRegistroLiquidaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroLiquidaciones));
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdBtnSi = new System.Windows.Forms.RadioButton();
            this.RdBtnNo = new System.Windows.Forms.RadioButton();
            this.TxtFechaMaxima = new System.Windows.Forms.TextBox();
            this.TxtFechaDeclaracion = new System.Windows.Forms.TextBox();
            this.TxtIngresosContribuyente = new System.Windows.Forms.TextBox();
            this.TxtCodigoLiquidacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlTitulo.SuspendLayout();
            this.PnlBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrar.Image")));
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(3, 3);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(146, 55);
            this.BtnRegistrar.TabIndex = 3;
            this.BtnRegistrar.Text = "Guardar";
            this.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Liquidaciones";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(3, 64);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(146, 55);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.BtnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.BtnLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCampos.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(261, 293);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(166, 39);
            this.BtnLimpiarCampos.TabIndex = 6;
            this.BtnLimpiarCampos.Text = "Limpiar Campos";
            this.BtnLimpiarCampos.UseVisualStyleBackColor = false;
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.Controls.Add(this.label2);
            this.PnlTitulo.Controls.Add(this.label1);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(800, 93);
            this.PnlTitulo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese la siguiente informacion de su  liquidacion de impuesto: ";
            // 
            // PnlBotones
            // 
            this.PnlBotones.Controls.Add(this.BtnRegistrar);
            this.PnlBotones.Controls.Add(this.BtnBuscar);
            this.PnlBotones.Location = new System.Drawing.Point(594, 65);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(161, 134);
            this.PnlBotones.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtFechaMaxima);
            this.panel1.Controls.Add(this.TxtFechaDeclaracion);
            this.panel1.Controls.Add(this.TxtIngresosContribuyente);
            this.panel1.Controls.Add(this.TxtCodigoLiquidacion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(56, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 274);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RdBtnSi);
            this.panel2.Controls.Add(this.RdBtnNo);
            this.panel2.Location = new System.Drawing.Point(255, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 22);
            this.panel2.TabIndex = 11;
            // 
            // RdBtnSi
            // 
            this.RdBtnSi.AutoSize = true;
            this.RdBtnSi.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtnSi.Location = new System.Drawing.Point(41, 0);
            this.RdBtnSi.Name = "RdBtnSi";
            this.RdBtnSi.Size = new System.Drawing.Size(39, 22);
            this.RdBtnSi.TabIndex = 9;
            this.RdBtnSi.TabStop = true;
            this.RdBtnSi.Text = "Si";
            this.RdBtnSi.UseVisualStyleBackColor = true;
            // 
            // RdBtnNo
            // 
            this.RdBtnNo.AutoSize = true;
            this.RdBtnNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtnNo.Location = new System.Drawing.Point(129, 0);
            this.RdBtnNo.Name = "RdBtnNo";
            this.RdBtnNo.Size = new System.Drawing.Size(45, 22);
            this.RdBtnNo.TabIndex = 10;
            this.RdBtnNo.TabStop = true;
            this.RdBtnNo.Text = "No";
            this.RdBtnNo.UseVisualStyleBackColor = true;
            // 
            // TxtFechaMaxima
            // 
            this.TxtFechaMaxima.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaMaxima.Location = new System.Drawing.Point(255, 151);
            this.TxtFechaMaxima.Name = "TxtFechaMaxima";
            this.TxtFechaMaxima.Size = new System.Drawing.Size(232, 26);
            this.TxtFechaMaxima.TabIndex = 8;
            // 
            // TxtFechaDeclaracion
            // 
            this.TxtFechaDeclaracion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaDeclaracion.Location = new System.Drawing.Point(255, 110);
            this.TxtFechaDeclaracion.Name = "TxtFechaDeclaracion";
            this.TxtFechaDeclaracion.Size = new System.Drawing.Size(232, 26);
            this.TxtFechaDeclaracion.TabIndex = 7;
            // 
            // TxtIngresosContribuyente
            // 
            this.TxtIngresosContribuyente.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngresosContribuyente.Location = new System.Drawing.Point(255, 69);
            this.TxtIngresosContribuyente.Name = "TxtIngresosContribuyente";
            this.TxtIngresosContribuyente.Size = new System.Drawing.Size(232, 26);
            this.TxtIngresosContribuyente.TabIndex = 6;
            // 
            // TxtCodigoLiquidacion
            // 
            this.TxtCodigoLiquidacion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoLiquidacion.Location = new System.Drawing.Point(255, 28);
            this.TxtCodigoLiquidacion.Name = "TxtCodigoLiquidacion";
            this.TxtCodigoLiquidacion.Size = new System.Drawing.Size(232, 26);
            this.TxtCodigoLiquidacion.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label7.Location = new System.Drawing.Point(96, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fue emplazado?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label6.Location = new System.Drawing.Point(36, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de plazo maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label5.Location = new System.Drawing.Point(53, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de declaracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingresos del contribuyente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.2F);
            this.label3.Location = new System.Drawing.Point(78, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo liquidacion";
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PnlContenedor.Controls.Add(this.panel1);
            this.PnlContenedor.Controls.Add(this.PnlBotones);
            this.PnlContenedor.Controls.Add(this.BtnLimpiarCampos);
            this.PnlContenedor.Location = new System.Drawing.Point(0, 93);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(800, 357);
            this.PnlContenedor.TabIndex = 11;
            // 
            // FrmRegistroLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistroLiquidaciones";
            this.Text = "FrmRegistroLiquidaciones";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            this.PnlBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel PnlBotones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtFechaMaxima;
        private System.Windows.Forms.TextBox TxtFechaDeclaracion;
        private System.Windows.Forms.TextBox TxtIngresosContribuyente;
        private System.Windows.Forms.TextBox TxtCodigoLiquidacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RdBtnNo;
        private System.Windows.Forms.RadioButton RdBtnSi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}