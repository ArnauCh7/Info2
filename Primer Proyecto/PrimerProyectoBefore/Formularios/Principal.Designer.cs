
namespace Formularios
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reset = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.mover = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAircraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aircraftListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(56, 273);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(97, 32);
            this.reset.TabIndex = 0;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(56, 221);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(97, 32);
            this.stop.TabIndex = 1;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // mover
            // 
            this.mover.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mover.Location = new System.Drawing.Point(56, 117);
            this.mover.Name = "mover";
            this.mover.Size = new System.Drawing.Size(97, 32);
            this.mover.TabIndex = 2;
            this.mover.Text = "MOVE";
            this.mover.UseVisualStyleBackColor = true;
            this.mover.Click += new System.EventHandler(this.mover_Click);
            // 
            // auto
            // 
            this.auto.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto.Location = new System.Drawing.Point(56, 167);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(97, 32);
            this.auto.TabIndex = 3;
            this.auto.Text = "AUTO";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(370, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(801, 551);
            this.panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1141, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "800";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "550";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAircraftToolStripMenuItem,
            this.aircraftListToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // newAircraftToolStripMenuItem
            // 
            this.newAircraftToolStripMenuItem.Name = "newAircraftToolStripMenuItem";
            this.newAircraftToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newAircraftToolStripMenuItem.Text = "New Aircraft";
            this.newAircraftToolStripMenuItem.Click += new System.EventHandler(this.newAircraftToolStripMenuItem_Click);
            // 
            // aircraftListToolStripMenuItem
            // 
            this.aircraftListToolStripMenuItem.Name = "aircraftListToolStripMenuItem";
            this.aircraftListToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.aircraftListToolStripMenuItem.Text = "Aircraft List";
            this.aircraftListToolStripMenuItem.Click += new System.EventHandler(this.aircraftListToolStripMenuItem_Click);
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.mover);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button mover;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAircraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aircraftListToolStripMenuItem;
        private System.Windows.Forms.Timer reloj;
    }
}

