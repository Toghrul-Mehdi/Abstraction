using System.Drawing;
using System.Text.RegularExpressions;

namespace Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            bool f = false;
            string email;

            double Point;

            string stu_fullname;

            User users =new User();

            bool bool_limit = false;
            int limit;
            do
            {
                Console.WriteLine("Limit daxil edin:");
                bool_limit=int.TryParse(Console.ReadLine(),out limit);

                if(limit>=5 && limit <= 18)
                {
                    bool_limit = true;
                }
                else
                {
                    bool_limit=false;
                }
            } while (!bool_limit);

            Group students =new Group(limit);

            

            

            do
            {
                Console.WriteLine("1.AddUser    2.ShowInfo  3.CheckGroupNo  4.AddStudent   5.GetStudent   6.GetAllStudent   0.Exit");                         
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Fullname daxil edin:");
                        string fullname = Console.ReadLine();
                        bool email_f = false;
                        do
                        {
                            Console.WriteLine("Email daxil edin:");
                            email = Console.ReadLine();
                            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                 @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                 @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                            Regex re = new Regex(strRegex);
                            if (re.IsMatch(email))
                            {
                                Console.WriteLine("EMail uygundur");
                                email_f = true;
                            }
                            else
                            {
                                Console.WriteLine("EMail uygun deyil");
                                email_f = false;
                            }
                        } while (!email_f);

                        bool pass = false;
                        do
                        {
                            Console.WriteLine("Password daxil edin:");
                            password = Console.ReadLine();

                            if(users.PasswordChecker(password) == true)
                            {
                                pass = true;    
                            }
                            else
                            {
                                pass =false;
                            }                       
                        } while (!pass);
                        users.AddUser(users,fullname,email,password);
                        break;

                    case "2":                        
                        users.ShowInfo();                        
                        break;
                    case "3":
                        bool group_f = false;
                        do
                        {
                            Console.WriteLine("Qrup adi daxil edin:");
                            string groupname = Console.ReadLine();

                            if (students.CheckGroupNo(groupname) == true)
                            {
                                Console.WriteLine("Qrup adinin parametrleri uyusur");
                                group_f = true;
                            }
                            else
                            {
                                Console.WriteLine("Qrup adinin parametrleri uyusmur");
                                group_f = false;
                            }
                        } while (!group_f);                     

                        

                        break;
                    case "4":
                        Console.WriteLine("Fullname daxil edin:");
                        stu_fullname= Console.ReadLine();

                        bool point_f = false;
                        
                        do
                        {
                            Console.WriteLine("Point daxil edin:");
                            point_f=double.TryParse(Console.ReadLine(), out Point);
                            if(Point>=0 && Point <= 100)
                            {
                                point_f = true;
                            }
                            else
                            {
                                point_f = false;
                            }
                        } while (!point_f);
                        Student student = new Student(stu_fullname, Point);
                        students.AddStudent(student);
                        break;

                    case "5":
                        

                        int id;
                        bool id_f = false;
                        do
                        {
                            Console.WriteLine("Id daxil edin:");
                            id_f=int.TryParse(Console.ReadLine(),out id);
                            if (id > 0)
                            {
                                id_f = true;
                            }
                            else
                            {
                                id_f = false;
                            }
                        } while (!id_f);
                        students.GetStudent(id);
                        break;

                    case "6":
                        students.GetAllStudent();  
                        break;
                    case "0":
                        return;


                    default:
                        break;
                }
            } while (!f);

            

        }
    }
}
