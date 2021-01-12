using MelonLoader;
using Harmony;
using NKHook6.Api;
using NKHook6;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Simulation.Towers.Projectiles;
using Assets.Scripts.Simulation;
namespace First_Test
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            NKHook6.Logger.Log("First Test has loaded POG.");
        }
        
    }

    
/*    [HarmonyPatch(typeof(Weapon), nameof(Weapon.UpdatedModel))]
    public class WeaponUpdatedModel_Patch    
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }
*/
/*    [HarmonyPatch(typeof(Weapon), nameof(Weapon.Initialise))]
    public class WeaponInitialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }*/

    [HarmonyPatch(typeof(Projectile), nameof(Projectile.Initialise))]
    public class ProjectileInitialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Projectile __instance)
        {
            __instance.projectileModel.radius = 10000;
            __instance.projectileModel.pierce = 10000;
        }
    }

    [HarmonyPatch(typeof(Simulation), nameof(Simulation.Initialise))]
    public class SimInitialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Simulation __instance)
        {
            __instance.towerInventories.a=
        }
    }
    /*[HarmonyPatch(typeof(Simulation), "OnRoundEnd")]
    public class SimulationOnRoundEnd_Patch
    {
        [HarmonyPostfix]
        public static void Postfix()
        {
            InGame.instance.addCash(1000000);
            InGame.instance.addHealth(1000000);

        }
    }*/
}
