using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;

namespace UtilitySource
{
    [UserRepositoryItem("RegisterDxMutiSelectGridEdit")]
    public class RepositoryItemDxMutiSelectGridEdit : RepositoryItemPopupContainerEdit
    {
        static RepositoryItemDxMutiSelectGridEdit()
        {
            RegisterDxMutiSelectGridEdit();
        }

        public const string CustomEditName = "DxMutiSelectGridEdit";

        #region 自定义属性和字段
        GridControl grid;
        GridView view;

        /// <summary>
        /// 显示列表View
        /// </summary>
        public GridView PopupView { get { return view; }}
        /// <summary>
        /// 数据源
        /// </summary>
        [Description("数据源"), AttributeProvider(typeof(IListSource)),
            DefaultValue(null), RefreshProperties(RefreshProperties.Repaint),
            DXCategory(CategoryName.Data)]
        public object DataSource
        {
            get { return grid.DataSource; }
            set
            {
                if (grid.DataSource != value)
                {
                    grid.DataSource = value;
                    OnPropertiesChanged();
                }
            }
        }

        /// <summary>
        /// 值成员字段名
        /// </summary>
        [Description("值成员名称"), DefaultValue(""), DXCategory(CategoryName.Data),
       TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"),
       Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
        public string ValueMember { get; set; }

        /// <summary>
        /// 显示文本成员字段名
        /// </summary>
        [Description("显示文本成员名称"), DefaultValue(""), DXCategory(CategoryName.Data),
         TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design"),
         Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor))]
        public string DisplayMember { get; set; }

        /// <summary>
        /// 分隔符
        /// </summary>
        [Description("分隔符")]
        public char SeparatorChar { get; set; } = ',';
        #endregion

        public RepositoryItemDxMutiSelectGridEdit()
        {
            PopupContainerControl panel = new PopupContainerControl();
            grid = new GridControl();
            view = new GridView(grid);
            grid.MainView = view;
            view.OptionsBehavior.Editable = false;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsFind.AlwaysVisible = true;
            view.OptionsSelection.MultiSelect = true;
            view.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            view.OptionsDetail.EnableMasterViewMode = false;
            view.BorderStyle = BorderStyles.NoBorder;
            //view.IndicatorWidth = 45;
            view.OptionsView.ShowIndicator = false;
            view.OptionsSelection.CheckBoxSelectorColumnWidth = 45;
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(grid);
            panel.Size = new Size(300, 340);
            this.PopupControl = panel;
        }

        public override string EditorTypeName => CustomEditName;

        

        public static void RegisterDxMutiSelectGridEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(DxMutiSelectGridEdit), typeof(RepositoryItemDxMutiSelectGridEdit), typeof(DxMutiSelectGridEditViewInfo), new DxMutiSelectGridEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemDxMutiSelectGridEdit source = item as RepositoryItemDxMutiSelectGridEdit;
                if (source == null) return;
                //
                //DataSource = source.DataSource;
                //DisplayMember = source.DisplayMember;
                //ValueMember = source.ValueMember;
                //SeparatorChar = source.SeparatorChar;
            }
            finally
            {
                EndUpdate();
            }
        }

        protected override void RaiseQueryPopUp(CancelEventArgs e)
        {
            base.RaiseQueryPopUp(e);
            if(OwnerEdit.EditValue?.ToString().Split(SeparatorChar) is string[] values)
            {
                view.BeginSelection();
                int lastFocusedHandle = 0;
                for (int i = 0; i < view.RowCount; i++)
                {
                    if (view.IsDataRow(i))
                    {
                        var text = view.GetRowCellValue(i, view.Columns[ValueMember]);
                        if (values.Any(p => p.Equals(text?.ToString())))
                        {
                            view.SelectRow(i);
                            lastFocusedHandle = i;
                        }
                    }
                }
                view.FocusedRowHandle = lastFocusedHandle;

                view.EndSelection();
            }
        }

        protected override void RaiseQueryResultValue(QueryResultValueEventArgs e)
        {
            base.RaiseQueryResultValue(e);
            var ids = view.GetSelectedRows();
            e.Value = string.Join(SeparatorChar.ToString(), ids.Select(s => view.GetRowCellValue(s, ValueMember).ToString()));
        }

        protected override void RaiseQueryDisplayText(QueryDisplayTextEventArgs e)
        {
            base.RaiseQueryDisplayText(e);
            if(e.EditValue is string value)
            {
                var vList = value.Split(SeparatorChar);
                var dList = new List<string>();
                for (int i = 0; i < view.RowCount; i++)
                {
                    if(view.IsDataRow(i)&& vList.Contains(view.GetRowCellValue(i, ValueMember).ToString()))
                    {
                        dList.Add(view.GetRowCellValue(i, DisplayMember).ToString());
                    }
                }
                e.DisplayText = string.Join(SeparatorChar.ToString(), dList);
            }
            else
            {
                e.DisplayText = "";
            }
        }
    }

    [ToolboxItem(true)]
    public class DxMutiSelectGridEdit : PopupContainerEdit
    {
        static DxMutiSelectGridEdit()
        {
            RepositoryItemDxMutiSelectGridEdit.RegisterDxMutiSelectGridEdit();
        }

        public DxMutiSelectGridEdit()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemDxMutiSelectGridEdit Properties => base.Properties as RepositoryItemDxMutiSelectGridEdit;

        public override string EditorTypeName => RepositoryItemDxMutiSelectGridEdit.CustomEditName;

        protected override PopupBaseForm CreatePopupForm()
        {
            if (Properties.PopupControl == null) return null;
            return new DxMutiSelectGridEditPopupForm(this);
        }

    }

    public class DxMutiSelectGridEditViewInfo : PopupContainerEditViewInfo
    {
        public DxMutiSelectGridEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class DxMutiSelectGridEditPainter : ButtonEditPainter
    {
        public DxMutiSelectGridEditPainter()
        {
        }
    }

    public class DxMutiSelectGridEditPopupForm : PopupContainerForm
    {
        public DxMutiSelectGridEditPopupForm(DxMutiSelectGridEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
