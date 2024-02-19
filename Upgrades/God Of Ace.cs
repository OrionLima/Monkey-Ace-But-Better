using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyAceButBetter.Upgrades
{
    internal class God_Of_Ace : ModParagonUpgrade<BetterMonkeyAce>
    {
        public override int Cost => 6000000;
        public override string Description => "There's nothing stronger than it, not even God itself...";
        public override string DisplayName => "God Of Ace";

        public override string Icon => "God Of Ace-Icon";

        public override string Portrait => "God Of Ace-Portrait";

        // This is getting its Icon and Portrait from GodKingOfSpades-Icon.png and GodKingOfSpace-Portrait.png, so no other overriding needed

        public override void ApplyUpgrade(TowerModel towerModel)
        {

        }
    }
}
