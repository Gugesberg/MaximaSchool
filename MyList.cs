namespace MyCustomList2
{
    public class MyList
    {
        private int[] _array; //массив
        public int Capacity { get; set; } // вместимость массива
        public int Count { get; set; } // текущая наполненность массива

        public MyList() // добавляем пустой массив с объявленной длинной 10
        {
            _array = new int[10];
            Capacity = _array.Length;
            Count = 0;
        }

        public MyList(int length) // добавляем массив с кастомной длинной, длину передаем в length
        {
            _array = new int[length];
            Capacity = length; 
            Count = 0;
        }
        public MyList(int length, int element) // добавляем 1 элемент c индексом 0;
        {
            _array = new int[length];
            _array[0] = element;
            Capacity = length;
            Count = 1;
        }
        public void Add(int element)
        {
            if(Count >= Capacity)
            {
                Resize();       
            }
            _array[Count] = element;
            Count++;
        }

        public void Add(int[] elements) // ДОБАВЛЕНИЕ НЕСКОЛЬКИХ ЭЛЕМЕНТОВ В МАССИВ
        {
            if (elements.Length > Capacity - Count) // проверяем, поместится ли новый массив
            {
                Capacity = elements.Length + Count; // новая емкость = длинна добавляемого массива + текущая наполненность
                int[] newArr = new int[Capacity];// создаем массив c новой емкостью 
                MyList.Copy(_array, newArr); //копируем элементы старого массива в новый
                _array = newArr; // перезаписываем ссылку.

            }
            Array.Copy(elements,0, _array,Count, elements.Length); // копируем элементы из elements, начиная с индекса[0], в исходный массив, начиная с индекса[Count]
            Count += elements.Length; // наполненность массива увеличиваем на длину добавленного массива.
           
        }

        public void Add(int index, int element) // ДОБАВЛЕНИЕ ЭЛЕМЕНТА С ОПРЕДЕЛЕННЫМ ИНДЕКСОМ, СО СМЕЩЕНИЕМ ЭЛЕМЕНТОВ
        {
            if(Count == Capacity)
            {
                Resize(); 
            }
            for (int i = Count; i > index; i--) 
            {
                _array[i] = _array[i - 1];
            }
            _array[index] = element;
            Count++;

        }
        public void Add(int index, int[] elements)
        {
            if (Count == Capacity)
            {
                Array.Resize(ref _array, Capacity * 2);
                Capacity *= 2;
            }
            else if (index == Count) 
            {
                _array[index] = elements[0];
                for (int i = 1; i < elements.Length; i++)
                    _array[i + index] = elements[i];

                Count += elements.Length;
            }
            else 
            {
                for (int i = Count; i > index; i--)
                {
                    _array[i] = _array[i - 1];
                }
                _array[index] = elements[0];
                for (int i = 1; i < elements.Length; i++)
                    _array[i + index] = elements[i];

                Count += elements.Length;
                


            }
        }

        public int this[int index] // перегрузка индексаторов
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException("Нет элемента с указанным индексом в листе");
                }
                return _array[index];
            }
            set
            {
                if (index >= _array.Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Resize() // перезаписываем массив с новой длинной
        {
            int newLength = _array.Length * 2; // увеличиваем длинну массива X2
            var newArray = new int[newLength]; // Создаем массив с новой длинной
            Array.Copy(_array, newArray, Count); //Копируем содержимое старого массива в новый
            _array = newArray;// перезаписываем,подмена ссылки
            Capacity = newLength;
        }

        public static void Copy(int[] sourseArray, int[] destinationArray) // копирование элементов из одного массива в другой
        {
            if (sourseArray.Length > destinationArray.Length)
            {
                throw new Exception("Элементы не уместятся");
            }    

            for (int i = 0; i< sourseArray.Length; i++)
            {
                destinationArray[i] = sourseArray[i];
            }
        }
    }
}
