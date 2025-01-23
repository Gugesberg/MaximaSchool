using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using MyCustomList2;
using System.Reflection;


/*MyList list = new MyList(10,5);
list.Resize();
Console.WriteLine(list[0]);
Console.WriteLine(list.Capacity);*/


/*int[] little = new int[5];
int[] big = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

MyList.Copy(big, little);*/


MyList list = new MyList();
list.Add(1); // индекс 0
list.Add(5); // индекс 1
list.Add(6); // индекс 2

int[] arr = new int[] { 2, 3, 4 };

list.Add(3,arr);


Console.WriteLine(list[0]);
Console.WriteLine(list[1]);
Console.WriteLine(list[2]);
Console.WriteLine(list[3]);
Console.WriteLine(list[4]);
Console.WriteLine(list[5]);