using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Models.Towers.Mods;

namespace MonkeyAceButBetter.Upgrades.Bottom_Path.Teir_3
{
    internal class RPG : ModUpgrade <BetterMonkeyAce>
    {
        public override int Path => BOTTOM;

        public override int Tier => 3;

        public override int Cost => 10000;

        public override string Name => "RPG";

        public override string Description => "Range, Pierce and Gaster increace the Ace's ATK and SPD (Very Correct Name)";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            // ATK
            projectileModel.GetDamageModel().damage = 4;

            // SPD
            weaponModel.rate *= 0.45f;
        }
    }
}
