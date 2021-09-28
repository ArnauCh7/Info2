
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
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.Button();
            this.positiontracker = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stop = new System.Windows.Forms.Button();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.nuevoPuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Location = new System.Drawing.Point(371, 28);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(533, 492);
            this.panel.TabIndex = 0;
            this.panel.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "400";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "400";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "MOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // auto
            // 
            this.auto.Location = new System.Drawing.Point(61, 222);
            this.auto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(80, 30);
            this.auto.TabIndex = 5;
            this.auto.Text = "AUTO";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.Click += new System.EventHandler(this.button2_Click);
            // 
            // positiontracker
            // 
            this.positiontracker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positiontracker.Location = new System.Drawing.Point(477, 1);
            this.positiontracker.Name = "positiontracker";
            this.positiontracker.Size = new System.Drawing.Size(291, 24);
            this.positiontracker.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPointToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newPointToolStripMenuItem
            // 
            this.newPointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPuntoToolStripMenuItem,
            this.listarPuntosToolStripMenuItem});
            this.newPointToolStripMenuItem.Name = "newPointToolStripMenuItem";
            this.newPointToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.newPointToolStripMenuItem.Text = "Opciones";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(61, 278);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(80, 30);
            this.stop.TabIndex = 9;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // nuevoPuntoToolStripMenuItem
            // 
            this.nuevoPuntoToolStripMenuItem.Name = "nuevoPuntoToolStripMenuItem";
            this.nuevoPuntoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoPuntoToolStripMenuItem.Text = "Nuevo Punto";
            this.nuevoPuntoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPuntoToolStripMenuItem_Click);
            // 
            // listarPuntosToolStripMenuItem
            // 
            this.listarPuntosToolStripMenuItem.Name = "listarPuntosToolStripMenuItem";
            this.listarPuntosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listarPuntosToolStripMenuItem.Text = "Listar Puntos";
            this.listarPuntosToolStripMenuItem.Click += new System.EventHandler(this.listarPuntosToolStripMenuItem_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(61, 333);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(80, 30);
            this.reset.TabIndex = 10;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 545);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.positiontracker);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button auto;
        private System.Windows.Forms.Label positiontracker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPointToolStripMenuItem;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.ToolStripMenuItem nuevoPuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPuntosToolStripMenuItem;
        private System.Windows.Forms.Button reset;
    }
}

