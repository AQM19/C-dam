using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ZoocanV2;

namespace ZoocanUnitTest
{
    /// <summary>
    /// Descripción resumida de UnitTestAnimales
    /// </summary>
    [TestClass]
    public class UnitTestAnimales
    {
        public UnitTestAnimales()
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
                new Refugio{ RefugioId = 4, Nombre = "Refugio04", Direccion = "Calle Nuñez Nº60", Especie = "Otros", Telefono = "915358967", MaxAnimales = 0 }
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

        #region ObtenerAnimales
        [TestMethod]
        public void ObtenerAnimales_DatosCorrectos()
        {
            // Act
            List<Animal> Animales = _herramientas.ObtenerAnimales();

            // Assert
            Assert.IsNotNull(Animales);
            Assert.AreEqual(4, Animales.Count);
            Assert.AreEqual(1, Animales[0].AnimalId);
            Assert.AreEqual(2, Animales[1].AnimalId);
            Assert.AreEqual(3, Animales[2].AnimalId);
            Assert.AreEqual(4, Animales[3].AnimalId);
        }

        [TestMethod]
        public void ObtenerAnimales_DatosIncorrectos()
        {
            // Act
            List<Animal> Animales = _herramientas.ObtenerAnimales();

            // Assert
            Assert.AreNotEqual(80, Animales.Count);
            Assert.AreNotEqual(91, Animales[0].AnimalId);
            Assert.AreNotEqual(92, Animales[1].AnimalId);
            Assert.AreNotEqual(93, Animales[2].AnimalId);
            Assert.AreNotEqual(94, Animales[3].AnimalId);
        }
        #endregion

        #region ObtenerAnimalesPorRefugio
        [TestMethod]
        public void ObtenerAnimalesPorRefugio_DatosCorrectos()
        {
            List<Animal> Animales = _herramientas.ObtenerAnimalesPorRefugio(1);

            Assert.IsNotNull(Animales);
            Assert.AreEqual(1, Animales.Count());
            Assert.AreEqual(1, Animales[0].AnimalId);
        }

        [TestMethod]
        public void ObtenerAnimalesPorRefugio_DatosIncorrectos()
        {
            List<Animal> Animales = _herramientas.ObtenerAnimalesPorRefugio(1);

            Assert.AreNotEqual(10, Animales.Count());
            Assert.AreNotEqual(10, Animales[0].AnimalId);
        }
        #endregion

        #region ObtenerAnimal
        [TestMethod]
        public void ObtenerAnimal_DatosCorrectos()
        {
            Animal animal = _herramientas.ObtenerAnimale(1);

            Assert.IsNotNull(animal);
            Assert.AreEqual(1, animal.AnimalId);
        }

        [TestMethod]
        public void ObtenerAnimal_DatosIncorrectos()
        {
            Animal animal = _herramientas.ObtenerAnimale(1);

            Assert.AreNotEqual(10, animal.AnimalId);
        }
        #endregion

        #region CrearAnimal
        [TestMethod]
        public void CrearAnimal_DatosCorrectos()
        {
            Animal animal = new Animal
            {
                AnimalId = 5,
                RefugioId = 1,
                Nombre = "Animal01",
                Nacimiento = new DateTime(2009, 8, 1, 0, 0, 0),
                Entrada = new DateTime(2009, 8, 5, 12, 0, 0),
                Especie = "Otros",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.CrearAnimale(animal);

            Assert.AreEqual(5, animal.AnimalId);

        }

        [TestMethod]
        public void CrearAnimal_DatosIncorrectos()
        {
            Animal animal = new Animal
            {
                AnimalId = 5,
                RefugioId = 1,
                Nombre = "Animal01",
                Nacimiento = new DateTime(2009, 8, 1, 0, 0, 0),
                Entrada = new DateTime(2009, 8, 5, 12, 0, 0),
                Especie = "Otros",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.CrearAnimale(animal);

            Assert.AreNotEqual(10, animal.AnimalId);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearAnimal_ParametrosNulos()
        {
            _herramientas.CrearAnimale(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearAnimal_LanzarZoocanException_Nacimiento()
        {
            Animal animal = new Animal
            {
                AnimalId = 5,
                RefugioId = 1,
                Nombre = "Animal01",
                Nacimiento = DateTime.Now,
                Entrada = DateTime.Now,
                Especie = "Caninos",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.CrearAnimale(animal);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void CrearAnimal_LanzarZoocanException_MaxAnimales()
        {
            Animal animal = new Animal
            {
                AnimalId = 5,
                RefugioId = 4,
                Nombre = "Animal01",
                Nacimiento = new DateTime(2009, 8, 1, 0, 0, 0),
                Entrada = new DateTime(2009, 8, 5, 12, 0, 0),
                Especie = "Caninos",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.CrearAnimale(animal);
        }
        #endregion

        #region BorrarAnimal
        [TestMethod]
        public void BorrarAnimal_DatosCorrectos()
        {
            _herramientas.BorrarAnimale(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void BorrarAnimal_DatosIncorrectos()
        {
            _herramientas.BorrarAnimale(0);
        }
        #endregion

        #region ActualizarAnimal
        [TestMethod]
        public void ActualizarAnimal_DatosCorrectos()
        {
            Animal animal = new Animal
            {
                AnimalId = 1,
                RefugioId = 1,
                Nombre = "Animal01",
                Nacimiento = new DateTime(2009, 8, 1, 0, 0, 0),
                Entrada = new DateTime(2009, 8, 5, 12, 0, 0),
                Especie = "Otros",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.ActualizarAnimale(animal);
            //_mockZoocanBD.Verify(db => db.SaveChanges(), Times.Never());

            Assert.AreEqual(1, animal.AnimalId);
            Assert.AreEqual(1, animal.RefugioId);
            Assert.AreEqual("Animal01", animal.Nombre);
            Assert.AreEqual(new DateTime(2009, 8, 1, 0, 0, 0), animal.Nacimiento);
            Assert.AreEqual(new DateTime(2009, 8, 5, 12, 0, 0), animal.Entrada);
            Assert.AreEqual("Otros", animal.Especie);
            Assert.AreEqual("Raza", animal.Raza);
            Assert.AreEqual(5, animal.Peso);
            Assert.AreEqual(10, animal.EspacioMin);
        }

        [TestMethod]
        public void ActualizarAnimal_DatosIncorrectos()
        {
            Animal animal = new Animal
            {
                AnimalId = 1,
                RefugioId = 1,
                Nombre = "Animal01",
                Nacimiento = new DateTime(2009, 8, 1, 0, 0, 0),
                Entrada = new DateTime(2009, 8, 5, 12, 0, 0),
                Especie = "Otros",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.ActualizarAnimale(animal);
            //_mockZoocanBD.Verify(db => db.SaveChanges(), Times.Never());

            Assert.AreNotEqual(10, animal.AnimalId);
            Assert.AreNotEqual(10, animal.RefugioId);
            Assert.AreNotEqual("Animal00", animal.Nombre);
            Assert.AreNotEqual(new DateTime(2009, 8, 2, 0, 0, 0), animal.Nacimiento);
            Assert.AreNotEqual(new DateTime(2009, 8, 7, 12, 0, 0), animal.Entrada);
            Assert.AreNotEqual("Otro", animal.Especie);
            Assert.AreNotEqual("Razas", animal.Raza);
            Assert.AreNotEqual(6, animal.Peso);
            Assert.AreNotEqual(100, animal.EspacioMin);
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarAnimal_LanzarZoocanException_Nulo()
        {
            _herramientas.ActualizarAnimale(null);
            //_mockZoocanBD.Verify(db => db.SaveChanges(), Times.Never());
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarAnimal_LanzarZoocanException_Nacimiento()
        {
            Animal animal = new Animal
            {
                AnimalId = 1,
                RefugioId = 1,
                Nombre = "Animal01",
                Nacimiento = DateTime.Now,
                Entrada = DateTime.Now,
                Especie = "Otros",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.ActualizarAnimale(animal);
            //_mockZoocanBD.Verify(db => db.SaveChanges(), Times.Never());
        }

        [TestMethod]
        [ExpectedException(typeof(ZoocanException))]
        public void ActualizarAnimal_LanzarZoocanException_MaxAnimales()
        {
            Animal animal = new Animal
            {
                AnimalId = 1,
                RefugioId = 4,
                Nombre = "Animal01",
                Nacimiento = new DateTime(2009, 8, 1, 0, 0, 0),
                Entrada = new DateTime(2009, 8, 5, 12, 0, 0),
                Especie = "Otros",
                Raza = "Raza",
                Peso = 5,
                EspacioMin = 10
            };

            _herramientas.ActualizarAnimale(animal);
            //_mockZoocanBD.Verify(db => db.SaveChanges(), Times.Never());
        }
        #endregion

    }
}
