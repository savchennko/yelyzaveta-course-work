namespace Services
{
	public class ServiceInfo
	{
		public string Name { get; private set; }
		public string Description { get; private set; }
		public string DisplayName { get; private set; }
		public string ServiceType { get; private set; }
		public string StartMode { get; private set; }
		public string State { get; private set; }

		public ServiceInfo(string name, string description, string displayname,
			string servicetype, string startmode, string state)
		{
			Name = name;
			Description = description;
			DisplayName = displayname;
			ServiceType = servicetype;
			StartMode = startmode;
			State = state;
		}

		public void SetStartMode(string startmode)
		{
			StartMode = startmode;
		}

		public void SetState(string state)
		{
			State = state;
		}
	}
}
