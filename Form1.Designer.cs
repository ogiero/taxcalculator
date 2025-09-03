namespace NarposTaxCalculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBackWard = new System.Windows.Forms.RadioButton();
            this.rbForward = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2022 = new System.Windows.Forms.RadioButton();
            this.rb2023 = new System.Windows.Forms.RadioButton();
            this.txtinclusive = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtexclusive = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtamountBeforeVat = new System.Windows.Forms.TextBox();
            this.txtNhil = new System.Windows.Forms.TextBox();
            this.txtCovidLevy = new System.Windows.Forms.TextBox();
            this.txtGetFundLevy = new System.Windows.Forms.TextBox();
            this.txtTlLevy = new System.Windows.Forms.TextBox();
            this.txtBaseAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNhil = new System.Windows.Forms.Label();
            this.lblCovid = new System.Windows.Forms.Label();
            this.lblGetFund = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgiristuru = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBackWard);
            this.groupBox2.Controls.Add(this.rbForward);
            this.groupBox2.Location = new System.Drawing.Point(18, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculation Direction";
            // 
            // rbBackWard
            // 
            this.rbBackWard.AutoSize = true;
            this.rbBackWard.Location = new System.Drawing.Point(6, 66);
            this.rbBackWard.Name = "rbBackWard";
            this.rbBackWard.Size = new System.Drawing.Size(184, 17);
            this.rbBackWard.TabIndex = 2;
            this.rbBackWard.Text = "From Grand Total to Main Amount";
            this.rbBackWard.UseVisualStyleBackColor = true;
            this.rbBackWard.CheckedChanged += new System.EventHandler(this.rbBackWard_CheckedChanged_1);
            // 
            // rbForward
            // 
            this.rbForward.AutoSize = true;
            this.rbForward.Checked = true;
            this.rbForward.Location = new System.Drawing.Point(6, 40);
            this.rbForward.Name = "rbForward";
            this.rbForward.Size = new System.Drawing.Size(184, 17);
            this.rbForward.TabIndex = 1;
            this.rbForward.TabStop = true;
            this.rbForward.Text = "From Main Amount to Grand Total";
            this.rbForward.UseVisualStyleBackColor = true;
            this.rbForward.CheckedChanged += new System.EventHandler(this.Rbforward_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2022);
            this.groupBox1.Controls.Add(this.rb2023);
            this.groupBox1.Location = new System.Drawing.Point(18, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year Selection";
            // 
            // rb2022
            // 
            this.rb2022.AutoSize = true;
            this.rb2022.Location = new System.Drawing.Point(23, 54);
            this.rb2022.Name = "rb2022";
            this.rb2022.Size = new System.Drawing.Size(98, 17);
            this.rb2022.TabIndex = 1;
            this.rb2022.Text = "NORMAL-2022";
            this.rb2022.UseVisualStyleBackColor = true;
            this.rb2022.CheckedChanged += new System.EventHandler(this.Yearselectionchange);
            // 
            // rb2023
            // 
            this.rb2023.AutoSize = true;
            this.rb2023.Checked = true;
            this.rb2023.Location = new System.Drawing.Point(23, 30);
            this.rb2023.Name = "rb2023";
            this.rb2023.Size = new System.Drawing.Size(98, 17);
            this.rb2023.TabIndex = 0;
            this.rb2023.TabStop = true;
            this.rb2023.Text = "NORMAL-2023";
            this.rb2023.UseVisualStyleBackColor = true;
            this.rb2023.CheckedChanged += new System.EventHandler(this.Yearselectionchange);
            // 
            // txtinclusive
            // 
            this.txtinclusive.Location = new System.Drawing.Point(910, 252);
            this.txtinclusive.Name = "txtinclusive";
            this.txtinclusive.Size = new System.Drawing.Size(223, 20);
            this.txtinclusive.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(907, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Sales amount - Inclusive of all taxes and VAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Sales amount - Exclusive of all taxes and VAT";
            // 
            // txtexclusive
            // 
            this.txtexclusive.Location = new System.Drawing.Point(909, 198);
            this.txtexclusive.Name = "txtexclusive";
            this.txtexclusive.Size = new System.Drawing.Size(223, 20);
            this.txtexclusive.TabIndex = 41;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(388, 248);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(79, 23);
            this.btnCalculate.TabIndex = 40;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(487, 297);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 39;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(593, 246);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(100, 20);
            this.txtVAT.TabIndex = 38;
            // 
            // txtamountBeforeVat
            // 
            this.txtamountBeforeVat.Location = new System.Drawing.Point(487, 246);
            this.txtamountBeforeVat.Name = "txtamountBeforeVat";
            this.txtamountBeforeVat.Size = new System.Drawing.Size(100, 20);
            this.txtamountBeforeVat.TabIndex = 37;
            // 
            // txtNhil
            // 
            this.txtNhil.Location = new System.Drawing.Point(711, 246);
            this.txtNhil.Name = "txtNhil";
            this.txtNhil.Size = new System.Drawing.Size(100, 20);
            this.txtNhil.TabIndex = 36;
            // 
            // txtCovidLevy
            // 
            this.txtCovidLevy.Location = new System.Drawing.Point(711, 203);
            this.txtCovidLevy.Name = "txtCovidLevy";
            this.txtCovidLevy.Size = new System.Drawing.Size(100, 20);
            this.txtCovidLevy.TabIndex = 35;
            // 
            // txtGetFundLevy
            // 
            this.txtGetFundLevy.Location = new System.Drawing.Point(593, 203);
            this.txtGetFundLevy.Name = "txtGetFundLevy";
            this.txtGetFundLevy.Size = new System.Drawing.Size(100, 20);
            this.txtGetFundLevy.TabIndex = 34;
            // 
            // txtTlLevy
            // 
            this.txtTlLevy.Location = new System.Drawing.Point(487, 203);
            this.txtTlLevy.Name = "txtTlLevy";
            this.txtTlLevy.Size = new System.Drawing.Size(100, 20);
            this.txtTlLevy.TabIndex = 33;
            // 
            // txtBaseAmount
            // 
            this.txtBaseAmount.Location = new System.Drawing.Point(282, 251);
            this.txtBaseAmount.Name = "txtBaseAmount";
            this.txtBaseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBaseAmount.TabIndex = 32;
            this.txtBaseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBaseAmount_keypress);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(484, 281);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 31;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(590, 230);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(60, 13);
            this.lblVAT.TabIndex = 30;
            this.lblVAT.Text = "VAT (%15):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Value before VAT";
            // 
            // lblNhil
            // 
            this.lblNhil.AutoSize = true;
            this.lblNhil.Location = new System.Drawing.Point(708, 230);
            this.lblNhil.Name = "lblNhil";
            this.lblNhil.Size = new System.Drawing.Size(67, 13);
            this.lblNhil.TabIndex = 28;
            this.lblNhil.Text = "NHIL (%2.5):";
            // 
            // lblCovid
            // 
            this.lblCovid.AutoSize = true;
            this.lblCovid.Location = new System.Drawing.Point(708, 187);
            this.lblCovid.Name = "lblCovid";
            this.lblCovid.Size = new System.Drawing.Size(81, 13);
            this.lblCovid.TabIndex = 27;
            this.lblCovid.Text = "Covid Tax (%1):";
            // 
            // lblGetFund
            // 
            this.lblGetFund.AutoSize = true;
            this.lblGetFund.Location = new System.Drawing.Point(590, 187);
            this.lblGetFund.Name = "lblGetFund";
            this.lblGetFund.Size = new System.Drawing.Size(112, 13);
            this.lblGetFund.TabIndex = 26;
            this.lblGetFund.Text = "Get Fund Levy (%2.5):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = " tlLevy (%1)";
            // 
            // lblgiristuru
            // 
            this.lblgiristuru.AutoSize = true;
            this.lblgiristuru.Location = new System.Drawing.Point(279, 220);
            this.lblgiristuru.Name = "lblgiristuru";
            this.lblgiristuru.Size = new System.Drawing.Size(149, 13);
            this.lblgiristuru.TabIndex = 24;
            this.lblgiristuru.Text = "BaseAmount (excluding taxes)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtinclusive);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtexclusive);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtamountBeforeVat);
            this.Controls.Add(this.txtNhil);
            this.Controls.Add(this.txtCovidLevy);
            this.Controls.Add(this.txtGetFundLevy);
            this.Controls.Add(this.txtTlLevy);
            this.Controls.Add(this.txtBaseAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNhil);
            this.Controls.Add(this.lblCovid);
            this.Controls.Add(this.lblGetFund);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblgiristuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBackWard;
        private System.Windows.Forms.RadioButton rbForward;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2022;
        private System.Windows.Forms.RadioButton rb2023;
        private System.Windows.Forms.TextBox txtinclusive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtexclusive;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtamountBeforeVat;
        private System.Windows.Forms.TextBox txtNhil;
        private System.Windows.Forms.TextBox txtCovidLevy;
        private System.Windows.Forms.TextBox txtGetFundLevy;
        private System.Windows.Forms.TextBox txtTlLevy;
        private System.Windows.Forms.TextBox txtBaseAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNhil;
        private System.Windows.Forms.Label lblCovid;
        private System.Windows.Forms.Label lblGetFund;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgiristuru;
    }
}

