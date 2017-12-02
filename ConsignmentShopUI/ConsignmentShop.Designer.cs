namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsinlist = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.purchaseditem = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorlistbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.storeprofitvalue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConsignmentShop demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(16, 51);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(180, 147);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsinlist
            // 
            this.itemsinlist.AutoSize = true;
            this.itemsinlist.Location = new System.Drawing.Point(16, 32);
            this.itemsinlist.Name = "itemsinlist";
            this.itemsinlist.Size = new System.Drawing.Size(62, 13);
            this.itemsinlist.TabIndex = 2;
            this.itemsinlist.Text = "itemsinstore";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "purchase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "addtocart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // purchaseditem
            // 
            this.purchaseditem.FormattingEnabled = true;
            this.purchaseditem.Location = new System.Drawing.Point(355, 51);
            this.purchaseditem.Name = "purchaseditem";
            this.purchaseditem.Size = new System.Drawing.Size(165, 147);
            this.purchaseditem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "vendors";
            // 
            // vendorlistbox
            // 
            this.vendorlistbox.FormattingEnabled = true;
            this.vendorlistbox.Location = new System.Drawing.Point(12, 241);
            this.vendorlistbox.Name = "vendorlistbox";
            this.vendorlistbox.Size = new System.Drawing.Size(180, 147);
            this.vendorlistbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "store profit";
            // 
            // storeprofitvalue
            // 
            this.storeprofitvalue.AutoSize = true;
            this.storeprofitvalue.Location = new System.Drawing.Point(420, 289);
            this.storeprofitvalue.Name = "storeprofitvalue";
            this.storeprofitvalue.Size = new System.Drawing.Size(34, 13);
            this.storeprofitvalue.TabIndex = 10;
            this.storeprofitvalue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 400);
            this.Controls.Add(this.storeprofitvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendorlistbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseditem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemsinlist);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsignmentShop";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsinlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox purchaseditem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox vendorlistbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label storeprofitvalue;
    }
}

