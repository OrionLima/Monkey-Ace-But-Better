using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Projectiles.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Middle_Path.Teir_1
{
    internal class Mo__Projectiles___Mo__Damage : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 3000;

        public override string Name => "Mo' Projectiles = Mo' Damage";

        public override string Description => "Sacrifices Damage to give you more projectiles and Neva Miss Targeting";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // Lower Damage
            projectileModel.GetDamageModel().damage -= 3;

            // Multishot
            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 20, 0, 360, null, false, true);

            // Behaviors (Here it's Neva Miss and Ultra Jug Thingy)
            weaponModel.projectile.AddBehavior(new TrackTargetModel("TrackTargetModel_", 99999999f, true, false, 360f, true, 160f, false, false));

            weaponModel.projectile.AddBehavior<CreateProjectileOnExhaustFractionModel>(new("CreateProjectileOnExhaustFractionModel_", weaponModel.projectile.Duplicate(), new ArcEmissionModel("ArcEmissionModel_", 2, 0, 45, null, false, false), 0.5f, 0.33333f, false, false, false));

        }
    }
}
