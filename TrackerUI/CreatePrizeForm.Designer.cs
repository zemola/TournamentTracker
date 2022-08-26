
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.CreatePrizeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreatePrizeBtn
            // 
            this.CreatePrizeBtn.Location = new System.Drawing.Point(341, 364);
            this.CreatePrizeBtn.Name = "CreatePrizeBtn";
            this.CreatePrizeBtn.Size = new System.Drawing.Size(144, 43);
            this.CreatePrizeBtn.TabIndex = 16;
            this.CreatePrizeBtn.Text = "Create Prize";
            this.CreatePrizeBtn.UseVisualStyleBackColor = true;
            this.CreatePrizeBtn.Click += new System.EventHandler(this.CreatePrizeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(371, 218);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(244, 31);
            this.prizeAmountValue.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prize Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(371, 100);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(244, 31);
            this.placeNumberValue.TabIndex = 18;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.placeNumberValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(371, 160);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(244, 31);
            this.placeNameValue.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Place Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "-OR-";
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Location = new System.Drawing.Point(371, 308);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(244, 31);
            this.PrizePercentageValue.TabIndex = 22;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreatePrizeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePrizeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrizePercentageValue;
    }
}