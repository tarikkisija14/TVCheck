using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.WinApp.Helpers
{
    public static class Extensions
    {
        public static bool isSet(this string text)
        {
            return !string.IsNullOrEmpty(text);
        }

        public static void LoadData<T>(this ComboBox comboBox,List<T> dataSource,string displayMember="Name",string valueMember = "ID")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "ID";
        }
    }
}
