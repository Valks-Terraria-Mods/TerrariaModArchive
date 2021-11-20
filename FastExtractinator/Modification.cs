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

            // 424 is silt block, 1103 is slush, 3347 is desert fossil
            if (item.type == 424 || item.type == 1103 || item.type == 3347) {
                item.useTime = 0;
                item.reuseDelay = 0;
            }
        }
    }
}
