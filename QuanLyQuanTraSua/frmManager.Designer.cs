
namespace QuanLyQuanTraSua
{
    partial class frmManager
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
            this.tcManager = new System.Windows.Forms.TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.nudAccountType = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtAccountDisplayName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btnAccountShow = new System.Windows.Forms.Button();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.nudOrderPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.cbOrderCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtOrderSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderShow = new System.Windows.Forms.Button();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.tpTables = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtgvTables = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnTableShow = new System.Windows.Forms.Button();
            this.btnTableEdit = new System.Windows.Forms.Button();
            this.btnTableDelete = new System.Windows.Forms.Button();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.tpEarnings = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumPage = new System.Windows.Forms.TextBox();
            this.btnGoBackPage = new System.Windows.Forms.Button();
            this.btnGoToNextPage = new System.Windows.Forms.Button();
            this.btnGoToFirstPage = new System.Windows.Forms.Button();
            this.btnGoToLastPage = new System.Windows.Forms.Button();
            this.dtgvEarnings = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEarningView = new System.Windows.Forms.Button();
            this.dtpTo_Date = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom_Date = new System.Windows.Forms.DateTimePicker();
            this.tcManager.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpOrder.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderPrice)).BeginInit();
            this.panel20.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpTables.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTables)).BeginInit();
            this.panel12.SuspendLayout();
            this.tpEarnings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEarnings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManager
            // 
            this.tcManager.Controls.Add(this.tpAccount);
            this.tcManager.Controls.Add(this.tpOrder);
            this.tcManager.Controls.Add(this.tpTables);
            this.tcManager.Controls.Add(this.tpEarnings);
            this.tcManager.Location = new System.Drawing.Point(9, 3);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(669, 403);
            this.tcManager.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel15);
            this.tpAccount.Controls.Add(this.panel26);
            this.tpAccount.Controls.Add(this.panel23);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(661, 377);
            this.tpAccount.TabIndex = 0;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel14);
            this.panel15.Controls.Add(this.btnResetPass);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Location = new System.Drawing.Point(422, 9);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(233, 224);
            this.panel15.TabIndex = 16;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtAccountName);
            this.panel14.Controls.Add(this.label10);
            this.panel14.Location = new System.Drawing.Point(3, 13);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(230, 48);
            this.panel14.TabIndex = 15;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(98, 12);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(126, 26);
            this.txtAccountName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên tài khoản:";
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(131, 175);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(96, 40);
            this.btnResetPass.TabIndex = 3;
            this.btnResetPass.Text = "Đặt lại mật khẩu";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.nudAccountType);
            this.panel16.Controls.Add(this.label11);
            this.panel16.Location = new System.Drawing.Point(0, 121);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(230, 48);
            this.panel16.TabIndex = 2;
            // 
            // nudAccountType
            // 
            this.nudAccountType.Location = new System.Drawing.Point(101, 15);
            this.nudAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAccountType.Name = "nudAccountType";
            this.nudAccountType.Size = new System.Drawing.Size(38, 20);
            this.nudAccountType.TabIndex = 3;
            this.nudAccountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Loại tài khoản";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtAccountDisplayName);
            this.panel17.Controls.Add(this.label12);
            this.panel17.Location = new System.Drawing.Point(0, 67);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(230, 48);
            this.panel17.TabIndex = 1;
            // 
            // txtAccountDisplayName
            // 
            this.txtAccountDisplayName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountDisplayName.Location = new System.Drawing.Point(101, 12);
            this.txtAccountDisplayName.Name = "txtAccountDisplayName";
            this.txtAccountDisplayName.Size = new System.Drawing.Size(126, 26);
            this.txtAccountDisplayName.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên hiển thị:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.btnAccountShow);
            this.panel26.Controls.Add(this.btnAccountUpdate);
            this.panel26.Controls.Add(this.btnAccountDelete);
            this.panel26.Controls.Add(this.btnAccountAdd);
            this.panel26.Location = new System.Drawing.Point(149, 294);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(267, 50);
            this.panel26.TabIndex = 13;
            // 
            // btnAccountShow
            // 
            this.btnAccountShow.Location = new System.Drawing.Point(198, 3);
            this.btnAccountShow.Name = "btnAccountShow";
            this.btnAccountShow.Size = new System.Drawing.Size(59, 40);
            this.btnAccountShow.TabIndex = 3;
            this.btnAccountShow.Text = "Xem";
            this.btnAccountShow.UseVisualStyleBackColor = true;
            this.btnAccountShow.Click += new System.EventHandler(this.btnAccountShow_Click);
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.Location = new System.Drawing.Point(133, 3);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(59, 40);
            this.btnAccountUpdate.TabIndex = 2;
            this.btnAccountUpdate.Text = "Sửa";
            this.btnAccountUpdate.UseVisualStyleBackColor = true;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.Location = new System.Drawing.Point(68, 3);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(59, 40);
            this.btnAccountDelete.TabIndex = 1;
            this.btnAccountDelete.Text = "Xóa";
            this.btnAccountDelete.UseVisualStyleBackColor = true;
            this.btnAccountDelete.Click += new System.EventHandler(this.btnAccountDelete_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(59, 40);
            this.btnAccountAdd.TabIndex = 0;
            this.btnAccountAdd.Text = "Thêm";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.dtgvAccount);
            this.panel23.Location = new System.Drawing.Point(9, 6);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(410, 282);
            this.panel23.TabIndex = 14;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(404, 276);
            this.dtgvAccount.TabIndex = 0;
            // 
            // tpOrder
            // 
            this.tpOrder.Controls.Add(this.panel5);
            this.tpOrder.Controls.Add(this.panel4);
            this.tpOrder.Controls.Add(this.panel3);
            this.tpOrder.Controls.Add(this.panel2);
            this.tpOrder.Location = new System.Drawing.Point(4, 22);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpOrder.Size = new System.Drawing.Size(661, 377);
            this.tpOrder.TabIndex = 1;
            this.tpOrder.Text = "Các món";
            this.tpOrder.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel19);
            this.panel5.Controls.Add(this.panel21);
            this.panel5.Controls.Add(this.panel20);
            this.panel5.Controls.Add(this.panel18);
            this.panel5.Location = new System.Drawing.Point(422, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 266);
            this.panel5.TabIndex = 3;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtOrderID);
            this.panel19.Controls.Add(this.label2);
            this.panel19.Location = new System.Drawing.Point(3, 13);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(230, 48);
            this.panel19.TabIndex = 2;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(74, 12);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(153, 26);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.nudOrderPrice);
            this.panel21.Controls.Add(this.label4);
            this.panel21.Location = new System.Drawing.Point(0, 175);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(230, 48);
            this.panel21.TabIndex = 3;
            // 
            // nudOrderPrice
            // 
            this.nudOrderPrice.Location = new System.Drawing.Point(77, 14);
            this.nudOrderPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudOrderPrice.Name = "nudOrderPrice";
            this.nudOrderPrice.Size = new System.Drawing.Size(150, 20);
            this.nudOrderPrice.TabIndex = 1;
            this.nudOrderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOrderPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.cbOrderCategory);
            this.panel20.Controls.Add(this.label3);
            this.panel20.Location = new System.Drawing.Point(3, 67);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(230, 48);
            this.panel20.TabIndex = 2;
            // 
            // cbOrderCategory
            // 
            this.cbOrderCategory.FormattingEnabled = true;
            this.cbOrderCategory.Location = new System.Drawing.Point(74, 16);
            this.cbOrderCategory.Name = "cbOrderCategory";
            this.cbOrderCategory.Size = new System.Drawing.Size(150, 21);
            this.cbOrderCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txtOrderName);
            this.panel18.Controls.Add(this.label1);
            this.panel18.Location = new System.Drawing.Point(3, 121);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(230, 48);
            this.panel18.TabIndex = 1;
            // 
            // txtOrderName
            // 
            this.txtOrderName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderName.Location = new System.Drawing.Point(74, 12);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(150, 26);
            this.txtOrderName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtOrderSearch);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Location = new System.Drawing.Point(422, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 46);
            this.panel4.TabIndex = 2;
            // 
            // txtOrderSearch
            // 
            this.txtOrderSearch.Location = new System.Drawing.Point(3, 14);
            this.txtOrderSearch.Name = "txtOrderSearch";
            this.txtOrderSearch.Size = new System.Drawing.Size(162, 20);
            this.txtOrderSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(171, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(59, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvOrder);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 284);
            this.panel3.TabIndex = 1;
            // 
            // dtgvOrder
            // 
            this.dtgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrder.Location = new System.Drawing.Point(3, 3);
            this.dtgvOrder.Name = "dtgvOrder";
            this.dtgvOrder.Size = new System.Drawing.Size(410, 278);
            this.dtgvOrder.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrderShow);
            this.panel2.Controls.Add(this.btnOrderEdit);
            this.panel2.Controls.Add(this.btnOrderDelete);
            this.panel2.Controls.Add(this.btnOrderAdd);
            this.panel2.Location = new System.Drawing.Point(154, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnOrderShow
            // 
            this.btnOrderShow.Location = new System.Drawing.Point(198, 3);
            this.btnOrderShow.Name = "btnOrderShow";
            this.btnOrderShow.Size = new System.Drawing.Size(59, 40);
            this.btnOrderShow.TabIndex = 3;
            this.btnOrderShow.Text = "Xem";
            this.btnOrderShow.UseVisualStyleBackColor = true;
            this.btnOrderShow.Click += new System.EventHandler(this.btnOrderShow_Click);
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Location = new System.Drawing.Point(133, 3);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(59, 40);
            this.btnOrderEdit.TabIndex = 2;
            this.btnOrderEdit.Text = "Sửa";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.btnOrderEdit_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(68, 3);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(59, 40);
            this.btnOrderDelete.TabIndex = 1;
            this.btnOrderDelete.Text = "Xóa";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(3, 3);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(59, 40);
            this.btnOrderAdd.TabIndex = 0;
            this.btnOrderAdd.Text = "Thêm";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // tpTables
            // 
            this.tpTables.Controls.Add(this.panel8);
            this.tpTables.Controls.Add(this.panel9);
            this.tpTables.Controls.Add(this.panel11);
            this.tpTables.Controls.Add(this.panel12);
            this.tpTables.Location = new System.Drawing.Point(4, 22);
            this.tpTables.Name = "tpTables";
            this.tpTables.Padding = new System.Windows.Forms.Padding(3);
            this.tpTables.Size = new System.Drawing.Size(661, 377);
            this.tpTables.TabIndex = 3;
            this.tpTables.Text = "Bàn";
            this.tpTables.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTableID);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(412, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(230, 48);
            this.panel8.TabIndex = 11;
            // 
            // txtTableID
            // 
            this.txtTableID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableID.Location = new System.Drawing.Point(98, 8);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(129, 26);
            this.txtTableID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(409, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(233, 266);
            this.panel9.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtTableName);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(0, 67);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(230, 48);
            this.panel10.TabIndex = 1;
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(101, 12);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(126, 26);
            this.txtTableName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên bàn:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dtgvTables);
            this.panel11.Location = new System.Drawing.Point(6, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(397, 280);
            this.panel11.TabIndex = 10;
            // 
            // dtgvTables
            // 
            this.dtgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTables.Location = new System.Drawing.Point(3, 3);
            this.dtgvTables.Name = "dtgvTables";
            this.dtgvTables.Size = new System.Drawing.Size(391, 274);
            this.dtgvTables.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnTableShow);
            this.panel12.Controls.Add(this.btnTableEdit);
            this.panel12.Controls.Add(this.btnTableDelete);
            this.panel12.Controls.Add(this.btnTableAdd);
            this.panel12.Location = new System.Drawing.Point(138, 292);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(265, 46);
            this.panel12.TabIndex = 9;
            // 
            // btnTableShow
            // 
            this.btnTableShow.Location = new System.Drawing.Point(198, 3);
            this.btnTableShow.Name = "btnTableShow";
            this.btnTableShow.Size = new System.Drawing.Size(59, 40);
            this.btnTableShow.TabIndex = 3;
            this.btnTableShow.Text = "Xem";
            this.btnTableShow.UseVisualStyleBackColor = true;
            this.btnTableShow.Click += new System.EventHandler(this.btnTableShow_Click);
            // 
            // btnTableEdit
            // 
            this.btnTableEdit.Location = new System.Drawing.Point(133, 3);
            this.btnTableEdit.Name = "btnTableEdit";
            this.btnTableEdit.Size = new System.Drawing.Size(59, 40);
            this.btnTableEdit.TabIndex = 2;
            this.btnTableEdit.Text = "Sửa";
            this.btnTableEdit.UseVisualStyleBackColor = true;
            this.btnTableEdit.Click += new System.EventHandler(this.btnTableEdit_Click);
            // 
            // btnTableDelete
            // 
            this.btnTableDelete.Location = new System.Drawing.Point(68, 3);
            this.btnTableDelete.Name = "btnTableDelete";
            this.btnTableDelete.Size = new System.Drawing.Size(59, 40);
            this.btnTableDelete.TabIndex = 1;
            this.btnTableDelete.Text = "Xóa";
            this.btnTableDelete.UseVisualStyleBackColor = true;
            this.btnTableDelete.Click += new System.EventHandler(this.btnTableDelete_Click);
            // 
            // btnTableAdd
            // 
            this.btnTableAdd.Location = new System.Drawing.Point(3, 3);
            this.btnTableAdd.Name = "btnTableAdd";
            this.btnTableAdd.Size = new System.Drawing.Size(59, 40);
            this.btnTableAdd.TabIndex = 0;
            this.btnTableAdd.Text = "Thêm";
            this.btnTableAdd.UseVisualStyleBackColor = true;
            this.btnTableAdd.Click += new System.EventHandler(this.btnTableAdd_Click);
            // 
            // tpEarnings
            // 
            this.tpEarnings.Controls.Add(this.label5);
            this.tpEarnings.Controls.Add(this.txtNumPage);
            this.tpEarnings.Controls.Add(this.btnGoBackPage);
            this.tpEarnings.Controls.Add(this.btnGoToNextPage);
            this.tpEarnings.Controls.Add(this.btnGoToFirstPage);
            this.tpEarnings.Controls.Add(this.btnGoToLastPage);
            this.tpEarnings.Controls.Add(this.dtgvEarnings);
            this.tpEarnings.Controls.Add(this.panel1);
            this.tpEarnings.Location = new System.Drawing.Point(4, 22);
            this.tpEarnings.Name = "tpEarnings";
            this.tpEarnings.Padding = new System.Windows.Forms.Padding(3);
            this.tpEarnings.Size = new System.Drawing.Size(661, 377);
            this.tpEarnings.TabIndex = 4;
            this.tpEarnings.Text = "Doanh thu";
            this.tpEarnings.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Page";
            // 
            // txtNumPage
            // 
            this.txtNumPage.Location = new System.Drawing.Point(286, 354);
            this.txtNumPage.Name = "txtNumPage";
            this.txtNumPage.ReadOnly = true;
            this.txtNumPage.Size = new System.Drawing.Size(56, 20);
            this.txtNumPage.TabIndex = 6;
            this.txtNumPage.Text = "1";
            this.txtNumPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumPage.TextChanged += new System.EventHandler(this.txtNumPage_TextChanged);
            // 
            // btnGoBackPage
            // 
            this.btnGoBackPage.Location = new System.Drawing.Point(81, 338);
            this.btnGoBackPage.Name = "btnGoBackPage";
            this.btnGoBackPage.Size = new System.Drawing.Size(69, 36);
            this.btnGoBackPage.TabIndex = 5;
            this.btnGoBackPage.Text = "Quay lai";
            this.btnGoBackPage.UseVisualStyleBackColor = true;
            this.btnGoBackPage.Click += new System.EventHandler(this.btnGoBackPage_Click);
            // 
            // btnGoToNextPage
            // 
            this.btnGoToNextPage.Location = new System.Drawing.Point(508, 338);
            this.btnGoToNextPage.Name = "btnGoToNextPage";
            this.btnGoToNextPage.Size = new System.Drawing.Size(69, 36);
            this.btnGoToNextPage.TabIndex = 4;
            this.btnGoToNextPage.Text = "Tiếp theo";
            this.btnGoToNextPage.UseVisualStyleBackColor = true;
            this.btnGoToNextPage.Click += new System.EventHandler(this.btnGoToNextPage_Click);
            // 
            // btnGoToFirstPage
            // 
            this.btnGoToFirstPage.Location = new System.Drawing.Point(6, 338);
            this.btnGoToFirstPage.Name = "btnGoToFirstPage";
            this.btnGoToFirstPage.Size = new System.Drawing.Size(69, 36);
            this.btnGoToFirstPage.TabIndex = 3;
            this.btnGoToFirstPage.Text = "Đầu";
            this.btnGoToFirstPage.UseVisualStyleBackColor = true;
            this.btnGoToFirstPage.Click += new System.EventHandler(this.btnGoToFirstPage_Click);
            // 
            // btnGoToLastPage
            // 
            this.btnGoToLastPage.Location = new System.Drawing.Point(583, 338);
            this.btnGoToLastPage.Name = "btnGoToLastPage";
            this.btnGoToLastPage.Size = new System.Drawing.Size(69, 36);
            this.btnGoToLastPage.TabIndex = 2;
            this.btnGoToLastPage.Text = "Cuối";
            this.btnGoToLastPage.UseVisualStyleBackColor = true;
            this.btnGoToLastPage.Click += new System.EventHandler(this.btnGoToLastPage_Click);
            // 
            // dtgvEarnings
            // 
            this.dtgvEarnings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEarnings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEarnings.Location = new System.Drawing.Point(6, 45);
            this.dtgvEarnings.Name = "dtgvEarnings";
            this.dtgvEarnings.Size = new System.Drawing.Size(646, 290);
            this.dtgvEarnings.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEarningView);
            this.panel1.Controls.Add(this.dtpTo_Date);
            this.panel1.Controls.Add(this.dtpFrom_Date);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnEarningView
            // 
            this.btnEarningView.Location = new System.Drawing.Point(274, 6);
            this.btnEarningView.Name = "btnEarningView";
            this.btnEarningView.Size = new System.Drawing.Size(85, 33);
            this.btnEarningView.TabIndex = 2;
            this.btnEarningView.Text = "Thống kê";
            this.btnEarningView.UseVisualStyleBackColor = true;
            this.btnEarningView.Click += new System.EventHandler(this.btnEarningView_Click);
            // 
            // dtpTo_Date
            // 
            this.dtpTo_Date.Location = new System.Drawing.Point(488, 10);
            this.dtpTo_Date.Name = "dtpTo_Date";
            this.dtpTo_Date.Size = new System.Drawing.Size(164, 20);
            this.dtpTo_Date.TabIndex = 1;
            // 
            // dtpFrom_Date
            // 
            this.dtpFrom_Date.Location = new System.Drawing.Point(6, 10);
            this.dtpFrom_Date.Name = "dtpFrom_Date";
            this.dtpFrom_Date.Size = new System.Drawing.Size(164, 20);
            this.dtpFrom_Date.TabIndex = 0;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 418);
            this.Controls.Add(this.tcManager);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.tcManager.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAccountType)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpOrder.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderPrice)).EndInit();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tpTables.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTables)).EndInit();
            this.panel12.ResumeLayout(false);
            this.tpEarnings.ResumeLayout(false);
            this.tpEarnings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEarnings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.TabPage tpTables;
        private System.Windows.Forms.TabPage tpEarnings;
        private System.Windows.Forms.DataGridView dtgvEarnings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEarningView;
        private System.Windows.Forms.DateTimePicker dtpTo_Date;
        private System.Windows.Forms.DateTimePicker dtpFrom_Date;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtOrderSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrderShow;
        private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.ComboBox cbOrderCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.NumericUpDown nudOrderPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtAccountDisplayName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnAccountShow;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.Button btnAccountDelete;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dtgvTables;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnTableShow;
        private System.Windows.Forms.Button btnTableEdit;
        private System.Windows.Forms.Button btnTableDelete;
        private System.Windows.Forms.Button btnTableAdd;
        private System.Windows.Forms.NumericUpDown nudAccountType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumPage;
        private System.Windows.Forms.Button btnGoBackPage;
        private System.Windows.Forms.Button btnGoToNextPage;
        private System.Windows.Forms.Button btnGoToFirstPage;
        private System.Windows.Forms.Button btnGoToLastPage;
    }
}