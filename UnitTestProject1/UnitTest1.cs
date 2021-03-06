﻿using System;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task EnviaUmPacoteDe15631Registros()
        {
            var s = await new Program().RetornaPacotes(1, 15631);
            Assert.AreEqual(4, s.Count);
        }
        [TestMethod]
        public async Task Envia100PacotesComValoresDiversos()
        {
            for (int i = 0; i < 99; i++)
            {
                var totalPacote = new Random().Next(1, 10000000);
                var numPacote = new Random().Next(1, 20);

                var s = await new Program().RetornaPacotes(numPacote, totalPacote);


                var assertCount = totalPacote / 5000;
                var resto = (totalPacote % 5000);

                if (resto > 0) assertCount += 1;


                Assert.AreEqual(assertCount, s.Count);
            }

        }

        [TestMethod]
        public async Task Envia1000000PacotesComValoresDiversos()
        {
            for (int i = 0; i < 999999; i++)
            {
                var totalPacote = new Random().Next(1, 10000000);
                var numPacote = new Random().Next(1, 20);

                var s = await new Program().RetornaPacotes(numPacote, totalPacote);


                var assertCount = totalPacote / 5000;
                var resto = (totalPacote % 5000);

                if (resto >= 0) assertCount += 1;

                //Console.WriteLine("Total Pacote:" + totalPacote + " Numero Pacote: " + numPacote);

                Assert.AreEqual(assertCount, s.Count);

            }
        }
        [TestMethod]
        public async Task EnviaUmPacoteComValoreMenorQueoLimite()
        {
            var s = await new Program().RetornaPacotes(1, 4999);
            Assert.AreEqual(1, s.Count);
        }
    }
}
