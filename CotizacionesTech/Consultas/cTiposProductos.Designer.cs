namespace CotizacionesTech.Consultas
{
    partial class cTiposProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cTiposProductos));
            this.TiposPruductosdataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FiltrarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TiposPruductosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TiposPruductosdataGridView
            // 
            this.TiposPruductosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposPruductosdataGridView.Location = new System.Drawing.Point(12, 141);
            this.TiposPruductosdataGridView.Name = "TiposPruductosdataGridView";
            this.TiposPruductosdataGridView.RowTemplate.Height = 24;
            this.TiposPruductosdataGridView.Size = new System.Drawing.Size(748, 326);
            this.TiposPruductosdataGridView.TabIndex = 0;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Location = new System.Drawing.Point(483, 85);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(134, 28);
            this.FiltrarcomboBox.TabIndex = 1;
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrartextBox.Location = new System.Drawing.Point(89, 86);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(385, 27);
            this.FiltrartextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar:";
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(652, 77);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(92, 36);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FiltrarerrorProvider
            // 
            this.FiltrarerrorProvider.ContainerControl = this;
            // 
            // cTiposProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 479);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.TiposPruductosdataGridView);
            this.Name = "cTiposProductos";
            this.Text = "cTiposProductos";
            this.Load += new System.EventHandler(this.cTiposProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TiposPruductosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiltrarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TiposPruductosdataGridView;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider FiltrarerrorProvider;
    }
}