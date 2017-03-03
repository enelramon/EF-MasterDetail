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
            this.Idlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(12, 78);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.Size = new System.Drawing.Size(965, 220);
            this.ClientesdataGridView.TabIndex = 0;
            // 
            // Filtrarbutton
            // 
            this.Filtrarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrarbutton.Location = new System.Drawing.Point(905, 49);
            this.Filtrarbutton.Name = "Filtrarbutton";
            this.Filtrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Filtrarbutton.TabIndex = 1;
            this.Filtrarbutton.Text = "Filtrar";
            this.Filtrarbutton.UseVisualStyleBackColor = true;
            this.Filtrarbutton.Click += new System.EventHandler(this.Filtrarbutton_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscartextBox.Location = new System.Drawing.Point(760, 49);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(139, 20);
            this.BuscartextBox.TabIndex = 2;
            this.BuscartextBox.TextChanged += new System.EventHandler(this.BuscartextBox_TextChanged);
            // 
            // Idlabel
            // 
            this.Idlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(737, 54);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(18, 13);
            this.Idlabel.TabIndex = 3;
            this.Idlabel.Text = "ID";
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 342);
            this.Controls.Add(this.Idlabel);
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
        private System.Windows.Forms.Label Idlabel;
    }
}