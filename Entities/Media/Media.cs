using reviewPlataformConsole.Entities.Media.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Entities.Media
{
    internal abstract class Media
    {
        public Guid Id { get; set; }
        public int NegativePoints { get; set; }
        public int PositivePoints { get; set; }
        public List<Comment> Comments { get; set; }
        public string Title { get; set; }

        protected Media(int negativePoints, int positivePoints, List<Comment> comments, string title)
        {
            Id = Guid.NewGuid();
            NegativePoints = negativePoints;
            PositivePoints = positivePoints;
            Comments = comments;
            Title = title;
        }

    }
}
