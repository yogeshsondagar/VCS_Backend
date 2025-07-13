namespace Mission.Entities.ViewModels.MissionTheme
{
	public class MissionThemeResponseModel : UpsertMissionThemeRequestModel
	{
		public MissionThemeResponseModel() { }

		public MissionThemeResponseModel(Models.MissionTheme missionTheme)
		{
			Id = missionTheme.Id;
			themeName = missionTheme.themeName;
			Status = missionTheme.Status;
		}
	}
}