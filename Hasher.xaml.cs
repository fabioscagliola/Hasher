using com.fabioscagliola.Core.Data;
using DevExpress.Xpf.Editors;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace com.fabioscagliola.Hasher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = $"Hasher {Assembly.GetExecutingAssembly().GetName().Version.ToString(2)}";
        }

        private void Source_EditValueChanged(object sender, EditValueChangedEventArgs e)
        {
            string s = Source.Text;
            MD5 md5 = MD5.Create();
            byte[] computedHash = md5.ComputeHash(Encoding.UTF8.GetBytes(s));
            Target.Text = computedHash.ToHexString();
        }

    }
}

