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
            this.groupBox_Setting = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.miscSetting_Label = new System.Windows.Forms.Label();
            this.charLength_Label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.isSpacePermit = new System.Windows.Forms.CheckBox();
            this.charLength = new System.Windows.Forms.NumericUpDown();
            this.algorithmBox = new System.Windows.Forms.GroupBox();
            this.algorithmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.algorithmRadio_Unicode = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button_Create = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Setting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charLength)).BeginInit();
            this.algorithmBox.SuspendLayout();
            this.algorithmPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Setting
            // 
            this.groupBox_Setting.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_Setting.Location = new System.Drawing.Point(12, 140);
            this.groupBox_Setting.Name = "groupBox_Setting";
            this.groupBox_Setting.Size = new System.Drawing.Size(466, 125);
            this.groupBox_Setting.TabIndex = 2;
            this.groupBox_Setting.TabStop = false;
            this.groupBox_Setting.Text = "설정";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.miscSetting_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.charLength_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.charLength, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // miscSetting_Label
            // 
            this.miscSetting_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miscSetting_Label.AutoSize = true;
            this.miscSetting_Label.Location = new System.Drawing.Point(3, 29);
            this.miscSetting_Label.Name = "miscSetting_Label";
            this.miscSetting_Label.Size = new System.Drawing.Size(59, 71);
            this.miscSetting_Label.TabIndex = 4;
            this.miscSetting_Label.Text = "기타 설정";
            this.miscSetting_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charLength_Label
            // 
            this.charLength_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charLength_Label.AutoSize = true;
            this.charLength_Label.Location = new System.Drawing.Point(3, 0);
            this.charLength_Label.Name = "charLength_Label";
            this.charLength_Label.Size = new System.Drawing.Size(59, 29);
            this.charLength_Label.TabIndex = 1;
            this.charLength_Label.Text = "문자 갯수";
            this.charLength_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.isSpacePermit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(68, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 65);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // isSpacePermit
            // 
            this.isSpacePermit.AutoSize = true;
            this.isSpacePermit.Checked = true;
            this.isSpacePermit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isSpacePermit.Location = new System.Drawing.Point(3, 3);
            this.isSpacePermit.Name = "isSpacePermit";
            this.isSpacePermit.Size = new System.Drawing.Size(102, 19);
            this.isSpacePermit.TabIndex = 0;
            this.isSpacePermit.Text = "띄어쓰기 허용";
            this.toolTip.SetToolTip(this.isSpacePermit, "특정 알고리즘에서 띄어쓰기를 허용합니다.");
            this.isSpacePermit.UseVisualStyleBackColor = true;
            // 
            // charLength
            // 
            this.charLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.charLength.Location = new System.Drawing.Point(68, 3);
            this.charLength.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.charLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.charLength.Name = "charLength";
            this.charLength.Size = new System.Drawing.Size(386, 23);
            this.charLength.TabIndex = 0;
            this.charLength.ThousandsSeparator = true;
            this.toolTip.SetToolTip(this.charLength, "생성될 글자의 길이를 설정합니다.");
            this.charLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // algorithmBox
            // 
            this.algorithmBox.Controls.Add(this.algorithmPanel);
            this.algorithmBox.Location = new System.Drawing.Point(12, 27);
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size(466, 107);
            this.algorithmBox.TabIndex = 1;
            this.algorithmBox.TabStop = false;
            this.algorithmBox.Text = "알고리즘";
            // 
            // algorithmPanel
            // 
            this.algorithmPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algorithmPanel.Controls.Add(this.algorithmRadio_Unicode);
            this.algorithmPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.algorithmPanel.Location = new System.Drawing.Point(7, 23);
            this.algorithmPanel.Name = "algorithmPanel";
            this.algorithmPanel.Size = new System.Drawing.Size(453, 78);
            this.algorithmPanel.TabIndex = 0;
            // 
            // algorithmRadio_Unicode
            // 
            this.algorithmRadio_Unicode.AutoSize = true;
            this.algorithmRadio_Unicode.Location = new System.Drawing.Point(3, 3);
            this.algorithmRadio_Unicode.Name = "algorithmRadio_Unicode";
            this.algorithmRadio_Unicode.Size = new System.Drawing.Size(73, 19);
            this.algorithmRadio_Unicode.TabIndex = 1;
            this.algorithmRadio_Unicode.TabStop = true;
            this.algorithmRadio_Unicode.Text = "유니코드";
            this.toolTip.SetToolTip(this.algorithmRadio_Unicode, "유니코드에있는 모든 한글을 랜덤으로 조합합니다.");
            this.algorithmRadio_Unicode.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(490, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.HelpToolStripMenuItem.Text = "제작자 정보(&A)";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "도움말";
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(12, 271);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(466, 37);
            this.button_Create.TabIndex = 4;
            this.button_Create.Text = "생성";
            this.toolTip.SetToolTip(this.button_Create, "설정된 값에 따라 이름을 생성하고 클립보드에 추가합니다.");
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.ContextMenuStrip = this.contextMenuStrip1;
            this.ResultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResultBox.DetectUrls = false;
            this.ResultBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultBox.Location = new System.Drawing.Point(12, 314);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(466, 124);
            this.ResultBox.TabIndex = 5;
            this.ResultBox.Text = "";
            this.toolTip.SetToolTip(this.ResultBox, "생성된 이름은 이곳에 표시됩니다.");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.복사ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.복사ToolStripMenuItem.Text = "복사(&C)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.algorithmBox);
            this.Controls.Add(this.groupBox_Setting);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "네임스케이프";
            this.Load += new System.EventHandler(this.CNG_Form_Load);
            this.groupBox_Setting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charLength)).EndInit();
            this.algorithmBox.ResumeLayout(false);
            this.algorithmPanel.ResumeLayout(false);
            this.algorithmPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Setting;
        private System.Windows.Forms.Label charLength_Label;
        private System.Windows.Forms.NumericUpDown charLength;
        private System.Windows.Forms.GroupBox algorithmBox;
        private System.Windows.Forms.FlowLayoutPanel algorithmPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton algorithmRadio_Unicode;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox isSpacePermit;
        private System.Windows.Forms.Label miscSetting_Label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
    }
}