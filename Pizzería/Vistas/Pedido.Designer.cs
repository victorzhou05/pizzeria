namespace Pizzería.Vistas
{
    partial class Pedido
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
            this.bt_factura = new System.Windows.Forms.Button();
            this.bt_seguirComprando = new System.Windows.Forms.Button();
            this.label_pedido = new System.Windows.Forms.Label();
            this.label_numeroPedido = new System.Windows.Forms.Label();
            this.label_carrito = new System.Windows.Forms.Label();
            this.label_pizzas = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_euro = new System.Windows.Forms.Label();
            this.label_numped = new System.Windows.Forms.Label();
            this.label_numpizzas = new System.Windows.Forms.Label();
            this.label_dinero = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_factura
            // 
            this.bt_factura.Location = new System.Drawing.Point(367, 275);
            this.bt_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_factura.Name = "bt_factura";
            this.bt_factura.Size = new System.Drawing.Size(106, 63);
            this.bt_factura.TabIndex = 0;
            this.bt_factura.Text = "Finalizar Compra";
            this.bt_factura.UseVisualStyleBackColor = true;
            this.bt_factura.Click += new System.EventHandler(this.bt_factura_Click);
            // 
            // bt_seguirComprando
            // 
            this.bt_seguirComprando.Location = new System.Drawing.Point(103, 275);
            this.bt_seguirComprando.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_seguirComprando.Name = "bt_seguirComprando";
            this.bt_seguirComprando.Size = new System.Drawing.Size(103, 63);
            this.bt_seguirComprando.TabIndex = 1;
            this.bt_seguirComprando.Text = "Añadir otra pizza";
            this.bt_seguirComprando.UseVisualStyleBackColor = true;
            this.bt_seguirComprando.Click += new System.EventHandler(this.bt_seguirComprando_Click);
            // 
            // label_pedido
            // 
            this.label_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pedido.Location = new System.Drawing.Point(257, 20);
            this.label_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pedido.Name = "label_pedido";
            this.label_pedido.Size = new System.Drawing.Size(107, 30);
            this.label_pedido.TabIndex = 2;
            this.label_pedido.Text = "Pedido";
            this.label_pedido.Click += new System.EventHandler(this.label_pedido_Click);
            // 
            // label_numeroPedido
            // 
            this.label_numeroPedido.AutoSize = true;
            this.label_numeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeroPedido.Location = new System.Drawing.Point(223, 60);
            this.label_numeroPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numeroPedido.Name = "label_numeroPedido";
            this.label_numeroPedido.Size = new System.Drawing.Size(74, 17);
            this.label_numeroPedido.TabIndex = 3;
            this.label_numeroPedido.Text = "Nº pedido:";
            // 
            // label_carrito
            // 
            this.label_carrito.AutoSize = true;
            this.label_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_carrito.Location = new System.Drawing.Point(32, 109);
            this.label_carrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_carrito.Name = "label_carrito";
            this.label_carrito.Size = new System.Drawing.Size(156, 24);
            this.label_carrito.TabIndex = 5;
            this.label_carrito.Text = "Contenido Carrito";
            // 
            // label_pizzas
            // 
            this.label_pizzas.AutoSize = true;
            this.label_pizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pizzas.Location = new System.Drawing.Point(32, 166);
            this.label_pizzas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pizzas.Name = "label_pizzas";
            this.label_pizzas.Size = new System.Drawing.Size(68, 24);
            this.label_pizzas.TabIndex = 6;
            this.label_pizzas.Text = "Pizzas:";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x.Location = new System.Drawing.Point(102, 171);
            this.label_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(14, 17);
            this.label_x.TabIndex = 7;
            this.label_x.Text = "x";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(32, 210);
            this.label_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(56, 24);
            this.label_total.TabIndex = 9;
            this.label_total.Text = "Total:";
            // 
            // label_euro
            // 
            this.label_euro.AutoSize = true;
            this.label_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_euro.Location = new System.Drawing.Point(148, 214);
            this.label_euro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(22, 20);
            this.label_euro.TabIndex = 10;
            this.label_euro.Text = "€ ";
            // 
            // label_numped
            // 
            this.label_numped.AutoSize = true;
            this.label_numped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numped.Location = new System.Drawing.Point(292, 60);
            this.label_numped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numped.Name = "label_numped";
            this.label_numped.Size = new System.Drawing.Size(46, 17);
            this.label_numped.TabIndex = 11;
            this.label_numped.Text = "label1";
            // 
            // label_numpizzas
            // 
            this.label_numpizzas.AutoSize = true;
            this.label_numpizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numpizzas.Location = new System.Drawing.Point(119, 166);
            this.label_numpizzas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numpizzas.Name = "label_numpizzas";
            this.label_numpizzas.Size = new System.Drawing.Size(20, 24);
            this.label_numpizzas.TabIndex = 12;
            this.label_numpizzas.Text = "0";
            // 
            // label_dinero
            // 
            this.label_dinero.AutoSize = true;
            this.label_dinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dinero.Location = new System.Drawing.Point(101, 214);
            this.label_dinero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dinero.Name = "label_dinero";
            this.label_dinero.Size = new System.Drawing.Size(18, 20);
            this.label_dinero.TabIndex = 13;
            this.label_dinero.Text = "0";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.Location = new System.Drawing.Point(281, 226);
            this.label_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(144, 17);
            this.label_direccion.TabIndex = 14;
            this.label_direccion.Text = "Dirección de entrega:";
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(421, 226);
            this.tb_direccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(127, 20);
            this.tb_direccion.TabIndex = 15;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_dinero);
            this.Controls.Add(this.label_numpizzas);
            this.Controls.Add(this.label_numped);
            this.Controls.Add(this.label_euro);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_pizzas);
            this.Controls.Add(this.label_carrito);
            this.Controls.Add(this.label_numeroPedido);
            this.Controls.Add(this.label_pedido);
            this.Controls.Add(this.bt_seguirComprando);
            this.Controls.Add(this.bt_factura);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_factura;
        private System.Windows.Forms.Button bt_seguirComprando;
        private System.Windows.Forms.Label label_pedido;
        private System.Windows.Forms.Label label_numeroPedido;
        private System.Windows.Forms.Label label_carrito;
        private System.Windows.Forms.Label label_pizzas;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_euro;
        private System.Windows.Forms.Label label_numped;
        private System.Windows.Forms.Label label_numpizzas;
        private System.Windows.Forms.Label label_dinero;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox tb_direccion;
    }
}