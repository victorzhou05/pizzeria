namespace Pizzería.Vistas
{
    partial class Pizzeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizzeria));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_infoUsuario = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 191);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seleccionar Pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(409, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 191);
            this.button2.TabIndex = 1;
            this.button2.Text = "Crear Pizza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_infoUsuario
            // 
            this.bt_infoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_infoUsuario.FlatAppearance.BorderSize = 0;
            this.bt_infoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_infoUsuario.ImageIndex = 0;
            this.bt_infoUsuario.ImageList = this.images;
            this.bt_infoUsuario.Location = new System.Drawing.Point(12, 12);
            this.bt_infoUsuario.Name = "bt_infoUsuario";
            this.bt_infoUsuario.Size = new System.Drawing.Size(86, 77);
            this.bt_infoUsuario.TabIndex = 2;
            this.bt_infoUsuario.UseVisualStyleBackColor = true;
            this.bt_infoUsuario.Click += new System.EventHandler(this.bt_infoUsuario_Click);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "botonInfo.png");
            // 
            // Pizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_infoUsuario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Pizzeria";
            this.Text = "Pizzeria";
            this.Load += new System.EventHandler(this.Pizzeria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_infoUsuario;
        private System.Windows.Forms.ImageList images;
    }
}