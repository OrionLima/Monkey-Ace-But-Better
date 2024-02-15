using MelonLoader;
using BTD_Mod_Helper;
using MonkeyAceButBetter;

[assembly: MelonInfo(typeof(MonkeyAceButBetter.MonkeyAceButBetter), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace MonkeyAceButBetter;

public class MonkeyAceButBetter : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<MonkeyAceButBetter>("Better Monkey Ace is Here! Thank You for Playing! Full Release Is Finally out! Discord, for those who wanna support me: https://discord.gg/hCgP22JNYA");
    }
}