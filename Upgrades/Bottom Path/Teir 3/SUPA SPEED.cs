using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using MonkeyAceButBetter.Display.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Middle_Path.Teir_3
{
    internal class SUPA_SPEED : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => BOTTOM;

        public override int Tier => 3;

        public override int Cost => 5069;

        public override string Name => "SUPA SPEED";

        public override string DisplayName => "SUPA SPEED";


        public override string Description => "Makes you go SUPA FAST but smaller damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.ApplyDisplay<MissileDisplay>();

            weaponModel.rate *= 0.3f;

            projectileModel.GetDamageModel().damage -= 5;
        }
    }
}
