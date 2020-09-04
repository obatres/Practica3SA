# Practicas de Software Avanzado
# Practica3SA - REServ



> REServ es un crowdsourcing el cual tiene como objetivo prestar el servicio de delivery a varios restaurantes, dicha aplicacion consta de 3 partes:

## Servidor REST API
### Restaurante
> El cual esta desarrollado en C# y almacena los datos momentaneamente en una estructura de datos

## Cliente REST 
### Cliente
> El api que presta los servicios al cliente esta desarrollado en Pyhton y consume de los servicios que provee el servidor restaurante.

### Repartidor
> El api que presta los servicios a los repartidores esta desarrollado en Python y consumer de los servicios que provee el servidor del restaurante. 


>En conjunto, las tres partes son capaces de manejar pedidos con estado, dandole al cliente un tracker para que sepa el estado de su pedido en cualquier momento despues de realizar su orden. 

## Video de demostracion del funcionamiento
> https://youtu.be/P02DyvFvGTQ
## Historial de versiones
* 1.0
  * Primera version
  * CAMBIO: El servidor recibe pedido de los clientes y le informa tanto al repartidor como al cliente el estado del pedido.
  *         El cliente puede colocar pedidos en el restaurante que desee y se le asignara un repartidor, tambien puede consultar el estado de su pedido. 
  *         El repartidor puede consultar el pedido que le llevara al cliente, como consultar el estado cuando se encuentra en el restaurante y tambien actualizarlo cuando lo entregue al cliente. 
  
* 1.1
 *CAMBIO: Se manejan todos los servicios por medio de un ESB intermedio entre los clientes (cliente y repartidor) y el servidor (restaurante)
