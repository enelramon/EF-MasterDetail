namespace CotizacionesTech.Consultas
{
    partial class cClientes
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
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.Filtrarbutton = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(12, 94);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.Size = new System.Drawing.Size(501, 220);
            this.ClientesdataGridView.TabIndex = 0;
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Location = new System.Drawing.Point(438, 65);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Filtrarbutton.TabIndex = 1;
            this.Filtrarbutton.Text = "Filtrar";
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(293, 65);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(139, 20);
            this.BuscartextBox.TabIndex = 2;
            this.BuscartextBox.TextChanged += new System.EventHandler(this.BuscartextBox_TextChanged);
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 358);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Filtrarbutton);
            this.Controls.Add(this.ClientesdataGridView);
            this.Name = "cClientes";
            this.Text = "cClientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.Button Filtrarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
    }
}