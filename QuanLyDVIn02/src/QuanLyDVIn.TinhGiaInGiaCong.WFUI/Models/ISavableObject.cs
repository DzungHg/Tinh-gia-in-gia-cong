using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI
{
    public interface ISavableObject
    {
        void Save(bool isAddingItem);
        void Delete();
        void Cancel();
    }
}
