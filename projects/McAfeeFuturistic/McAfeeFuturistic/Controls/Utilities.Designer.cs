
namespace McAfeeFuturistic.Controls
{
    partial class Utilities
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSlider
            // 
            this.PanelSlider.Controls.Add(this.label4);
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(52)))), ((int)(((byte)(219)))));
            this.PanelSlider.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(57)))));
            this.PanelSlider.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.PanelSlider.Location = new System.Drawing.Point(0, 0);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(1000, 517);
            this.PanelSlider.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(411, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 65);
            this.label4.TabIndex = 4;
            this.label4.Text = "Utilities";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelSlider);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Utilities";
            this.Size = new System.Drawing.Size(1000, 517);
            this.PanelSlider.ResumeLayout(false);
            this.PanelSlider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel PanelSlider;
        private System.Windows.Forms.Label label4;
    }
}
