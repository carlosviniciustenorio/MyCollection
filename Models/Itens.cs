using Type = MyCollection.Models.Enum.Type;

namespace MyCollection.Models
{
    public class Itens
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Type Type  { get; set; }

        public string ParseEnumToText(Type type)
        {
            var exit = "";
            switch (type)
            {
                case Type.CD:
                    exit = "CD";
                    break;
                case Type.DVD:
                    exit = "Especialista";
                    break;
                case Type.Livro:
                    exit = "Livro";
                    break;
            }
            return exit;
        }
    }
}