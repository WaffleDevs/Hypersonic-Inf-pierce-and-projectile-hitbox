using MelonLoader;
using Harmony;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Simulation.Towers.Projectiles;

namespace HIPPH
{
    public class Main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            NKHook6.Logger.Log("HIPPH has successfully loaded.");
        }

    }


    [HarmonyPatch(typeof(Weapon), nameof(Weapon.UpdatedModel))]
    public class WeaponUpdatedModel_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }

    [HarmonyPatch(typeof(Weapon), nameof(Weapon.Initialise))]
    public class WeaponInitialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }

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
}
