// Activity 4 Kevin Xie
using System;

namespace Activity4
{

    // interface
    public interface MyInterface
    {
        string MyString { get; set; }

        bool MyBool { get; set; }

        int MyInt { get; set; }

        int this[int i] { get; set; }

        void greeting();

    }


    class MyClass : MyInterface
    {
        // field
        private string str_val;
        private bool bool_val;
        private int int_val;


        // properties
        public string MyString
        {
            get { return str_val; }
            set { str_val = value; }
        }

        public bool MyBool
        {
            get { return bool_val; }
            set { bool_val = value; }
        }

        public int MyInt
        {
            get { return int_val; }
            set { int_val = value; }
        }


        // indexer
        private int[] arr = new int[5];

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        // instance
        public void greeting()
        {
            Console.WriteLine("Hello Serra!");
        }

    }

    class Program
    {
        static void Main(String[] args)
        {
            // instance of class
            MyClass student = new MyClass();

            // setter
            student.MyString = "Kevin";
            student.MyBool = true;
            student.MyInt = 23;

            student[0] = 2;
            student[1] = 4;
            student[2] = 6;
            student[3] = 8;
            student[4] = 10;

            // instance function
            student.greeting();

            // getter
            Console.WriteLine(student.MyString);
            Console.WriteLine(student.MyBool);
            Console.WriteLine(student.MyInt);

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(student[i]);
                i++;
            }


        }
    }
}