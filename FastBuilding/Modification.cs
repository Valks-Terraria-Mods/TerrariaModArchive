using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace FastBuilding
{
    class Modification : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            // item.createTile > - 1 means its a placable tile
            // item.hammer > 0 means its a hammer
            if (item.hammer > 0 || item.createTile > -1) {
                item.useTime = 0;
                item.reuseDelay = 0;
            }
        }
    }
}
