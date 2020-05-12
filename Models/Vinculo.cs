namespace MyCollection.Models
{
    public class Vinculo
    {
        #region properties

        public int Id { get; set; }
        public Itens Itens { get; set; }
        public User User { get; set; }
        
        #endregion
    }
}