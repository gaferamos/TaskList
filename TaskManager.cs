using System.Xml.Linq;

namespace TaskList
{
    internal class TaskManager
    {
        List<Tasks> tasklist = new List<Tasks>();

        
        public void Addtask()
        {
            Console.Clear();
            Console.WriteLine("De um numero a  sua tarefa");
            Console.Write("Numero: ");
            int numID = int.Parse(Console.ReadLine());

            if (tasklist.Any(u => u.Id.Equals(numID)))
            {
                Console.WriteLine("Uma tarefa com esse numero ja existe.");
                Console.WriteLine("Precione qualquer tecla para cintinuar...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("De um nome a sua tarefa");
            Console.Write("Nome: ");
            var name =Console.ReadLine();

            Console.WriteLine("Dedescreva a sua tarefa");
            Console.Write("Descrição: ");
            var descripton = Console.ReadLine();

            Tasks newTask = new Tasks(numID, name, descripton);
            tasklist.Add(newTask);
            Console.WriteLine(newTask);

            

        }
        public void Sowtasks()
        {
            foreach (var task in tasklist)
            {
                Console.WriteLine(task.ToString());
            }
        }


    }
}
