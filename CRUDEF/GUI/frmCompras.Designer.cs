namespace GUI
{
    partial class frmCompras
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
            this.btnCompras = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnAplcarDescuento = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompras
            // 
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Location = new System.Drawing.Point(28, 43);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(145, 49);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "Traer Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(28, 115);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(748, 288);
            this.dgvCompras.TabIndex = 1;
            // 
            // btnAplcarDescuento
            // 
            this.btnAplcarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplcarDescuento.Location = new System.Drawing.Point(216, 43);
            this.btnAplcarDescuento.Name = "btnAplcarDescuento";
            this.btnAplcarDescuento.Size = new System.Drawing.Size(145, 49);
            this.btnAplcarDescuento.TabIndex = 2;
            this.btnAplcarDescuento.Text = "Aplicar Descuento";
            this.btnAplcarDescuento.UseVisualStyleBackColor = true;
            this.btnAplcarDescuento.Click += new System.EventHandler(this.btnAplcarDescuento_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(411, 43);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 29);
            this.txtDescuento.TabIndex = 3;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnAplcarDescuento);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnCompras);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnAplcarDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
    }
}