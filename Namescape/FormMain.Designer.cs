namespace Namescape
{
    partial class FormMain
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
            this.ui_groupBox_Setting = new System.Windows.Forms.GroupBox();
            this.ui_tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ui_miscSetting_Label = new System.Windows.Forms.Label();
            this.ui_charLength_Label = new System.Windows.Forms.Label();
            this.ui_flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ui_isSpacePermit = new System.Windows.Forms.CheckBox();
            this.ui_charLength = new System.Windows.Forms.NumericUpDown();
            this.ui_algorithmBox = new System.Windows.Forms.GroupBox();
            this.ui_algorithmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ui_algorithmRadio_Unicode = new System.Windows.Forms.RadioButton();
            this.ui_algorithmRadio_KoreanName = new System.Windows.Forms.RadioButton();
            this.ui_menuStrip = new System.Windows.Forms.MenuStrip();
            this.ui_HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ui_button_Create = new System.Windows.Forms.Button();
            this.ui_ResultBox = new System.Windows.Forms.RichTextBox();
            this.ui_contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ui_복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ui_groupBox_Setting.SuspendLayout();
            this.ui_tableLayoutPanel1.SuspendLayout();
            this.ui_flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_charLength)).BeginInit();
            this.ui_algorithmBox.SuspendLayout();
            this.ui_algorithmPanel.SuspendLayout();
            this.ui_menuStrip.SuspendLayout();
            this.ui_contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_groupBox_Setting
            // 
            this.ui_groupBox_Setting.Controls.Add(this.ui_tableLayoutPanel1);
            this.ui_groupBox_Setting.Location = new System.Drawing.Point(12, 140);
            this.ui_groupBox_Setting.Name = "ui_groupBox_Setting";
            this.ui_groupBox_Setting.Size = new System.Drawing.Size(466, 125);
            this.ui_groupBox_Setting.TabIndex = 2;
            this.ui_groupBox_Setting.TabStop = false;
            this.ui_groupBox_Setting.Text = "설정";
            // 
            // ui_tableLayoutPanel1
            // 
            this.ui_tableLayoutPanel1.ColumnCount = 2;
            this.ui_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ui_tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ui_tableLayoutPanel1.Controls.Add(this.ui_miscSetting_Label, 0, 1);
            this.ui_tableLayoutPanel1.Controls.Add(this.ui_charLength_Label, 0, 0);
            this.ui_tableLayoutPanel1.Controls.Add(this.ui_flowLayoutPanel1, 1, 1);
            this.ui_tableLayoutPanel1.Controls.Add(this.ui_charLength, 1, 0);
            this.ui_tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.ui_tableLayoutPanel1.Name = "ui_tableLayoutPanel1";
            this.ui_tableLayoutPanel1.RowCount = 2;
            this.ui_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.ui_tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ui_tableLayoutPanel1.Size = new System.Drawing.Size(454, 100);
            this.ui_tableLayoutPanel1.TabIndex = 0;
            // 
            // ui_miscSetting_Label
            // 
            this.ui_miscSetting_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_miscSetting_Label.AutoSize = true;
            this.ui_miscSetting_Label.Location = new System.Drawing.Point(3, 29);
            this.ui_miscSetting_Label.Name = "ui_miscSetting_Label";
            this.ui_miscSetting_Label.Size = new System.Drawing.Size(59, 71);
            this.ui_miscSetting_Label.TabIndex = 4;
            this.ui_miscSetting_Label.Text = "기타 설정";
            this.ui_miscSetting_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ui_charLength_Label
            // 
            this.ui_charLength_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_charLength_Label.AutoSize = true;
            this.ui_charLength_Label.Location = new System.Drawing.Point(3, 0);
            this.ui_charLength_Label.Name = "ui_charLength_Label";
            this.ui_charLength_Label.Size = new System.Drawing.Size(59, 29);
            this.ui_charLength_Label.TabIndex = 1;
            this.ui_charLength_Label.Text = "문자 갯수";
            this.ui_charLength_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ui_flowLayoutPanel1
            // 
            this.ui_flowLayoutPanel1.Controls.Add(this.ui_isSpacePermit);
            this.ui_flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ui_flowLayoutPanel1.Location = new System.Drawing.Point(68, 32);
            this.ui_flowLayoutPanel1.Name = "ui_flowLayoutPanel1";
            this.ui_flowLayoutPanel1.Size = new System.Drawing.Size(386, 65);
            this.ui_flowLayoutPanel1.TabIndex = 3;
            // 
            // ui_isSpacePermit
            // 
            this.ui_isSpacePermit.AutoSize = true;
            this.ui_isSpacePermit.Checked = true;
            this.ui_isSpacePermit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ui_isSpacePermit.Location = new System.Drawing.Point(3, 3);
            this.ui_isSpacePermit.Name = "ui_isSpacePermit";
            this.ui_isSpacePermit.Size = new System.Drawing.Size(102, 19);
            this.ui_isSpacePermit.TabIndex = 0;
            this.ui_isSpacePermit.Text = "띄어쓰기 허용";
            this.ui_toolTip.SetToolTip(this.ui_isSpacePermit, "특정 알고리즘에서 띄어쓰기를 허용합니다.");
            this.ui_isSpacePermit.UseVisualStyleBackColor = true;
            // 
            // ui_charLength
            // 
            this.ui_charLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ui_charLength.Location = new System.Drawing.Point(68, 3);
            this.ui_charLength.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ui_charLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_charLength.Name = "ui_charLength";
            this.ui_charLength.Size = new System.Drawing.Size(386, 23);
            this.ui_charLength.TabIndex = 0;
            this.ui_charLength.ThousandsSeparator = true;
            this.ui_toolTip.SetToolTip(this.ui_charLength, "생성될 글자의 길이를 설정합니다.");
            this.ui_charLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ui_algorithmBox
            // 
            this.ui_algorithmBox.Controls.Add(this.ui_algorithmPanel);
            this.ui_algorithmBox.Location = new System.Drawing.Point(12, 27);
            this.ui_algorithmBox.Name = "ui_algorithmBox";
            this.ui_algorithmBox.Size = new System.Drawing.Size(466, 107);
            this.ui_algorithmBox.TabIndex = 1;
            this.ui_algorithmBox.TabStop = false;
            this.ui_algorithmBox.Text = "알고리즘";
            // 
            // ui_algorithmPanel
            // 
            this.ui_algorithmPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ui_algorithmPanel.Controls.Add(this.ui_algorithmRadio_Unicode);
            this.ui_algorithmPanel.Controls.Add(this.ui_algorithmRadio_KoreanName);
            this.ui_algorithmPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ui_algorithmPanel.Location = new System.Drawing.Point(7, 23);
            this.ui_algorithmPanel.Name = "ui_algorithmPanel";
            this.ui_algorithmPanel.Size = new System.Drawing.Size(453, 78);
            this.ui_algorithmPanel.TabIndex = 0;
            // 
            // ui_algorithmRadio_Unicode
            // 
            this.ui_algorithmRadio_Unicode.AutoSize = true;
            this.ui_algorithmRadio_Unicode.Location = new System.Drawing.Point(3, 3);
            this.ui_algorithmRadio_Unicode.Name = "ui_algorithmRadio_Unicode";
            this.ui_algorithmRadio_Unicode.Size = new System.Drawing.Size(73, 19);
            this.ui_algorithmRadio_Unicode.TabIndex = 1;
            this.ui_algorithmRadio_Unicode.TabStop = true;
            this.ui_algorithmRadio_Unicode.Text = "유니코드";
            this.ui_toolTip.SetToolTip(this.ui_algorithmRadio_Unicode, "유니코드에있는 모든 한글을 랜덤으로 조합합니다.");
            this.ui_algorithmRadio_Unicode.UseVisualStyleBackColor = true;
            // 
            // ui_algorithmRadio_KoreanName
            // 
            this.ui_algorithmRadio_KoreanName.AutoSize = true;
            this.ui_algorithmRadio_KoreanName.Location = new System.Drawing.Point(3, 28);
            this.ui_algorithmRadio_KoreanName.Name = "ui_algorithmRadio_KoreanName";
            this.ui_algorithmRadio_KoreanName.Size = new System.Drawing.Size(77, 19);
            this.ui_algorithmRadio_KoreanName.TabIndex = 2;
            this.ui_algorithmRadio_KoreanName.TabStop = true;
            this.ui_algorithmRadio_KoreanName.Text = "한자 이름";
            this.ui_toolTip.SetToolTip(this.ui_algorithmRadio_KoreanName, "인명용 한자표에 나와있는 한자들을 한글로 옮겨 랜덤으로 조합합니다.");
            this.ui_algorithmRadio_KoreanName.UseVisualStyleBackColor = true;
            // 
            // ui_menuStrip
            // 
            this.ui_menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.ui_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ui_HelpToolStripMenuItem});
            this.ui_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.ui_menuStrip.Name = "ui_menuStrip";
            this.ui_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ui_menuStrip.Size = new System.Drawing.Size(490, 24);
            this.ui_menuStrip.TabIndex = 3;
            this.ui_menuStrip.Text = "menuStrip1";
            // 
            // ui_HelpToolStripMenuItem
            // 
            this.ui_HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ui_toolStripMenuItem1});
            this.ui_HelpToolStripMenuItem.Name = "ui_HelpToolStripMenuItem";
            this.ui_HelpToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.ui_HelpToolStripMenuItem.Text = "제작자 정보(&A)";
            this.ui_HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // ui_toolStripMenuItem1
            // 
            this.ui_toolStripMenuItem1.Name = "ui_toolStripMenuItem1";
            this.ui_toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // ui_toolTip
            // 
            this.ui_toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ui_toolTip.ToolTipTitle = "도움말";
            // 
            // ui_button_Create
            // 
            this.ui_button_Create.Location = new System.Drawing.Point(12, 271);
            this.ui_button_Create.Name = "ui_button_Create";
            this.ui_button_Create.Size = new System.Drawing.Size(466, 37);
            this.ui_button_Create.TabIndex = 4;
            this.ui_button_Create.Text = "생성";
            this.ui_toolTip.SetToolTip(this.ui_button_Create, "설정된 값에 따라 이름을 생성하고 클립보드에 추가합니다.");
            this.ui_button_Create.UseVisualStyleBackColor = true;
            this.ui_button_Create.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // ui_ResultBox
            // 
            this.ui_ResultBox.ContextMenuStrip = this.ui_contextMenuStrip1;
            this.ui_ResultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ui_ResultBox.DetectUrls = false;
            this.ui_ResultBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_ResultBox.Location = new System.Drawing.Point(12, 314);
            this.ui_ResultBox.Name = "ui_ResultBox";
            this.ui_ResultBox.ReadOnly = true;
            this.ui_ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ui_ResultBox.Size = new System.Drawing.Size(466, 124);
            this.ui_ResultBox.TabIndex = 5;
            this.ui_ResultBox.Text = "";
            this.ui_toolTip.SetToolTip(this.ui_ResultBox, "생성된 이름은 이곳에 표시됩니다.");
            // 
            // ui_contextMenuStrip1
            // 
            this.ui_contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ui_복사ToolStripMenuItem});
            this.ui_contextMenuStrip1.Name = "contextMenuStrip1";
            this.ui_contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // ui_복사ToolStripMenuItem
            // 
            this.ui_복사ToolStripMenuItem.Name = "ui_복사ToolStripMenuItem";
            this.ui_복사ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ui_복사ToolStripMenuItem.Text = "복사(&C)";
            // 
            // FormMain
            // 
            this.AcceptButton = this.ui_button_Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.ui_ResultBox);
            this.Controls.Add(this.ui_button_Create);
            this.Controls.Add(this.ui_algorithmBox);
            this.Controls.Add(this.ui_groupBox_Setting);
            this.Controls.Add(this.ui_menuStrip);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.ui_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "네임스케이프";
            this.Load += new System.EventHandler(this.CNG_Form_Load);
            this.ui_groupBox_Setting.ResumeLayout(false);
            this.ui_tableLayoutPanel1.ResumeLayout(false);
            this.ui_tableLayoutPanel1.PerformLayout();
            this.ui_flowLayoutPanel1.ResumeLayout(false);
            this.ui_flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_charLength)).EndInit();
            this.ui_algorithmBox.ResumeLayout(false);
            this.ui_algorithmPanel.ResumeLayout(false);
            this.ui_algorithmPanel.PerformLayout();
            this.ui_menuStrip.ResumeLayout(false);
            this.ui_menuStrip.PerformLayout();
            this.ui_contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ui_groupBox_Setting;
        private System.Windows.Forms.Label ui_charLength_Label;
        private System.Windows.Forms.NumericUpDown ui_charLength;
        private System.Windows.Forms.GroupBox ui_algorithmBox;
        private System.Windows.Forms.FlowLayoutPanel ui_algorithmPanel;
        private System.Windows.Forms.MenuStrip ui_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ui_HelpToolStripMenuItem;
        private System.Windows.Forms.ToolTip ui_toolTip;
        private System.Windows.Forms.RadioButton ui_algorithmRadio_Unicode;
        private System.Windows.Forms.Button ui_button_Create;
        private System.Windows.Forms.RichTextBox ui_ResultBox;
        private System.Windows.Forms.TableLayoutPanel ui_tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel ui_flowLayoutPanel1;
        private System.Windows.Forms.CheckBox ui_isSpacePermit;
        private System.Windows.Forms.Label ui_miscSetting_Label;
        private System.Windows.Forms.ContextMenuStrip ui_contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ui_복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ui_toolStripMenuItem1;
        private System.Windows.Forms.RadioButton ui_algorithmRadio_KoreanName;
    }
}