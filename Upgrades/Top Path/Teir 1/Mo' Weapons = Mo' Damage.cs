using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Top_Path.Teir_1
{
    internal class Mo__Weapons___Mo__Damage : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 2069;

        public override string Name => "Mo' Weapons = Mo' Damage";

        public override string Description => "Gives you a whole lotta weapons";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            //Add New Weapons
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("NinjaMonkey-002").GetWeapon().Duplicate());
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("SuperMonkey-200").GetWeapon().Duplicate());
            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("DartlingGunner-200").GetWeapon().Duplicate());
        }
    }
}
