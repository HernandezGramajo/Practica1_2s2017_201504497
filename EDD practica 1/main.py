
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
    #parametro=str(request.form['user='])
    #contrase=str(request.form['&pass='])111111111111
    return "HOla !"





#---------------Nodo Activo metodo get-----------
@app.route('/conectado')
def activo():
  return '201504497'

#------ Para enviar mensajes  metodo post---------
@app.route('/mensaje',methods=['POST'])
def enviar():
    var = "Wi-Fi"
    os.system("netsh interface ip set address name="+var+" source=static addr=192.168.11.10 mask=255.255.255.0 gateway=192.168.10.100 store=persistent")


    parametro = str(request.form['inorden'])
 #   colain.insertarCola(parametro)
# hacer uso de la cola  restSharo
    return  "true"+ parametro

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
@app.route('/json',methods=['POST'])
def datos_json(url):
    
   # contenido=request.args.get('parametro','no contiene parametro')
   parametro = str(request.form['json'])
   dato = l.leerjosn(parametro)
   return dato + "REgreso"

#-------------------Enviar datos xml------------------------
@app.route('/xml')
def datos_xml():
    contenido=request.args.get('parametro','no contiene parametro')
    datos=l.cargar('{}'.format(contenido))

    return datos


###-------------------------- ENVAR RUTA ------------------------------------------------
if __name__ == '__main__':
    app.run(
       debug=True, host='0.0.0.0'

    )
   # cool.app.run(
   # host=cool.app.config.get("HOST", "localhost"),
   # port=cool.app.config.get("PORT", 9000)






















#    ls = lSimple()
 #   ruta = 'nodos2.json'
#    carga_datos(ruta)

#data = {"Fruteria": [{"Fruta": [{"Nombre": "Manzana", "Cantidad": 10}, {"Nombre": "Pera", "Cantidad": 20},{"Nombre": "Naranja", "Cantidad": 30}]}, { "Verdura": [{"Nombre": "Lechuga", "Cantidad": 80}, {"Nombre": "Tomate", "Cantidad": 15}, {"Nombre": "Pepino", "Cantidad": 50}]}]}
#data_string = json.dumps(data)
#print 'ENCODED:', data_string



