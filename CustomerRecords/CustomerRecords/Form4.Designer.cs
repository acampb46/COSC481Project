namespace CustomerRecords
{
    partial class Form4
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
            this.f4label1 = new System.Windows.Forms.Label();
            this.f4textBox2 = new System.Windows.Forms.TextBox();
            this.f4label2 = new System.Windows.Forms.Label();
            this.f4textBox3 = new System.Windows.Forms.TextBox();
            this.f4label3 = new System.Windows.Forms.Label();
            this.f4checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.f4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f4label1
            // 
            this.f4label1.AutoSize = true;
            this.f4label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.f4label1.Location = new System.Drawing.Point(12, 9);
            this.f4label1.Name = "f4label1";
            this.f4label1.Size = new System.Drawing.Size(126, 24);
            this.f4label1.TabIndex = 0;
            this.f4label1.Text = "Treatments: ";
            // 
            // f4textBox2
            // 
            this.f4textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.f4textBox2.Location = new System.Drawing.Point(121, 194);
            this.f4textBox2.Name = "f4textBox2";
            this.f4textBox2.ReadOnly = true;
            this.f4textBox2.Size = new System.Drawing.Size(214, 29);
            this.f4textBox2.TabIndex = 5;
            this.f4textBox2.TabStop = false;
            // 
            // f4label2
            // 
            this.f4label2.AutoSize = true;
            this.f4label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.f4label2.Location = new System.Drawing.Point(16, 199);
            this.f4label2.Name = "f4label2";
            this.f4label2.Size = new System.Drawing.Size(58, 24);
            this.f4label2.TabIndex = 4;
            this.f4label2.Text = "Date:";
            // 
            // f4textBox3
            // 
            this.f4textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.f4textBox3.Location = new System.Drawing.Point(121, 229);
            this.f4textBox3.Name = "f4textBox3";
            this.f4textBox3.Size = new System.Drawing.Size(113, 29);
            this.f4textBox3.TabIndex = 7;
            this.f4textBox3.TabStop = false;
            // 
            // f4label3
            // 
            this.f4label3.AutoSize = true;
            this.f4label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.f4label3.Location = new System.Drawing.Point(16, 229);
            this.f4label3.Name = "f4label3";
            this.f4label3.Size = new System.Drawing.Size(110, 24);
            this.f4label3.TabIndex = 6;
            this.f4label3.Text = "TotalPrice:";
            // 
            // f4checkedListBox1
            // 
            this.f4checkedListBox1.CheckOnClick = true;
            this.f4checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.f4checkedListBox1.FormattingEnabled = true;
            this.f4checkedListBox1.Items.AddRange(new object[] {
            "Bath(30)",
            "Nail Clippings(20)",
            "DeSkunking(30)",
            "Untangling",
            "DeMatting"});
            this.f4checkedListBox1.Location = new System.Drawing.Point(132, 12);
            this.f4checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.f4checkedListBox1.Name = "f4checkedListBox1";
            this.f4checkedListBox1.Size = new System.Drawing.Size(336, 148);
            this.f4checkedListBox1.TabIndex = 1;
            this.f4checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.f4checkedListBox1_SelectedIndexChanged);
            // 
            // f4
            // 
            this.f4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.f4.Location = new System.Drawing.Point(352, 194);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(192, 73);
            this.f4.TabIndex = 2;
            this.f4.Text = "Create Order";
            this.f4.UseVisualStyleBackColor = true;
            this.f4.Click += new System.EventHandler(this.f4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 295);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.f4checkedListBox1);
            this.Controls.Add(this.f4textBox3);
            this.Controls.Add(this.f4label3);
            this.Controls.Add(this.f4textBox2);
            this.Controls.Add(this.f4label2);
            this.Controls.Add(this.f4label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f4label1;
        private System.Windows.Forms.TextBox f4textBox2;
        private System.Windows.Forms.Label f4label2;
        private System.Windows.Forms.TextBox f4textBox3;
        private System.Windows.Forms.Label f4label3;
        private System.Windows.Forms.CheckedListBox f4checkedListBox1;
        private System.Windows.Forms.Button f4;
    }
}