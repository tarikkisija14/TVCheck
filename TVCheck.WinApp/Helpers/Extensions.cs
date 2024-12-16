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

        public static void LoadCheckedData<T>(this CheckedListBox checkedListBox, List<T> dataSource, string displayMember = "Name", string valueMember = "ID", List<T> selectedItems = null)
        {
            checkedListBox.Items.Clear();

            selectedItems = selectedItems ?? new List<T>();

            foreach (var item in dataSource)
            {
                var displayValue = item.GetType().GetProperty(displayMember)?.GetValue(item, null)?.ToString();

                if (displayValue != null)
                {
                    checkedListBox.Items.Add(displayValue);

                    if (selectedItems.Contains(item))
                    {
                        int index = checkedListBox.Items.IndexOf(displayValue);
                        if (index >= 0)
                        {
                            checkedListBox.SetItemChecked(index, true);
                        }
                    }
                }
            }
        }



        public static object GetRow(this DataGridView dataGridView)
        {
            if (dataGridView.CurrentRow == null)
                throw new Exception("You haven't selected anything");
            return dataGridView.CurrentRow.DataBoundItem;
            
        }



    }
}
