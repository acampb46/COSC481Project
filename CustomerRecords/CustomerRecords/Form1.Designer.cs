namespace CustomerRecords
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.f1textBox1 = new System.Windows.Forms.TextBox();
            this.f1button1 = new System.Windows.Forms.Button();
            this.f1label2 = new System.Windows.Forms.Label();
            this.f1button2 = new System.Windows.Forms.Button();
            this.f1dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f1dataGridView2 = new System.Windows.Forms.DataGridView();
            this.f1button7 = new System.Windows.Forms.Button();
            this.f1dataGridView3 = new System.Windows.Forms.DataGridView();
            this.f1button8 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.f1dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f1dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // f1textBox1
            // 
            this.f1textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.f1textBox1.Location = new System.Drawing.Point(12, 62);
            this.f1textBox1.Name = "f1textBox1";
            this.f1textBox1.Size = new System.Drawing.Size(278, 30);
            this.f1textBox1.TabIndex = 0;
            // 
            // f1button1
            // 
            this.f1button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.f1button1.Location = new System.Drawing.Point(307, 62);
            this.f1button1.Name = "f1button1";
            this.f1button1.Size = new System.Drawing.Size(93, 90);
            this.f1button1.TabIndex = 2;
            this.f1button1.Text = "Search";
            this.f1button1.UseVisualStyleBackColor = true;
            this.f1button1.Click += new System.EventHandler(this.searchCustomer);
            // 
            // f1label2
            // 
            this.f1label2.AutoSize = true;
            this.f1label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.f1label2.Location = new System.Drawing.Point(12, 30);
            this.f1label2.Name = "f1label2";
            this.f1label2.Size = new System.Drawing.Size(407, 29);
            this.f1label2.TabIndex = 1;
            this.f1label2.Text = "Search Last Name or Phone Number";
            // 
            // f1button2
            // 
            this.f1button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.f1button2.Location = new System.Drawing.Point(12, 94);
            this.f1button2.Name = "f1button2";
            this.f1button2.Size = new System.Drawing.Size(278, 58);
            this.f1button2.TabIndex = 5;
            this.f1button2.Text = "Add New Customer";
            this.f1button2.UseVisualStyleBackColor = true;
            this.f1button2.Click += new System.EventHandler(this.createNewCustomer);
            // 
            // f1dataGridView1
            // 
            this.f1dataGridView1.AllowUserToAddRows = false;
            this.f1dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.f1dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.f1dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.f1dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f1dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.f1dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.f1dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.f1dataGridView1.Name = "f1dataGridView1";
            this.f1dataGridView1.ReadOnly = true;
            this.f1dataGridView1.RowTemplate.ReadOnly = true;
            this.f1dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f1dataGridView1.Size = new System.Drawing.Size(1131, 84);
            this.f1dataGridView1.TabIndex = 12;
            this.f1dataGridView1.TabStop = false;
            this.f1dataGridView1.Visible = false;
            this.f1dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.f1dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // f1dataGridView2
            // 
            this.f1dataGridView2.AllowUserToAddRows = false;
            this.f1dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.f1dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.f1dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.f1dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f1dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.f1dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.f1dataGridView2.Location = new System.Drawing.Point(12, 296);
            this.f1dataGridView2.Name = "f1dataGridView2";
            this.f1dataGridView2.ReadOnly = true;
            this.f1dataGridView2.RowTemplate.ReadOnly = true;
            this.f1dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f1dataGridView2.Size = new System.Drawing.Size(1131, 122);
            this.f1dataGridView2.TabIndex = 13;
            this.f1dataGridView2.Visible = false;
            this.f1dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.f1dataGridView2_CellClick);
            // 
            // f1button7
            // 
            this.f1button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.f1button7.Location = new System.Drawing.Point(980, 248);
            this.f1button7.Name = "f1button7";
            this.f1button7.Size = new System.Drawing.Size(163, 42);
            this.f1button7.TabIndex = 14;
            this.f1button7.Text = "Add Pet";
            this.f1button7.UseVisualStyleBackColor = true;
            this.f1button7.Visible = false;
            this.f1button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // f1dataGridView3
            // 
            this.f1dataGridView3.AllowUserToAddRows = false;
            this.f1dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.f1dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.f1dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.f1dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.f1dataGridView3.Location = new System.Drawing.Point(12, 472);
            this.f1dataGridView3.Name = "f1dataGridView3";
            this.f1dataGridView3.ReadOnly = true;
            this.f1dataGridView3.Size = new System.Drawing.Size(1131, 164);
            this.f1dataGridView3.TabIndex = 15;
            this.f1dataGridView3.Visible = false;
            // 
            // f1button8
            // 
            this.f1button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.f1button8.Location = new System.Drawing.Point(980, 424);
            this.f1button8.Name = "f1button8";
            this.f1button8.Size = new System.Drawing.Size(163, 42);
            this.f1button8.TabIndex = 16;
            this.f1button8.Text = "Add Order";
            this.f1button8.UseVisualStyleBackColor = true;
            this.f1button8.Visible = false;
            this.f1button8.Click += new System.EventHandler(this.f1button8_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clear.Location = new System.Drawing.Point(406, 62);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(92, 90);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pets";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Appointments";
            this.label2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRecordsToolStripMenuItem,
            this.calendarToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerRecordsToolStripMenuItem
            // 
            this.customerRecordsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.customerRecordsToolStripMenuItem.Name = "customerRecordsToolStripMenuItem";
            this.customerRecordsToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.customerRecordsToolStripMenuItem.Text = "CustomerRecords";
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.calendarToolStripMenuItem.Text = "Calendar";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1155, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.f1button8);
            this.Controls.Add(this.f1dataGridView3);
            this.Controls.Add(this.f1button7);
            this.Controls.Add(this.f1dataGridView2);
            this.Controls.Add(this.f1dataGridView1);
            this.Controls.Add(this.f1button2);
            this.Controls.Add(this.f1button1);
            this.Controls.Add(this.f1label2);
            this.Controls.Add(this.f1textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CustomerRecords";
            ((System.ComponentModel.ISupportInitialize)(this.f1dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.f1dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f1textBox1;
        private System.Windows.Forms.Button f1button1;
        private System.Windows.Forms.Label f1label2;
        private System.Windows.Forms.Button f1button2;
        private System.Windows.Forms.DataGridView f1dataGridView1;
        private System.Windows.Forms.DataGridView f1dataGridView2;
        private System.Windows.Forms.Button f1button7;
        private System.Windows.Forms.DataGridView f1dataGridView3;
        private System.Windows.Forms.Button f1button8;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

