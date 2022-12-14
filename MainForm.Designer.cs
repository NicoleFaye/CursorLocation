
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PixelXLabel = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AbsoluteXValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.PixelYLabel = new System.Windows.Forms.Label();
            this.yValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.AbsoluteYLabel = new System.Windows.Forms.Label();
            this.AbsoluteYValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 115);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 109);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.PixelXLabel);
            this.flowLayoutPanel2.Controls.Add(this.xValue);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(182, 48);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // PixelXLabel
            // 
            this.PixelXLabel.AutoSize = true;
            this.PixelXLabel.Location = new System.Drawing.Point(3, 0);
            this.PixelXLabel.Name = "PixelXLabel";
            this.PixelXLabel.Size = new System.Drawing.Size(56, 20);
            this.PixelXLabel.TabIndex = 7;
            this.PixelXLabel.Text = "PixelX:";
            // 
            // xValue
            // 
            this.xValue.AutoSize = true;
            this.xValue.Location = new System.Drawing.Point(65, 0);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(0, 20);
            this.xValue.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.AbsoluteXValue);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(182, 49);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "AbsoluteX:";
            // 
            // AbsoluteXValue
            // 
            this.AbsoluteXValue.AutoSize = true;
            this.AbsoluteXValue.Location = new System.Drawing.Point(96, 0);
            this.AbsoluteXValue.Name = "AbsoluteXValue";
            this.AbsoluteXValue.Size = new System.Drawing.Size(0, 20);
            this.AbsoluteXValue.TabIndex = 4;
            this.AbsoluteXValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.PixelYLabel);
            this.flowLayoutPanel4.Controls.Add(this.yValue);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(191, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(182, 48);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // PixelYLabel
            // 
            this.PixelYLabel.AutoSize = true;
            this.PixelYLabel.Location = new System.Drawing.Point(3, 0);
            this.PixelYLabel.Name = "PixelYLabel";
            this.PixelYLabel.Size = new System.Drawing.Size(56, 20);
            this.PixelYLabel.TabIndex = 3;
            this.PixelYLabel.Text = "PixelY:";
            // 
            // yValue
            // 
            this.yValue.AutoSize = true;
            this.yValue.Location = new System.Drawing.Point(65, 0);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(0, 20);
            this.yValue.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.AbsoluteYLabel);
            this.flowLayoutPanel5.Controls.Add(this.AbsoluteYValue);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(191, 57);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(182, 49);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // AbsoluteYLabel
            // 
            this.AbsoluteYLabel.AutoSize = true;
            this.AbsoluteYLabel.Location = new System.Drawing.Point(3, 0);
            this.AbsoluteYLabel.Name = "AbsoluteYLabel";
            this.AbsoluteYLabel.Size = new System.Drawing.Size(87, 20);
            this.AbsoluteYLabel.TabIndex = 4;
            this.AbsoluteYLabel.Text = "AbsoluteY:";
            // 
            // AbsoluteYValue
            // 
            this.AbsoluteYValue.AutoSize = true;
            this.AbsoluteYValue.Location = new System.Drawing.Point(96, 0);
            this.AbsoluteYValue.Name = "AbsoluteYValue";
            this.AbsoluteYValue.Size = new System.Drawing.Size(0, 20);
            this.AbsoluteYValue.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 115);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label xValue;
        private System.Windows.Forms.Label yValue;
        private System.Windows.Forms.Label PixelYLabel;
        private System.Windows.Forms.Label AbsoluteXValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label PixelXLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label AbsoluteYLabel;
        private System.Windows.Forms.Label AbsoluteYValue;
    }
}

