using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace Services
{
	public partial class FormServices : Form
	{
		private List<ServiceInfo> servicesInfo = new List<ServiceInfo>();
		private List<ManagementObject> managmentObjects = new List<ManagementObject>();
		private BindingSource bindingSource = new BindingSource();

		public FormServices()
		{
			InitializeComponent();
		}

		private void startservice_Click(object sender, EventArgs e)
		{
			if (dataGridServices.SelectedRows.Count == 1)
			{
				int index = dataGridServices.SelectedRows[0].Index;
				ManagementBaseObject outParams = managmentObjects[index].InvokeMethod("StartService", null, null);
				servicesInfo[index].SetState("Running");
				bindingSource.ResetBindings(true);

				LogInfo.LogServiceAction( servicesInfo[index].DisplayName, LogInfo.Action.Ebabled );
			}
		}

		private void stopservice_Click(object sender, EventArgs e)
		{
			if (dataGridServices.SelectedRows.Count == 1)
			{
				int index = dataGridServices.SelectedRows[0].Index;
				ManagementBaseObject outParams = managmentObjects[index].InvokeMethod("StopService", null, null);
				servicesInfo[index].SetState("Stopped");
				bindingSource.ResetBindings(true);

				LogInfo.LogServiceAction( servicesInfo[index].DisplayName, ELogInfo.Action.Disabled );
			}
		}

		private void servicestarttype_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dataGridServices.SelectedRows.Count == 1)
			{
				int index = dataGridServices.SelectedRows[0].Index;
				string state = serviceStartType.SelectedItem as string;
				servicesInfo[index].SetStartMode(state);

				if (state == "Auto")
					state = "Automatic";

				changeMode(managmentObjects[index], state);
				dataGridServices.Invalidate();

				LogInfo.LogServiceChangeMode( servicesInfo[index].DisplayName, LogInfo.ServiceMode.Auto );
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            log.Show();

        }

        private void dataGridServices_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridServices.SelectedRows.Count == 1)
			{
                serviceStartType.SelectedItem = servicesInfo[dataGridServices.SelectedRows[0].Index].StartMode;
                LogInfo.LogServiceChangeMode(servicesInfo[0].DisplayName, LogInfo.ServiceMode.Manual);
                LogInfo.LogServiceChangeMode(servicesInfo[1].DisplayName, LogInfo.ServiceMode.Disabled);
            }
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            ManagementClass mcServices = new ManagementClass("Win32_Service");

            foreach (ManagementObject moService in mcServices.GetInstances())
            {
                string description = string.Empty;

                if (moService.GetPropertyValue("Description") != null)
                    description = moService.GetPropertyValue("Description").ToString();

                ServiceInfo i = new ServiceInfo(
                        moService.GetPropertyValue("Name").ToString(),
                        description,
                        moService.GetPropertyValue("Caption").ToString(),
                        moService.GetPropertyValue("ServiceType").ToString(),
                        moService.GetPropertyValue("StartMode").ToString(),
                        moService.GetPropertyValue("State").ToString()
                    );

                servicesInfo.Add(i);
                managmentObjects.Add(moService);
            }

            bindingSource.DataSource = servicesInfo;
            dataGridServices.DataSource = bindingSource;
        }

        private void changeMode(ManagementObject mo, string startmode)
        {
            ManagementBaseObject inParams = mo.GetMethodParameters("ChangeStartMode");
            inParams["startmode"] = startmode;
            ManagementBaseObject outParams = mo.InvokeMethod("ChangeStartMode", inParams, null);
            startmode = mo.Properties["StartMode"].Value.ToString().Trim();
        }



    }
}