using RoR2;
using RoR2.Achievements;

namespace BulwarksHaunt.Achievements
{
	[RegisterAchievement("BulwarksHaunt_VoidSurvivorWinGhostWave", "Skins.VoidSurvivor.BulwarksHaunt_Alt", null, 10, null)]
	public class VoidSurvivorWinGhostWave : BaseWinGhostWavePerSurvivor
	{
		public override BodyIndex LookUpRequiredBodyIndex()
		{
			return BodyCatalog.FindBodyIndex("VoidSurvivorBody");
		}
	}
}
