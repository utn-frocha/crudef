namespace GUI
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.grpAgregar = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregar
            // 
            this.grpAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpAgregar.Controls.Add(this.btnGuardar);
            this.grpAgregar.Controls.Add(this.cboGenero);
            this.grpAgregar.Controls.Add(this.dtpFecha);
            this.grpAgregar.Controls.Add(this.txtCodigo);
            this.grpAgregar.Controls.Add(this.txtEmail);
            this.grpAgregar.Controls.Add(this.txtApellido2);
            this.grpAgregar.Controls.Add(this.txtNombre);
            this.grpAgregar.Controls.Add(this.txtApellido1);
            this.grpAgregar.Controls.Add(this.txtCedula);
            this.grpAgregar.Location = new System.Drawing.Point(29, 27);
            this.grpAgregar.Name = "grpAgregar";
            this.grpAgregar.Size = new System.Drawing.Size(787, 343);
            this.grpAgregar.TabIndex = 0;
            this.grpAgregar.TabStop = false;
            this.grpAgregar.Text = "Agregar Personas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Lavender;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(587, 268);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 49);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Agregar Cliente";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(543, 133);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(212, 28);
            this.cboGenero.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(216, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(212, 26);
            this.dtpFecha.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(543, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(212, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(216, 185);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(212, 26);
            this.txtApellido2.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(216, 135);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(212, 26);
            this.txtApellido1.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(216, 52);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(212, 26);
            this.txtCedula.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 401);
            this.Controls.Add(this.grpAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAgregar";
            this.Text = "frmAgregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.grpAgregar.ResumeLayout(false);
            this.grpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}