using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Abstractions;
using Test.Domain.Entities.Models;

namespace Test.Infrastructure.Persistence
{
    public class TestDbContext : DbContext, ITestDbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<CriteriaModel> Criterias { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<MessageModel> Messages { get; set; }
    }
}
