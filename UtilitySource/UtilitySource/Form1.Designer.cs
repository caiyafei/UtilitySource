namespace UtilitySource
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
            this.rowDefinition1 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
            this.rowDefinition2 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
            this.rowDefinition3 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
            this.columnDefinition1 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.columnDefinition2 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.columnDefinition3 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.columnDefinition4 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.columnDefinition5 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.uC_ItemDocument = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uC_ItemDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.widgetView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.widgetView1});
            // 
            // widgetView1
            // 
            this.widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.widgetView1.AllowDragDropWobbleAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.widgetView1.Columns.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition[] {
            this.columnDefinition1,
            this.columnDefinition2,
            this.columnDefinition3,
            this.columnDefinition4,
            this.columnDefinition5});
            this.widgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.uC_ItemDocument});
            this.widgetView1.DocumentSpacing = 10;
            this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout;
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widgetView1.Rows.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition[] {
            this.rowDefinition1,
            this.rowDefinition2,
            this.rowDefinition3});
            this.widgetView1.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light;
            // 
            // uC_ItemDocument
            // 
            this.uC_ItemDocument.Caption = "UC_Item";
            this.uC_ItemDocument.ControlName = "UC_Item";
            this.uC_ItemDocument.ControlTypeName = "UtilitySource.UC_Item";
            this.uC_ItemDocument.Properties.AllowDragging = DevExpress.Utils.DefaultBoolean.False;
            this.uC_ItemDocument.Properties.ShowBorders = DevExpress.Utils.DefaultBoolean.False;
            this.uC_ItemDocument.Properties.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.uC_ItemDocument.Properties.ShowMaximizeButton = DevExpress.Utils.DefaultBoolean.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 603);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uC_ItemDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition3;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition4;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition5;
        private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition3;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document uC_ItemDocument;
    }
}

