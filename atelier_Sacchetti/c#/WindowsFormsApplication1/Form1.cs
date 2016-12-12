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
        Countries regionResponse = new Countries();
        
        public Form1()
        {
            InitializeComponent();

            tabControl1.SelectedIndex = 1;

            GetCurrentWeather("Neuchatel");
            GetCurrentWeather("Yverdon-les-bains");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "Region-pays";
            tabControl1.TabPages[1].Text = "Meteo locale";
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
            lstBox_Informations.Items.Clear();
            lstBox_Informations.Items.Add("Capitale : " + country.capital + Environment.NewLine);
            lstBox_Informations.Items.Add("Population : " + country.population + Environment.NewLine);
        }

        private void GetCurrentWeather(string city)
        {
            try
            {
                AllForecast ActualWeather = new AllForecast();
                string endPoint = "http://www.prevision-meteo.ch/services/json/" + city;
                var client = new RestClient(endPoint);
                var json = client.MakeRequest();
                object objJsonResponse = JsonConvert.DeserializeObject(json, typeof(AllForecast));

                //Convertir dans le type voulu
                ActualWeather = (AllForecast)objJsonResponse;

                grBox_CDF.Text = ActualWeather.city_info.name + " " + ActualWeather.current_condition.hour;

                if (city == "Neuchatel")
                {
                    lstBox_NE.Items.Clear();
                    grBox_NE.Text = ActualWeather.city_info.name + " " + ActualWeather.current_condition.hour;
                    lstBox_NE.Items.Add(ActualWeather.current_condition.condition + Environment.NewLine);
                    lstBox_NE.Items.Add(ActualWeather.current_condition.tmp + "°C" + Environment.NewLine);
                    pctBox_NE.Load(ActualWeather.current_condition.icon_big);
                }

                lstBox_CDF.Items.Clear();
                lstBox_CDF.Items.Add(ActualWeather.current_condition.condition + Environment.NewLine);
                lstBox_CDF.Items.Add(ActualWeather.current_condition.tmp + "°C" + Environment.NewLine);
                pctBox_CDF.Load(ActualWeather.current_condition.icon_big);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            //GetCurrentMeteo("Neuchatel");
        }
    }
}
