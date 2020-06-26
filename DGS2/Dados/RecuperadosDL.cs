/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>26/06/2020</date>
 * <description>Esta classe é onde são trabalhados os dados referentes a classe Recuperado </description>
 * --------------------------------------------------------------------------------
 */

using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Dados
{
    /// <summary>
    ///Classe RecuperadosDL.Trabalha com os dados da classe Recuperado.
    /// </summary>
    public class RecuperadosDL
    {
        #region Atributos
        static List<Recuperados> doentesRecuperados;
        #endregion

        #region Construtor
        static RecuperadosDL()
        {
            doentesRecuperados = new List<Recuperados>();
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Insere um recuperado caso seja verdade.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool InsertRecover(Recuperados x)
        {
            if (doentesRecuperados.Contains(x))
            {
                return false;
            }
            doentesRecuperados.Add(x);
            return true;
        }

        /// <summary>
        /// Retorna os dados inseridos na lista de recuperados
        /// </summary>
        /// <returns></returns>
        public static List<Recuperados> GetAllRecovers()
        {
            return (doentesRecuperados);
        }

        /// <summary>
        /// Conta o numero de pessoas nao recuperadas.
        /// </summary>
        /// <param name="recuperados"></param>
        /// <param name="mau"></param>
        /// <returns></returns>
        public static int ContaNaoRecuperados(string mau)
        {
            try
            {
                int qtmau = 0;
                foreach (Recuperados c in doentesRecuperados)
                {
                    if (c.Recuperado == mau)
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
        public static int ContaRecuperados(string bom)
        {
            try
            {
                int qtbom = 0;
                foreach (Recuperados c in doentesRecuperados)
                {
                    if (c.Recuperado == bom)
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
        public static bool SaveCaso(string filename)
        {
            if (File.Exists(filename))
            {
                try
                {
                    Stream stream = File.Open(filename, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, doentesRecuperados);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// Carrega o ficheiro com os dados foram gravados.
        /// NÃO CONSEGUI IMPLEMENTAR!!!
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool LoadRecuperados(string fileName)
        {

            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    doentesRecuperados = (List<Recuperados>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
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
        public static string FormataDadosR()
        {
            string lista = "";


            foreach (Recuperados x in doentesRecuperados)
            {
                lista += String.Format("\n" + "Nome" + x.Nome + "Região: " + x.Regiao + " Idade " + x.Idades + " Genero: " + x.Genero + " Sintomas : " + x.Recuperado + "\n");
            }

            return lista;

        }

        #endregion
    }
}
