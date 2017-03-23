using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverCSharpConsole;

namespace TestesDeUnidade
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void Mover_ComValorValido_UpdateCoords()
        {
            //declaração 
            Rover rover = new Rover(2, 3, "N");
            // ação 
            rover.mover();
            //checagem 
            string expected = "2 4 N";
            string atual = rover.getCoordx() + " " + rover.getCoordy() + " " + rover.getDir();
            Assert.AreEqual(expected, atual, "Method mover did not executed correctly");
        }

        [TestMethod]
        public void Mover_ComValorInvalido_UpdateCoords()
        {
            //declaração 
            Rover rover = new Rover(0, 3, "W");
            // ação 
            rover.mover();
            //checagem 
            string expected = "0 3 W";
            string atual = rover.getCoordx() + " " + rover.getCoordy() + " " + rover.getDir();
            Assert.AreEqual(expected, atual, "Method mover can't move the rover to negative coordinates");
        }

        [TestMethod]
        public void MudarDir_ComCaracterValido_UpdateDir()
        {
            Rover rover = new Rover(0, 3, "N");
            rover.mudaDir("R");
            string expected = "0 3 E";
            string atual = rover.getCoordx() + " " + rover.getCoordy() + " " + rover.getDir();
            Assert.AreEqual(expected, atual, "Method mudaDir did not move the rover to the right direction");
        }

        [TestMethod]
        public void MudaDir_ComCaracterInvalido_UpdateDir()
        {
            Rover rover = new Rover(0, 3, "N");
            rover.mudaDir("A");
            string expected = "0 3 N";
            string atual = rover.getCoordx() + " " + rover.getCoordy() + " " + rover.getDir();
            Assert.AreEqual(expected, atual, "Method mudaDir did not worked, invalid direction");
        }
    }
}
