namespace Pizzería.Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.btnMinMaxLogin = new System.Windows.Forms.PictureBox();
            this.btnCerrarLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.RichTextBox();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnLogin = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinMaxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizarLogin
            // 
            this.btnMinimizarLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarLogin.Image")));
            this.btnMinimizarLogin.Location = new System.Drawing.Point(633, 12);
            this.btnMinimizarLogin.Name = "btnMinimizarLogin";
            this.btnMinimizarLogin.Size = new System.Drawing.Size(39, 31);
            this.btnMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizarLogin.TabIndex = 15;
            this.btnMinimizarLogin.TabStop = false;
            this.btnMinimizarLogin.Click += new System.EventHandler(this.btnMinimizarLogin_Click);
            // 
            // btnMinMaxLogin
            // 
            this.btnMinMaxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinMaxLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnMinMaxLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnMinMaxLogin.Image")));
            this.btnMinMaxLogin.Location = new System.Drawing.Point(678, 12);
            this.btnMinMaxLogin.Name = "btnMinMaxLogin";
            this.btnMinMaxLogin.Size = new System.Drawing.Size(39, 31);
            this.btnMinMaxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinMaxLogin.TabIndex = 16;
            this.btnMinMaxLogin.TabStop = false;
            this.btnMinMaxLogin.Click += new System.EventHandler(this.btnMinMaxLogin_Click);
            // 
            // btnCerrarLogin
            // 
            this.btnCerrarLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarLogin.Image")));
            this.btnCerrarLogin.Location = new System.Drawing.Point(723, 12);
            this.btnCerrarLogin.Name = "btnCerrarLogin";
            this.btnCerrarLogin.Size = new System.Drawing.Size(39, 31);
            this.btnCerrarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarLogin.TabIndex = 17;
            this.btnCerrarLogin.TabStop = false;
            this.btnCerrarLogin.Click += new System.EventHandler(this.btnCerrarLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.tbContraseña);
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(178, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 88);
            this.panel1.TabIndex = 18;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.Gray;
            this.tbContraseña.Location = new System.Drawing.Point(3, 40);
            this.tbContraseña.Multiline = true;
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(257, 34);
            this.tbContraseña.TabIndex = 2;
            this.tbContraseña.Text = "Contraseña";
            this.tbContraseña.Enter += new System.EventHandler(this.tbContraseña_Enter);
            this.tbContraseña.Leave += new System.EventHandler(this.tbContraseña_Leave);
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.tbMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMail.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.ForeColor = System.Drawing.Color.Gray;
            this.tbMail.Location = new System.Drawing.Point(0, 0);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(259, 34);
            this.tbMail.TabIndex = 1;
            this.tbMail.Text = "Correo Electronico";
            this.tbMail.Enter += new System.EventHandler(this.tbMail_Enter);
            this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 4;
            this.lineShape6.X2 = 258;
            this.lineShape6.Y1 = 81;
            this.lineShape6.Y2 = 81;
            this.lineShape6.Click += new System.EventHandler(this.lineShape6_Click);
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 4;
            this.lineShape5.X2 = 257;
            this.lineShape5.Y1 = 37;
            this.lineShape5.Y2 = 37;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(194)))));
            this.btnLogin.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(268, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5});
            this.shapeContainer1.Size = new System.Drawing.Size(263, 88);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrarLogin);
            this.Controls.Add(this.btnMinMaxLogin);
            this.Controls.Add(this.btnMinimizarLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinMaxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizarLogin;
        private System.Windows.Forms.PictureBox btnMinMaxLogin;
        private System.Windows.Forms.PictureBox btnCerrarLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.RichTextBox tbMail;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Button btnLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}