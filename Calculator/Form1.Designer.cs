namespace Calculator
{
    partial class Form1
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
            this.negativeButton = new System.Windows.Forms.Button();
            this.operationsTextBox = new System.Windows.Forms.TextBox();
            this._0Button = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.mcButton = new System.Windows.Forms.Button();
            this.mrButton = new System.Windows.Forms.Button();
            this.mAddButton = new System.Windows.Forms.Button();
            this.mRemoveButton = new System.Windows.Forms.Button();
            this._1Button = new System.Windows.Forms.Button();
            this._2Button = new System.Windows.Forms.Button();
            this._3Button = new System.Windows.Forms.Button();
            this._6Button = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this._5Button = new System.Windows.Forms.Button();
            this._4Button = new System.Windows.Forms.Button();
            this._9Button = new System.Windows.Forms.Button();
            this._7Button = new System.Windows.Forms.Button();
            this._8Button = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.hypocriticallyButton = new System.Windows.Forms.Button();
            this.degreeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // negativeButton
            // 
            this.negativeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.negativeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.negativeButton.Location = new System.Drawing.Point(12, 429);
            this.negativeButton.Name = "negativeButton";
            this.negativeButton.Size = new System.Drawing.Size(75, 41);
            this.negativeButton.TabIndex = 0;
            this.negativeButton.Text = "+/-";
            this.negativeButton.UseVisualStyleBackColor = true;
            this.negativeButton.Click += new System.EventHandler(this.NegativeButton_Click);
            // 
            // operationsTextBox
            // 
            this.operationsTextBox.Location = new System.Drawing.Point(12, 12);
            this.operationsTextBox.Name = "operationsTextBox";
            this.operationsTextBox.ReadOnly = true;
            this.operationsTextBox.Size = new System.Drawing.Size(318, 20);
            this.operationsTextBox.TabIndex = 1;
            this.operationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _0Button
            // 
            this._0Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._0Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._0Button.Location = new System.Drawing.Point(93, 429);
            this._0Button.Name = "_0Button";
            this._0Button.Size = new System.Drawing.Size(75, 41);
            this._0Button.TabIndex = 2;
            this._0Button.Text = "0";
            this._0Button.UseVisualStyleBackColor = true;
            this._0Button.Click += new System.EventHandler(this._0Button_Click);
            // 
            // pointButton
            // 
            this.pointButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.pointButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointButton.Location = new System.Drawing.Point(174, 429);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(75, 41);
            this.pointButton.TabIndex = 3;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.equalButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.equalButton.Location = new System.Drawing.Point(255, 429);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 41);
            this.equalButton.TabIndex = 4;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // mcButton
            // 
            this.mcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcButton.Location = new System.Drawing.Point(12, 165);
            this.mcButton.Name = "mcButton";
            this.mcButton.Size = new System.Drawing.Size(75, 23);
            this.mcButton.TabIndex = 31;
            this.mcButton.Text = "MC";
            this.mcButton.UseVisualStyleBackColor = true;
            this.mcButton.Click += new System.EventHandler(this.MCButton_Click);
            // 
            // mrButton
            // 
            this.mrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrButton.Location = new System.Drawing.Point(255, 165);
            this.mrButton.Name = "mrButton";
            this.mrButton.Size = new System.Drawing.Size(75, 23);
            this.mrButton.TabIndex = 32;
            this.mrButton.Text = "MR";
            this.mrButton.UseVisualStyleBackColor = true;
            this.mrButton.Click += new System.EventHandler(this.MRButton_Click);
            // 
            // mAddButton
            // 
            this.mAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAddButton.Location = new System.Drawing.Point(93, 165);
            this.mAddButton.Name = "mAddButton";
            this.mAddButton.Size = new System.Drawing.Size(75, 23);
            this.mAddButton.TabIndex = 33;
            this.mAddButton.Text = "M+";
            this.mAddButton.UseVisualStyleBackColor = true;
            this.mAddButton.Click += new System.EventHandler(this.MAddButton_Click);
            // 
            // mRemoveButton
            // 
            this.mRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRemoveButton.Location = new System.Drawing.Point(174, 165);
            this.mRemoveButton.Name = "mRemoveButton";
            this.mRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.mRemoveButton.TabIndex = 35;
            this.mRemoveButton.Text = "M-";
            this.mRemoveButton.UseVisualStyleBackColor = true;
            this.mRemoveButton.Click += new System.EventHandler(this.MRemoveButton_Click);
            // 
            // _1Button
            // 
            this._1Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._1Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._1Button.Location = new System.Drawing.Point(12, 382);
            this._1Button.Name = "_1Button";
            this._1Button.Size = new System.Drawing.Size(75, 41);
            this._1Button.TabIndex = 36;
            this._1Button.Text = "1";
            this._1Button.UseVisualStyleBackColor = false;
            this._1Button.Click += new System.EventHandler(this._1Button_Click);
            // 
            // _2Button
            // 
            this._2Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._2Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._2Button.Location = new System.Drawing.Point(93, 382);
            this._2Button.Name = "_2Button";
            this._2Button.Size = new System.Drawing.Size(75, 41);
            this._2Button.TabIndex = 37;
            this._2Button.Text = "2";
            this._2Button.UseVisualStyleBackColor = false;
            this._2Button.Click += new System.EventHandler(this._2Button_Click);
            // 
            // _3Button
            // 
            this._3Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._3Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._3Button.Location = new System.Drawing.Point(174, 382);
            this._3Button.Name = "_3Button";
            this._3Button.Size = new System.Drawing.Size(75, 41);
            this._3Button.TabIndex = 38;
            this._3Button.Text = "3";
            this._3Button.UseVisualStyleBackColor = false;
            this._3Button.Click += new System.EventHandler(this._3Button_Click);
            // 
            // _6Button
            // 
            this._6Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._6Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._6Button.Location = new System.Drawing.Point(174, 335);
            this._6Button.Name = "_6Button";
            this._6Button.Size = new System.Drawing.Size(75, 41);
            this._6Button.TabIndex = 39;
            this._6Button.Text = "6";
            this._6Button.UseVisualStyleBackColor = false;
            this._6Button.Click += new System.EventHandler(this._6Button_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.plusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plusButton.Location = new System.Drawing.Point(255, 382);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 41);
            this.plusButton.TabIndex = 39;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.minusButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minusButton.Location = new System.Drawing.Point(255, 335);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 41);
            this.minusButton.TabIndex = 40;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // _5Button
            // 
            this._5Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._5Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._5Button.Location = new System.Drawing.Point(93, 335);
            this._5Button.Name = "_5Button";
            this._5Button.Size = new System.Drawing.Size(75, 41);
            this._5Button.TabIndex = 41;
            this._5Button.Text = "5";
            this._5Button.UseVisualStyleBackColor = false;
            this._5Button.Click += new System.EventHandler(this._5Button_Click);
            // 
            // _4Button
            // 
            this._4Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._4Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._4Button.Location = new System.Drawing.Point(12, 335);
            this._4Button.Name = "_4Button";
            this._4Button.Size = new System.Drawing.Size(75, 41);
            this._4Button.TabIndex = 42;
            this._4Button.Text = "4";
            this._4Button.UseVisualStyleBackColor = false;
            this._4Button.Click += new System.EventHandler(this._4Button_Click);
            // 
            // _9Button
            // 
            this._9Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._9Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._9Button.Location = new System.Drawing.Point(174, 288);
            this._9Button.Name = "_9Button";
            this._9Button.Size = new System.Drawing.Size(75, 41);
            this._9Button.TabIndex = 43;
            this._9Button.Text = "9";
            this._9Button.UseVisualStyleBackColor = false;
            this._9Button.Click += new System.EventHandler(this._9Button_Click);
            // 
            // _7Button
            // 
            this._7Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._7Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._7Button.Location = new System.Drawing.Point(12, 288);
            this._7Button.Name = "_7Button";
            this._7Button.Size = new System.Drawing.Size(75, 41);
            this._7Button.TabIndex = 43;
            this._7Button.Text = "7";
            this._7Button.UseVisualStyleBackColor = false;
            this._7Button.Click += new System.EventHandler(this._7Button_Click);
            // 
            // _8Button
            // 
            this._8Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._8Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this._8Button.Location = new System.Drawing.Point(93, 288);
            this._8Button.Name = "_8Button";
            this._8Button.Size = new System.Drawing.Size(75, 41);
            this._8Button.TabIndex = 44;
            this._8Button.Text = "8";
            this._8Button.UseVisualStyleBackColor = false;
            this._8Button.Click += new System.EventHandler(this._8Button_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multiplyButton.Location = new System.Drawing.Point(255, 288);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 41);
            this.multiplyButton.TabIndex = 45;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // hypocriticallyButton
            // 
            this.hypocriticallyButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypocriticallyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hypocriticallyButton.Location = new System.Drawing.Point(12, 241);
            this.hypocriticallyButton.Name = "hypocriticallyButton";
            this.hypocriticallyButton.Size = new System.Drawing.Size(75, 41);
            this.hypocriticallyButton.TabIndex = 46;
            this.hypocriticallyButton.Text = "1/x";
            this.hypocriticallyButton.UseVisualStyleBackColor = true;
            this.hypocriticallyButton.Click += new System.EventHandler(this.HypocriticallyButton_Click);
            // 
            // degreeButton
            // 
            this.degreeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.degreeButton.Location = new System.Drawing.Point(93, 241);
            this.degreeButton.Name = "degreeButton";
            this.degreeButton.Size = new System.Drawing.Size(75, 41);
            this.degreeButton.TabIndex = 47;
            this.degreeButton.Text = "x^y";
            this.degreeButton.UseVisualStyleBackColor = true;
            this.degreeButton.Click += new System.EventHandler(this.DegreeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.Location = new System.Drawing.Point(110, 194);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(88, 41);
            this.clearButton.TabIndex = 48;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sqrtButton.Location = new System.Drawing.Point(174, 241);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(75, 41);
            this.sqrtButton.TabIndex = 48;
            this.sqrtButton.Text = "SQRT";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.divisionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divisionButton.Location = new System.Drawing.Point(255, 241);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 41);
            this.divisionButton.TabIndex = 49;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearAllButton.Location = new System.Drawing.Point(12, 194);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(92, 41);
            this.clearAllButton.TabIndex = 50;
            this.clearAllButton.Text = "CE\r\n";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backspaceButton.Location = new System.Drawing.Point(204, 194);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(126, 41);
            this.backspaceButton.TabIndex = 51;
            this.backspaceButton.Text = "Backspace";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(12, 38);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(318, 121);
            this.resultTextBox.TabIndex = 52;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 480);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.degreeButton);
            this.Controls.Add(this.hypocriticallyButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this._8Button);
            this.Controls.Add(this._7Button);
            this.Controls.Add(this._9Button);
            this.Controls.Add(this._4Button);
            this.Controls.Add(this._5Button);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this._6Button);
            this.Controls.Add(this._3Button);
            this.Controls.Add(this._2Button);
            this.Controls.Add(this._1Button);
            this.Controls.Add(this.mRemoveButton);
            this.Controls.Add(this.mAddButton);
            this.Controls.Add(this.mrButton);
            this.Controls.Add(this.mcButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this._0Button);
            this.Controls.Add(this.operationsTextBox);
            this.Controls.Add(this.negativeButton);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button negativeButton;
        private System.Windows.Forms.TextBox operationsTextBox;
        private System.Windows.Forms.Button _0Button;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button mcButton;
        private System.Windows.Forms.Button mrButton;
        private System.Windows.Forms.Button mAddButton;
        private System.Windows.Forms.Button mRemoveButton;
        private System.Windows.Forms.Button _1Button;
        private System.Windows.Forms.Button _2Button;
        private System.Windows.Forms.Button _3Button;
        private System.Windows.Forms.Button _6Button;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button _5Button;
        private System.Windows.Forms.Button _4Button;
        private System.Windows.Forms.Button _9Button;
        private System.Windows.Forms.Button _7Button;
        private System.Windows.Forms.Button _8Button;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button hypocriticallyButton;
        private System.Windows.Forms.Button degreeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

