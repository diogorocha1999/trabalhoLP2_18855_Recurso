/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>26/06/2020</date>
 * <description>Esta classe define um caso.</description>
 * --------------------------------------------------------------------------------
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Classes
{
    /// <summary>
    /// Classe caso.Define um caso
    /// </summary>

    [Serializable]
    public class Caso : Pessoa
    {

        #region Atributos
        protected string doenteRisco;

        #endregion

        #region Construtor


        public Caso()
        {
        }

        /// <summary>
        /// Construtor com dados do exterior
        /// </summary>
        /// <param name="rRegiao"></param>
        /// <param name="iIdade"></param>
        /// <param name="gGenero"></param>
        /// <param name="dDoenteRisco"></param>
        public Caso(string nNome, string rRegiao, int iIdade, string gGenero, string dDoenteRisco) : base(nNome, rRegiao, iIdade, gGenero)
        {
            doenteRisco = dDoenteRisco;
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Manipula atributo doenteRisco
        /// </summary>

        public string DDoenteRisco
        {
            get { return doenteRisco; }
            set { value = doenteRisco; }
        }


        #endregion

        #region Métodos
        ///// <summary>
        ///// Imprime a lista de casos.
        ///// </summary>
        ///// <param name="casolista"></param>
        //public void ListaCasos()
        //{
        //    List<Caso> aux = GetAllCases();
        //    foreach (Caso x in aux) 
        //    {
        //        Console.WriteLine("Nome: " + x.Nome + " Região: " + x.Regiao + " Idade " + x.Idades + " Genero: " + x.Genero);
        //    }
        //}

        #region Metodos antigos
        /// <summary>
        /// Consulta casos por região e conta o numero de casos para essa região.
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="pRegiao"></param>
        /// <returns></returns>
        //public int ConsultaRegiao(List<Caso> casos, string pRegiao)
        //{
        //    try
        //    {
        //        int qtdRegiao = 0;

        //        foreach (Caso c in casos)
        //        {
        //            if (c.regiao == pRegiao)
        //            {
        //                qtdRegiao++;
        //            }
        //        }

        //        return qtdRegiao;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}

        /// <summary>
        /// Consulta casos por idade e conta o numero de casos com essa idade.
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="pIdade"></param>
        /// <returns></returns>
        //public int ConsultaIdade(List<Caso> casos, int pIdade)
        //{
        //    try
        //    {
        //        int qtIdades = 0;
        //        foreach (Caso c in casos)
        //        {
        //            if (c.Idades == pIdade)
        //            {
        //                qtIdades++;
        //            }
        //        }
        //        return qtIdades;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        /// <summary>
        /// Consulta casos por género e conta o numero de casos com esse genero.
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="pGenero"></param>
        /// <returns></returns>
        //public int ConsultaGenero(List<Caso> casos, string pGenero)
        //{
        //    try
        //    {
        //        int qtGenero = 0;
        //        foreach (Caso c in casos)
        //        {
        //            if (c.Genero == pGenero)
        //            {
        //                qtGenero++;
        //            }
        //        }
        //        return qtGenero;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        /// <summary>
        /// Conta o numero de casos sem risco
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="risco"></param>
        /// <returns></returns>
        //public int ContaRisco(List<Caso> casos, string risco)
        //{
        //    try
        //    {
        //        int qtrisco = 0;
        //        foreach (Caso c in casos)
        //        {
        //            if (c.doenteRisco == risco)
        //            {
        //                qtrisco++;
        //            }

        //        }
        //        return qtrisco;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        /// <summary>
        /// Conta o numero de casos com risco
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="semRisco"></param>
        /// <returns></returns>
        //public int ContaSemRisco(List<Caso> casos, string semRisco)
        //{
        //    try
        //    {
        //        int qtrisco = 0;
        //        foreach (Caso c in casos)
        //        {
        //            if (c.doenteRisco == semRisco)
        //            {
        //                qtrisco++;
        //            }

        //        }
        //        return qtrisco;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}


        /// <summary>
        /// Indica a maior idade infetada
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        //public int MaiorIdade(List<Caso> casos)
        //{
        //    try
        //    {
        //        int maior = 0;
        //        foreach (Caso c in casos)
        //        {
        //            if (maior < c.Idades)
        //            {
        //                maior = c.Idades;
        //            }
        //        }
        //        return maior;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        /// <summary>
        /// Faz a média de idades dos casos registados.
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        //public int MediaIdades(List<Caso> casos)
        //{
        //    int soma = 0;
        //    int media;

        //    for (int i = 0; i < casos.Count; i++)
        //    {
        //        soma += casos[i].Idades;
        //    }
        //    media = soma / casos.Count;
        //    return media;
        //}


        /// <summary>
        /// Indica a percentagem de casos por sexo masculino.
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        //public float PercentagemGeneroM(List<Caso> casos)
        //{

        //    float percentagemM;

        //    int contaM = 0;

        //    string pMasculino = "Masculino";
        //    for (int i = 0; i < casos.Count; i++)
        //    {
        //        if (casos[i].Genero == pMasculino)
        //        {
        //            contaM++;
        //        }
        //    }

        //    percentagemM = (float)contaM / casos.Count;


        //    return percentagemM;
        //}

        /// <summary>
        /// Indica a percentagem de casos por sexo feminino
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        //public float PercentagemGeneroF(List<Caso> casos)
        //{

        //    float percentagemF;

        //    int contaF = 0;
        //    string pFeminino = "Feminino";
        //    for (int i = 0; i < casos.Count; i++)
        //    {
        //        if (casos[i].Genero == pFeminino)
        //        {
        //            contaF++;
        //        }

        //    }
        //    percentagemF = (float)contaF / casos.Count;
        //    return percentagemF;
        //}

        /// <summary>
        /// Grava os dados inseridos em ficheiro.
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        #endregion

        #endregion
    }
}