using System;
using System.Linq;

namespace LINQ_Methods
{
    class Purchase
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int PurchaseQuantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //var list = new List<int>() { 1,4,5,8,9,12,16,23,26,27};
            //var resList = list.Where(x=>x%2==0).ToList();
            //foreach(var item in resList)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 2
            //var list = new List<int>() {-6, 1, 4, 5, 8, 9, 12, 16, 23, -26, 27 };
            //var resList = list.Where(x => x > 0 && x < 11).ToList();
            //foreach (var item in resList)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 3
            //var list = new List<int>() { 3,7,5,9,11};
            //var squaredNumbers = list.Select(num => new
            //{
            //    Number = num,
            //    SqrNo = num * num
            //});

            //Console.WriteLine("Expected Output:");

            //foreach (var item in squaredNumbers)
            //{
            //    Console.WriteLine($"Number = {item.Number}, SqrNo = {item.SqrNo}");
            //}

            // Task 4
            //var list = new List<int>() { 1, 4, 4, 5, 8, 11, 13, 18, 22, 4,8,11,22,3,22,31,5,11 };
            //var groupBy = list.GroupBy(x=>x).ToList();
            //foreach (var item in groupBy)
            //{
            //    var key = item.Key;
            //    var count = item.Count();
            //    Console.WriteLine($"Numbers {key} appears {count} times");
            //}

            // Task 5
            //string str = Console.ReadLine();
            //var groupBy = str.GroupBy(x=>x);
            //foreach ( var group in groupBy )
            //{
            //    var key = group.Key;
            //    var count = group.Count();
            //    Console.WriteLine($"Character {key}: {count} times");
            //}

            // Task 6
            //var list = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //var dayOfWeek = list.Select(day => day);

            //Console.WriteLine("Days of Week:");
            //foreach (var day in dayOfWeek)
            //{
            //    Console.WriteLine(day);
            //}

            // Task 7
            //var list = new List<int>() { 1, 4, 4, 5, 8, 11, 13, 18, 22, 4, 8, 11, 22, 3, 22, 31, 5, 11 };
            //var groupBy = list.GroupBy(x => x).ToList();
            //Console.WriteLine("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency");
            //foreach (var item in groupBy)
            //{
            //    var key = item.Key;
            //    var count = item.Count();
            //    var numFreq = key * count;
            //    Console.WriteLine($"{key}\t {numFreq}\t\t\t {count}");
            //}

            // Task 8
            //var list = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //var resList = list.Where(x => x.StartsWith("A") && x.EndsWith("M")).ToList();
            //foreach ( var item in resList )
            //{
            //    Console.WriteLine(item);
            //}

            // Task 9
            //var list = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };
            //var resList = list.Where(x=>x>80).ToList();
            //foreach(var item in resList)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 10
            //var list = new List<int>();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Member {0} : ", i);
            //    int value = int.Parse(Console.ReadLine());
            //    list.Add(value);
            //}
            //Console.WriteLine("Enter condition input");
            //var input = int.Parse(Console.ReadLine());
            //var filteredList = list.Where(x => x > input);

            //Console.WriteLine("\nThe numbers greater than {0} are : ", input);
            //foreach (int item in filteredList)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 11
            //var list = new List<int>() { 5,12,4,23,15,19,54,11,3,27,24,31};
            //list.Sort();
            //list.Reverse();
            //var resList = list.Take(3);
            //foreach (var item in resList)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 12
            //string str = Console.ReadLine();
            //var strArr = str.Split(" ");
            //var upperCase = strArr.Where(x => x.All(char.IsUpper));
            //foreach ( var item in upperCase )
            //{
            //    Console.WriteLine(item);
            //}

            // Task 13
            //Console.Write("Input number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //string[] stringArray = new string[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Element[{i}]: ");
            //    stringArray[i] = Console.ReadLine();
            //}

            //string result = string.Join(", ", stringArray);

            //Console.WriteLine("New array:");
            //Console.WriteLine(result);

            // Task 14

            // Task 15

            // Task 16
            //string[] filePaths = { "file1.txt", "file2.txt", "file3.txt" };
            //var fileSizes = filePaths.Select(filePath => new FileInfo(filePath).Length);

            //double averageSize = fileSizes.Average() / (1024 * 1024);

            //Console.WriteLine($"The Average file size is {averageSize:F1} MB");

            // Task 17
            //var charList = new List<char> { 'm', 'n', 'o', 'p', 'q' };
            //foreach (char item in charList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            //char itemToRemove = 'o';
            //charList.Remove(itemToRemove);

            //Console.WriteLine($"After Remove: {itemToRemove}");
            //foreach (char item in charList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            // Task 18
            //var charList = new List<char> { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in charList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            //char itemToRemove = 'p';

            //var filteredList = charList.Where(item => item != itemToRemove).ToList();

            //Console.WriteLine($"After removing '{itemToRemove}' and new list:");
            //foreach (char item in filteredList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            // Task 19
            //var charList = new List<char> { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in charList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            //char itemToRemove = 'q';

            //var filteredList = charList.Where(item => item != itemToRemove).ToList();

            //Console.WriteLine($"After removing '{itemToRemove}' and new list:");
            //foreach (char item in filteredList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}


            // Task 20
            //var charList = new List<char> { 'm', 'n', 'o', 'p', 'q' };

            //Console.WriteLine("Here is the list of items:");
            //foreach (char item in charList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            //int indexToRemove = 3;

            //if (indexToRemove >= 0 && indexToRemove < charList.Count)
            //{
            //    charList.RemoveAt(indexToRemove);

            //    Console.WriteLine($"After removing item index {indexToRemove} from the list:");
            //    foreach (char item in charList)
            //    {
            //        Console.WriteLine($"Char: {item}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Item index {indexToRemove} is out of range.");
            //}

            // Task 21
            //var charList = new List<char> { 'm', 'n', 'o', 'p', 'q' };
            //foreach (char item in charList)
            //{
            //    Console.WriteLine($"Char: {item}");
            //}

            //int startIndexToRemove = 1;
            //int countToRemove = 3;

            //if (startIndexToRemove >= 0 && startIndexToRemove < charList.Count && countToRemove > 0)
            //{
            //    charList.RemoveRange(startIndexToRemove, countToRemove);

            //    Console.WriteLine($"After removing {countToRemove} items starting from the item index {startIndexToRemove} from the list:");
            //    foreach (char item in charList)
            //    {
            //        Console.WriteLine($"Char: {item}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid start index or count to remove.");
            //}

            // Task 22
            //Console.Write("Input number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //string[] stringArray = new string[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element[{i}]: ");
            //    stringArray[i] = Console.ReadLine();
            //}

            //Console.Write("Min length: ");
            //int minLength = Convert.ToInt32(Console.ReadLine());

            //var result = stringArray.Where(item => item.Length >= minLength);

            //Console.WriteLine("The items of minimum " + minLength);

            //foreach (string item in result)
            //{
            //    Console.WriteLine("Item: " + item);
            //}

            // Task 23
            //List<char> letterList = new List<char> { 'X' };
            //List<int> numberList = new List<int> { 1, 2, 3, 4 };

            //var cartesianProduct = letterList.SelectMany(
            //    letter => numberList,
            //    (letter, number) => new { letterList = letter, numberList = number }
            //);

            //foreach (var pair in cartesianProduct)
            //{
            //    Console.WriteLine($" letterList = {pair.letterList}, numberList = {pair.numberList}");
            //}

            // Task 24

            // Task 25
            //List<Purchase> purchaseList = new List<Purchase>
            //{
            //new Purchase { ItemID = 1, ItemName = "Biscuit", PurchaseQuantity = 458 },
            //new Purchase { ItemID = 2, ItemName = "Chocolate", PurchaseQuantity = 650 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 800 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 700 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 650 }
            //};

            //var result = from purchase in purchaseList
            //             select purchase;

            //Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            //Console.WriteLine("-----------------------------------------------");

            //foreach (var purchase in result)
            //{
            //    Console.WriteLine($"{purchase.ItemID}\t\t{purchase.ItemName}\t{purchase.PurchaseQuantity}");
            //}

            // Task 26
            //List<Purchase> purchaseList = new List<Purchase>
            //{
            //new Purchase { ItemID = 1, ItemName = "Biscuit", PurchaseQuantity = 458 },
            //new Purchase { ItemID = 2, ItemName = "Chocolate", PurchaseQuantity = 650 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 800 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 700 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 650 }
            //};

            //List<int> itemIDs = new List<int> { 1, 2, 3, 4, 5 };

            //var result = itemIDs
            //    .GroupJoin(
            //        purchaseList,
            //        itemId => itemId,
            //        purchase => purchase.ItemID,
            //        (itemId, purchases) => new
            //        {
            //            ItemID = itemId,
            //            Purchases = purchases.DefaultIfEmpty(new Purchase { ItemName = "Unknown", PurchaseQuantity = 0 })
            //        })
            //    .SelectMany(
            //        grouping => grouping.Purchases,
            //        (grouping, purchase) => new
            //        {
            //            ItemID = grouping.ItemID,
            //            ItemName = purchase.ItemName,
            //            PurchaseQuantity = purchase.PurchaseQuantity
            //        });

            //Console.WriteLine("Here is the list after joining :");
            //Console.WriteLine();
            //Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            //Console.WriteLine("-----------------------------------------------");

            //foreach (var purchase in result)
            //{
            //    Console.WriteLine($"{purchase.ItemID}\t\t{purchase.ItemName}\t{purchase.PurchaseQuantity}");
            //}

            // Task 27
            //List<Purchase> purchaseList = new List<Purchase>
            //{
            //new Purchase { ItemID = 1, ItemName = "Biscuit", PurchaseQuantity = 458 },
            //new Purchase { ItemID = 2, ItemName = "Chocolate", PurchaseQuantity = 650 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 800 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            //new Purchase { ItemID = 3, ItemName = "Butter", PurchaseQuantity = 900 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 700 },
            //new Purchase { ItemID = 4, ItemName = "Brade", PurchaseQuantity = 650 }
            //};

            //List<int> itemIDs = new List<int> { 3, 5, 4, 1 };

            //var result = purchaseList
            //    .GroupJoin(
            //        itemIDs,
            //        purchase => purchase.ItemID,
            //        itemId => itemId,
            //        (purchase, items) => new
            //        {
            //            Purchase = purchase,
            //            ItemIDs = items.DefaultIfEmpty()
            //        })
            //    .SelectMany(
            //        grouping => grouping.ItemIDs,
            //        (grouping, itemId) => new
            //        {
            //            ItemID = itemId,
            //            ItemName = grouping.Purchase?.ItemName ?? "Unknown",
            //            PurchaseQuantity = grouping.Purchase?.PurchaseQuantity ?? 0
            //        });

            //Console.WriteLine("Here is the list after joining :");
            //Console.WriteLine();
            //Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            //Console.WriteLine("-----------------------------------------------");

            //foreach (var purchase in result)
            //{
            //    Console.WriteLine($"{purchase.ItemID}\t\t{purchase.ItemName}\t{purchase.PurchaseQuantity}");
            //}

            // Task 28
        //    string[] cities = {
        //    "PARIS", "LONDON", "ZURICH", "NAIROBI",
        //    "ROME", "ABU DHABI", "AMSTERDAM", "NEW DELHI", "CALIFORNIA"
        //    };

        //    var arrangedList = cities
        //        .OrderBy(city => city.Length) 
        //        .ThenBy(city => city);         

        //Console.WriteLine("Here is the arranged list:");

        //    foreach (var city in arrangedList)
        //    {
        //        Console.WriteLine(city);
        //    }
        }
    }
}