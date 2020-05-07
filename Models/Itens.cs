namespace MyCollection
{
    public class Itens
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int Type { get; internal set; }
        public int PlaceId { get; internal set; }
        public Locations Place { get; internal set; }
    }

}