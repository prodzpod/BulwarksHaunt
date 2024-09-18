using RoR2;
using RoR2.Achievements;

namespace BulwarksHaunt.Achievements
{
	[RegisterAchievement("BulwarksHaunt_MercWinGhostWave", "Skins.Merc.BulwarksHaunt_Alt", null, 10, null)]
	public class MercWinGhostWave : BaseWinGhostWavePerSurvivor
	{
		public override BodyIndex LookUpRequiredBodyIndex()
		{
			return BodyCatalog.FindBodyIndex("MercBody");
		}
	}
}
