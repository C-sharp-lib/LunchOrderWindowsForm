namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new System.Windows.Forms.GroupBox();
            rSalad = new System.Windows.Forms.RadioButton();
            rPizza = new System.Windows.Forms.RadioButton();
            rHamburger = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSalesTax = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            gbCondiments = new System.Windows.Forms.GroupBox();
            cbThirdAddOn = new System.Windows.Forms.CheckBox();
            cbSecondAddOn = new System.Windows.Forms.CheckBox();
            cbFirstAddOn = new System.Windows.Forms.CheckBox();
            bRefresh = new System.Windows.Forms.Button();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            gbCondiments.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(rSalad);
            gbxMainCourse.Controls.Add(rPizza);
            gbxMainCourse.Controls.Add(rHamburger);
            gbxMainCourse.Location = new System.Drawing.Point(34, 17);
            gbxMainCourse.Margin = new System.Windows.Forms.Padding(2);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new System.Windows.Forms.Padding(2);
            gbxMainCourse.Size = new System.Drawing.Size(159, 98);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // rSalad
            // 
            rSalad.AutoSize = true;
            rSalad.Location = new System.Drawing.Point(14, 71);
            rSalad.Name = "rSalad";
            rSalad.Size = new System.Drawing.Size(91, 19);
            rSalad.TabIndex = 2;
            rSalad.TabStop = true;
            rSalad.Text = "Salad - $4.95";
            rSalad.UseVisualStyleBackColor = true;
            rSalad.CheckedChanged += rSalad_CheckedChanged;
            // 
            // rPizza
            // 
            rPizza.AutoSize = true;
            rPizza.Location = new System.Drawing.Point(14, 46);
            rPizza.Name = "rPizza";
            rPizza.Size = new System.Drawing.Size(89, 19);
            rPizza.TabIndex = 1;
            rPizza.TabStop = true;
            rPizza.Text = "Pizza - $5.95";
            rPizza.UseVisualStyleBackColor = true;
            rPizza.CheckedChanged += rPizza_CheckedChanged;
            // 
            // rHamburger
            // 
            rHamburger.AutoSize = true;
            rHamburger.Location = new System.Drawing.Point(14, 21);
            rHamburger.Name = "rHamburger";
            rHamburger.Size = new System.Drawing.Size(124, 19);
            rHamburger.TabIndex = 0;
            rHamburger.TabStop = true;
            rHamburger.Text = "Hamburger - $6.95";
            rHamburger.UseVisualStyleBackColor = true;
            rHamburger.CheckedChanged += rHamburger_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(34, 133);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(260, 115);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(112, 76);
            txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(106, 23);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 79);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new System.Drawing.Point(112, 50);
            txtSalesTax.Margin = new System.Windows.Forms.Padding(2);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new System.Drawing.Size(106, 23);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 53);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(112, 23);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(106, 23);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 26);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(320, 143);
            btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(78, 25);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(320, 222);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(78, 25);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gbCondiments
            // 
            gbCondiments.Controls.Add(cbThirdAddOn);
            gbCondiments.Controls.Add(cbSecondAddOn);
            gbCondiments.Controls.Add(cbFirstAddOn);
            gbCondiments.Location = new System.Drawing.Point(211, 17);
            gbCondiments.Name = "gbCondiments";
            gbCondiments.Size = new System.Drawing.Size(187, 98);
            gbCondiments.TabIndex = 4;
            gbCondiments.TabStop = false;
            // 
            // cbThirdAddOn
            // 
            cbThirdAddOn.AutoSize = true;
            cbThirdAddOn.Location = new System.Drawing.Point(6, 71);
            cbThirdAddOn.Name = "cbThirdAddOn";
            cbThirdAddOn.Size = new System.Drawing.Size(15, 14);
            cbThirdAddOn.TabIndex = 2;
            cbThirdAddOn.UseVisualStyleBackColor = true;
            // 
            // cbSecondAddOn
            // 
            cbSecondAddOn.AutoSize = true;
            cbSecondAddOn.Location = new System.Drawing.Point(6, 46);
            cbSecondAddOn.Name = "cbSecondAddOn";
            cbSecondAddOn.Size = new System.Drawing.Size(15, 14);
            cbSecondAddOn.TabIndex = 1;
            cbSecondAddOn.UseVisualStyleBackColor = true;
            // 
            // cbFirstAddOn
            // 
            cbFirstAddOn.AutoSize = true;
            cbFirstAddOn.Location = new System.Drawing.Point(6, 21);
            cbFirstAddOn.Name = "cbFirstAddOn";
            cbFirstAddOn.Size = new System.Drawing.Size(15, 14);
            cbFirstAddOn.TabIndex = 0;
            cbFirstAddOn.UseVisualStyleBackColor = true;
            // 
            // bRefresh
            // 
            bRefresh.Location = new System.Drawing.Point(320, 183);
            bRefresh.Name = "bRefresh";
            bRefresh.Size = new System.Drawing.Size(78, 23);
            bRefresh.TabIndex = 5;
            bRefresh.Text = "Refresh";
            bRefresh.UseVisualStyleBackColor = true;
            bRefresh.Click += bRefresh_Click;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(433, 274);
            Controls.Add(bRefresh);
            Controls.Add(gbCondiments);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbCondiments.ResumeLayout(false);
            gbCondiments.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rPizza;
        private System.Windows.Forms.RadioButton rHamburger;
        private System.Windows.Forms.RadioButton rSalad;
        private System.Windows.Forms.GroupBox gbCondiments;
        private System.Windows.Forms.CheckBox cbSecondAddOn;
        private System.Windows.Forms.CheckBox cbFirstAddOn;
        private System.Windows.Forms.CheckBox cbThirdAddOn;
        private System.Windows.Forms.Button bRefresh;
    }
}

