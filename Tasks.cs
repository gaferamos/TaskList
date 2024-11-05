using System.Xml.Linq;

namespace TaskList
{
    internal class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Tasks(int id, string name, string decription)
        {
            Id = id;
            Name = name;
            Description = decription;

        }

    }
    
}
