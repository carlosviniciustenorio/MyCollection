﻿using System.Collections.Generic;

namespace MyCollection.Models
{
    public class User
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Endereco { get; set; }
        public virtual List<Vinculo> Vinculos { get; set; }

        #endregion
    }
}