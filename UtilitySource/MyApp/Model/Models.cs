using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace MyApp
{
    public class BaseModel : INotifyPropertyChanged
    {
        public BaseModel()
        {
            MState = ModelState.Normal;
            PropertyChanged += BaseModel_PropertyChanged;
        }

        public int Id { get; set; }
        string remark;
        public string Remark
        {
            get { return remark; }
            set
            {
                if (value != remark)
                {
                    remark = value; OnPropertyChanged();
                }
            }
        }
        [Write(false)]
        public ModelState MState { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void BaseModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((sender as BaseModel).MState== ModelState.Normal)
            {
                (sender as BaseModel).MState = ModelState.Dirty;
            }
        }
    }
    [Table("DictionaryMap")]
    public class DicMap: BaseModel
    {
        public string MapDesc { get; set; }
    }
    [Table("Dictionary")]
    public class Dictionary : BaseModel
    {
        public int DicType { get; set; }
        public string DicValue { get; set; }
    }
    [Table("Security")]
    public class Security : BaseModel
    {
        string appType;
        public string AppType
        { get { return appType; } set { if (value != appType) { appType = value;OnPropertyChanged(); } } }
        public string UserName { get; set; }
        public string SecName { get; set; }
        public string UserPwd { get; set; }
        public string SecPwd { get; set; }
    }

    public enum ModelState
    {
        Added,
        Dirty,
        Deleted,
        Normal
    }

    public class TList<T>:BindingList<T> where T:BaseModel
    {
        public List<T> DelItems;
        public List<T> NewItems;
        public TList(IEnumerable<T> ts):base(ts.ToList())
        {
            DelItems = new List<T>();
            NewItems = new List<T>();
        }
        
        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if(e.ListChangedType== ListChangedType.ItemDeleted)
            {
                if (this[e.OldIndex].MState != ModelState.Added)
                    DelItems.Add(this[e.OldIndex]);
                else
                    NewItems.Remove(this[e.OldIndex]);
            }
            else if(e.ListChangedType== ListChangedType.ItemAdded)
            {
                NewItems.Add(this[e.NewIndex]);
            }
            base.OnListChanged(e);
        }
        protected override object AddNewCore()
        {
            object obj= base.AddNewCore();
            (obj as BaseModel).MState = ModelState.Added;
            return obj;
        }
    }

    public static class Extends
    {
        public static TList<T> ToTList<T>(this IEnumerable<T> ts) where T : BaseModel
        {
            return new TList<T>(ts);
        }
    }
}
