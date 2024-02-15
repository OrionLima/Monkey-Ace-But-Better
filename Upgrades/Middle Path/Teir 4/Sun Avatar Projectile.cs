using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Middle_Path.Teir_4
{
    internal class Sun_Avatar_Projectile : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => MIDDLE;

        public override int Tier => 4;

        public override int Cost => 9800;

        public override string Name => "Sun Avatar Projectile";

        public override string Description => "Sun Avatar Beams rain over bloons destroying them instantly. Increaces projectile amounts and damage.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("SuperMonkey-300").GetWeapon().Duplicate());
            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 30, 0, 360, null, false, true);
            weaponModel.rate *= 2;
            projectileModel.GetDamageModel().damage += 7;
            projectileModel.pierce = 696;
        }
    }
}
