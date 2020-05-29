namespace SynsGUI
{
    partial class UserControlPOS
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_custID = new System.Windows.Forms.TextBox();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.btn_chooseCust = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_getOldOrder = new System.Windows.Forms.Button();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addProd = new System.Windows.Forms.Button();
            this.btn_RemoveProdLine = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_prodID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_quantity = new System.Windows.Forms.ComboBox();
            this.btn_chooseProd = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_zipCity = new System.Windows.Forms.Label();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_discount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_PayFinal = new System.Windows.Forms.Button();
            this.lbl_pris = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.67971F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.78386F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.72421F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.27579F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.51719F));
            this.tableLayoutPanel1.Controls.Add(this.txt_custID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_newOrder, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_chooseCust, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_getOldOrder, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1661, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_custID
            // 
            this.txt_custID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_custID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txt_custID.Location = new System.Drawing.Point(8, 48);
            this.txt_custID.Margin = new System.Windows.Forms.Padding(8);
            this.txt_custID.Name = "txt_custID";
            this.txt_custID.Size = new System.Drawing.Size(178, 26);
            this.txt_custID.TabIndex = 3;
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_newOrder.Location = new System.Drawing.Point(509, 43);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(338, 34);
            this.btn_newOrder.TabIndex = 0;
            this.btn_newOrder.Text = "Ny ordre";
            this.btn_newOrder.UseVisualStyleBackColor = true;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // btn_chooseCust
            // 
            this.btn_chooseCust.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chooseCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_chooseCust.Location = new System.Drawing.Point(197, 43);
            this.btn_chooseCust.Name = "btn_chooseCust";
            this.btn_chooseCust.Size = new System.Drawing.Size(306, 34);
            this.btn_chooseCust.TabIndex = 6;
            this.btn_chooseCust.Text = "Vælg kunde";
            this.btn_chooseCust.UseVisualStyleBackColor = true;
            this.btn_chooseCust.Click += new System.EventHandler(this.btn_chooseCust_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kundenummer";
            // 
            // btn_getOldOrder
            // 
            this.btn_getOldOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getOldOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_getOldOrder.Location = new System.Drawing.Point(1339, 43);
            this.btn_getOldOrder.Name = "btn_getOldOrder";
            this.btn_getOldOrder.Size = new System.Drawing.Size(319, 34);
            this.btn_getOldOrder.TabIndex = 1;
            this.btn_getOldOrder.Text = "Hent ordre";
            this.btn_getOldOrder.UseVisualStyleBackColor = true;
            this.btn_getOldOrder.Click += new System.EventHandler(this.btn_getOldOrder_Click);
            // 
            // txt_orderID
            // 
            this.txt_orderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_orderID.Location = new System.Drawing.Point(3, 46);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.ReadOnly = true;
            this.txt_orderID.Size = new System.Drawing.Size(107, 26);
            this.txt_orderID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ordrenummer";
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 315);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1664, 486);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_addProd
            // 
            this.btn_addProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_addProd.Location = new System.Drawing.Point(579, 43);
            this.btn_addProd.Name = "btn_addProd";
            this.btn_addProd.Size = new System.Drawing.Size(141, 34);
            this.btn_addProd.TabIndex = 2;
            this.btn_addProd.Text = "Tilføj vare";
            this.btn_addProd.UseVisualStyleBackColor = true;
            this.btn_addProd.Click += new System.EventHandler(this.btn_addProd_Click);
            // 
            // btn_RemoveProdLine
            // 
            this.btn_RemoveProdLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RemoveProdLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_RemoveProdLine.Location = new System.Drawing.Point(3, 43);
            this.btn_RemoveProdLine.Name = "btn_RemoveProdLine";
            this.btn_RemoveProdLine.Size = new System.Drawing.Size(122, 34);
            this.btn_RemoveProdLine.TabIndex = 3;
            this.btn_RemoveProdLine.Text = "Fjern varelinie";
            this.btn_RemoveProdLine.UseVisualStyleBackColor = true;
            this.btn_RemoveProdLine.Click += new System.EventHandler(this.btn_RemoveProdLine_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_prodID
            // 
            this.txt_prodID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_prodID.Location = new System.Drawing.Point(150, 46);
            this.txt_prodID.Margin = new System.Windows.Forms.Padding(6);
            this.txt_prodID.Name = "txt_prodID";
            this.txt_prodID.Size = new System.Drawing.Size(132, 26);
            this.txt_prodID.TabIndex = 8;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(147, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Varenr";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(435, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Antal";
            // 
            // cmb_quantity
            // 
            this.cmb_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_quantity.FormattingEnabled = true;
            this.cmb_quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            ""});
            this.cmb_quantity.Location = new System.Drawing.Point(438, 46);
            this.cmb_quantity.Margin = new System.Windows.Forms.Padding(6);
            this.cmb_quantity.Name = "cmb_quantity";
            this.cmb_quantity.Size = new System.Drawing.Size(132, 28);
            this.cmb_quantity.TabIndex = 13;
            this.cmb_quantity.Text = "1";
            // 
            // btn_chooseProd
            // 
            this.btn_chooseProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chooseProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_chooseProd.Location = new System.Drawing.Point(291, 43);
            this.btn_chooseProd.Name = "btn_chooseProd";
            this.btn_chooseProd.Size = new System.Drawing.Size(138, 34);
            this.btn_chooseProd.TabIndex = 14;
            this.btn_chooseProd.Text = "Vælg vare";
            this.btn_chooseProd.UseVisualStyleBackColor = true;
            this.btn_chooseProd.Click += new System.EventHandler(this.btn_chooseProd_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_adress, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_zipCity, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 148);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1661, 62);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(3, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "navn";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adress.Location = new System.Drawing.Point(3, 20);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(73, 20);
            this.label_adress.TabIndex = 1;
            this.label_adress.Text = "adresse";
            // 
            // label_zipCity
            // 
            this.label_zipCity.AutoSize = true;
            this.label_zipCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zipCity.Location = new System.Drawing.Point(3, 40);
            this.label_zipCity.Name = "label_zipCity";
            this.label_zipCity.Size = new System.Drawing.Size(83, 20);
            this.label_zipCity.TabIndex = 2;
            this.label_zipCity.Text = "postnr by";
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_deleteOrder.Location = new System.Drawing.Point(131, 43);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(122, 34);
            this.btn_deleteOrder.TabIndex = 16;
            this.btn_deleteOrder.Text = "Slet Ordre";
            this.btn_deleteOrder.UseVisualStyleBackColor = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.78541F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.69127F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.47668F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.04664F));
            this.tableLayoutPanel3.Controls.Add(this.cbb_discount, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_PayFinal, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_pris, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1015, 827);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(660, 80);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // cbb_discount
            // 
            this.cbb_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbb_discount.FormattingEnabled = true;
            this.cbb_discount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbb_discount.Location = new System.Drawing.Point(96, 46);
            this.cbb_discount.Margin = new System.Windows.Forms.Padding(6);
            this.cbb_discount.Name = "cbb_discount";
            this.cbb_discount.Size = new System.Drawing.Size(104, 28);
            this.cbb_discount.TabIndex = 2;
            this.cbb_discount.Text = "0";
            this.cbb_discount.SelectedIndexChanged += new System.EventHandler(this.cbb_discount_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(93, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rabat i %";
            // 
            // btn_PayFinal
            // 
            this.btn_PayFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PayFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_PayFinal.Location = new System.Drawing.Point(416, 43);
            this.btn_PayFinal.Name = "btn_PayFinal";
            this.btn_PayFinal.Size = new System.Drawing.Size(241, 34);
            this.btn_PayFinal.TabIndex = 3;
            this.btn_PayFinal.Text = "Betal";
            this.btn_PayFinal.UseVisualStyleBackColor = true;
            this.btn_PayFinal.Click += new System.EventHandler(this.btn_PayFinal_Click);
            // 
            // lbl_pris
            // 
            this.lbl_pris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pris.AutoSize = true;
            this.lbl_pris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pris.Location = new System.Drawing.Point(290, 51);
            this.lbl_pris.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_pris.Name = "lbl_pris";
            this.lbl_pris.Size = new System.Drawing.Size(38, 18);
            this.lbl_pris.TabIndex = 4;
            this.lbl_pris.Text = "Pris";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btn_addProd, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmb_quantity, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_chooseProd, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_prodID, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_orderID, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(11, 229);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(723, 80);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btn_deleteOrder, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btn_RemoveProdLine, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1416, 229);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(256, 80);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // UserControlPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1080, 570);
            this.Name = "UserControlPOS";
            this.Size = new System.Drawing.Size(1704, 941);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.Button btn_getOldOrder;
        private System.Windows.Forms.Button btn_addProd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_quantity;
        private System.Windows.Forms.Button btn_chooseProd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        public System.Windows.Forms.TextBox txt_prodID;
        private System.Windows.Forms.Button btn_chooseCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_zipCity;
        public System.Windows.Forms.TextBox txt_custID;
        public System.Windows.Forms.TextBox txt_orderID;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_deleteOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_PayFinal;
        public System.Windows.Forms.Label lbl_pris;
        public System.Windows.Forms.Button btn_RemoveProdLine;
        public System.Windows.Forms.ComboBox cbb_discount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}
