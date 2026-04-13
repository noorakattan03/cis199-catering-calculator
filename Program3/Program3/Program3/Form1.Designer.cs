namespace Program3
{
    partial class contractLabel
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
            this.CalcButton = new System.Windows.Forms.Button();
            this.cateringLabel = new System.Windows.Forms.Label();
            this.businessLabel = new System.Windows.Forms.Label();
            this.contractYearsLabel = new System.Windows.Forms.Label();
            this.cateringComboBox = new System.Windows.Forms.ComboBox();
            this.businessComboBox = new System.Windows.Forms.ComboBox();
            this.contractYearsTxt = new System.Windows.Forms.TextBox();
            this.contractPriceLabel = new System.Windows.Forms.Label();
            this.priceOutPut = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.Location = new System.Drawing.Point(113, 247);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(199, 31);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // cateringLabel
            // 
            this.cateringLabel.AutoSize = true;
            this.cateringLabel.Location = new System.Drawing.Point(15, 105);
            this.cateringLabel.Name = "cateringLabel";
            this.cateringLabel.Size = new System.Drawing.Size(66, 20);
            this.cateringLabel.TabIndex = 1;
            this.cateringLabel.Text = "Caterer:";
            // 
            // businessLabel
            // 
            this.businessLabel.AutoSize = true;
            this.businessLabel.Location = new System.Drawing.Point(15, 142);
            this.businessLabel.Name = "businessLabel";
            this.businessLabel.Size = new System.Drawing.Size(78, 20);
            this.businessLabel.TabIndex = 2;
            this.businessLabel.Text = "Business:";
            // 
            // contractYearsLabel
            // 
            this.contractYearsLabel.AutoSize = true;
            this.contractYearsLabel.Location = new System.Drawing.Point(12, 182);
            this.contractYearsLabel.Name = "contractYearsLabel";
            this.contractYearsLabel.Size = new System.Drawing.Size(120, 20);
            this.contractYearsLabel.TabIndex = 3;
            this.contractYearsLabel.Text = "Contract Years:";
            // 
            // cateringComboBox
            // 
            this.cateringComboBox.FormattingEnabled = true;
            this.cateringComboBox.Location = new System.Drawing.Point(218, 97);
            this.cateringComboBox.Name = "cateringComboBox";
            this.cateringComboBox.Size = new System.Drawing.Size(175, 28);
            this.cateringComboBox.TabIndex = 4;
            // 
            // businessComboBox
            // 
            this.businessComboBox.FormattingEnabled = true;
            this.businessComboBox.Location = new System.Drawing.Point(218, 134);
            this.businessComboBox.Name = "businessComboBox";
            this.businessComboBox.Size = new System.Drawing.Size(175, 28);
            this.businessComboBox.TabIndex = 5;
            // 
            // contractYearsTxt
            // 
            this.contractYearsTxt.Location = new System.Drawing.Point(218, 176);
            this.contractYearsTxt.Name = "contractYearsTxt";
            this.contractYearsTxt.Size = new System.Drawing.Size(175, 26);
            this.contractYearsTxt.TabIndex = 6;
            // 
            // contractPriceLabel
            // 
            this.contractPriceLabel.AutoSize = true;
            this.contractPriceLabel.Location = new System.Drawing.Point(19, 322);
            this.contractPriceLabel.Name = "contractPriceLabel";
            this.contractPriceLabel.Size = new System.Drawing.Size(113, 20);
            this.contractPriceLabel.TabIndex = 7;
            this.contractPriceLabel.Text = "Contract Price:";
            // 
            // priceOutPut
            // 
            this.priceOutPut.Location = new System.Drawing.Point(248, 319);
            this.priceOutPut.Name = "priceOutPut";
            this.priceOutPut.Size = new System.Drawing.Size(100, 23);
            this.priceOutPut.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(451, 37);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Catering Contract Calculator";
            // 
            // contractLabel
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 404);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.priceOutPut);
            this.Controls.Add(this.contractPriceLabel);
            this.Controls.Add(this.contractYearsTxt);
            this.Controls.Add(this.businessComboBox);
            this.Controls.Add(this.cateringComboBox);
            this.Controls.Add(this.contractYearsLabel);
            this.Controls.Add(this.businessLabel);
            this.Controls.Add(this.cateringLabel);
            this.Controls.Add(this.CalcButton);
            this.Name = "contractLabel";
            this.Text = "Contract Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label cateringLabel;
        private System.Windows.Forms.Label businessLabel;
        private System.Windows.Forms.Label contractYearsLabel;
        private System.Windows.Forms.ComboBox cateringComboBox;
        private System.Windows.Forms.ComboBox businessComboBox;
        private System.Windows.Forms.TextBox contractYearsTxt;
        private System.Windows.Forms.Label contractPriceLabel;
        private System.Windows.Forms.Label priceOutPut;
        private System.Windows.Forms.Label titleLabel;
    }
}

