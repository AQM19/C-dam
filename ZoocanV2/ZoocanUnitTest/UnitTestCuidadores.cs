using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ZoocanV2;

namespace ZoocanUnitTest
{
    /// <summary>
    /// Descripción resumida de UnitTestCuidadores
    /// </summary>
    [TestClass]
    public class UnitTestCuidadores
    {
        public UnitTestCuidadores()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

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
        public void MyTestInitialize()
        {
            _mockZoocanBD = new Mock<ZoocanBD>();
            IQueryable<Refugio> datosRefugio = new List<Refugio>
            {
                new Refugio{ RefugioId = 1, Nombre = "Refugio01", Direccion = "Direccion de prueba 1", Especie = "Otros", Telefono = "654654654", MaxAnimales = 5 },
                new Refugio{ RefugioId = 2, Nombre = "Refugio02", Direccion = "Calle Medina Nº77", Especie = "Caninos", Telefono = "812630958", MaxAnimales = 9 },
                new Refugio{ RefugioId = 3, Nombre = "Refugio03", Direccion = "Calle Gonzalez Nº62", Especie = "Reptiles", Telefono = "981698999", MaxAnimales = 8 },
                new Refugio{ RefugioId = 4, Nombre = "Refugio04", Direccion = "Calle Nuñez Nº60", Especie = "Otros", Telefono = "915358967", MaxAnimales = 18 }
            }.AsQueryable();

            Mock<DbSet<Refugio>> mockTablaRefugios = new Mock<DbSet<Refugio>>();

            mockTablaRefugios.As<IQueryable<Refugio>>().Setup(x => x.Provider).Returns(datosRefugio.Provider);
            mockTablaRefugios.As<IQueryable<Refugio>>().Setup(x => x.Expression).Returns(datosRefugio.Expression);
            mockTablaRefugios.As<IQueryable<Refugio>>().Setup(x => x.GetEnumerator()).Returns(datosRefugio.GetEnumerator());

            IQueryable<Cuidador> datosCuidadores = new List<Cuidador>
            {
                new Cuidador{ CuidadorId = 1, RefugioId = 1, Nombre = "Alejandro Moreno Marin", Telefono = "693520354", Direccion = "Calle Ramos Nº50", SalarioAnual = 21149, Especie = "Reptiles", Responsable = true },
                new Cuidador{ CuidadorId = 2, RefugioId = 2, Nombre = "Laura Santos Gomez", Telefono = "855176901", Direccion = "Calle Gomez Nº73", SalarioAnual = 22743, Especie = "Reptiles", Responsable = false },
                new Cuidador{ CuidadorId = 3, RefugioId = 3, Nombre = "Luis Ortega Jimenez", Telefono = "774179922", Direccion = "Calle Sanchez Nº29", SalarioAnual = 23376, Especie = "Caninos", Responsable = true },
                new Cuidador{ CuidadorId = 4, RefugioId = 4, Nombre = "Francisca Gutierrez Morales", Telefono = "601925675", Direccion = "Calle Gutierrez Nº39", SalarioAnual = 15210, Especie = "Caninos", Responsable = false }
            }.AsQueryable();

            Mock<DbSet<Cuidador>> mockTablaCuidadores = new Mock<DbSet<Cuidador>>();

            mockTablaCuidadores.As<IQueryable<Cuidador>>().Setup(x => x.Provider).Returns(datosCuidadores.Provider);
            mockTablaCuidadores.As<IQueryable<Cuidador>>().Setup(x => x.Expression).Returns(datosCuidadores.Expression);
            mockTablaCuidadores.As<IQueryable<Cuidador>>().Setup(x => x.GetEnumerator()).Returns(datosCuidadores.GetEnumerator());

            IQueryable<Animal> datosAnimales = new List<Animal>
            {
                new Animal{ AnimalId = 1, RefugioId = 1, Nombre = "Animal01", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 5, EspacioMin = 10 },
                new Animal{ AnimalId = 2, RefugioId = 2, Nombre = "Animal02", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 6, EspacioMin = 20 },
                new Animal{ AnimalId = 3, RefugioId = 3, Nombre = "Animal03", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 7, EspacioMin = 30 },
                new Animal{ AnimalId = 4, RefugioId = 4, Nombre = "Animal04", Nacimiento = DateTime.Now, Entrada = DateTime.Now, Especie = "Otros", Raza = "Raza", Peso = 8, EspacioMin = 40 },
            }.AsQueryable();

            Mock<DbSet<Animal>> mockTablaAnimales = new Mock<DbSet<Animal>>();

            mockTablaAnimales.As<IQueryable<Animal>>().Setup(x => x.Provider).Returns(datosAnimales.Provider);
            mockTablaAnimales.As<IQueryable<Animal>>().Setup(x => x.Expression).Returns(datosAnimales.Expression);
            mockTablaAnimales.As<IQueryable<Animal>>().Setup(x => x.GetEnumerator()).Returns(datosAnimales.GetEnumerator());


            _mockZoocanBD.Setup(x => x.Refugios).Returns(mockTablaRefugios.Object);
            _mockZoocanBD.Setup(x => x.Cuidadores).Returns(mockTablaCuidadores.Object);
            _mockZoocanBD.Setup(x => x.Animales).Returns(mockTablaAnimales.Object);

            _herramientas = new Herramientas(_mockZoocanBD.Object);
        }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region ObtenerCuidadores
        [TestMethod]
        public void ObtenerCuidadores_DatosCorrectos()
        {
            // Act
            List<Cuidador> result = _herramientas.ObtenerCuidadores();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());
            Assert.AreEqual(1, result[0].CuidadorId);
            Assert.AreEqual(2, result[1].CuidadorId);
            Assert.AreEqual(3, result[2].CuidadorId);
            Assert.AreEqual(4, result[3].CuidadorId);
        }

        [TestMethod]
        public void ObtenerCuidadores_DatosIncorrectos()
        {
            // Act
            List<Cuidador> result = _herramientas.ObtenerCuidadores();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
            Assert.AreNotEqual(10, result[0].CuidadorId);
            Assert.AreNotEqual(20, result[1].CuidadorId);
            Assert.AreNotEqual(30, result[2].CuidadorId);
            Assert.AreNotEqual(40, result[3].CuidadorId);
        }
        #endregion

        #region ObtenerCuidadoresPorRefugio
        [TestMethod]
        public void ObtenerCuidadoresPorRefugio_DatosCorrectos()
        {
            // Arrange
            int refugioId = 2;

            // Act
            List<Cuidador> resultado = _herramientas.ObtenerCuidadoresPorRefugio(refugioId);

            // Assert
            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(2, resultado[0].CuidadorId);
        }

        [TestMethod]
        public void ObtenerCuidadoresPorRefugio_DatosIncorrectos()
        {
            // Arrange
            int refugioId = 2;

            // Act
            List<Cuidador> resultado = _herramientas.ObtenerCuidadoresPorRefugio(refugioId);

            // Assert
            Assert.AreNotEqual(2, resultado.Count);
            Assert.AreNotEqual(1, resultado[0].CuidadorId);
        }

        [TestMethod]
        public void ObtenerCuidadoresPorRefugio_LanzarZoocanException()
        {
            // Arrange
            int refugioId = -1;

            // Act
            List<Cuidador> resultado = _herramientas.ObtenerCuidadoresPorRefugio(refugioId);

            // Assert
            Assert.AreEqual(0, resultado.Count());
        }
        #endregion

        #region ObtenerCuidadorPorId
        [TestMethod]
        public void ObtenerCuidadorPorId_DatosCorrectos()
        {
            int id = 1;

            Cuidador cuidador = _herramientas.ObtenerCuidadorPorId(id);

            Assert.IsNotNull(cuidador);
            Assert.AreEqual(1, cuidador.CuidadorId);
        }

        [TestMethod]
        public void ObtenerCuidadorPorId_DatosIncorrectos()
        {
            int id = 0;

            Cuidador cuidador = _herramientas.ObtenerCuidadorPorId(id);

            Assert.IsNull(cuidador);
        }
        #endregion

        #region ObtenerCuidadorPorNombre
        [TestMethod]
        public void ObtenerCuidadorPorNombre_DatosCorrectos()
        {
            Cuidador cuidador = _herramientas.ObtenerCuidadorPorNombre("Alejandro Moreno Marin");

            Assert.IsNotNull(cuidador);
            Assert.AreEqual(1, cuidador.CuidadorId);
        }

        [TestMethod]
        public void ObtenerCuidadorPorNombre_DatosIncorrectos()
        {
            Cuidador cuidador = _herramientas.ObtenerCuidadorPorNombre("Toño");

            Assert.IsNull(cuidador);
        }

        [TestMethod]
        public void ObtenerCuidadorPorNombre_ParametrosNulos()
        {
            Cuidador cuidador = _herramientas.ObtenerCuidadorPorNombre(null);

            Assert.IsNull(cuidador);
        }
        #endregion

        #region ObtenerCuidadorResponsablePorRefugioId
        [TestMethod]
        public void ObtenerCuidadorResponsablePorRefugioId_DatosCorrectos()
        {
            Cuidador cuidador = _herramientas.ObtenerCuidadorResponsablePorRefugioId(2);

            Assert.IsNotNull(cuidador);
            Assert.AreEqual(2, cuidador.CuidadorId);
        }

        [TestMethod]
        public void ObtenerCuidadorResponsablePorRefugioId_DatosIncorrectos()
        {
            Cuidador cuidador = _herramientas.ObtenerCuidadorResponsablePorRefugioId(-1);

            Assert.IsNull(cuidador);
        }
        #endregion

        #region CrearCuidador
        [TestMethod]
        public void CrearCuidador_DatosCorrectos()
        {
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 5,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº50",
                SalarioAnual = 21149,
                Especie = "Caninos",
                Responsable = false
            };

            _herramientas.CrearCuidador(cuidador);
        }

        [TestMethod]
        public void CrearCuidador_DatosIncorrectos()
        {
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 5,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº50",
                SalarioAnual = 21149,
                Especie = "Caninos",
                Responsable = false
            };

            _herramientas.CrearCuidador(cuidador);

            Assert.AreNotEqual(10, cuidador.CuidadorId);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearCuidador_ParametrosNulos()
        {
            _herramientas.CrearCuidador(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearCuidador_LanzarZoocanException_Responsable()
        {
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 5,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº50",
                SalarioAnual = 21149,
                Especie = "Otros",
                Responsable = true
            };

            _herramientas.CrearCuidador(cuidador);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearCuidador_LanzarZoocanException_Especie()
        {
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 5,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº50",
                SalarioAnual = 21149,
                Especie = "Reptiles",
                Responsable = false
            };

            _herramientas.CrearCuidador(cuidador);
        }
        #endregion

        #region BorrarCuidador
        [TestMethod]
        public void BorrarCuidador_DatosCorrectos()
        {
            _herramientas.BorrarCuidador(1);
        }

        [TestMethod]
        public void BorrarCuidador_DatosIncorrectos()
        {
            _herramientas.BorrarCuidador(-1);
        }
        #endregion

        #region ActualizarCuidador
        [TestMethod]
        public void ActualizarCuidador_DatosCorrectos()
        {
            // Arrange
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 1,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº49",
                SalarioAnual = 21149,
                Especie = "Caninos",
                Responsable = false
            };
            // Act
            _herramientas.ActualizarCuidador(cuidador);

            // Assert
            Assert.AreEqual(1, cuidador.CuidadorId);
            Assert.AreEqual(2, cuidador.RefugioId);
            Assert.AreEqual("Alejandro Moreno Marin", cuidador.Nombre);
            Assert.AreEqual("693520354", cuidador.Telefono);
            Assert.AreEqual("Calle Ramos Nº49", cuidador.Direccion);
            Assert.AreEqual(21149, cuidador.SalarioAnual);
            Assert.AreEqual("Caninos", cuidador.Especie);
            Assert.IsFalse(cuidador.Responsable);
        }

        [TestMethod]
        public void ActualizarCuidador_DatosIncorrectos()
        {
            // Arrange
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 1,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº49",
                SalarioAnual = 21149,
                Especie = "Caninos",
                Responsable = false
            };
            // Act
            _herramientas.ActualizarCuidador(cuidador);

            // Assert
            Assert.AreNotEqual(10, cuidador.CuidadorId);
            Assert.AreNotEqual(20, cuidador.RefugioId);
            Assert.AreNotEqual("Alejandro Moreno Martin", cuidador.Nombre);
            Assert.AreNotEqual("6935203541", cuidador.Telefono);
            Assert.AreNotEqual("Calle Ramos Nº50", cuidador.Direccion);
            Assert.AreNotEqual(21150, cuidador.SalarioAnual);
            Assert.AreNotEqual("Canino", cuidador.Especie);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarCuidador_ParametrosNulos()
        {
            // Arrange
            Cuidador cuidador = null;
            // Act
            _herramientas.ActualizarCuidador(cuidador);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarCuidador_LanzarZoocanException_Responsable()
        {
            // Arrange
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 1,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº50",
                SalarioAnual = 21149,
                Especie = "Otros",
                Responsable = true
            };
            // Act
            _herramientas.ActualizarCuidador(cuidador);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarCuidador_LanzarZoocanException_Especie()
        {
            // Arrange
            Cuidador cuidador = new Cuidador
            {
                CuidadorId = 1,
                RefugioId = 2,
                Nombre = "Alejandro Moreno Marin",
                Telefono = "693520354",
                Direccion = "Calle Ramos Nº50",
                SalarioAnual = 21149,
                Especie = "falso",
                Responsable = false
            };
            // Act
            _herramientas.ActualizarCuidador(cuidador);
        }
        #endregion
    }
}
