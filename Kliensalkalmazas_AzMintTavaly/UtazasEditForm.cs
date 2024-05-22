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
using System.IO;

namespace Kliensalkalmazas_AzMintTavaly
{
    public partial class UtazasEditForm : Form
    {
        int arIdx, nevIdx, urlSlugIdx, leirasIdx, smallKepIdx, medKepIdx;
        string OG_JSON;
        string[] tordelt;
        string keput;
        string bvin;
        bool kep_Valtozik;
        ProductDTO globalTermek;

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
                globalTermek.SitePrice = ar_numericUpDown.Value;
                globalTermek.ProductName = nev_TextBox.Text;
                globalTermek.UrlSlug = URLSlug_TextBox.Text;
                globalTermek.LongDescription = leiras_textBox.Text;
                //tordelt[arIdx] = "SitePrice\":" + ar_numericUpDown.Value.ToString();
                //tordelt[nevIdx] = "ProductName\":\"" + nev_TextBox.Text+"\"";
                //tordelt[urlSlugIdx] = "UrlSlug\":\"" + URLSlug_TextBox.Text+"\"";
                //tordelt[leirasIdx] = "LongDescription\":\"" + leiras_textBox.Text + "\"";
                if (kep_Valtozik)
                {
                    string kepFajlNev = keput_TextBox.Text.Split('\\').Last();
                    //tordelt[smallKepIdx] = "ImageFileSmall\":\"" + kepFajlNev +"\"";
                    //tordelt[medKepIdx] = "ImageFileMedium\":\"" + kepFajlNev + "\"";
                    globalTermek.ImageFileMedium = kepFajlNev;
                    globalTermek.ImageFileSmall = kepFajlNev;

                    DirectoryInfo d = new DirectoryInfo("..\\..\\Kuldendo_kepek\\");

                    FileInfo[] Files = d.GetFiles();


                    foreach (FileInfo file in Files)
                    {
                        if (file.Name.Contains(bvin.ToUpper()))
                        {
                            File.Delete(file.FullName);
                        }
                    }

                    string[] tordelt2 = kepFajlNev.Split('.');
                    string ujkepnev = kepFajlNev.Replace('.' + tordelt2.Last(),"") + ";" + bvin.ToUpper() + '.'+tordelt2.Last();
                    File.Copy(keput, "..\\..\\Kuldendo_kepek\\" + ujkepnev);
                }
                //string uj_JSON = String.Join(",\"", tordelt);
                //ProductDTO frissTermek = JsonConvert.DeserializeObject<ProductDTO>(uj_JSON);
                //Form1.jelenlegiTermek = frissTermek;
                Form1.jelenlegiTermek = globalTermek;
                this.Close();
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
            globalTermek = termek;
            ar_numericUpDown.Value = globalTermek.SitePrice;
            nev_TextBox.Text = globalTermek.ProductName;
            URLSlug_TextBox.Text = globalTermek.UrlSlug;
            leiras_textBox.Text = globalTermek.LongDescription;
            bvin = globalTermek.Bvin;
            //OG_JSON = JsonConvert.SerializeObject(termek);
            //string JSON2 = OG_JSON.Replace(",\"", "␟");
            //tordelt = JSON2.Split('␟');

            //for (int i = 0; i < tordelt.Length; i++)
            //{

            //    if (tordelt[i].Contains("SitePrice\":"))
            //    {
            //        ar_numericUpDown.Value = Convert.ToInt32(tordelt[i].Split(':')[1].Split('.')[0].Trim());
            //        arIdx = i;
            //    }

            //    if (tordelt[i].Contains("ProductName\":"))
            //    {
            //        nev_TextBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':',"").Replace("\"", "");
            //        nevIdx = i;
            //    }

            //    if (tordelt[i].Contains("UrlSlug\":"))
            //    {
            //        URLSlug_TextBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
            //        urlSlugIdx = i;
            //    }

            //    if (tordelt[i].Contains("LongDescription\":"))
            //    {
            //        leiras_textBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
            //        leirasIdx = i;
            //    }

            //    if (tordelt[i].Contains("ImageFileSmall\":"))
            //    {
            //        keput_TextBox.Text = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
            //        smallKepIdx = i;
            //    }

            //    if (tordelt[i].Contains("ImageFileMedium\":"))
            //    {
            //        medKepIdx = i;
            //    }

            //    if (tordelt[i].Contains("Bvin\":"))
            //    {
            //        bvin = tordelt[i].Replace(tordelt[i].Split(':')[0] + ':', "").Replace("\"", "");
            //    }

            //}

        }
    }
}
