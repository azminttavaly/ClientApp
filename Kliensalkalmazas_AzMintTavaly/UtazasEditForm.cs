using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;
using Newtonsoft.Json;

namespace Kliensalkalmazas_AzMintTavaly
{
    public partial class UtazasEditForm : Form
    {
        int arIdx, nevIdx, urlSlugIdx, leirasIdx, smallKepIdx, medKepIdx;
        string OG_JSON;
        string[] tordelt;
        string keput;
        bool kep_Valtozik;

        private void kepvalaszto_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg),(*.jpeg),(*.png)|*.jpg;*.jpeg;*.png";
            ofd.Multiselect = false;
            kep_Valtozik = ofd.ShowDialog() == DialogResult.OK;
            keput = ofd.FileName;
            keput_TextBox.Text = keput;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void keput_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tordelt[arIdx]);
                tordelt[arIdx] = "SitePrice\":" + ar_numericUpDown.Value.ToString();
                tordelt[nevIdx] = "ProductName\":" + nev_TextBox.Text;
                tordelt[urlSlugIdx] = "UrlSlug\":" + URLSlug_TextBox.Text;
                tordelt[leirasIdx] = "LongDescription\":" + leiras_textBox.Text;
                if (kep_Valtozik)
                {
                    tordelt[smallKepIdx] = "ImageFileSmall\":" + keput_TextBox.Text.Split('\\').Last();
                    tordelt[medKepIdx] = "ImageFileMedium\":" + keput_TextBox.Text.Split('\\').Last();
                }
                string uj_JSON = String.Join(",\"", tordelt);
                ProductDTO frissTermek = JsonConvert.DeserializeObject<ProductDTO>(uj_JSON);
                Form1.jelenlegiTermek = frissTermek;
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public UtazasEditForm()
        {
            InitializeComponent();
        }


        public UtazasEditForm(ProductDTO termek)
        {
            InitializeComponent();
            OG_JSON = JsonConvert.SerializeObject(termek);
            string JSON2 = OG_JSON.Replace(",\"", "␟");
            tordelt = JSON2.Split('␟');
            
            for (int i = 0; i < tordelt.Length; i++)
            {

                if (tordelt[i].Contains("SitePrice\":"))
                {
                    ar_numericUpDown.Value = Convert.ToInt32(tordelt[i].Split(':')[1].Split('.')[0].Trim());
                    arIdx = i;
                }

                if (tordelt[i].Contains("ProductName\":"))
                {
                    nev_TextBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':',"").Replace("\"", "");
                    nevIdx = i;
                }

                if (tordelt[i].Contains("UrlSlug\":"))
                {
                    URLSlug_TextBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
                    urlSlugIdx = i;
                }

                if (tordelt[i].Contains("LongDescription\":"))
                {
                    leiras_textBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
                    leirasIdx = i;
                }

                if (tordelt[i].Contains("ImageFileSmall\":"))
                {
                    keput_TextBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
                    smallKepIdx = i;
                }

                if (tordelt[i].Contains("ImageFileMedium\":"))
                {
                    medKepIdx = i;
                }

            }

        }
    }
}
