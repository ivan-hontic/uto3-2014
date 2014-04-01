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
            float polumjer = 0;
            float.TryParse(txtPolumjer.Text, out polumjer);

            Izracunaj(polumjer);
        }

private void Izracunaj(float polumjer)
{
            float opseg = 0;
            float povrsina = 0;

            

            if (polumjer > 0)
            {
                opseg = 2 * polumjer * (float)Math.PI;
                povrsina = polumjer * polumjer * (float)Math.PI;

                txtOpseg.Text = Math.Round(opseg, 2).ToString();
                txtPovrsina.Text = Math.Round(povrsina, 2).ToString();
                                
            }
            if (chkSpremi.Checked == true) lstRezultati.Items.Add(polumjer);

}

        private void lstRezultati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            float polumjer = 0;

            float.TryParse(lstRezultati.SelectedItem.ToString(), out polumjer);

            txtPolumjer.Text = polumjer.ToString();
            //btnIzracunaj_Click(null, null);
            Izracunaj(polumjer)
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            lstRezultati.Items.Clear();

            txtOpseg.Text = "0,00";
            txtPolumjer.Text = "0,00";
            txtPovrsina.Text = "0,00";

        }
        
    }
}
