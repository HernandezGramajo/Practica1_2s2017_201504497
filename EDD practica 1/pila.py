class Nodo:
    def __init__(self,dato):
        self.siguiente=None
        self.anterior=None
        self.info=dato


    def verNodo(self):
        return  self.info


class Pila:

    def __init__(self):
        self.cabeza=None
        self.cola=None



    def vacia(self):
        if self.cabeza==None:
            return  True
        else:
            return  False



    def listar(self):
        temporal = self.cabeza
        while temporal!=None:
            print(temporal.verNodo())
            p=temporal.verNodo()
            temporal = temporal.siguiente
        return p


    def borrarPrimero(self):
        if self.vacia()==False:
            self.cabeza=self.cabeza.siguiente
            self.cabeza.anterior=None
