namespace ConsoleApp1.FORMULARIOS
{
    partial class frmCrearMembresia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombMem = new System.Windows.Forms.TextBox();
            this.txtDescMem = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtFreeMax = new System.Windows.Forms.TextBox();
            this.txtDiasMem = new System.Windows.Forms.TextBox();
            this.dgvMemb = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Membresía: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarifa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Freezing Máximo(en días): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duración de la membresía(expresada en días): ";
            // 
            // txtNombMem
            // 
            this.txtNombMem.Location = new System.Drawing.Point(173, 47);
            this.txtNombMem.Name = "txtNombMem";
            this.txtNombMem.Size = new System.Drawing.Size(226, 20);
            this.txtNombMem.TabIndex = 5;
            // 
            // txtDescMem
            // 
            this.txtDescMem.Location = new System.Drawing.Point(121, 80);
            this.txtDescMem.Name = "txtDescMem";
            this.txtDescMem.Size = new System.Drawing.Size(278, 20);
            this.txtDescMem.TabIndex = 6;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(294, 117);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(105, 20);
            this.txtTarifa.TabIndex = 7;
            // 
            // txtFreeMax
            // 
            this.txtFreeMax.Location = new System.Drawing.Point(294, 153);
            this.txtFreeMax.Name = "txtFreeMax";
            this.txtFreeMax.Size = new System.Drawing.Size(105, 20);
            this.txtFreeMax.TabIndex = 8;
            // 
            // txtDiasMem
            // 
            this.txtDiasMem.Location = new System.Drawing.Point(294, 190);
            this.txtDiasMem.Name = "txtDiasMem";
            this.txtDiasMem.Size = new System.Drawing.Size(105, 20);
            this.txtDiasMem.TabIndex = 9;
            // 
            // dgvMemb
            // 
            this.dgvMemb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemb.Location = new System.Drawing.Point(22, 224);
            this.dgvMemb.Name = "dgvMemb";
            this.dgvMemb.Size = new System.Drawing.Size(377, 115);
            this.dgvMemb.TabIndex = 10;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(22, 362);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 24);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(121, 364);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(224, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(324, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID Membresía: ";
            // 
            // txtIdMem
            // 
            this.txtIdMem.Location = new System.Drawing.Point(294, 12);
            this.txtIdMem.Name = "txtIdMem";
            this.txtIdMem.Size = new System.Drawing.Size(105, 20);
            this.txtIdMem.TabIndex = 16;
            // 
            // frmCrearMembresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 408);
            this.Controls.Add(this.txtIdMem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMemb);
            this.Controls.Add(this.txtDiasMem);
            this.Controls.Add(this.txtFreeMax);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtDescMem);
            this.Controls.Add(this.txtNombMem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearMembresia";
            this.Text = "Crear Membresia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombMem;
        private System.Windows.Forms.TextBox txtDescMem;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtFreeMax;
        private System.Windows.Forms.TextBox txtDiasMem;
        private System.Windows.Forms.DataGridView dgvMemb;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdMem;
    }
}