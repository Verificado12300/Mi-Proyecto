PRAGMA foreign_keys = ON;

BEGIN TRANSACTION;

-- Empresa demo
INSERT OR IGNORE INTO Empresa
    (RUC, RazonSocial, NombreComercial, Direccion, Departamento, Provincia, Distrito, Ubigeo, Telefono, Email, Web, Activo)
VALUES
    ('20123456789', 'Agropecuaria Demo S.A.C.', 'AgroDemo', 'Av. Principal 123 - Centro', 'Lima', 'Lima', 'Lima', '150101', '999111222', 'contacto@agrodemo.pe', 'www.agrodemo.pe', 1);

-- Clientes demo
INSERT OR IGNORE INTO Clientes
    (TipoDocumento, NumeroDocumento, Nombres, Apellidos, RazonSocial, Direccion, Telefono, Email, LimiteCredito, Activo)
VALUES
    ('DNI', '70987654', 'Luis', 'Mendoza', NULL, 'Jr. Los Olivos 120', '987654321', 'luis.mendoza@mail.com', 500, 1),
    ('DNI', '71543210', 'Rosa', 'Quispe', NULL, 'Av. Libertad 441', '976543210', 'rosa.quispe@mail.com', 600, 1),
    ('RUC', '20604561234', NULL, NULL, 'Fundo El Valle E.I.R.L.', 'Carretera Norte Km 8', '945667788', 'ventas@elvalle.pe', 2500, 1),
    ('DNI', '73890124', 'Marcos', 'Vargas', NULL, 'Calle Comercio 15', '944332211', 'marcos.vargas@mail.com', 400, 1),
    ('RUC', '20456789123', NULL, NULL, 'Ganaderia San Pedro S.R.L.', 'Sector La Pradera S/N', '933224466', 'admin@sanpedro.pe', 3000, 1);

-- Proveedores demo
INSERT OR IGNORE INTO Proveedores
    (RUC, RazonSocial, NombreComercial, Direccion, Telefono, Email, Contacto, TelefonoContacto, Activo)
VALUES
    ('20600011122', 'Distribuidora Agro Norte S.A.C.', 'Agro Norte', 'Av. Industrial 455', '912345678', 'ventas@agronorte.pe', 'Carmen Ruiz', '912345679', 1),
    ('20600033344', 'Veterinaria El Campo S.A.C.', 'Vet Campo', 'Jr. Los Cedros 890', '913456789', 'pedidos@vetcampo.pe', 'Jorge Salas', '913456780', 1),
    ('20600055566', 'Insumos Rurales del Peru S.A.C.', 'Insumos Rurales', 'Parque Industrial Mz B Lt 10', '914567890', 'comercial@insumosrurales.pe', 'Milagros Pena', '914567891', 1);

-- 10 productos demo
INSERT OR IGNORE INTO Productos
    (Codigo, CodigoBarras, Nombre, Descripcion, CategoriaID, UnidadBaseID, StockTotal, StockMinimo, StockMaximo, ProveedorID, FechaUltimaModificacion, Activo)
VALUES
    ('PRD001', '750000000001', 'Alimento Balanceado Engorde 25kg', 'Alimento para ganado en etapa de engorde', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Alimentos Balanceados' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Kilogramo' LIMIT 1), 120, 20, 300, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600011122'), datetime('now'), 1),
    ('PRD002', '750000000002', 'Alimento Balanceado Inicial 10kg', 'Formula inicial para terneros y becerros', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Alimentos Balanceados' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Kilogramo' LIMIT 1), 80, 15, 200, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600011122'), datetime('now'), 1),
    ('PRD003', '750000000003', 'Vitamina AD3E Frasco 250ml', 'Suplemento vitaminico para bovinos y caprinos', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Vitaminas' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Mililitro' LIMIT 1), 60, 10, 120, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600033344'), datetime('now'), 1),
    ('PRD004', '750000000004', 'Complejo B Inyectable 100ml', 'Complejo B para recuperacion nutricional', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Vitaminas' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Mililitro' LIMIT 1), 55, 10, 100, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600033344'), datetime('now'), 1),
    ('PRD005', '750000000005', 'Antibiotico Veterinario LA 100ml', 'Tratamiento de amplio espectro', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Medicamentos' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Mililitro' LIMIT 1), 40, 8, 90, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600033344'), datetime('now'), 1),
    ('PRD006', '750000000006', 'Antiparasitario Oral 500ml', 'Control interno y externo de parasitos', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Antiparasitarios' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Mililitro' LIMIT 1), 35, 8, 70, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600033344'), datetime('now'), 1),
    ('PRD007', '750000000007', 'Vacuna Triple Bovino 10 dosis', 'Proteccion contra enfermedades respiratorias', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Vacunas' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Unidad' LIMIT 1), 70, 12, 150, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600055566'), datetime('now'), 1),
    ('PRD008', '750000000008', 'Desinfectante Ganadero 1L', 'Desinfeccion de corrales y ambientes', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Desinfectantes' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Litro' LIMIT 1), 90, 15, 200, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600055566'), datetime('now'), 1),
    ('PRD009', '750000000009', 'Bebedero Automatico Bovino', 'Accesorio plastico de alto flujo', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Accesorios' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Unidad' LIMIT 1), 25, 5, 60, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600055566'), datetime('now'), 1),
    ('PRD010', '750000000010', 'Comedero Metalico 1.5m', 'Comedero reforzado para campo', (SELECT CategoriaID FROM Categorias WHERE Nombre = 'Accesorios' LIMIT 1), (SELECT UnidadID FROM UnidadesBase WHERE Nombre = 'Unidad' LIMIT 1), 18, 4, 40, (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600055566'), datetime('now'), 1);

-- Presentaciones por producto (1 por producto para pruebas rapidas)
INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 70, 90, 20, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Saco'
WHERE p.Codigo = 'PRD001';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 36, 48, 12, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Bolsa'
WHERE p.Codigo = 'PRD002';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 24, 35, 11, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Frasco'
WHERE p.Codigo = 'PRD003';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 18, 28, 10, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Frasco'
WHERE p.Codigo = 'PRD004';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 50, 72, 22, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Frasco'
WHERE p.Codigo = 'PRD005';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 55, 80, 25, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Frasco'
WHERE p.Codigo = 'PRD006';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 22, 35, 13, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Caja'
WHERE p.Codigo = 'PRD007';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 16, 24, 8, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Bidón'
WHERE p.Codigo = 'PRD008';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 85, 120, 35, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Unidad'
WHERE p.Codigo = 'PRD009';

INSERT OR IGNORE INTO ProductoPresentaciones
    (ProductoID, PresentacionID, CantidadUnidades, CostoBase, PrecioVenta, Ganancia, Activo)
SELECT p.ProductoID, pr.PresentacionID, 1, 110, 160, 50, 1
FROM Productos p
JOIN Presentaciones pr ON pr.Nombre = 'Unidad'
WHERE p.Codigo = 'PRD010';

-- Compras demo
INSERT OR IGNORE INTO Compras
    (NumeroCompra, Fecha, Hora, ProveedorID, TipoComprobante, Serie, Numero, IncluyeIGV, SubTotal, IGV, Total, MetodoPago, Estado, UsuarioID, Observaciones)
VALUES
    ('C-000001', '2026-02-10', '09:10:00', (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600011122'), 'FACTURA', 'F001', '000120', 1, 500.00, 90.00, 590.00, 'EFECTIVO', 'COMPLETADA', 1, 'Compra inicial de alimentos'),
    ('C-000002', '2026-02-11', '11:25:00', (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600033344'), 'FACTURA', 'F001', '000121', 1, 300.00, 54.00, 354.00, 'CREDITO', 'CREDITO', 1, 'Compra de antiparasitarios'),
    ('C-000003', '2026-02-12', '15:40:00', (SELECT ProveedorID FROM Proveedores WHERE RUC = '20600055566'), 'FACTURA', 'F001', '000122', 1, 200.00, 36.00, 236.00, 'TRANSFERENCIA', 'COMPLETADA', 1, 'Compra de accesorios');

INSERT INTO CompraDetalles (CompraID, ProductoID, ProductoPresentacionID, Cantidad, CostoUnitario, Subtotal, CantidadUnidadesBase)
SELECT c.CompraID, p.ProductoID, pp.ProductoPresentacionID, 5, 70, 350, 5
FROM Compras c
JOIN Productos p ON p.Codigo = 'PRD001'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE c.NumeroCompra = 'C-000001'
  AND NOT EXISTS (SELECT 1 FROM CompraDetalles cd WHERE cd.CompraID = c.CompraID AND cd.ProductoID = p.ProductoID);

INSERT INTO CompraDetalles (CompraID, ProductoID, ProductoPresentacionID, Cantidad, CostoUnitario, Subtotal, CantidadUnidadesBase)
SELECT c.CompraID, p.ProductoID, pp.ProductoPresentacionID, 5, 30, 150, 5
FROM Compras c
JOIN Productos p ON p.Codigo = 'PRD002'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE c.NumeroCompra = 'C-000001'
  AND NOT EXISTS (SELECT 1 FROM CompraDetalles cd WHERE cd.CompraID = c.CompraID AND cd.ProductoID = p.ProductoID);

INSERT INTO CompraDetalles (CompraID, ProductoID, ProductoPresentacionID, Cantidad, CostoUnitario, Subtotal, CantidadUnidadesBase)
SELECT c.CompraID, p.ProductoID, pp.ProductoPresentacionID, 4, 75, 300, 4
FROM Compras c
JOIN Productos p ON p.Codigo = 'PRD006'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE c.NumeroCompra = 'C-000002'
  AND NOT EXISTS (SELECT 1 FROM CompraDetalles cd WHERE cd.CompraID = c.CompraID AND cd.ProductoID = p.ProductoID);

INSERT INTO CompraDetalles (CompraID, ProductoID, ProductoPresentacionID, Cantidad, CostoUnitario, Subtotal, CantidadUnidadesBase)
SELECT c.CompraID, p.ProductoID, pp.ProductoPresentacionID, 2, 100, 200, 2
FROM Compras c
JOIN Productos p ON p.Codigo = 'PRD009'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE c.NumeroCompra = 'C-000003'
  AND NOT EXISTS (SELECT 1 FROM CompraDetalles cd WHERE cd.CompraID = c.CompraID AND cd.ProductoID = p.ProductoID);

INSERT OR IGNORE INTO CreditosCompras
    (CompraID, ProveedorID, MontoTotal, MontoPagado, Saldo, FechaVencimiento, Estado, FechaRegistro, FechaPago)
SELECT c.CompraID, c.ProveedorID, c.Total, 200.00, c.Total - 200.00, '2026-03-10', 'PENDIENTE', datetime('now'), NULL
FROM Compras c
WHERE c.NumeroCompra = 'C-000002';

INSERT INTO CuentasPorPagar
    (CompraID, ProveedorID, MontoTotal, MontoPagado, MontoPendiente, FechaVencimiento, Estado)
SELECT c.CompraID, c.ProveedorID, c.Total, 200.00, c.Total - 200.00, '2026-03-10', 'PARCIAL'
FROM Compras c
WHERE c.NumeroCompra = 'C-000002'
  AND NOT EXISTS (SELECT 1 FROM CuentasPorPagar cp WHERE cp.CompraID = c.CompraID);

INSERT INTO PagosProveedores
    (CuentaPorPagarID, Fecha, Hora, Monto, MetodoPago, Comprobante, Observaciones, UsuarioID)
SELECT cp.CuentaPorPagarID, '2026-02-13', '10:30:00', 200.00, 'TRANSFERENCIA', 'TRF-8871', 'Abono inicial a credito proveedor', 1
FROM CuentasPorPagar cp
JOIN Compras c ON c.CompraID = cp.CompraID
WHERE c.NumeroCompra = 'C-000002'
  AND NOT EXISTS (
      SELECT 1 FROM PagosProveedores pp
      WHERE pp.CuentaPorPagarID = cp.CuentaPorPagarID
        AND pp.Monto = 200.00
        AND pp.Fecha = '2026-02-13'
  );

-- Ventas demo
INSERT OR IGNORE INTO Ventas
    (NumeroVenta, Fecha, Hora, ClienteID, TipoComprobante, Serie, Numero, SubTotal, IGV, Total, MetodoPago, MontoEfectivo, MontoYape, MontoTarjeta, MontoTransferencia, Estado, CajaID, UsuarioID, Observaciones)
VALUES
    ('V-000001', '2026-02-14', '09:20:00', 1, 'BOLETA', 'B001', '000501', 100.00, 18.00, 118.00, 'EFECTIVO', 118.00, 0, 0, 0, 'COMPLETADA', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1, 'Venta mostrador'),
    ('V-000002', '2026-02-14', '11:10:00', (SELECT ClienteID FROM Clientes WHERE NumeroDocumento = '70987654'), 'BOLETA', 'B001', '000502', 200.00, 36.00, 236.00, 'YAPE', 0, 236.00, 0, 0, 'COMPLETADA', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1, 'Pago con Yape'),
    ('V-000003', '2026-02-15', '10:05:00', (SELECT ClienteID FROM Clientes WHERE NumeroDocumento = '20604561234'), 'FACTURA', 'F001', '000210', 300.00, 54.00, 354.00, 'CREDITO', 0, 0, 0, 0, 'CREDITO', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1, 'Venta a credito 30 dias'),
    ('V-000004', '2026-02-15', '16:45:00', (SELECT ClienteID FROM Clientes WHERE NumeroDocumento = '71543210'), 'BOLETA', 'B001', '000503', 150.00, 27.00, 177.00, 'MIXTO', 100.00, 77.00, 0, 0, 'COMPLETADA', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1, 'Pago mixto efectivo+yape');

INSERT INTO VentaDetalles (VentaID, ProductoID, ProductoPresentacionID, Cantidad, PrecioUnitario, Subtotal, CantidadUnidadesBase)
SELECT v.VentaID, p.ProductoID, pp.ProductoPresentacionID, 2, 50, 100, 2
FROM Ventas v
JOIN Productos p ON p.Codigo = 'PRD002'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE v.NumeroVenta = 'V-000001'
  AND NOT EXISTS (SELECT 1 FROM VentaDetalles vd WHERE vd.VentaID = v.VentaID AND vd.ProductoID = p.ProductoID);

INSERT INTO VentaDetalles (VentaID, ProductoID, ProductoPresentacionID, Cantidad, PrecioUnitario, Subtotal, CantidadUnidadesBase)
SELECT v.VentaID, p.ProductoID, pp.ProductoPresentacionID, 4, 50, 200, 4
FROM Ventas v
JOIN Productos p ON p.Codigo = 'PRD001'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE v.NumeroVenta = 'V-000002'
  AND NOT EXISTS (SELECT 1 FROM VentaDetalles vd WHERE vd.VentaID = v.VentaID AND vd.ProductoID = p.ProductoID);

INSERT INTO VentaDetalles (VentaID, ProductoID, ProductoPresentacionID, Cantidad, PrecioUnitario, Subtotal, CantidadUnidadesBase)
SELECT v.VentaID, p.ProductoID, pp.ProductoPresentacionID, 3, 100, 300, 3
FROM Ventas v
JOIN Productos p ON p.Codigo = 'PRD006'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE v.NumeroVenta = 'V-000003'
  AND NOT EXISTS (SELECT 1 FROM VentaDetalles vd WHERE vd.VentaID = v.VentaID AND vd.ProductoID = p.ProductoID);

INSERT INTO VentaDetalles (VentaID, ProductoID, ProductoPresentacionID, Cantidad, PrecioUnitario, Subtotal, CantidadUnidadesBase)
SELECT v.VentaID, p.ProductoID, pp.ProductoPresentacionID, 3, 50, 150, 3
FROM Ventas v
JOIN Productos p ON p.Codigo = 'PRD003'
JOIN ProductoPresentaciones pp ON pp.ProductoID = p.ProductoID
WHERE v.NumeroVenta = 'V-000004'
  AND NOT EXISTS (SELECT 1 FROM VentaDetalles vd WHERE vd.VentaID = v.VentaID AND vd.ProductoID = p.ProductoID);

INSERT OR IGNORE INTO CreditosVentas
    (VentaID, ClienteID, MontoTotal, MontoPagado, Saldo, FechaVencimiento, Estado, FechaRegistro, FechaPago)
SELECT v.VentaID, v.ClienteID, v.Total, 100.00, v.Total - 100.00, '2026-03-17', 'PENDIENTE', datetime('now'), NULL
FROM Ventas v
WHERE v.NumeroVenta = 'V-000003';

INSERT INTO Pagos
    (ClienteID, Monto, MetodoPago, MontoEfectivo, MontoYape, MontoTransferencia, FechaPago, HoraPago, Observaciones)
SELECT v.ClienteID, 100.00, 'EFECTIVO', 100.00, 0, 0, '2026-02-16', '12:10:00', 'Abono inicial de credito V-000003'
FROM Ventas v
WHERE v.NumeroVenta = 'V-000003'
  AND NOT EXISTS (
      SELECT 1 FROM Pagos p
      WHERE p.ClienteID = v.ClienteID
        AND p.Monto = 100.00
        AND p.FechaPago = '2026-02-16'
  );

INSERT INTO PagoVenta (PagoID, VentaID, MontoAplicado)
SELECT p.PagoID, v.VentaID, 100.00
FROM Pagos p
JOIN Ventas v ON v.NumeroVenta = 'V-000003'
WHERE p.Observaciones = 'Abono inicial de credito V-000003'
  AND NOT EXISTS (
      SELECT 1 FROM PagoVenta pv
      WHERE pv.PagoID = p.PagoID
        AND pv.VentaID = v.VentaID
  );

-- Gastos demo
INSERT INTO Gastos
    (Fecha, Hora, Concepto, Monto, Categoria, MetodoPago, Comprobante, Observaciones, CajaID, UsuarioID)
SELECT '2026-02-14', '13:20:00', 'Compra de bolsas de empaque', 45.00, 'OPERATIVO', 'EFECTIVO', 'BOL-2201', 'Material de atencion', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1
WHERE NOT EXISTS (SELECT 1 FROM Gastos WHERE Concepto = 'Compra de bolsas de empaque' AND Fecha = '2026-02-14');

INSERT INTO Gastos
    (Fecha, Hora, Concepto, Monto, Categoria, MetodoPago, Comprobante, Observaciones, CajaID, UsuarioID)
SELECT '2026-02-15', '08:50:00', 'Movilidad de reparto', 30.00, 'TRANSPORTE', 'EFECTIVO', 'MOV-1109', 'Entrega a clientes', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1
WHERE NOT EXISTS (SELECT 1 FROM Gastos WHERE Concepto = 'Movilidad de reparto' AND Fecha = '2026-02-15');

INSERT INTO Gastos
    (Fecha, Hora, Concepto, Monto, Categoria, MetodoPago, Comprobante, Observaciones, CajaID, UsuarioID)
SELECT '2026-02-15', '12:00:00', 'Pago de internet local', 120.00, 'SERVICIOS', 'TRANSFERENCIA', 'SRV-9981', 'Servicio mensual', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1
WHERE NOT EXISTS (SELECT 1 FROM Gastos WHERE Concepto = 'Pago de internet local' AND Fecha = '2026-02-15');

INSERT INTO Gastos
    (Fecha, Hora, Concepto, Monto, Categoria, MetodoPago, Comprobante, Observaciones, CajaID, UsuarioID)
SELECT '2026-02-16', '09:05:00', 'Limpieza y desinfeccion', 55.00, 'MANTENIMIENTO', 'YAPE', 'YAP-4502', 'Mantenimiento de almacen', (SELECT CajaID FROM Cajas WHERE Estado = 'ABIERTA' LIMIT 1), 1
WHERE NOT EXISTS (SELECT 1 FROM Gastos WHERE Concepto = 'Limpieza y desinfeccion' AND Fecha = '2026-02-16');

COMMIT;
