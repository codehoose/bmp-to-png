using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BMP2PNG
{
    public partial class BmpPngForm : Form
    {
        public BmpPngForm()
        {
            InitializeComponent();
        }

        private void Label1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Label1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var files = (string[])data;
                foreach (var f in files)
                {
                    Convert(f);
                }
            }
        }

        private void Convert(string path)
        {
            var extension = Path.GetExtension(path);
            if (extension.IndexOf("png", StringComparison.OrdinalIgnoreCase) >= 0) return;

            var image = Image.FromFile(path);

            var newFileName = path.Substring(0, path.Length - extension.Length) + ".png";
            image.Save(newFileName, ImageFormat.Png);           
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            var abt = new AboutBox();
            abt.ShowDialog();
        }
    }
}
