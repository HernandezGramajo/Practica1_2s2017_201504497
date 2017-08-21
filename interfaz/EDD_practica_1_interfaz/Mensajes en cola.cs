using RestSharp;
using System;
using System.Collections;
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


        ArrayList orden = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            //respuesta();
            operar();
        }


        public  void operar() {

            // opero los mensajes en cola y luego voy llamando al metdo para reponder
            //la cola tiene que estar visualizada en graphviz y tiene que 
            //irse actulizando cuando se vaya operado  hasta vaciarse
            try
            {           // cambiar la ip con la que nos dan

                var nodo = new RestClient("http://127.0.0.1:5000/sacarcola");
                var metodo = new RestRequest("/", Method.POST);

                IRestResponse responder = nodo.Execute(metodo);
                var respuesta = responder.Content;
                MessageBox.Show(respuesta.ToString());
                // *-------------- enviado para postorden
                string res = respuesta.ToString();





            }
            catch (Exception ex)
            {

                MessageBox.Show("La peticion de mensaje fue rechazada por el nodo ");

            }
            
           












           // respuesta();

        }

        public static void respuesta() {

            try
            {           // cambiar la ip con la que nos dan

                var nodo = new RestClient("http://127.0.0.1:5000/respuesta");
                var metodo = new RestRequest("/", Method.POST);

                metodo.AddParameter("inorden", "((21-17)+ (4*2))");
                metodo.AddParameter("postorden", "2 17 - 4 2 * +");
                metodo.AddParameter("resultado", "12");
                IRestResponse responder = nodo.Execute(metodo);
                var respuesta = responder.Content;

                MessageBox.Show(respuesta.ToString());



            }
            catch (Exception ex)
            {

                MessageBox.Show("La peticion de mensaje fue rechazada por el nodo ");

            }




        }


    }
}
