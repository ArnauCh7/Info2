﻿
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
            this.confirm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.safe = new System.Windows.Forms.TextBox();
            this.default2 = new System.Windows.Forms.Button();
            this.default1 = new System.Windows.Forms.Button();
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
            this.label5.Location = new System.Drawing.Point(147, 217);
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
            this.label3.Location = new System.Drawing.Point(147, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Y";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 52);
            this.id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 6;
            // 
            // currentX
            // 
            this.currentX.Location = new System.Drawing.Point(12, 140);
            this.currentX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentX.Name = "currentX";
            this.currentX.Size = new System.Drawing.Size(100, 22);
            this.currentX.TabIndex = 7;
            // 
            // finalX
            // 
            this.finalX.Location = new System.Drawing.Point(12, 249);
            this.finalX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalX.Name = "finalX";
            this.finalX.Size = new System.Drawing.Size(100, 22);
            this.finalX.TabIndex = 8;
            // 
            // currentY
            // 
            this.currentY.Location = new System.Drawing.Point(149, 140);
            this.currentY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentY.Name = "currentY";
            this.currentY.Size = new System.Drawing.Size(100, 22);
            this.currentY.TabIndex = 9;
            // 
            // velocity
            // 
            this.velocity.Location = new System.Drawing.Point(12, 338);
            this.velocity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.velocity.Name = "velocity";
            this.velocity.Size = new System.Drawing.Size(100, 22);
            this.velocity.TabIndex = 10;
            // 
            // finalY
            // 
            this.finalY.Location = new System.Drawing.Point(149, 249);
            this.finalY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalY.Name = "finalY";
            this.finalY.Size = new System.Drawing.Size(100, 22);
            this.finalY.TabIndex = 11;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(149, 386);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 36);
            this.confirm.TabIndex = 12;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Safety Distance";
            // 
            // safe
            // 
            this.safe.Location = new System.Drawing.Point(151, 338);
            this.safe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.safe.Name = "safe";
            this.safe.Size = new System.Drawing.Size(99, 22);
            this.safe.TabIndex = 14;
            // 
            // default2
            // 
            this.default2.Location = new System.Drawing.Point(257, 386);
            this.default2.Name = "default2";
            this.default2.Size = new System.Drawing.Size(75, 36);
            this.default2.TabIndex = 15;
            this.default2.Text = "Default 2";
            this.default2.UseVisualStyleBackColor = true;
            this.default2.Click += new System.EventHandler(this.default2_Click);
            // 
            // default1
            // 
            this.default1.Location = new System.Drawing.Point(37, 386);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(75, 36);
            this.default1.TabIndex = 16;
            this.default1.Text = "Default 1";
            this.default1.UseVisualStyleBackColor = true;
            this.default1.Click += new System.EventHandler(this.default1_Click);
            // 
            // NewAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 436);
            this.Controls.Add(this.default1);
            this.Controls.Add(this.default2);
            this.Controls.Add(this.safe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.confirm);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox safe;
        private System.Windows.Forms.Button default2;
        private System.Windows.Forms.Button default1;
    }
}