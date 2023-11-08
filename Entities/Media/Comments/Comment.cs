using reviewPlataformConsole.Entities.Media.Comments.Enums;
using reviewPlataformConsole.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Entities.Media.Comments
{
    internal class Comment
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Guid Media { get; set; }
        public string Text { get; set; }
        public string LastText { get; set; }
        public int Likes { get; set; }
        public int Dislike { get; set; }
        public CommentStatus Status { get; set; }
        public DateTime? Created { get; set; } = DateTime.MinValue;
        public DateTime? Updated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public DateTime? CreatedBy { get; set; }

        public Comment(string text)
        {
            Id = Guid.NewGuid();
            Text = text;
        }

        //HistoricoDeText um dia



    }
}
