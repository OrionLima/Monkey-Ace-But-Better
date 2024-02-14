using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Top_Path.Teir_3
{
    internal class SloWeapon_MorDamage : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 4000;

        public override string Name => "SloWeapon MorDamage";

        public override string Description => "Slows the ace down but gives you 4x more damage!";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // Attack Speed
            weaponModel.rate *= 5;

            // Damage
            projectileModel.GetDamageModel().damage *= 4;
        }
    }
}
