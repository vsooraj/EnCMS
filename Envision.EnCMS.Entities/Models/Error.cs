using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Entities.Models
{
    public class Error : IEntityBase
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
