using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncHelper.Database
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
