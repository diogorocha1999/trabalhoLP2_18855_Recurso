/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>26/06/2020</date>
 * <description>Esta classe define uma pessoa.</description>
 * --------------------------------------------------------------------------------
 */

using System;

namespace Classes
{
    /// <summary>
    /// Classe Pessoa.Define uma pessoa.
    /// </summary>
    [Serializable]
    public class Pessoa
    {
        #region Atributos
        protected string regiao;
        protected int idades;
        protected string genero;
        protected string nome;


        #endregion

        #region Construtor


        public Pessoa()
        {


        }


        /// <summary>
        /// Construtor com dados do exterior
        /// </summary>
        /// <param name="rRegiao"></param>
        /// <param name="iIdade"></param>
        /// <param name="gGenero"></param>
        public Pessoa(string nNome, string rRegiao, int iIdade, string gGenero)
        {
            nome = nNome;
            regiao = rRegiao;
            idades = iIdade;
            genero = gGenero;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Manipula atributo "nome"
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { if (nome.Length > 10) nome = value; }
        }


        /// <summary>
        /// Manipula atributo "regiao"
        /// int regiao;
        /// </summary>
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }

        /// <summary>
        /// Manipula atributo "idade"
        /// int idades;
        /// </summary>
        public int Idades
        {
            get { return idades; }
            set { if (value > 0 && value < 115) idades = value; }
        }

        /// <summary>
        /// Manipula atributo "genero"
        /// int genero;
        /// </summary>
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        #endregion

        #region Métodos

        #endregion

    }
}
