using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

/*CREATED BY JONNATAN FARIAS*/

namespace Navegador_CPD
{

    public partial class Form1 : Form

    {

        public Form1() 

        {
            
            InitializeComponent();
            InitializeAsync();
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            InitBrowser();
            // verifica se existe o arquivo
            if (!File.Exists(@"c:\temp\Navegadorcpdfavoritos.txt"))
            {
                File.Create(@"c:\temp\Navegadorcpdfavoritos.txt").Close();
            }
            else
            {
                // lê os items do arquivo...
                string[] lines = File.ReadAllLines(@"c:\temp\Navegadorcpdfavoritos.txt");
                this.comboBox1.Items.AddRange(lines);
            }
        }

        private async Task Initizated()
        {

            await webView.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser()

        {
            await Initizated();
            webView.CoreWebView2.Navigate("https://www.google.com.br");
            webView.CoreWebView2.DownloadStarting +=delegate(object sender , CoreWebView2DownloadStartingEventArgs args) {
                CoreWebView2Deferral deferral = args.GetDeferral();
                System.Threading.SynchronizationContext.Current.Post((_) =>
                {
                    using (deferral)
                    {
                        // Hide the default download dialog.
                        args.Handled = true;
                        var dialog = new TextInputDialog(
                            title: "Download Starting",
                            description: "Enter new result file path or select OK to keep default path. Select cancel to cancel the download.",
                            defaultInput: args.ResultFilePath);
                        if (dialog.ShowDialog() == true)
                        {
                            args.ResultFilePath = dialog.Input.ToString();
                            UpdateProgress(args.DownloadOperation);
                        }
                        else
                        {
                            args.Cancel = true;
                        }
                    }
                }, null);
            };
 
        }

        private void UpdateProgress(CoreWebView2DownloadOperation downloadOperation)
        {
            throw new NotImplementedException();
        }

        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            if (Uri.IsWellFormedUriString(addressBar.Text, UriKind.Absolute)) //Verifica se o texto digitado é uma url válida...
            {
                Uri uri = new Uri(addressBar.Text);
                webView.CoreWebView2.Navigate(uri.ToString()); //Caso seja uma Url válida navegará para ela
            }
            else
            {
                Uri uri = new Uri(@"https://www.google.com.br/search?q=" + addressBar.Text.Replace(" ", "+"));
                webView.CoreWebView2.Navigate(uri.ToString()); //Caso contrário, irá realizar a pesquisa no google
            }


        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoBack();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.GoForward();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.google.com.br");
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (Uri.IsWellFormedUriString(addressBar.Text, UriKind.Absolute)) //Verifica se o texto digitado é uma url válida...
                {
                    Uri uri = new Uri(addressBar.Text);
                    webView.CoreWebView2.Navigate(uri.ToString()); //Caso seja uma Url válida navegará para ela
                }
                else
                {
                    Uri uri = new Uri(@"https://www.google.com.br/search?q=" + addressBar.Text.Replace(" ", "+"));
                    webView.CoreWebView2.Navigate(uri.ToString()); //Caso contrário, irá realizar a pesquisa no google
                }
            }

        }

        private void btn_Fav_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(addressBar.Text);
            MessageBox.Show("FAVORITO SALVO COM SUCESSO!.", "MENSAGEM INTERNA", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // salva os items...
            string[] items = new string[this.comboBox1.Items.Count];
            this.comboBox1.Items.CopyTo(items, 0);
            File.WriteAllLines(@"c:\temp\Navegadorcpdfavoritos.txt", items);

        }

        private void btn_RemovFav_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {

                MessageBox.Show("POR FAVOR SELECIONAR UM FAVORITO PARA EXCLUIR!.", "MENSAGEM INTERNA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                string[] Lines = File.ReadAllLines(@"c:\temp\Navegadorcpdfavoritos.txt");
                File.Delete(@"c:\temp\Navegadorcpdfavoritos.txt");// Deleting the file
                using (StreamWriter sw = File.AppendText(@"c:\temp\Navegadorcpdfavoritos.txt"))

                {
                    foreach (string line in Lines)
                    {
                        if (line.IndexOf(addressBar.Text) >= 0)
                        {
                            //Skip the line
                            continue;
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("FAVORITO REMOVIDO COM SUCESSO!.", "MENSAGEM INTERNA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {

                var fav = addressBar.Text = comboBox1.SelectedItem.ToString();
                webView.CoreWebView2.Navigate(fav);

            }
        }
    }

    internal class TextInputDialog
    {
        internal object Input;
        private string title;
        private string description;
        private string defaultInput;

        public TextInputDialog(string title, string description, string defaultInput)
        {
            this.title = title;
            this.description = description;
            this.defaultInput = defaultInput;
        }

        internal bool ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
