namespace ListDemo
{
    partial class CalculateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateForm));
            this.btnSeven = new System.Windows.Forms.Button();
            this.NumberButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquel = new System.Windows.Forms.Button();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.NumberButtonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeven
            // 
            this.btnSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeven.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeven.Location = new System.Drawing.Point(8, 41);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(43, 37);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // NumberButtonTableLayout
            // 
            this.NumberButtonTableLayout.ColumnCount = 4;
            this.NumberButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.90184F));
            this.NumberButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.NumberButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.5F));
            this.NumberButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.NumberButtonTableLayout.Controls.Add(this.lblResult, 0, 0);
            this.NumberButtonTableLayout.Controls.Add(this.btnThree, 2, 3);
            this.NumberButtonTableLayout.Controls.Add(this.btnTwo, 1, 3);
            this.NumberButtonTableLayout.Controls.Add(this.btnOne, 0, 3);
            this.NumberButtonTableLayout.Controls.Add(this.btnSix, 2, 2);
            this.NumberButtonTableLayout.Controls.Add(this.btnFive, 1, 2);
            this.NumberButtonTableLayout.Controls.Add(this.btnFour, 0, 2);
            this.NumberButtonTableLayout.Controls.Add(this.btnNine, 2, 1);
            this.NumberButtonTableLayout.Controls.Add(this.btnEight, 1, 1);
            this.NumberButtonTableLayout.Controls.Add(this.btnSeven, 0, 1);
            this.NumberButtonTableLayout.Controls.Add(this.button1, 2, 4);
            this.NumberButtonTableLayout.Controls.Add(this.button2, 3, 1);
            this.NumberButtonTableLayout.Controls.Add(this.button3, 3, 2);
            this.NumberButtonTableLayout.Controls.Add(this.btnZero, 0, 4);
            this.NumberButtonTableLayout.Controls.Add(this.btnEquel, 3, 3);
            this.NumberButtonTableLayout.Location = new System.Drawing.Point(1, 304);
            this.NumberButtonTableLayout.Name = "NumberButtonTableLayout";
            this.NumberButtonTableLayout.RowCount = 5;
            this.NumberButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.NumberButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NumberButtonTableLayout.Size = new System.Drawing.Size(265, 238);
            this.NumberButtonTableLayout.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberButtonTableLayout.SetColumnSpan(this.lblResult, 4);
            this.lblResult.Location = new System.Drawing.Point(3, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(259, 34);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThree
            // 
            this.btnThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThree.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.Location = new System.Drawing.Point(127, 143);
            this.btnThree.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(49, 37);
            this.btnThree.TabIndex = 8;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTwo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTwo.Location = new System.Drawing.Point(67, 143);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(44, 37);
            this.btnTwo.TabIndex = 7;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnOne
            // 
            this.btnOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOne.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.Location = new System.Drawing.Point(8, 143);
            this.btnOne.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(43, 37);
            this.btnOne.TabIndex = 6;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnSix
            // 
            this.btnSix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSix.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.Location = new System.Drawing.Point(127, 92);
            this.btnSix.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(49, 37);
            this.btnSix.TabIndex = 5;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnFive
            // 
            this.btnFive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFive.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.Location = new System.Drawing.Point(67, 92);
            this.btnFive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(44, 37);
            this.btnFive.TabIndex = 4;
            this.btnFive.Tag = "5";
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnFour
            // 
            this.btnFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFour.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.Location = new System.Drawing.Point(8, 92);
            this.btnFour.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(43, 37);
            this.btnFour.TabIndex = 3;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnNine
            // 
            this.btnNine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNine.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNine.Location = new System.Drawing.Point(127, 41);
            this.btnNine.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(49, 37);
            this.btnNine.TabIndex = 2;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnEight
            // 
            this.btnEight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEight.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEight.Location = new System.Drawing.Point(67, 41);
            this.btnEight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(44, 37);
            this.btnEight.TabIndex = 1;
            this.btnEight.Tag = "8";
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(127, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 37);
            this.button1.TabIndex = 11;
            this.button1.Tag = "decimal";
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(192, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 37);
            this.button2.TabIndex = 12;
            this.button2.Tag = "back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(192, 92);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 37);
            this.button3.TabIndex = 13;
            this.button3.Tag = "clear";
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnZero
            // 
            this.btnZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZero.BackColor = System.Drawing.Color.SteelBlue;
            this.NumberButtonTableLayout.SetColumnSpan(this.btnZero, 2);
            this.btnZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZero.Location = new System.Drawing.Point(8, 194);
            this.btnZero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(103, 37);
            this.btnZero.TabIndex = 10;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // btnEquel
            // 
            this.btnEquel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEquel.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEquel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEquel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEquel.Location = new System.Drawing.Point(192, 143);
            this.btnEquel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnEquel.Name = "btnEquel";
            this.NumberButtonTableLayout.SetRowSpan(this.btnEquel, 2);
            this.btnEquel.Size = new System.Drawing.Size(65, 88);
            this.btnEquel.TabIndex = 10;
            this.btnEquel.Tag = "done";
            this.btnEquel.Text = "Done";
            this.btnEquel.UseVisualStyleBackColor = false;
            this.btnEquel.Click += new System.EventHandler(this.CalculatorNumber_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeLabel.Location = new System.Drawing.Point(148, 123);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(118, 35);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Tag = "height";
            this.AgeLabel.Text = "0";
            this.AgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgeLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightLabel.Location = new System.Drawing.Point(148, 66);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(118, 35);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Tag = "height";
            this.WeightLabel.Text = "0";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WeightLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightLabel.Location = new System.Drawing.Point(148, 9);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(118, 35);
            this.HeightLabel.TabIndex = 6;
            this.HeightLabel.Tag = "height";
            this.HeightLabel.Text = "0";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HeightLabel.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 551);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.NumberButtonTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "CalculateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            this.Click += new System.EventHandler(this.CalculatorForm_Click);
            this.NumberButtonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.TableLayoutPanel NumberButtonTableLayout;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnEquel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
    }
}

