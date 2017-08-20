
import json
from flask import Flask,request,Response
from LeeJson import  ljson
import os
#from cola import  Cola
#colain =Cola()
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
    parametro= str(request.form['iplocal'])



 #   colain.insertarCola(parametro)
# hacer uso de la cola  restSharo
    return  "true"





#--------------- Responder mensajes metodo post---------------
@app.route('/respuesta',methods=['POST'])
def responder():
    # parametro = str(request.form['inorden'])
     #parametro1 = str(request.form['postorden'])
     #parametro2 = str(request.form['resultado'])

    # saco los datos des pues de haberlos pasado e  la pila y
    #el se almacenan en una lista doble
     return "true"




#---------------- Enviar datos json----------
@app.route('/nuevaip',methods=['POST'])
def datos_json():
    var = "Wi-Fi"
    parametro = str(request.form['iplocal'])
    mascara =str(request.form['mascara'])
    os.system("netsh interface ip set address name=" + var + " source=static addr=" + parametro + " mask="+mascara+" gateway=192.168.0.1 store=persistent")


#-------------------Enviar datos xml------------------------
@app.route('/xml')
def datos_xml():
    contenido=request.args.get('parametro','no contiene parametro')
    datos=l.cargar('{}'.format(contenido))

    return datos


###-------------------------- ENVAR RUTA ------------------------------------------------
if __name__ == '__main__':
    app.run(
#       debug=True, host='0.0.0.0'

    )
   # cool.app.run(
   # host=cool.app.config.get("HOST", "localhost"),
   # port=cool.app.config.get("PORT", 9000)




















