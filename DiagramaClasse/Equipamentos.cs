using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasse
{
    internal abstract class Equipamentos
    {
        /// <summary>
        /// Perda de carga no equipamento (m)
        /// </summary>
        public double perdaCarga
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Calcula a perda de carga no equpamento
        /// </summary>
        public double calculaPerdaCarga()
        {
            throw new System.NotImplementedException();
        }
    }
}