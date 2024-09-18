using RoR2;
using RoR2.Achievements;

namespace BulwarksHaunt.Achievements
{
	[RegisterAchievement("BulwarksHaunt_HuntressWinGhostWave", "Skins.Huntress.BulwarksHaunt_Alt", null, 10, null)]
	public class HuntressWinGhostWave : BaseWinGhostWavePerSurvivor
	{
		public override BodyIndex LookUpRequiredBodyIndex()
		{
			return BodyCatalog.FindBodyIndex("HuntressBody");
		}
	}
}
