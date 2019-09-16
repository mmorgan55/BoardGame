using game_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class GameTile : ITile
    {
        public string StringRepresentation { get; set; }

        public GameTile(string stringRepresentation)
        {
            StringRepresentation = stringRepresentation;
        }

        public override string ToString()
        {
            return StringRepresentation;
        }
    }
}
