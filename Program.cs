using ConsoleApp15;

Console.WriteLine("System IO:");

//Directory.CreateDirectory(@".\Admin");
Product p1 = new(3, "Motorolla", 470);
if (!File.Exists(@".\Admin\admin.txt"))
{
    File.Create(@".\Admin\admin.txt");
}

StreamReader sr = new StreamReader(@".\Admin\admin.txt");
while (!sr.EndOfStream)
{
    Console.WriteLine(sr.ReadLine());
}
sr.Close();

StreamWriter sw = new StreamWriter(@".\Admin\admin.txt", true);
sw.WriteLine($"Id:{p1.Id}; Name : {p1.Name}; Price: {p1.Price}");
sw.Close();