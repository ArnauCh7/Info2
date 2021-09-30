
namespace Formularios
{
    partial class MostrarPuntos
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
            this.puntosView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.puntosView)).BeginInit();
            this.SuspendLayout();
            // 
            // puntosView
            // 
            this.puntosView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puntosView.Location = new System.Drawing.Point(30, 54);
            this.puntosView.Name = "puntosView";
            this.puntosView.RowHeadersWidth = 51;
            this.puntosView.RowTemplate.Height = 24;
            this.puntosView.Size = new System.Drawing.Size(240, 150);
            this.puntosView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 285);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.puntosView);
            this.Name = "MostrarPuntos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MostrarPuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntosView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView puntosView;
        private System.Windows.Forms.Button button1;
    }
}