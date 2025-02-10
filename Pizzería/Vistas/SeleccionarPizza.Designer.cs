namespace Pizzería.Vistas
{
    partial class SeleccionarPizza
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarPizza));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_siguiente = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sin_títulocarbo-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "Sin_título-removebg-preview.png");
            this.imageList1.Images.SetKeyName(2, "Sin_títuloqueso-removebg-preview.png");
            // 
            // bt_siguiente
            // 
            this.bt_siguiente.Location = new System.Drawing.Point(249, 275);
            this.bt_siguiente.Margin = new System.Windows.Forms.Padding(2);
            this.bt_siguiente.Name = "bt_siguiente";
            this.bt_siguiente.Size = new System.Drawing.Size(94, 50);
            this.bt_siguiente.TabIndex = 9;
            this.bt_siguiente.Text = "Siguiente";
            this.bt_siguiente.UseVisualStyleBackColor = true;
            this.bt_siguiente.Click += new System.EventHandler(this.bt_siguiente_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 257);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // SeleccionarPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_siguiente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeleccionarPizza";
            this.Text = "SeleccionarPizza";
            this.Load += new System.EventHandler(this.SeleccionarPizza_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bt_siguiente;
        private System.Windows.Forms.ListView listView1;
    }
}