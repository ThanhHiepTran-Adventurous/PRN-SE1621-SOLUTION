namespace PRN_SE1621_WinFormsApp
{
    partial class FrmAddProduct
    {
        private Label lbProductID;
        private Label lbProductName;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private Label lbUnitPrice;
        private Label lbCreateDate;
        private MaskedTextBox maskedTextBox1;
        private Label lbDesc;
        private TextBox txtDesc;
        private MaskedTextBox mskUnitPrice;
        private Button btnSave;
        private Button btnCancel;
        private Label lbContinue;
        private GroupBox grpContinued;
        private RadioButton raDisContinued;
        private RadioButton raContinued;
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduct));
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.mskUnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbContinue = new System.Windows.Forms.Label();
            this.grpContinued = new System.Windows.Forms.GroupBox();
            this.raDisContinued = new System.Windows.Forms.RadioButton();
            this.raContinued = new System.Windows.Forms.RadioButton();
            this.grpContinued.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(44, 59);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            this.lbProductID.Click += new System.EventHandler(this.lbProductID_Click);
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(44, 117);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            this.lbProductName.Click += new System.EventHandler(this.lbProductName_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtProductId.Location = new System.Drawing.Point(209, 59);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(343, 27);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(209, 114);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(342, 27);
            this.txtProductName.TabIndex = 2;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(44, 177);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(44, 249);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(88, 20);
            this.lbCreateDate.TabIndex = 5;
            this.lbCreateDate.Text = "Create Date";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(209, 246);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(164, 27);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(47, 374);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(85, 20);
            this.lbDesc.TabIndex = 7;
            this.lbDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(212, 374);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(343, 94);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // mskUnitPrice
            // 
            this.mskUnitPrice.Location = new System.Drawing.Point(209, 179);
            this.mskUnitPrice.Mask = "00.000,00";
            this.mskUnitPrice.Name = "mskUnitPrice";
            this.mskUnitPrice.Size = new System.Drawing.Size(266, 27);
            this.mskUnitPrice.TabIndex = 9;
            this.mskUnitPrice.ValidatingType = typeof(int);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.Location = new System.Drawing.Point(355, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbContinue
            // 
            this.lbContinue.AutoSize = true;
            this.lbContinue.Location = new System.Drawing.Point(47, 322);
            this.lbContinue.Name = "lbContinue";
            this.lbContinue.Size = new System.Drawing.Size(77, 20);
            this.lbContinue.TabIndex = 12;
            this.lbContinue.Text = "Continued";
            // 
            // grpContinued
            // 
            this.grpContinued.Controls.Add(this.raDisContinued);
            this.grpContinued.Controls.Add(this.raContinued);
            this.grpContinued.Location = new System.Drawing.Point(209, 279);
            this.grpContinued.Name = "grpContinued";
            this.grpContinued.Size = new System.Drawing.Size(346, 76);
            this.grpContinued.TabIndex = 13;
            this.grpContinued.TabStop = false;
            this.grpContinued.Enter += new System.EventHandler(this.grpContinued_Enter);
            // 
            // raDisContinued
            // 
            this.raDisContinued.AutoSize = true;
            this.raDisContinued.Location = new System.Drawing.Point(186, 43);
            this.raDisContinued.Name = "raDisContinued";
            this.raDisContinued.Size = new System.Drawing.Size(117, 24);
            this.raDisContinued.TabIndex = 15;
            this.raDisContinued.Text = "Discontinued";
            this.raDisContinued.UseVisualStyleBackColor = true;
            // 
            // raContinued
            // 
            this.raContinued.AutoSize = true;
            this.raContinued.Checked = true;
            this.raContinued.Location = new System.Drawing.Point(47, 43);
            this.raContinued.Name = "raContinued";
            this.raContinued.Size = new System.Drawing.Size(98, 24);
            this.raContinued.TabIndex = 14;
            this.raContinued.TabStop = true;
            this.raContinued.Text = "Continued";
            this.raContinued.UseVisualStyleBackColor = true;
            // 
            // FrmAddProduct
            // 
            this.ClientSize = new System.Drawing.Size(630, 658);
            this.Controls.Add(this.grpContinued);
            this.Controls.Add(this.lbContinue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mskUnitPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecommerce Product Managemnts";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
            this.grpContinued.ResumeLayout(false);
            this.grpContinued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbProductName_Click(object sender, EventArgs e)
        {

        }

        private void lbProductID_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {

        }



        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpContinued_Enter(object sender, EventArgs e)
        {

        }


    }
}