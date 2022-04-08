using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public interface IDataUtils
    {
        TList<T> GetAll<T>() where T : BaseModel;

        void Update<T>(TList<T> list) where T : BaseModel;
    }
}
