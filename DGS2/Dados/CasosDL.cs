/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>22/05/2020</date>
 * <description>Esta classe é onde são trabalhados os dados referentes a classe Caso </description>
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
    /// Classe CasosDL.Trabalha com os dados da classe Caso
    /// </summary>
    public class CasosDL
    {

        #region Atributos
        static List<Caso> allCases;
        #endregion

        #region Metodos

        #region Construtor
        /// <summary>
        /// Construtor cases
        /// </summary>
        static CasosDL()
        {
            allCases = new List<Caso>();
        }
        #endregion


        /// <summary>
        /// Retorna todos os dados inseridos na lista Caso.
        /// </summary>
        /// <returns></returns>
        public static List<Caso> GetAllCases()
        {
            return (allCases);
        }

        /// <summary>
        /// Consulta casos por região e conta o numero de casos para essa região.
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="pRegiao"></param>
        /// <returns></returns>
        public static int ConsultaRegiao(string pRegiao)
        {
            try
            {
                int qtdRegiao = 0;

                foreach (Caso c in allCases)
                {
                    if (c.Regiao == pRegiao)
                    {
                        qtdRegiao++;
                    }
                }

                return qtdRegiao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Conta o numero de casos com risco
        /// </summary>
        /// <param name="casos"></param>
        /// <param name="semRisco"></param>
        /// <returns></returns>
        public static int ContaRisco(string semRisco)
        {
            try
            {
                int qtrisco = 0;
                foreach (Caso c in allCases)
                {
                    if (c.DDoenteRisco == semRisco)
                    {
                        qtrisco++;
                    }

                }
                return qtrisco;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Indica a maior idade infetada
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        public static int MaiorIdade()
        {
            try
            {
                int maior = 0;
                foreach (Caso c in allCases)
                {
                    if (maior < c.Idades)
                    {
                        maior = c.Idades;
                    }
                }
                return maior;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Faz a média de idades dos casos registados.
        /// </summary>
        /// <param name="casos"></param>
        /// <returns></returns>
        public static int MediaIdades()
        {
            int soma = 0;
            int media;

            for (int i = 0; i < allCases.Count; i++)
            {
                soma += allCases[i].Idades;
            }
            media = soma / allCases.Count;
            return media;
        }

        /// <summary>
        /// Insere uma pessoa(caso), caso os parametros sejam verdade.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InsertCase(Caso c)
        {
            if (allCases.Contains(c))
            {
                return false;
            }
            allCases.Add(c);
            return true;
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
                    bin.Serialize(stream, allCases);
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
        public static bool LoadCasos(string fileName)
        {

            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    allCases = (List<Caso>)bin.Deserialize(stream);
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
        public static string FormataDados()
        {
            string lista = "";


            foreach (Caso x in allCases)
            {
                lista += String.Format("\n" + "Nome: " + x.Nome + " Região: " + x.Regiao + " Idade: " + x.Idades + " Genero: " + x.Genero + " Sintomas : " + x.DDoenteRisco + "\n");
            }

            return lista;

        }

        #endregion

    }
}
