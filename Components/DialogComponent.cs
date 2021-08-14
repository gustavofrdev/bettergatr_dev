using System;
using System.Windows.Forms;

namespace GATR_Project.Components
{
    public static class DialogComponent
    {
        public static Tuple<OpenFileDialog, DialogResult> CreateBrowserDialog()
        {
            var browserDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Arquivo de Dados JSON (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            var browserDialogResult = browserDialog.ShowDialog();
            return Tuple.Create(browserDialog, browserDialogResult);
        }
    }
}