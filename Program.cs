/* //1

//var list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//var result = list.Where(x => x % 2 == 0);
//foreach (int num in result)
//{
//    Console.Write(num+" ");
//}
//Console.Write("\n\n");


//2
var list = new List<int> { 1, 1, 11, 312, 2, 2 };
var result = list.Where(x => x >= 1).Where(x=> x <= 11);
//foreach (int num in result)
//{
//    Console.Write(num+" ");
//}

//3
//result = list.Select(x=>(int)(Math.Pow(x,2)));
result = list.Select(x => x * x);
//foreach (int num in result)
//{
//    Console.Write(num+" ");
//}
//4
var result_2 = list.GroupBy(x => x)
                 .Select(y => new { Number = y.Key,
                                    Frequency = y.Count() 
                                  }); 
//foreach (var num in result_2)
//{
//    Console.Write(num);
*/
//5
using LINQ_006.Models;
using System.ComponentModel.DataAnnotations;

//dynamic result;
//var str = "aapppllee";
//result = str.GroupBy(x=>x)
//                    .Select(x => new 
//                    {
//                        Name = x.Key,
//                        Count = x.Count(),
//                    }) ;
//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Name} => {item.Count}");
////}
// var list_str = new List<string>()
// {
//     "Понедельник","Вторник","Среда","Четверг",
//     "Пятница","Суббота","Воскресение"
// };
////6
//result = list_str.Select(x=>x);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//7
//var list_int = new List<int>()
//{
//    5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
//};

//result = list_int.GroupBy(x => x)
//                 .Select(x => new { Name = x.Key, Count = x.Count(), Sum = x.Sum() });

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Name} => {item.Count} times  Sum:{item.Sum}");
//}

//8

//var list_string = new List<string>()
//{
//    "ROME","LONDON","NAIROBI","CALIFORNIA",
//    "ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
//};
//var start = Console.ReadLine().ToLower();
//var end = Console.ReadLine().ToLower();

//result = list_string.Where(x=>x.ToLower().StartsWith(start)).Where(x => x.ToLower().EndsWith(end));

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//9

//var res = list_int.FindAll(x => x > 80 ? true : false).ToList();

////10

//int i = 0;
//int memlist, n, m;
//List<int> templist = new List<int>();
//n = Convert.ToInt32(Console.ReadLine());

//for (i = 0; i < n; i++)
//{
//    Console.Write("Member {0} : ", i);
//    memlist = Convert.ToInt32(Console.ReadLine());
//    templist.Add(memlist);
//}
//m = Convert.ToInt32(Console.ReadLine());

//List<int> FilterList = templist.FindAll(x => x > m ? true : false);
//foreach (var num in FilterList)
//{
//    Console.WriteLine(num);
//}

//11

//var result_2 = list_int.OrderByDescending(x=>x);
//int n_2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//foreach (var num in result_2.Take(n_2))
//{
//    Console.WriteLine($"{num}");
//}

//12

//string strNew;

//strNew = Console.ReadLine();

//var res_2 = strNew.Split(' ')
//                .Where(x => String.Equals(x, x.ToUpper(),
//                StringComparison.Ordinal)).ToList();

//foreach (string strRet in res_2)
//{
//    Console.WriteLine(strRet);
//}
//Console.ReadLine();

//13

//string[] strings = new string[5] {"ASD","BSa","dsaf","asgsa","dsawe"};
//List<string> strings_str = new List<string>() { "ASD", "BSa", "dsaf", "asgsa", "dsawe" };

//string arr_res = string.Join(" ",strings);
//string list_res = string.Join(" ", strings_str);

//Console.WriteLine(arr_res+ "\n");
//Console.WriteLine(list_res);


//14

//var students = Student.GetStudents();
//result = students.Where(x => x.Points == students.Max(x => x.Points)).OrderBy(x=>x.Id);

//foreach (var student in result)
//{
//    Console.WriteLine(student.Id + " " + student.Name + " " + student.Points);
//}

//15

//string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

//var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
//         .GroupBy(z => z, (fExt, extCtr) => new
//         {
//             Extension = fExt,
//             Count = extCtr.Count()
//         });

//foreach (var m in fGrp)
//    Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
//Console.ReadLine();



//16

//string[] dirfiles = Directory.GetFiles("D:\\Study");

//var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
//avgFsize = Math.Round(avgFsize / 10, 1);
//Console.WriteLine("The Average file size is {0} MB", avgFsize);
//Console.ReadLine();


//17~20

var str_list = new List<string>()
 {
     "a","b","c","asd",
     "fds","asd","fds"
 };
//string str = Console.ReadLine();
//Console.WriteLine();


////17
//var find = str_list.FirstOrDefault(x => x == str);
//if (find != null)
//{
//    str_list.Remove(find);
//}

//18
//str_list.Remove(str_list.FirstOrDefault(x => x == str_2));



//19
//str_list.RemoveAll(x => x == str);

//20
str_list.RemoveAt(4);
foreach (var item in str_list)
{
    Console.WriteLine(item);
}
