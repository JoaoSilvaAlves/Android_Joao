using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpUtils;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Pays_Click(object sender, EventArgs e)
        {

        }

        private void cbx_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string endPoint = "https://restcountries.eu/rest/v1/region/" + cbx_Region.Text;
                var client = new RestClient(endPoint);
                var json = client.MakeRequest();
                var objResponse = JsonConvert.DeserializeObject(json, typeof(List<Country>));

                //Converti dans le type requis
                Countries regionResponse = new Countries();
                regionResponse._allRegionCountries = (List<Country>)objResponse;

                //Nouvelles données dans la liste des pays
                cbx_Pays.Items.Clear();
                int nbCountries = regionResponse._allRegionCountries.Count;
                for (int i = 0; i < nbCountries; i++)
                {
                    cbx_Pays.Items.Add(regionResponse._allRegionCountries[i].name);
                    cbx_Pays.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbx_Pays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
