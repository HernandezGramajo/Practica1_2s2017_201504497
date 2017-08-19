class Nodo:
    def __init__(self,dato):
        self.siguiente=None
        self.anterior=None
        self.info=dato


    def verNodo(self):
        return  self.info


class Lista:

    def __init__(self):
        self.cabeza=None
        self.cola=None



    def vacia(self):
        if self.cabeza==None:
            return  True
        else:
            return  False

    def insertarPrimero(self,dato):
        temporal=Nodo(dato)
        if self.vacia()==True:
            self.cabeza=temporal
            self.cola=temporal
        else:
            temporal.siguiente=self.cabeza
            self.cabeza.anterior=temporal
            self.cabeza=temporal


    def listar(self):
        temporal = self.cabeza
        while temporal!=None:
            print(temporal.verNodo())
            temporal = temporal.siguiente


    def listarDesdeCola(self):
        temporal=self.cola
        while temporal !=None:
            print temporal.verNodo()
            temporal = temporal.anterior


    def borrarPrimero(self):
        if self.vacia()==False:
            self.cabeza=self.cabeza.siguiente
            self.cabeza.anterior=None

    def borrarUltimo(self):
        if self.cola.anterior==None:
            self.cabeza=None
            self.cola=None
        else:
            self.cola=self.cola.anterior
            self.cola.siguiente=None


    def borrarPosicion(self,pos):
        anterior=self.cabeza
        actual=self.cabeza
        k=0
        if  pos > 0:
            while k !=pos and actual.siguiente !=None:
                anterior=actual
                actual=actual.siguiente
                k+=1

            if k==pos:
                temporal = actual.siguiente
                anterior.siguiente=actual.siguiente
                temporal.anterior=anterior

if __name__ == "__main__":


 listas = Lista()

 listas.insertarPrimero(1)
 listas.insertarPrimero(2)
 listas.insertarPrimero(3)
 listas.insertarPrimero(4)

## mostrar empezando por los mas recientes
 listas.listar()

 ## mostrar empezando por los mas antiguos
 listas.listarDesdeCola()
