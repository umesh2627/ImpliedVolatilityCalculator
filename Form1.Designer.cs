
namespace ImpliedVolatilityCalculator
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
            this.lblUnderlyingPrice = new System.Windows.Forms.Label();
            this.txtUnderlyingPrice = new System.Windows.Forms.TextBox();
            this.lblStrikePrice = new System.Windows.Forms.Label();
            this.lblTimeOfMaturity = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblDividend = new System.Windows.Forms.Label();
            this.txtStrikePrice = new System.Windows.Forms.TextBox();
            this.txtTimeOfMaturity = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDividend = new System.Windows.Forms.TextBox();
            this.txtMarketPRice = new System.Windows.Forms.TextBox();
            this.lblMarketPrice = new System.Windows.Forms.Label();
            this.btnCalCulate = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.lblIvResult = new System.Windows.Forms.Label();
            this.cmbOptionType = new System.Windows.Forms.ComboBox();
            this.lblOptionType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUnderlyingPrice
            // 
            this.lblUnderlyingPrice.AutoSize = true;
            this.lblUnderlyingPrice.Location = new System.Drawing.Point(30, 103);
            this.lblUnderlyingPrice.Name = "lblUnderlyingPrice";
            this.lblUnderlyingPrice.Size = new System.Drawing.Size(84, 13);
            this.lblUnderlyingPrice.TabIndex = 0;
            this.lblUnderlyingPrice.Text = "Underlying Price";
            // 
            // txtUnderlyingPrice
            // 
            this.txtUnderlyingPrice.Location = new System.Drawing.Point(133, 100);
            this.txtUnderlyingPrice.Name = "txtUnderlyingPrice";
            this.txtUnderlyingPrice.Size = new System.Drawing.Size(75, 20);
            this.txtUnderlyingPrice.TabIndex = 1;
            this.txtUnderlyingPrice.Text = "450";
            // 
            // lblStrikePrice
            // 
            this.lblStrikePrice.AutoSize = true;
            this.lblStrikePrice.Location = new System.Drawing.Point(32, 147);
            this.lblStrikePrice.Name = "lblStrikePrice";
            this.lblStrikePrice.Size = new System.Drawing.Size(58, 13);
            this.lblStrikePrice.TabIndex = 2;
            this.lblStrikePrice.Text = "StrikePrice";
            // 
            // lblTimeOfMaturity
            // 
            this.lblTimeOfMaturity.AutoSize = true;
            this.lblTimeOfMaturity.Location = new System.Drawing.Point(30, 190);
            this.lblTimeOfMaturity.Name = "lblTimeOfMaturity";
            this.lblTimeOfMaturity.Size = new System.Drawing.Size(84, 13);
            this.lblTimeOfMaturity.TabIndex = 3;
            this.lblTimeOfMaturity.Text = "Time Of Maturity";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(32, 238);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(82, 13);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "Interest Rate(%)";
            // 
            // lblDividend
            // 
            this.lblDividend.AutoSize = true;
            this.lblDividend.Location = new System.Drawing.Point(33, 280);
            this.lblDividend.Name = "lblDividend";
            this.lblDividend.Size = new System.Drawing.Size(57, 13);
            this.lblDividend.TabIndex = 5;
            this.lblDividend.Text = "Divided(%)";
            // 
            // txtStrikePrice
            // 
            this.txtStrikePrice.Location = new System.Drawing.Point(133, 144);
            this.txtStrikePrice.Name = "txtStrikePrice";
            this.txtStrikePrice.Size = new System.Drawing.Size(75, 20);
            this.txtStrikePrice.TabIndex = 6;
            this.txtStrikePrice.Text = "410";
            // 
            // txtTimeOfMaturity
            // 
            this.txtTimeOfMaturity.Location = new System.Drawing.Point(133, 187);
            this.txtTimeOfMaturity.Name = "txtTimeOfMaturity";
            this.txtTimeOfMaturity.Size = new System.Drawing.Size(75, 20);
            this.txtTimeOfMaturity.TabIndex = 7;
            this.txtTimeOfMaturity.Text = "91";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(133, 231);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(75, 20);
            this.txtInterestRate.TabIndex = 8;
            this.txtInterestRate.Text = "2";
            // 
            // txtDividend
            // 
            this.txtDividend.Location = new System.Drawing.Point(133, 277);
            this.txtDividend.Name = "txtDividend";
            this.txtDividend.Size = new System.Drawing.Size(75, 20);
            this.txtDividend.TabIndex = 9;
            this.txtDividend.Text = "0";
            // 
            // txtMarketPRice
            // 
            this.txtMarketPRice.Location = new System.Drawing.Point(133, 318);
            this.txtMarketPRice.Name = "txtMarketPRice";
            this.txtMarketPRice.Size = new System.Drawing.Size(75, 20);
            this.txtMarketPRice.TabIndex = 10;
            this.txtMarketPRice.Text = "45";
            // 
            // lblMarketPrice
            // 
            this.lblMarketPrice.AutoSize = true;
            this.lblMarketPrice.Location = new System.Drawing.Point(32, 321);
            this.lblMarketPrice.Name = "lblMarketPrice";
            this.lblMarketPrice.Size = new System.Drawing.Size(67, 13);
            this.lblMarketPrice.TabIndex = 11;
            this.lblMarketPrice.Text = "Market Price";
            // 
            // btnCalCulate
            // 
            this.btnCalCulate.Location = new System.Drawing.Point(93, 359);
            this.btnCalCulate.Name = "btnCalCulate";
            this.btnCalCulate.Size = new System.Drawing.Size(75, 23);
            this.btnCalCulate.TabIndex = 12;
            this.btnCalCulate.Text = "Calculate";
            this.btnCalCulate.UseVisualStyleBackColor = true;
            this.btnCalCulate.Click += new System.EventHandler(this.btnCalCulate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHeader.Location = new System.Drawing.Point(16, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(226, 20);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "Implied Volatility Calculator";
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIV.Location = new System.Drawing.Point(17, 402);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(151, 17);
            this.lblIV.TabIndex = 14;
            this.lblIV.Text = "Implied Volatility(%)";
            // 
            // lblIvResult
            // 
            this.lblIvResult.AutoSize = true;
            this.lblIvResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblIvResult.Location = new System.Drawing.Point(195, 406);
            this.lblIvResult.Name = "lblIvResult";
            this.lblIvResult.Size = new System.Drawing.Size(37, 13);
            this.lblIvResult.TabIndex = 15;
            this.lblIvResult.Text = "IvCalc";
            // 
            // cmbOptionType
            // 
            this.cmbOptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptionType.FormattingEnabled = true;
            this.cmbOptionType.Location = new System.Drawing.Point(133, 58);
            this.cmbOptionType.Name = "cmbOptionType";
            this.cmbOptionType.Size = new System.Drawing.Size(75, 21);
            this.cmbOptionType.TabIndex = 16;
            this.cmbOptionType.SelectedIndexChanged += new System.EventHandler(this.cmbOptionType_SelectedIndexChanged);
            // 
            // lblOptionType
            // 
            this.lblOptionType.AutoSize = true;
            this.lblOptionType.Location = new System.Drawing.Point(32, 61);
            this.lblOptionType.Name = "lblOptionType";
            this.lblOptionType.Size = new System.Drawing.Size(65, 13);
            this.lblOptionType.TabIndex = 17;
            this.lblOptionType.Text = "Option Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 437);
            this.Controls.Add(this.lblOptionType);
            this.Controls.Add(this.cmbOptionType);
            this.Controls.Add(this.lblIvResult);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnCalCulate);
            this.Controls.Add(this.lblMarketPrice);
            this.Controls.Add(this.txtMarketPRice);
            this.Controls.Add(this.txtDividend);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtTimeOfMaturity);
            this.Controls.Add(this.txtStrikePrice);
            this.Controls.Add(this.lblDividend);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblTimeOfMaturity);
            this.Controls.Add(this.lblStrikePrice);
            this.Controls.Add(this.txtUnderlyingPrice);
            this.Controls.Add(this.lblUnderlyingPrice);
            this.Name = "Form1";
            this.Text = "Option Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnderlyingPrice;
        private System.Windows.Forms.TextBox txtUnderlyingPrice;
        private System.Windows.Forms.Label lblStrikePrice;
        private System.Windows.Forms.Label lblTimeOfMaturity;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblDividend;
        private System.Windows.Forms.TextBox txtStrikePrice;
        private System.Windows.Forms.TextBox txtTimeOfMaturity;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDividend;
        private System.Windows.Forms.TextBox txtMarketPRice;
        private System.Windows.Forms.Label lblMarketPrice;
        private System.Windows.Forms.Button btnCalCulate;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label lblIvResult;
        private System.Windows.Forms.ComboBox cmbOptionType;
        private System.Windows.Forms.Label lblOptionType;
    }
}

