namespace MyApp
{
    partial class FrmMain
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
            DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions customHeaderButtonImageOptions1 = new DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions customHeaderButtonImageOptions2 = new DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.navPane = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navPageSecurity = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcSecurity = new DevExpress.XtraGrid.GridControl();
            this.gvSecurity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navPageEncrypt = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDecry = new DevExpress.XtraEditors.SimpleButton();
            this.btnEncry = new DevExpress.XtraEditors.SimpleButton();
            this.meTxt2 = new DevExpress.XtraEditors.MemoEdit();
            this.meTxt1 = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.navPageSqlSugar = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.txtCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPwd = new DevExpress.XtraEditors.ButtonEdit();
            this.txtUid = new DevExpress.XtraEditors.MRUEdit();
            this.txtServer = new DevExpress.XtraEditors.MRUEdit();
            ((System.ComponentModel.ISupportInitialize)(this.navPane)).BeginInit();
            this.navPane.SuspendLayout();
            this.navPageSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.navPageEncrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meTxt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meTxt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.navPageSqlSugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // navPane
            // 
            this.navPane.Controls.Add(this.navPageSecurity);
            this.navPane.Controls.Add(this.navPageEncrypt);
            this.navPane.Controls.Add(this.navPageSqlSugar);
            this.navPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPane.Location = new System.Drawing.Point(0, 0);
            this.navPane.Name = "navPane";
            this.navPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPageSecurity,
            this.navPageEncrypt,
            this.navPageSqlSugar});
            this.navPane.RegularSize = new System.Drawing.Size(895, 522);
            this.navPane.SelectedPage = this.navPageSecurity;
            this.navPane.Size = new System.Drawing.Size(895, 522);
            this.navPane.TabIndex = 0;
            this.navPane.Text = "主窗体";
            // 
            // navPageSecurity
            // 
            this.navPageSecurity.Caption = "密保信息";
            this.navPageSecurity.Controls.Add(this.layoutControl1);
            this.navPageSecurity.CustomHeaderButtons.AddRange(new DevExpress.XtraBars.Docking2010.IButton[] {
            new DevExpress.XtraBars.Docking.CustomHeaderButton("保存", true, customHeaderButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, serializableAppearanceObject1, null, -1),
            new DevExpress.XtraBars.Docking.CustomHeaderButton("修改", true, customHeaderButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, serializableAppearanceObject2, null, -1)});
            this.navPageSecurity.Name = "navPageSecurity";
            this.navPageSecurity.Size = new System.Drawing.Size(792, 449);
            this.navPageSecurity.CustomButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.navPageSecurity_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcSecurity);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(792, 449);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcSecurity
            // 
            this.gcSecurity.Location = new System.Drawing.Point(4, 4);
            this.gcSecurity.MainView = this.gvSecurity;
            this.gcSecurity.Name = "gcSecurity";
            this.gcSecurity.Size = new System.Drawing.Size(784, 441);
            this.gcSecurity.TabIndex = 4;
            this.gcSecurity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSecurity});
            // 
            // gvSecurity
            // 
            this.gvSecurity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvSecurity.GridControl = this.gcSecurity;
            this.gvSecurity.Name = "gvSecurity";
            this.gvSecurity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvSecurity.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvSecurity.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "应用";
            this.gridColumn1.FieldName = "AppType";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "账号";
            this.gridColumn2.FieldName = "UserName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "二级账号";
            this.gridColumn3.FieldName = "SecName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "密码";
            this.gridColumn4.FieldName = "UserPwd";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "二级密码";
            this.gridColumn5.FieldName = "SecPwd";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "备注";
            this.gridColumn6.FieldName = "Remark";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(792, 449);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcSecurity;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(788, 445);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // navPageEncrypt
            // 
            this.navPageEncrypt.Caption = "密保工具";
            this.navPageEncrypt.Controls.Add(this.layoutControl2);
            this.navPageEncrypt.Name = "navPageEncrypt";
            this.navPageEncrypt.PageText = "密保工具";
            this.navPageEncrypt.Size = new System.Drawing.Size(792, 449);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnDecry);
            this.layoutControl2.Controls.Add(this.btnEncry);
            this.layoutControl2.Controls.Add(this.meTxt2);
            this.layoutControl2.Controls.Add(this.meTxt1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(792, 449);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btnDecry
            // 
            this.btnDecry.Location = new System.Drawing.Point(355, 234);
            this.btnDecry.Name = "btnDecry";
            this.btnDecry.Size = new System.Drawing.Size(89, 22);
            this.btnDecry.StyleController = this.layoutControl2;
            this.btnDecry.TabIndex = 7;
            this.btnDecry.Text = "<-- 解密";
            this.btnDecry.Click += new System.EventHandler(this.btnDecry_Click);
            // 
            // btnEncry
            // 
            this.btnEncry.Location = new System.Drawing.Point(355, 188);
            this.btnEncry.Name = "btnEncry";
            this.btnEncry.Size = new System.Drawing.Size(89, 22);
            this.btnEncry.StyleController = this.layoutControl2;
            this.btnEncry.TabIndex = 6;
            this.btnEncry.Text = "加密 -->";
            this.btnEncry.Click += new System.EventHandler(this.btnEncry_Click);
            // 
            // meTxt2
            // 
            this.meTxt2.Location = new System.Drawing.Point(456, 4);
            this.meTxt2.Name = "meTxt2";
            this.meTxt2.Size = new System.Drawing.Size(332, 441);
            this.meTxt2.StyleController = this.layoutControl2;
            this.meTxt2.TabIndex = 5;
            // 
            // meTxt1
            // 
            this.meTxt1.Location = new System.Drawing.Point(4, 4);
            this.meTxt1.Name = "meTxt1";
            this.meTxt1.Size = new System.Drawing.Size(339, 441);
            this.meTxt1.StyleController = this.layoutControl2;
            this.meTxt1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(792, 449);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.meTxt1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(343, 445);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.meTxt2;
            this.layoutControlItem3.Location = new System.Drawing.Point(452, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(336, 445);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnEncry;
            this.layoutControlItem4.Location = new System.Drawing.Point(343, 184);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 12);
            this.layoutControlItem4.Size = new System.Drawing.Size(109, 36);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnDecry;
            this.layoutControlItem5.Location = new System.Drawing.Point(343, 220);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 12, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(109, 36);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(343, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(109, 184);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(343, 256);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(109, 189);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // navPageSqlSugar
            // 
            this.navPageSqlSugar.Caption = "快捷Sql";
            this.navPageSqlSugar.Controls.Add(this.labelControl4);
            this.navPageSqlSugar.Controls.Add(this.labelControl3);
            this.navPageSqlSugar.Controls.Add(this.labelControl2);
            this.navPageSqlSugar.Controls.Add(this.labelControl1);
            this.navPageSqlSugar.Controls.Add(this.gcList);
            this.navPageSqlSugar.Controls.Add(this.btnDelete);
            this.navPageSqlSugar.Controls.Add(this.btnUpdate);
            this.navPageSqlSugar.Controls.Add(this.btnInsert);
            this.navPageSqlSugar.Controls.Add(this.memoEdit1);
            this.navPageSqlSugar.Controls.Add(this.txtCategory);
            this.navPageSqlSugar.Controls.Add(this.txtPwd);
            this.navPageSqlSugar.Controls.Add(this.txtUid);
            this.navPageSqlSugar.Controls.Add(this.txtServer);
            this.navPageSqlSugar.Name = "navPageSqlSugar";
            this.navPageSqlSugar.Size = new System.Drawing.Size(792, 449);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "数据库：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 14);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "密  码：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "用户名：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "服务器：";
            // 
            // gcList
            // 
            this.gcList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcList.Location = new System.Drawing.Point(30, 209);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(298, 236);
            this.gcList.TabIndex = 8;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(30, 182);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(355, 3);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(417, 442);
            this.memoEdit1.TabIndex = 4;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(97, 137);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCategory.Size = new System.Drawing.Size(196, 20);
            this.txtCategory.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(97, 96);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPwd.Size = new System.Drawing.Size(196, 20);
            this.txtPwd.TabIndex = 2;
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(97, 56);
            this.txtUid.Name = "txtUid";
            this.txtUid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUid.Size = new System.Drawing.Size(196, 20);
            this.txtUid.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(97, 18);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtServer.Size = new System.Drawing.Size(196, 20);
            this.txtServer.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 522);
            this.Controls.Add(this.navPane);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navPane)).EndInit();
            this.navPane.ResumeLayout(false);
            this.navPageSecurity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.navPageEncrypt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meTxt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meTxt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.navPageSqlSugar.ResumeLayout(false);
            this.navPageSqlSugar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navPane;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageSecurity;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageEncrypt;
        private DevExpress.XtraGrid.GridControl gcSecurity;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSecurity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnDecry;
        private DevExpress.XtraEditors.SimpleButton btnEncry;
        private DevExpress.XtraEditors.MemoEdit meTxt2;
        private DevExpress.XtraEditors.MemoEdit meTxt1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageSqlSugar;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit txtCategory;
        private DevExpress.XtraEditors.ButtonEdit txtPwd;
        private DevExpress.XtraEditors.MRUEdit txtUid;
        private DevExpress.XtraEditors.MRUEdit txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

