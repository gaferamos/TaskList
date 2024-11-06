using System.Xml.Linq;

namespace TaskList
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Tasks(int id, string name, string decription)
        {
            Id = id;
            Name = name;
            Description = decription;
            IsCompleted = false;

        }
        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, Descrição: {Description}, Estado: {(IsCompleted ? "Concluída" : "Pendente" )}";
        }


    }
    //public override string ToString()
        //{
        //    return $"{Descricao} - {(Concluida ? "Concluída" : "Pendente")}";
        //}
}
