USE [master]
GO
/****** Object:  Database [impactoDB]    Script Date: 16/08/2020 21:44:09 ******/
CREATE DATABASE [impactoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'impactoDB', FILENAME = N'D:\Program Files (x86)\MSSQL15.MSSQLSERVER\MSSQL\DATA\impactoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'impactoDB_log', FILENAME = N'D:\Program Files (x86)\MSSQL15.MSSQLSERVER\MSSQL\DATA\impactoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [impactoDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [impactoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [impactoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [impactoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [impactoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [impactoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [impactoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [impactoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [impactoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [impactoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [impactoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [impactoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [impactoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [impactoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [impactoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [impactoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [impactoDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [impactoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [impactoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [impactoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [impactoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [impactoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [impactoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [impactoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [impactoDB] SET RECOVERY FULL 
GO
ALTER DATABASE [impactoDB] SET  MULTI_USER 
GO
ALTER DATABASE [impactoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [impactoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [impactoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [impactoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [impactoDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'impactoDB', N'ON'
GO
ALTER DATABASE [impactoDB] SET QUERY_STORE = OFF
GO
USE [impactoDB]
GO
/****** Object:  Table [dbo].[Boleta]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boleta](
	[idboleta] [int] IDENTITY(1,1) NOT NULL,
	[pedido_idpedido] [int] NOT NULL,
	[cliente_idcliente] [int] NOT NULL,
	[monto] [float] NOT NULL,
	[igv] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Boleta] PRIMARY KEY CLUSTERED 
(
	[idboleta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombrecategoria] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nombrecliente] [varchar](45) NOT NULL,
	[apellidopaternocliente] [varchar](45) NOT NULL,
	[apellidomaternocliente] [varchar](45) NOT NULL,
	[telefonocliente] [char](9) NULL,
	[correocliente] [varchar](45) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_pedido]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_pedido](
	[pedido_idpedido] [int] NOT NULL,
	[producto_idproducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[nombreempleado] [varchar](45) NOT NULL,
	[apellidopatempleado] [varchar](45) NOT NULL,
	[apellidomatempleado] [varchar](45) NOT NULL,
	[tipoempleado_idtipoempleado] [int] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Forma_de_pago]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forma_de_pago](
	[idformadepago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](45) NULL,
 CONSTRAINT [PK_Forma_de_pago] PRIMARY KEY CLUSTERED 
(
	[idformadepago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[idpedido] [int] IDENTITY(1,1) NOT NULL,
	[cliente_idcliente] [int] NOT NULL,
	[montotot] [float] NOT NULL,
	[cantprod] [int] NOT NULL,
	[pedidocol] [varchar](45) NOT NULL,
	[empleados_idempleados] [int] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido2]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido2](
	[idpedido] [int] IDENTITY(1,1) NOT NULL,
	[cliente_idcliente] [int] NOT NULL,
	[montotot] [float] NOT NULL,
	[cantprod] [int] NOT NULL,
	[fecha] [varchar](45) NOT NULL,
	[formadepago_idformadepago] [int] NOT NULL,
	[empleados_idempleados] [int] NOT NULL,
 CONSTRAINT [PK_Pedido2] PRIMARY KEY CLUSTERED 
(
	[idpedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreproducto] [varchar](45) NOT NULL,
	[desproducto] [varchar](90) NOT NULL,
	[precio] [float] NOT NULL,
	[categoria_idcategoria] [int] NOT NULL,
	[proveedores_idproveedores] [int] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idproveedores] [int] IDENTITY(1,1) NOT NULL,
	[nombreproveedores] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[idproveedores] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_de_empleados]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_de_empleados](
	[idtipoempleado] [int] IDENTITY(1,1) NOT NULL,
	[nombretipo] [varchar](45) NOT NULL,
 CONSTRAINT [PK_Tipo_de_empleados] PRIMARY KEY CLUSTERED 
(
	[idtipoempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[username] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
	[empleado_idempleado] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Boleta]  WITH CHECK ADD  CONSTRAINT [FK_Boleta_Cliente] FOREIGN KEY([cliente_idcliente])
REFERENCES [dbo].[Cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Boleta] CHECK CONSTRAINT [FK_Boleta_Cliente]
GO
ALTER TABLE [dbo].[Boleta]  WITH CHECK ADD  CONSTRAINT [FK_Boleta_Pedido2] FOREIGN KEY([pedido_idpedido])
REFERENCES [dbo].[Pedido2] ([idpedido])
GO
ALTER TABLE [dbo].[Boleta] CHECK CONSTRAINT [FK_Boleta_Pedido2]
GO
ALTER TABLE [dbo].[Detalle_pedido]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_pedido_Pedido2] FOREIGN KEY([pedido_idpedido])
REFERENCES [dbo].[Pedido2] ([idpedido])
GO
ALTER TABLE [dbo].[Detalle_pedido] CHECK CONSTRAINT [FK_Detalle_pedido_Pedido2]
GO
ALTER TABLE [dbo].[Detalle_pedido]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_pedido_Producto] FOREIGN KEY([producto_idproducto])
REFERENCES [dbo].[Producto] ([idproducto])
GO
ALTER TABLE [dbo].[Detalle_pedido] CHECK CONSTRAINT [FK_Detalle_pedido_Producto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Tipo_de_empleados] FOREIGN KEY([tipoempleado_idtipoempleado])
REFERENCES [dbo].[Tipo_de_empleados] ([idtipoempleado])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Tipo_de_empleados]
GO
ALTER TABLE [dbo].[Pedido2]  WITH CHECK ADD  CONSTRAINT [FK_Pedido2_Cliente] FOREIGN KEY([cliente_idcliente])
REFERENCES [dbo].[Cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Pedido2] CHECK CONSTRAINT [FK_Pedido2_Cliente]
GO
ALTER TABLE [dbo].[Pedido2]  WITH CHECK ADD  CONSTRAINT [FK_Pedido2_Empleado] FOREIGN KEY([empleados_idempleados])
REFERENCES [dbo].[Empleado] ([idempleado])
GO
ALTER TABLE [dbo].[Pedido2] CHECK CONSTRAINT [FK_Pedido2_Empleado]
GO
ALTER TABLE [dbo].[Pedido2]  WITH CHECK ADD  CONSTRAINT [FK_Pedido2_Forma_de_pago] FOREIGN KEY([formadepago_idformadepago])
REFERENCES [dbo].[Forma_de_pago] ([idformadepago])
GO
ALTER TABLE [dbo].[Pedido2] CHECK CONSTRAINT [FK_Pedido2_Forma_de_pago]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([categoria_idcategoria])
REFERENCES [dbo].[Categoria] ([idcategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedores] FOREIGN KEY([proveedores_idproveedores])
REFERENCES [dbo].[Proveedores] ([idproveedores])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedores]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([empleado_idempleado])
REFERENCES [dbo].[Empleado] ([idempleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
/****** Object:  StoredProcedure [dbo].[actualizarinfoempleado]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarinfoempleado] @nombre varchar(45), @apellidop varchar(45), @apellidom varchar(45), @iduser int
as
update Empleado set nombreempleado=@nombre, apellidopatempleado=@apellidop, apellidomatempleado=@apellidom where @iduser=idempleado
GO
/****** Object:  StoredProcedure [dbo].[actualizarstock]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarstock] @nombreproducto varchar(45), @cantidad int
as
UPDATE Producto set stock=stock-@cantidad where nombreproducto=@nombreproducto
GO
/****** Object:  StoredProcedure [dbo].[extraerdatosempleado]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[extraerdatosempleado]  @iduser int
as
select * from Empleado where @iduser=idempleado
GO
/****** Object:  StoredProcedure [dbo].[extraerultimoidpedido]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[extraerultimoidpedido] 
as

SELECT TOP 1 idpedido FROM pedido2 ORDER BY idpedido DESC 
GO
/****** Object:  StoredProcedure [dbo].[llenarproducto]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[llenarproducto] @nombrecategoria varchar(45)
as 
SELECT nombreproducto, precio from Producto p join Categoria c on p.categoria_idcategoria=c.idcategoria where @nombrecategoria=nombrecategoria
GO
/****** Object:  StoredProcedure [dbo].[modificarproducto]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modificarproducto] @idproducto int, @nombreproducto varchar(45), @desproducto varchar(90), @precio float, @stock int
as
UPDATE Producto set nombreproducto=@nombreproducto, desproducto=@desproducto, precio=@precio, stock=@stock where idproducto=@idproducto
GO
/****** Object:  StoredProcedure [dbo].[mostrarbienvenida]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[mostrarbienvenida] @iduser int 
as
select nombreempleado, apellidopatempleado, apellidomatempleado from Empleado where idempleado=@iduser 
GO
/****** Object:  StoredProcedure [dbo].[registrarcliente]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrarcliente] @nombrecliente varchar(45), @paternocliente varchar(45), @maternocliente varchar(45), @telefonocliente char(9), @correocliente varchar(45)
as
insert into Cliente(nombrecliente, apellidopaternocliente, apellidomaternocliente, telefonocliente ,correocliente) values(@nombrecliente, @paternocliente, @maternocliente, @telefonocliente, @correocliente)
GO
/****** Object:  StoredProcedure [dbo].[registrarpedido]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[registrarpedido] @idcliente int, @montotot float, @cantidad int, @fecha varchar(45), @idformadepago int, @idempleado int
as
insert into Pedido2(cliente_idcliente, montotot, cantprod, fecha, formadepago_idformadepago, empleados_idempleados) values(@idcliente, @montotot, @cantidad, @fecha, @idformadepago, @idempleado)
GO
/****** Object:  StoredProcedure [dbo].[registrarpedidodetalle]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[registrarpedidodetalle] @idpedido int, @idproducto int, @cantidad int
as
insert into Detalle_pedido(pedido_idpedido, producto_idproducto, cantidad) values(@idpedido, @idproducto, @cantidad)
GO
/****** Object:  StoredProcedure [dbo].[verificarcontrasena]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[verificarcontrasena] @usuario varchar(45)
as 
select * from Usuario u join Empleado e on U.empleado_idempleado = E.idempleado where @usuario=username
GO
/****** Object:  StoredProcedure [dbo].[verificarusuario]    Script Date: 16/08/2020 21:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[verificarusuario] @usuario varchar(45)
as 
select * from Usuario where username = @usuario;
GO
USE [master]
GO
ALTER DATABASE [impactoDB] SET  READ_WRITE 
GO
