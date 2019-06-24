using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBoard.DomainModels
{
    public class Issue
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public List List { get;set; }

        public override string ToString() => $@"#{Id} {Name} ({nameof(Issue)})";
    }
}
