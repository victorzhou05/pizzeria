namespace Pizzería.Vistas
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.tbNombre = new System.Windows.Forms.RichTextBox();
            this.tbApellidos = new System.Windows.Forms.RichTextBox();
            this.tbMail = new System.Windows.Forms.RichTextBox();
            this.tbTelefono = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMinMax = new System.Windows.Forms.PictureBox();
            this.linkLabelYaTienesCuenta = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinMax)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.Gray;
            this.tbNombre.Location = new System.Drawing.Point(0, 0);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbNombre.Size = new System.Drawing.Size(97, 34);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.Text = "Nombre";
            this.tbNombre.Enter += new System.EventHandler(this.tbNombre_Enter);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellidos.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.ForeColor = System.Drawing.Color.Gray;
            this.tbApellidos.Location = new System.Drawing.Point(103, 0);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(183, 34);
            this.tbApellidos.TabIndex = 7;
            this.tbApellidos.Text = "Apellidos";
            this.tbApellidos.Enter += new System.EventHandler(this.tbApellidos_Enter);
            this.tbApellidos.Leave += new System.EventHandler(this.tbApellidos_Leave);
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.ForeColor = System.Drawing.Color.Gray;
            this.tbMail.Location = new System.Drawing.Point(3, 80);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(275, 34);
            this.tbMail.TabIndex = 14;
            this.tbMail.Text = "Correo Electronico";
            this.tbMail.Enter += new System.EventHandler(this.tbMail_Enter);
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefono.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.ForeColor = System.Drawing.Color.Gray;
            this.tbTelefono.Location = new System.Drawing.Point(0, 40);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(112, 34);
            this.tbTelefono.TabIndex = 9;
            this.tbTelefono.Text = "Telefono";
            this.tbTelefono.Enter += new System.EventHandler(this.tbTelefono_Enter);
            this.tbTelefono.Leave += new System.EventHandler(this.tbTelefono_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.tbContraseña);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.tbApellidos);
            this.panel1.Controls.Add(this.tbTelefono);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(171, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 124);
            this.panel1.TabIndex = 11;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.Gray;
            this.tbContraseña.Location = new System.Drawing.Point(118, 40);
            this.tbContraseña.Multiline = true;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(160, 34);
            this.tbContraseña.TabIndex = 13;
            this.tbContraseña.Text = "Contraseña";
            this.tbContraseña.Enter += new System.EventHandler(this.tbContraseña_Enter);
            this.tbContraseña.Leave += new System.EventHandler(this.tbContraseña_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(281, 124);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 3;
            this.lineShape6.X2 = 279;
            this.lineShape6.Y1 = 155;
            this.lineShape6.Y2 = 155;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 5;
            this.lineShape5.X2 = 281;
            this.lineShape5.Y1 = 117;
            this.lineShape5.Y2 = 117;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 107;
            this.lineShape4.X2 = 281;
            this.lineShape4.Y1 = 76;
            this.lineShape4.Y2 = 76;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 5;
            this.lineShape3.X2 = 99;
            this.lineShape3.Y1 = 76;
            this.lineShape3.Y2 = 76;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 107;
            this.lineShape2.X2 = 281;
            this.lineShape2.Y1 = 35;
            this.lineShape2.Y2 = 35;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 99;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 35;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.btnRegistrarse.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.Gray;
            this.btnRegistrarse.Location = new System.Drawing.Point(303, 307);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(125, 33);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(727, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(629, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMinMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMinMax.Image")));
            this.btnMinMax.Location = new System.Drawing.Point(674, 12);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(39, 31);
            this.btnMinMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinMax.TabIndex = 15;
            this.btnMinMax.TabStop = false;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // linkLabelYaTienesCuenta
            // 
            this.linkLabelYaTienesCuenta.AutoSize = true;
            this.linkLabelYaTienesCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.linkLabelYaTienesCuenta.Font = new System.Drawing.Font("MV Boli", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelYaTienesCuenta.Location = new System.Drawing.Point(190, 304);
            this.linkLabelYaTienesCuenta.Name = "linkLabelYaTienesCuenta";
            this.linkLabelYaTienesCuenta.Size = new System.Drawing.Size(93, 10);
            this.linkLabelYaTienesCuenta.TabIndex = 16;
            this.linkLabelYaTienesCuenta.TabStop = true;
            this.linkLabelYaTienesCuenta.Text = "¿YA TIENES CUENTA?";
            this.linkLabelYaTienesCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelYaTienesCuenta_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelYaTienesCuenta);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Register_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbNombre;
        private System.Windows.Forms.RichTextBox tbApellidos;
        private System.Windows.Forms.RichTextBox tbMail;
        private System.Windows.Forms.RichTextBox tbTelefono;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMinMax;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.LinkLabel linkLabelYaTienesCuenta;
    }
}