namespace PRO131
{
    partial class DanhsachKH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView2 = new DataGridView();
            label1 = new Label();
            textBox_TK = new TextBox();
            button_TK = new Button();
            button_Thoat = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 179);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(805, 435);
            dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 18);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH KHÁCH HÀNG";
            label1.Click += label1_Click;
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(130, 87);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(516, 27);
            textBox_TK.TabIndex = 3;
            // 
            // button_TK
            // 
            button_TK.Location = new Point(13, 85);
            button_TK.Name = "button_TK";
            button_TK.Size = new Size(94, 29);
            button_TK.TabIndex = 4;
            button_TK.Text = "KiếmTìm ";
            button_TK.UseVisualStyleBackColor = true;
            // 
            // button_Thoat
            // 
            button_Thoat.Location = new Point(680, 87);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(94, 29);
            button_Thoat.TabIndex = 5;
            button_Thoat.Text = "Thoát";
            button_Thoat.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // DanhsachKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Thoat);
            Controls.Add(button_TK);
            Controls.Add(textBox_TK);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Name = "DanhsachKH";
            Size = new Size(921, 627);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label1;
        private TextBox textBox_TK;
        private Button button_TK;
        private Button button_Thoat;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
