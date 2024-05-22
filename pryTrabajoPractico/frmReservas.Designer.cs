namespace pryTrabajoPractico
{
    partial class frmReservas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Local = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbtAzul = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtVerde = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "quenaken",
            "onas",
            "tobas"});
            this.cmbLocal.Location = new System.Drawing.Point(68, 9);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(142, 21);
            this.cmbLocal.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(276, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(6, 59);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Local.Location = new System.Drawing.Point(18, 9);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(44, 18);
            this.Local.TabIndex = 3;
            this.Local.Text = "Local";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // rbtAzul
            // 
            this.rbtAzul.AutoSize = true;
            this.rbtAzul.Checked = true;
            this.rbtAzul.Location = new System.Drawing.Point(144, 20);
            this.rbtAzul.Name = "rbtAzul";
            this.rbtAzul.Size = new System.Drawing.Size(68, 17);
            this.rbtAzul.TabIndex = 6;
            this.rbtAzul.TabStop = true;
            this.rbtAzul.Text = "área azul";
            this.rbtAzul.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtVerde);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.rbtAzul);
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asiento y área";
            // 
            // rbtVerde
            // 
            this.rbtVerde.AutoSize = true;
            this.rbtVerde.Location = new System.Drawing.Point(144, 62);
            this.rbtVerde.Name = "rbtVerde";
            this.rbtVerde.Size = new System.Drawing.Size(76, 17);
            this.rbtVerde.TabIndex = 7;
            this.rbtVerde.Text = "área verde";
            this.rbtVerde.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de asiento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Área";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Local";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 174);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbLocal);
            this.Name = "frmReservas";
            this.Text = "Registro de reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label Local;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.RadioButton rbtAzul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtVerde;
    }
}

