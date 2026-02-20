# Arquitectura POS Modular (Base Profesional)

## Objetivo
Definir una estructura profesional para que el sistema escale sin mezclar operacion diaria con configuracion tecnica.

## Modulos principales (sidebar)
1. Dashboard
2. Ventas
3. Compras
4. Inventario
5. Caja y Bancos
6. Clientes
7. Proveedores
8. Finanzas (CxP/CxC y control)
9. Reportes Operativos
10. Reportes Gerenciales

## Menu de usuario (perfil, esquina superior)
- Mi cuenta
- Empresa
- Usuarios y roles
- Configuracion del sistema
- Cerrar sesion

## Regla de separacion clave
- `Kardex` pertenece a Inventario (movimientos de stock y costo).
- `Flujo de caja` pertenece a Caja/Finanzas (movimientos de dinero).
- `Empresa/Usuarios/Parametros` no deben ocupar espacio en el sidebar operativo.

## Mapa actual -> estructura objetivo
- `FormDashboard` -> Dashboard
- `FormVentas` + `FormHistorialVentas` -> Ventas
- `FormCompras` + `FormHistorialCompras` -> Compras
- `FormProductos` + `FormAjustes` + `FormAlertas` -> Inventario
- `FormCaja` + `FormGastos` -> Caja y Bancos
- `FormClientes` -> Clientes
- `FormProveedores` -> Proveedores
- `FormCuentasPorPagar` + `FormLibroDiario` -> Finanzas
- `FormFlujoCaja` -> Reportes Operativos
- `FormEstadoResultados` + `FormBalanceGeneral` -> Reportes Gerenciales
- `FormReportes` -> Configuracion de reportes (administracion)

## Flujo de conexion entre modulos
1. Venta confirmada:
   - descuenta inventario
   - registra movimiento de caja
   - actualiza reportes de ventas
2. Compra recibida:
   - incrementa inventario
   - genera cuenta por pagar
   - alimenta reportes de compras
3. Pago de proveedor:
   - reduce cuenta por pagar
   - registra salida de caja/banco
4. Ajuste de inventario:
   - actualiza stock
   - deja trazabilidad para kardex

## Fase siguiente recomendada (implementacion)
1. Crear modulo Kardex dedicado (UI + repositorio) con filtro por producto, fecha y almacen.
2. Separar CxC de clientes (actualmente predominan CxP).
3. Incorporar auditoria de anulaciones/devoluciones por usuario y caja.
4. Agregar conciliacion basica de bancos.
