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
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbBackWard = new System.Windows.Forms.RadioButton();
            this.rbForward = new System.Windows.Forms.RadioButton();
            this.lblNhil = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCovid = new System.Windows.Forms.Label();
            this.txtCovidLevy = new System.Windows.Forms.TextBox();
            this.lblGetFund = new System.Windows.Forms.Label();
            this.txtNhil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGetFundLevy = new System.Windows.Forms.TextBox();
            this.txtTlLevy = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtamountBeforeVat = new System.Windows.Forms.TextBox();
            this.txtBaseAmount = new System.Windows.Forms.TextBox();
            this.lblgiristuru = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2022 = new System.Windows.Forms.RadioButton();
            this.rb2023 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtexclusive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinclusive = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(this.rbForward);
            groupBox2.Controls.Add(this.rbBackWard);
            groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            groupBox2.ForeColor = System.Drawing.Color.White;
            groupBox2.Location = new System.Drawing.Point(792, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(224, 90);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calculation Direction";
            // 
            // rbBackWard
            // 
            this.rbBackWard.AutoSize = true;
            this.rbBackWard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbBackWard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbBackWard.Location = new System.Drawing.Point(6, 66);
            this.rbBackWard.Name = "rbBackWard";
            this.rbBackWard.Size = new System.Drawing.Size(215, 17);
            this.rbBackWard.TabIndex = 2;
            this.rbBackWard.Text = "From Grand Total to Main Amount";
            this.rbBackWard.UseVisualStyleBackColor = true;
            this.rbBackWard.CheckedChanged += new System.EventHandler(this.rbBackWard_CheckedChanged_1);
            // 
            // rbForward
            // 
            this.rbForward.AutoSize = true;
            this.rbForward.Checked = true;
            this.rbForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbForward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbForward.Location = new System.Drawing.Point(6, 40);
            this.rbForward.Name = "rbForward";
            this.rbForward.Size = new System.Drawing.Size(215, 17);
            this.rbForward.TabIndex = 1;
            this.rbForward.TabStop = true;
            this.rbForward.Text = "From Main Amount to Grand Total";
            this.rbForward.UseVisualStyleBackColor = true;
            this.rbForward.CheckedChanged += new System.EventHandler(this.Rbforward_CheckedChanged);
            // 
            // lblNhil
            // 
            this.lblNhil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNhil.AutoSize = true;
            this.lblNhil.BackColor = System.Drawing.Color.Transparent;
            this.lblNhil.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNhil.ForeColor = System.Drawing.Color.White;
            this.lblNhil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNhil.Location = new System.Drawing.Point(823, 425);
            this.lblNhil.Name = "lblNhil";
            this.lblNhil.Size = new System.Drawing.Size(86, 17);
            this.lblNhil.TabIndex = 28;
            this.lblNhil.Text = "NHIL (%2.5):";
            // 
            // lblVAT
            // 
            this.lblVAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVAT.AutoSize = true;
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVAT.ForeColor = System.Drawing.Color.White;
            this.lblVAT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVAT.Location = new System.Drawing.Point(840, 372);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(77, 17);
            this.lblVAT.TabIndex = 30;
            this.lblVAT.Text = "VAT (%15):";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(695, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Value before VAT";
            // 
            // lblCovid
            // 
            this.lblCovid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCovid.AutoSize = true;
            this.lblCovid.BackColor = System.Drawing.Color.Transparent;
            this.lblCovid.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCovid.ForeColor = System.Drawing.Color.White;
            this.lblCovid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCovid.Location = new System.Drawing.Point(579, 425);
            this.lblCovid.Name = "lblCovid";
            this.lblCovid.Size = new System.Drawing.Size(105, 17);
            this.lblCovid.TabIndex = 27;
            this.lblCovid.Text = "Covid Tax (%1):";
            // 
            // txtCovidLevy
            // 
            this.txtCovidLevy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCovidLevy.Location = new System.Drawing.Point(570, 445);
            this.txtCovidLevy.Name = "txtCovidLevy";
            this.txtCovidLevy.ReadOnly = true;
            this.txtCovidLevy.Size = new System.Drawing.Size(102, 20);
            this.txtCovidLevy.TabIndex = 35;
            // 
            // lblGetFund
            // 
            this.lblGetFund.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGetFund.AutoSize = true;
            this.lblGetFund.BackColor = System.Drawing.Color.Transparent;
            this.lblGetFund.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGetFund.ForeColor = System.Drawing.Color.White;
            this.lblGetFund.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGetFund.Location = new System.Drawing.Point(685, 372);
            this.lblGetFund.Name = "lblGetFund";
            this.lblGetFund.Size = new System.Drawing.Size(143, 17);
            this.lblGetFund.TabIndex = 26;
            this.lblGetFund.Text = "Get Fund Levy (%2.5):";
            // 
            // txtNhil
            // 
            this.txtNhil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhil.Location = new System.Drawing.Point(826, 445);
            this.txtNhil.Name = "txtNhil";
            this.txtNhil.ReadOnly = true;
            this.txtNhil.Size = new System.Drawing.Size(102, 20);
            this.txtNhil.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(580, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = " tlLevy (%1)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(401, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Sales amount - Exclusive of all taxes and VAT";
            // 
            // txtGetFundLevy
            // 
            this.txtGetFundLevy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGetFundLevy.Location = new System.Drawing.Point(698, 402);
            this.txtGetFundLevy.Name = "txtGetFundLevy";
            this.txtGetFundLevy.ReadOnly = true;
            this.txtGetFundLevy.Size = new System.Drawing.Size(100, 20);
            this.txtGetFundLevy.TabIndex = 34;
            // 
            // txtTlLevy
            // 
            this.txtTlLevy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTlLevy.Location = new System.Drawing.Point(570, 402);
            this.txtTlLevy.Name = "txtTlLevy";
            this.txtTlLevy.ReadOnly = true;
            this.txtTlLevy.Size = new System.Drawing.Size(100, 20);
            this.txtTlLevy.TabIndex = 33;
            // 
            // txtVAT
            // 
            this.txtVAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVAT.Location = new System.Drawing.Point(826, 402);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(100, 20);
            this.txtVAT.TabIndex = 38;
            // 
            // txtamountBeforeVat
            // 
            this.txtamountBeforeVat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtamountBeforeVat.Location = new System.Drawing.Point(698, 445);
            this.txtamountBeforeVat.Name = "txtamountBeforeVat";
            this.txtamountBeforeVat.ReadOnly = true;
            this.txtamountBeforeVat.Size = new System.Drawing.Size(100, 20);
            this.txtamountBeforeVat.TabIndex = 37;
            // 
            // txtBaseAmount
            // 
            this.txtBaseAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBaseAmount.Location = new System.Drawing.Point(651, 334);
            this.txtBaseAmount.Name = "txtBaseAmount";
            this.txtBaseAmount.Size = new System.Drawing.Size(177, 20);
            this.txtBaseAmount.TabIndex = 32;
            this.txtBaseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBaseAmount_keypress);
            // 
            // lblgiristuru
            // 
            this.lblgiristuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblgiristuru.BackColor = System.Drawing.Color.Transparent;
            this.lblgiristuru.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiristuru.ForeColor = System.Drawing.Color.White;
            this.lblgiristuru.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblgiristuru.Location = new System.Drawing.Point(648, 308);
            this.lblgiristuru.Name = "lblgiristuru";
            this.lblgiristuru.Size = new System.Drawing.Size(200, 23);
            this.lblgiristuru.TabIndex = 24;
            this.lblgiristuru.Text = "BaseAmount (Excluding Taxes)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalculate.Location = new System.Drawing.Point(850, 331);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 23);
            this.btnCalculate.TabIndex = 40;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(813, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Sales amount - Inclusive of all taxes and VAT";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb2022);
            this.groupBox1.Controls.Add(this.rb2023);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(506, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 90);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year Selection";
            // 
            // rb2022
            // 
            this.rb2022.AutoSize = true;
            this.rb2022.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rb2022.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb2022.Location = new System.Drawing.Point(23, 54);
            this.rb2022.Name = "rb2022";
            this.rb2022.Size = new System.Drawing.Size(109, 17);
            this.rb2022.TabIndex = 1;
            this.rb2022.Text = "NORMAL-2022";
            this.rb2022.UseVisualStyleBackColor = true;
            this.rb2022.CheckedChanged += new System.EventHandler(this.Yearselectionchange);
            // 
            // rb2023
            // 
            this.rb2023.AutoSize = true;
            this.rb2023.Checked = true;
            this.rb2023.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.rb2023.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rb2023.Location = new System.Drawing.Point(23, 30);
            this.rb2023.Name = "rb2023";
            this.rb2023.Size = new System.Drawing.Size(109, 17);
            this.rb2023.TabIndex = 0;
            this.rb2023.TabStop = true;
            this.rb2023.Text = "NORMAL-2023";
            this.rb2023.UseVisualStyleBackColor = true;
            this.rb2023.CheckedChanged += new System.EventHandler(this.Yearselectionchange);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 80F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(439, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 172);
            this.label3.TabIndex = 50;
            this.label3.Text = "NARPOS";
            // 
            // txtexclusive
            // 
            this.txtexclusive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtexclusive.Location = new System.Drawing.Point(419, 517);
            this.txtexclusive.Name = "txtexclusive";
            this.txtexclusive.ReadOnly = true;
            this.txtexclusive.Size = new System.Drawing.Size(265, 20);
            this.txtexclusive.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(737, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "TAX CALCULATOR APPLİCATİON";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtinclusive
            // 
            this.txtinclusive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtinclusive.Location = new System.Drawing.Point(816, 517);
            this.txtinclusive.Name = "txtinclusive";
            this.txtinclusive.ReadOnly = true;
            this.txtinclusive.Size = new System.Drawing.Size(262, 20);
            this.txtinclusive.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::NarposTaxCalculator.Properties.Resources.narposres;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblgiristuru);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.txtinclusive);
            this.panel1.Controls.Add(this.txtexclusive);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtamountBeforeVat);
            this.panel1.Controls.Add(this.txtVAT);
            this.panel1.Controls.Add(this.txtTlLevy);
            this.panel1.Controls.Add(this.txtGetFundLevy);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNhil);
            this.panel1.Controls.Add(this.lblGetFund);
            this.panel1.Controls.Add(this.txtCovidLevy);
            this.panel1.Controls.Add(this.lblVAT);
            this.panel1.Controls.Add(this.txtBaseAmount);
            this.panel1.Controls.Add(this.lblCovid);
            this.panel1.Controls.Add(this.lblNhil);
            this.panel1.Controls.Add(groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 799);
            this.panel1.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1519, 784);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Narpos Tax Caltulator";
            this.TopMost = true;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhil;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCovid;
        private System.Windows.Forms.TextBox txtCovidLevy;
        private System.Windows.Forms.Label lblGetFund;
        private System.Windows.Forms.TextBox txtNhil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGetFundLevy;
        private System.Windows.Forms.TextBox txtTlLevy;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtamountBeforeVat;
        private System.Windows.Forms.TextBox txtBaseAmount;
        private System.Windows.Forms.Label lblgiristuru;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbBackWard;
        private System.Windows.Forms.RadioButton rbForward;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2022;
        private System.Windows.Forms.RadioButton rb2023;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtexclusive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinclusive;
        private System.Windows.Forms.Panel panel1;
    }
}

