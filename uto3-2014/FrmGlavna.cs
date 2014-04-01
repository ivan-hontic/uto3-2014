using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uto3_2014
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void lblPovrsina_Click(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float povrsina = 0;
            float opseg = 0;
            float polumjer = 0;

            float.TryParse(txtPolumjer.Text, out polumjer);

            if (polumjer > 0)
            {
                opseg = 2 * polumjer * (float)Math.PI;
                povrsina = polumjer * polumjer * (float)Math.PI;

                txtOpseg.Text = opseg.ToString();
                txtPovrsina.Text = povrsina.ToString();

                if (chkSpremi.Checked == true) lstRezultati.Items.Add(polumjer);
            }
        }

        private void lstRezultati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;

            float.TryParse(lstRezultati.SelectedItem.ToString(), out polumjer);

            txtPolumjer.Text = polumjer.ToString();
            btnIzracunaj_Click(null, null);
        }
    }
}
