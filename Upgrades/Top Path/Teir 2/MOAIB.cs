using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Top_Path.Teir_2
{
    internal class MOAIB : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 4000;

        public override string Name => "MOAIB";

        public override string Description => "MOAIB (Monkey on an Inteligent Bomb) Makes the Monkey Panic and Shoot Faster but lose accuracy (lower pierce)";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;


            // Pierce
            projectileModel.pierce *= 0.5f;

            // Attack Speed
            weaponModel.rate *= 0.25f;
        }
    }
}
