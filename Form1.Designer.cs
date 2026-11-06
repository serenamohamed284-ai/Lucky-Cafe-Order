namespace Lucky_Cafe_Order1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.grpDrink = new System.Windows.Forms.GroupBox();
            this.rdoTea = new System.Windows.Forms.RadioButton();
            this.rdoCoffee = new System.Windows.Forms.RadioButton();
            this.rdoJuice = new System.Windows.Forms.RadioButton();
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.chkStudentMember = new System.Windows.Forms.CheckBox();
            this.lblfooter = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblLuckyMessage = new System.Windows.Forms.Label();
            this.grpDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 573);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(251, 58);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Order";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(340, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 55);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(697, 580);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(287, 51);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load From Form";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1040, 576);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(277, 55);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(606, 57);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Lucky-Cafe-Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.LightBlue;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl2.Location = new System.Drawing.Point(692, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(601, 32);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Order List";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 493);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerInformation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInformation.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCustomerInformation.Location = new System.Drawing.Point(12, 79);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(239, 42);
            this.lblCustomerInformation.TabIndex = 7;
            this.lblCustomerInformation.Text = "Customer Information";
            this.lblCustomerInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 132);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(197, 39);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "Customer Name:";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textCustomerName
            // 
            this.textCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCustomerName.Location = new System.Drawing.Point(12, 186);
            this.textCustomerName.Multiline = true;
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(586, 38);
            this.textCustomerName.TabIndex = 9;
            // 
            // grpDrink
            // 
            this.grpDrink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpDrink.Controls.Add(this.rdoJuice);
            this.grpDrink.Controls.Add(this.rdoCoffee);
            this.grpDrink.Controls.Add(this.rdoTea);
            this.grpDrink.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grpDrink.Location = new System.Drawing.Point(12, 241);
            this.grpDrink.Name = "grpDrink";
            this.grpDrink.Size = new System.Drawing.Size(581, 201);
            this.grpDrink.TabIndex = 10;
            this.grpDrink.TabStop = false;
            this.grpDrink.Text = "Drink Type    ";
            // 
            // rdoTea
            // 
            this.rdoTea.AutoSize = true;
            this.rdoTea.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoTea.Location = new System.Drawing.Point(41, 41);
            this.rdoTea.Name = "rdoTea";
            this.rdoTea.Size = new System.Drawing.Size(104, 26);
            this.rdoTea.TabIndex = 0;
            this.rdoTea.TabStop = true;
            this.rdoTea.Text = "Tea ($1)";
            this.rdoTea.UseVisualStyleBackColor = true;
            // 
            // rdoCoffee
            // 
            this.rdoCoffee.AutoSize = true;
            this.rdoCoffee.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCoffee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoCoffee.Location = new System.Drawing.Point(41, 89);
            this.rdoCoffee.Name = "rdoCoffee";
            this.rdoCoffee.Size = new System.Drawing.Size(126, 26);
            this.rdoCoffee.TabIndex = 1;
            this.rdoCoffee.TabStop = true;
            this.rdoCoffee.Text = "Coffee ($2)";
            this.rdoCoffee.UseVisualStyleBackColor = true;
            // 
            // rdoJuice
            // 
            this.rdoJuice.AutoSize = true;
            this.rdoJuice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJuice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoJuice.Location = new System.Drawing.Point(41, 142);
            this.rdoJuice.Name = "rdoJuice";
            this.rdoJuice.Size = new System.Drawing.Size(114, 26);
            this.rdoJuice.TabIndex = 2;
            this.rdoJuice.TabStop = true;
            this.rdoJuice.Text = "Juice ($3)";
            this.rdoJuice.UseVisualStyleBackColor = true;
            // 
            // lstOrderList
            // 
            this.lstOrderList.FormattingEnabled = true;
            this.lstOrderList.ItemHeight = 19;
            this.lstOrderList.Location = new System.Drawing.Point(692, 104);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.Size = new System.Drawing.Size(601, 460);
            this.lstOrderList.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(29, 457);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 45);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textQuantity
            // 
            this.textQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQuantity.Location = new System.Drawing.Point(163, 457);
            this.textQuantity.Multiline = true;
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 45);
            this.textQuantity.TabIndex = 13;
            this.textQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkStudentMember
            // 
            this.chkStudentMember.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkStudentMember.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStudentMember.Location = new System.Drawing.Point(299, 469);
            this.chkStudentMember.Name = "chkStudentMember";
            this.chkStudentMember.Size = new System.Drawing.Size(309, 33);
            this.chkStudentMember.TabIndex = 14;
            this.chkStudentMember.Text = "Student Member (10% OFF)";
            this.chkStudentMember.UseVisualStyleBackColor = false;
            // 
            // lblfooter
            // 
            this.lblfooter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfooter.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfooter.Location = new System.Drawing.Point(2, 663);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(1338, 114);
            this.lblfooter.TabIndex = 15;
            this.lblfooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 663);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(239, 34);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price: $0.00";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLuckyMessage
            // 
            this.lblLuckyMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLuckyMessage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuckyMessage.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLuckyMessage.Location = new System.Drawing.Point(8, 718);
            this.lblLuckyMessage.Name = "lblLuckyMessage";
            this.lblLuckyMessage.Size = new System.Drawing.Size(391, 43);
            this.lblLuckyMessage.TabIndex = 17;
            this.lblLuckyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 786);
            this.Controls.Add(this.lblLuckyMessage);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblfooter);
            this.Controls.Add(this.chkStudentMember);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lstOrderList);
            this.Controls.Add(this.grpDrink);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerInformation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDrink.ResumeLayout(false);
            this.grpDrink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.GroupBox grpDrink;
        private System.Windows.Forms.RadioButton rdoJuice;
        private System.Windows.Forms.RadioButton rdoCoffee;
        private System.Windows.Forms.RadioButton rdoTea;
        private System.Windows.Forms.ListBox lstOrderList;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.CheckBox chkStudentMember;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblLuckyMessage;
    }
}

