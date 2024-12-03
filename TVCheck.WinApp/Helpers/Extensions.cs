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

        public static void LoadCheckedData<T>(this CheckedListBox checkedListBox,List<T>dataSource, string displayMember = "Name", string valueMember = "ID")
        {
            checkedListBox.Items.Clear();
            foreach (var item in dataSource)
            {
                var displayValue = item.GetType().GetProperty(displayMember)?.GetValue(item,null);
                var realValue=item.GetType().GetProperty(valueMember)?.GetValue(item,null);
                if(displayValue!=null)
                {
                    checkedListBox.Items.Add(displayValue);
                }

            }
        }
    }
}
