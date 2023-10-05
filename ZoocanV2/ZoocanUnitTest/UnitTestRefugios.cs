using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using ZoocanV2;

namespace ZoocanUnitTest
{
    /// <summary>
    /// Descripción resumida de UnitTestPruebas
    /// </summary>
    [TestClass]
    public class UnitTestRefugios
    {
        public UnitTestRefugios() { }

        private TestContext testContextInstance;
        private Mock<ZoocanBD> _mockZoocanBD;
        private Herramientas _herramientas;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        [TestInitialize()]
        public void Initialize()
        {
            _mockZoocanBD = new Mock<ZoocanBD>();
            IQueryable<Refugio> datosRefugio = new List<Refugio>
            {
                new Refugio{ RefugioId = 1, Nombre = "Refugio01", Direccion = "Direccion de prueba 1", Especie = "Otros", Telefono = "654654654", MaxAnimales = 5 },
                new Refugio{ RefugioId = 2, Nombre = "Refugio02", Direccion = "Calle Medina Nº77", Especie = "Caninos", Telefono = "812630958", MaxAnimales = 9 },
                new Refugio{ RefugioId = 3, Nombre = "Refugio03", Direccion = "Calle Gonzalez Nº62", Especie = "Reptiles", Telefono = "981698999", MaxAnimales = 8 },
                new Refugio{ RefugioId = 4, Nombre = "Refugio04", Direccion = "Calle Nuñez Nº60", Especie = "Otros", Telefono = "915358967", MaxAnimales = 1 }
            }.AsQueryable();

            Mock<DbSet<Refugio>> mockTablaRefugios = new Mock<DbSet<Refugio>>();

            mockTablaRefugios.As<IQueryable<Refugio>>().Setup(x => x.Provider).Returns(datosRefugio.Provider);
            mockTablaRefugios.As<IQueryable<Refugio>>().Setup(x => x.Expression).Returns(datosRefugio.Expression);
            mockTablaRefugios.As<IQueryable<Refugio>>().Setup(x => x.GetEnumerator()).Returns(datosRefugio.GetEnumerator());

            IQueryable<Cuidador> datosCuidadors = new List<Cuidador>
            {
                new Cuidador{ CuidadorId = 1, RefugioId = 1, Nombre = "Alejandro Moreno Marin", Telefono = "693520354", Direccion = "Calle Ramos Nº50", SalarioAnual = 21149, Especie = "Reptiles", Responsable = true },
                new Cuidador{ CuidadorId = 2, RefugioId = 2, Nombre = "Laura Santos Gomez", Telefono = "855176901", Direccion = "Calle Gomez Nº73", SalarioAnual = 22743, Especie = "Reptiles", Responsable = false },
                new Cuidador{ CuidadorId = 3, RefugioId = 3, Nombre = "Luis Ortega Jimenez", Telefono = "774179922", Direccion = "Calle Sanchez Nº29", SalarioAnual = 23376, Especie = "Caninos", Responsable = true },
                new Cuidador{ CuidadorId = 4, RefugioId = 3, Nombre = "Francisca Gutierrez Morales", Telefono = "601925675", Direccion = "Calle Gutierrez Nº39", SalarioAnual = 15210, Especie = "Caninos", Responsable = false }
            }.AsQueryable();

            Mock<DbSet<Cuidador>> mockTablaCuidadors = new Mock<DbSet<Cuidador>>();

            mockTablaCuidadors.As<IQueryable<Cuidador>>().Setup(x => x.Provider).Returns(datosCuidadors.Provider);
            mockTablaCuidadors.As<IQueryable<Cuidador>>().Setup(x => x.Expression).Returns(datosCuidadors.Expression);
            mockTablaCuidadors.As<IQueryable<Cuidador>>().Setup(x => x.GetEnumerator()).Returns(datosCuidadors.GetEnumerator());

            IQueryable<Animal> datosAnimales = new List<Animal>
            {
                new Animal{ AnimalId = 1, RefugioId = 1, Nombre = "Animal01", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 5, EspacioMin = 10 },
                new Animal{ AnimalId = 2, RefugioId = 2, Nombre = "Animal02", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 6, EspacioMin = 20 },
                new Animal{ AnimalId = 3, RefugioId = 3, Nombre = "Animal03", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 7, EspacioMin = 30 },
                new Animal{ AnimalId = 4, RefugioId = 3, Nombre = "Animal04", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 8, EspacioMin = 40 },
            }.AsQueryable();

            Mock<DbSet<Animal>> mockTablaAnimales = new Mock<DbSet<Animal>>();

            mockTablaAnimales.As<IQueryable<Animal>>().Setup(x => x.Provider).Returns(datosAnimales.Provider);
            mockTablaAnimales.As<IQueryable<Animal>>().Setup(x => x.Expression).Returns(datosAnimales.Expression);
            mockTablaAnimales.As<IQueryable<Animal>>().Setup(x => x.GetEnumerator()).Returns(datosAnimales.GetEnumerator());


            _mockZoocanBD.Setup(x => x.Refugios).Returns(mockTablaRefugios.Object);
            _mockZoocanBD.Setup(x => x.Cuidadores).Returns(mockTablaCuidadors.Object);
            _mockZoocanBD.Setup(x => x.Animales).Returns(mockTablaAnimales.Object);

            _herramientas = new Herramientas(_mockZoocanBD.Object);
        }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Testing ObtenerRefugioPorId
        [TestMethod]
        public void ObtenerRefugioPorId_DatosCorrectos_DebeRetornarRefugio()
        {
            // Arrange
            int refugioId = 1;

            // Act
            Refugio refugio = _herramientas.ObtenerRefugioPorId(refugioId);

            // Assert
            Assert.IsNotNull(refugio);
            Assert.AreEqual(refugio.RefugioId, refugioId);
        }

        [TestMethod]
        public void ObtenerRefugioPorId_DatosIncorrectos_DebeRetornarNull()
        {
            // Arrange
            int refugioId = 999;

            // Act
            Refugio refugio = _herramientas.ObtenerRefugioPorId(refugioId);

            // Assert
            Assert.IsNull(refugio);
        }
        #endregion

        #region Testing ObtenerRefugioPorNombre
        [TestMethod]
        public void ObtenerRefugioPorNombre_DatosCorrectos_DebeDevolverRefugio()
        {
            // Arrange
            string nombre = "Refugio01";

            // Act
            Refugio resultado = _herramientas.ObtenerRefugioPorNombre(nombre);

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(1, resultado.RefugioId);
            Assert.AreEqual(nombre, resultado.Nombre);
        }

        [TestMethod]
        public void ObtenerRefugioPorNombre_DatosIncorrectos_DebeDevolverNulo()
        {
            // Arrange
            string nombre = "RefugioNoExistente";

            // Act
            Refugio resultado = _herramientas.ObtenerRefugioPorNombre(nombre);

            // Assert
            Assert.IsNull(resultado);
        }

        [TestMethod]
        public void ObtenerRefugioPorNombre_ParametroNulo()
        {
            // Arrange
            string nombre = null;

            // Act
            Refugio refugio = _herramientas.ObtenerRefugioPorNombre(nombre);

            Assert.IsNull(refugio);
        }
        #endregion

        #region Testing ObtenerEspecieDeRefugioPorId
        [TestMethod]
        public void ObtenerEspecieDeRefugioPorId_DatosCorrectos()
        {
            // Arrange
            int refugioId = 2;
            string especie = "Caninos";

            // Act
            string actualEspecie = _herramientas.ObtenerEspecieDeRefugioPorId(refugioId);

            // Assert
            Assert.AreEqual(especie, actualEspecie);
        }

        [TestMethod]
        public void ObtenerEspecieDeRefugioPorId_DatosIncorrectos()
        {
            // Arrange
            int refugioId = 2;
            string especie = "Otros";

            // Act
            string actualEspecie = _herramientas.ObtenerEspecieDeRefugioPorId(refugioId);

            // Assert
            Assert.AreNotEqual(especie, actualEspecie);
        }
        #endregion

        #region Testing ObtenerEspecieDeRefugioPorNombre
        [TestMethod]
        public void ObtenerEspecieDeRefugioPorNombre_DatosCorrectos_DebeDevolverEspecie()
        {
            // Arrange
            string nombre = "Refugio01";

            // Act
            string resultado = _herramientas.ObtenerEspecieDeRefugioPorNombre(nombre);

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual("Otros", resultado);
        }

        [TestMethod]
        public void ObtenerEspecieDeRefugioPorNombre_DatosIncorrectos()
        {
            string especie = "Caninos";
            string nombre = "Refugio01";

            string resultado = _herramientas.ObtenerEspecieDeRefugioPorNombre(nombre);

            Assert.AreNotEqual(especie, resultado);
        }
        #endregion

        #region Testing ObtenerNumeroCuidadors
        [TestMethod]
        public void ObtenerNumeroCuidadors_DatosCorrectos()
        {
            // Arrange
            int id = 1;

            // Act
            int resultado = _herramientas.ObtenerNumeroCuidadores(id);

            // Assert
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void ObtenerNumeroCuidadors_DatosIncorrectos()
        {
            // Arrange
            int id = 1;

            // Act
            int resultado = _herramientas.ObtenerNumeroCuidadores(id);

            // Assert
            Assert.AreNotEqual(3, resultado);
        }
        #endregion

        #region Testing ObtenerNumeroAnimalesPorId
        [TestMethod]
        public void ObtenerNumeroAnimalesPorId_DatosCorrectos()
        {
            // Arrange
            int id = 1;

            // Act
            int resultado = _herramientas.ObtenerNumeroAnimalesPorId(id);

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void ObtenerNumeroAnimalesPorId_DatosIncorrectos()
        {
            // Arrange
            int id = -1;

            // Act
            int resultado = _herramientas.ObtenerNumeroAnimalesPorId(id);

            Assert.AreNotEqual(1, resultado);
        }
        #endregion

        #region Testing ObtenerNumeroAnimalesPorNombre
        [TestMethod]
        public void ObtenerNumeroAnimalesPorNombre_DatosCorrectos()
        {
            // Arrange
            string nombre = "Refugio01";

            // Act
            int resultado = _herramientas.ObtenerNumeroAnimalesPorNombre(nombre);

            // Assert
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void ObtenerNumeroAnimalesPorNombre_DatosIncorrectos()
        {
            // Arrange
            string nombre = "Refugio00";

            // Act
            int resultado = _herramientas.ObtenerNumeroAnimalesPorNombre(nombre);

            Assert.AreNotEqual(1, resultado);
        }
        #endregion

        #region Testing CrearRefugio
        [TestMethod]
        public void CrearRefugio_DatosCorrectos()
        {
            // Arrange
            Refugio refugio = new Refugio()
            {
                RefugioId = 10,
                Nombre = "Refugio01",
                Direccion = "Direccion de prueba 2",
                Especie = "Otros",
                Telefono = "654654654",
                MaxAnimales = 5
            };

            // Act
            _herramientas.CrearRefugio(refugio);

            Assert.AreEqual(10, refugio.RefugioId);
            Assert.AreEqual("Refugio01", refugio.Nombre);
            Assert.AreEqual("Direccion de prueba 2", refugio.Direccion);
            Assert.AreEqual("Otros", refugio.Especie);
            Assert.AreEqual("654654654", refugio.Telefono);
            Assert.AreEqual(5, refugio.MaxAnimales);
        }

        [TestMethod]
        public void CrearRefugio_DatosIncorrectos()
        {
            Refugio refugio = new Refugio()
            {
                RefugioId = 10,
                Nombre = "Refugio01",
                Direccion = "Direccion de prueba 2",
                Especie = "Otros",
                Telefono = "654654654",
                MaxAnimales = 5
            };

            // Act
            _herramientas.CrearRefugio(refugio);

            Assert.AreNotEqual(11, refugio.RefugioId);
            Assert.AreNotEqual("Refugio00", refugio.Nombre);
            Assert.AreNotEqual("Direccion de prueba 0", refugio.Direccion);
            Assert.AreNotEqual("Otro", refugio.Especie);
            Assert.AreNotEqual("654564654", refugio.Telefono);
            Assert.AreNotEqual(6, refugio.MaxAnimales);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearRefugio_ParametrosNulos()
        {
            // Arrange
            Refugio refugio = null;
            // Act
            _herramientas.CrearRefugio(refugio);
        }
        #endregion

        #region Testing BorrarRefugio
        [TestMethod]
        public void BorrarRefugio_DatosCorrectos()
        {
            _herramientas.BorrarRefugio(4);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void BorrarRefugio_DatosIncorrectos()
        {
            _herramientas.BorrarRefugio(-1);
        }
        #endregion

        #region ActualizarRefugio
        [TestMethod]
        public void ActualizarRefugio_DatosCorrectos()
        {
            // Arrange
            Refugio refugio = new Refugio()
            {
                RefugioId = 1,
                Nombre = "Refugio01",
                Direccion = "Direccion de prueba 2",
                Especie = "Otros",
                Telefono = "654654654",
                MaxAnimales = 5
            };

            // Act
            _herramientas.ActualizarRefugio(refugio);

            // Assert
            Assert.AreEqual("Refugio01", refugio.Nombre);
            Assert.AreEqual("Direccion de prueba 2", refugio.Direccion);
            Assert.AreEqual("Otros", refugio.Especie);
            Assert.AreEqual("654654654", refugio.Telefono);
            Assert.AreEqual(5, refugio.MaxAnimales);
        }

        [TestMethod]
        public void ActualizarRefugio_DatosIncorrectos()
        {
            // Arrange
            Refugio refugio = new Refugio();
            refugio.RefugioId = 1;
            refugio.Especie = "Gatos";

            Assert.ThrowsException<ZoocanException>(() => _herramientas.ActualizarRefugio(refugio));
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarRefugio_ParametrosNulos()
        {// Arrange
            Refugio refugio = null;
            // Act
            _herramientas.ActualizarRefugio(refugio);
        }

        [TestMethod]
        public void ActualizarRefugio_LanzarZoocanException()
        {
            // Arrange
            Refugio refugio = new Refugio
            {
                RefugioId = 1,
                Nombre = "Refugio01",
                Direccion = "Direccion de prueba 1",
                Especie = "Canino",
                Telefono = "654654654",
                MaxAnimales = 5
            };

            // Act
            Assert.ThrowsException<ZoocanException>(() => _herramientas.ActualizarRefugio(refugio));
        }

        [TestMethod]
        public void ActualizarRefugio_LanzarZoocanException_Especie()
        {
            // Arrange
            Refugio refugio = new Refugio
            {
                RefugioId = 1,
                Nombre = "Refugio01",
                Direccion = "Direccion de prueba 1",
                Especie = "Falso",
                Telefono = "654654654",
                MaxAnimales = 5
            };

            // Act
            Assert.ThrowsException<ZoocanException>(() => _herramientas.ActualizarRefugio(refugio));
        }

        [TestMethod]
        public void ActualizarRefugio_LanzarZoocanException_MaxAnimales()
        {
            // Arrange
            Refugio refugio = new Refugio
            {
                RefugioId = 1,
                Nombre = "Refugio01",
                Direccion = "Direccion de prueba 1",
                Especie = "Canino",
                Telefono = "654654654",
                MaxAnimales = 0
            };

            // Act
            Assert.ThrowsException<ZoocanException>(() => _herramientas.ActualizarRefugio(refugio));
        }
        #endregion
    }
}
