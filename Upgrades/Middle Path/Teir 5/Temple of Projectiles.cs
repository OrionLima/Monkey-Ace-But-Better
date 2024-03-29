﻿using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Unity;
using MonkeyAceButBetter.Display.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades.Middle_Path.Teir_5
{
    internal class Temple_of_Projectiles : ModUpgrade<BetterMonkeyAce>
    {
        public override int Path => MIDDLE;

        public override int Tier => 5;

        public override int Cost => 98500;

        public override string Name => "Temple Of Projectiles";

        public override string Icon => "Temple Of Projectiles-Icon";

        public override string Portrait => "Temple Of Projectiles-Portrait";

        public override string Description => "Upgrades your Sun Avatar Beams to True Sun God Beams and gives you more projectiles and slightly increaces damage.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            var projectileModel = weaponModel.projectile;

            projectileModel.ApplyDisplay<BombDisplay>();

            attackModel.AddWeapon(Game.instance.model.GetTowerFromId("SuperMonkey-500").GetWeapon().Duplicate());
            weaponModel.rate *= 1.3f;
            weaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 69, 0, 360, null, false, true);
            projectileModel.GetDamageModel().damage = 50;
            projectileModel.pierce = 999999999f;
        }
    }
}
