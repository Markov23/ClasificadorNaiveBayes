using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasificadorNaiveBayesTitanic
{
    public partial class Form1 : Form
    {
        double probabilidadSi = 0;
        double probabilidadNo = 0;
        double unidadPorcentaje = 0;
        double porcentajeSi = 0;
        double porcentajeNo = 0;

        public Form1()
        {
            InitializeComponent();

            cbClase.SelectedIndex = 0;
            cbEdad.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            probabilidadNo = 0;
            probabilidadSi = 0;
            porcentajeNo = 0;
            porcentajeSi = 0;
            unidadPorcentaje = 0;

            switch (cbClase.SelectedItem.ToString())
            {
                case "Primera":
                    probabilidadSi += 0.285513361;
                    probabilidadNo += 0.081879195;
                    break;

                case "Segunda":
                    probabilidadSi += 0.165963432;
                    probabilidadNo += 0.112080537;
                    break;

                case "Tercera":
                    probabilidadSi += 0.250351617;
                    probabilidadNo += 0.354362416;
                    break;

                case "Tripulación":
                    probabilidadSi += 0.298171589;
                    probabilidadNo += 0.451677852;
                    break;
            }

            switch(cbEdad.SelectedItem.ToString())
            {
                case "Adulto":
                    probabilidadSi += 0.919831224;
                    probabilidadNo += 0.965100671;
                    break;

                case "Niño":
                    probabilidadSi += 0.080168776;
                    probabilidadNo += 0.034899329;
                    break;
            }

            switch(cbSexo.SelectedItem.ToString())
            {
                case "Masculino":
                    probabilidadSi += 0.516174402;
                    probabilidadNo += 0.915436242;
                    break;

                case "Femenino":
                    probabilidadSi += 0.483825598;
                    probabilidadNo += 0.084563758;
                    break;
            }

            unidadPorcentaje = (probabilidadNo + probabilidadSi) / 100;
            porcentajeSi = probabilidadSi / unidadPorcentaje;
            porcentajeNo = probabilidadNo / unidadPorcentaje;

            if(porcentajeSi > porcentajeNo)
            {
                porcentajeSi = Math.Ceiling(porcentajeSi);
                porcentajeNo = Math.Floor(porcentajeNo);
            }
            else if(porcentajeNo > porcentajeSi)
            {
                porcentajeSi = Math.Floor(porcentajeSi);
                porcentajeNo = Math.Ceiling(porcentajeNo);
            }

            labelVivir.Text = "Probabilidad de sobrevivir: "+ porcentajeSi +"%";
            labelMorir.Text = "Probabilidad de morir: "+ porcentajeNo +"%";

            if (probabilidadSi > probabilidadNo)
            {
                pbResultado.Image = iconos.Images["vive.png"];
            }
            else if(probabilidadNo > probabilidadSi)
            {
                pbResultado.Image = iconos.Images["muere.png"];
            }
            else
            {
                pbResultado.Image = iconos.Images["resultado.png"];
                MessageBox.Show("Las probabilidades de sobrevivir o morir son las mismas. El resultado es indeterminado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbClase.SelectedIndex = 0;
            cbEdad.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;

            probabilidadSi = 0;
            probabilidadNo = 0;

            porcentajeNo = 0;
            porcentajeSi = 0;
            unidadPorcentaje = 0;

            pbResultado.Image = iconos.Images["resultado.png"];
            labelVivir.Text = "Probabilidad de sobrevivir: 0%";
            labelMorir.Text = "Probabilidad de morir: 0%";
        }
    }
}
