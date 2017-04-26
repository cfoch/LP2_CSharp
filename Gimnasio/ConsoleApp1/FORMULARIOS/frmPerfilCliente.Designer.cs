namespace ConsoleApp1
{
    partial class frmPerfilCliente
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.lblApMat = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdMembresia = new System.Windows.Forms.Label();
            this.gbDatosPers1 = new System.Windows.Forms.GroupBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.gbDatosMembresia = new System.Windows.Forms.GroupBox();
            this.txtFreezRestante = new System.Windows.Forms.TextBox();
            this.txtPeriodoFreez = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTipoMembresia = new System.Windows.Forms.TextBox();
            this.txtIdMembresia = new System.Windows.Forms.TextBox();
            this.lblPeriodoFreezing = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFreez = new System.Windows.Forms.Label();
            this.lblTipoMembresia = new System.Windows.Forms.Label();
            this.gbServiciosAd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosPers1.SuspendLayout();
            this.gbDatosMembresia.SuspendLayout();
            this.gbServiciosAd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(78, 68);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(35, 309);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Location = new System.Drawing.Point(78, 131);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(87, 13);
            this.lblApPat.TabIndex = 3;
            this.lblApPat.Text = "Apellido Paterno:";
            this.lblApPat.Click += new System.EventHandler(this.lblApPat_Click);
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Location = new System.Drawing.Point(78, 162);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(89, 13);
            this.lblApMat.TabIndex = 4;
            this.lblApMat.Text = "Apellido Materno:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(35, 278);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(35, 212);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 6;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(35, 178);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(35, 246);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblIdMembresia
            // 
            this.lblIdMembresia.AutoSize = true;
            this.lblIdMembresia.Location = new System.Drawing.Point(35, 32);
            this.lblIdMembresia.Name = "lblIdMembresia";
            this.lblIdMembresia.Size = new System.Drawing.Size(75, 13);
            this.lblIdMembresia.TabIndex = 9;
            this.lblIdMembresia.Text = "ID Membresia:";
            // 
            // gbDatosPers1
            // 
            this.gbDatosPers1.Controls.Add(this.txtFechaNacimiento);
            this.gbDatosPers1.Controls.Add(this.txtCorreo);
            this.gbDatosPers1.Controls.Add(this.txtTelefono);
            this.gbDatosPers1.Controls.Add(this.txtDistrito);
            this.gbDatosPers1.Controls.Add(this.txtDireccion);
            this.gbDatosPers1.Controls.Add(this.txtApMat);
            this.gbDatosPers1.Controls.Add(this.txtApPat);
            this.gbDatosPers1.Controls.Add(this.txtNombre);
            this.gbDatosPers1.Controls.Add(this.txtDni);
            this.gbDatosPers1.Controls.Add(this.lblDireccion);
            this.gbDatosPers1.Controls.Add(this.lblCorreo);
            this.gbDatosPers1.Controls.Add(this.lblTelefono);
            this.gbDatosPers1.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosPers1.Controls.Add(this.lblDistrito);
            this.gbDatosPers1.Location = new System.Drawing.Point(43, 31);
            this.gbDatosPers1.Name = "gbDatosPers1";
            this.gbDatosPers1.Size = new System.Drawing.Size(622, 345);
            this.gbDatosPers1.TabIndex = 10;
            this.gbDatosPers1.TabStop = false;
            this.gbDatosPers1.Text = "Datos Personales";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(488, 309);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(117, 20);
            this.txtFechaNacimiento.TabIndex = 17;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(398, 278);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(206, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(486, 246);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(119, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(398, 212);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(207, 20);
            this.txtDistrito.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(346, 178);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(398, 131);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(208, 20);
            this.txtApMat.TabIndex = 12;
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(398, 100);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(208, 20);
            this.txtApPat.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(398, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(486, 37);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(120, 20);
            this.txtDni.TabIndex = 9;
            // 
            // gbDatosMembresia
            // 
            this.gbDatosMembresia.Controls.Add(this.txtFreezRestante);
            this.gbDatosMembresia.Controls.Add(this.txtPeriodoFreez);
            this.gbDatosMembresia.Controls.Add(this.txtFechaInicio);
            this.gbDatosMembresia.Controls.Add(this.txtFechaFin);
            this.gbDatosMembresia.Controls.Add(this.txtEstado);
            this.gbDatosMembresia.Controls.Add(this.txtTipoMembresia);
            this.gbDatosMembresia.Controls.Add(this.txtIdMembresia);
            this.gbDatosMembresia.Controls.Add(this.lblPeriodoFreezing);
            this.gbDatosMembresia.Controls.Add(this.lblFechaFin);
            this.gbDatosMembresia.Controls.Add(this.lblFechaInicio);
            this.gbDatosMembresia.Controls.Add(this.lblEstado);
            this.gbDatosMembresia.Controls.Add(this.lblFreez);
            this.gbDatosMembresia.Controls.Add(this.lblTipoMembresia);
            this.gbDatosMembresia.Controls.Add(this.lblIdMembresia);
            this.gbDatosMembresia.Location = new System.Drawing.Point(43, 406);
            this.gbDatosMembresia.Name = "gbDatosMembresia";
            this.gbDatosMembresia.Size = new System.Drawing.Size(622, 199);
            this.gbDatosMembresia.TabIndex = 11;
            this.gbDatosMembresia.TabStop = false;
            this.gbDatosMembresia.Text = "Datos de Membresia";
            // 
            // txtFreezRestante
            // 
            this.txtFreezRestante.Location = new System.Drawing.Point(491, 160);
            this.txtFreezRestante.Name = "txtFreezRestante";
            this.txtFreezRestante.Size = new System.Drawing.Size(115, 20);
            this.txtFreezRestante.TabIndex = 22;
            // 
            // txtPeriodoFreez
            // 
            this.txtPeriodoFreez.Location = new System.Drawing.Point(202, 156);
            this.txtPeriodoFreez.Name = "txtPeriodoFreez";
            this.txtPeriodoFreez.Size = new System.Drawing.Size(115, 20);
            this.txtPeriodoFreez.TabIndex = 21;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(202, 126);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(115, 20);
            this.txtFechaInicio.TabIndex = 20;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(491, 126);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(115, 20);
            this.txtFechaFin.TabIndex = 19;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(491, 95);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(115, 20);
            this.txtEstado.TabIndex = 18;
            // 
            // txtTipoMembresia
            // 
            this.txtTipoMembresia.Location = new System.Drawing.Point(491, 63);
            this.txtTipoMembresia.Name = "txtTipoMembresia";
            this.txtTipoMembresia.Size = new System.Drawing.Size(115, 20);
            this.txtTipoMembresia.TabIndex = 17;
            // 
            // txtIdMembresia
            // 
            this.txtIdMembresia.Location = new System.Drawing.Point(490, 32);
            this.txtIdMembresia.Name = "txtIdMembresia";
            this.txtIdMembresia.Size = new System.Drawing.Size(116, 20);
            this.txtIdMembresia.TabIndex = 16;
            // 
            // lblPeriodoFreezing
            // 
            this.lblPeriodoFreezing.AutoSize = true;
            this.lblPeriodoFreezing.Location = new System.Drawing.Point(35, 163);
            this.lblPeriodoFreezing.Name = "lblPeriodoFreezing";
            this.lblPeriodoFreezing.Size = new System.Drawing.Size(136, 13);
            this.lblPeriodoFreezing.TabIndex = 15;
            this.lblPeriodoFreezing.Text = "Fin de Periodo de Freezing:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(359, 129);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 14;
            this.lblFechaFin.Text = "Fecha de fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(35, 129);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(82, 13);
            this.lblFechaInicio.TabIndex = 13;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(35, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFreez
            // 
            this.lblFreez.AutoSize = true;
            this.lblFreez.Location = new System.Drawing.Point(359, 163);
            this.lblFreez.Name = "lblFreez";
            this.lblFreez.Size = new System.Drawing.Size(96, 13);
            this.lblFreez.TabIndex = 11;
            this.lblFreez.Text = "Freezing Restante:";
            // 
            // lblTipoMembresia
            // 
            this.lblTipoMembresia.AutoSize = true;
            this.lblTipoMembresia.Location = new System.Drawing.Point(35, 63);
            this.lblTipoMembresia.Name = "lblTipoMembresia";
            this.lblTipoMembresia.Size = new System.Drawing.Size(100, 13);
            this.lblTipoMembresia.TabIndex = 10;
            this.lblTipoMembresia.Text = "Tipo de Membresia:";
            // 
            // gbServiciosAd
            // 
            this.gbServiciosAd.Controls.Add(this.label1);
            this.gbServiciosAd.Location = new System.Drawing.Point(43, 630);
            this.gbServiciosAd.Name = "gbServiciosAd";
            this.gbServiciosAd.Size = new System.Drawing.Size(622, 107);
            this.gbServiciosAd.TabIndex = 12;
            this.gbServiciosAd.TabStop = false;
            this.gbServiciosAd.Text = "Servicios Adicionales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No está afiliado a ningún servicio.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 770);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cursos inscritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No está inscrito a ningún curso.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPerfilCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbServiciosAd);
            this.Controls.Add(this.lblApMat);
            this.Controls.Add(this.lblApPat);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.gbDatosPers1);
            this.Controls.Add(this.gbDatosMembresia);
            this.Name = "frmPerfilCliente";
            this.Text = "Perfil Cliente";
            this.gbDatosPers1.ResumeLayout(false);
            this.gbDatosPers1.PerformLayout();
            this.gbDatosMembresia.ResumeLayout(false);
            this.gbDatosMembresia.PerformLayout();
            this.gbServiciosAd.ResumeLayout(false);
            this.gbServiciosAd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblIdMembresia;
        private System.Windows.Forms.GroupBox gbDatosPers1;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox gbDatosMembresia;
        private System.Windows.Forms.Label lblTipoMembresia;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFreez;
        private System.Windows.Forms.TextBox txtFreezRestante;
        private System.Windows.Forms.TextBox txtPeriodoFreez;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTipoMembresia;
        private System.Windows.Forms.TextBox txtIdMembresia;
        private System.Windows.Forms.Label lblPeriodoFreezing;
        private System.Windows.Forms.GroupBox gbServiciosAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}