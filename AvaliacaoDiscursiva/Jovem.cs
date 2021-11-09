using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoDiscursiva
{
    class Jovem
    {
       static List<Jovem> jovens = new List<Jovem>();

        static int MaxId = 0;
        public enum Sexo { Masculino, Feminino };
        public enum SituacaoTrabalhista { Empregrado, Desempregado };

        protected int _Id;
        protected string _Nome;
        protected Sexo _Sexo;
        protected SituacaoTrabalhista _SituacaoTrabalhista;


        #region Construtores

        public Jovem()
        {

        }

        public Jovem(int id, string nome, Sexo sexo, SituacaoTrabalhista situacaoTrabalhista)
        {
            _Id = id;
            _Nome = nome;
            _Sexo = sexo;
            _SituacaoTrabalhista = situacaoTrabalhista;
        }

        public Jovem(string nome, Sexo sexo, SituacaoTrabalhista situacaoTrabalhista)
        {
            _Id = 0;
            _Nome = nome;
            _Sexo = sexo;
            _SituacaoTrabalhista = situacaoTrabalhista;
        }

        #endregion


        #region Gets e Sets

        public int IdJovem
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public string NomeJovem
        {
            set { _Nome = value; }
            get { return _Nome; }
        }

        public Sexo SexoJovem
        {
            set { _Sexo = value; }
            get { return _Sexo; }
        }

        public SituacaoTrabalhista SituacaoTrabalhistaJovem
        {
            set { _SituacaoTrabalhista = value; }
            get { return _SituacaoTrabalhista; }
        }
        #endregion

        public void Incluir()
        {
            MaxId++;
            _Id = MaxId;
            jovens.Add(this);
        }

        public static void Limpar()
        {
            jovens.Clear();
            MaxId = 0;
        }

        public static List<Jovem> Consultar()
        {
            return jovens;
        }

        
        #region lista automatica
        public static void Preencher()
        {
            Jovem jovemAutomatico;

            jovemAutomatico = new Jovem("Wagner Geroldi", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("João da Silva", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Juvêncio Lopes", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Tamires Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ivanir Barp", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Janete Carvalho", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Juvêncio Lopes", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Maria da Silva Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Jurema Castro Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Roberto Bonan", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Alisson Boggio", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Marina Silva Lopes", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Tamires Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Lucas Grolli", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Antonio Fedrigo", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Anne Laura dos Santos", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Jussara Silva", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Wagner Geroldi", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("João da Silva", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Juvêncio Lopes", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Camila Silvério", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Marcos Souza", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("João da Silva", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Evandro Cappelleto", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Tanise Alves Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Rogerio Chaves", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("João da Silva", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Juvêncio Lopes", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Tamires Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Wagner Geroldi", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("João da Silva", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Carlos dos Santos", Sexo.Masculino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Juvêncio Lopes", Sexo.Masculino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Tamires Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Ana Trindade", Sexo.Feminino, SituacaoTrabalhista.Desempregado);
            jovemAutomatico.Incluir();
            jovemAutomatico = new Jovem("Tamires Souza", Sexo.Feminino, SituacaoTrabalhista.Empregrado);
            jovemAutomatico.Incluir();


        }

        #endregion

        #region Metodos para calcular quantidades
        public static int ResultadoMasculinoEmpregado()
        {
            int resultadoMasculinoEmpregado = 0;
            foreach(Jovem j in jovens)
            {
                if(j.SexoJovem == Sexo.Masculino && j.SituacaoTrabalhistaJovem == SituacaoTrabalhista.Empregrado)
                {
                    resultadoMasculinoEmpregado++;
                }
            }
                return resultadoMasculinoEmpregado;
        }

        public static int ResultadoMasculinoDesempregado()
        {
            int resultadoMasculinoDesempregado = 0;
            foreach (Jovem j in jovens)
            {
                if (j.SexoJovem == Sexo.Masculino && j.SituacaoTrabalhistaJovem == SituacaoTrabalhista.Desempregado)
                {
                    resultadoMasculinoDesempregado++;
                }
            }
            return resultadoMasculinoDesempregado;
        }

        public static int ResultadoFemininoEmpregado()
        {
            int resultadoFemininoEmpregado = 0;
            foreach (Jovem j in jovens)
            {
                if (j.SexoJovem == Sexo.Feminino && j.SituacaoTrabalhistaJovem == SituacaoTrabalhista.Empregrado)
                {
                    resultadoFemininoEmpregado++;
                }
            }
            return resultadoFemininoEmpregado;
        }

        public static int ResultadoFemininoDesempregado()
        {
            int resultadoFemininoDesempregado = 0;
            foreach (Jovem j in jovens)
            {
                if (j.SexoJovem == Sexo.Feminino && j.SituacaoTrabalhistaJovem == SituacaoTrabalhista.Desempregado)
                {
                    resultadoFemininoDesempregado++;
                }
            }
            return resultadoFemininoDesempregado;
        }

        #endregion


        #region calcular porcentagens      

        public static int TotalDeEntrevistados()
        {
            int quantidadeDeJovens = jovens.Count;
            return quantidadeDeJovens;
        }

        public static float PorcentagemHomemEmpregado()
        {
            float quantidadeDeJovens = jovens.Count;
            float resultado = ResultadoMasculinoEmpregado() / quantidadeDeJovens * 100;
            return resultado;
        }

        public static float PorcentagemHomemDesempregado()
        {
            float quantidadeDeJovens = jovens.Count;
            float resultado = ResultadoMasculinoDesempregado() / quantidadeDeJovens * 100;
            return resultado;
        }

        public static float PorcentagemMulherEmpregado()
        {
            float quantidadeDeJovens = jovens.Count;
            float resultado = ResultadoFemininoEmpregado() / quantidadeDeJovens * 100;
            return resultado;
        }

        public static float PorcentagemMulherDesempregado()
        {
            float quantidadeDeJovens = jovens.Count;
            float resultado = ResultadoFemininoDesempregado() / quantidadeDeJovens * 100;
            return resultado;
        }



        #endregion
    }





}
