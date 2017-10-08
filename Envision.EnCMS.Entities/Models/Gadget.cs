using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Entities.Models
{
    public class Gadget:IEntityBase
    {
        public Gadget()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
