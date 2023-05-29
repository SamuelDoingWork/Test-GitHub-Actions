using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Repository
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Version { get; set; }
        public string Author { get; set; } = "Sam";

        public string CreateRepo()
        {
            return $"{Author} RepoCreated";
        }

        public static string ReadRepo() => "Readed repo";
    }
}
