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

namespace Kliensalkalmazas_AzMintTavaly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            API_csatl_form apcf = new API_csatl_form();
            apcf.ShowDialog();

            string url = API_csatl_form.API_csatl_info.url;
            string key = API_csatl_form.API_csatl_info.APIkey;

            
            Api proxy = new Api(url, key);

            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();
            List<ProductDTO> result = response.Content;
            
            
            for (int i = 0; i < result.Count; i++)
            {
            
                string ár = Math.Round(result[i].SitePrice, 0).ToString() + " Ft";
            
            
                utazasokDGV.Rows.Add(result[i].ProductName, ár);
            
            }
            
            ApiResponse<List<ProductImageDTO>> kepek = proxy.ProductImagesFindAllByProduct(result[0].Bvin);
            List<ProductImageDTO> kepek2 = kepek.Content;

            

            
            //pictureBox1.Image = kepek2[0];
            //MessageBox.Show(kepek2[0].ProductId);
        }
    }
}
