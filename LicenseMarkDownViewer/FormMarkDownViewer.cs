using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseInMarkDown;

namespace LicenseMarkDownViewer
{
    public partial class FormMarkDownViewer : Form
    {
        private MarkDownViewer _markDownViewer;

        public FormMarkDownViewer()
        {
            InitializeComponent();
        }


        private void FormMarkDownViewer_Load(object sender, EventArgs e)
        {
            _markDownViewer = new MarkDownViewer();
            _markDownViewer.InitializeComponent();

            this.elementHost1.Child = _markDownViewer;

            string EulaFile = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "apache-v2.0.md");

            _markDownViewer.Text = File.ReadAllText(EulaFile);
            _markDownViewer.IsReadOnly = true;

        }
    }
}
