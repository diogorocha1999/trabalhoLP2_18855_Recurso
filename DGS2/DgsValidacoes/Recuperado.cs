/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>26/06/2020</date>
 * <description>Esta classe define um recuperado.</description>
 * --------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Classes
{
    /// <summary>
    /// Classe Recuperados.Define um recuperado
    /// </summary>
    [Serializable]
    public class Recuperados : Pessoa
    {
        #region Atributos
        protected string recuperado;
        #endregion

        #region Construtor
        public Recuperados()
        {

        }

        /// <summary>
        /// Construtor com dados do exterior
        /// </summary>
        /// <param name="rRegiao"></param>
        /// <param name="iIdade"></param>
        /// <param name="gGenero"></param>
        /// <param name="rRecuperado"></param>
        public Recuperados(string nNome, string rRegiao, int iIdade, string gGenero, string rRecuperado) : base(nNome, rRegiao, iIdade, gGenero)
        {
            recuperado = rRecuperado;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Manipula atributo recuperado
        /// </summary>
        public string Recuperado
        {
            get { return recuperado; }
            set {recuperado = value; }
        }
        #endregion

        #region Métodos

        ///// <summary>
        ///// Imprime a lista de recuperados e nao recuperados
        ///// </summary>
        ///// <param name="casolista"></param>
        //public void ListaRecuperados()
        //{
        //    foreach (Recuperados x in doentes)
        //    {
        //        Console.WriteLine("\n" + "Nome: " + x.Nome + " Região: " + x.Regiao + " Idade: " + x.Idades + " Genero: " + x.Genero + " Recuperado: " + x.Recuperado);
        //    }
        //}

            /// <summary>
            /// Conta o numero de pessoas nao recuperadas.
            /// </summary>
            /// <param name="recuperados"></param>
            /// <param name="mau"></param>
            /// <returns></returns>
        public int ContaNaoRecuperados(List<Recuperados> recuperados, string mau)
        {
            try
            {
                int qtmau = 0;
                foreach (Recuperados c in recuperados)
                {
                    if (c.recuperado == mau)
                    {
                        qtmau++;
                    }
                }
                return qtmau;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Conta o numero de pessoas recuperadas
        /// </summary>
        /// <param name="recuperados"></param>
        /// <param name="bom"></param>
        /// <returns></returns>
        public int ContaRecuperados(List<Recuperados> recuperados, string bom)
        {
            try
            {
                int qtbom = 0;
                foreach (Recuperados c in recuperados)
                {
                    if (c.recuperado == bom)
                    {
                        qtbom++;
                    }

                }
                return qtbom;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Grava os dados inseridos em ficheiro.
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static bool SaveCaso(List<Recuperados> casos, string filename)
        {
            if (File.Exists(filename))
            {
                try
                {
                    Stream stream = File.Open(filename, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, casos);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    Console.Write("Erro de gravação: " + e.Message);
                    throw e;
                }
            }
            return false;
        }

        ///// <summary>
        ///// Limpa a lista.
        ///// </summary>
        ///// <param name="casos"></param>
        //public static void LimpaRecuperados(List<Recuperados> casos)
        //{
        //    casos.Clear();
        //}

        /// <summary>
        /// Carrega o ficheiro com os dados foram gravados.
        /// NÃO CONSEGUI IMPLEMENTAR!!!
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadRecuperados(List<Recuperados> casos, string fileName)
        {

            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    casos = (List<Recuperados>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    Console.Write("ERRO!!:" + e.Message);
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// Le os dados guardados do ficheiro.
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        public static string LeFicheiro(List<Recuperados> casos)
        {
            string lista = "";


            foreach (Recuperados x in casos)
            {
                lista += String.Format("Nome"+ x.Nome + "Região: " + x.Regiao + " Idade " + x.Idades + " Genero: " + x.Genero + " Sintomas : " + x.Recuperado + "\n");
            }

            return lista;

        }
        #endregion
    }
}
