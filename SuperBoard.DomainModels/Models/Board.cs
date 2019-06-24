
namespace SuperBoard.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Board
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<List> Lists { get; set; }

        public override string ToString() => $@"#{Id} {Name} ({nameof(Board)})";
    }
}
