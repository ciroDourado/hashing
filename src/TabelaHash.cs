using System.Linq;
using System;

namespace hashing.src {

    class TabelaHash {
        private No[] tabela;
        private int  capacidade = 16;
        private int  tamanho;

        public TabelaHash() {
            tabela = new No[capacidade];
        } // construtor padrão


        public TabelaHash(int capacidade) {
            tabela = new No[capacidade];
            tamanho = 0;
            this.capacidade = capacidade;
        } // construtor parametrizado


        // Metodo do quadrado medio
        public int Hash(object chave) {
            var chars     = chave.ToString().ToCharArray();
            var numeros   = Array.ConvertAll(chars, c => (int)c);
            int somatorio = numeros.Sum();

            double media = somatorio * (Math.Sqrt(5.0) - 1) / 2;
            double valorNumerico = media - Math.Floor(media);

            return (int)Math.Floor(valorNumerico * capacidade);
        } // metodo Hash


        public int Tamanho() {
            return tamanho;
        } // get Tamanho


        public bool EstaVazia() {
            return tamanho == 0;
        } // metodo EstaVazia


        public bool NoEstaVazio(object chave) {
            int indice = Hash(chave);
            return tabela[indice] == null;
        } // metodo NoEstaVazio


        public void Inserir(object chave, object valor) {
            if (_HaEspaco()) _Inserir(chave, valor);
        } // metodo Inserir


        private
        bool _HaEspaco() {
            return tamanho < capacidade;
        } // metodo privado _HaEspaco


        private
        void _Inserir(object chave, object valor) {
            if (NoEstaVazio(chave)) {
                this._InserirNaTabela(chave, valor);
                this.tamanho += 1;
            } else _InserirNaLista(chave, valor);
        } // método privado _Inserir


        private
        void _InserirNaTabela(object chave, object valor) {
            int indice = Hash(chave);
            var novoNo = new No(chave, valor, indice);

            tabela[indice] = novoNo;
        } // metodo privado _InserirNaTabela


        private
        void _InserirNaLista(object chave, object valor) {
            int indice = Hash(chave);
            var novoNo = new No(chave, valor, indice);

            foreach (var no in tabela[indice]) {
                if (no.Existe(chave))  {
                    no.Atualizar(valor);
                    return;
            }} // foreach
    		novoNo.proximo = tabela[indice];
			tabela[indice] = novoNo;
        } // metodo privado _InserirNaLista


        public object Valor(object chave) {
            var indice = Hash(chave);

            foreach (var no in tabela[indice])
                if (no.Existe(chave)) return no.valor;
            return "null"; /*    se nao achou nada: */
        } // get Valor

    } // class TabelaHash
} // namespace hashing.src
