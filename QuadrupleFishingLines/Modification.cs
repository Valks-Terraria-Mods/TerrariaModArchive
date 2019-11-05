using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace QuadrupleFishingLines
{
    class Modification : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            if (item.fishingPole > 0) {
                item.useTime = 0;
                item.reuseDelay = 0;
            }
        }
    }
}
