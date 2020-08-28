# Libreria que se utiliza para el envio de datos por medio de JSON
import json
# Libreria que permite realizar HTTP requests
import requests

urlSolicitarPedido = "http://localhost:51630/api/pedido/3"


response = requests.get(urlSolicitarPedido)

print(response.text)