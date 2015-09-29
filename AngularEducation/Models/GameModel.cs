using AngularEducationBackend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularEducation.Models
{
    [Serializable]
    public class GameModel
    {
        public string Name { get; set; }
        public GameModel(tblGame game)
        {
            Name = game.Name;
        }
    }
}
