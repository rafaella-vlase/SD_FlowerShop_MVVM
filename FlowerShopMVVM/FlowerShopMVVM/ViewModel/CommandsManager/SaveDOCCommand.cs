using System;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using FlowerShopMVVM.ViewModel;
using FlowerShopMVVM.ViewModel.CommandsManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

public class SaveDOCCommand : ICommands
{
    private VMManager vmManager;

    public SaveDOCCommand(VMManager vmManager)
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
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.DefaultExt = "docx";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (WordprocessingDocument document = WordprocessingDocument.Create(saveFileDialog.FileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                    {
                        MainDocumentPart mainPart = document.AddMainDocumentPart();
                        mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                        DocumentFormat.OpenXml.Wordprocessing.Body body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());

                        Table t = new Table();

                        for (int i = 0; i < vmManager.Flowers.Rows.Count; i++)
                        {
                            TableRow row = new TableRow();

                            for (int j = 0; j < vmManager.Flowers.Columns.Count; j++)
                            {
                                TableCell cell = new TableCell();
                                cell.Append(new Paragraph(new Run(new Text(vmManager.Flowers.Rows[i][j].ToString()))));
                                row.Append(cell);
                            }

                            t.Append(row);
                        }

                        body.Append(t);
                        document.Save();
                        MessageBox.Show("File saved successfully!");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}
