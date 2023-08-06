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
                    NombreEmpresa = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreEspecialidad = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreEstadoOrden = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreEstadoParte = table.Column<string>(type: "longtext", nullable: true)
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
                    EstadoFactura = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreMarca = table.Column<string>(type: "longtext", nullable: true)
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
                    NombrePais = table.Column<string>(type: "longtext", nullable: true)
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
                    DescripcionRec = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoContacto = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoMovimiento = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoPersona = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoPrestadorSer = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoProducto = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoServicio = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreTipoVehiculo = table.Column<string>(type: "longtext", nullable: true)
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
                    NombreParteVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstadoParte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoParteIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParteVehiculos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_ParteVehiculos_EstadoPartes_EstadoParteIdCod",
                        column: x => x.EstadoParteIdCod,
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
                    NombreModelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMarca = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MarcaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_MarcaIdCod",
                        column: x => x.MarcaIdCod,
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
                    NombreDepartamento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Departamentos_Paises_PaisIdCod",
                        column: x => x.PaisIdCod,
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
                    IdRecomendacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RecomendacionIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdFactura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FacturaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFacturas", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Facturas_FacturaIdCod",
                        column: x => x.FacturaIdCod,
                        principalTable: "Facturas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_DetalleFacturas_Recomendaciones_RecomendacionIdCod",
                        column: x => x.RecomendacionIdCod,
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
                    FechaMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdTipoMovimiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoMovimientoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Movimientos_TipoMovimientos_TipoMovimientoIdCod",
                        column: x => x.TipoMovimientoIdCod,
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
                    NombrePrestadorServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPrestadorSer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPrestadorSerIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorServicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PrestadorServicios_TipoPrestadorSers_TipoPrestadorSerIdCod",
                        column: x => x.TipoPrestadorSerIdCod,
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
                    NombreServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoServicioIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Servicios_TipoServicios_TipoServicioIdCod",
                        column: x => x.TipoServicioIdCod,
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
                    NombreInspeccionParte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdParteVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParteVehiculoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspeccionPartes", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_InspeccionPartes_ParteVehiculos_ParteVehiculoIdCod",
                        column: x => x.ParteVehiculoIdCod,
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
                    NombreCiudad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartamentoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Ciudades_Departamentos_DepartamentoIdCod",
                        column: x => x.DepartamentoIdCod,
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
                    Direccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NroFijo = table.Column<int>(type: "int", nullable: false),
                    NroMovil = table.Column<int>(type: "int", nullable: false),
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    NombreSucursal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdContactoPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactoPersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCiudad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CiudadIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEmpresa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmpresaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Sucursales_Ciudades_CiudadIdCod",
                        column: x => x.CiudadIdCod,
                        principalTable: "Ciudades",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Sucursales_ContactoPersonas_ContactoPersonaIdCod",
                        column: x => x.ContactoPersonaIdCod,
                        principalTable: "ContactoPersonas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Sucursales_Empresas_EmpresaIdCod",
                        column: x => x.EmpresaIdCod,
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
                    NombrePersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contraseña = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdSucursal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SucursalIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Personas_Sucursales_SucursalIdCod",
                        column: x => x.SucursalIdCod,
                        principalTable: "Sucursales",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Personas_TipoPersonas_TipoPersonaIdCod",
                        column: x => x.TipoPersonaIdCod,
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
                    FechaOrden = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdEstadoOrden = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoOrdenIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdFactura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FacturaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Ordenes_EstadoOrdenes_EstadoOrdenIdCod",
                        column: x => x.EstadoOrdenIdCod,
                        principalTable: "EstadoOrdenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Ordenes_Facturas_FacturaIdCod",
                        column: x => x.FacturaIdCod,
                        principalTable: "Facturas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Ordenes_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
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
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdAfiliacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AfiliacionIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaAfiliaciones", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PersonaAfiliaciones_Afiliaciones_AfiliacionIdCod",
                        column: x => x.AfiliacionIdCod,
                        principalTable: "Afiliaciones",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_PersonaAfiliaciones_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
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
                    IdEspecialidad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EspecialidadIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaEspecialidades", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PersonaEspecialidades_Especialidades_EspecialidadIdCod",
                        column: x => x.EspecialidadIdCod,
                        principalTable: "Especialidades",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_PersonaEspecialidades_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
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
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicioIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaServicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_PersonaServicios_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_PersonaServicios_Servicios_ServicioIdCod",
                        column: x => x.ServicioIdCod,
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
                    NombreProducto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioProducto = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IdMovimiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MovimientoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoProducto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoProductoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_Productos_Movimientos_MovimientoIdCod",
                        column: x => x.MovimientoIdCod,
                        principalTable: "Movimientos",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Productos_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Productos_TipoProductos_TipoProductoIdCod",
                        column: x => x.TipoProductoIdCod,
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
                    DescripcionDiagnostico = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdOrden = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrdenIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDiagnosticos", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_OrdenDiagnosticos_Ordenes_OrdenIdCod",
                        column: x => x.OrdenIdCod,
                        principalTable: "Ordenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_OrdenDiagnosticos_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
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
                    IdServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServicioIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdOrden = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrdenIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDetalleFact = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DetalleFacturaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenServicios", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_OrdenServicios_DetalleFacturas_DetalleFacturaIdCod",
                        column: x => x.DetalleFacturaIdCod,
                        principalTable: "DetalleFacturas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_OrdenServicios_Ordenes_OrdenIdCod",
                        column: x => x.OrdenIdCod,
                        principalTable: "Ordenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_OrdenServicios_Servicios_ServicioIdCod",
                        column: x => x.ServicioIdCod,
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
                    Placa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdInspeccionParte = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InspeccionParteIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoVehiculo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoVehiculoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdModelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModeloIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
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
                        name: "FK_Vehiculos_InspeccionPartes_InspeccionParteIdCod",
                        column: x => x.InspeccionParteIdCod,
                        principalTable: "InspeccionPartes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Modelos_ModeloIdCod",
                        column: x => x.ModeloIdCod,
                        principalTable: "Modelos",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Ordenes_OrdenIdCod",
                        column: x => x.OrdenIdCod,
                        principalTable: "Ordenes",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_PersonaIdCod",
                        column: x => x.PersonaIdCod,
                        principalTable: "Personas",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_Vehiculos_TipoVehiculos_TipoVehiculoIdCod",
                        column: x => x.TipoVehiculoIdCod,
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
                    EstadoProdOrdenSer = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrecioTotalProducto = table.Column<int>(type: "int", nullable: false),
                    IdOrdenServicio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrdenServicioIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProducto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductoIdCod = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoOrdenSers", x => x.IdCod);
                    table.ForeignKey(
                        name: "FK_ProductoOrdenSers_OrdenServicios_OrdenServicioIdCod",
                        column: x => x.OrdenServicioIdCod,
                        principalTable: "OrdenServicios",
                        principalColumn: "IdCod");
                    table.ForeignKey(
                        name: "FK_ProductoOrdenSers_Productos_ProductoIdCod",
                        column: x => x.ProductoIdCod,
                        principalTable: "Productos",
                        principalColumn: "IdCod");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliaciones_IdPrestadorServicio",
                table: "Afiliaciones",
                column: "IdPrestadorServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentoIdCod",
                table: "Ciudades",
                column: "DepartamentoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersonas_PersonaIdCod",
                table: "ContactoPersonas",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersonas_TipoContactoIdCod",
                table: "ContactoPersonas",
                column: "TipoContactoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PaisIdCod",
                table: "Departamentos",
                column: "PaisIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_FacturaIdCod",
                table: "DetalleFacturas",
                column: "FacturaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleFacturas_RecomendacionIdCod",
                table: "DetalleFacturas",
                column: "RecomendacionIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_InspeccionPartes_ParteVehiculoIdCod",
                table: "InspeccionPartes",
                column: "ParteVehiculoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaIdCod",
                table: "Modelos",
                column: "MarcaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_TipoMovimientoIdCod",
                table: "Movimientos",
                column: "TipoMovimientoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDiagnosticos_OrdenIdCod",
                table: "OrdenDiagnosticos",
                column: "OrdenIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDiagnosticos_PersonaIdCod",
                table: "OrdenDiagnosticos",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_EstadoOrdenIdCod",
                table: "Ordenes",
                column: "EstadoOrdenIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_FacturaIdCod",
                table: "Ordenes",
                column: "FacturaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_PersonaIdCod",
                table: "Ordenes",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_DetalleFacturaIdCod",
                table: "OrdenServicios",
                column: "DetalleFacturaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_OrdenIdCod",
                table: "OrdenServicios",
                column: "OrdenIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenServicios_ServicioIdCod",
                table: "OrdenServicios",
                column: "ServicioIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_ParteVehiculos_EstadoParteIdCod",
                table: "ParteVehiculos",
                column: "EstadoParteIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaAfiliaciones_AfiliacionIdCod",
                table: "PersonaAfiliaciones",
                column: "AfiliacionIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaAfiliaciones_PersonaIdCod",
                table: "PersonaAfiliaciones",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaEspecialidades_EspecialidadIdCod",
                table: "PersonaEspecialidades",
                column: "EspecialidadIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaEspecialidades_PersonaIdCod",
                table: "PersonaEspecialidades",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SucursalIdCod",
                table: "Personas",
                column: "SucursalIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoPersonaIdCod",
                table: "Personas",
                column: "TipoPersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicios_PersonaIdCod",
                table: "PersonaServicios",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaServicios_ServicioIdCod",
                table: "PersonaServicios",
                column: "ServicioIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorServicios_TipoPrestadorSerIdCod",
                table: "PrestadorServicios",
                column: "TipoPrestadorSerIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoOrdenSers_OrdenServicioIdCod",
                table: "ProductoOrdenSers",
                column: "OrdenServicioIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoOrdenSers_ProductoIdCod",
                table: "ProductoOrdenSers",
                column: "ProductoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MovimientoIdCod",
                table: "Productos",
                column: "MovimientoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PersonaIdCod",
                table: "Productos",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoProductoIdCod",
                table: "Productos",
                column: "TipoProductoIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_TipoServicioIdCod",
                table: "Servicios",
                column: "TipoServicioIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_CiudadIdCod",
                table: "Sucursales",
                column: "CiudadIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_ContactoPersonaIdCod",
                table: "Sucursales",
                column: "ContactoPersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_EmpresaIdCod",
                table: "Sucursales",
                column: "EmpresaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_InspeccionParteIdCod",
                table: "Vehiculos",
                column: "InspeccionParteIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModeloIdCod",
                table: "Vehiculos",
                column: "ModeloIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_OrdenIdCod",
                table: "Vehiculos",
                column: "OrdenIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PersonaIdCod",
                table: "Vehiculos",
                column: "PersonaIdCod");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoVehiculoIdCod",
                table: "Vehiculos",
                column: "TipoVehiculoIdCod");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactoPersonas_Personas_PersonaIdCod",
                table: "ContactoPersonas",
                column: "PersonaIdCod",
                principalTable: "Personas",
                principalColumn: "IdCod");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentoIdCod",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactoPersonas_Personas_PersonaIdCod",
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
