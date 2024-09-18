using RoR2;
using RoR2.Achievements;

namespace BulwarksHaunt.Achievements
{
	[RegisterAchievement("BulwarksHaunt_LoaderWinGhostWave", "Skins.Loader.BulwarksHaunt_Alt", null, 10, null)]
	public class LoaderWinGhostWave : BaseWinGhostWavePerSurvivor
	{
		public override BodyIndex LookUpRequiredBodyIndex()
		{
			return BodyCatalog.FindBodyIndex("LoaderBody");
		}
	}
}
