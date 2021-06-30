using System;
using System.Collections;

namespace MusicalInstrumentStore2
{
    [Serializable]
    public class EstoqueItems
    {
        int contador;
        private object[] items;

        public virtual int Count
        {
            get { return contador; }
        }

        public virtual bool IsSynchronized
        {
            get { return false; }
        }

        public virtual object SyncRoot
        {
            get { return this; }
        }

        public virtual void CopyTo(Array arr, int index)
        {
        }

        public virtual IEnumerator GetEnumerator()
        {
            return null;
        }

        public virtual bool IsFixedSize
        {
            get { return false; }
        }

        public virtual bool IsReadOnly
        {
            get { return false; }
        }

        public virtual object this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        // adiciona um novo item na coleção
        public virtual int Add(object value)
        {
            // Verifica se o array é muito pequeno para os demais itens
            // se for aumenta o seu tamanho de 5
            if (Count == items.Length)
                Array.Resize(ref items, items.Length + 5);

            if (contador < items.Length)
            {
                items[contador] = value;
                contador++;
                return contador - 1;
            }
            else
                return -1;
        }

        // Insere um novo elemento em uma posição na coleção
        public virtual void Insert(int index, Object value)
        {
        }

        // Verifica se o item passado como argumento existe na coleção
        public virtual bool Contains(object value)
        {
            return false;
        }

        // verifia se o item passado como argumento existe na coleção e retorna o indice
        public virtual int IndexOf(object value)
        {
            return 0;
        }

        // deleta o item posicionado no indice passado como argumento
        public virtual void RemoveAt(int index)
        {
        }

        // primeiro verifica a existencia do item passado
        //  se existir o metodo deleta o item
        public virtual void Remove(object value)
        {
        }

        // deleta todos os items da coleção
        public virtual void Clear()
        {
        }

        public EstoqueItems()
        {
            contador = 0;
            items = new object[5];
        }
    }
}
