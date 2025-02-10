namespace Pizzería.Vistas
{
    partial class FormAdministrador
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
            this.lv_usuarios = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_elegirUsuario = new System.Windows.Forms.Label();
            this.bt_seleccionarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_usuarios
            // 
            this.lv_usuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnUserName});
            this.lv_usuarios.FullRowSelect = true;
            this.lv_usuarios.HideSelection = false;
            this.lv_usuarios.Location = new System.Drawing.Point(63, 88);
            this.lv_usuarios.Name = "lv_usuarios";
            this.lv_usuarios.Size = new System.Drawing.Size(194, 175);
            this.lv_usuarios.TabIndex = 0;
            this.lv_usuarios.UseCompatibleStateImageBehavior = false;
            this.lv_usuarios.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id usuario";
            this.columnId.Width = 84;
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "Username";
            this.columnUserName.Width = 81;
            // 
            // lb_elegirUsuario
            // 
            this.lb_elegirUsuario.AutoSize = true;
            this.lb_elegirUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_elegirUsuario.ForeColor = System.Drawing.Color.Black;
            this.lb_elegirUsuario.Location = new System.Drawing.Point(81, 43);
            this.lb_elegirUsuario.Name = "lb_elegirUsuario";
            this.lb_elegirUsuario.Size = new System.Drawing.Size(152, 24);
            this.lb_elegirUsuario.TabIndex = 1;
            this.lb_elegirUsuario.Text = "Lista de usuarios";
            // 
            // bt_seleccionarUsuario
            // 
            this.bt_seleccionarUsuario.Location = new System.Drawing.Point(101, 286);
            this.bt_seleccionarUsuario.Name = "bt_seleccionarUsuario";
            this.bt_seleccionarUsuario.Size = new System.Drawing.Size(104, 72);
            this.bt_seleccionarUsuario.TabIndex = 2;
            this.bt_seleccionarUsuario.Text = "Seleccionar usuario";
            this.bt_seleccionarUsuario.UseVisualStyleBackColor = true;
            this.bt_seleccionarUsuario.Click += new System.EventHandler(this.bt_seleccionarUsuario_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 447);
            this.Controls.Add(this.bt_seleccionarUsuario);
            this.Controls.Add(this.lb_elegirUsuario);
            this.Controls.Add(this.lv_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_usuarios;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.Label lb_elegirUsuario;
        private System.Windows.Forms.Button bt_seleccionarUsuario;
    }
}