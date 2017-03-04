namespace CotizacionesTech.Registros
{
    partial class rUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.ConfirmartextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ClaveerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Deletebutton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Cliente";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(12, 25);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(51, 20);
            this.IdtextBox.TabIndex = 2;
            // 
            // ConfirmartextBox
            // 
            this.ConfirmartextBox.Location = new System.Drawing.Point(12, 142);
            this.ConfirmartextBox.Name = "ConfirmartextBox";
            this.ConfirmartextBox.PasswordChar = '*';
            this.ConfirmartextBox.Size = new System.Drawing.Size(158, 20);
            this.ConfirmartextBox.TabIndex = 3;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(12, 103);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(158, 20);
            this.ClavetextBox.TabIndex = 4;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(12, 64);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(158, 20);
            this.NombretextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clave ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar Clave";
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // ClaveerrorProvider
            // 
            this.ClaveerrorProvider.ContainerControl = this;
            // 
            // ConfirmarerrorProvider
            // 
            this.ConfirmarerrorProvider.ContainerControl = this;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(231, 187);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(60, 53);
            this.Deletebutton.TabIndex = 12;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(119, 188);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 52);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(11, 189);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 51);
            this.NewButton.TabIndex = 20;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(85, 16);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 29);
            this.searchButton.TabIndex = 21;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 264);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.ConfirmartextBox);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label1);
            this.Name = "rUsuarios";
            this.Text = "rUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.TextBox ConfirmartextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider ClaveerrorProvider;
        private System.Windows.Forms.ErrorProvider ConfirmarerrorProvider;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button searchButton;
    }
}