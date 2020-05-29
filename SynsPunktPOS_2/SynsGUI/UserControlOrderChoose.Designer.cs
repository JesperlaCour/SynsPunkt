namespace SynsGUI
{
    partial class UserControlOrderChoose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_custName = new System.Windows.Forms.TextBox();
            this.btn_OrderSearch = new System.Windows.Forms.Button();
            this.btn_showAllCust = new System.Windows.Forms.Button();
            this.btn_OrderChoose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kundenavn";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txt_custName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_OrderSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_showAllCust, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_OrderChoose, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 42);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txt_custName
            // 
            this.txt_custName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_custName.Location = new System.Drawing.Point(8, 8);
            this.txt_custName.Margin = new System.Windows.Forms.Padding(8);
            this.txt_custName.Name = "txt_custName";
            this.txt_custName.Size = new System.Drawing.Size(84, 26);
            this.txt_custName.TabIndex = 1;
            // 
            // btn_OrderSearch
            // 
            this.btn_OrderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_OrderSearch.Location = new System.Drawing.Point(103, 3);
            this.btn_OrderSearch.Name = "btn_OrderSearch";
            this.btn_OrderSearch.Size = new System.Drawing.Size(94, 36);
            this.btn_OrderSearch.TabIndex = 2;
            this.btn_OrderSearch.Text = "Søg";
            this.btn_OrderSearch.UseVisualStyleBackColor = true;
            this.btn_OrderSearch.Click += new System.EventHandler(this.btn_OrderSearch_Click);
            // 
            // btn_showAllCust
            // 
            this.btn_showAllCust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_showAllCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_showAllCust.Location = new System.Drawing.Point(203, 3);
            this.btn_showAllCust.Name = "btn_showAllCust";
            this.btn_showAllCust.Size = new System.Drawing.Size(194, 36);
            this.btn_showAllCust.TabIndex = 3;
            this.btn_showAllCust.Text = "Vis alle";
            this.btn_showAllCust.UseVisualStyleBackColor = true;
            this.btn_showAllCust.Click += new System.EventHandler(this.btn_showAllCust_Click);
            // 
            // btn_OrderChoose
            // 
            this.btn_OrderChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OrderChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_OrderChoose.Location = new System.Drawing.Point(403, 3);
            this.btn_OrderChoose.Name = "btn_OrderChoose";
            this.btn_OrderChoose.Size = new System.Drawing.Size(95, 36);
            this.btn_OrderChoose.TabIndex = 4;
            this.btn_OrderChoose.Text = "Vælg";
            this.btn_OrderChoose.UseVisualStyleBackColor = true;
            this.btn_OrderChoose.Click += new System.EventHandler(this.btn_OrderChoose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 143);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1589, 753);
            this.dataGridView1.TabIndex = 11;
            // 
            // UserControlOrderChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlOrderChoose";
            this.Size = new System.Drawing.Size(1704, 941);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_custName;
        private System.Windows.Forms.Button btn_OrderSearch;
        private System.Windows.Forms.Button btn_showAllCust;
        private System.Windows.Forms.Button btn_OrderChoose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
