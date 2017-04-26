namespace ConsoleApp1
{
    partial class frmRegistrarVenta
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
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblNombProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNombProd = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.lblCantProd = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(49, 79);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(67, 13);
            this.lblIdProd.TabIndex = 0;
            this.lblIdProd.Text = "ID Producto:";
            this.lblIdProd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombProd
            // 
            this.lblNombProd.AutoSize = true;
            this.lblNombProd.Location = new System.Drawing.Point(49, 110);
            this.lblNombProd.Name = "lblNombProd";
            this.lblNombProd.Size = new System.Drawing.Size(108, 13);
            this.lblNombProd.TabIndex = 1;
            this.lblNombProd.Text = "Nombre de Producto:";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(176, 76);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(293, 20);
            this.txtIdProd.TabIndex = 2;
            // 
            // txtNombProd
            // 
            this.txtNombProd.Location = new System.Drawing.Point(176, 107);
            this.txtNombProd.Name = "txtNombProd";
            this.txtNombProd.Size = new System.Drawing.Size(129, 20);
            this.txtNombProd.TabIndex = 3;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(52, 153);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(510, 219);
            this.dgvProductos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(133, 392);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Location = new System.Drawing.Point(487, 392);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(75, 23);
            this.btnAdquirir.TabIndex = 7;
            this.btnAdquirir.Text = "Adquirir";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            // 
            // lblCantProd
            // 
            this.lblCantProd.AutoSize = true;
            this.lblCantProd.Location = new System.Drawing.Point(351, 110);
            this.lblCantProd.Name = "lblCantProd";
            this.lblCantProd.Size = new System.Drawing.Size(52, 13);
            this.lblCantProd.TabIndex = 8;
            this.lblCantProd.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(409, 108);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(153, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(176, 36);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(386, 21);
            this.cmbSelect.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Qué desea adquirir?";
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblCantProd);
            this.Controls.Add(this.btnAdquirir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtNombProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lblNombProd);
            this.Controls.Add(this.lblIdProd);
            this.Name = "frmRegistrarVenta";
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblNombProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtNombProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdquirir;
        private System.Windows.Forms.Label lblCantProd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label label1;
    }
}