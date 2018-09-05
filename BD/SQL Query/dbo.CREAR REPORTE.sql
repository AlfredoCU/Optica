CREATE PROC reporteFacturaCompra

@idCompra int
AS
SELECT COMPRA.[Id Compra] AS IdCompra, COMPRA.[Fecha de Compra] AS FechaCompra, EXAMEN.[Id Examen] AS IdExamen,
EXAMEN.Costo AS costoExamen, PRODUCTO.[Id Producto] AS IdProducto, PRODUCTO.Nombre, PRODUCTO.Marca, 
PRODUCTO.Descripcion, PRODUCTO.Costo AS CostoProducto, 
COMPRA.Total
FROM COMPRA INNER JOIN PRODUCTO
ON PRODUCTO.[Id Producto] = COMPRA.[Id Producto]
INNER JOIN EXAMEN
ON EXAMEN.[Id Examen] = COMPRA.[Id Examen]
WHERE COMPRA.[Id Compra]=@idCompra
GO