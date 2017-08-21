
class Arbol:

    def __init__(self,arbol,dato):
        self.derecha =None
        self.izquierda = None
        self.info = dato


    def agregar (self, arbol,dato):
        if arbol.info > dato:
            self.agregaIzquierda(arbol,dato)
        elif arbol.info < dato:
            self.agregaDerecha(arbol,dato)

    def agregaIzquierda(self,arbol,dato):
        if arbol.izquierda == None:
            arbol.izquierda=Arbol(arbol,dato)
        else:
            self.agregar(arbol.izquierda,dato)

    def agregaDerecha(self,arbol,dato):
        if arbol.derecha==None:
            arbol.derecha= Arbol(arbol,dato)
        else:
            self.agregar(arbol.derecha,dato)

    def preOrden (self,arbol):
        print (arbol.info )
        if arbol.izquierda!=None:
            self.preoIzquierda(arbol)
        if arbol.derecha!=None:
            self.preoDerecha(arbol)

    def preoIzquierda(self,arbol):
        self.preOrden(arbol.izquierda)

    def preoDerecha (self,arbol):
        self.preOrden(arbol.derecha)

    def InOrden(self,arbol):
        if arbol.izquierda!=None:
            self.inOrIzquierda(arbol)
        print (arbol.info )

        if arbol.derecha!=None:
            self.inOrIDerecha(arbol)

    def inOrIzquierda(self,arbol):
        self.InOrden(arbol.izquierda)

    def inOrIDerecha(self,arbol):
        self.InOrden(arbol.derecha)

    def PostOrden(self,arbol):
        if arbol.izquierda!=None:
            self.postIzquierda(arbol)
        if arbol.derecha!=None:
            self.postIDerecha(arbol)
        print (arbol.info )

    def postIzquierda(self,arbol):
        self.PostOrden(arbol.izquierda)

    def postIDerecha(self,arbol):
        self.PostOrden(arbol.derecha)



arbol = Arbol(None,2)
arbol.agregar(arbol,3)
arbol.agregar(arbol,"+")
arbol.agregar(arbol,"*")
arbol.agregar(arbol,4)
arbol.agregar(arbol,"-")
arbol.agregar(arbol,7)
print ("PreOrden")
arbol.preOrden(arbol)
print ("")
print ("InOrden")
arbol.InOrden(arbol)
print ("")
print ("PostOrden")
arbol.PostOrden(arbol)

