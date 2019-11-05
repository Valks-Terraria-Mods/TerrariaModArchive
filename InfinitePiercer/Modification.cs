using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace InfinitePiercer
{
    class Modification : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            base.SetDefaults(projectile);

            if (projectile.friendly) {
                projectile.penetrate = 1000;
                projectile.maxPenetrate = 1000;
            }
            
        }
    }
}
