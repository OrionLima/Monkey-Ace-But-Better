using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Bottom_Path.Teir_2
{
    internal class All_Bloons_M : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => BOTTOM;

        public override int Tier => 2;

        public override int Cost => 3500;

        public override string Name => "All Bloons M.I.B";

        public override string Description => "Allows the Monkey Ace to hit all Bloons (Including Leads and Camo)";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.CanHitCamo();
            projectileModel.SetHitCamo(true);
            projectileModel.GetDamageModel().immuneBloonProperties = BloonProperties.None;
        }
    }
}
