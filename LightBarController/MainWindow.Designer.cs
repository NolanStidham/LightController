namespace LightBarController
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorSelectorButton = new System.Windows.Forms.Button();
            this.sendColorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.colorPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanel.Location = new System.Drawing.Point(3, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(428, 290);
            this.colorPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.sendColorButton);
            this.flowLayoutPanel1.Controls.Add(this.colorSelectorButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 299);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // colorSelectorButton
            // 
            this.colorSelectorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colorSelectorButton.Location = new System.Drawing.Point(269, 3);
            this.colorSelectorButton.Name = "colorSelectorButton";
            this.colorSelectorButton.Size = new System.Drawing.Size(75, 23);
            this.colorSelectorButton.TabIndex = 0;
            this.colorSelectorButton.Text = "Color Menu";
            this.colorSelectorButton.UseVisualStyleBackColor = true;
            this.colorSelectorButton.Click += new System.EventHandler(this.colorSelectorButton_Click);
            // 
            // sendColorButton
            // 
            this.sendColorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendColorButton.Location = new System.Drawing.Point(350, 3);
            this.sendColorButton.Name = "sendColorButton";
            this.sendColorButton.Size = new System.Drawing.Size(75, 23);
            this.sendColorButton.TabIndex = 1;
            this.sendColorButton.Text = "Send Color";
            this.sendColorButton.UseVisualStyleBackColor = true;
            this.sendColorButton.Click += new System.EventHandler(this.sendColorButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 150);
            this.Name = "MainWindow";
            this.Text = "Light Bar Controler v1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button sendColorButton;
        private System.Windows.Forms.Button colorSelectorButton;
    }
}

