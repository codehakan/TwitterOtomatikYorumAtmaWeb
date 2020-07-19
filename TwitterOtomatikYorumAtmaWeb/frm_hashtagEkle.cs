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
    public partial class frm_hashtagEkle : Form
    {
        public static ComboBox hashtagler;
        public frm_hashtagEkle()
        {
            InitializeComponent();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtHashtag.Text.Equals("") || txtHashtag.Text.Equals(null))
            {
                MessageBox.Show("Lütfen değer girin.");
            }
            else
            {
                cmbxHashtagList.Items.Add(txtHashtag.Text);
                if (cmbxHashtagList.Items.Count > 0)
                    cmbxHashtagList.SelectedIndex = cmbxHashtagList.Items.Count-1;
                hashtagler = cmbxHashtagList;
                txtHashtag.Clear();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbxHashtagList.Items.Count > 0)
            {
                cmbxHashtagList.Items.RemoveAt(cmbxHashtagList.SelectedIndex);
                if (cmbxHashtagList.Items.Count > 0)
                    cmbxHashtagList.SelectedIndex = 0;
                hashtagler = cmbxHashtagList;
            }
        }

        private void frm_hashtagEkle_Load(object sender, EventArgs e)
        {
            if (frmHomePage.hashtagler.Items.Count > 0)
            {
                for (int i = 0; i < frmHomePage.hashtagler.Items.Count; i++)
                {
                    cmbxHashtagList.Items.Add(frmHomePage.hashtagler.Items[i].ToString());
                }
                cmbxHashtagList.SelectedIndex = 0;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            hashtagler = cmbxHashtagList;
        }

        private void frm_hashtagEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            hashtagler = cmbxHashtagList;
        }
    }
}
