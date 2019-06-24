using SuperBoard.DomainModels;

namespace SuperBoard.UI.Models
{
    public class BoardViewModel
    {
        public BoardViewModel(Board[] boards)
        {
            Boards = boards;
        }
        public Board[] Boards { get; set; }

    }
}
