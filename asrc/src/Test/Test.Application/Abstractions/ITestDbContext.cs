using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Entities.Models;

namespace Test.Application.Abstractions
{
    public interface ITestDbContext
    {
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        public DbSet<AnswerModel> Answers { get; set; }

        public DbSet<CriteriaModel> Criterias { get; set; }

        public DbSet<QuestionModel> Questions { get; set; }

        public DbSet<MessageModel> Messages { get; set; }
    }
}
