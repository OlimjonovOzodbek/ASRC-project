using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities.Models
{
    public class QuestionModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<AnswerModel> Answers { get; set; }
    }
}
