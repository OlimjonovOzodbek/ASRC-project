using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities.Models
{
    public class CriteriaModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<int> QuestionIds { get; set; }
        public List<MessageModel> Messages { get; set; }
    }
}
