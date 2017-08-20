using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Threading;

using System.Net;
using System.IO;
using System.Collections;
using RestSharp;

namespace EDD_practica_1_interfaz
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        static   ArrayList nodoip = new ArrayList();
        static  ArrayList nodomasc = new ArrayList();
        static ArrayList nodos = new ArrayList();
        static ArrayList estadonodo = new ArrayList();
        static string iplocal = "";
        static string masc = "";
        private void button1_Click(object sender, EventArgs e)


        {
            string ruta = string.Empty;
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JSON|*.json";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                ruta = abrir.FileName;
                    
            }

           
            
           string archivojson = System.IO.File.ReadAllText(abrir.FileName);
            
            var json = Newtonsoft.Json.Linq.JObject.Parse(archivojson);
             iplocal = json["nodos"]["local"].ToString();
             masc= json["nodos"]["mascara"].ToString();

            int cont = 0;
            foreach (var item in json["nodos"]["nodo"])
            {
                nodoip.Add(json["nodos"]["nodo"][cont]["ip"].ToString()); 
                nodomasc.Add(json["nodos"]["nodo"][cont]["mascara"].ToString());
                nodos.Add("Nodo" + (cont + 1));
                
                cont++;
            }

          cambiaripserver();
           // llamadaip();

        }

        public void llamadaip() {

            for (int i = 0; i < nodoip.Count; i++)
            {
                try
                {



                    string url = "http://127.0.0.1:5000/conectado";
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse respuesta = (HttpWebResponse)request.GetResponse();
                    StreamReader red = new StreamReader(respuesta.GetResponseStream(), Encoding.ASCII);

                    estadonodo.Add(red.ReadToEnd());

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El nodo "+ nodoip[i]+ " esta desconectado");
                    estadonodo.Add("Desconectado");
                    
                }

               

            }
            for (int i = 0; i < nodoip.Count; i++)
            {
                DataGriv.Rows.Add(nodos[i], nodoip[i], nodomasc[i], estadonodo[i]);
            }

            //ThreadStart delegado = new ThreadStart(llamadaip);
            //Thread hilo = new Thread(delegado);

            //Thread.Sleep(20000);
            //hilo.Start();



        }

        private static void cambiaripserver() {
            
            try


            {

               

                var nodo = new RestClient("http://127.0.0.1:5000/nuevaip");
                var metodo = new RestRequest("/", Method.POST);
                metodo.AddParameter("iplocal", iplocal);
                metodo.AddParameter("mascara", masc);

                IRestResponse responder = nodo.Execute(metodo);
                var respuesta = responder.Content;

                MessageBox.Show(respuesta);

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la ip" + ex.Message) ;
            }


        }



    }
}
