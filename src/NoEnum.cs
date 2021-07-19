using System.Collections;
using System;

namespace hashing.src {

    // isso aqui é pra gente poder usar uma lista
    // de No's dentro de iteradores, tipo foreach

    // nao tente entender, por hora.
    // caso queira saber sobre, pesquise por
    // Iterators e Iterables (geral) ou
    // Enumerator e Enumerable (C#)
    public class NoEnum: IEnumerator {
        public No _primeiro;

        int posicao = -1;
        int limite  = -1;
        No  atual   = null;

        public NoEnum(No _primeiro) {
            this._primeiro = _primeiro;

            if (_primeiro != null)
                limite = _primeiro.Tamanho();
        } // NoEnum


        public bool MoveNext() {
            if (_primeiro == null) return false;
            else return _MoveNext();
        } // MoveNext


        private bool _MoveNext() {
            this._AvancarParaProximo();
            posicao += 1;
            return (posicao < limite);
        } // _MoveNext


        private void _AvancarParaProximo() {
            if (posicao == -1) {
                atual = _primeiro;
            } else atual = atual.proximo;
        } // _AvancarParaProximo


        public void Reset() {
            posicao = -1;
            atual   = null;
        } // Reset


        object IEnumerator.Current {
            get { return Current; }
        } // IEnumerator.Current


        public No Current {
            get { return atual; }
        } // Current

    } // class NoEnum
} // namespace hashing.src
