namespace Texteditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelForTextBox = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.New_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindow_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dash = new System.Windows.Forms.ToolStripSeparator();
            this.PageSetup_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Print_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dash2 = new System.Windows.Forms.ToolStripSeparator();
            this.Close_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeDate_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Format_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSize_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColor_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomIn_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOut_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHelp_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.About_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AntalRader_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.AntalOrd_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.ABMM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ABUM = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.PanelForTextBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForTextBox
            // 
            this.PanelForTextBox.AllowDrop = true;
            this.PanelForTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelForTextBox.AutoScroll = true;
            this.PanelForTextBox.Controls.Add(this.TextBox);
            this.PanelForTextBox.Location = new System.Drawing.Point(0, 29);
            this.PanelForTextBox.Name = "PanelForTextBox";
            this.PanelForTextBox.Size = new System.Drawing.Size(867, 607);
            this.PanelForTextBox.TabIndex = 0;
            this.PanelForTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop_function);
            this.PanelForTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter_Function);
            // 
            // TextBox
            // 
            this.TextBox.AcceptsTab = true;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBox.Size = new System.Drawing.Size(867, 607);
            this.TextBox.TabIndex = 0;
            this.TextBox.WordWrap = false;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_Function);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Menu,
            this.Edit_Menu,
            this.Format_Menu,
            this.View_Menu,
            this.Help_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_Menu
            // 
            this.File_Menu.Checked = true;
            this.File_Menu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.File_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_MenuItem,
            this.NewWindow_MenuItem,
            this.Open_MenuItem,
            this.Save_MenuItem,
            this.SaveAs_MenuItem,
            this.Dash,
            this.PageSetup_MenuItem,
            this.Print_MenuItem,
            this.Dash2,
            this.Close_MenuItem});
            this.File_Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Menu.Name = "File_Menu";
            this.File_Menu.Size = new System.Drawing.Size(44, 24);
            this.File_Menu.Text = "File";
            // 
            // New_MenuItem
            // 
            this.New_MenuItem.Name = "New_MenuItem";
            this.New_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.New_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.New_MenuItem.Text = "New";
            this.New_MenuItem.Click += new System.EventHandler(this.NewTextBox_Function);
            // 
            // NewWindow_MenuItem
            // 
            this.NewWindow_MenuItem.Name = "NewWindow_MenuItem";
            this.NewWindow_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.NewWindow_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.NewWindow_MenuItem.Text = "New Window";
            this.NewWindow_MenuItem.Click += new System.EventHandler(this.NewWindow_Function);
            // 
            // Open_MenuItem
            // 
            this.Open_MenuItem.Name = "Open_MenuItem";
            this.Open_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.Open_MenuItem.Text = "Open...";
            this.Open_MenuItem.Click += new System.EventHandler(this.OpenFile_Function);
            // 
            // Save_MenuItem
            // 
            this.Save_MenuItem.Name = "Save_MenuItem";
            this.Save_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.Save_MenuItem.Text = "Save";
            this.Save_MenuItem.Click += new System.EventHandler(this.SaveContent_Function);
            // 
            // SaveAs_MenuItem
            // 
            this.SaveAs_MenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAs_MenuItem.Name = "SaveAs_MenuItem";
            this.SaveAs_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAs_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.SaveAs_MenuItem.Text = "Save as...";
            this.SaveAs_MenuItem.Click += new System.EventHandler(this.SaveAsContent_Function);
            // 
            // Dash
            // 
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(257, 6);
            // 
            // PageSetup_MenuItem
            // 
            this.PageSetup_MenuItem.Name = "PageSetup_MenuItem";
            this.PageSetup_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.PageSetup_MenuItem.Text = "Page Setup";
            this.PageSetup_MenuItem.Click += new System.EventHandler(this.PageSetup_MenuItem_Click);
            // 
            // Print_MenuItem
            // 
            this.Print_MenuItem.Name = "Print_MenuItem";
            this.Print_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Print_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.Print_MenuItem.Text = "Print...";
            this.Print_MenuItem.Click += new System.EventHandler(this.Print_Function);
            // 
            // Dash2
            // 
            this.Dash2.Name = "Dash2";
            this.Dash2.Size = new System.Drawing.Size(257, 6);
            // 
            // Close_MenuItem
            // 
            this.Close_MenuItem.Name = "Close_MenuItem";
            this.Close_MenuItem.Size = new System.Drawing.Size(260, 24);
            this.Close_MenuItem.Text = "Exit";
            this.Close_MenuItem.Click += new System.EventHandler(this.Close_Function);
            // 
            // Edit_Menu
            // 
            this.Edit_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo_MenuItem,
            this.toolStripMenuItem1,
            this.Cut_MenuItem,
            this.Copy_MenuItem,
            this.Paste_MenuItem,
            this.Delete_MenuItem,
            this.toolStripMenuItem2,
            this.SelectAll_MenuItem,
            this.TimeDate_MenuItem});
            this.Edit_Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Menu.Name = "Edit_Menu";
            this.Edit_Menu.Size = new System.Drawing.Size(47, 24);
            this.Edit_Menu.Text = "Edit";
            // 
            // Undo_MenuItem
            // 
            this.Undo_MenuItem.Name = "Undo_MenuItem";
            this.Undo_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Undo_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.Undo_MenuItem.Text = "Undo";
            this.Undo_MenuItem.Click += new System.EventHandler(this.Undo_MenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // Cut_MenuItem
            // 
            this.Cut_MenuItem.Name = "Cut_MenuItem";
            this.Cut_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.Cut_MenuItem.Text = "Cut";
            this.Cut_MenuItem.Click += new System.EventHandler(this.Cut_MenuItem_Click);
            // 
            // Copy_MenuItem
            // 
            this.Copy_MenuItem.Name = "Copy_MenuItem";
            this.Copy_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.Copy_MenuItem.Text = "Copy";
            this.Copy_MenuItem.Click += new System.EventHandler(this.Copy_MenuItem_Click);
            // 
            // Paste_MenuItem
            // 
            this.Paste_MenuItem.Name = "Paste_MenuItem";
            this.Paste_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Paste_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.Paste_MenuItem.Text = "Paste";
            this.Paste_MenuItem.Click += new System.EventHandler(this.Paste_MenuItem_Click);
            // 
            // Delete_MenuItem
            // 
            this.Delete_MenuItem.Name = "Delete_MenuItem";
            this.Delete_MenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Delete_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.Delete_MenuItem.Text = "Delete";
            this.Delete_MenuItem.Click += new System.EventHandler(this.Delete_MenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // SelectAll_MenuItem
            // 
            this.SelectAll_MenuItem.Name = "SelectAll_MenuItem";
            this.SelectAll_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.SelectAll_MenuItem.Text = "Select All";
            this.SelectAll_MenuItem.Click += new System.EventHandler(this.SelectAll_MenuItem_Click);
            // 
            // TimeDate_MenuItem
            // 
            this.TimeDate_MenuItem.Name = "TimeDate_MenuItem";
            this.TimeDate_MenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.TimeDate_MenuItem.Size = new System.Drawing.Size(192, 24);
            this.TimeDate_MenuItem.Text = "Time/Date";
            this.TimeDate_MenuItem.Click += new System.EventHandler(this.TimeDate_MenuItem_Click);
            // 
            // Format_Menu
            // 
            this.Format_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSize_MenuItem,
            this.FontColor_MenuItem});
            this.Format_Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Format_Menu.Name = "Format_Menu";
            this.Format_Menu.Size = new System.Drawing.Size(68, 24);
            this.Format_Menu.Text = "Format";
            // 
            // FontSize_MenuItem
            // 
            this.FontSize_MenuItem.Name = "FontSize_MenuItem";
            this.FontSize_MenuItem.Size = new System.Drawing.Size(156, 24);
            this.FontSize_MenuItem.Text = "Font Size..";
            this.FontSize_MenuItem.Click += new System.EventHandler(this.Font_MenuItem_Click);
            // 
            // FontColor_MenuItem
            // 
            this.FontColor_MenuItem.Name = "FontColor_MenuItem";
            this.FontColor_MenuItem.Size = new System.Drawing.Size(156, 24);
            this.FontColor_MenuItem.Text = "Font Color...";
            this.FontColor_MenuItem.Click += new System.EventHandler(this.Color_MenuItem_Click);
            // 
            // View_Menu
            // 
            this.View_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.StatusBar_MenuItem});
            this.View_Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Menu.Name = "View_Menu";
            this.View_Menu.Size = new System.Drawing.Size(53, 24);
            this.View_Menu.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomIn_MenuItem,
            this.ZoomOut_MenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ZoomIn_MenuItem
            // 
            this.ZoomIn_MenuItem.Name = "ZoomIn_MenuItem";
            this.ZoomIn_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.ZoomIn_MenuItem.Size = new System.Drawing.Size(257, 24);
            this.ZoomIn_MenuItem.Text = "Zoom In";
            this.ZoomIn_MenuItem.Click += new System.EventHandler(this.zoomIn_MenuItem_Click);
            // 
            // ZoomOut_MenuItem
            // 
            this.ZoomOut_MenuItem.Name = "ZoomOut_MenuItem";
            this.ZoomOut_MenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.ZoomOut_MenuItem.Size = new System.Drawing.Size(257, 24);
            this.ZoomOut_MenuItem.Text = "Zoom out";
            this.ZoomOut_MenuItem.Click += new System.EventHandler(this.ZoomOut_MenuItem_Click);
            // 
            // StatusBar_MenuItem
            // 
            this.StatusBar_MenuItem.Checked = true;
            this.StatusBar_MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusBar_MenuItem.Name = "StatusBar_MenuItem";
            this.StatusBar_MenuItem.Size = new System.Drawing.Size(144, 24);
            this.StatusBar_MenuItem.Text = "Status Bar";
            this.StatusBar_MenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // Help_Menu
            // 
            this.Help_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelp_MenuItem,
            this.toolStripMenuItem3,
            this.About_MenuItem});
            this.Help_Menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_Menu.Name = "Help_Menu";
            this.Help_Menu.Size = new System.Drawing.Size(53, 24);
            this.Help_Menu.Text = "Help";
            // 
            // ViewHelp_MenuItem
            // 
            this.ViewHelp_MenuItem.Name = "ViewHelp_MenuItem";
            this.ViewHelp_MenuItem.Size = new System.Drawing.Size(146, 24);
            this.ViewHelp_MenuItem.Text = "View Help";
            this.ViewHelp_MenuItem.Click += new System.EventHandler(this.ViewHelp_MenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 6);
            // 
            // About_MenuItem
            // 
            this.About_MenuItem.Name = "About_MenuItem";
            this.About_MenuItem.Size = new System.Drawing.Size(146, 24);
            this.About_MenuItem.Text = "About ";
            this.About_MenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AntalRader_Label,
            this.AntalOrd_Label,
            this.ABMM,
            this.ABUM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // AntalRader_Label
            // 
            this.AntalRader_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntalRader_Label.Margin = new System.Windows.Forms.Padding(10, 3, 40, 2);
            this.AntalRader_Label.Name = "AntalRader_Label";
            this.AntalRader_Label.Size = new System.Drawing.Size(72, 17);
            this.AntalRader_Label.Text = "Ln, 1 Col, 1";
            // 
            // AntalOrd_Label
            // 
            this.AntalOrd_Label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntalOrd_Label.Margin = new System.Windows.Forms.Padding(0, 3, 50, 2);
            this.AntalOrd_Label.Name = "AntalOrd_Label";
            this.AntalOrd_Label.Size = new System.Drawing.Size(76, 17);
            this.AntalOrd_Label.Text = "Antal ord: 0";
            // 
            // ABMM
            // 
            this.ABMM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABMM.Margin = new System.Windows.Forms.Padding(0, 3, 30, 2);
            this.ABMM.Name = "ABMM";
            this.ABMM.Size = new System.Drawing.Size(174, 17);
            this.ABMM.Text = "Bokstäver med mellanslag: 0";
            // 
            // ABUM
            // 
            this.ABUM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABUM.Name = "ABUM";
            this.ABUM.Size = new System.Drawing.Size(177, 17);
            this.ABUM.Text = "Bokstäver utan mellanslag:  0";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.EnableMetric = true;
            this.pageSetupDialog1.ShowHelp = true;
            this.pageSetupDialog1.ShowNetwork = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(869, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PanelForTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(685, 500);
            this.Name = "Form1";
            this.Text = "Ordbehandlare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosed_Function);
            this.PanelForTextBox.ResumeLayout(false);
            this.PanelForTextBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelForTextBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_Menu;
        private System.Windows.Forms.ToolStripMenuItem New_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Close_MenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AntalRader_Label;
        private System.Windows.Forms.ToolStripStatusLabel AntalOrd_Label;
        private System.Windows.Forms.ToolStripStatusLabel ABMM;
        private System.Windows.Forms.ToolStripStatusLabel ABUM;
        private System.Windows.Forms.ToolStripMenuItem PageSetup_MenuItem;
        private System.Windows.Forms.ToolStripSeparator Dash;
        private System.Windows.Forms.ToolStripSeparator Dash2;
        private System.Windows.Forms.ToolStripMenuItem Print_MenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem Edit_Menu;
        private System.Windows.Forms.ToolStripMenuItem Undo_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Cut_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Copy_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Paste_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem NewWindow_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAll_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimeDate_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Format_Menu;
        private System.Windows.Forms.ToolStripMenuItem FontSize_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontColor_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_Menu;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomIn_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomOut_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusBar_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Help_Menu;
        private System.Windows.Forms.ToolStripMenuItem ViewHelp_MenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem About_MenuItem;
    }
}

