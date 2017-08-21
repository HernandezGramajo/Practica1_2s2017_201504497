class Nodo:
    def __init__(self,dato):
        self.siguiente=None
        self.anterior=None
        self.info=dato


    def verNodo(self):
        return  self.info


class Cola:
    global cont

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




    def listarDesdeCola(self):
        temporal=self.cola
        while temporal !=None:
            paso=""+ str(temporal.verNodo())+ ""

            print temporal.verNodo()
            temporal = temporal.anterior

        return paso



    def borrarUltimo(self):
        if self.cola.anterior==None:
            self.cabeza=None
            self.cola=None
        else:
            self.cola=self.cola.anterior
            self.cola.siguiente=None



