using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Bottom_Path.Teir_4
{
    internal class Laser_Projectile_Speed : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => BOTTOM;

        public override int Tier => 4;

        public override int Cost => 10000;

        public override string Name => "Laser Projectile Speed";

        public override string Description => "Fires lasers from the center of the ace, causing other projectiles to fire faster and damage more, making bloons decinigrate even at the sight of it.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("DartlingGunner-300").GetWeapon().Duplicate());

            weaponModel.rate *= 0.7f;
        }
    }
}
