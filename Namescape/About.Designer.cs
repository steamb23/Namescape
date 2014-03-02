namespace Namescape
{
    partial class About
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
            this.ui_producerName = new System.Windows.Forms.Label();
            this.ui_producerLabel = new System.Windows.Forms.Label();
            this.ui_forum = new System.Windows.Forms.Label();
            this.ui_avangsLink = new System.Windows.Forms.LinkLabel();
            this.ui_ilwarLink = new System.Windows.Forms.LinkLabel();
            this.ui_accept = new System.Windows.Forms.Button();
            this.ui_credit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_producerName
            // 
            this.ui_producerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_producerName.AutoSize = true;
            this.ui_producerName.Font = new System.Drawing.Font("궁서체", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_producerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ui_producerName.Location = new System.Drawing.Point(233, 36);
            this.ui_producerName.Name = "ui_producerName";
            this.ui_producerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ui_producerName.Size = new System.Drawing.Size(177, 40);
            this.ui_producerName.TabIndex = 0;
            this.ui_producerName.Text = "맛난호빵";
            this.ui_producerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ui_producerLabel
            // 
            this.ui_producerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_producerLabel.AutoSize = true;
            this.ui_producerLabel.Font = new System.Drawing.Font("궁서체", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_producerLabel.Location = new System.Drawing.Point(312, 9);
            this.ui_producerLabel.Name = "ui_producerLabel";
            this.ui_producerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ui_producerLabel.Size = new System.Drawing.Size(96, 27);
            this.ui_producerLabel.TabIndex = 1;
            this.ui_producerLabel.Text = "제작자";
            this.ui_producerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ui_forum
            // 
            this.ui_forum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ui_forum.AutoSize = true;
            this.ui_forum.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_forum.Location = new System.Drawing.Point(9, 150);
            this.ui_forum.Name = "ui_forum";
            this.ui_forum.Size = new System.Drawing.Size(98, 37);
            this.ui_forum.TabIndex = 2;
            this.ui_forum.Text = "서식지";
            // 
            // ui_avangsLink
            // 
            this.ui_avangsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ui_avangsLink.AutoSize = true;
            this.ui_avangsLink.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_avangsLink.Location = new System.Drawing.Point(12, 187);
            this.ui_avangsLink.Name = "ui_avangsLink";
            this.ui_avangsLink.Size = new System.Drawing.Size(58, 21);
            this.ui_avangsLink.TabIndex = 3;
            this.ui_avangsLink.TabStop = true;
            this.ui_avangsLink.Text = "아방스";
            this.ui_avangsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.avangsLink_LinkClicked);
            // 
            // ui_ilwarLink
            // 
            this.ui_ilwarLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ui_ilwarLink.AutoSize = true;
            this.ui_ilwarLink.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_ilwarLink.Location = new System.Drawing.Point(12, 208);
            this.ui_ilwarLink.Name = "ui_ilwarLink";
            this.ui_ilwarLink.Size = new System.Drawing.Size(125, 21);
            this.ui_ilwarLink.TabIndex = 4;
            this.ui_ilwarLink.TabStop = true;
            this.ui_ilwarLink.Text = "일간워스트 IT밭";
            this.ui_ilwarLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ilwarLink_LinkClicked);
            // 
            // ui_accept
            // 
            this.ui_accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_accept.Location = new System.Drawing.Point(312, 187);
            this.ui_accept.Name = "ui_accept";
            this.ui_accept.Size = new System.Drawing.Size(96, 39);
            this.ui_accept.TabIndex = 5;
            this.ui_accept.Text = "확인";
            this.ui_accept.UseVisualStyleBackColor = true;
            this.ui_accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // ui_credit
            // 
            this.ui_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_credit.AutoSize = true;
            this.ui_credit.Location = new System.Drawing.Point(113, 100);
            this.ui_credit.Name = "ui_credit";
            this.ui_credit.Size = new System.Drawing.Size(303, 75);
            this.ui_credit.TabIndex = 6;
            this.ui_credit.Text = "Copyright ⓒ 2014 by 맛난호빵\r\n프로그램의 소스는 GPL로 배포됩니다.\r\n\r\nGPL로 배포된다해서 저작권이 포기되는 것이 아닙니다." +
    "\r\n제작자 이름 수정은 하지마세요.";
            this.ui_credit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // About
            // 
            this.AcceptButton = this.ui_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.ui_credit);
            this.Controls.Add(this.ui_accept);
            this.Controls.Add(this.ui_ilwarLink);
            this.Controls.Add(this.ui_avangsLink);
            this.Controls.Add(this.ui_forum);
            this.Controls.Add(this.ui_producerLabel);
            this.Controls.Add(this.ui_producerName);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "제작자 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_producerName;
        private System.Windows.Forms.Label ui_producerLabel;
        private System.Windows.Forms.Label ui_forum;
        private System.Windows.Forms.LinkLabel ui_avangsLink;
        private System.Windows.Forms.LinkLabel ui_ilwarLink;
        private System.Windows.Forms.Button ui_accept;
        private System.Windows.Forms.Label ui_credit;
    }
}