# Libreria que se utiliza para el envio de datos por medio de JSON
import json
# Libreria que permite realizar HTTP requests
import requests
# Libreria que obtiene el dia y la hora 
from datetime import datetime

# Archivo de Logs
Log=open("LogCliente.txt","w") 

#-----------------------------Solicitar pedido al restaurante---------------
# URL para solicitar pedido
urlSolicitarPedido = "http://localhost:51630/api/pedido/"
# Id del cliente que solicita pedido
idCliente = "3"
# Request que solicita el pedido al servidor del restaurante
response = requests.get(urlSolicitarPedido+idCliente)
# Fecha y hora actual
now = datetime.now()
# Log del pedido solicitado
Log.write(str(now)+" "+"Pedido solicitado "+str(response.json())+" "+"\n") 


#-----------------------------Solicitar estado del pedido al restaurante
# Id del pedido
pedido = response.json().get("id")
# Id del cliente que posee el pedido
cliente = response.json().get("idCliente")
# Estado del pedido del cliente 
estado = response.json().get("estado")
# Log del estado del pedido solicitado
Log.write(str(now)+" el pedido "+str(pedido)+" del cliente "+str(cliente)+" se encuentra en el estado "+str(estado)+" "+"\n")

#-----------------------------Enviar pedido al restaurante

# Cierra Archivo de Logs
Log.close() 
