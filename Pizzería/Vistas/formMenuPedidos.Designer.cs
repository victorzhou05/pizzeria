namespace Pizzería.Vistas
{
    partial class formMenuPedidos
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
            this.lv_pedidosEntregados = new System.Windows.Forms.ListView();
            this.columnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDirec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_infoPedidos = new System.Windows.Forms.Label();
            this.lv_pedidosEnPreparacion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_pedidosPendientes = new System.Windows.Forms.Label();
            this.bt_recibirPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_pedidosEntregados
            // 
            this.lv_pedidosEntregados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPrecio,
            this.columnFecha,
            this.columnDirec});
            this.lv_pedidosEntregados.FullRowSelect = true;
            this.lv_pedidosEntregados.HideSelection = false;
            this.lv_pedidosEntregados.Location = new System.Drawing.Point(29, 54);
            this.lv_pedidosEntregados.Name = "lv_pedidosEntregados";
            this.lv_pedidosEntregados.Size = new System.Drawing.Size(225, 308);
            this.lv_pedidosEntregados.TabIndex = 0;
            this.lv_pedidosEntregados.UseCompatibleStateImageBehavior = false;
            this.lv_pedidosEntregados.View = System.Windows.Forms.View.Details;
            // 
            // columnPrecio
            // 
            this.columnPrecio.Text = "Precio";
            this.columnPrecio.Width = 47;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha de entrega";
            this.columnFecha.Width = 103;
            // 
            // columnDirec
            // 
            this.columnDirec.Text = "Dirección";
            this.columnDirec.Width = 66;
            // 
            // lb_infoPedidos
            // 
            this.lb_infoPedidos.AutoSize = true;
            this.lb_infoPedidos.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_infoPedidos.Location = new System.Drawing.Point(25, 20);
            this.lb_infoPedidos.Name = "lb_infoPedidos";
            this.lb_infoPedidos.Size = new System.Drawing.Size(229, 19);
            this.lb_infoPedidos.TabIndex = 1;
            this.lb_infoPedidos.Text = "Información de nuestros pedidos";
            // 
            // lv_pedidosEnPreparacion
            // 
            this.lv_pedidosEnPreparacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_pedidosEnPreparacion.FullRowSelect = true;
            this.lv_pedidosEnPreparacion.HideSelection = false;
            this.lv_pedidosEnPreparacion.Location = new System.Drawing.Point(271, 54);
            this.lv_pedidosEnPreparacion.Name = "lv_pedidosEnPreparacion";
            this.lv_pedidosEnPreparacion.Size = new System.Drawing.Size(261, 226);
            this.lv_pedidosEnPreparacion.TabIndex = 2;
            this.lv_pedidosEnPreparacion.UseCompatibleStateImageBehavior = false;
            this.lv_pedidosEnPreparacion.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Precio";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dirección";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Número de pedido";
            this.columnHeader3.Width = 100;
            // 
            // lb_pedidosPendientes
            // 
            this.lb_pedidosPendientes.AutoSize = true;
            this.lb_pedidosPendientes.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pedidosPendientes.Location = new System.Drawing.Point(336, 20);
            this.lb_pedidosPendientes.Name = "lb_pedidosPendientes";
            this.lb_pedidosPendientes.Size = new System.Drawing.Size(140, 19);
            this.lb_pedidosPendientes.TabIndex = 3;
            this.lb_pedidosPendientes.Text = "Pedidos pendientes";
            // 
            // bt_recibirPedido
            // 
            this.bt_recibirPedido.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_recibirPedido.Location = new System.Drawing.Point(349, 296);
            this.bt_recibirPedido.Name = "bt_recibirPedido";
            this.bt_recibirPedido.Size = new System.Drawing.Size(116, 66);
            this.bt_recibirPedido.TabIndex = 4;
            this.bt_recibirPedido.Text = "Recibir pedido";
            this.bt_recibirPedido.UseVisualStyleBackColor = true;
            this.bt_recibirPedido.Click += new System.EventHandler(this.bt_recibirPedido_Click);
            // 
            // formMenuPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 401);
            this.Controls.Add(this.bt_recibirPedido);
            this.Controls.Add(this.lb_pedidosPendientes);
            this.Controls.Add(this.lv_pedidosEnPreparacion);
            this.Controls.Add(this.lb_infoPedidos);
            this.Controls.Add(this.lv_pedidosEntregados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMenuPedidos";
            this.Text = "formMenuPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_pedidosEntregados;
        private System.Windows.Forms.ColumnHeader columnPrecio;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnDirec;
        private System.Windows.Forms.Label lb_infoPedidos;
        private System.Windows.Forms.ListView lv_pedidosEnPreparacion;
        private System.Windows.Forms.Label lb_pedidosPendientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bt_recibirPedido;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}