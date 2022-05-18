using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherLibrary_HW;

namespace WeatherCalulator_HW
{
    public partial class WeatherCalc : Form
    {
        public WeatherCalc()
        {
            InitializeComponent();
        } // end weather calc

        private void btnCalculateTemp_Click(object sender, EventArgs e)
        {
            double f_to_c = WeatherLibrary_HW.WeatherLibraryFuncs.FahrToCel(Double.Parse(txtFtoCInput.Text));
            txtCfromFAnswer.Text = f_to_c.ToString();

            double f_to_k = WeatherLibrary_HW.WeatherLibraryFuncs.FahrToKelv(Double.Parse(txtFtoKInput.Text));
            txtKfromFAnswer.Text = f_to_k.ToString();

            double c_to_f = WeatherLibrary_HW.WeatherLibraryFuncs.CelToFahr(Double.Parse(txtCtoFInput.Text));
            txtFfromCAnswer.Text = c_to_f.ToString();

            double c_to_k = WeatherLibrary_HW.WeatherLibraryFuncs.CelToKelv(Double.Parse(txtCtoKInput.Text));
            txtKfromCAnswer.Text = c_to_k.ToString();

        } // end Calc Temp

        private void btnCalculateRH_Click(object sender, EventArgs e)
        {
            double relativeHumidity = WeatherLibrary_HW.WeatherLibraryFuncs.RealtiveHumidity(Double.Parse(txtSVP.Text), Double.Parse(txtAVP.Text));
            txtRHAnswer.Text = relativeHumidity.ToString();

        } // end Calc RH

        private void btnCalculateHI_Click(object sender, EventArgs e)
        {
            double heatIndex = WeatherLibrary_HW.WeatherLibraryFuncs.HeatIndex(Double.Parse(txtHITempInput.Text), Double.Parse(txtRHInput.Text));
            txtHIAnswer.Text = heatIndex.ToString();

        } // end Calc Heat Index

        private void btnCalculateWC_Click(object sender, EventArgs e)
        {
            double windChill = WeatherLibrary_HW.WeatherLibraryFuncs.WindChill(Double.Parse(txtWS.Text), Double.Parse(txtTemperature.Text));
            txtWindChill.Text = windChill.ToString();

        } // end Calc Wind Chill

        private void btnCalculateWS_Click(object sender, EventArgs e)
        {
            double mph_to_knots = WeatherLibrary_HW.WeatherLibraryFuncs.MphToKnots(Double.Parse(txtMPHInput.Text));
            txtKnotsAnswer.Text = mph_to_knots.ToString();

            double knots_to_mph = WeatherLibrary_HW.WeatherLibraryFuncs.KnotsToMph(Double.Parse(txtKnotsInput.Text));
            txtMPHAnswer.Text = knots_to_mph.ToString();

        } // end Calc Wind Speed

    } // end class
} // end namespace
