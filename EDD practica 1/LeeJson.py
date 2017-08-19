import json
from pprint import pprint
class ljson:


  #def cargar(self,ruta):

  #cursos = json.dumps(ruta)
 # for curso in cursos:
#    ip = curso

   # return "conec"
 #def envio(self):
  #  return "conexion ok"


 def leerjosn (self,ruta):
  with open(ruta) as data_file:
   data = json.load(data_file)

   list = []
   print (data["nodos"]["local"])
   print (data["nodos"]["mascara"])

   cont =0
   while cont <=2:
    #print str (data["nodos"]["nodo"][cont]["ip"])
    print str(data["nodos"]["nodo"][cont]["mascara"])
    ip = data["nodos"]["nodo"][cont]["ip"]
    list.append(ip)
    cont = cont +1
    print( list)

   return "HOla"

#if __name__ == '__main__':

 #   ljson.leerjosn()