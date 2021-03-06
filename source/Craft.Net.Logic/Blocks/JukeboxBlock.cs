using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Craft.Net.Anvil;

namespace Craft.Net.Logic.Blocks
{
    [Item(JukeboxBlock.BlockId, JukeboxBlock.DisplayName, "Initialize", typeof(Block))]
    [Block(JukeboxBlock.BlockId, DisplayName = JukeboxBlock.DisplayName, Hardness = JukeboxBlock.Hardness)]
    public static class JukeboxBlock
    {
        public const string DisplayName = "Jukebox";
        public const short BlockId = 84;
		public const double Hardness = 2;
    }
}
