namespace CotizacionesTech.Registros
{
    partial class rProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.CostoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ProductoIdTextBox = new System.Windows.Forms.TextBox();
            this.MedidasLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.ProductoIdLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxesITBS = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxMedida = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCosto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecio = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Location = new System.Drawing.Point(54, 225);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(37, 13);
            this.PrecioLabel.TabIndex = 51;
            this.PrecioLabel.Text = "Precio";
            // 
            // CostoLabel
            // 
            this.CostoLabel.AutoSize = true;
            this.CostoLabel.Location = new System.Drawing.Point(54, 196);
            this.CostoLabel.Name = "CostoLabel";
            this.CostoLabel.Size = new System.Drawing.Size(34, 13);
            this.CostoLabel.TabIndex = 50;
            this.CostoLabel.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 49;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(119, 44);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 50);
            this.DescripcionTextBox.TabIndex = 0;
            // 
            // ProductoIdTextBox
            // 
            this.ProductoIdTextBox.Location = new System.Drawing.Point(119, 12);
            this.ProductoIdTextBox.Name = "ProductoIdTextBox";
            this.ProductoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoIdTextBox.TabIndex = 9;
            // 
            // MedidasLabel
            // 
            this.MedidasLabel.AutoSize = true;
            this.MedidasLabel.Location = new System.Drawing.Point(54, 106);
            this.MedidasLabel.Name = "MedidasLabel";
            this.MedidasLabel.Size = new System.Drawing.Size(47, 13);
            this.MedidasLabel.TabIndex = 43;
            this.MedidasLabel.Text = "Medidas";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(54, 44);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescripcionLabel.TabIndex = 42;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // ProductoIdLabel
            // 
            this.ProductoIdLabel.AutoSize = true;
            this.ProductoIdLabel.Location = new System.Drawing.Point(54, 15);
            this.ProductoIdLabel.Name = "ProductoIdLabel";
            this.ProductoIdLabel.Size = new System.Drawing.Size(59, 13);
            this.ProductoIdLabel.TabIndex = 41;
            this.ProductoIdLabel.Text = "ProductoId";
            // 
            // NewButton
            // 
            this.NewButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(57, 267);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 51);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(166, 266);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 52);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(264, 266);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(60, 52);
            this.Deletebutton.TabIndex = 7;
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
            this.searchButton.Location = new System.Drawing.Point(245, 10);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 29);
            this.searchButton.TabIndex = 8;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxesITBS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(57, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO ITBS";
            // 
            // checkBoxesITBS
            // 
            this.checkBoxesITBS.AutoSize = true;
            this.checkBoxesITBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.checkBoxesITBS.Location = new System.Drawing.Point(6, 22);
            this.checkBoxesITBS.Name = "checkBoxesITBS";
            this.checkBoxesITBS.Size = new System.Drawing.Size(39, 21);
            this.checkBoxesITBS.TabIndex = 0;
            this.checkBoxesITBS.Text = "SI";
            this.checkBoxesITBS.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxMedida
            // 
            this.maskedTextBoxMedida.Location = new System.Drawing.Point(119, 107);
            this.maskedTextBoxMedida.Mask = "99999";
            this.maskedTextBoxMedida.Name = "maskedTextBoxMedida";
            this.maskedTextBoxMedida.Size = new System.Drawing.Size(205, 20);
            this.maskedTextBoxMedida.TabIndex = 1;
            this.maskedTextBoxMedida.ValidatingType = typeof(int);
            // 
            // maskedTextBoxCosto
            // 
            this.maskedTextBoxCosto.Location = new System.Drawing.Point(119, 199);
            this.maskedTextBoxCosto.Mask = "99999";
            this.maskedTextBoxCosto.Name = "maskedTextBoxCosto";
            this.maskedTextBoxCosto.Size = new System.Drawing.Size(205, 20);
            this.maskedTextBoxCosto.TabIndex = 3;
            this.maskedTextBoxCosto.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPrecio
            // 
            this.maskedTextBoxPrecio.Location = new System.Drawing.Point(119, 225);
            this.maskedTextBoxPrecio.Mask = "99999";
            this.maskedTextBoxPrecio.Name = "maskedTextBoxPrecio";
            this.maskedTextBoxPrecio.Size = new System.Drawing.Size(205, 20);
            this.maskedTextBoxPrecio.TabIndex = 4;
            this.maskedTextBoxPrecio.ValidatingType = typeof(int);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 358);
            this.Controls.Add(this.maskedTextBoxPrecio);
            this.Controls.Add(this.maskedTextBoxCosto);
            this.Controls.Add(this.maskedTextBoxMedida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.CostoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.ProductoIdTextBox);
            this.Controls.Add(this.MedidasLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.ProductoIdLabel);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.searchButton);
            this.Name = "rProductos";
            this.Text = "rProductos";
            this.Load += new System.EventHandler(this.rProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label CostoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ProductoIdTextBox;
        private System.Windows.Forms.Label MedidasLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label ProductoIdLabel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxesITBS;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMedida;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCosto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecio;
    }
}