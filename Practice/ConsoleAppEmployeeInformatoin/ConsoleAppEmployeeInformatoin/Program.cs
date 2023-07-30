using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Human h1 = new Human("Rijoan", 21, 111122, "Bangladeshi");
            // h1.displayDetails();

            Student s1 = new Student("Fardous", 21, 22223, "Bangladeshi", 3.65, 41943);
            s1.displayDetails();

            Teacher t1 = new Teacher("Dr XYZ", 42, 333344, "Bangladeshi", "DS0109", 5254, "ABCD");
            t1.displayDetails();
        }
    }

    public class Human
    {
        private string name;
        private int age;
        private int nid;
        private string nationality;

        public Human()
        {
            Console.WriteLine("Default Human.");
        }
        public Human(string name, int age, int nid, string nationality)
        {
            this.name = name;
            this.age = age;
            this.nid = nid;
            this.nationality = nationality;
        }

        //Setters
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setNid(int nid)
        {
            this.nid = nid;
        }
        public void setNationality(string nationality)
        {
            this.nationality = nationality;
        }

        // Getters
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public int getNid()
        {
            return nid;
        }
        public string getNationality()
        {
            return nationality;
        }

        public virtual void displayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("NID: " + nid);
            Console.WriteLine("Nationality: " + nationality);
        }
    }

    public class Student : Human
    {
        private double cgpa;
        private int id;

        public Student()
        {
            Console.WriteLine("Default Student.");
        }
        public Student(string name, int age, int nid, string nationality, double cgpa, int id) : base(name, age, nid, nationality)
        {
            this.cgpa = cgpa;
            this.id = id;
        }

        //Setters
        public void setCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        // Getters
        public double getCgpa()
        {
            return cgpa;
        }
        public int getId()
        {
            return id;
        }

        public override void displayDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("Student Details:");
            Console.WriteLine("_______________________________");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("NID: " + getNid());
            Console.WriteLine("Nationality: " + getNationality());
            Console.WriteLine("CGPA: " + cgpa);
            Console.WriteLine("Student Id: " + id);
            Console.WriteLine("");
        }


    }


    public class Teacher : Human
    {
        private string roomNo;
        private int tId;
        private string research;

        public Teacher()
        {
            Console.WriteLine("Default Student.");
        }
        public Teacher(string name, int age, int nid, string nationality, string roomNo, int tId, string research) : base(name, age, nid, nationality)
        {
            this.roomNo = roomNo;
            this.tId = tId;
            this.research = research;
        }

        //Setters
        public void setRoomNo(string roomNo)
        {
            this.roomNo = roomNo;
        }
        public void setTId(int tId)
        {
            this.tId = tId;
        }
        public void setResearch(string research)
        {
            this.research = research;
        }

        // Getters
        public string getRoomNo()
        {
            return roomNo;
        }
        public int getTId()
        {
            return tId;
        }
        public string getResearch()
        {
            return research;
        }

        public override void displayDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("Teacher Details:");
            Console.WriteLine("_______________________________");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("NID: " + getNid());
            Console.WriteLine("Nationality: " + getNationality());
            Console.WriteLine("Room No: " + roomNo);
            Console.WriteLine("Teacher Id: " + tId);
            Console.WriteLine("Research Interest: " + research);
            Console.WriteLine("");
        }
    }
}