namespace VeterinerUygulama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            this.panelRoot = new System.Windows.Forms.Panel();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelGridHost = new VeterinerUygulama.Controls.ThemePanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFormHost = new VeterinerUygulama.Controls.ThemePanel();
            this.tableForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblHayvanAdi = new System.Windows.Forms.Label();
            this.hostText1 = new VeterinerUygulama.Controls.InputFieldPanel();
            this.textBox1 = new VeterinerUygulama.Controls.ModernTextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.hostText2 = new VeterinerUygulama.Controls.InputFieldPanel();
            this.textBox2 = new VeterinerUygulama.Controls.ModernTextBox();
            this.lblSahip = new System.Windows.Forms.Label();
            this.hostText3 = new VeterinerUygulama.Controls.InputFieldPanel();
            this.textBox3 = new VeterinerUygulama.Controls.ModernTextBox();
            this.checkBox1 = new VeterinerUygulama.Controls.ModernCheckBox();
            this.tableActions = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new VeterinerUygulama.Controls.GlowButton();
            this.button3 = new VeterinerUygulama.Controls.GlowButton();
            this.button2 = new VeterinerUygulama.Controls.GlowButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelAccentLine = new System.Windows.Forms.Panel();
            this.panelRoot.SuspendLayout();
            this.tableMain.SuspendLayout();
            this.panelGridHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormHost.SuspendLayout();
            this.tableForm.SuspendLayout();
            this.hostText1.SuspendLayout();
            this.hostText2.SuspendLayout();
            this.hostText3.SuspendLayout();
            this.tableActions.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoot
            // 
            this.panelRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.panelRoot.Controls.Add(this.tableMain);
            this.panelRoot.Controls.Add(this.panelHeader);
            this.panelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoot.Location = new System.Drawing.Point(0, 0);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.panelRoot.Size = new System.Drawing.Size(1184, 721);
            this.panelRoot.TabIndex = 0;
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableMain.Controls.Add(this.panelGridHost, 0, 0);
            this.tableMain.Controls.Add(this.panelFormHost, 1, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(20, 92);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1144, 609);
            this.tableMain.TabIndex = 1;
            // 
            // panelGridHost
            // 
            this.panelGridHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelGridHost.Controls.Add(this.dataGridView1);
            this.panelGridHost.CornerRadius = 10;
            this.panelGridHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridHost.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.panelGridHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.panelGridHost.HeaderText = "Kayıt listesi";
            this.panelGridHost.Location = new System.Drawing.Point(8, 8);
            this.panelGridHost.Margin = new System.Windows.Forms.Padding(8);
            this.panelGridHost.Name = "panelGridHost";
            this.panelGridHost.Padding = new System.Windows.Forms.Padding(14, 48, 14, 14);
            this.panelGridHost.ShowHeader = true;
            this.panelGridHost.Size = new System.Drawing.Size(647, 593);
            this.panelGridHost.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(14, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 531);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelFormHost
            // 
            this.panelFormHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panelFormHost.Controls.Add(this.tableForm);
            this.panelFormHost.CornerRadius = 10;
            this.panelFormHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormHost.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.panelFormHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.panelFormHost.HeaderText = "Kayıt formu";
            this.panelFormHost.Location = new System.Drawing.Point(671, 8);
            this.panelFormHost.Margin = new System.Windows.Forms.Padding(8);
            this.panelFormHost.Name = "panelFormHost";
            this.panelFormHost.Padding = new System.Windows.Forms.Padding(14, 48, 14, 14);
            this.panelFormHost.ShowHeader = true;
            this.panelFormHost.Size = new System.Drawing.Size(465, 593);
            this.panelFormHost.TabIndex = 1;
            // 
            // tableForm
            // 
            this.tableForm.ColumnCount = 1;
            this.tableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableForm.Controls.Add(this.lblHayvanAdi, 0, 0);
            this.tableForm.Controls.Add(this.hostText1, 0, 1);
            this.tableForm.Controls.Add(this.lblTur, 0, 2);
            this.tableForm.Controls.Add(this.hostText2, 0, 3);
            this.tableForm.Controls.Add(this.lblSahip, 0, 4);
            this.tableForm.Controls.Add(this.hostText3, 0, 5);
            this.tableForm.Controls.Add(this.checkBox1, 0, 6);
            this.tableForm.Controls.Add(this.tableActions, 0, 7);
            this.tableForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableForm.Location = new System.Drawing.Point(14, 48);
            this.tableForm.Name = "tableForm";
            this.tableForm.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableForm.RowCount = 8;
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableForm.Size = new System.Drawing.Size(437, 531);
            this.tableForm.TabIndex = 0;
            // 
            // lblHayvanAdi
            // 
            this.lblHayvanAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHayvanAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblHayvanAdi.Location = new System.Drawing.Point(3, 7);
            this.lblHayvanAdi.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblHayvanAdi.Name = "lblHayvanAdi";
            this.lblHayvanAdi.Size = new System.Drawing.Size(431, 23);
            this.lblHayvanAdi.TabIndex = 0;
            this.lblHayvanAdi.Text = "Evcil hayvan adı";
            this.lblHayvanAdi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hostText1
            // 
            this.hostText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.hostText1.Controls.Add(this.textBox1);
            this.hostText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostText1.Location = new System.Drawing.Point(3, 33);
            this.hostText1.Name = "hostText1";
            this.hostText1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.hostText1.Size = new System.Drawing.Size(431, 36);
            this.hostText1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.textBox1.Location = new System.Drawing.Point(10, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 18);
            this.textBox1.TabIndex = 0;
            // 
            // lblTur
            // 
            this.lblTur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblTur.Location = new System.Drawing.Point(3, 75);
            this.lblTur.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(431, 23);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Tür";
            this.lblTur.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hostText2
            // 
            this.hostText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.hostText2.Controls.Add(this.textBox2);
            this.hostText2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostText2.Location = new System.Drawing.Point(3, 101);
            this.hostText2.Name = "hostText2";
            this.hostText2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.hostText2.Size = new System.Drawing.Size(431, 36);
            this.hostText2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.textBox2.Location = new System.Drawing.Point(10, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(411, 18);
            this.textBox2.TabIndex = 0;
            // 
            // lblSahip
            // 
            this.lblSahip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSahip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblSahip.Location = new System.Drawing.Point(3, 143);
            this.lblSahip.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblSahip.Name = "lblSahip";
            this.lblSahip.Size = new System.Drawing.Size(431, 23);
            this.lblSahip.TabIndex = 4;
            this.lblSahip.Text = "Sahibin adı";
            this.lblSahip.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hostText3
            // 
            this.hostText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.hostText3.Controls.Add(this.textBox3);
            this.hostText3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostText3.Location = new System.Drawing.Point(3, 169);
            this.hostText3.Name = "hostText3";
            this.hostText3.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.hostText3.Size = new System.Drawing.Size(431, 36);
            this.hostText3.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.textBox3.Location = new System.Drawing.Point(10, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(411, 18);
            this.textBox3.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.checkBox1.Location = new System.Drawing.Point(3, 212);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.MinimumSize = new System.Drawing.Size(0, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.checkBox1.Size = new System.Drawing.Size(431, 36);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Aşı durumu tamam";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // tableActions
            // 
            this.tableActions.ColumnCount = 3;
            this.tableActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableActions.Controls.Add(this.button1, 0, 0);
            this.tableActions.Controls.Add(this.button3, 1, 0);
            this.tableActions.Controls.Add(this.button2, 2, 0);
            this.tableActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableActions.Location = new System.Drawing.Point(3, 255);
            this.tableActions.MinimumSize = new System.Drawing.Size(0, 52);
            this.tableActions.Name = "tableActions";
            this.tableActions.RowCount = 1;
            this.tableActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableActions.Size = new System.Drawing.Size(431, 273);
            this.tableActions.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(212)))), ((int)(((byte)(170)))));
            this.button1.CornerRadius = 8;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 6, 5, 3);
            this.button1.MinimumSize = new System.Drawing.Size(72, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 264);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.button3.CornerRadius = 8;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(146, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 6, 5, 3);
            this.button3.MinimumSize = new System.Drawing.Size(72, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 264);
            this.button3.TabIndex = 1;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.button2.CornerRadius = 8;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.button2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.button2.Location = new System.Drawing.Point(289, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.button2.MinimumSize = new System.Drawing.Size(72, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 264);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.panelAccentLine);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(20, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(0, 16, 0, 10);
            this.panelHeader.Size = new System.Drawing.Size(1144, 92);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblSubtitle.Location = new System.Drawing.Point(16, 54);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(159, 15);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Evcil hayvan kayıtlarını yönet";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Veteriner Kayıt";
            // 
            // panelAccentLine
            // 
            this.panelAccentLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.panelAccentLine.Location = new System.Drawing.Point(0, 22);
            this.panelAccentLine.Name = "panelAccentLine";
            this.panelAccentLine.Size = new System.Drawing.Size(4, 32);
            this.panelAccentLine.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.panelRoot);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veteriner Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRoot.ResumeLayout(false);
            this.tableMain.ResumeLayout(false);
            this.panelGridHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormHost.ResumeLayout(false);
            this.tableForm.ResumeLayout(false);
            this.hostText1.ResumeLayout(false);
            this.hostText1.PerformLayout();
            this.hostText2.ResumeLayout(false);
            this.hostText2.PerformLayout();
            this.hostText3.ResumeLayout(false);
            this.hostText3.PerformLayout();
            this.tableActions.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelAccentLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private Controls.ThemePanel panelGridHost;
        private Controls.ThemePanel panelFormHost;
        private System.Windows.Forms.TableLayoutPanel tableForm;
        private System.Windows.Forms.Label lblHayvanAdi;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblSahip;
        private Controls.InputFieldPanel hostText1;
        private Controls.InputFieldPanel hostText2;
        private Controls.InputFieldPanel hostText3;
        private Controls.ModernTextBox textBox1;
        private Controls.ModernTextBox textBox2;
        private Controls.ModernTextBox textBox3;
        private Controls.ModernCheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableActions;
        private Controls.GlowButton button1;
        private Controls.GlowButton button2;
        private Controls.GlowButton button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
