using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Entities.Models
{
    public class Category : IEntityBase
    {
        public Category()
        {
            DateCreated = DateTime.Now;
            Gadgets = new List<Gadget>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual ICollection<Gadget> Gadgets { get; set; }

        
    }
}
