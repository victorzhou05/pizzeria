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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMasaSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.gbIngredientes = new System.Windows.Forms.GroupBox();
            this.btnIngrSig = new System.Windows.Forms.Button();
            this.clbCarnes = new System.Windows.Forms.CheckedListBox();
            this.clbVerduras = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngrAtras = new System.Windows.Forms.Button();
            this.gbBase.SuspendLayout();
            this.gbIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gbBase
            // 
            this.gbBase.Controls.Add(this.label4);
            this.gbBase.Controls.Add(this.comboBox4);
            this.gbBase.Controls.Add(this.label3);
            this.gbBase.Controls.Add(this.comboBox3);
            this.gbBase.Controls.Add(this.label1);
            this.gbBase.Controls.Add(this.comboBox2);
            this.gbBase.Controls.Add(this.label2);
            this.gbBase.Controls.Add(this.btnMasaSiguiente);
            this.gbBase.Controls.Add(this.comboBox1);
            this.gbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbBase.Location = new System.Drawing.Point(513, 40);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(256, 346);
            this.gbBase.TabIndex = 3;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "Base";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tradicional",
            "Fina",
            "Gruesa"});
            this.comboBox1.Location = new System.Drawing.Point(29, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // btnMasaSiguiente
            // 
            this.btnMasaSiguiente.Location = new System.Drawing.Point(149, 308);
            this.btnMasaSiguiente.Name = "btnMasaSiguiente";
            this.btnMasaSiguiente.Size = new System.Drawing.Size(101, 32);
            this.btnMasaSiguiente.TabIndex = 1;
            this.btnMasaSiguiente.Text = "Siguiente";
            this.btnMasaSiguiente.UseVisualStyleBackColor = true;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Individual",
            "Mediana",
            "Familiar"});
            this.comboBox2.Location = new System.Drawing.Point(29, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 25);
            this.comboBox2.TabIndex = 5;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tomate",
            "Carbonara",
            "Barbacoa",
            "Sin salsa"});
            this.comboBox3.Location = new System.Drawing.Point(29, 189);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(189, 25);
            this.comboBox3.TabIndex = 7;
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
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Queso Cheddar",
            "Queso Suizo",
            "Queso Provolone",
            "Queso de Rulo",
            "4 Quesos",
            "Sin queso"});
            this.comboBox4.Location = new System.Drawing.Point(29, 254);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(189, 25);
            this.comboBox4.TabIndex = 9;
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
            this.gbIngredientes.Location = new System.Drawing.Point(513, 40);
            this.gbIngredientes.Name = "gbIngredientes";
            this.gbIngredientes.Size = new System.Drawing.Size(256, 346);
            this.gbIngredientes.TabIndex = 11;
            this.gbIngredientes.TabStop = false;
            this.gbIngredientes.Text = "Ingredientes";
            this.gbIngredientes.Visible = false;
            // 
            // btnIngrSig
            // 
            this.btnIngrSig.Location = new System.Drawing.Point(149, 308);
            this.btnIngrSig.Name = "btnIngrSig";
            this.btnIngrSig.Size = new System.Drawing.Size(101, 32);
            this.btnIngrSig.TabIndex = 1;
            this.btnIngrSig.Text = "Siguiente";
            this.btnIngrSig.UseVisualStyleBackColor = true;
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
            // clbVerduras
            // 
            this.clbVerduras.FormattingEnabled = true;
            this.clbVerduras.Items.AddRange(new object[] {
            "Ternera",
            "Pollo",
            "Pepperoni",
            "Cerdo",
            "Atun"});
            this.clbVerduras.Location = new System.Drawing.Point(6, 192);
            this.clbVerduras.Name = "clbVerduras";
            this.clbVerduras.Size = new System.Drawing.Size(238, 112);
            this.clbVerduras.TabIndex = 3;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carnes:";
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
            // CrearPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbIngredientes);
            this.Controls.Add(this.gbBase);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearPizza";
            this.Text = "CrearPizza";
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.gbIngredientes.ResumeLayout(false);
            this.gbIngredientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMasaSiguiente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gbIngredientes;
        private System.Windows.Forms.Button btnIngrAtras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbVerduras;
        private System.Windows.Forms.CheckedListBox clbCarnes;
        private System.Windows.Forms.Button btnIngrSig;
    }
}