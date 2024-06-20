using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Entities.Models
{
    public class AnswerModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Points { get; set; }
        public string Text {  get; set; }
    }
}
