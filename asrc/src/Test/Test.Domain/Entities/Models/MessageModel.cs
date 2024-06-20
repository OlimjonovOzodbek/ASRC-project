using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities.Models
{
    public class MessageModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int MinPoints { get; set; }
        public int MaxPoints { get; set; }
        public string Content { get; set; }
    }
}
