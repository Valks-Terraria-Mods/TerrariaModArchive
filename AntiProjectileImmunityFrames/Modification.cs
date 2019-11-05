using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace AntiProjectileImmunityFrames
{
    class Modification : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            base.SetDefaults(projectile);

            projectile.penetrate = -1;
        }
    }
}
