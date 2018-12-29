namespace VideoOnCmder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.embeddedVideoScreen = new System.Windows.Forms.WebBrowser();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.menu_fullview = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_search = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hide = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tmp_axWebBrowser = new AxSHDocVw.AxWebBrowser();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmp_axWebBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // embeddedVideoScreen
            // 
            this.embeddedVideoScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.embeddedVideoScreen.IsWebBrowserContextMenuEnabled = false;
            this.embeddedVideoScreen.Location = new System.Drawing.Point(0, 28);
            this.embeddedVideoScreen.Margin = new System.Windows.Forms.Padding(0);
            this.embeddedVideoScreen.MinimumSize = new System.Drawing.Size(20, 20);
            this.embeddedVideoScreen.Name = "embeddedVideoScreen";
            this.embeddedVideoScreen.Size = new System.Drawing.Size(749, 463);
            this.embeddedVideoScreen.TabIndex = 7;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(65, 219);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(602, 55);
            this.searchBox.TabIndex = 5;
            this.searchBox.Tag = "";
            this.searchBox.Text = "Enter Url";
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // menu_fullview
            // 
            this.menu_fullview.Image = ((System.Drawing.Image)(resources.GetObject("menu_fullview.Image")));
            this.menu_fullview.Name = "menu_fullview";
            this.menu_fullview.Size = new System.Drawing.Size(129, 24);
            this.menu_fullview.Text = "FULL SCREEN";
            this.menu_fullview.Click += new System.EventHandler(this.menu_fullview_click);
            // 
            // menu_search
            // 
            this.menu_search.Image = ((System.Drawing.Image)(resources.GetObject("menu_search.Image")));
            this.menu_search.Name = "menu_search";
            this.menu_search.Size = new System.Drawing.Size(96, 24);
            this.menu_search.Text = "SEARCH";
            this.menu_search.Click += new System.EventHandler(this.menu_search_click);
            // 
            // menu_hide
            // 
            this.menu_hide.Image = ((System.Drawing.Image)(resources.GetObject("menu_hide.Image")));
            this.menu_hide.Name = "menu_hide";
            this.menu_hide.Size = new System.Drawing.Size(121, 24);
            this.menu_hide.Text = "HIDE MENU";
            this.menu_hide.Click += new System.EventHandler(this.menu_hide_click);
            // 
            // menu_exit
            // 
            this.menu_exit.Image = ((System.Drawing.Image)(resources.GetObject("menu_exit.Image")));
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(70, 24);
            this.menu_exit.Text = "EXIT";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_fullview,
            this.menu_search,
            this.menu_hide,
            this.menu_exit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(749, 28);
            this.menu.TabIndex = 9;
            this.menu.Text = "menu";
            // 
            // tmp_axWebBrowser
            // 
            this.tmp_axWebBrowser.Enabled = true;
            this.tmp_axWebBrowser.Location = new System.Drawing.Point(33, 72);
            this.tmp_axWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tmp_axWebBrowser.OcxState")));
            this.tmp_axWebBrowser.Size = new System.Drawing.Size(672, 348);
            this.tmp_axWebBrowser.TabIndex = 10;
            this.tmp_axWebBrowser.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(749, 491);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.embeddedVideoScreen);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tmp_axWebBrowser);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Main";
            this.Text = "Video On Cmder";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmp_axWebBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser embeddedVideoScreen;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem menu_fullview;
        private System.Windows.Forms.ToolStripMenuItem menu_search;
        private System.Windows.Forms.ToolStripMenuItem menu_hide;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.MenuStrip menu;
        private AxSHDocVw.AxWebBrowser tmp_axWebBrowser;
    }
}

