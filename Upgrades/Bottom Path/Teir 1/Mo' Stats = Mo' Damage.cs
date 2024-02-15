using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Simulation.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Bottom_Path.Teir_1
{
    internal class Mo__Stats___Mo__Damage : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 3500;

        public override string Name => "Mo' Stats = Mo' Damage...?";

        public override string Description => "Increaces Most Stats";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // Attack Speed
            weaponModel.rate *= 0.5f;

            // Damage
            projectileModel.GetDamageModel().damage += 2;

            // Pierce
            projectileModel.pierce += 100;
        }
    }
}
