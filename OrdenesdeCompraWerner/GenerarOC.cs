using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenesdeCompraWerner
{
    public partial class GenerarOC : Form
    {
        public GenerarOC()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void GenerarOC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogos f3 = new Catalogos();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapturaOrden f4 = new CapturaOrden();
            f4.Show();
        }
    }
}
