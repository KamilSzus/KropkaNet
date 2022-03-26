using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Tablica może być np. tablicą obiektów typu int bądź referencji do typu Object.
    Tablica ma posiadać indeksator do zapisu/odczytu oraz metodę Add do dopisywania elementów na końcu
    W przypadku dopisywania i konieczności rozszerzenia tablicy należy zarezerwować pamięć na 2*n elementów, gdzie n to aktualny rozmiar. Rezerwacja nie oznacza tu wpisania do tablicy elementów (czyli zmiany wielkości tablicy) - ważne przy próbie odczytu poza aktualną wielkością tablicy
    W przypadku odczytu indeksatorem poza aktualną wielkością tablicy rzucamy wyjątek
    W przypadku zapisu elementu poza aktualną wielkością tablica jest rozszerzana do żądanego indeksu. W tym wypadku wszystkie elementy między poprzednim ostatnim a nowym dodanym traktujemy jako istniejące, z wartością domyślną
*/

namespace MyVector
{
    class MyVector
    {
        public int m_cappacity
        {
            get;
            private set;
        }
        public int m_size //pokazuje pierwszy wolny element
        {
            get;
            private set;
        }
        public int[] m_myVector
        {
            get;
            private set;
        }

        public MyVector(int cappacityOfNewVector)
        {
            m_myVector = new int[cappacityOfNewVector];
            m_size = 0;
            m_cappacity = cappacityOfNewVector;
        }

        public void pushBack(int value)
        {
            if (m_size == m_cappacity)
            {
                allocate((2 * m_cappacity));
            }
            m_myVector[m_size] = value;
            m_size++;
        }

        private void allocate(int newCappacity)
        {
            int[] newMyVector = new int[newCappacity];
            Array.Copy(m_myVector, newMyVector, m_size);

            m_cappacity = newCappacity;
            m_myVector = newMyVector;
        }
    }
}
