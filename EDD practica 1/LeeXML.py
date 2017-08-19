from xml.dom import minidom

cont = 0

xmldoc= minidom.parse("mensaje.xml")

entrada = xmldoc.getElementsByTagName("mensaje")

for mess in entrada:

    nod = mess.getElementsByTagName("nodos")
    text = mess.getElementsByTagName("texto")
    ipss = mess.getElementsByTagName("IP")
    cont = cont+1

    print ("mensaje " + str(cont))

    for text2 in nod:

        ip = text2.getElementsByTagName("IP")

        for ips in ip:
            print(ips.firstChild.data)

    for text3 in text:
        print (text3.firstChild.data)




















class Nodo:
    def __init__(self, ip=None, sig=None):
        self.ip = ip
        self.sig = sig

    def __str__(self):
        return self.ip

class lSimple:
        def __init__(self):
            self.cabeza = None
            self.cola = None

        def agregar(self, elemento):
            if self.cabeza == None:
                self.cabeza = elemento
            if self.cola != None:
                self.cola.sig = elemento

            self.cola = elemento

        def listar(self):
            aux = self.cabeza
            while aux != None:
                print (aux)
                aux = aux.sig