using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace FastExtractinator
{
    class Modification : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);

            // 424 is silt block
            if (item.type == 424) {
                item.useTime = 0;
                item.reuseDelay = 0;
            }
        }
    }
}
