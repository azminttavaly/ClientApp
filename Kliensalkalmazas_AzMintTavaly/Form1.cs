using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.Commerce.Catalog;
using Hotcakes.CommerceDTO;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;

namespace Kliensalkalmazas_AzMintTavaly
{
    public partial class Form1 : Form
    {
        public static ProductDTO jelenlegiTermek;
        public static List<ProductDTO> result;
        public static Api Globalproxy;
        public static string kepFajlNev;
        public static string keput;
        string bvin;

        public Form1()
        {
            InitializeComponent();
            API_csatl_form apcf = new API_csatl_form();
            apcf.ShowDialog();

            string url = API_csatl_form.API_csatl_info.url;
            string key = API_csatl_form.API_csatl_info.APIkey;

            Api proxy = new Api(url, key);
            Globalproxy = proxy;
            
            UtazasListaz();

        }

        private void UtazasListaz()
        {
            utazasokDGV.Rows.Clear();
            utazasokDGV.Refresh();

            ApiResponse<List<ProductDTO>> response = Globalproxy.ProductsFindAll();
            result = response.Content;
            for (int i = 0; i < result.Count; i++)
            {

                string ár = Math.Round(result[i].SitePrice, 0).ToString() + " Ft";

                utazasokDGV.Rows.Add(result[i].ProductName, ár);

            }
        }

        private void utazasokDGV_MouseClick(object sender, MouseEventArgs e)
        {
            UtazasEditForm UEF = new UtazasEditForm(result[utazasokDGV.SelectedCells[0].RowIndex]);
            UEF.ShowDialog();
            if (jelenlegiTermek != null)
            {
                try
                {
                    ApiResponse<ProductDTO> prodUpdateResponse = Globalproxy.ProductsUpdate(jelenlegiTermek);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            

            UtazasListaz();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            UjUtazasForm.Globalproxy2 = Globalproxy;
            UjUtazasForm ujtermekForm = new UjUtazasForm();
            ujtermekForm.ShowDialog();
            if(jelenlegiTermek != null) 
            {
                try
                {

                    //ApiResponse<ProductDTO> ujProdResponse = Globalproxy.ProductsCreate(jelenlegiTermek, null);
                    //ProductDTO result = ujProdResponse.Content;
                    //MessageBox.Show(result.Bvin);
                    ApiResponse<ProductDTO> prodUpdateResponse = Globalproxy.ProductsCreate(jelenlegiTermek,null);
                    bvin = prodUpdateResponse.Content.Bvin;
                    string[] tordelt2 = kepFajlNev.Split('.');
                    string ujkepnev = kepFajlNev.Replace('.' + tordelt2.Last(), "") + ";" + bvin.ToUpper() + '.' + tordelt2.Last();
                    File.Copy(keput, "..\\..\\Kuldendo_kepek\\" + ujkepnev);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            UtazasListaz();

        }
    }
}
