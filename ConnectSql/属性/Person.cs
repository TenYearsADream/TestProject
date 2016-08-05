using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性
{
    public class Person
    {
        public Person(string name, int age,char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            sayhello();
        }
        string _name;
        public string Name
        {
            get
            {                            
                return _name;
            }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }             
        public void sayhello()
        {
            Console.WriteLine("我叫{0},我今年{1}，我是{2}的。", Name, Age, Gender);
        }
    }
}
