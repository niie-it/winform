/*
 * Viết chương trình nhập một mảng số nguyên, Sau đó thực hiện các yêu cầu:
o Xuất ra tổng của mảng.
o Xuất ra số nguyên lớn nhất trong mảng.
o Xuất ra số nguyên nhỏ nhất trong mảng.
*/
Console.Write("Nhập số lượng phần tử: ");
int soLuong = int.Parse(Console.ReadLine());

// Khai báo mảng động
List<int> myList = new List<int>();

//duyệt qua từng phần và nhập
for (int i = 0; i < soLuong; i++)
{
    Console.Write($"Phần tử thứ {i}: ");
    var tmp = int.Parse(Console.ReadLine());

    myList.Add(tmp);//thêm phần tử vào mảng
}

//Xuất
Console.WriteLine("Mảng vừa nhập:");
Console.WriteLine(string.Join(", ", myList));

Console.WriteLine($"Tổng: {myList.Sum()}");
Console.WriteLine(myList.Max());
Console.WriteLine(myList.Min());