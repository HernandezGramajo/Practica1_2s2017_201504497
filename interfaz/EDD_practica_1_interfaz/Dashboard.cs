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

        static ArrayList ipnodo = new ArrayList();
        static string dato = "";
        static string[]  ipnodos  = { "127.0.0.1", "127.0.0.1" } ;
        private void button1_Click(object sender, EventArgs e)


        {
            string ruta = string.Empty;
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JSON|*.json";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                ruta = abrir.FileName;
                    
            }

           
            // MessageBox.Show(ruta);
           string archivojson = System.IO.File.ReadAllText(abrir.FileName);
            // string datos = cambiaripserver(ruta);
            //  MessageBox.Show("hola " + dato);
            //    llamadaip();
            dynamic json = JsonConvert.DeserializeObject(archivojson);


            //JObject json = new JObject();
            // json = JObject.Parse(archivojson);
            MessageBox.Show(json["nodo"].toString());
            Console.WriteLine(json[""].tostring());
            
       
            
        }

        public void llamadaip() {

            for (int i = 0; i < ipnodos.Length; i++)
            {
                try
                {



                    string url = "http://192.168.43.112:5000/conectado";
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse respuesta = (HttpWebResponse)request.GetResponse();
                    StreamReader red = new StreamReader(respuesta.GetResponseStream(), Encoding.ASCII);



                   MessageBox.Show(red.ReadToEnd());
                    //  return red.ToString();

                   DataGriv.Rows.Add("Nodo","IP","Mascara","Estado");
                

                }
                catch (Exception ex)
                {
                    MessageBox.Show("El nodo "+ ipnodos[i]+ " esta desconectado");
                }


            }

            ThreadStart delegado = new ThreadStart(llamadaip);
            Thread hilo = new Thread(delegado);
            
            Thread.Sleep(20000);
            hilo.Start();


        }

        private static string cambiaripserver(string arjson) {
            
            try


            {

                //// ?parametro=


                //string url = "http://127.0.0.1:5000/json/"+arjson;
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //HttpWebResponse respuesta = (HttpWebResponse)request.GetResponse();
                //StreamReader red = new StreamReader(respuesta.GetResponseStream( ),Encoding.ASCII);



                //MessageBox.Show(red.ReadToEnd());
                //var l = red.ReadToEnd();
                //string ips = l.ToString();              
                // MessageBox.Show(l);

                var nodo = new RestClient("http://127.0.0.1:5000/json");
                var metodo = new RestRequest("/", Method.POST);
                metodo.AddParameter("json", arjson);
                IRestResponse responder = nodo.Execute(metodo);
                var respuesta = responder.Content;

                MessageBox.Show(respuesta);


                //for (int i = 0; i < ips.Length; i++)
                //{
                //    if (ips[i].Equals('['))
                //    {

                //    }
                //    else if (ips[i].Equals("'"))
                //    {


                //    }
                //    else if (ips[i].Equals(','))
                //    {
                //        ipnodo.Add(ips[i]);
                //        dato = "";
                //    }
                //    else
                //    {
                //        dato += ips[i];
                //    }
                //}
                //for (int i = 0; i < ipnodo.Count; i++)
                //{
                //    MessageBox.Show(ipnodo[i].ToString());
                //}

                return respuesta;
            }
            catch (Exception ex)
            {
                return "Error al traer la informacion"+ex.Message;
            }


        }



    }
}
