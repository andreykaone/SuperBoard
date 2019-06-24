using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBoard.DomainModels
{
    public class List
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }

        public override string ToString() => $@"#{Id} {Name} ({nameof(List)})";
    }
}
