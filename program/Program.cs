void Print(string[] array)
{
    for(int i=0; i<array.Length;i++)
        Console.Write($"{array[i]},  ");
}
string[] Fill(string[] array1)
{
    string[] array2=new string[array1.Length];
    int count=0;
    for(int i=0; i<array1.Length;i++)
    {
        if(array1[i].Length<=3)
        {
            array2[count]=array1[i];
            count++;
        }
    }
    Array.Resize<string>(ref array2,count);
    return array2;
}
string[] Test=new string[5] {"hello","2","world","gb",":-)"};
Print(Test);
Console.WriteLine("");
string[] Test2=Fill(Test);
Print(Test2);