namespace CotizacionesTech.Registros
{
    partial class rTiposProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rTiposProductos));
            this.actorIdLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.IDTipoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTipoTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxesActivo = new System.Windows.Forms.CheckBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actorIdLabel
            // 
            this.actorIdLabel.AutoSize = true;
            this.actorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.actorIdLabel.Location = new System.Drawing.Point(17, 37);
            this.actorIdLabel.Name = "actorIdLabel";
            this.actorIdLabel.Size = new System.Drawing.Size(21, 17);
            this.actorIdLabel.TabIndex = 26;
            this.actorIdLabel.Text = "ID";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.nombreLabel.Location = new System.Drawing.Point(17, 63);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(135, 17);
            this.nombreLabel.TabIndex = 28;
            this.nombreLabel.Text = "NOMBRE DEL TIPO";
            // 
            // IDTipoTextBox
            // 
            this.IDTipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.IDTipoTextBox.Location = new System.Drawing.Point(157, 37);
            this.IDTipoTextBox.Name = "IDTipoTextBox";
            this.IDTipoTextBox.Size = new System.Drawing.Size(61, 23);
            this.IDTipoTextBox.TabIndex = 27;
            // 
            // nombreTipoTextBox
            // 
            this.nombreTipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.nombreTipoTextBox.Location = new System.Drawing.Point(157, 63);
            this.nombreTipoTextBox.Name = "nombreTipoTextBox";
            this.nombreTipoTextBox.Size = new System.Drawing.Size(134, 23);
            this.nombreTipoTextBox.TabIndex = 29;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxesActivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(20, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 57);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO";
            // 
            // checkBoxesActivo
            // 
            this.checkBoxesActivo.AutoSize = true;
            this.checkBoxesActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.checkBoxesActivo.Location = new System.Drawing.Point(6, 22);
            this.checkBoxesActivo.Name = "checkBoxesActivo";
            this.checkBoxesActivo.Size = new System.Drawing.Size(80, 21);
            this.checkBoxesActivo.TabIndex = 44;
            this.checkBoxesActivo.Text = "esActivo";
            this.checkBoxesActivo.UseVisualStyleBackColor = true;
            this.checkBoxesActivo.CheckedChanged += new System.EventHandler(this.esActivo_CheckedChanged);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.Image")));
            this.buttonNuevo.Location = new System.Drawing.Point(28, 171);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(66, 51);
            this.buttonNuevo.TabIndex = 44;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(127, 169);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(66, 52);
            this.buttonGuardar.TabIndex = 45;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(214, 171);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(60, 52);
            this.buttonEliminar.TabIndex = 46;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(225, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 29);
            this.button4.TabIndex = 47;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rTiposProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 257);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actorIdLabel);
            this.Controls.Add(this.IDTipoTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTipoTextBox);
            this.Name = "rTiposProductos";
            this.Text = "TIPOS DE PRODUCTOS";
            this.Load += new System.EventHandler(this.rTiposProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDTipoTextBox;
        private System.Windows.Forms.TextBox nombreTipoTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxesActivo;
        private System.Windows.Forms.Label actorIdLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button button4;
    }
}