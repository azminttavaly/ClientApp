﻿using System;
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
        public static ProductDTO aktualisTermek;
        public static List<ProductDTO> result;
        public static Api Globalproxy;

        public Form1()
        {
            InitializeComponent();
            API_csatl_form apcf = new API_csatl_form();
            apcf.ShowDialog();

            string url = API_csatl_form.API_csatl_info.url;
            string key = API_csatl_form.API_csatl_info.APIkey;

            Api proxy = new Api(url, key);
            Globalproxy = proxy;
            ApiResponse<List<ProductDTO>> response = proxy.ProductsFindAll();
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
            ApiResponse<ProductDTO> prodUpdateResponse = Globalproxy.ProductsUpdate(aktualisTermek);
        }
    }
}
