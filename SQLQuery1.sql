use neptuno;

--Lista de los años de pedido
CREATE PROCEDURE Usp_ListaAnios 
AS
SELECT DISTINCT YEAR(fechapedido) AS Anios FROM Pedidos

Usp_ListaAnios

--Lista de pedidos segun el año de pedido
CREATE PROCEDURE Usp_Lista_Pedidos_Anios
@anio INT
AS
SELECT IdPedido,NombreCompañia,Apellidos + ' ' + Nombre AS Empleado, FechaPedido,FechaEntrega
FROM Clientes INNER JOIN Pedidos
ON Clientes.idCliente=Pedidos.IdCliente
INNER JOIN Empleados
ON Pedidos.IdEmpleado=Empleados.IdEmpleado
WHERE YEAR(FechaPedido)=@anio

CREATE PROCEDURE Usp_Detalle_Pedido
@idpedido INT
AS
SELECT detallesdepedidos.idpedido,NombreProducto,detallesdepedidos.preciounidad,Cantidad,detallesdepedidos.preciounidad*cantidad AS Monto
FROM detallesdepedidos INNER JOIN productos
ON detallesdepedidos.idProducto=Productos.idProducto
WHERE idPedido=@idpedido

--CASO PROPUESTO 1:
CREATE PROCEDURE Usp_Listado_Pedidos
AS
SELECT IdPedido,NombreCompañia,Apellidos + ' ' + Nombre AS Empleado, FechaPedido,FechaEntrega
FROM Clientes INNER JOIN Pedidos
ON Clientes.idCliente=Pedidos.IdCliente
INNER JOIN Empleados
ON Pedidos.IdEmpleado=Empleados.IdEmpleado

ALTER PROCEDURE Usp_Busqueda_Pedidos
@empleado VARCHAR(100)
AS
SELECT IdPedido,NombreCompañia,Apellidos + ' ' + Nombre AS Empleado, FechaPedido,FechaEntrega
FROM Clientes INNER JOIN Pedidos
ON Clientes.idCliente=Pedidos.IdCliente
INNER JOIN Empleados
ON Pedidos.IdEmpleado=Empleados.IdEmpleado
WHERE Apellidos + Nombre like '%'+@empleado+'%' 

Usp_Busqueda_Pedidos 'Bucha'


