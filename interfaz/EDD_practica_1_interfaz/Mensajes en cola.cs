using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDD_practica_1_interfaz
{
    public partial class Mensajes_en_cola : Form
    {
        public Mensajes_en_cola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operar();
        }


        public static void operar() {

            // opero los mensajes en cola y luego voy llamando al metdo para reponder
            //la cola tiene que estar visualizada en graphviz y tiene que 
            //irse actulizando cuando se vaya operado  hasta vaciarse
            respuesta();

        }

        public static void respuesta() {

            // hay que guardar la ip de la persona que nos hiso el mensaje junto con e mensaje para responderles



            string tresmensajes = "inorden , post orden ,resultado";
            string ipnodores = "127.0.0.1";
            // falta un for para que responda todas las peticiones
            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + ipnodores + ":5000/respuesta");
                httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    // enviando operacion inorden
                    string obj = tresmensajes;
                    streamWriter.Write(obj);
                    streamWriter.Flush();
                    streamWriter.Close();


                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show("Solicitud al nodo" + ipnodores + "  " + result);

                }



            }
            catch (Exception ex)
            {

                 MessageBox.Show("La resultado fue rechazada por el nodo  "+ ipnodores+"  "+ ex.Message);

            }





        }


    }
}
