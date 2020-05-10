using Type = MyCollection.Models.Enum.Type;

namespace MyCollection.Models
{
    public class Itens
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Loan { get; set; }
        public Type Type  { get; set; }

    }
}
