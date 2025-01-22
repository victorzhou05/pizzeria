namespace Pizzería.Vistas
{
    partial class CrearPizza
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
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbQueso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSalsa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTamano = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMasaSig = new System.Windows.Forms.Button();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.gbIngredientes = new System.Windows.Forms.GroupBox();
            this.btnIngrAtras = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clbVerduras = new System.Windows.Forms.CheckedListBox();
            this.clbCarnes = new System.Windows.Forms.CheckedListBox();
            this.btnIngrSig = new System.Windows.Forms.Button();
            this.gbCompletar = new System.Windows.Forms.GroupBox();
            this.tbCompNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvBase = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvVerduras = new System.Windows.Forms.ListView();
            this.lvCarnes = new System.Windows.Forms.ListView();
            this.btnCompAtras = new System.Windows.Forms.Button();
            this.btnCompFin = new System.Windows.Forms.Button();
            this.rtbImagen = new System.Windows.Forms.RichTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbBase.SuspendLayout();
            this.gbIngredientes.SuspendLayout();
            this.gbCompletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBase
            // 
            this.gbBase.Controls.Add(this.label4);
            this.gbBase.Controls.Add(this.cbQueso);
            this.gbBase.Controls.Add(this.label3);
            this.gbBase.Controls.Add(this.cbSalsa);
            this.gbBase.Controls.Add(this.label1);
            this.gbBase.Controls.Add(this.cbTamano);
            this.gbBase.Controls.Add(this.label2);
            this.gbBase.Controls.Add(this.btnMasaSig);
            this.gbBase.Controls.Add(this.cbMasa);
            this.gbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbBase.Location = new System.Drawing.Point(522, 40);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(256, 346);
            this.gbBase.TabIndex = 3;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(26, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Queso:";
            // 
            // cbQueso
            // 
            this.cbQueso.FormattingEnabled = true;
            this.cbQueso.Items.AddRange(new object[] {
            "Queso Cheddar",
            "Queso Suizo",
            "Queso Provolone",
            "Queso de Rulo",
            "4 Quesos",
            "Sin queso"});
            this.cbQueso.Location = new System.Drawing.Point(29, 254);
            this.cbQueso.Name = "cbQueso";
            this.cbQueso.Size = new System.Drawing.Size(189, 25);
            this.cbQueso.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(26, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salsa:";
            // 
            // cbSalsa
            // 
            this.cbSalsa.FormattingEnabled = true;
            this.cbSalsa.Items.AddRange(new object[] {
            "Tomate",
            "Carbonara",
            "Barbacoa",
            "Sin salsa"});
            this.cbSalsa.Location = new System.Drawing.Point(29, 189);
            this.cbSalsa.Name = "cbSalsa";
            this.cbSalsa.Size = new System.Drawing.Size(189, 25);
            this.cbSalsa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamaño:";
            // 
            // cbTamano
            // 
            this.cbTamano.FormattingEnabled = true;
            this.cbTamano.Items.AddRange(new object[] {
            "Individual",
            "Mediana",
            "Familiar"});
            this.cbTamano.Location = new System.Drawing.Point(29, 60);
            this.cbTamano.Name = "cbTamano";
            this.cbTamano.Size = new System.Drawing.Size(189, 25);
            this.cbTamano.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masa";
            // 
            // btnMasaSig
            // 
            this.btnMasaSig.Location = new System.Drawing.Point(149, 308);
            this.btnMasaSig.Name = "btnMasaSig";
            this.btnMasaSig.Size = new System.Drawing.Size(101, 32);
            this.btnMasaSig.TabIndex = 1;
            this.btnMasaSig.Text = "Siguiente";
            this.btnMasaSig.UseVisualStyleBackColor = true;
            this.btnMasaSig.Click += new System.EventHandler(this.btnMasaSig_Click);
            // 
            // cbMasa
            // 
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Items.AddRange(new object[] {
            "Tradicional",
            "Fina",
            "Gruesa"});
            this.cbMasa.Location = new System.Drawing.Point(29, 124);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(189, 25);
            this.cbMasa.TabIndex = 0;
            // 
            // gbIngredientes
            // 
            this.gbIngredientes.Controls.Add(this.btnIngrAtras);
            this.gbIngredientes.Controls.Add(this.label6);
            this.gbIngredientes.Controls.Add(this.label5);
            this.gbIngredientes.Controls.Add(this.clbVerduras);
            this.gbIngredientes.Controls.Add(this.clbCarnes);
            this.gbIngredientes.Controls.Add(this.btnIngrSig);
            this.gbIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbIngredientes.Location = new System.Drawing.Point(522, 40);
            this.gbIngredientes.Name = "gbIngredientes";
            this.gbIngredientes.Size = new System.Drawing.Size(256, 346);
            this.gbIngredientes.TabIndex = 11;
            this.gbIngredientes.TabStop = false;
            this.gbIngredientes.Text = "Ingredientes";
            // 
            // btnIngrAtras
            // 
            this.btnIngrAtras.Location = new System.Drawing.Point(9, 308);
            this.btnIngrAtras.Name = "btnIngrAtras";
            this.btnIngrAtras.Size = new System.Drawing.Size(101, 32);
            this.btnIngrAtras.TabIndex = 6;
            this.btnIngrAtras.Text = "Atrás";
            this.btnIngrAtras.UseVisualStyleBackColor = true;
            this.btnIngrAtras.Click += new System.EventHandler(this.btnIngrAtras_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carnes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verduras:";
            // 
            // clbVerduras
            // 
            this.clbVerduras.FormattingEnabled = true;
            this.clbVerduras.Items.AddRange(new object[] {
            "Champiñon",
            "Cebolla",
            "Aceitunas",
            "Pimiento"});
            this.clbVerduras.Location = new System.Drawing.Point(6, 192);
            this.clbVerduras.Name = "clbVerduras";
            this.clbVerduras.Size = new System.Drawing.Size(238, 112);
            this.clbVerduras.TabIndex = 3;
            // 
            // clbCarnes
            // 
            this.clbCarnes.FormattingEnabled = true;
            this.clbCarnes.Items.AddRange(new object[] {
            "Ternera",
            "Pollo",
            "Pepperoni",
            "Cerdo",
            "Atun"});
            this.clbCarnes.Location = new System.Drawing.Point(6, 54);
            this.clbCarnes.Name = "clbCarnes";
            this.clbCarnes.Size = new System.Drawing.Size(238, 112);
            this.clbCarnes.TabIndex = 2;
            // 
            // btnIngrSig
            // 
            this.btnIngrSig.Location = new System.Drawing.Point(149, 308);
            this.btnIngrSig.Name = "btnIngrSig";
            this.btnIngrSig.Size = new System.Drawing.Size(101, 32);
            this.btnIngrSig.TabIndex = 1;
            this.btnIngrSig.Text = "Siguiente";
            this.btnIngrSig.UseVisualStyleBackColor = true;
            this.btnIngrSig.Click += new System.EventHandler(this.btnIngrSig_Click);
            // 
            // gbCompletar
            // 
            this.gbCompletar.Controls.Add(this.tbCompNombre);
            this.gbCompletar.Controls.Add(this.label10);
            this.gbCompletar.Controls.Add(this.label9);
            this.gbCompletar.Controls.Add(this.lvBase);
            this.gbCompletar.Controls.Add(this.label8);
            this.gbCompletar.Controls.Add(this.label7);
            this.gbCompletar.Controls.Add(this.lvVerduras);
            this.gbCompletar.Controls.Add(this.lvCarnes);
            this.gbCompletar.Controls.Add(this.btnCompAtras);
            this.gbCompletar.Controls.Add(this.btnCompFin);
            this.gbCompletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbCompletar.Location = new System.Drawing.Point(522, 40);
            this.gbCompletar.Name = "gbCompletar";
            this.gbCompletar.Size = new System.Drawing.Size(256, 346);
            this.gbCompletar.TabIndex = 12;
            this.gbCompletar.TabStop = false;
            this.gbCompletar.Text = "Completar";
            // 
            // tbCompNombre
            // 
            this.tbCompNombre.Location = new System.Drawing.Point(36, 277);
            this.tbCompNombre.Name = "tbCompNombre";
            this.tbCompNombre.Size = new System.Drawing.Size(182, 23);
            this.tbCompNombre.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Base";
            // 
            // lvBase
            // 
            this.lvBase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvBase.HideSelection = false;
            this.lvBase.Location = new System.Drawing.Point(6, 40);
            this.lvBase.Name = "lvBase";
            this.lvBase.Size = new System.Drawing.Size(244, 97);
            this.lvBase.TabIndex = 11;
            this.lvBase.UseCompatibleStateImageBehavior = false;
            this.lvBase.View = System.Windows.Forms.View.List;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Verduras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Carnes";
            // 
            // lvVerduras
            // 
            this.lvVerduras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvVerduras.HideSelection = false;
            this.lvVerduras.Location = new System.Drawing.Point(129, 160);
            this.lvVerduras.Name = "lvVerduras";
            this.lvVerduras.Size = new System.Drawing.Size(117, 96);
            this.lvVerduras.TabIndex = 8;
            this.lvVerduras.UseCompatibleStateImageBehavior = false;
            this.lvVerduras.View = System.Windows.Forms.View.List;
            // 
            // lvCarnes
            // 
            this.lvCarnes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvCarnes.HideSelection = false;
            this.lvCarnes.Location = new System.Drawing.Point(6, 160);
            this.lvCarnes.Name = "lvCarnes";
            this.lvCarnes.Size = new System.Drawing.Size(117, 96);
            this.lvCarnes.TabIndex = 7;
            this.lvCarnes.UseCompatibleStateImageBehavior = false;
            this.lvCarnes.View = System.Windows.Forms.View.List;
            // 
            // btnCompAtras
            // 
            this.btnCompAtras.Location = new System.Drawing.Point(9, 308);
            this.btnCompAtras.Name = "btnCompAtras";
            this.btnCompAtras.Size = new System.Drawing.Size(101, 32);
            this.btnCompAtras.TabIndex = 6;
            this.btnCompAtras.Text = "Atrás";
            this.btnCompAtras.UseVisualStyleBackColor = true;
            this.btnCompAtras.Click += new System.EventHandler(this.btnCompAtras_Click);
            // 
            // btnCompFin
            // 
            this.btnCompFin.Location = new System.Drawing.Point(149, 308);
            this.btnCompFin.Name = "btnCompFin";
            this.btnCompFin.Size = new System.Drawing.Size(101, 32);
            this.btnCompFin.TabIndex = 1;
            this.btnCompFin.Text = "Finalizar";
            this.btnCompFin.UseVisualStyleBackColor = true;
            this.btnCompFin.Click += new System.EventHandler(this.btnCompFin_Click);
            // 
            // rtbImagen
            // 
            this.rtbImagen.Location = new System.Drawing.Point(12, 40);
            this.rtbImagen.Name = "rtbImagen";
            this.rtbImagen.ReadOnly = true;
            this.rtbImagen.Size = new System.Drawing.Size(483, 340);
            this.rtbImagen.TabIndex = 12;
            this.rtbImagen.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 244;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 117;
            // 
            // CrearPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCompletar);
            this.Controls.Add(this.gbIngredientes);
            this.Controls.Add(this.rtbImagen);
            this.Controls.Add(this.gbBase);
            this.Name = "CrearPizza";
            this.Text = "CrearPizza";
            this.Load += new System.EventHandler(this.CrearPizza_Load);
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.gbIngredientes.ResumeLayout(false);
            this.gbIngredientes.PerformLayout();
            this.gbCompletar.ResumeLayout(false);
            this.gbCompletar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMasaSig;
        private System.Windows.Forms.ComboBox cbMasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbQueso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSalsa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTamano;
        private System.Windows.Forms.GroupBox gbIngredientes;
        private System.Windows.Forms.Button btnIngrAtras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbVerduras;
        private System.Windows.Forms.CheckedListBox clbCarnes;
        private System.Windows.Forms.Button btnIngrSig;
        private System.Windows.Forms.GroupBox gbCompletar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvVerduras;
        private System.Windows.Forms.ListView lvCarnes;
        private System.Windows.Forms.Button btnCompAtras;
        private System.Windows.Forms.Button btnCompFin;
        private System.Windows.Forms.TextBox tbCompNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbImagen;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}