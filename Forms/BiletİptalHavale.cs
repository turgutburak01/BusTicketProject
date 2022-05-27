using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketProject
{
    public partial class BiletİptalHavale : Form
    {
        public BiletİptalHavale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Havale / Eft işlemi gerçekleşmiştir. .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BiletIptal biletIptal = new BiletIptal();
            biletIptal.Show();
            this.Hide();
        }

        private void BiletİptalHavale_Load(object sender, EventArgs e)
        {

        }
    }
}
