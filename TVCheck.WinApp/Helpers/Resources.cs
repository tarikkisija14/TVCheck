using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TvCheck.WinApp;

namespace TVCheck.WinApp.Helpers
{
    public class Resources
    {
        static ResourceManager resourcemanager=new ResourceManager("TVCheck.WinApp.Resource1",typeof(frmLogin).Assembly);
        public static string Get(string key)
        {
            return resourcemanager.GetString(key);
        }
    }
}
