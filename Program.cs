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
//str_list.RemoveAt(4);


//21
//str_list.RemoveRange(1,str_list.Count);
//foreach (var item in str_list)
//{
//    Console.WriteLine(item);
//}

//22
//string[] arr1;
//int n, i, ctr;

//n = Convert.ToInt32(Console.ReadLine());
//arr1 = new string[n];
//for (i = 0; i < n; i++)
//{
//    Console.Write("Element[{0}] : ", i);
//    arr1[i] = Console.ReadLine();
//}

//ctr = Convert.ToInt32(Console.ReadLine());

//IEnumerable<string> objNew = from m in arr1
//                             where m.Length >= ctr
//                             orderby m
//                             select m;

//foreach (string z in objNew)
//    Console.WriteLine("Item: {0}", z);

//23
//char[] chars = { 'A', 'B', 'C' };
//int[] nums = { 1, 2, 3 };

//var result = from bel in chars
//             from son in nums
//             select new { bel, son };



//var result_2 = chars.SelectMany(num => nums, (chars, nums) => new { bel = chars, son = nums })
//                      .GroupBy(x => x.bel);


//Console.Write("The cartesian product are : \n");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("\n\n");
//foreach (var item in result_2)
//{
//    Console.Write(item.Key+" => ");
//    foreach (var item2 in item)
//    {
//        Console.Write($"\"{item2.son}\"  ");
//    }

//    Console.WriteLine();
//}


//24

//char[] charset1 = { 'X', 'Y', 'Z' };
//int[] numset1 = { 1, 2, 3 };
//string[] colorset1 = { "Green", "Orange" };


//var cartesianProduct = from letter in charset1
//                       from number in numset1
//                       from colour in colorset1
//                       select new { letter, number, colour };


//var cartesianProduct_2 = charset1
//    .SelectMany(letter => numset1, (letter, number) => new { letter, number })
//    .SelectMany(temp => colorset1, (temp, colour) => new { temp.letter, temp.number, colour });


//foreach (var ProductList in cartesianProduct)
//{
//    Console.WriteLine(ProductList);
//}


//25

List<Item_mast> itemlist = new List<Item_mast>
           {
           new Item_mast { id = 1, name = "Biscuit" },
           new Item_mast { id = 2, name = "Chocolate" },
           new Item_mast { id = 3, name = "Butter" },
           new Item_mast { id = 4, name = "Brade" },
           new Item_mast { id = 5, name = "Honey" }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
           };


//var result = itemlist.Join(purchlist,
//                        item => item.id,
//                        purch => purch.ItemId,
//                        (item, purch) => new
//                        {
//                            Item_Id = item.id,
//                            Item_Name = item.name,
//                            PurChase_Quantity =purch.PurQty
//                        });
//Console.WriteLine("Item ID         Item Name       Purchase Quantity\n-------------------------------------------------------");
//foreach (var item in result)
//{
//    string x = (item.Item_Name.Length > 8) ? "\t" : "\t\t";
//    Console.WriteLine($"{item.Item_Id}\t\t{item.Item_Name}{x}{item.PurChase_Quantity}");
//}




//26
//var leftOuterJoin = itemlist
//    .GroupJoin(purchlist, itm => itm.id, prch => prch.ItemId, (itm, a) => new { itm, a })
//    .SelectMany(x => x.a.DefaultIfEmpty(new Purchase()), (x, b) => new
//    {
//        itid = x.itm.id,
//        itdes = x.itm.name,
//        prqty = b.PurQty
//    });


//var leftOuterJoin_2 = from itm in itemlist
//                    join prch in purchlist
//                    on itm.id equals prch.ItemId
//                    into a
//                    from b in a.DefaultIfEmpty(new Purchase())
//                    select new
//                    {
//                        itid = itm.id,
//                        itdes = itm.name,
//                        prqty = b.PurQty
//                    };


//foreach (var data in leftOuterJoin)
//{
//    string x = (data.itdes.Length > 8) ? "\t" : "\t\t";
//    Console.WriteLine(data.itid + "\t\t" + data.itdes + x + data.prqty);
//}

//Console.WriteLine();

//foreach (var data in leftOuterJoin_2)
//{
//    string x = (data.itdes.Length > 8) ? "\t" : "\t\t";
//    Console.WriteLine(data.itid + "\t\t" + data.itdes + x + data.prqty);
//}



//27

//var rightOuterJoin = from p in purchlist
//                     join i in itemlist
//                     on p.ItemId equals i.id
//                     into a
//                     from b in a.DefaultIfEmpty()
//                     orderby b.id
//                     select new
//                     {
//                         itid = b.id,
//                         itdes = b.name,
//                         prqty = p.PurQty
//                     };

//var rightOuterJoin_1 = purchlist
//    .GroupJoin(itemlist, p => p.ItemId, i => i.id, (p, a) => new { p, a })
//    .SelectMany(x => x.a.DefaultIfEmpty(), (x, b) => new
//    {
//        itid = b?.id,
//        itdes = b?.name,
//        prqty = x.p.PurQty
//    }).OrderBy(x=>x.itid);

//foreach (var data in rightOuterJoin)
//{
//    string x = (data.itdes.Length > 8) ? "\t" : "\t\t";

//    Console.WriteLine(data.itid + "\t" + data.itdes + x + data.prqty);
//}

//28


//var list = new List<string>()
//{
//    "ROME","CALIFORNIA","PARIS","LONDON","ZURICH",
//    "NAIROBI","ABU DHABI","NEW DELHI","AMSTERDAM",
//};

//var result = list.OrderBy(x=>x.Length).ThenBy(x => x);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//29

//string[] cities =
//            {
//                "ROME","LONDON","NAIROBI","CALIFORNIA",
//                "ZURICH","NEW DELHI","AMSTERDAM",
//                "ABU DHABI", "PARIS","NEW YORK"
//            };


//var citySplit = from i in Enumerable.Range(0, cities.Length)
//                group cities[i] by i / 3;


//var citySplit_1 = Enumerable.Range(0, cities.Length)
//    .GroupBy(x=>x / 3, x => cities[x]);


//foreach (var city in citySplit)
//    cityView(string.Join(";  ", city.ToList()));

//Console.WriteLine();

//foreach (var city in citySplit_1)
//    cityView(string.Join(";  ", city.ToList()));

   
//static void cityView(string cityMetro)
//{
//    Console.WriteLine(cityMetro);
//}


//30
//var res = itemlist.Select(x=>x.name)
//                    .Distinct()
//                    .OrderBy(x => x);

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

