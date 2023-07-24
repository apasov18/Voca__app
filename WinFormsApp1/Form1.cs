namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await web.EnsureCoreWebView2Async(null);
            string path = Path.Combine(Environment.CurrentDirectory, "Interface", "index.html");
            web.CoreWebView2.Navigate(path);
        }
    }
}