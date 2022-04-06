using System;
/*
    Tablica może być np. tablicą obiektów typu int bądź referencji do typu Object.
    Tablica ma posiadać indeksator do zapisu/odczytu oraz metodę Add do dopisywania elementów na końcu
    W przypadku dopisywania i konieczności rozszerzenia tablicy należy zarezerwować pamięć na 2*n elementów, gdzie n to aktualny rozmiar. Rezerwacja nie oznacza tu wpisania do tablicy elementów (czyli zmiany wielkości tablicy) - ważne przy próbie odczytu poza aktualną wielkością tablicy
    W przypadku odczytu indeksatorem poza aktualną wielkością tablicy rzucamy wyjątek
    W przypadku zapisu elementu poza aktualną wielkością tablica jest rozszerzana do żądanego indeksu. W tym wypadku wszystkie elementy między poprzednim ostatnim a nowym dodanym traktujemy jako istniejące, z wartością domyślną
*/

namespace MyVector
{
    class MyVector<Type>
    {
        private Type[] m_myVector;
        //m_myVector.Length() ilosc zaalokowanej pamieci
        public Type this[int index]
        {
            get
            {
                if (index >= m_myVector.Length || index <= -1 )
                {
                    throw new IndexOutOfRangeException("Wartosc o podanym indeksie jest nieosiagalna");
                }
               return m_myVector[index];
            }
            set 
            { 
                if(index <= -1)
                {
                    throw new IndexOutOfRangeException("Wartosc o podanym indeksie jest nieosiagalny");
                }
                if(index >= m_myVector.Length)
                {
                    if (index == 0)
                    {
                        allocate(1 * 2);
                    }
                    allocate(index * 2);
                }

                m_myVector[index] = value;
            }
        }

        public MyVector(int cappacityOfNewVector)
        {
            m_myVector = new Type[cappacityOfNewVector];
        }

        public void pushBack(Type value)
        {
            this[m_myVector.Length] = value;
        }

        private void allocate(int newCappacity)
        {
            Array.Resize(ref m_myVector, newCappacity);
        }
    }
}
