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
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label actorIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rTiposProductos));
            this.IDTipoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTipoTextBox = new System.Windows.Forms.TextBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.radioButtonNoactivo = new System.Windows.Forms.RadioButton();
            this.radioButtonActivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProviderButonACtivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderButonNoactiv = new System.Windows.Forms.ErrorProvider(this.components);
            peliculaIdLabel = new System.Windows.Forms.Label();
            actorIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButonACtivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButonNoactiv)).BeginInit();
            this.SuspendLayout();
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            peliculaIdLabel.Location = new System.Drawing.Point(112, 9);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(80, 17);
            peliculaIdLabel.TabIndex = 34;
            peliculaIdLabel.Text = "REGISTRO";
            // 
            // actorIdLabel
            // 
            actorIdLabel.AutoSize = true;
            actorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            actorIdLabel.Location = new System.Drawing.Point(17, 37);
            actorIdLabel.Name = "actorIdLabel";
            actorIdLabel.Size = new System.Drawing.Size(21, 17);
            actorIdLabel.TabIndex = 26;
            actorIdLabel.Text = "ID";
            // 
            // IDTipoTextBox
            // 
            this.IDTipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.IDTipoTextBox.Location = new System.Drawing.Point(157, 37);
            this.IDTipoTextBox.Name = "IDTipoTextBox";
            this.IDTipoTextBox.Size = new System.Drawing.Size(61, 23);
            this.IDTipoTextBox.TabIndex = 27;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            nombreLabel.Location = new System.Drawing.Point(17, 63);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(135, 17);
            nombreLabel.TabIndex = 28;
            nombreLabel.Text = "NOMBRE DEL TIPO";
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
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(26, 213);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 51);
            this.NewButton.TabIndex = 38;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(126, 212);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 52);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(218, 213);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(60, 52);
            this.Deletebutton.TabIndex = 40;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(223, 31);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 29);
            this.searchButton.TabIndex = 37;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // radioButtonNoactivo
            // 
            this.radioButtonNoactivo.AutoSize = true;
            this.radioButtonNoactivo.Location = new System.Drawing.Point(182, 31);
            this.radioButtonNoactivo.Name = "radioButtonNoactivo";
            this.radioButtonNoactivo.Size = new System.Drawing.Size(80, 21);
            this.radioButtonNoactivo.TabIndex = 42;
            this.radioButtonNoactivo.Text = "noActivo";
            this.radioButtonNoactivo.UseVisualStyleBackColor = true;
            this.radioButtonNoactivo.CheckedChanged += new System.EventHandler(this.radioButtonNoactivo_CheckedChanged);
            // 
            // radioButtonActivo
            // 
            this.radioButtonActivo.AutoSize = true;
            this.radioButtonActivo.Location = new System.Drawing.Point(6, 31);
            this.radioButtonActivo.Name = "radioButtonActivo";
            this.radioButtonActivo.Size = new System.Drawing.Size(79, 21);
            this.radioButtonActivo.TabIndex = 41;
            this.radioButtonActivo.Text = "esActivo";
            this.radioButtonActivo.UseVisualStyleBackColor = true;
            this.radioButtonActivo.CheckedChanged += new System.EventHandler(this.radioButtonActivo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNoactivo);
            this.groupBox1.Controls.Add(this.radioButtonActivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(20, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 82);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO";
            // 
            // errorProviderButonACtivo
            // 
            this.errorProviderButonACtivo.ContainerControl = this;
            // 
            // errorProviderButonNoactiv
            // 
            this.errorProviderButonNoactiv.ContainerControl = this;
            // 
            // rTiposProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(actorIdLabel);
            this.Controls.Add(this.IDTipoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTipoTextBox);
            this.Name = "rTiposProductos";
            this.Text = "TIPOS DE PRODUCTOS";
            this.Load += new System.EventHandler(this.rTiposProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButonACtivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButonNoactiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDTipoTextBox;
        private System.Windows.Forms.TextBox nombreTipoTextBox;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton radioButtonNoactivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonActivo;
        private System.Windows.Forms.ErrorProvider errorProviderButonACtivo;
        private System.Windows.Forms.ErrorProvider errorProviderButonNoactiv;
    }
}