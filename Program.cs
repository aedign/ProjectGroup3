using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace ProjectGroup3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Form1());
            Project p = new Project("Example", "Whatever");
            p.AddMember("Andres");

            foreach (Member member in p.GetMembers())
            {
                Console.WriteLine(member.Name);
            }

            foreach (Member member in p.GetMembers()) 
            {
                changeName(ref member.Name);
            }

            foreach (Member member in p.GetMembers())
            {
                Console.WriteLine(member.Name);
            }

            p.AddFunctionalRequirement("jkfne");
            string a = p.GetFunctionalRequirements().First();
            Console.WriteLine(a);
            changeName(ref a);
            foreach (string member in p.GetFunctionalRequirements())
            {
                Console.WriteLine(member);
            }


        }

        public static void changeName(ref string name)
        {
            name = "Enrique";
        }
    }
}
