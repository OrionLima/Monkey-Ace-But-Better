using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using MonkeyAceButBetter.Display.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Top_Path.Teir_5
{
    internal class Burning_Boomarangs : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 81600;

        public override string Name => "Burning Boomerang";

        public override string Description => "Glaves destroy anything in a 3 mile radius, gives you much more damage on other attacks.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.ApplyDisplay<BombDisplay>();

            projectileModel.GetDamageModel().damage = 300;
            projectileModel.pierce = 99999999999;
            weaponModel.rate *= 2;
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("BoomerangMonkey-502").GetWeapon().Duplicate());
        }
    }
}
