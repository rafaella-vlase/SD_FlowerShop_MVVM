using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using FlowerShopMVVM.ViewModel;
using FlowerShopMVVM.ViewModel.CommandsEmployee;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

public class SaveDOCEmployeeCommand : ICommands
{
    private VMEmployee vmEmployee;

    public SaveDOCEmployeeCommand(VMEmployee vmEmployee)
    {
        this.vmEmployee = vmEmployee;
    }

    public void Execute(int dontCare) { }
    public void Execute(string dontCare) { }

    public void Execute()
    {
        try
        {
            if (vmEmployee != null)
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
                        Debug.WriteLine("Save DOC Flowers Rows Number: " + vmEmployee.Flowers.Rows.Count + '\n');

                        for (int i = 0; i < vmEmployee.Flowers.Rows.Count; i++)
                        {
                            TableRow row = new TableRow();

                            for (int j = 0; j < vmEmployee.Flowers.Columns.Count; j++)
                            {
                                TableCell cell = new TableCell();
                                Debug.WriteLine("Cells: " + vmEmployee.Flowers.Rows[i][j].ToString() + '\n');
                                cell.Append(new Paragraph(new Run(new Text(vmEmployee.Flowers.Rows[i][j].ToString()))));
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
