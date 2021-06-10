using System;

namespace EF6_SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SQLiteDBEntities();

            foreach(var dept in db.Departments)
            {
                Console.WriteLine($"DeptId: {dept.DeptId}, DeptName: {dept.Name}");

                foreach(var user in dept.Users)
                {
                    Console.WriteLine($"         UserId: {user.UserId}, UserName: {user.UserName}, FirstName: {user.FirstName}, LastName: {user.LastName}");
                }
            }

            Console.ReadLine();
        }
    }
}
