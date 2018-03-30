﻿using System.Collections.Generic;

namespace ConsoleApp1
{
    public class RetornaPacotes
    {
        const int TOTAL_BY_PACKAGE = 5000;
        public Dictionary<int, int> retorno = new Dictionary<int, int>();
        public Dictionary<int, int> PackageGenerator(int pacote, int numTotalRegistros)
        {
            var pacotes = numTotalRegistros / TOTAL_BY_PACKAGE;
            if (pacotes == 0)
            {
                retorno.Add(pacote, numTotalRegistros);
            }
            else
            {
                retorno.Add(pacote, TOTAL_BY_PACKAGE);
                PackageGenerator(++pacote, numTotalRegistros - TOTAL_BY_PACKAGE);

            }
            return retorno;
        }
    }
}
