using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBoard.DomainModels
{
    public class SuperBoardContext : DbContext
    {
        public SuperBoardContext(DbContextOptions<SuperBoardContext> options)
            : base(options)
        { }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
