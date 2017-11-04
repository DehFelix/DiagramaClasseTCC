using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramaClasse
{
    public interface Itubulacao
    {
        /// <summary>
        /// Comprimento da tubulação
        /// </summary>
        double comprimento { get; set; }
        /// <summary>
        /// Comprimento equivalente das sigularidades
        /// </summary>
        double comprimentoEquivalente { get; set; }
        /// <summary>
        /// Diametro da tubulação (m)
        /// </summary>
        double diametro { get; set; }
        /// <summary>
        /// Tipo de material
        /// </summary>
        string material { get; set; }
        /// <summary>
        /// Rugosidede do material
        /// </summary>
        double rugosidade { get; set; }
        /// <summary>
        /// Rugosidade relativa do mateira
        /// </summary>
        double rugosidadeRelativa { get; set; }
        /// <summary>
        /// Fator de atrido na condição de escoamento
        /// </summary>
        double fatorAtrito { get; set; }
        /// <summary>
        /// Lista de singulariedades na tubulação
        /// </summary>
        List<Singularidade> listaSingulariedades { get; set; }
        /// <summary>
        /// Calcula a equação da perda de carga em função da velocidade
        /// </summary>
        string calculaEqCarga();
    }
}