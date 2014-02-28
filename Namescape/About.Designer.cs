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
            this.producerName = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.forum = new System.Windows.Forms.Label();
            this.avangsLink = new System.Windows.Forms.LinkLabel();
            this.ilwarLink = new System.Windows.Forms.LinkLabel();
            this.Accept = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // producerName
            // 
            this.producerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.producerName.AutoSize = true;
            this.producerName.Font = new System.Drawing.Font("궁서체", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.producerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.producerName.Location = new System.Drawing.Point(233, 36);
            this.producerName.Name = "producerName";
            this.producerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.producerName.Size = new System.Drawing.Size(177, 40);
            this.producerName.TabIndex = 0;
            this.producerName.Text = "맛난호빵";
            this.producerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // producerLabel
            // 
            this.producerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("궁서체", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.producerLabel.Location = new System.Drawing.Point(312, 9);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.producerLabel.Size = new System.Drawing.Size(96, 27);
            this.producerLabel.TabIndex = 1;
            this.producerLabel.Text = "제작자";
            this.producerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // forum
            // 
            this.forum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forum.AutoSize = true;
            this.forum.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.forum.Location = new System.Drawing.Point(9, 150);
            this.forum.Name = "forum";
            this.forum.Size = new System.Drawing.Size(98, 37);
            this.forum.TabIndex = 2;
            this.forum.Text = "서식지";
            // 
            // avangsLink
            // 
            this.avangsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.avangsLink.AutoSize = true;
            this.avangsLink.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.avangsLink.Location = new System.Drawing.Point(12, 187);
            this.avangsLink.Name = "avangsLink";
            this.avangsLink.Size = new System.Drawing.Size(58, 21);
            this.avangsLink.TabIndex = 3;
            this.avangsLink.TabStop = true;
            this.avangsLink.Text = "아방스";
            this.avangsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.avangsLink_LinkClicked);
            // 
            // ilwarLink
            // 
            this.ilwarLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ilwarLink.AutoSize = true;
            this.ilwarLink.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ilwarLink.Location = new System.Drawing.Point(12, 208);
            this.ilwarLink.Name = "ilwarLink";
            this.ilwarLink.Size = new System.Drawing.Size(125, 21);
            this.ilwarLink.TabIndex = 4;
            this.ilwarLink.TabStop = true;
            this.ilwarLink.Text = "일간워스트 IT밭";
            this.ilwarLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ilwarLink_LinkClicked);
            // 
            // Accept
            // 
            this.Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept.Location = new System.Drawing.Point(312, 187);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(96, 39);
            this.Accept.TabIndex = 5;
            this.Accept.Text = "확인";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // credit
            // 
            this.credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(113, 100);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(303, 75);
            this.credit.TabIndex = 6;
            this.credit.Text = "Copyright ⓒ 2014 by 맛난호빵\r\n프로그램의 소스는 GPL로 배포됩니다.\r\n\r\nGPL로 배포된다해서 저작권이 포기되는 것이 아닙니다." +
    "\r\n제작자 이름 수정은 하지마세요.";
            this.credit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // About
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.ilwarLink);
            this.Controls.Add(this.avangsLink);
            this.Controls.Add(this.forum);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.producerName);
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

        private System.Windows.Forms.Label producerName;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label forum;
        private System.Windows.Forms.LinkLabel avangsLink;
        private System.Windows.Forms.LinkLabel ilwarLink;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label credit;
    }
}