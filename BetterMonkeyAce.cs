using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Data.Quests;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter
{
    internal class BetterMonkeyAce : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Military;

        public override string BaseTower => TowerType.MonkeyAce;

        public override int Cost => 1100;

        public override string Description => "This is my First Attempt at a Tower. Hope you like it!";

        public override string DisplayName => "Better Monkey Ace";

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override ParagonMode ParagonMode => ParagonMode.Base555;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            //Range
            towerModel.range = 1000; // Higher = Better
            attackModel.range += 1000;

            //Attack Speed
            weaponModel.rate *= 0.5f; //Lower = Better   // Can Also Be weaponModel.rate /= 2f;

            // Damage
            projectileModel.GetDamageModel().damage = 4;

            // Pierce
            projectileModel.pierce = 100;
        }

        public override int GetTowerIndex(List<TowerDetailsModel> towerSet) => 
            towerSet.First(model => model.towerId == TowerType.MonkeyAce).towerIndex + 1; // Makes it be in front of the Monkey Ace (If Not Present it will be at the end of the Military section)

        public override bool IsValidCrosspath(int[] tiers) =>
            ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);  // Gives Ultimate Crosspathing Support
    }
}
