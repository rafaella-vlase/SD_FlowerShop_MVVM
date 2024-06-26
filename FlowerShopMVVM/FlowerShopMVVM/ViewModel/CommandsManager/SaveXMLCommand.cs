﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel.CommandsManager
{
    public class SaveXMLCommand : ICommands
    {
        private VMManager vmManager;

        public SaveXMLCommand(VMManager vmManager)
        {
            this.vmManager = vmManager;
        }

        public void Execute(int dontCare) { }
        public void Execute(string dontCare) { }

        public void Execute()
        {
            try
            {
                if (vmManager != null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                    saveFileDialog.DefaultExt = "xml";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        vmManager.Flowers.TableName = "Flowers";
                        vmManager.Flowers.WriteXml(saveFileDialog.FileName);
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
