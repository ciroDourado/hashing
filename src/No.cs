using System.Collections;
using System;

namespace hashing.src {

    public class No: IEnumerable {
        public object chave;
        public object valor;
        public int    indice;
        public No     proximo;

        public No(object chave, object valor, int indice) {
            this.chave   = chave;
            this.valor   = valor;
            this.indice  = indice;
            this.proximo = null;
        } // construtor parametrizado

        public object Chave() {
            return this.chave;
        } // get Chave

        public bool Existe(object chave) {
            return this.chave.Equals(chave);
        } // NoExiste

        public void Atualizar(object valor) {
            this.valor = valor;
        } // Atualizar

        public int Tamanho() {
            int tamanho = 1;
            var atual = this;

            while (atual.proximo != null) {
                tamanho++;
                atual = atual.proximo;
            }
            return tamanho;
        } // Tamanho

        IEnumerator IEnumerable.GetEnumerator() {
            return (IEnumerator) GetEnumerator();
        } // definindo extensao para GetEnumerator

        public NoEnum GetEnumerator() {
            return new NoEnum(this);
        } // GetEnumerator

    } // class No
} // namespace hashing.src
