namespace _26_PA09_Zachary
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
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radyen = new System.Windows.Forms.RadioButton();
            this.radusd = new System.Windows.Forms.RadioButton();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(106, 74);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(100, 20);
            this.txtamount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value";
            // 
            // radyen
            // 
            this.radyen.AutoSize = true;
            this.radyen.Location = new System.Drawing.Point(106, 117);
            this.radyen.Name = "radyen";
            this.radyen.Size = new System.Drawing.Size(93, 17);
            this.radyen.TabIndex = 4;
            this.radyen.TabStop = true;
            this.radyen.Text = "Japanese Yen";
            this.radyen.UseVisualStyleBackColor = true;
            // 
            // radusd
            // 
            this.radusd.AutoSize = true;
            this.radusd.Location = new System.Drawing.Point(106, 139);
            this.radusd.Name = "radusd";
            this.radusd.Size = new System.Drawing.Size(75, 17);
            this.radusd.TabIndex = 5;
            this.radusd.TabStop = true;
            this.radusd.Text = "US Dollars";
            this.radusd.UseVisualStyleBackColor = true;
            // 
            // txtvalue
            // 
            this.txtvalue.Enabled = false;
            this.txtvalue.Location = new System.Drawing.Point(106, 177);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.ReadOnly = true;
            this.txtvalue.Size = new System.Drawing.Size(100, 20);
            this.txtvalue.TabIndex = 0;
            this.txtvalue.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(231, 117);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 7;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.Btnconvert_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(231, 147);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.radusd);
            this.Controls.Add(this.radyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.txtamount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radyen;
        private System.Windows.Forms.RadioButton radusd;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Button btnclear;
    }
}

