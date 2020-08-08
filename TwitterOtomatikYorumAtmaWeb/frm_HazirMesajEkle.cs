using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterOtomatikYorumAtmaWeb
{
    public partial class frm_HazirMesajEkle : Form
    {
        public static ComboBox mesajlar;
        public frm_HazirMesajEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMesaj.Text.Equals("") || txtMesaj.Text.Equals(null))
            {
                MessageBox.Show("Lütfen değer girin.");
            }
            else
            {
                cmbxMesajList.Items.Add(txtMesaj.Text);
                if (cmbxMesajList.Items.Count > 0)
                    cmbxMesajList.SelectedIndex = cmbxMesajList.Items.Count - 1;
                mesajlar = cmbxMesajList;
                txtMesaj.Clear();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbxMesajList.Items.Count > 0)
            {
                cmbxMesajList.Items.RemoveAt(cmbxMesajList.SelectedIndex);
                if (cmbxMesajList.Items.Count > 0)
                    cmbxMesajList.SelectedIndex = 0;
                mesajlar = cmbxMesajList;
            }
        }

        private void frm_HazirMesajEkle_Load(object sender, EventArgs e)
        {
            if (frmHome.hazirmesajlar.Items.Count > 0)
            {
                for (int i = 0; i < frmHome.hazirmesajlar.Items.Count; i++)
                {
                    cmbxMesajList.Items.Add(frmHome.hazirmesajlar.Items[i].ToString());
                }
                cmbxMesajList.SelectedIndex = 0;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            mesajlar = cmbxMesajList;
        }

        private void frm_HazirMesajEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            mesajlar = cmbxMesajList;
        }
    }
}
