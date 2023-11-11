using reviewPlataformConsole.Entities.Media.Comments;
using reviewPlataformConsole.Entities.Media.MediaTypes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Entities.Media.MediaTypes
{
    internal class TesteMedia : Media
    {
        public MediaType type { get; set; } = MediaType.Teste;
        public string Developer { get; set; }

        public TesteMedia(string developer, int negativePoints, int positivePoints, List<Comment> comments, string title) : base(negativePoints, positivePoints, comments, title)
        {
            Developer = developer;
        }

        public override string ToString()
        {
            string result = "ID objeto: " + Id + "\nTitle: " + Title + "\nDeveloper: " + Developer + "\nPontos positivos: " + PositivePoints + "\nPontos negativos: " + NegativePoints +
                 "\nComments:\n";
            foreach (Comment item in Comments)
            {
                result += "\nID: " + item.Id + "\n";
                result += "MediaType: " + MediaType.Teste + "\n";
                result += "Texto: " + item.Text + "\n";
            }

            return result;
        }
    }
}
