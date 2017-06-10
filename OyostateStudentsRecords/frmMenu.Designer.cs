namespace OyostateStudentsRecords
{
    partial class frmMenu
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
            if(disposing && (components != null))
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quikSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.registerStudentToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.adminMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem1,
            this.updateRecordToolStripMenuItem,
            this.viewRecordsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem1.Text = "Main Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // registerStudentToolStripMenuItem1
            // 
            this.registerStudentToolStripMenuItem1.Name = "registerStudentToolStripMenuItem1";
            this.registerStudentToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.registerStudentToolStripMenuItem1.Text = "Register Student";
            this.registerStudentToolStripMenuItem1.Click += new System.EventHandler(this.registerStudentToolStripMenuItem1_Click);
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateRecordToolStripMenuItem.Text = "Update Record";
            this.updateRecordToolStripMenuItem.Click += new System.EventHandler(this.updateRecordToolStripMenuItem_Click);
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            this.viewRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewRecordsToolStripMenuItem_Click);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backUpDatabaseToolStripMenuItem,
            this.quikSearchToolStripMenuItem});
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.registerStudentToolStripMenuItem.Text = "Operations";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // backUpDatabaseToolStripMenuItem
            // 
            this.backUpDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localBackUpToolStripMenuItem,
            this.serverBackUpToolStripMenuItem});
            this.backUpDatabaseToolStripMenuItem.Name = "backUpDatabaseToolStripMenuItem";
            this.backUpDatabaseToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.backUpDatabaseToolStripMenuItem.Text = "BackUp Database";
            // 
            // localBackUpToolStripMenuItem
            // 
            this.localBackUpToolStripMenuItem.Name = "localBackUpToolStripMenuItem";
            this.localBackUpToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.localBackUpToolStripMenuItem.Text = "Local BackUp";
            this.localBackUpToolStripMenuItem.Click += new System.EventHandler(this.localBackUpToolStripMenuItem_Click);
            // 
            // serverBackUpToolStripMenuItem
            // 
            this.serverBackUpToolStripMenuItem.Name = "serverBackUpToolStripMenuItem";
            this.serverBackUpToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.serverBackUpToolStripMenuItem.Text = "Remote BackUp";
            this.serverBackUpToolStripMenuItem.Click += new System.EventHandler(this.serverBackUpToolStripMenuItem_Click);
            // 
            // quikSearchToolStripMenuItem
            // 
            this.quikSearchToolStripMenuItem.Name = "quikSearchToolStripMenuItem";
            this.quikSearchToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.quikSearchToolStripMenuItem.Text = "Quik Search";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.contactsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // adminMenuToolStripMenuItem
            // 
            this.adminMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.resetPasswordToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.databaseRestoreToolStripMenuItem});
            this.adminMenuToolStripMenuItem.Name = "adminMenuToolStripMenuItem";
            this.adminMenuToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.adminMenuToolStripMenuItem.Text = "Admin Menu";
            this.adminMenuToolStripMenuItem.Click += new System.EventHandler(this.adminMenuToolStripMenuItem_Click);
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            this.createNewUserToolStripMenuItem.Click += new System.EventHandler(this.createNewUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sendEmailToolStripMenuItem.Text = "Send E-mail";
            // 
            // databaseRestoreToolStripMenuItem
            // 
            this.databaseRestoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreLocalToolStripMenuItem,
            this.restoreToServerToolStripMenuItem});
            this.databaseRestoreToolStripMenuItem.Name = "databaseRestoreToolStripMenuItem";
            this.databaseRestoreToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.databaseRestoreToolStripMenuItem.Text = "Database Restore";
            // 
            // restoreLocalToolStripMenuItem
            // 
            this.restoreLocalToolStripMenuItem.Name = "restoreLocalToolStripMenuItem";
            this.restoreLocalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.restoreLocalToolStripMenuItem.Text = "Restore Local";
            // 
            // restoreToServerToolStripMenuItem
            // 
            this.restoreToServerToolStripMenuItem.Name = "restoreToServerToolStripMenuItem";
            this.restoreToServerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.restoreToServerToolStripMenuItem.Text = "Restore to Server";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(771, 365);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quikSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToServerToolStripMenuItem;
    }
}