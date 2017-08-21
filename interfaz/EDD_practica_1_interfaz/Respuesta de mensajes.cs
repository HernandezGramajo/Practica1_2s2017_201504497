using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDD_practica_1_interfaz
{
    public partial class Respuesta_de_mensajes : Form
    {
        public Respuesta_de_mensajes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {           // cambiar la ip con la que nos dan

                var nodo = new RestClient("http://127.0.0.1:5000/orden");
                var metodo = new RestRequest("/", Method.POST);
                        
                IRestResponse responder = nodo.Execute(metodo);
                var respuesta = responder.Content;

                string contenido = responder.Content.ToString();
                MessageBox.Show(respuesta.ToString());
                string inorden = "";
                string postorden = "";
                string resultado = "";
                int contador = 0;
                for (int i = 0; i < contenido.Length; i++)
                {
                    if (contenido[i].ToString()!=",")
                    {
                        if (contador==0)
                        {
                            inorden += contenido[i];
                        }else if(contador == 1)
                        {
                            postorden += contenido[i];
                        }
                        else if (contador == 2)
                        {
                            resultado += contenido[i];
                        }

                    }else
                    {
                         contador++;
                    }

                }
                dataGridView1.Rows.Add("", "", inorden, postorden,resultado);
                


            }
            catch (Exception ex)
            {

                MessageBox.Show("La peticion de mensaje fue rechazada por el nodo ");

            }






        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {           // cambiar la ip con la que nos dan

                var nodo = new RestClient("http://127.0.0.1:5000/ordenant");
                var metodo = new RestRequest("/", Method.POST);

                IRestResponse responder = nodo.Execute(metodo);
                var respuesta = responder.Content;

                string contenido = responder.Content.ToString();
                MessageBox.Show(respuesta.ToString());
                string inorden = "";
                string postorden = "";
                string resultado = "";
                int contador = 0;
                for (int i = 0; i < contenido.Length; i++)
                {
                    if (contenido[i].ToString() != ",")
                    {
                        if (contador == 0)
                        {
                            inorden += contenido[i];
                        }
                        else if (contador == 1)
                        {
                            postorden += contenido[i];
                        }
                        else if (contador == 2)
                        {
                            resultado += contenido[i];
                        }

                    }
                    else
                    {
                        contador++;
                    }

                }
                dataGridView1.Rows.Add("", "", inorden, postorden, resultado);



            }
            catch (Exception ex)
            {

                MessageBox.Show("La peticion de mensaje fue rechazada por el nodo ");

            }





        }
    }
}
