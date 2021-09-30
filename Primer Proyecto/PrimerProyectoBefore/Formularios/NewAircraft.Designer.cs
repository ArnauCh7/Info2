
namespace Formularios
{
    partial class NewAircraft
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.currentX = new System.Windows.Forms.TextBox();
            this.finalX = new System.Windows.Forms.TextBox();
            this.currentY = new System.Windows.Forms.TextBox();
            this.velocity = new System.Windows.Forms.TextBox();
            this.finalY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aircraft ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Velicity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Final Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Y";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 52);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 6;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // currentX
            // 
            this.currentX.Location = new System.Drawing.Point(12, 140);
            this.currentX.Name = "currentX";
            this.currentX.Size = new System.Drawing.Size(100, 22);
            this.currentX.TabIndex = 7;
            this.currentX.TextChanged += new System.EventHandler(this.currentX_TextChanged);
            // 
            // finalX
            // 
            this.finalX.Location = new System.Drawing.Point(12, 248);
            this.finalX.Name = "finalX";
            this.finalX.Size = new System.Drawing.Size(100, 22);
            this.finalX.TabIndex = 8;
            this.finalX.TextChanged += new System.EventHandler(this.finalX_TextChanged);
            // 
            // currentY
            // 
            this.currentY.Location = new System.Drawing.Point(149, 140);
            this.currentY.Name = "currentY";
            this.currentY.Size = new System.Drawing.Size(100, 22);
            this.currentY.TabIndex = 9;
            this.currentY.TextChanged += new System.EventHandler(this.currentY_TextChanged);
            // 
            // velocity
            // 
            this.velocity.Location = new System.Drawing.Point(12, 338);
            this.velocity.Name = "velocity";
            this.velocity.Size = new System.Drawing.Size(100, 22);
            this.velocity.TabIndex = 10;
            this.velocity.TextChanged += new System.EventHandler(this.velocity_TextChanged);
            // 
            // finalY
            // 
            this.finalY.Location = new System.Drawing.Point(149, 248);
            this.finalY.Name = "finalY";
            this.finalY.Size = new System.Drawing.Size(100, 22);
            this.finalY.TabIndex = 11;
            this.finalY.TextChanged += new System.EventHandler(this.finalY_TextChanged);
            // 
            // NewAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 421);
            this.Controls.Add(this.finalY);
            this.Controls.Add(this.velocity);
            this.Controls.Add(this.currentY);
            this.Controls.Add(this.finalX);
            this.Controls.Add(this.currentX);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "NewAircraft";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox currentX;
        private System.Windows.Forms.TextBox finalX;
        private System.Windows.Forms.TextBox currentY;
        private System.Windows.Forms.TextBox velocity;
        private System.Windows.Forms.TextBox finalY;
    }
}