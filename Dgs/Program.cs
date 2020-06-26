/*
 * --------------------------------------------------------------------------------
 * <copyright file = "Person"   Developer: Diogo Rocha @IPCA</copyright>
 * <author>Diogo Miguel Correia Rocha</author>
 * <email>a18855@alunos.ipca.pt</email>
 * <date>26/06/2020</date>
 * <description>Este programa permite gerir pessoas infecionadas no caso de uma possivel pandemia.Ou seja fazer uma possivel análise estatistica ao numero de infecionados</description>
 * --------------------------------------------------------------------------------
 */
using Classes;
using Dados;
using Regras;
using System;
using System.Collections.Generic;
/// <summary>
/// Mainspace do programa. Neste espaço, a classe principal(Program), é que irá chamar e executar todos os métodos.
/// </summary>
namespace Classes
{
    class Program

    {
        /// <summary>
        ///Main. Vai executar sempre.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Casos

            Caso c1 = new Caso("João", "Norte", 25, "Masculino", "Sim");
            bool aux = Validar.InsertNewCase(c1, 1);
            if (aux)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            Caso c2 = new Caso("Maria", "Sul", 25, "Masculino", "Sim");
            bool auxc2 = Validar.InsertNewCase(c2, 2);
            if (auxc2)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            Caso c3 = new Caso("Mario", "Norte", 25, "Masculino", "Sim");
            bool auxc3 = Validar.InsertNewCase(c3, 3);
            if (auxc3)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            Caso c4 = new Caso("Margarida", "Centro", 80, "Feminino", "Não");
            bool auxc4 = Validar.InsertNewCase(c4, 4);
            if (auxc4)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            #region Pessoas (nao esta em uso)
            //Validar.InserePessoa(casos, new Caso("João", "Norte", 25, "Masculino", "Sim"));
            //Validar.InserePessoa(casos, new Caso("Ana", "Sul", 25, "Feminino", "Nâo"));
            //Validar.InserePessoa(casos, new Caso("Joana", "Sul", 25, "Feminino", "Sim"));
            //Validar.InserePessoa(casos, new Caso("Mario", "Centro", 32, "Masculino", "Sim"));
            //Validar.InserePessoa(casos, new Caso("Diogo", "Centro", 8, "Masculino", "Não"));
            //Validar.InserePessoa(casos, new Caso("Paula", "Sul", 16, "Feminino", "Sim"));
            //Validar.InserePessoa(casos, new Caso("Cristina", "Sul", 40, "Feminino", "Sim"));
            //Validar.InserePessoa(casos, new Caso("Isabela", "Norte", 55, "Feminino", "Sim"));
            //Validar.InserePessoa(casos, new Caso("Sara", "Norte", 65, "Feminino", "Não"));
            //Validar.InserePessoa(casos, new Caso("Margarida", "Centro", 80, "Feminino", "Não"));
            #endregion

            #region Lista de Casos
            List<Caso> auxc = CasosDL.GetAllCases();
            foreach (Caso x in auxc)
            {
                Console.WriteLine("\nNome: " + x.Nome + " Região: " + x.Regiao + " Idade: " + x.Idades + " Genero: " + x.Genero);
            }
            #endregion

            #region Consulta Região
            int contaRegiao = 0;
            while (contaRegiao == 0)
            {
                try
                {
                    Console.WriteLine("\nInsira a região a consultar: ");
                    string pRegiao = Console.ReadLine();
                    contaRegiao = CasosDL.ConsultaRegiao(pRegiao);

                    if (contaRegiao > 0)
                    {
                        Console.WriteLine("Nº de casos na região " + pRegiao + " : " + contaRegiao);
                    }
                    else
                    {
                        Console.WriteLine("Não existe registo para essa região");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erro formato:" + e.Message);
                }
            }
            #endregion

            #region Consulta Idades (nao em uso)
            //int nIdades = 0;
            //while (nIdades == 0)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira a idade a consultar: ");
            //        int pIdade = Convert.ToInt32(Console.ReadLine());
            //        nIdades = c.ConsultaIdade(casos, pIdade);

            //        if (nIdades > 0)
            //        {
            //            Console.WriteLine("Nº de casos com a idade de " + pIdade + " : " + nIdades);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Não existe registos para essa idade!");

            //        }
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Erro formato:" + e.Message);
            //    }

            //}
            #endregion

            #region Consulta Genero (nao em uso)
            //int nGenero = 0;
            //while (nGenero == 0)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira o genero a consultar: ");
            //        string pGenero = Console.ReadLine();
            //        nGenero = c.ConsultaGenero(casos, pGenero);

            //        if (nGenero > 0)
            //        {
            //            Console.WriteLine("Nº de casos com o género  " + pGenero + "é de : " + nGenero);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Não existe registos para esse género!");
            //        }
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Erro formato:" + e.Message);
            //    }
            //}
            #endregion

            #region Doentes de Risco
            string risco = "Sim";
            int nRisco = CasosDL.ContaRisco(risco);

            Console.WriteLine("Nº de casos de risco é de: " + nRisco);

            #endregion

            #region Doentes sem risco
            string semRisco = "Não";
            int nsemRisco = CasosDL.ContaRisco(semRisco);

            Console.WriteLine("Nº de casos sem risco é de: " + nsemRisco);

            #endregion

            #region Maior Idade
            int mIdade = CasosDL.MaiorIdade();
            Console.WriteLine("O(s) infetado(s) com maior idade é: " + mIdade);
            #endregion

            #region Média de Idades
            int averageAge = CasosDL.MediaIdades();
            Console.WriteLine("A idade média de casos é de : " + averageAge);
            #endregion

            #region Percentagem Genero Masculino (nao em uso)
            //float percentGeneroM = c.PercentagemGeneroM(casos);
            //Console.WriteLine("Percentagem de obitos por genero : ");
            //Console.WriteLine("Masculino :" + +percentGeneroM + "%");
            #endregion

            #region Percentagem Genero Feminino (nao em uso)
            //float percentGeneroF = c.PercentagemGeneroF(casos);
            //Console.WriteLine("Percentagem de obitos por genero : ");
            //Console.WriteLine("Masculino :" + +percentGeneroF + "%");
            #endregion

            #region Ficheiro
            Console.WriteLine("Salva Ficheiro!");
            CasosDL.SaveCaso(@"C:\Users\diogo\Desktop\DGS\Dgs\bin\caso.bin");

            Console.WriteLine("Carrega ficheiro de casos!");
            CasosDL.LoadCasos(@"C:\Users\diogo\Desktop\DGS\Dgs\bin\caso.bin");
            Console.WriteLine(CasosDL.FormataDados());
            #endregion

    #endregion

            #region Recuperados

            Recuperados r1 = new Recuperados("João", "Norte", 25, "Masculino", "Sim");
            bool auxr1 = Validar.InsertNewRecover(r1, 1);
            if (auxr1)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            Recuperados r2 = new Recuperados("Joana", "Sul", 28, "Feminino", "Sim");
            bool auxr2 = Validar.InsertNewRecover(r2, 1);
            if (auxr1)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            Recuperados r3 = new Recuperados("Paula", "Sul", 16, "Feminino", "Nao");
            bool auxr3 = Validar.InsertNewRecover(r3, 1);
            if (auxr3)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            Recuperados r4 = new Recuperados("Isabela", "Norte", 55, "Feminino", "Sim");
            bool auxr4 = Validar.InsertNewRecover(r4, 1);
            if (auxr4)
            {
                Console.WriteLine("Inserido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi inserido!");
            }

            #region Recuperados(não esta em uso)
            //Validar.InserePessoa(recuperados, new Recuperados("João", "Norte", 25, "Masculino", "Sim"));
            //Validar.InserePessoa(recuperados, new Recuperados("Ana", "Sul", 25, "Feminino", "Nâo"));
            //Validar.InserePessoa(recuperados, new Recuperados("Joana", "Sul", 25, "Feminino", "Sim"));
            //Validar.InserePessoa(recuperados, new Recuperados("Mario", "Centro", 32, "Masculino", "Sim"));
            //Validar.InserePessoa(recuperados, new Recuperados("Diogo", "Centro", 8, "Masculino", "Não"));
            //Validar.InserePessoa(recuperados, new Recuperados("Paula", "Sul", 16, "Feminino", "Sim"));
            //Validar.InserePessoa(recuperados, new Recuperados("Cristina", "Sul", 40, "Feminino", "Sim"));
            //Validar.InserePessoa(recuperados, new Recuperados("Isabela", "Norte", 55, "Feminino", "Sim"));
            //Validar.InserePessoa(recuperados, new Recuperados("Sara", "Norte", 65, "Feminino", "Não"));
            //Validar.InserePessoa(recuperados, new Recuperados("Margarida", "Centro", 80, "Feminino", "Não"));
            #endregion

            #region Lista de Recuperados
            List<Recuperados> auxr = RecuperadosDL.GetAllRecovers();
            foreach (Recuperados x in auxr)
            {
                Console.WriteLine("\n" + "Nome: " + x.Nome + " Região: " + x.Regiao + " Idade: " + x.Idades + " Genero: " + x.Genero + " Recuperado: " + x.Recuperado);
            }
            #endregion

            #region Doentes de recuperados
            string bom = "Sim";
            int nBom = RecuperadosDL.ContaRecuperados(bom);

            Console.WriteLine("\n"+ "Nº de doentes de recuperados é de: " + nBom);

            #endregion

            #region Doentes não recuperados
            string mau = "Nao";
            int nMau = RecuperadosDL.ContaNaoRecuperados(mau);

            Console.WriteLine("\n" + "Nº de casos sem risco é de: " + nMau);

            #endregion

            #region Ficheiro
            Console.WriteLine("\n" + "Salva Ficheiro!");
            RecuperadosDL.SaveCaso(@"C:\Users\diogo\Desktop\DGS\Dgs\bin\recuperado.bin");

            Console.WriteLine("\n" + "Carrega ficheiro de recuperados!");
            RecuperadosDL.LoadRecuperados(@"C:\Users\diogo\Desktop\DGS\Dgs\bin\recuperado.bin");
            Console.WriteLine(RecuperadosDL.FormataDadosR());
            #endregion
            #endregion

            Console.ReadKey();

        }
    }
}