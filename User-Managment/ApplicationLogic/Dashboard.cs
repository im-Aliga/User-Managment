using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Managment.Database.Models;
using User_Managment.Database.Reposity;

namespace User_Managment.ApplicationLogic
{
    public static class Dashboard
    {
        public static void AdminPanel()
        {
            Console.WriteLine("Our available commands :");
            Console.WriteLine("/add-user");
            Console.WriteLine("/update-user");
            Console.WriteLine("/reports");
            Console.WriteLine("/remove-user");
            Console.WriteLine("/add-admin");
            Console.WriteLine("/show-admins");
            Console.WriteLine("/update-admin ");
            Console.WriteLine("/remove-admin");
            Console.WriteLine("/log out");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Enter command : ");
                string command = Console.ReadLine();
                if (command == "/add-user")
                {
                    Authentication.Register();


                }
                else if (command == "/update-user")
                {
                    Console.Write("Enter user's email :");
                    string email = Console.ReadLine();
                    User user = UserReposity.GetUserByEmail(email);
                    if (user == null)
                    {
                        Console.WriteLine("User not found");

                    }
                    else if (user is Admin)
                    {
                        Console.WriteLine("This email is admin's");
                    }
                    else
                    {
                        User updateuser = new User(Authentication.GetName(), Authentication.GetLastName());
                        UserReposity.UpdateForUser(email, updateuser);
                        Console.WriteLine("User has ben updated");




                    }

                }
                else if (command == "/remove-user")
                {
                    Console.Write("Enter user's email : ");
                    string email = Console.ReadLine();
                    User user = UserReposity.GetUserByEmail(email);
                    if (user == null)
                    {
                        Console.WriteLine("User not found");
                    }
                    else if (user is Admin)
                    {
                        Console.WriteLine("This user is admin");

                    }
                    else
                    {
                        UserReposity.Delete(user);
                        Console.WriteLine("User has been deleted");

                    }




                }
                else if (command == "/reports")
                {

                }
                else if (command == "/add-admin")
                {

                    Admin admin = new Admin(Authentication.GetName(), Authentication.GetLastName(), Authentication.GetEmail(), Authentication.GetPassword());
                    UserReposity.AddUser(admin);




                }
                else if (command == "/show-admins")
                {
                    UserReposity.ShowAdmin();

                }
                else if (command == "/update-admin")
                {
                    Console.Write("Enter email :");
                    string email = Console.ReadLine();
                    User admin = UserReposity.GetUserByEmail(email);
                    if (admin.Email == email)
                    {
                        Console.WriteLine("deyiwmekk istediyiniz admin daxil olmusunuz");

                    }
                    else if (email == null)
                    {
                        Console.WriteLine("email tapilmadi");
                    }
                    else
                    {
                        if (admin is Admin)
                        {
                            User updateuser = new User(Authentication.GetName(), Authentication.GetLastName());
                            UserReposity.UpdateForUser(email, updateuser);
                            Console.WriteLine("admin hes been updated");
                        }
                        else if (admin is User)
                        {
                            Console.WriteLine("this email is user's email");

                        }
                    }


                }
                else if (command == "/remove-admin")
                {
                    Console.WriteLine("enter email");
                    string email = Console.ReadLine();
                    User admin = UserReposity.GetUserByEmail(email);
                    if (admin.Email == email)
                    {
                        Console.WriteLine("admin ozunu sile bilmez");
                    }
                    else
                    {

                        if (admin == null)
                        {
                            Console.WriteLine("admin tapilmadi");
                        }
                        else if (admin is User)
                        {
                            Console.WriteLine("dazxil etdiyiniz admin deyl");

                        }
                        else if (admin is Admin)
                        {

                            UserReposity.Delete(admin);
                            User user = new User(admin.Name, admin.LastName, admin.Email, admin.Password, admin.Id);


                        }









                    }

                }


                else if (command == "/log out")
                {
                    Program.Main(new string[] { });
                    break;
                }




            }







        }


        public static void UserPanel(string email)
        {
            User user = UserReposity.GetUserByEmail(email);
            Console.WriteLine($"user succesfully joined : {user.GetUserInfoForUser()}");
            while (true)
            {
                Console.WriteLine("/update-info ");
                Console.WriteLine("/report-user");
                Console.WriteLine("enter command");
                string command = Console.ReadLine();
                if (command == "/update-info ")
                {
                    if (user.Email == email)
                    {
                        User uptUser = new User(Authentication.GetName(), Authentication.GetLastName());
                        UserReposity.UpdateForUser(email, uptUser);
                    }

                }
            }
        }
    }
}

