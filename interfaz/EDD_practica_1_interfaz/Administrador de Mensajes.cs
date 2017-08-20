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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EDD_practica_1_interfaz
{
    public partial class Administrador_de_Mensajes : Form
    {
        public Administrador_de_Mensajes()
        {
            InitializeComponent();
        }


        static string ipserver = "";
        ArrayList msip = new ArrayList();
         ArrayList mstex = new ArrayList();

        private void button2_Click(object sender, EventArgs e)
        {
            Mensajes_en_cola cola = new Mensajes_en_cola();
            cola.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Respuesta_de_mensajes respuesta = new Respuesta_de_mensajes();
            respuesta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "XML|*.xml";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                
            }


            XDocument documento = XDocument.Load(abrir.FileName);
           
            var ipnodos = from ips in documento.Descendants("mensaje") select ips;
            
            foreach (var dato in ipnodos.Elements("nodos").Elements("IP"))
            {

                msip.Add(dato.Value);
                    MessageBox.Show(dato.Value);
                              
            }
           foreach (var item in ipnodos.Elements("texto"))
            {
                mstex.Add(item.Value);
               MessageBox.Show(item.Value);
            }
          

            //string archivoxml = System.IO.File.ReadAllText(abrir.FileName);
            //enviarjson(archivoxml);
            



           //llamadapost();
      Mensajes();


        }



        //---------------------- Enviado mensaje inorden a otra ip -----------------------------




        public void Mensajes() {

            for (int i = 0; i < msip.Count; i++)
            {
                try
                {

                    var nodo = new RestClient("http://127.0.0.1:5000/mensaje");
                    var metodo = new RestRequest("/", Method.POST);

                    metodo.AddParameter("inorden", mstex[i]);
                    IRestResponse responder = nodo.Execute(metodo);
                    var respuesta = responder.Content;

                    MessageBox.Show(respuesta.ToString());



                }
                catch (Exception ex)
                {

                    MessageBox.Show("La peticion de mensaje fue rechazada por el nodo " );

                }

            }
            msip.Clear();
            mstex.Clear();

        }





        public void llamadapost()
        {
            // hacer que la direccion ip cambien entodos comforme cargue el archivo json y conecte la direccion hacer un string que puda ser visitado por todas lasclases y un if que lo permita

            try
            {
                if (ipserver=="")
                {
                    ipserver = "192.168.43.33";
                }

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://"+ipserver +":5000/metodopost");
                httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
                //httpWebRequest.Accept =   
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    
                    string obj = "enviadon informacion";
                    streamWriter.Write(obj);
                    streamWriter.Flush();
                    streamWriter.Close();


                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    
                    string l = result.ToString();
                    MessageBox.Show(l);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);
            }


        }


    }
}
