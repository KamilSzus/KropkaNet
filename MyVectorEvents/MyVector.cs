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
        public delegate void EventHandler(int size);
        public EventHandler eventHandler;
        public EventHandler eventHandler1;

        private Type[] m_myVector;
        public int Size//index ostatniego elementu
        {
            get;
            private set;
        }
        //m_myVector.Length() ilosc zaalokowanej pamieci
        public Type this[int index]
        {
            get
            {
                if (index >= Size || index <= -1)
                {
                    throw new IndexOutOfRangeException("Wartosc o podanym indeksie jest nieosiagalna");
                }
                return m_myVector[index];
            }
            set
            {
                if (index <= -1)
                {
                    throw new IndexOutOfRangeException("Wartosc o podanym indeksie jest nieosiagalna");
                }
                if (index >= m_myVector.Length)
                {
                    allocate((index + 1) * 2);
                    eventHandler1(m_myVector.Length);
                }
                m_myVector[index] = value;
                if (index >= Size)
                {
                    Size = index + 1;
                    eventHandler(Size);
                }
            }
        }

        public MyVector(int cappacityOfNewVector)
        {
            m_myVector = new Type[cappacityOfNewVector];
            Size = 0;
        }

        public void pushBack(Type value)
        {
            this[Size] = value;
        }

        private void allocate(int newCappacity)
        {
            Array.Resize(ref m_myVector, newCappacity);
        }

        public void dump()
        {
            Console.WriteLine("Allocated memory: " + m_myVector.Length);
            Console.WriteLine("Last index: " + Size);
            for (int i = 0; i < Size; i++)
            {
                Console.Write(m_myVector[i] + " ");
            }
            Console.WriteLine();
        }

        protected virtual void OnEventHandler(int size)
        {
            eventHandler?.Invoke(size);
        }

        protected virtual void OnEventHandler1(int size)
        {
            eventHandler1?.Invoke(size);
        }
    }
}
