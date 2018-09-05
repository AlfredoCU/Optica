SELECT [Id Compra], Cantidad, [Fecha de Compra], EXAMEN.Costo, PRODUCTO.Costo, Total
FROM EXAMEN, PRODUCTO, COMPRA
WHERE EXAMEN.[Id Examen] = COMPRA.[Id Examen] AND PRODUCTO.[Id Producto] = COMPRA.[Id Producto]