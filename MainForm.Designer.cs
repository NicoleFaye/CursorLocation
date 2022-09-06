
namespace CursorLocation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.xValue = new System.Windows.Forms.Label();
            this.yValue = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.xLabel);
            this.flowLayoutPanel1.Controls.Add(this.xValue);
            this.flowLayoutPanel1.Controls.Add(this.yLabel);
            this.flowLayoutPanel1.Controls.Add(this.yValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // xValue
            // 
            this.xValue.AutoSize = true;
            this.xValue.Location = new System.Drawing.Point(33, 0);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(51, 20);
            this.xValue.TabIndex = 0;
            this.xValue.Text = "label1";
            // 
            // yValue
            // 
            this.yValue.AutoSize = true;
            this.yValue.Location = new System.Drawing.Point(120, 0);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(51, 20);
            this.yValue.TabIndex = 1;
            this.yValue.Text = "label1";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(3, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 20);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "X:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(90, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 20);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Y:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 31);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label xValue;
        private System.Windows.Forms.Label yValue;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
    }
}

