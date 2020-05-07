namespace MyCollection
{
    public class Borrowed
    {
        public int Id { get; internal set; }
        public int ItemId { get; internal set; }
        public Itens Item { get; internal set; }
        public string NameResponsible { get; internal set; }
        public string PhoneResponsible { get; internal set; }
    }
}