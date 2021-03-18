
namespace GoldyGopher
{
    partial class GoldyGopher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_LowerBounds = new System.Windows.Forms.TextBox();
            this.tbx_UpperBounds = new System.Windows.Forms.TextBox();
            this.lstbx_Items = new System.Windows.Forms.ListBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(633, 398);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(155, 40);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lower Bounds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upper Bounds";
            // 
            // tbx_LowerBounds
            // 
            this.tbx_LowerBounds.Location = new System.Drawing.Point(127, 67);
            this.tbx_LowerBounds.MaxLength = 5;
            this.tbx_LowerBounds.Name = "tbx_LowerBounds";
            this.tbx_LowerBounds.Size = new System.Drawing.Size(113, 23);
            this.tbx_LowerBounds.TabIndex = 3;
            this.tbx_LowerBounds.Text = "1";
            this.tbx_LowerBounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_LowerBounds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // tbx_UpperBounds
            // 
            this.tbx_UpperBounds.Location = new System.Drawing.Point(127, 102);
            this.tbx_UpperBounds.MaxLength = 5;
            this.tbx_UpperBounds.Name = "tbx_UpperBounds";
            this.tbx_UpperBounds.Size = new System.Drawing.Size(113, 23);
            this.tbx_UpperBounds.TabIndex = 4;
            this.tbx_UpperBounds.Text = "30";
            this.tbx_UpperBounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_UpperBounds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // lstbx_Items
            // 
            this.lstbx_Items.FormattingEnabled = true;
            this.lstbx_Items.ItemHeight = 15;
            this.lstbx_Items.Location = new System.Drawing.Point(309, 31);
            this.lstbx_Items.Name = "lstbx_Items";
            this.lstbx_Items.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbx_Items.Size = new System.Drawing.Size(257, 409);
            this.lstbx_Items.TabIndex = 5;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(85, 151);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(155, 40);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Lower and Upper Bounds,\r\nthen press start to process.";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(85, 151);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(155, 40);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Results:";
            // 
            // GoldyGopher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lstbx_Items);
            this.Controls.Add(this.tbx_UpperBounds);
            this.Controls.Add(this.tbx_LowerBounds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "GoldyGopher";
            this.Text = "Goldy Gopher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_LowerBounds;
        private System.Windows.Forms.TextBox tbx_UpperBounds;
        private System.Windows.Forms.ListBox lstbx_Items;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label4;
    }
}

