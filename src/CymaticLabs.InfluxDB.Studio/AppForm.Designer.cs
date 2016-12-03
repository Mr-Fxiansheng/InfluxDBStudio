﻿namespace CymaticLabs.InfluxDB.Studio
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Measurement", 3, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Database", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Connection", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAppSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAppSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowUntrustedSSLCertificatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQueryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.runQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.manageConnectionsButton = new System.Windows.Forms.ToolStripButton();
            this.disconnectButton = new System.Windows.Forms.ToolStripButton();
            this.showUsersButton = new System.Windows.Forms.ToolStripButton();
            this.showDiagnosticsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.newQueryButton = new System.Windows.Forms.ToolStripButton();
            this.runQueryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.createDatabaseButton = new System.Windows.Forms.ToolStripButton();
            this.continuousQueryButton = new System.Windows.Forms.ToolStripButton();
            this.dropDatabaseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tagKeysButton = new System.Windows.Forms.ToolStripButton();
            this.tagValuesButton = new System.Windows.Forms.ToolStripButton();
            this.fieldKeysButton = new System.Windows.Forms.ToolStripButton();
            this.showSeriesButton = new System.Windows.Forms.ToolStripButton();
            this.dropSeriesButton = new System.Windows.Forms.ToolStripButton();
            this.dropMeasurementButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.connectionsTreeView = new System.Windows.Forms.TreeView();
            this.tabControl = new CymaticLabs.InfluxDB.Studio.Controls.ExtendedTabControl();
            this.connectionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectionRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continousQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newQueryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tagKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropMeasurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.connectionsContextMenu.SuspendLayout();
            this.databaseContextMenu.SuspendLayout();
            this.measurementContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importAppSettingsMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importAppSettingsMenuItem
            // 
            this.importAppSettingsMenuItem.Name = "importAppSettingsMenuItem";
            this.importAppSettingsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.importAppSettingsMenuItem.Text = "Settings";
            this.importAppSettingsMenuItem.Click += new System.EventHandler(this.importAppSettingsMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAppSettingsMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportAppSettingsMenuItem
            // 
            this.exportAppSettingsMenuItem.Name = "exportAppSettingsMenuItem";
            this.exportAppSettingsMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportAppSettingsMenuItem.Text = "Settings";
            this.exportAppSettingsMenuItem.Click += new System.EventHandler(this.exportAppSettingsMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.allowUntrustedSSLCertificatesToolStripMenuItem});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectionsToolStripMenuItem.Text = "Connections";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageToolStripMenuItem.Image")));
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // allowUntrustedSSLCertificatesToolStripMenuItem
            // 
            this.allowUntrustedSSLCertificatesToolStripMenuItem.CheckOnClick = true;
            this.allowUntrustedSSLCertificatesToolStripMenuItem.Name = "allowUntrustedSSLCertificatesToolStripMenuItem";
            this.allowUntrustedSSLCertificatesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.allowUntrustedSSLCertificatesToolStripMenuItem.Text = "Allow Untrusted SSL Certificates";
            this.allowUntrustedSSLCertificatesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.allowUntrustedSSLCertificatesToolStripMenuItem_CheckedChanged);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQueryToolStripMenuItem2,
            this.runQueryToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // newQueryToolStripMenuItem2
            // 
            this.newQueryToolStripMenuItem2.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.NewQuery;
            this.newQueryToolStripMenuItem2.Name = "newQueryToolStripMenuItem2";
            this.newQueryToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.newQueryToolStripMenuItem2.Text = "New Query";
            this.newQueryToolStripMenuItem2.Click += new System.EventHandler(this.newQueryToolStripMenuItem2_Click);
            // 
            // runQueryToolStripMenuItem
            // 
            this.runQueryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runQueryToolStripMenuItem.Image")));
            this.runQueryToolStripMenuItem.Name = "runQueryToolStripMenuItem";
            this.runQueryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.runQueryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.runQueryToolStripMenuItem.Text = "Run";
            this.runQueryToolStripMenuItem.Click += new System.EventHandler(this.runQueryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Loading");
            this.imageList.Images.SetKeyName(1, "Connection");
            this.imageList.Images.SetKeyName(2, "Database");
            this.imageList.Images.SetKeyName(3, "Measurement");
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageConnectionsButton,
            this.disconnectButton,
            this.showUsersButton,
            this.showDiagnosticsButton,
            this.toolStripSeparator1,
            this.refreshButton,
            this.newQueryButton,
            this.runQueryButton,
            this.toolStripSeparator2,
            this.createDatabaseButton,
            this.continuousQueryButton,
            this.dropDatabaseButton,
            this.toolStripSeparator3,
            this.tagKeysButton,
            this.tagValuesButton,
            this.fieldKeysButton,
            this.showSeriesButton,
            this.dropSeriesButton,
            this.dropMeasurementButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // manageConnectionsButton
            // 
            this.manageConnectionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageConnectionsButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.EditConnection;
            this.manageConnectionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manageConnectionsButton.Name = "manageConnectionsButton";
            this.manageConnectionsButton.Size = new System.Drawing.Size(23, 22);
            this.manageConnectionsButton.Text = "manageConnectionsButton";
            this.manageConnectionsButton.ToolTipText = "Manage Connections";
            this.manageConnectionsButton.Click += new System.EventHandler(this.manageConnectionsButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disconnectButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Disconnect;
            this.disconnectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(23, 22);
            this.disconnectButton.Text = "disconnectButton";
            this.disconnectButton.ToolTipText = "Disconnect";
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // showUsersButton
            // 
            this.showUsersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showUsersButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Users;
            this.showUsersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showUsersButton.Name = "showUsersButton";
            this.showUsersButton.Size = new System.Drawing.Size(23, 22);
            this.showUsersButton.Text = "Show Users";
            this.showUsersButton.Click += new System.EventHandler(this.showUsersButton_Click);
            // 
            // showDiagnosticsButton
            // 
            this.showDiagnosticsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showDiagnosticsButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Diagnostics;
            this.showDiagnosticsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showDiagnosticsButton.Name = "showDiagnosticsButton";
            this.showDiagnosticsButton.Size = new System.Drawing.Size(23, 22);
            this.showDiagnosticsButton.Text = "showDiagnosticsButton";
            this.showDiagnosticsButton.ToolTipText = "Show Diagnostics";
            this.showDiagnosticsButton.Click += new System.EventHandler(this.showDiagnosticsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Refresh;
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.ToolTipText = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // newQueryButton
            // 
            this.newQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newQueryButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.NewQuery;
            this.newQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newQueryButton.Name = "newQueryButton";
            this.newQueryButton.Size = new System.Drawing.Size(23, 22);
            this.newQueryButton.Text = "newQueryButton";
            this.newQueryButton.ToolTipText = "New Query";
            this.newQueryButton.Click += new System.EventHandler(this.newQueryButton_Click);
            // 
            // runQueryButton
            // 
            this.runQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runQueryButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.RunQuery;
            this.runQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runQueryButton.Name = "runQueryButton";
            this.runQueryButton.Size = new System.Drawing.Size(23, 22);
            this.runQueryButton.Text = "runQueryButton";
            this.runQueryButton.ToolTipText = "Run Query";
            this.runQueryButton.Click += new System.EventHandler(this.runQueryButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // createDatabaseButton
            // 
            this.createDatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createDatabaseButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.CreateDatabase;
            this.createDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDatabaseButton.Name = "createDatabaseButton";
            this.createDatabaseButton.Size = new System.Drawing.Size(23, 22);
            this.createDatabaseButton.Text = "createDatabaseButton";
            this.createDatabaseButton.ToolTipText = "Create Database";
            this.createDatabaseButton.Click += new System.EventHandler(this.createDatabaseButton_Click);
            // 
            // continuousQueryButton
            // 
            this.continuousQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.continuousQueryButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.ContinuousQuery;
            this.continuousQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.continuousQueryButton.Name = "continuousQueryButton";
            this.continuousQueryButton.Size = new System.Drawing.Size(23, 22);
            this.continuousQueryButton.Text = "Show Continuous Queries";
            this.continuousQueryButton.Click += new System.EventHandler(this.continuousQueryButton_Click);
            // 
            // dropDatabaseButton
            // 
            this.dropDatabaseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropDatabaseButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.DropDatabase;
            this.dropDatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropDatabaseButton.Name = "dropDatabaseButton";
            this.dropDatabaseButton.Size = new System.Drawing.Size(23, 22);
            this.dropDatabaseButton.Text = "dropDatabaseButton";
            this.dropDatabaseButton.ToolTipText = "Drop Database";
            this.dropDatabaseButton.Click += new System.EventHandler(this.dropDatabaseButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tagKeysButton
            // 
            this.tagKeysButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagKeysButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.TagKeys;
            this.tagKeysButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagKeysButton.Name = "tagKeysButton";
            this.tagKeysButton.Size = new System.Drawing.Size(23, 22);
            this.tagKeysButton.Text = "A";
            this.tagKeysButton.ToolTipText = "Show Tag Keys";
            this.tagKeysButton.Click += new System.EventHandler(this.tagKeysButton_Click);
            // 
            // tagValuesButton
            // 
            this.tagValuesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagValuesButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.TagValues;
            this.tagValuesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagValuesButton.Name = "tagValuesButton";
            this.tagValuesButton.Size = new System.Drawing.Size(23, 22);
            this.tagValuesButton.Text = "Tag Values";
            this.tagValuesButton.ToolTipText = "Show Tag Values";
            this.tagValuesButton.Click += new System.EventHandler(this.tagValuesButton_Click);
            // 
            // fieldKeysButton
            // 
            this.fieldKeysButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fieldKeysButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.FieldKeys;
            this.fieldKeysButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fieldKeysButton.Name = "fieldKeysButton";
            this.fieldKeysButton.Size = new System.Drawing.Size(23, 22);
            this.fieldKeysButton.Text = "Field Keys";
            this.fieldKeysButton.ToolTipText = "Show Field Keys";
            this.fieldKeysButton.Click += new System.EventHandler(this.fieldKeysButton_Click);
            // 
            // showSeriesButton
            // 
            this.showSeriesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showSeriesButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Series;
            this.showSeriesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showSeriesButton.Name = "showSeriesButton";
            this.showSeriesButton.Size = new System.Drawing.Size(23, 22);
            this.showSeriesButton.Text = "showSeriesButton";
            this.showSeriesButton.ToolTipText = "Show Show Series";
            this.showSeriesButton.Click += new System.EventHandler(this.showSeriesButton_Click);
            // 
            // dropSeriesButton
            // 
            this.dropSeriesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropSeriesButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.DropSeries;
            this.dropSeriesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropSeriesButton.Name = "dropSeriesButton";
            this.dropSeriesButton.Size = new System.Drawing.Size(23, 22);
            this.dropSeriesButton.Text = "dropSeriesButton";
            this.dropSeriesButton.ToolTipText = "Drop Series";
            this.dropSeriesButton.Click += new System.EventHandler(this.dropSeriesButton_Click);
            // 
            // dropMeasurementButton
            // 
            this.dropMeasurementButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropMeasurementButton.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.DropMeasurement;
            this.dropMeasurementButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropMeasurementButton.Name = "dropMeasurementButton";
            this.dropMeasurementButton.Size = new System.Drawing.Size(23, 22);
            this.dropMeasurementButton.Text = "dropMeasurementButton";
            this.dropMeasurementButton.ToolTipText = "Drop Measurement";
            this.dropMeasurementButton.Click += new System.EventHandler(this.dropMeasurementButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 540);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 49);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.connectionsTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(784, 491);
            this.splitContainer.SplitterDistance = 168;
            this.splitContainer.TabIndex = 4;
            // 
            // connectionsTreeView
            // 
            this.connectionsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionsTreeView.FullRowSelect = true;
            this.connectionsTreeView.HideSelection = false;
            this.connectionsTreeView.ImageIndex = 0;
            this.connectionsTreeView.ImageList = this.imageList;
            this.connectionsTreeView.Location = new System.Drawing.Point(0, 0);
            this.connectionsTreeView.Name = "connectionsTreeView";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "Node2";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Measurement";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Node1";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Database";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Connection";
            this.connectionsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.connectionsTreeView.SelectedImageIndex = 0;
            this.connectionsTreeView.Size = new System.Drawing.Size(168, 491);
            this.connectionsTreeView.TabIndex = 1;
            this.connectionsTreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.connectionsTreeView_AfterExpand);
            this.connectionsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.connectionsTreeView_AfterSelect);
            this.connectionsTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.connectionsTreeView_NodeMouseClick);
            this.connectionsTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.connectionsTreeView_NodeMouseDoubleClick);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowTabCloseArea = true;
            this.tabControl.Size = new System.Drawing.Size(612, 491);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabCloseSpace = 8;
            this.tabControl.TabCloseWidth = 16;
            this.tabControl.TabImageHeight = 16;
            this.tabControl.TabImageLeft = 4;
            this.tabControl.TabImageTop = 4;
            this.tabControl.TabImageWidth = 16;
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLeadingOffset = 8;
            this.tabControl.TabClosed += new System.EventHandler<System.Windows.Forms.TabPage>(this.tabControl_TabClosed);
            // 
            // connectionsContextMenu
            // 
            this.connectionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionRefreshToolStripMenuItem,
            this.createDatabaseToolStripMenuItem,
            this.showUsersToolStripMenuItem,
            this.diagnosticsToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.connectionsContextMenu.Name = "connectionsContextMenu";
            this.connectionsContextMenu.Size = new System.Drawing.Size(160, 114);
            // 
            // connectionRefreshToolStripMenuItem
            // 
            this.connectionRefreshToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Refresh;
            this.connectionRefreshToolStripMenuItem.Name = "connectionRefreshToolStripMenuItem";
            this.connectionRefreshToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.connectionRefreshToolStripMenuItem.Text = "Refresh";
            this.connectionRefreshToolStripMenuItem.Click += new System.EventHandler(this.connectionRefreshToolStripMenuItem_Click);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.CreateDatabase;
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.createDatabaseToolStripMenuItem.Text = "Create Database";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // showUsersToolStripMenuItem
            // 
            this.showUsersToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Users;
            this.showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            this.showUsersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.showUsersToolStripMenuItem.Text = "Show Users";
            this.showUsersToolStripMenuItem.Click += new System.EventHandler(this.showUsersToolStripMenuItem_Click);
            // 
            // diagnosticsToolStripMenuItem
            // 
            this.diagnosticsToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Diagnostics;
            this.diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
            this.diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.diagnosticsToolStripMenuItem.Text = "Diagnostics";
            this.diagnosticsToolStripMenuItem.Click += new System.EventHandler(this.diagnosticsToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Disconnect;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // databaseContextMenu
            // 
            this.databaseContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseRefreshToolStripMenuItem,
            this.newQueryToolStripMenuItem,
            this.continousQueriesToolStripMenuItem,
            this.dropDatabaseToolStripMenuItem});
            this.databaseContextMenu.Name = "databaseContextMenu";
            this.databaseContextMenu.Size = new System.Drawing.Size(205, 92);
            // 
            // databaseRefreshToolStripMenuItem
            // 
            this.databaseRefreshToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Refresh;
            this.databaseRefreshToolStripMenuItem.Name = "databaseRefreshToolStripMenuItem";
            this.databaseRefreshToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.databaseRefreshToolStripMenuItem.Text = "Refresh";
            this.databaseRefreshToolStripMenuItem.Click += new System.EventHandler(this.databaseRefreshToolStripMenuItem_Click);
            // 
            // newQueryToolStripMenuItem
            // 
            this.newQueryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newQueryToolStripMenuItem.Image")));
            this.newQueryToolStripMenuItem.Name = "newQueryToolStripMenuItem";
            this.newQueryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newQueryToolStripMenuItem.Text = "New Query";
            this.newQueryToolStripMenuItem.Click += new System.EventHandler(this.newQueryMenuItem_Click);
            // 
            // continousQueriesToolStripMenuItem
            // 
            this.continousQueriesToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.ContinuousQuery;
            this.continousQueriesToolStripMenuItem.Name = "continousQueriesToolStripMenuItem";
            this.continousQueriesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.continousQueriesToolStripMenuItem.Text = "Show Continous Queries";
            this.continousQueriesToolStripMenuItem.Click += new System.EventHandler(this.continousQueriesToolStripMenuItem_Click);
            // 
            // dropDatabaseToolStripMenuItem
            // 
            this.dropDatabaseToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.DropDatabase;
            this.dropDatabaseToolStripMenuItem.Name = "dropDatabaseToolStripMenuItem";
            this.dropDatabaseToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dropDatabaseToolStripMenuItem.Text = "Drop Database";
            this.dropDatabaseToolStripMenuItem.Click += new System.EventHandler(this.dropDatabaseToolStripMenuItem_Click);
            // 
            // measurementContextMenu
            // 
            this.measurementContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQueryToolStripMenuItem1,
            this.tagKeysToolStripMenuItem,
            this.tagValuesToolStripMenuItem,
            this.fieldKeysToolStripMenuItem,
            this.showSeriesToolStripMenuItem,
            this.dropMeasurementToolStripMenuItem,
            this.dropSeriesToolStripMenuItem});
            this.measurementContextMenu.Name = "measurementContextMenu";
            this.measurementContextMenu.Size = new System.Drawing.Size(177, 158);
            // 
            // newQueryToolStripMenuItem1
            // 
            this.newQueryToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newQueryToolStripMenuItem1.Image")));
            this.newQueryToolStripMenuItem1.Name = "newQueryToolStripMenuItem1";
            this.newQueryToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.newQueryToolStripMenuItem1.Text = "New Query";
            this.newQueryToolStripMenuItem1.Click += new System.EventHandler(this.newQueryMenuItem_Click);
            // 
            // tagKeysToolStripMenuItem
            // 
            this.tagKeysToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.TagKeys;
            this.tagKeysToolStripMenuItem.Name = "tagKeysToolStripMenuItem";
            this.tagKeysToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tagKeysToolStripMenuItem.Text = "Show Tag Keys";
            this.tagKeysToolStripMenuItem.Click += new System.EventHandler(this.tagKeysToolStripMenuItem_Click);
            // 
            // tagValuesToolStripMenuItem
            // 
            this.tagValuesToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.TagValues;
            this.tagValuesToolStripMenuItem.Name = "tagValuesToolStripMenuItem";
            this.tagValuesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tagValuesToolStripMenuItem.Text = "Show Tag Values";
            this.tagValuesToolStripMenuItem.Click += new System.EventHandler(this.tagValuesToolStripMenuItem_Click);
            // 
            // fieldKeysToolStripMenuItem
            // 
            this.fieldKeysToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.FieldKeys;
            this.fieldKeysToolStripMenuItem.Name = "fieldKeysToolStripMenuItem";
            this.fieldKeysToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.fieldKeysToolStripMenuItem.Text = "Show Field Keys";
            this.fieldKeysToolStripMenuItem.Click += new System.EventHandler(this.fieldKeysToolStripMenuItem_Click);
            // 
            // showSeriesToolStripMenuItem
            // 
            this.showSeriesToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.Series;
            this.showSeriesToolStripMenuItem.Name = "showSeriesToolStripMenuItem";
            this.showSeriesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showSeriesToolStripMenuItem.Text = "Show Series";
            this.showSeriesToolStripMenuItem.Click += new System.EventHandler(this.showSeriesToolStripMenuItem_Click);
            // 
            // dropMeasurementToolStripMenuItem
            // 
            this.dropMeasurementToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.DropMeasurement;
            this.dropMeasurementToolStripMenuItem.Name = "dropMeasurementToolStripMenuItem";
            this.dropMeasurementToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dropMeasurementToolStripMenuItem.Text = "Drop Measurement";
            this.dropMeasurementToolStripMenuItem.Click += new System.EventHandler(this.dropMeasurementToolStripMenuItem_Click);
            // 
            // dropSeriesToolStripMenuItem
            // 
            this.dropSeriesToolStripMenuItem.Image = global::CymaticLabs.InfluxDB.Studio.Properties.Resources.DropSeries;
            this.dropSeriesToolStripMenuItem.Name = "dropSeriesToolStripMenuItem";
            this.dropSeriesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dropSeriesToolStripMenuItem.Text = "Drop Series";
            this.dropSeriesToolStripMenuItem.Click += new System.EventHandler(this.dropSeriesToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "InfluxDBStudio.json";
            this.saveFileDialog.Filter = "JSON files|*.json|All files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "InfluxDBStudio.json";
            this.openFileDialog.Filter = "JSON files|*.json|All files|*.*";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AppForm";
            this.Text = "InfluxDB Studio";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.connectionsContextMenu.ResumeLayout(false);
            this.databaseContextMenu.ResumeLayout(false);
            this.measurementContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView connectionsTreeView;
        private System.Windows.Forms.ContextMenuStrip connectionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionRefreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip databaseContextMenu;
        private System.Windows.Forms.ToolStripMenuItem databaseRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropDatabaseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip measurementContextMenu;
        private System.Windows.Forms.ToolStripMenuItem dropMeasurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem allowUntrustedSSLCertificatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continousQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton manageConnectionsButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton createDatabaseButton;
        private System.Windows.Forms.ToolStripButton showDiagnosticsButton;
        private System.Windows.Forms.ToolStripButton disconnectButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton runQueryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newQueryButton;
        private System.Windows.Forms.ToolStripButton dropDatabaseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton showSeriesButton;
        private System.Windows.Forms.ToolStripButton dropSeriesButton;
        private System.Windows.Forms.ToolStripButton dropMeasurementButton;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tagKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tagKeysButton;
        private System.Windows.Forms.ToolStripButton tagValuesButton;
        private System.Windows.Forms.ToolStripButton fieldKeysButton;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton showUsersButton;
        private System.Windows.Forms.ToolStripButton continuousQueryButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAppSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAppSettingsMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Controls.ExtendedTabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

