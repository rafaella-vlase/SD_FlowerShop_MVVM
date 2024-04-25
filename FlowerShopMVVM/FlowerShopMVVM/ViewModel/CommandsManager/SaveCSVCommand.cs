using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32; // Add this to use SaveFileDialog

namespace FlowerShopMVVM.ViewModel.CommandsManager
{
    public class SaveCSVCommand : ICommands
    {
        private VMManager vmManager;

        public SaveCSVCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute()
        {
            try
            {
                if (vmManager.Flowers != null)
                {
                    StringBuilder sb = new StringBuilder();

                    IEnumerable<string> columnNames = vmManager.Flowers.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in vmManager.Flowers.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        sb.AppendLine(string.Join(",", fields));
                    }

                    // Use SaveFileDialog to get the file path and name from the user
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Execute(string dontCare) { }
        public void Execute(int dontCare) { }

    }
}
