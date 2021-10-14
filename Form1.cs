using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckIDNo
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e) // Design kısmının Name kısmında belirledik.
        {
            TcKimlikNoDogrulama.KPSPublic kps = new TcKimlikNoDogrulama.KPSPublic();
            bool check = kps.TCKimlikNoDogrula(long.Parse(txtIDNumber.Text), txtİsim.Text.ToUpper(), txtSurname.Text.ToUpper(), int.Parse(txtBirthday.Text));
            /* 1) DevNote: Tc No'ya Design kısmında veirlen isimi (property bölümü)
           2) İsim her zaman Büyük gelecek o yüzden toUpper metodu kullanıldı.                                                                            
           */
            if (check)
            {
                MessageBox.Show("Your Info has been confirmed", "Information: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your Info hasn't been confirmed", "Information: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
