using RestSharp;
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
            int cont = 0;
            
            foreach (var dato in ipnodos.Elements("nodos").Elements("IP"))
            {
                
                    MessageBox.Show(dato.Value);
                              
            }
            foreach (var item in ipnodos.Elements("texto"))
            {
                MessageBox.Show(item.Value);
            }
          

            //string archivoxml = System.IO.File.ReadAllText(abrir.FileName);
            //enviarjson(archivoxml);
            



           //llamadapost();
         //   Mensajes();


        }



        //---------------------- Enviado mensaje inorden a otra ip -----------------------------




        public static void Mensajes() {

            string inorden = "(2+7)*3";
            string ipnodo = "127.0.0.1";
            // falta un for para que haga todas las peticiones
            try
            {

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + ipnodo + ":5000/mensaje");
                httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    // enviando operacion inorden
                    string obj = inorden;
                    streamWriter.Write(obj);
                    streamWriter.Flush();
                    streamWriter.Close();


                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show("Solicitud al nodo"+ipnodo +"  "+result);

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("La peticion de mensaje fue rechazada por el nodo "+ipnodo );
            
            }


            }



        private void enviarjson(string dirreccion) {

            var nodo = new RestClient("http://127.0.0.1:5000/mensaje");
            var metodo = new RestRequest("/", Method.POST);
            string par = "(2+3)-7";
            metodo.AddParameter("inorden", par);
            IRestResponse responder = nodo.Execute(metodo);
            var respuesta = responder.Content;

            MessageBox.Show(respuesta);
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









            //    //try
            //    //{




            //    string user = "usuario";
            //    string contra = "contraseña";

            //    ASCIIEncoding encoding = new ASCIIEncoding();
            //    string postData = "user=" + user + "&pass=" + contra;
            //    byte[] data = encoding.GetBytes(postData);

            //    WebRequest request = WebRequest.Create("http://127.0.0.1:5000/metodopost");
            //    request.Method = "POST";
            //    request.ContentType = "application/x-www-form-urlencoded";
            //    request.ContentLength = data.Length;

            //    Stream stream = request.GetRequestStream();
            //    stream.Write(data, 0, data.Length);
            //    stream.Close();

            ////    WebResponse response = request.GetResponse();
            ////    stream = response.GetResponseStream();
            ////MessageBox.Show(stream.ToString());

            //HttpWebResponse respuest = (HttpWebResponse)request.GetResponse();
            //StreamReader redp = new StreamReader(respuest.GetResponseStream(),Encoding.ASCII);

            //MessageBox.Show(redp.ReadToEnd());
         




            //using (StreamReader read = new StreamReader(stream, Encoding.ASCII))
            //{
            //    String asciiSrt = read.ReadToEnd();
            //    Byte[] asciidata = Encoding.ASCII.GetBytes(asciiSrt);
            //    MessageBox.Show(asciiSrt);
            //}

            //StreamReader sr = new StreamReader(stream);
            //   MessageBox.Show.ReadToEnd());

            //sr.Close();
            //stream.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("HA ocurrido un error :" + ex.Message);

            //}








            //        byte[] data = Encoding.ASCII.GetBytes(
            //$"username={"dia"}&password={"hola"}");

            //        WebRequest request = WebRequest.Create("http://127.0.0.1:5000/metodopost");
            //        request.Method = "POST";
            //        request.ContentType = "application/x-www-form-urlencoded";
            //        request.ContentLength = data.Length;
            //        using (Stream stream = request.GetRequestStream())
            //        {
            //            stream.Write(data, 0, data.Length);
            //        }

            //        string responseContent = null;

            //        using (WebResponse response = request.GetResponse())
            //        {
            //            using (Stream stream = response.GetResponseStream())
            //            {
            //                using (StreamReader sr99 = new StreamReader(stream))
            //                {
            //                    responseContent = sr99.ReadToEnd();
            //                }
            //            }
            //        }

            //MessageBox.Show(responseContent);


























            //// Create a request using a URL that can receive a post. 
            //WebRequest request = WebRequest.Create("http://127.0.0.1:5000/metodopost");
            //// Set the Method property of the request to POST.
            //request.Method = "POST";
            //// Create POST data and convert it to a byte array.
            //string postData = "This is a test that posts this string to a Web server.";
            //byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            //// Set the ContentType property of the WebRequest.
            //request.ContentType = "application/x-www-form-urlencoded";
            //// Set the ContentLength property of the WebRequest.
            //request.ContentLength = byteArray.Length;
            //// Get the request stream.
            //Stream dataStream = request.GetRequestStream();
            //// Write the data to the request stream.
            //dataStream.Write(byteArray, 0, byteArray.Length);
            //// Close the Stream object.
            ////dataStream.Close();
            //// Get the response.
            //WebResponse response = request.GetResponse();
            //// Display the status.
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            //// Get the stream containing content returned by the server.
            //dataStream = response.GetResponseStream();
            //// Open the stream using a StreamReader for easy access.
            //StreamReader reader = new StreamReader((System.IO.Stream)dataStream);
            //// Read the content.
            //string responseFromServer = reader.ReadToEnd();
            //// Display the content.


            //Console.WriteLine(responseFromServer);                              
            //MessageBox.Show(responseFromServer);
            //// Clean up the streams.












            //   return "";

        }


    }
}
