namespace Pizzería.Vistas
{
    partial class FormMenuInfoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuInfoUsuario));
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.bt_pedidos = new System.Windows.Forms.Button();
            this.bt_miCuenta = new System.Windows.Forms.Button();
            this.margen = new System.Windows.Forms.Panel();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.bt_volver = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.panel_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.Red;
            this.panel_lateral.Controls.Add(this.bt_volver);
            this.panel_lateral.Controls.Add(this.bt_pedidos);
            this.panel_lateral.Controls.Add(this.bt_miCuenta);
            this.panel_lateral.Controls.Add(this.margen);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(123, 401);
            this.panel_lateral.TabIndex = 0;
            // 
            // bt_pedidos
            // 
            this.bt_pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_pedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_pedidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pedidos.Location = new System.Drawing.Point(0, 118);
            this.bt_pedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_pedidos.Name = "bt_pedidos";
            this.bt_pedidos.Size = new System.Drawing.Size(123, 42);
            this.bt_pedidos.TabIndex = 2;
            this.bt_pedidos.Text = "Mis pedidos";
            this.bt_pedidos.UseVisualStyleBackColor = true;
            this.bt_pedidos.Click += new System.EventHandler(this.bt_pedidos_Click);
            // 
            // bt_miCuenta
            // 
            this.bt_miCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_miCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_miCuenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_miCuenta.Location = new System.Drawing.Point(0, 81);
            this.bt_miCuenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_miCuenta.Name = "bt_miCuenta";
            this.bt_miCuenta.Size = new System.Drawing.Size(123, 37);
            this.bt_miCuenta.TabIndex = 1;
            this.bt_miCuenta.Text = "Mi cuenta";
            this.bt_miCuenta.UseVisualStyleBackColor = true;
            this.bt_miCuenta.Click += new System.EventHandler(this.bt_miCuenta_Click);
            // 
            // margen
            // 
            this.margen.Dock = System.Windows.Forms.DockStyle.Top;
            this.margen.Location = new System.Drawing.Point(0, 0);
            this.margen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.margen.Name = "margen";
            this.margen.Size = new System.Drawing.Size(123, 81);
            this.margen.TabIndex = 0;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(123, 0);
            this.panel_contenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(545, 401);
            this.panel_contenedor.TabIndex = 1;
            // 
            // bt_volver
            // 
            this.bt_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_volver.FlatAppearance.BorderSize = 0;
            this.bt_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_volver.ImageIndex = 0;
            this.bt_volver.ImageList = this.images;
            this.bt_volver.Location = new System.Drawing.Point(3, 316);
            this.bt_volver.Name = "bt_volver";
            this.bt_volver.Size = new System.Drawing.Size(115, 82);
            this.bt_volver.TabIndex = 3;
            this.bt_volver.UseVisualStyleBackColor = true;
            this.bt_volver.Click += new System.EventHandler(this.bt_volver_Click);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "botonVolverPizza.png");
            // 
            // FormMenuInfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 401);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMenuInfoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button bt_miCuenta;
        private System.Windows.Forms.Panel margen;
        private System.Windows.Forms.Button bt_pedidos;
        private System.Windows.Forms.Button bt_volver;
        private System.Windows.Forms.ImageList images;
    }
}

