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
using System.IO;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        Countries regionResponse = new Countries();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "Region-pays";
            tabControl1.TabPages[1].Text = "Meteo locale";

            GetCurrentMeteo("Neuchatel");
            GetCurrentMeteo("La-Chaux-de-Fonds");
        }

        private void cbx_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string endPoint = "https://restcountries.eu/rest/v1/region/" + cbx_Region.Text;
                var client = new RestClient(endPoint);
                var json = client.MakeRequest();
                object objResponse = JsonConvert.DeserializeObject(json, typeof(List<Country>));

                //Converti dans le type requis
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
            Country country = new Country();
            country = regionResponse._allRegionCountries.Find(x => x.name == cbx_Pays.Text);

            //Nouvelles données dans la liste des pays
            lstB_Informations.Items.Clear();
            lstB_Informations.Items.Add("Capitale : " + country.capital + Environment.NewLine);
            lstB_Informations.Items.Add("Population : " + country.population + Environment.NewLine);
        }

        private void GetCurrentMeteo(string ville)
        {
            AllPrevision meteoActuelle = new AllPrevision();
            string endPoint = "http://www.prevision-meteo.ch/services/json/" + ville;
            var client = new RestClient(endPoint);
            var json = client.MakeRequest();
            object objResponse = JsonConvert.DeserializeObject(json, typeof(AllPrevision));

            meteoActuelle.current_condition = (Current_Condition)objResponse;

            if (ville == "Neuchâtel")
            {
                lstBox_NE.Items.Add(meteoActuelle.city_info.name + Environment.NewLine);
                lstBox_NE.Items.Add(meteoActuelle.current_condition.condition + Environment.NewLine);
                lstBox_NE.Items.Add(meteoActuelle.current_condition.tmp + Environment.NewLine);
                pctBox_CDF.Load(meteoActuelle.current_condition.icon);
            }

            if(ville == "La-Chaux-de-Fonds")
            {
                lstBox_CDF.Items.Add(meteoActuelle.city_info.name + Environment.NewLine);
                lstBox_CDF.Items.Add(meteoActuelle.current_condition.condition + Environment.NewLine);
                lstBox_CDF.Items.Add(meteoActuelle.current_condition.tmp + Environment.NewLine);
                pctBox_CDF.Load(@"http://www.prevision-meteo.ch/style/images/icon/ensoleille.png");
            }
        }
    }
}
