using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Bottom_Path.Teir_5
{
    internal class Ray_Of_Supersonic : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => BOTTOM;

        public override int Tier => 5;

        public override int Cost => 69690;

        public override string Name => "MAD Of Supersonic";

        public override string Description => "Upgrades lasers to Rays of Doom decinigrating all bloons. All projectiles fire at supersonic speeds.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.pierce = 999999999;
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("DartlingGunner-050").GetWeapon().Duplicate());
            weaponModel.rate *= 0.001f;
        }
    }
}
