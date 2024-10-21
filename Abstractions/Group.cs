using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class Group 
    {

        public string GroupNo;
        public int Studentlimit;
        private Student[] students;


        public Group(int limit)
        {
            students = new Student[0];
            Studentlimit = limit;
            

        }

        public bool CheckGroupNo(string group)
        {
            bool group_adi;
            if(group.Length==5 && char.IsUpper(group[0]) && char.IsUpper(group[1]) && char.IsDigit(group[2]) && char.IsDigit(group[3]) && char.IsDigit(group[4]))
            {
                group_adi = true;
            }
            else
            {
                group_adi = false;
            }
            return group_adi;   
        }

        public void AddStudent(Student student)
        {
            
            if (students.Length < Studentlimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
                Console.WriteLine($"Telebe {student.Fullname} qrupa elave edildi.");
            }
            else
            {
                Console.WriteLine("Qrupda artıq yer yoxdur.");
            }
        }


        public void GetStudent(int id)
        {
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    Console.WriteLine("Telebenin adi:"+students[i].Fullname);
                    Console.WriteLine("Telebenin xali:"+students[i].Point);
                }
            }
        }

        public void GetAllStudent()
        {
            for (int i = 0;i < students.Length;i++)
            {
                Console.WriteLine();
                Console.WriteLine("Telebe Idsi:"+students[i].Id);
                Console.WriteLine("Telebenin adi:"+students[i].Fullname);
                Console.WriteLine("Telebenin xali:"+students[i].Point);
                Console.WriteLine();
            }
        }

    }
}
