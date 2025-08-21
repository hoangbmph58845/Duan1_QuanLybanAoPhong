namespace PRO131
{
    partial class DSKH
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            textBox_TK2 = new TextBox();
            button_TK2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(548, 32);
            label1.Name = "label1";
            label1.Size = new Size(478, 47);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Font = new Font("Cambria", 11F);
            groupBox1.Location = new Point(36, 301);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1383, 439);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(39, 64);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1303, 334);
            dataGridView2.TabIndex = 0;
            // 
            // textBox_TK2
            // 
            textBox_TK2.Location = new Point(527, 163);
            textBox_TK2.Name = "textBox_TK2";
            textBox_TK2.Size = new Size(564, 27);
            textBox_TK2.TabIndex = 2;
            // 
            // button_TK2
            // 
            button_TK2.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button_TK2.Location = new Point(350, 152);
            button_TK2.Name = "button_TK2";
            button_TK2.Size = new Size(150, 41);
            button_TK2.TabIndex = 3;
            button_TK2.Text = "Tìm Kiếm";
            button_TK2.UseVisualStyleBackColor = true;
            // 
            // DSKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_TK2);
            Controls.Add(textBox_TK2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "DSKH";
            Size = new Size(1538, 752);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private TextBox textBox_TK2;
        private Button button_TK2;
    }
}