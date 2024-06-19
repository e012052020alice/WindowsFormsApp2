namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn快選 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab選號 = new System.Windows.Forms.TabPage();
            this.btn刪除所選號碼 = new System.Windows.Forms.Button();
            this.btn加入選號紀錄 = new System.Windows.Forms.Button();
            this.lbox選號紀錄 = new System.Windows.Forms.ListBox();
            this.tab包牌 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl二區包含號碼 = new System.Windows.Forms.Label();
            this.lbl二區剔除號碼 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl包含號碼2 = new System.Windows.Forms.Label();
            this.btn剔除號碼 = new System.Windows.Forms.Button();
            this.btn包含號碼 = new System.Windows.Forms.Button();
            this.lbl剔除號碼 = new System.Windows.Forms.Label();
            this.lbl包含號碼 = new System.Windows.Forms.Label();
            this.textBox包牌數量 = new System.Windows.Forms.TextBox();
            this.btn包牌 = new System.Windows.Forms.Button();
            this.lbox包牌紀錄 = new System.Windows.Forms.ListBox();
            this.tab對獎 = new System.Windows.Forms.TabPage();
            this.lbl購買期數 = new System.Windows.Forms.Label();
            this.lbl開獎期數 = new System.Windows.Forms.Label();
            this.lbl期數 = new System.Windows.Forms.Label();
            this.btn開獎 = new System.Windows.Forms.Button();
            this.btn對獎 = new System.Windows.Forms.Button();
            this.lbox購買紀錄 = new System.Windows.Forms.ListBox();
            this.lblwinning7 = new System.Windows.Forms.Label();
            this.lblwinning6 = new System.Windows.Forms.Label();
            this.lblwinning5 = new System.Windows.Forms.Label();
            this.lblwinning4 = new System.Windows.Forms.Label();
            this.lblwinning3 = new System.Windows.Forms.Label();
            this.lblwinning2 = new System.Windows.Forms.Label();
            this.lblwinning1 = new System.Windows.Forms.Label();
            this.lbox對獎紀錄 = new System.Windows.Forms.ListBox();
            this.tab歷史紀錄 = new System.Windows.Forms.TabPage();
            this.lbox歷史得獎紀錄 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn刪除所有號碼 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab選號.SuspendLayout();
            this.tab包牌.SuspendLayout();
            this.tab對獎.SuspendLayout();
            this.tab歷史紀錄.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn快選
            // 
            this.btn快選.BackColor = System.Drawing.Color.LightCoral;
            this.btn快選.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn快選.Location = new System.Drawing.Point(23, 390);
            this.btn快選.Margin = new System.Windows.Forms.Padding(4);
            this.btn快選.Name = "btn快選";
            this.btn快選.Size = new System.Drawing.Size(123, 59);
            this.btn快選.TabIndex = 0;
            this.btn快選.Text = "快選";
            this.btn快選.UseVisualStyleBackColor = false;
            this.btn快選.Click += new System.EventHandler(this.btn快選_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab選號);
            this.tabControl1.Controls.Add(this.tab包牌);
            this.tabControl1.Controls.Add(this.tab對獎);
            this.tabControl1.Controls.Add(this.tab歷史紀錄);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1191, 508);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab選號
            // 
            this.tab選號.BackColor = System.Drawing.Color.Cornsilk;
            this.tab選號.Controls.Add(this.btn刪除所選號碼);
            this.tab選號.Controls.Add(this.btn加入選號紀錄);
            this.tab選號.Controls.Add(this.lbox選號紀錄);
            this.tab選號.Controls.Add(this.btn快選);
            this.tab選號.Location = new System.Drawing.Point(4, 34);
            this.tab選號.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab選號.Name = "tab選號";
            this.tab選號.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab選號.Size = new System.Drawing.Size(1183, 470);
            this.tab選號.TabIndex = 0;
            this.tab選號.Text = "選號";
            // 
            // btn刪除所選號碼
            // 
            this.btn刪除所選號碼.BackColor = System.Drawing.Color.PowderBlue;
            this.btn刪除所選號碼.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn刪除所選號碼.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn刪除所選號碼.Location = new System.Drawing.Point(439, 389);
            this.btn刪除所選號碼.Margin = new System.Windows.Forms.Padding(4);
            this.btn刪除所選號碼.Name = "btn刪除所選號碼";
            this.btn刪除所選號碼.Size = new System.Drawing.Size(221, 59);
            this.btn刪除所選號碼.TabIndex = 7;
            this.btn刪除所選號碼.Text = "刪除所選號碼";
            this.btn刪除所選號碼.UseVisualStyleBackColor = false;
            this.btn刪除所選號碼.Click += new System.EventHandler(this.btn刪除所選號碼_Click);
            // 
            // btn加入選號紀錄
            // 
            this.btn加入選號紀錄.BackColor = System.Drawing.Color.Violet;
            this.btn加入選號紀錄.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn加入選號紀錄.Location = new System.Drawing.Point(175, 389);
            this.btn加入選號紀錄.Margin = new System.Windows.Forms.Padding(4);
            this.btn加入選號紀錄.Name = "btn加入選號紀錄";
            this.btn加入選號紀錄.Size = new System.Drawing.Size(237, 59);
            this.btn加入選號紀錄.TabIndex = 2;
            this.btn加入選號紀錄.Text = "加入選號紀錄";
            this.btn加入選號紀錄.UseVisualStyleBackColor = false;
            this.btn加入選號紀錄.Click += new System.EventHandler(this.btn加入選號紀錄_Click);
            // 
            // lbox選號紀錄
            // 
            this.lbox選號紀錄.BackColor = System.Drawing.Color.MistyRose;
            this.lbox選號紀錄.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox選號紀錄.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbox選號紀錄.FormattingEnabled = true;
            this.lbox選號紀錄.ItemHeight = 34;
            this.lbox選號紀錄.Location = new System.Drawing.Point(667, 6);
            this.lbox選號紀錄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox選號紀錄.Name = "lbox選號紀錄";
            this.lbox選號紀錄.Size = new System.Drawing.Size(471, 412);
            this.lbox選號紀錄.TabIndex = 1;
            // 
            // tab包牌
            // 
            this.tab包牌.BackColor = System.Drawing.Color.LemonChiffon;
            this.tab包牌.Controls.Add(this.btn刪除所有號碼);
            this.tab包牌.Controls.Add(this.label2);
            this.tab包牌.Controls.Add(this.lbl二區包含號碼);
            this.tab包牌.Controls.Add(this.lbl二區剔除號碼);
            this.tab包牌.Controls.Add(this.label1);
            this.tab包牌.Controls.Add(this.lbl包含號碼2);
            this.tab包牌.Controls.Add(this.btn剔除號碼);
            this.tab包牌.Controls.Add(this.btn包含號碼);
            this.tab包牌.Controls.Add(this.lbl剔除號碼);
            this.tab包牌.Controls.Add(this.lbl包含號碼);
            this.tab包牌.Controls.Add(this.textBox包牌數量);
            this.tab包牌.Controls.Add(this.btn包牌);
            this.tab包牌.Controls.Add(this.lbox包牌紀錄);
            this.tab包牌.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab包牌.Location = new System.Drawing.Point(4, 34);
            this.tab包牌.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab包牌.Name = "tab包牌";
            this.tab包牌.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab包牌.Size = new System.Drawing.Size(1183, 470);
            this.tab包牌.TabIndex = 1;
            this.tab包牌.Text = "包牌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(544, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "第二選區";
            // 
            // lbl二區包含號碼
            // 
            this.lbl二區包含號碼.AutoSize = true;
            this.lbl二區包含號碼.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl二區包含號碼.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl二區包含號碼.Location = new System.Drawing.Point(555, 386);
            this.lbl二區包含號碼.Name = "lbl二區包含號碼";
            this.lbl二區包含號碼.Size = new System.Drawing.Size(26, 27);
            this.lbl二區包含號碼.TabIndex = 16;
            this.lbl二區包含號碼.Text = "0";
            // 
            // lbl二區剔除號碼
            // 
            this.lbl二區剔除號碼.AutoSize = true;
            this.lbl二區剔除號碼.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl二區剔除號碼.ForeColor = System.Drawing.Color.Coral;
            this.lbl二區剔除號碼.Location = new System.Drawing.Point(555, 430);
            this.lbl二區剔除號碼.Name = "lbl二區剔除號碼";
            this.lbl二區剔除號碼.Size = new System.Drawing.Size(26, 27);
            this.lbl二區剔除號碼.TabIndex = 13;
            this.lbl二區剔除號碼.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "第一選區";
            // 
            // lbl包含號碼2
            // 
            this.lbl包含號碼2.AutoSize = true;
            this.lbl包含號碼2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl包含號碼2.ForeColor = System.Drawing.Color.Blue;
            this.lbl包含號碼2.Location = new System.Drawing.Point(183, 379);
            this.lbl包含號碼2.Name = "lbl包含號碼2";
            this.lbl包含號碼2.Size = new System.Drawing.Size(26, 27);
            this.lbl包含號碼2.TabIndex = 11;
            this.lbl包含號碼2.Text = "0";
            // 
            // btn剔除號碼
            // 
            this.btn剔除號碼.BackColor = System.Drawing.Color.HotPink;
            this.btn剔除號碼.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn剔除號碼.Location = new System.Drawing.Point(13, 427);
            this.btn剔除號碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn剔除號碼.Name = "btn剔除號碼";
            this.btn剔除號碼.Size = new System.Drawing.Size(149, 37);
            this.btn剔除號碼.TabIndex = 10;
            this.btn剔除號碼.Text = "剔除選號";
            this.btn剔除號碼.UseVisualStyleBackColor = false;
            this.btn剔除號碼.Click += new System.EventHandler(this.btn剔除號碼_Click);
            // 
            // btn包含號碼
            // 
            this.btn包含號碼.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn包含號碼.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn包含號碼.Location = new System.Drawing.Point(13, 379);
            this.btn包含號碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn包含號碼.Name = "btn包含號碼";
            this.btn包含號碼.Size = new System.Drawing.Size(149, 37);
            this.btn包含號碼.TabIndex = 9;
            this.btn包含號碼.Text = "包含選號";
            this.btn包含號碼.UseVisualStyleBackColor = false;
            this.btn包含號碼.Click += new System.EventHandler(this.btn包含號碼_Click);
            // 
            // lbl剔除號碼
            // 
            this.lbl剔除號碼.AutoSize = true;
            this.lbl剔除號碼.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl剔除號碼.ForeColor = System.Drawing.Color.Red;
            this.lbl剔除號碼.Location = new System.Drawing.Point(183, 433);
            this.lbl剔除號碼.Name = "lbl剔除號碼";
            this.lbl剔除號碼.Size = new System.Drawing.Size(26, 27);
            this.lbl剔除號碼.TabIndex = 8;
            this.lbl剔除號碼.Text = "0";
            // 
            // lbl包含號碼
            // 
            this.lbl包含號碼.AutoSize = true;
            this.lbl包含號碼.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl包含號碼.ForeColor = System.Drawing.Color.Blue;
            this.lbl包含號碼.Location = new System.Drawing.Point(183, 345);
            this.lbl包含號碼.Name = "lbl包含號碼";
            this.lbl包含號碼.Size = new System.Drawing.Size(0, 35);
            this.lbl包含號碼.TabIndex = 7;
            // 
            // textBox包牌數量
            // 
            this.textBox包牌數量.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox包牌數量.Location = new System.Drawing.Point(894, 330);
            this.textBox包牌數量.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox包牌數量.Name = "textBox包牌數量";
            this.textBox包牌數量.Size = new System.Drawing.Size(120, 43);
            this.textBox包牌數量.TabIndex = 6;
            this.textBox包牌數量.Text = "0";
            // 
            // btn包牌
            // 
            this.btn包牌.BackColor = System.Drawing.Color.Plum;
            this.btn包牌.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn包牌.Location = new System.Drawing.Point(1021, 326);
            this.btn包牌.Margin = new System.Windows.Forms.Padding(4);
            this.btn包牌.Name = "btn包牌";
            this.btn包牌.Size = new System.Drawing.Size(155, 51);
            this.btn包牌.TabIndex = 3;
            this.btn包牌.Text = "包牌數量";
            this.btn包牌.UseVisualStyleBackColor = false;
            this.btn包牌.Click += new System.EventHandler(this.btn包牌_Click);
            // 
            // lbox包牌紀錄
            // 
            this.lbox包牌紀錄.BackColor = System.Drawing.Color.SeaShell;
            this.lbox包牌紀錄.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox包牌紀錄.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbox包牌紀錄.FormattingEnabled = true;
            this.lbox包牌紀錄.ItemHeight = 34;
            this.lbox包牌紀錄.Location = new System.Drawing.Point(628, 31);
            this.lbox包牌紀錄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox包牌紀錄.Name = "lbox包牌紀錄";
            this.lbox包牌紀錄.Size = new System.Drawing.Size(441, 276);
            this.lbox包牌紀錄.TabIndex = 2;
            // 
            // tab對獎
            // 
            this.tab對獎.BackColor = System.Drawing.Color.SeaShell;
            this.tab對獎.Controls.Add(this.lbl購買期數);
            this.tab對獎.Controls.Add(this.lbl開獎期數);
            this.tab對獎.Controls.Add(this.lbl期數);
            this.tab對獎.Controls.Add(this.btn開獎);
            this.tab對獎.Controls.Add(this.btn對獎);
            this.tab對獎.Controls.Add(this.lbox購買紀錄);
            this.tab對獎.Controls.Add(this.lblwinning7);
            this.tab對獎.Controls.Add(this.lblwinning6);
            this.tab對獎.Controls.Add(this.lblwinning5);
            this.tab對獎.Controls.Add(this.lblwinning4);
            this.tab對獎.Controls.Add(this.lblwinning3);
            this.tab對獎.Controls.Add(this.lblwinning2);
            this.tab對獎.Controls.Add(this.lblwinning1);
            this.tab對獎.Controls.Add(this.lbox對獎紀錄);
            this.tab對獎.Location = new System.Drawing.Point(4, 34);
            this.tab對獎.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab對獎.Name = "tab對獎";
            this.tab對獎.Size = new System.Drawing.Size(1183, 470);
            this.tab對獎.TabIndex = 2;
            this.tab對獎.Text = "對獎";
            // 
            // lbl購買期數
            // 
            this.lbl購買期數.AutoSize = true;
            this.lbl購買期數.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl購買期數.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl購買期數.Location = new System.Drawing.Point(4, 98);
            this.lbl購買期數.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl購買期數.Name = "lbl購買期數";
            this.lbl購買期數.Size = new System.Drawing.Size(199, 32);
            this.lbl購買期數.TabIndex = 24;
            this.lbl購買期數.Text = "購買期數第0期";
            // 
            // lbl開獎期數
            // 
            this.lbl開獎期數.AutoSize = true;
            this.lbl開獎期數.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl開獎期數.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl開獎期數.Location = new System.Drawing.Point(45, 22);
            this.lbl開獎期數.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl開獎期數.Name = "lbl開獎期數";
            this.lbl開獎期數.Size = new System.Drawing.Size(199, 32);
            this.lbl開獎期數.TabIndex = 23;
            this.lbl開獎期數.Text = "開獎期數第0期";
            // 
            // lbl期數
            // 
            this.lbl期數.AutoSize = true;
            this.lbl期數.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl期數.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl期數.Location = new System.Drawing.Point(566, 98);
            this.lbl期數.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl期數.Name = "lbl期數";
            this.lbl期數.Size = new System.Drawing.Size(87, 32);
            this.lbl期數.TabIndex = 22;
            this.lbl期數.Text = "第0期";
            // 
            // btn開獎
            // 
            this.btn開獎.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn開獎.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn開獎.Location = new System.Drawing.Point(1044, 8);
            this.btn開獎.Margin = new System.Windows.Forms.Padding(4);
            this.btn開獎.Name = "btn開獎";
            this.btn開獎.Size = new System.Drawing.Size(132, 76);
            this.btn開獎.TabIndex = 21;
            this.btn開獎.Text = "開獎";
            this.btn開獎.UseVisualStyleBackColor = false;
            this.btn開獎.Click += new System.EventHandler(this.btn開獎_Click);
            // 
            // btn對獎
            // 
            this.btn對獎.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn對獎.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn對獎.Location = new System.Drawing.Point(381, 234);
            this.btn對獎.Margin = new System.Windows.Forms.Padding(4);
            this.btn對獎.Name = "btn對獎";
            this.btn對獎.Size = new System.Drawing.Size(170, 89);
            this.btn對獎.TabIndex = 20;
            this.btn對獎.Text = "對獎確認-->";
            this.btn對獎.UseVisualStyleBackColor = false;
            this.btn對獎.Click += new System.EventHandler(this.btn對獎_Click);
            // 
            // lbox購買紀錄
            // 
            this.lbox購買紀錄.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbox購買紀錄.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox購買紀錄.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbox購買紀錄.FormattingEnabled = true;
            this.lbox購買紀錄.ItemHeight = 34;
            this.lbox購買紀錄.Location = new System.Drawing.Point(15, 134);
            this.lbox購買紀錄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox購買紀錄.Name = "lbox購買紀錄";
            this.lbox購買紀錄.Size = new System.Drawing.Size(335, 310);
            this.lbox購買紀錄.TabIndex = 19;
            // 
            // lblwinning7
            // 
            this.lblwinning7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblwinning7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning7.Location = new System.Drawing.Point(935, 18);
            this.lblwinning7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning7.Name = "lblwinning7";
            this.lblwinning7.Size = new System.Drawing.Size(80, 50);
            this.lblwinning7.TabIndex = 18;
            this.lblwinning7.Text = "0";
            this.lblwinning7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwinning6
            // 
            this.lblwinning6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblwinning6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning6.Location = new System.Drawing.Point(824, 18);
            this.lblwinning6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning6.Name = "lblwinning6";
            this.lblwinning6.Size = new System.Drawing.Size(80, 50);
            this.lblwinning6.TabIndex = 17;
            this.lblwinning6.Text = "0";
            this.lblwinning6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwinning5
            // 
            this.lblwinning5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblwinning5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning5.Location = new System.Drawing.Point(719, 18);
            this.lblwinning5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning5.Name = "lblwinning5";
            this.lblwinning5.Size = new System.Drawing.Size(80, 50);
            this.lblwinning5.TabIndex = 16;
            this.lblwinning5.Text = "0";
            this.lblwinning5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwinning4
            // 
            this.lblwinning4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblwinning4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning4.Location = new System.Drawing.Point(612, 18);
            this.lblwinning4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning4.Name = "lblwinning4";
            this.lblwinning4.Size = new System.Drawing.Size(80, 50);
            this.lblwinning4.TabIndex = 15;
            this.lblwinning4.Text = "0";
            this.lblwinning4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwinning3
            // 
            this.lblwinning3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblwinning3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning3.Location = new System.Drawing.Point(501, 18);
            this.lblwinning3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning3.Name = "lblwinning3";
            this.lblwinning3.Size = new System.Drawing.Size(80, 50);
            this.lblwinning3.TabIndex = 14;
            this.lblwinning3.Text = "0";
            this.lblwinning3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwinning2
            // 
            this.lblwinning2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblwinning2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning2.Location = new System.Drawing.Point(390, 18);
            this.lblwinning2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning2.Name = "lblwinning2";
            this.lblwinning2.Size = new System.Drawing.Size(80, 50);
            this.lblwinning2.TabIndex = 13;
            this.lblwinning2.Text = "0";
            this.lblwinning2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwinning1
            // 
            this.lblwinning1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblwinning1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinning1.Location = new System.Drawing.Point(275, 18);
            this.lblwinning1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinning1.Name = "lblwinning1";
            this.lblwinning1.Size = new System.Drawing.Size(80, 50);
            this.lblwinning1.TabIndex = 12;
            this.lblwinning1.Text = "0";
            this.lblwinning1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbox對獎紀錄
            // 
            this.lbox對獎紀錄.BackColor = System.Drawing.Color.PowderBlue;
            this.lbox對獎紀錄.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox對獎紀錄.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbox對獎紀錄.FormattingEnabled = true;
            this.lbox對獎紀錄.ItemHeight = 29;
            this.lbox對獎紀錄.Location = new System.Drawing.Point(572, 134);
            this.lbox對獎紀錄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbox對獎紀錄.Name = "lbox對獎紀錄";
            this.lbox對獎紀錄.Size = new System.Drawing.Size(595, 294);
            this.lbox對獎紀錄.TabIndex = 3;
            // 
            // tab歷史紀錄
            // 
            this.tab歷史紀錄.BackColor = System.Drawing.Color.Plum;
            this.tab歷史紀錄.Controls.Add(this.label3);
            this.tab歷史紀錄.Controls.Add(this.lbox歷史得獎紀錄);
            this.tab歷史紀錄.Location = new System.Drawing.Point(4, 34);
            this.tab歷史紀錄.Name = "tab歷史紀錄";
            this.tab歷史紀錄.Size = new System.Drawing.Size(1183, 470);
            this.tab歷史紀錄.TabIndex = 3;
            this.tab歷史紀錄.Text = "歷史紀錄";
            // 
            // lbox歷史得獎紀錄
            // 
            this.lbox歷史得獎紀錄.BackColor = System.Drawing.Color.Lavender;
            this.lbox歷史得獎紀錄.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox歷史得獎紀錄.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbox歷史得獎紀錄.FormattingEnabled = true;
            this.lbox歷史得獎紀錄.ItemHeight = 50;
            this.lbox歷史得獎紀錄.Location = new System.Drawing.Point(60, 86);
            this.lbox歷史得獎紀錄.Name = "lbox歷史得獎紀錄";
            this.lbox歷史得獎紀錄.Size = new System.Drawing.Size(1061, 354);
            this.lbox歷史得獎紀錄.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "歷史得獎紀錄";
            // 
            // btn刪除所有號碼
            // 
            this.btn刪除所有號碼.BackColor = System.Drawing.Color.LightPink;
            this.btn刪除所有號碼.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn刪除所有號碼.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn刪除所有號碼.Location = new System.Drawing.Point(942, 396);
            this.btn刪除所有號碼.Margin = new System.Windows.Forms.Padding(4);
            this.btn刪除所有號碼.Name = "btn刪除所有號碼";
            this.btn刪除所有號碼.Size = new System.Drawing.Size(221, 59);
            this.btn刪除所有號碼.TabIndex = 18;
            this.btn刪除所有號碼.Text = "刪除所選號碼";
            this.btn刪除所有號碼.UseVisualStyleBackColor = false;
            this.btn刪除所有號碼.Click += new System.EventHandler(this.btn刪除所有號碼_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1215, 611);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "包你中(才怪)威力彩";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab選號.ResumeLayout(false);
            this.tab包牌.ResumeLayout(false);
            this.tab包牌.PerformLayout();
            this.tab對獎.ResumeLayout(false);
            this.tab對獎.PerformLayout();
            this.tab歷史紀錄.ResumeLayout(false);
            this.tab歷史紀錄.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn快選;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab選號;
        private System.Windows.Forms.TabPage tab包牌;
        private System.Windows.Forms.ListBox lbox選號紀錄;
        private System.Windows.Forms.Button btn加入選號紀錄;
        private System.Windows.Forms.Button btn包牌;
        private System.Windows.Forms.ListBox lbox包牌紀錄;
        private System.Windows.Forms.TextBox textBox包牌數量;
        private System.Windows.Forms.TabPage tab對獎;
        private System.Windows.Forms.Button btn對獎;
        private System.Windows.Forms.ListBox lbox購買紀錄;
        private System.Windows.Forms.Label lblwinning7;
        private System.Windows.Forms.Label lblwinning6;
        private System.Windows.Forms.Label lblwinning5;
        private System.Windows.Forms.Label lblwinning4;
        private System.Windows.Forms.Label lblwinning3;
        private System.Windows.Forms.Label lblwinning2;
        private System.Windows.Forms.Label lblwinning1;
        private System.Windows.Forms.ListBox lbox對獎紀錄;
        private System.Windows.Forms.Button btn包含號碼;
        private System.Windows.Forms.Label lbl剔除號碼;
        private System.Windows.Forms.Label lbl包含號碼;
        private System.Windows.Forms.Button btn剔除號碼;
        private System.Windows.Forms.Label lbl包含號碼2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl二區包含號碼;
        private System.Windows.Forms.Label lbl二區剔除號碼;
        private System.Windows.Forms.Button btn開獎;
        private System.Windows.Forms.Label lbl期數;
        private System.Windows.Forms.Button btn刪除所選號碼;
        private System.Windows.Forms.Label lbl購買期數;
        private System.Windows.Forms.Label lbl開獎期數;
        private System.Windows.Forms.TabPage tab歷史紀錄;
        private System.Windows.Forms.ListBox lbox歷史得獎紀錄;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn刪除所有號碼;
    }
}

