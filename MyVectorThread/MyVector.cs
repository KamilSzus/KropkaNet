using System;

namespace MyVector
{
    class MyVector<Type>
    {
        public delegate void EventHandler(int size);
        public EventHandler eventHandler;
        public EventHandler eventHandler1;

        private object locking = new object();

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
                    if (eventHandler != null)
                    {
                        eventHandler1(m_myVector.Length);
                    }
                }
                m_myVector[index] = value;
                if (index >= Size)
                {
                    Size = index + 1;
                    if (eventHandler != null)
                    {
                        eventHandler(Size);
                    }
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

        public void pushBackBlocking(Type value)
        {
            lock (locking)
            {
                this[Size] = value;
            }
        }

        public void saveToFile(string fileName)
        {
            using (StreamWriter fs = File.CreateText(fileName))
            {
                for (int i = 0; i < Size; i++)
                    fs.WriteLine(this[i].ToString());
            }
        }

        public Boolean pushBackNonBlocking(Type value)
        {
            if (Monitor.TryEnter(locking, 0))
            {
                try
                {
                    this[Size] = value;
                }
                finally
                {
                    Monitor.Exit(locking);
                }
            }
            else
            {
                return false;
            }
            return true;
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
