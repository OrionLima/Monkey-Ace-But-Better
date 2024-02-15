using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2Cpp;
using Il2CppSystem.Linq.Expressions.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;

namespace MonkeyAceButBetter.Upgrades.Middle_Path.Teir_2
{
    internal class PSA : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 6969;

        public override string Name => "PSA";

        public override string DisplayName => "PSA";


        public override string Description => "More Projectiles, Speed and Attack";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // Multishot

            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 30, 0, 360, null, false, true);

            // Attack Speed
            weaponModel.rate *= 0.5f;

            // Damage
            projectileModel.GetDamageModel().damage += 5;
        }
    }
}
