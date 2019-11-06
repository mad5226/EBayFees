namespace EBayFees
{
    partial class frmEBayCalc
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
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblEbayFees = new System.Windows.Forms.Label();
            this.lblPayPal = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.txtBoxShipping = new System.Windows.Forms.TextBox();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.txtBoxEbayFees = new System.Windows.Forms.TextBox();
            this.txtBoxPayPal = new System.Windows.Forms.TextBox();
            this.txtBoxProfit = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(12, 82);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(64, 17);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(15, 137);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(149, 17);
            this.lblShipping.TabIndex = 1;
            this.lblShipping.Text = "Shipping (Seller Cost):";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(18, 198);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(102, 17);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost of Goods:";
            // 
            // lblEbayFees
            // 
            this.lblEbayFees.AutoSize = true;
            this.lblEbayFees.Location = new System.Drawing.Point(24, 293);
            this.lblEbayFees.Name = "lblEbayFees";
            this.lblEbayFees.Size = new System.Drawing.Size(79, 17);
            this.lblEbayFees.TabIndex = 3;
            this.lblEbayFees.Text = "Ebay Fees:";
            this.lblEbayFees.Click += new System.EventHandler(this.lblEbayFees_Click);
            // 
            // lblPayPal
            // 
            this.lblPayPal.AutoSize = true;
            this.lblPayPal.Location = new System.Drawing.Point(24, 344);
            this.lblPayPal.Name = "lblPayPal";
            this.lblPayPal.Size = new System.Drawing.Size(91, 17);
            this.lblPayPal.TabIndex = 4;
            this.lblPayPal.Text = "PayPal Fees:";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(27, 394);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(45, 17);
            this.lblProfit.TabIndex = 5;
            this.lblProfit.Text = "Profit:";
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.Location = new System.Drawing.Point(256, 79);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.Size = new System.Drawing.Size(137, 22);
            this.txtBoxSubtotal.TabIndex = 6;
            // 
            // txtBoxShipping
            // 
            this.txtBoxShipping.Location = new System.Drawing.Point(256, 134);
            this.txtBoxShipping.Name = "txtBoxShipping";
            this.txtBoxShipping.Size = new System.Drawing.Size(137, 22);
            this.txtBoxShipping.TabIndex = 7;
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Location = new System.Drawing.Point(256, 195);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(137, 22);
            this.txtBoxCost.TabIndex = 8;
            // 
            // txtBoxEbayFees
            // 
            this.txtBoxEbayFees.Location = new System.Drawing.Point(256, 290);
            this.txtBoxEbayFees.Name = "txtBoxEbayFees";
            this.txtBoxEbayFees.ReadOnly = true;
            this.txtBoxEbayFees.Size = new System.Drawing.Size(137, 22);
            this.txtBoxEbayFees.TabIndex = 9;
            // 
            // txtBoxPayPal
            // 
            this.txtBoxPayPal.Location = new System.Drawing.Point(256, 341);
            this.txtBoxPayPal.Name = "txtBoxPayPal";
            this.txtBoxPayPal.ReadOnly = true;
            this.txtBoxPayPal.Size = new System.Drawing.Size(137, 22);
            this.txtBoxPayPal.TabIndex = 10;
            // 
            // txtBoxProfit
            // 
            this.txtBoxProfit.Location = new System.Drawing.Point(256, 391);
            this.txtBoxProfit.Name = "txtBoxProfit";
            this.txtBoxProfit.ReadOnly = true;
            this.txtBoxProfit.Size = new System.Drawing.Size(137, 22);
            this.txtBoxProfit.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(427, 195);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(21, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 23);
            this.label1.TabIndex = 13;
            // 
            // frmEBayCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBoxProfit);
            this.Controls.Add(this.txtBoxPayPal);
            this.Controls.Add(this.txtBoxEbayFees);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.txtBoxShipping);
            this.Controls.Add(this.txtBoxSubtotal);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblPayPal);
            this.Controls.Add(this.lblEbayFees);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblSubTotal);
            this.Name = "frmEBayCalc";
            this.Text = "Ebay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblEbayFees;
        private System.Windows.Forms.Label lblPayPal;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.TextBox txtBoxShipping;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.TextBox txtBoxEbayFees;
        private System.Windows.Forms.TextBox txtBoxPayPal;
        private System.Windows.Forms.TextBox txtBoxProfit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
    }
}

