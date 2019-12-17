using System;
using System.Collections.Generic;
using System.Text;

namespace XamEFCore.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
