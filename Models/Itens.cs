using System.Collections.Generic;
using Type = MyCollection.Models.Enum.Type;

namespace MyCollection.Models
{
    public class Itens
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Loan { get; set; }
        public Type Type  { get; set; }
        public virtual List<Vinculo> Vinculo { get; set; }

        #endregion

    }
}
