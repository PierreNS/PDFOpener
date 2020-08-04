using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourcesFolderTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenPDFBtn_Click(object sender, EventArgs e)
        {
           byte[] pdf = Properties.Resources.ThisWorks;

            MemoryStream ms = new MemoryStream(pdf);

            FileStream f = new FileStream("pdfFile.pdf", FileMode.OpenOrCreate);

            ms.WriteTo(f);
            f.Close();
            ms.Close();

            Process.Start("pdfFile.pdf");
        }
    }
}
