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
using Hotcakes.CommerceDTO;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Client;

namespace Kliensalkalmazas_AzMintTavaly
{
    public partial class UjUtazasForm : Form
    {
        string keput;
        string bvin;
        ProductDTO globalProduct;
        public static Api Globalproxy2;
        public UjUtazasForm()
        {
            InitializeComponent();

            

            try
            {
                
                //product.ProductName = "temp";
                //product.SitePrice = 0;

                //globalProduct = ujproduct;
                //bvin = globalProduct.Bvin;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
 
        }

        private void kepvalaszto_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg),(*.jpeg),(*.png)|*.jpg;*.jpeg;*.png";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            keput = ofd.FileName;
            keput_TextBox.Text = keput;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {

                string url = API_csatl_form.API_csatl_info.url;
                string key = API_csatl_form.API_csatl_info.APIkey;
                Api proxy = new Api(url, key);
                var product = new ProductDTO();

                

                string kepFajlNev = keput_TextBox.Text.Split('\\').Last();
                
                product.ProductName = nev_TextBox.Text;
                product.UrlSlug = URLSlug_TextBox.Text;
                product.LongDescription = leiras_textBox.Text;
                product.SitePrice = ar_numericUpDown.Value;
                product.StoreId = 1;
                product.ImageFileMedium = kepFajlNev;
                product.ImageFileSmall = kepFajlNev;

                ApiResponse<ProductDTO> ujProdResponse = Form1.Globalproxy.ProductsCreate(product, null);
                ProductDTO ujproduct = ujProdResponse.Content;

                Form1.jelenlegiTermek = ujproduct;
                Form1.keput = keput;
                Form1.kepFajlNev = kepFajlNev;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
