using RoR2;
using RoR2.Achievements;

namespace BulwarksHaunt.Achievements
{
	[RegisterAchievement("BulwarksHaunt_RailgunnerWinGhostWave", "Skins.RailGunner.BulwarksHaunt_Alt", null, 10, null)]
	public class RailgunnerWinGhostWave : BaseWinGhostWavePerSurvivor
	{
		public override BodyIndex LookUpRequiredBodyIndex()
		{
			return BodyCatalog.FindBodyIndex("RailgunnerBody");
		}
	}
}
