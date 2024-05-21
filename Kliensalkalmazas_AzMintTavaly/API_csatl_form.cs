using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Kliensalkalmazas_AzMintTavaly
{
    public partial class API_csatl_form : Form
    {
        public API_csatl_form()
        {
            InitializeComponent();
        }

        public static class API_csatl_info 
        {
            public static string url;
            public static string APIkey;
        }
        

        private void buttonOFD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Config file (*.config)|*.config";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            string fajlut = ofd.FileName;
            string configSzoveg = File.ReadAllText(fajlut);
            configSzoveg = configSzoveg.Replace(Environment.NewLine, "");          

            try
            {
                string[] tordelt = configSzoveg.Split(',');
                foreach (string t in tordelt)
                {
                    if (t.StartsWith("url")) 
                    {
                        API_csatl_info.url = t.Split('=')[1].Trim();
                    }

                    if (t.StartsWith("key"))
                    {
                        API_csatl_info.APIkey = t.Split('=')[1].Trim();
                    }
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Sikertelen csatlakozás");
                System.Windows.Forms.Application.Exit();
            }
            this.Close();
        }
    }
}
