/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>22/05/2020</date>
 * <description>Esta classe define um obito.</description>
 * --------------------------------------------------------------------------------
 */

namespace Classes
{
    /// <summary>
    /// Classe Obitos.Define um obito
    /// </summary>
    public class Obitos : Pessoa
    {
        #region Atributos
        Causas causas;
        #endregion

        #region Construtor
        public Obitos()
        {

        }

        /// <summary>
        /// Construtor com dados do exterior
        /// </summary>
        /// <param name="rRegiao"></param>
        /// <param name="iIdade"></param>
        /// <param name="gGenero"></param>
        /// <param name="cMorte"></param>
        public Obitos(string nNome, string rRegiao, int iIdade, string gGenero, Causas cCausa) : base(nNome, rRegiao, iIdade, gGenero)
        {
            causas = cCausa;
        }

        public Causas Causa
        {
            get { return causas; }
            set { causas = value; }
        }
        #endregion

        #region Propriedades   
        public enum Causas
        {
            Covid,
            Gripe
        }
 

        #endregion

    }
}
