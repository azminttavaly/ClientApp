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
        int eredetiar;
        string leiras, sku, nev;
        public UtazasEditForm()
        {
            InitializeComponent();
        }


        public UtazasEditForm(ProductDTO termek)
        {
            InitializeComponent();
            string OG_JSON = JsonConvert.SerializeObject(termek);
            string[] tordelt = OG_JSON.Split(',');
            for (int i = 0; i < tordelt.Length; i++)
            {

                if (tordelt[i].Contains("\"SitePrice\":"))
                {
                    //MessageBox.Show(tordelt[i].Split(':')[1].Split('.')[0]);
                    ar_numericUpDown.Value = Convert.ToInt32(tordelt[i].Split(':')[1].Split('.')[0].Trim());
                    //tordelt[i] = "\"SitePrice\":542000";
                }

                if (tordelt[i].Contains("\"ProductName\":"))
                {
                    nev_TextBox.Text =tordelt[i].Split(':')[1];
                }

                if (tordelt[i].Contains("\"UrlSlug\":"))
                {
                    URLSlug_TextBox.Text = tordelt[i].Split(':')[1];
                }

                if (tordelt[i].Contains("\"LongDescription\":"))
                {
                    leiras_listBox.Text = tordelt[i].Split(':')[1];
                }
            }
            string uj_JSON = String.Join(",", tordelt);
            ProductDTO frissTermek = JsonConvert.DeserializeObject<ProductDTO>(uj_JSON);
            Form1.aktualisTermek = frissTermek;
            return;
        }
    }
}
