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
            textBox_tk2 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(639, 68);
            label1.Name = "label1";
            label1.Size = new Size(478, 47);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // textBox_tk2
            // 
            textBox_tk2.Location = new Point(470, 153);
            textBox_tk2.Name = "textBox_tk2";
            textBox_tk2.Size = new Size(587, 27);
            textBox_tk2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 15.75F, FontStyle.Bold);
            button1.Location = new Point(249, 142);
            button1.Name = "button1";
            button1.Size = new Size(197, 40);
            button1.TabIndex = 2;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Font = new Font("Cambria", 11F);
            groupBox1.Location = new Point(83, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1354, 458);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Khách Hàng";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 61);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1342, 350);
            dataGridView2.TabIndex = 0;
            // 
            // DSKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox_tk2);
            Controls.Add(label1);
            Name = "DSKH";
            Size = new Size(1575, 765);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_tk2;
        private Button button1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
    }
}