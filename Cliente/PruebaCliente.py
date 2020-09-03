# Libreria que se utiliza para el envio de datos por medio de JSON
import json
# Libreria que permite realizar HTTP requests
import requests
# Libreria que obtiene el dia y la hora 
from datetime import datetime

# URL para solicitar pedido
urlSolicitarPedido = "http://localhost:56949/api/buscliente/"

urlEnviarPedido = urlSolicitarPedido +"agregar"
# variable headers que inidican en que formato se esta enviando la informacion
headers = {
    'content-type': 'application/json'
}
# Variable data que contiene la informacion necesaria para colocar un pedido en el servidor del restaurante
data = {
    "id":10,
    "descripcion":"Pedido 10",
    "idrestaurante": 10,
    "idrepartidor":10,
    "idcliente":10,
    "estado":10
    }

# Variable responser que realizar la accion POST al servidor restaurante para colocar el pedido
response  = requests.request("POST",urlEnviarPedido,data=json.dumps(data),headers=headers)

print(response.status_code)