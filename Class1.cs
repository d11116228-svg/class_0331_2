using System;
using System.Security.Cryptography.X509Certificates;

// 父類別
public class Person
{
    public string Name = "姓氏";
    //建構子
    public Person(string n)
    {
        Name = n;
    }
}

// 子類別
public class Student : Person
{
    public string stdname = "名字";
    //建構子
    public Student(string n) : base("陳")
    {
        stdname = Name + n;
    }
}