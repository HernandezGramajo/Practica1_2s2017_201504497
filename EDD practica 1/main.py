
import json
from flask import Flask,request,Response
from LeeJson import  ljson
import os
from cola import  Cola
col =Cola()
from ListaDobleEnlazada import Lista
listd = Lista()
from Arboles_Binarios import Arbol
ordenacion =Arbol(None,"")

app =Flask("Prueba")
#----------------Default-----------------------------------------------------------
l=ljson()

@app.route('/metodopost',methods=['POST'])
def carga():
    var = "Wi-Fi"
    iplocal = str(request.form['iplocal'])
    mascara =str(request.form['mascara'])

    os.system("netsh interface ip set address name="+var+" source=static addr="+iplocal+" mask="+mascara+" gateway=192.168.10.100 store=persistent")
    return "Exito !"





#---------------Nodo Activo metodo get-----------
@app.route('/conectado')
def activo():
  return '201504497'

#------ Para enviar mensajes  metodo post---------
@app.route('/mensaje',methods=['POST'])
def enviar():
    parametro= str(request.form['inorden'])

    col.insertarPrimero(parametro)
# hacer uso de la cola  restSharo
    return  "En cola"


#---------------- sacar dato y eliminar de la cola el mensaje
@app.route('/sacarcola',methods=['POST'])
def sacar():

    obtener =col.listarDesdeCola()
    col.borrarUltimo()

    return  obtener

#---------------- sacar dato y eliminar de la cola el mensaje
@app.route('/postorden',methods=['POST'])
def arbol():
    parametro = str(request.form['postorden'])
    cont =0
    for separar in parametro:
        if str(separar)!="(" | separar!=")":
            ordenacion.agregar(ordenacion,str(separar))
            cont = cont+1

    dato =str(ordenacion.InOrden() )
    return  dato
#--------------- Responder mensajes metodo post---------------
@app.route('/respuesta',methods=['POST'])
def responder():
     parametro = str(request.form['inorden'])
     parametro1 = str(request.form['postorden'])
     parametro2 = str(request.form['resultado'])
     contenido =str( parametro + ","+ parametro1 +","+parametro2)
     listd.insertarPrimero(contenido)

     return "true"

#------------------------------LIsta doble recientes
@app.route('/orden',methods=['POST'])
def orden():
   recientes = str (listd.listar())

   return recientes

#------------------------------LIsta doble antiguos
@app.route('/ordenant',methods=['POST'])
def ordenan():
   recientes = str (listd.listarDesdeCola())

   return recientes



#---------------- cambia ip----------
@app.route('/nuevaip',methods=['POST'])
def datos_json():
    var = "Wi-Fi"
    parametro = str(request.form['iplocal'])
    mascara =str(request.form['mascara'])
    os.system("netsh interface ip set address name=" + var + " source=static addr=" + parametro + " mask="+mascara+" gateway=192.168.0.1 store=persistent")





###-------------------------- ENVAR RUTA ------------------------------------------------
if __name__ == '__main__':
    app.run(
#       debug=True, host='0.0.0.0'

    )
   # cool.app.run(
   # host=cool.app.config.get("HOST", "localhost"),
   # port=cool.app.config.get("PORT", 9000)




















