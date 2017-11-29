namespace SaintSender
{
    partial class SaintSender
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mailList = new System.Windows.Forms.DataGridView();
            this.mailListColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.displayMail = new System.Windows.Forms.RichTextBox();
            this.replyMail = new System.Windows.Forms.RichTextBox();
            this.btnReply = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saintMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.switchAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreFromBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxToFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnCompose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mailList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(975, 555);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // mailList
            // 
            this.mailList.AllowUserToAddRows = false;
            this.mailList.AllowUserToDeleteRows = false;
            this.mailList.AllowUserToResizeColumns = false;
            this.mailList.AllowUserToResizeRows = false;
            this.mailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mailList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mailList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailListColumn});
            this.mailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailList.Location = new System.Drawing.Point(0, 0);
            this.mailList.MultiSelect = false;
            this.mailList.Name = "mailList";
            this.mailList.ReadOnly = true;
            this.mailList.RowHeadersVisible = false;
            this.mailList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mailList.RowTemplate.Height = 24;
            this.mailList.RowTemplate.ReadOnly = true;
            this.mailList.Size = new System.Drawing.Size(325, 555);
            this.mailList.TabIndex = 0;
            this.mailList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailList_CellContentClick);
            // 
            // mailListColumn
            // 
            this.mailListColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailListColumn.HeaderText = "Your E-mails:";
            this.mailListColumn.Name = "mailListColumn";
            this.mailListColumn.ReadOnly = true;
            this.mailListColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.displayMail);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.replyMail);
            this.splitContainer2.Size = new System.Drawing.Size(646, 555);
            this.splitContainer2.SplitterDistance = 364;
            this.splitContainer2.TabIndex = 0;
            // 
            // displayMail
            // 
            this.displayMail.BackColor = System.Drawing.SystemColors.Info;
            this.displayMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayMail.Location = new System.Drawing.Point(0, 0);
            this.displayMail.Name = "displayMail";
            this.displayMail.ReadOnly = true;
            this.displayMail.Size = new System.Drawing.Size(646, 364);
            this.displayMail.TabIndex = 0;
            this.displayMail.Text = "";
            // 
            // replyMail
            // 
            this.replyMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replyMail.Location = new System.Drawing.Point(0, 0);
            this.replyMail.Name = "replyMail";
            this.replyMail.Size = new System.Drawing.Size(646, 187);
            this.replyMail.TabIndex = 1;
            this.replyMail.Text = "";
            // 
            // btnReply
            // 
            this.btnReply.AutoSize = true;
            this.btnReply.Location = new System.Drawing.Point(888, 7);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(75, 27);
            this.btnReply.TabIndex = 1;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saintMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saintMenu
            // 
            this.saintMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchAccountToolStripMenuItem,
            this.backupEmailsToolStripMenuItem,
            this.restoreFromBackupToolStripMenuItem});
            this.saintMenu.Name = "saintMenu";
            this.saintMenu.Size = new System.Drawing.Size(58, 24);
            this.saintMenu.Text = "Menu";
            // 
            // switchAccountToolStripMenuItem
            // 
            this.switchAccountToolStripMenuItem.Name = "switchAccountToolStripMenuItem";
            this.switchAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.switchAccountToolStripMenuItem.Text = "Switch Account";
            // 
            // backupEmailsToolStripMenuItem
            // 
            this.backupEmailsToolStripMenuItem.Name = "backupEmailsToolStripMenuItem";
            this.backupEmailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backupEmailsToolStripMenuItem.Text = "Backup E-mails";
            // 
            // restoreFromBackupToolStripMenuItem
            // 
            this.restoreFromBackupToolStripMenuItem.Name = "restoreFromBackupToolStripMenuItem";
            this.restoreFromBackupToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restoreFromBackupToolStripMenuItem.Text = "Restore From Backup";
            // 
            // txtBoxToFrom
            // 
            this.txtBoxToFrom.Location = new System.Drawing.Point(431, 12);
            this.txtBoxToFrom.Name = "txtBoxToFrom";
            this.txtBoxToFrom.Size = new System.Drawing.Size(437, 22);
            this.txtBoxToFrom.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(360, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(65, 17);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "To/From:";
            // 
            // btnCompose
            // 
            this.btnCompose.AutoSize = true;
            this.btnCompose.Location = new System.Drawing.Point(133, 7);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(192, 27);
            this.btnCompose.TabIndex = 5;
            this.btnCompose.Text = "Compose Mail";
            this.btnCompose.UseVisualStyleBackColor = true;
            // 
            // SaintSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 595);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtBoxToFrom);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SaintSender";
            this.Text = "SaintSender";
            this.Load += new System.EventHandler(this.SaintSender_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mailList)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox displayMail;
        private System.Windows.Forms.RichTextBox replyMail;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saintMenu;
        private System.Windows.Forms.ToolStripMenuItem switchAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreFromBackupToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxToFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.DataGridView mailList;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailListColumn;
    }
}