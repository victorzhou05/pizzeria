namespace Pizzería.Vistas
{
    partial class menuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuInicial));
            this.bt_infoUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_infoUsuario
            // 
            this.bt_infoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_infoUsuario.BackgroundImage")));
            this.bt_infoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_infoUsuario.FlatAppearance.BorderSize = 0;
            this.bt_infoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_infoUsuario.ImageIndex = 0;
            this.bt_infoUsuario.Location = new System.Drawing.Point(13, 13);
            this.bt_infoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.bt_infoUsuario.Name = "bt_infoUsuario";
            this.bt_infoUsuario.Size = new System.Drawing.Size(100, 94);
            this.bt_infoUsuario.TabIndex = 3;
            this.bt_infoUsuario.UseVisualStyleBackColor = true;
            this.bt_infoUsuario.Click += new System.EventHandler(this.bt_infoUsuario_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 305);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_infoUsuario);
            this.Name = "menuInicial";
            this.Text = "menuInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_infoUsuario;
        private System.Windows.Forms.Button button1;
    }
}