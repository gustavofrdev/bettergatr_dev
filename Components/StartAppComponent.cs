using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GATR_Project.Components
{
    public class StartAppComponent
    {
        private static bool _fileResultSuccess;
        private static string _loc = "GATR_Project/Data/Computers.json";

        public StartAppComponent()
        {
            var jsonFileExists = File.Exists(_loc);
            if (jsonFileExists)
            {
                var text = File.ReadAllText(_loc);
                Debug.WriteLine(text);
            }
            else
            {
                var error =
                    "O Programa não pôde continuar.\n Detalhes do Erro: \n Arquivo de dados(json) não encontrado no diretório: " +
                    _loc + " \nDeseja encontrar o arquivo manualmente? Caso contrário, o aplicativo encerrará!";
                var result = MessageBox.Show(error, "ERRO!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch (result)
                {
                    case DialogResult.No:
                        Environment.Exit(1);
                        break;
                    case DialogResult.Yes:
                        while (!_fileResultSuccess)
                        {
                            var (browserDialog, browserDialogResult) = DialogComponent.CreateBrowserDialog();
                            if (browserDialogResult == DialogResult.OK)
                            {
                                var isCorrect = MessageBox.Show(
                                    "Você selecionou o diretório: " + browserDialog.FileName +
                                    " está correto?\n Caso você selecione SIM, iremos trabalhar com esses dados.\n Caso você selecione NÃO, você poderá selecionar outro arquivo.",
                                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                switch (isCorrect)
                                {
                                    case DialogResult.Yes:
                                        _loc = browserDialog.FileName;
                                        _fileResultSuccess = true;
                                        break;
                                    case DialogResult.Cancel:
                                        Environment.Exit(1);
                                        break;
                                    case DialogResult.None:
                                        break;
                                    case DialogResult.OK:
                                        break;
                                    case DialogResult.Abort:
                                        break;
                                    case DialogResult.Retry:
                                        break;
                                    case DialogResult.Ignore:
                                        break;
                                    case DialogResult.No:
                                        break;
                                    default:
                                        continue;
                                }
                            }
                        }
                        break;
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public static Tuple<int, int> DefineResoulution()
        {
            var resolution = Screen.PrimaryScreen.Bounds;
            var height = resolution.Height - 100;
            var width = resolution.Width - 100;
            return Tuple.Create(height, width);
        }
    }
}