using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Menu.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Favourite : Page
    {
        public Favourite()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var input = new ModelInput();
            var sexo = textBox1.Text;
            var aux = textBox.Text;
            int edad = int.Parse(aux);
            var embarazo = textBox2.Text;
            var ingreso = textBox3.Text;
            var inicio = textBox4.Text;
            var fiebre = textBox5.Text;
            var tos = textBox6.Text;
            var diarrea = textBox7.Text;
            var vomito = textBox8.Text;
            var diabetes = textBox9.Text;
            var epoc = textBox10.Text;
            var asma = textBox11.Text;
            var hipertension = textBox12.Text;
            var obesidad = textBox13.Text;
            var tabaquismo = textBox14.Text;
            input.Sexo = sexo;
            input.Edad = edad;
            input.Esta_emabarazada = embarazo;
            input.Fecha_ingreso = ingreso;
            input.Fecha_inicio_sintomas = inicio;
            input.Fiebre = fiebre;
            input.Tos = tos;
            input.Diarrea = diarrea;
            input.Vomito = vomito;
            input.Diabetes = diabetes;
            input.Epoc = epoc;
            input.Asma = asma;
            input.Hipertension = hipertension;
            input.Obesidad = obesidad;
            input.Tabaquismo = tabaquismo;
            Hamburger-MenuML.Model.ModelOutput result = Hamburger - MenuML.Model.ConsumeModel.Predict(input);
            int resultado = int.Parse(result.ToString());





            listBox1.Items.Add(1);



        }
    }
}
