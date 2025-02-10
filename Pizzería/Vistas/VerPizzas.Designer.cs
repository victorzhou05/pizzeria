namespace Pizzería.Vistas
{
    partial class VerPizzas
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label_numped = new System.Windows.Forms.Label();
            this.label_numeroPedido = new System.Windows.Forms.Label();
            this.label_pedido = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(178, 96);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(436, 214);
            this.treeView1.TabIndex = 0;
            // 
            // label_numped
            // 
            this.label_numped.AutoSize = true;
            this.label_numped.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numped.Location = new System.Drawing.Point(395, 68);
            this.label_numped.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numped.Name = "label_numped";
            this.label_numped.Size = new System.Drawing.Size(46, 17);
            this.label_numped.TabIndex = 14;
            this.label_numped.Text = "label1";
            // 
            // label_numeroPedido
            // 
            this.label_numeroPedido.AutoSize = true;
            this.label_numeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeroPedido.Location = new System.Drawing.Point(326, 68);
            this.label_numeroPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numeroPedido.Name = "label_numeroPedido";
            this.label_numeroPedido.Size = new System.Drawing.Size(74, 17);
            this.label_numeroPedido.TabIndex = 13;
            this.label_numeroPedido.Text = "Nº pedido:";
            // 
            // label_pedido
            // 
            this.label_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pedido.Location = new System.Drawing.Point(334, 29);
            this.label_pedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pedido.Name = "label_pedido";
            this.label_pedido.Size = new System.Drawing.Size(107, 30);
            this.label_pedido.TabIndex = 12;
            this.label_pedido.Text = "Pedido";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(34, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 85);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VerPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label_numped);
            this.Controls.Add(this.label_numeroPedido);
            this.Controls.Add(this.label_pedido);
            this.Controls.Add(this.treeView1);
            this.Name = "VerPizzas";
            this.Text = "VerPizzas";
            this.Load += new System.EventHandler(this.VerPizzas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label_numped;
        private System.Windows.Forms.Label label_numeroPedido;
        private System.Windows.Forms.Label label_pedido;
        private System.Windows.Forms.Button btnSalir;
    }
}