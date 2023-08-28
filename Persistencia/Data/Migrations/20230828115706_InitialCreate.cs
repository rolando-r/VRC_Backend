using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEmpresa = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEspecialidad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoOrdenes",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstadoOrden = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoOrdenes", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoPartes",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstadoParte = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPartes", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroFactura = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    EstadoFactura = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreMarca = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePais = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recomendaciones",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionRec = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendaciones", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoContactos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoContacto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContactos", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoMovimientos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoMovimiento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMovimientos", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersonas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoPersona = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonas", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPrestadorSers",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoPrestadorSer = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPrestadorSers", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoProductos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoProducto = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProductos", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoServicios",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoServicio = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoServicios", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoVehiculos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoVehiculo = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVehiculos", x => x.IdCod);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ParteVehiculos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreParteVehiculo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstadoParte = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParteVehiculos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_ParteVehiculos_EstadoPartes_IdEstadoParte",
                        column: x => x.IdEstadoParte,
                        principalTable: "EstadoPartes",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreModelo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMarca = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marcas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreDepartamento = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPais = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Departamentos_Paises_IdPais",
                        column: x => x.IdPais,
                        principalTable: "Paises",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleFacturas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRecomendacion = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdFactura = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturas", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Facturas_IdFactura",
                        column: x => x.IdFactura,
                        principalTable: "Facturas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Recomendaciones_IdRecomendacion",
                        column: x => x.IdRecomendacion,
                        principalTable: "Recomendaciones",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaMovimiento = table.Column<DateTime>(type: "date", nullable: false),
                    IdTipoMovimiento = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Movimientos_TipoMovimientos_IdTipoMovimiento",
                        column: x => x.IdTipoMovimiento,
                        principalTable: "TipoMovimientos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrestadorServicios",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePrestadorServicio = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPrestadorSer = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorServicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PrestadorServicios_TipoPrestadorSers_IdTipoPrestadorSer",
                        column: x => x.IdTipoPrestadorSer,
                        principalTable: "TipoPrestadorSers",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreServicio = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoServicio = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Servicios_TipoServicios_IdTipoServicio",
                        column: x => x.IdTipoServicio,
                        principalTable: "TipoServicios",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InspeccionPartes",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreInspeccionParte = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdParteVehiculo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspeccionPartes", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_InspeccionPartes_ParteVehiculos_IdParteVehiculo",
                        column: x => x.IdParteVehiculo,
                        principalTable: "ParteVehiculos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreCiudad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamento = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Ciudades_Departamentos_IdDepartamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Afiliaciones",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreAfiliacion = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPrestadorServicio = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliaciones", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Afiliaciones_PrestadorServicios_IdPrestadorServicio",
                        column: x => x.IdPrestadorServicio,
                        principalTable: "PrestadorServicios",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactoPersonas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NroFijo = table.Column<int>(type: "int", nullable: false),
                    NroMovil = table.Column<int>(type: "int", nullable: false),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoContacto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoContactoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoPersonas", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_ContactoPersonas_TipoContactos_TipoContactoIdCod",
                        column: x => x.TipoContactoIdCod,
                        principalTable: "TipoContactos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreSucursal = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdContactoPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCiudad = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEmpresa = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Sucursales_Ciudades_IdCiudad",
                        column: x => x.IdCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Sucursales_ContactoPersonas_IdContactoPersona",
                        column: x => x.IdContactoPersona,
                        principalTable: "ContactoPersonas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Sucursales_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePersona = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contraseña = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdSucursal = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Personas_Sucursales_IdSucursal",
                        column: x => x.IdSucursal,
                        principalTable: "Sucursales",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Personas_TipoPersonas_IdTipoPersona",
                        column: x => x.IdTipoPersona,
                        principalTable: "TipoPersonas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaOrden = table.Column<DateTime>(type: "date", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "date", nullable: false),
                    IdEstadoOrden = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdFactura = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Ordenes_EstadoOrdenes_IdEstadoOrden",
                        column: x => x.IdEstadoOrden,
                        principalTable: "EstadoOrdenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Ordenes_Facturas_IdFactura",
                        column: x => x.IdFactura,
                        principalTable: "Facturas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Ordenes_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonaAfiliaciones",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdAfiliacion = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaAfiliaciones", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PersonaAfiliaciones_Afiliaciones_IdAfiliacion",
                        column: x => x.IdAfiliacion,
                        principalTable: "Afiliaciones",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_PersonaAfiliaciones_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonaEspecialidades",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEspecialidad = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaEspecialidades", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PersonaEspecialidades_Especialidades_IdEspecialidad",
                        column: x => x.IdEspecialidad,
                        principalTable: "Especialidades",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_PersonaEspecialidades_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonaServicios",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdServicio = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaServicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PersonaServicios_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_PersonaServicios_Servicios_IdServicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicios",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreProducto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioVenta = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IdMovimiento = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoProducto = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Productos_Movimientos_IdMovimiento",
                        column: x => x.IdMovimiento,
                        principalTable: "Movimientos",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Productos_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Productos_TipoProductos_IdTipoProducto",
                        column: x => x.IdTipoProducto,
                        principalTable: "TipoProductos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenDiagnosticos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionDiagnostico = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdOrden = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDiagnosticos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_OrdenDiagnosticos_Ordenes_IdOrden",
                        column: x => x.IdOrden,
                        principalTable: "Ordenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_OrdenDiagnosticos_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrdenServicios",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdServicio = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdOrden = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDetalleFact = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_OrdenServicios_DetalleFacturas_IdDetalleFact",
                        column: x => x.IdDetalleFact,
                        principalTable: "DetalleFacturas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_OrdenServicios_Ordenes_IdOrden",
                        column: x => x.IdOrden,
                        principalTable: "Ordenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_OrdenServicios_Servicios_IdServicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicios",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Placa = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdInspeccionParte = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoVehiculo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdModelo = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdOrden = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrdenIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Vehiculos_InspeccionPartes_IdInspeccionParte",
                        column: x => x.IdInspeccionParte,
                        principalTable: "InspeccionPartes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Modelos_IdModelo",
                        column: x => x.IdModelo,
                        principalTable: "Modelos",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Ordenes_OrdenIdCod",
                        column: x => x.OrdenIdCod,
                        principalTable: "Ordenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_TipoVehiculos_IdTipoVehiculo",
                        column: x => x.IdTipoVehiculo,
                        principalTable: "TipoVehiculos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductoOrdenSers",
                columns: table => new
                {
                    IdCod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    EstadoProdOrdenSer = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioUnitario = table.Column<int>(type: "int", nullable: false),
                    IdOrdenServicio = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProducto = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoOrdenSers", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_ProductoOrdenSers_OrdenServicios_IdOrdenServicio",
                        column: x => x.IdOrdenServicio,
                        principalTable: "OrdenServicios",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_ProductoOrdenSers_Productos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "Productos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliaciones_IdPrestadorServicio",
                table: "Afiliaciones",
                column: "IdPrestadorServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_IdDepartamento",
                table: "Ciudades",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersonas_IdPersona",
                table: "ContactoPersonas",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersonas_TipoContactoIdCod",
                table: "ContactoPersonas",
                column: "TipoContactoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_IdPais",
                table: "Departamentos",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_IdFactura",
                table: "DetalleFacturas",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_IdRecomendacion",
                table: "DetalleFacturas",
                column: "IdRecomendacion");

            migrationBuilder.CreateIndex(
                name: "IX_InspeccionPartes_IdParteVehiculo",
                table: "InspeccionPartes",
                column: "IdParteVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_IdMarca",
                table: "Modelos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_IdTipoMovimiento",
                table: "Movimientos",
                column: "IdTipoMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDiagnosticos_IdOrden",
                table: "OrdenDiagnosticos",
                column: "IdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDiagnosticos_IdPersona",
                table: "OrdenDiagnosticos",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_IdEstadoOrden",
                table: "Ordenes",
                column: "IdEstadoOrden");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_IdFactura",
                table: "Ordenes",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_IdPersona",
                table: "Ordenes",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_IdDetalleFact",
                table: "OrdenServicios",
                column: "IdDetalleFact");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_IdOrden",
                table: "OrdenServicios",
                column: "IdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_IdServicio",
                table: "OrdenServicios",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_ParteVehiculos_IdEstadoParte",
                table: "ParteVehiculos",
                column: "IdEstadoParte");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaAfiliaciones_IdAfiliacion",
                table: "PersonaAfiliaciones",
                column: "IdAfiliacion");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaAfiliaciones_IdPersona",
                table: "PersonaAfiliaciones",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaEspecialidades_IdEspecialidad",
                table: "PersonaEspecialidades",
                column: "IdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaEspecialidades_IdPersona",
                table: "PersonaEspecialidades",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdSucursal",
                table: "Personas",
                column: "IdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdTipoPersona",
                table: "Personas",
                column: "IdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicios_IdPersona",
                table: "PersonaServicios",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicios_IdServicio",
                table: "PersonaServicios",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorServicios_IdTipoPrestadorSer",
                table: "PrestadorServicios",
                column: "IdTipoPrestadorSer");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoOrdenSers_IdOrdenServicio",
                table: "ProductoOrdenSers",
                column: "IdOrdenServicio");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoOrdenSers_IdProducto",
                table: "ProductoOrdenSers",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdMovimiento",
                table: "Productos",
                column: "IdMovimiento");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdPersona",
                table: "Productos",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_IdTipoProducto",
                table: "Productos",
                column: "IdTipoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_IdTipoServicio",
                table: "Servicios",
                column: "IdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdCiudad",
                table: "Sucursales",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdContactoPersona",
                table: "Sucursales",
                column: "IdContactoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_IdEmpresa",
                table: "Sucursales",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdInspeccionParte",
                table: "Vehiculos",
                column: "IdInspeccionParte");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdModelo",
                table: "Vehiculos",
                column: "IdModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdPersona",
                table: "Vehiculos",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_IdTipoVehiculo",
                table: "Vehiculos",
                column: "IdTipoVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_OrdenIdCod",
                table: "Vehiculos",
                column: "OrdenIdCod");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactoPersonas_Personas_IdPersona",
                table: "ContactoPersonas",
                column: "IdPersona",
                principalTable: "Personas",
                principalColumn: "IdCod");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Departamentos_IdDepartamento",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactoPersonas_Personas_IdPersona",
                table: "ContactoPersonas");

            migrationBuilder.DropTable(
                name: "OrdenDiagnosticos");

            migrationBuilder.DropTable(
                name: "PersonaAfiliaciones");

            migrationBuilder.DropTable(
                name: "PersonaEspecialidades");

            migrationBuilder.DropTable(
                name: "PersonaServicios");

            migrationBuilder.DropTable(
                name: "ProductoOrdenSers");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Afiliaciones");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "OrdenServicios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "InspeccionPartes");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "TipoVehiculos");

            migrationBuilder.DropTable(
                name: "PrestadorServicios");

            migrationBuilder.DropTable(
                name: "DetalleFacturas");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "TipoProductos");

            migrationBuilder.DropTable(
                name: "ParteVehiculos");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "TipoPrestadorSers");

            migrationBuilder.DropTable(
                name: "Recomendaciones");

            migrationBuilder.DropTable(
                name: "EstadoOrdenes");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "TipoServicios");

            migrationBuilder.DropTable(
                name: "TipoMovimientos");

            migrationBuilder.DropTable(
                name: "EstadoPartes");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "TipoPersonas");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "ContactoPersonas");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "TipoContactos");
        }
    }
}
