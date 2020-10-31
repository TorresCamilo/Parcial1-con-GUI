namespace PresentacionGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.PctLogo = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PctMinimizar = new System.Windows.Forms.PictureBox();
            this.PctRestaurar = new System.Windows.Forms.PictureBox();
            this.PctMaximar = new System.Windows.Forms.PictureBox();
            this.PctCerrar = new System.Windows.Forms.PictureBox();
            this.BtnSlide = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(69)))), ((int)(((byte)(102)))));
            this.MenuLateral.Controls.Add(this.button5);
            this.MenuLateral.Controls.Add(this.button4);
            this.MenuLateral.Controls.Add(this.button3);
            this.MenuLateral.Controls.Add(this.button1);
            this.MenuLateral.Controls.Add(this.button2);
            this.MenuLateral.Controls.Add(this.PctLogo);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(250, 650);
            this.MenuLateral.TabIndex = 0;
            // 
            // PctLogo
            // 
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(-12, 3);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(230, 84);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctLogo.TabIndex = 0;
            this.PctLogo.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.PctMinimizar);
            this.BarraTitulo.Controls.Add(this.PctRestaurar);
            this.BarraTitulo.Controls.Add(this.PctMaximar);
            this.BarraTitulo.Controls.Add(this.PctCerrar);
            this.BarraTitulo.Controls.Add(this.BtnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PctMinimizar
            // 
            this.PctMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PctMinimizar.Image")));
            this.PctMinimizar.Location = new System.Drawing.Point(963, 0);
            this.PctMinimizar.Name = "PctMinimizar";
            this.PctMinimizar.Size = new System.Drawing.Size(25, 30);
            this.PctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctMinimizar.TabIndex = 4;
            this.PctMinimizar.TabStop = false;
            this.PctMinimizar.Click += new System.EventHandler(this.PctMinimizar_Click);
            // 
            // PctRestaurar
            // 
            this.PctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PctRestaurar.Image")));
            this.PctRestaurar.Location = new System.Drawing.Point(994, 0);
            this.PctRestaurar.Name = "PctRestaurar";
            this.PctRestaurar.Size = new System.Drawing.Size(25, 30);
            this.PctRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctRestaurar.TabIndex = 3;
            this.PctRestaurar.TabStop = false;
            this.PctRestaurar.Visible = false;
            this.PctRestaurar.Click += new System.EventHandler(this.PctRestaurar_Click);
            // 
            // PctMaximar
            // 
            this.PctMaximar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctMaximar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctMaximar.Image = ((System.Drawing.Image)(resources.GetObject("PctMaximar.Image")));
            this.PctMaximar.Location = new System.Drawing.Point(994, 0);
            this.PctMaximar.Name = "PctMaximar";
            this.PctMaximar.Size = new System.Drawing.Size(25, 30);
            this.PctMaximar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctMaximar.TabIndex = 2;
            this.PctMaximar.TabStop = false;
            this.PctMaximar.Click += new System.EventHandler(this.PctMaximar_Click);
            // 
            // PctCerrar
            // 
            this.PctCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PctCerrar.Image")));
            this.PctCerrar.Location = new System.Drawing.Point(1025, 0);
            this.PctCerrar.Name = "PctCerrar";
            this.PctCerrar.Size = new System.Drawing.Size(25, 30);
            this.PctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctCerrar.TabIndex = 1;
            this.PctCerrar.TabStop = false;
            this.PctCerrar.Click += new System.EventHandler(this.PctCerrar_Click);
            // 
            // BtnSlide
            // 
            this.BtnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSlide.Image = ((System.Drawing.Image)(resources.GetObject("BtnSlide.Image")));
            this.BtnSlide.Location = new System.Drawing.Point(6, 3);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(35, 35);
            this.BtnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSlide.TabIndex = 0;
            this.BtnSlide.TabStop = false;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Controls.Add(this.BarraTitulo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1050, 650);
            this.PanelContenedor.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Liquidaciones         ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(117)))), ((int)(((byte)(230)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 595);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctMaximar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSlide)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox BtnSlide;
        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.PictureBox PctRestaurar;
        private System.Windows.Forms.PictureBox PctMaximar;
        private System.Windows.Forms.PictureBox PctCerrar;
        private System.Windows.Forms.PictureBox PctMinimizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}

