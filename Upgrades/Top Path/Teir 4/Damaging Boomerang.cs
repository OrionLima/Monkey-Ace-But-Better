using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Top_Path.Teir_4
{
    internal class Damaging_Boomerang : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 10069;

        public override string Name => "Damaging Boomerang";

        public override string Description => "Gives the ace boomerang. All projectiles now deal lots more damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.GetDamageModel().damage = 50;
            projectileModel.pierce = 696;

            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("BoomerangMonkey-400").GetWeapon().Duplicate());
        }
    }
}
