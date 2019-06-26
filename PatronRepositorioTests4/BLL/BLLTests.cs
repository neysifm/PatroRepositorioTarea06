using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.DAL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL.Tests
{
    [TestClass()]
    public class BLLTests
    {
        [TestMethod()]                            
        public void GuardarTest()
        {

            Assert.IsTrue(new RepositorioBase<Estados>().Guardar(new Estados()
            {
                Estado = "Hola",
                
            })); 
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }
    }

    [TestClass]
    public class UsuarioBLL
    {
        [TestMethod()]
        public void GuardarTest()
        {

            Assert.IsTrue(new RepositorioBase<Usuarios>().Guardar(new Usuarios()
            {
                Usuario = "asdfsd",
                Clave = "adf"

            }));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }
    }
}