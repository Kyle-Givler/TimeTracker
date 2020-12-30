using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Models;

namespace TimeTrackerLibrary.Helpers
{
    public static class ProjectHelper
    {
        private static readonly IProjectData projectData = new ProjectData(GlobalConfig.Connection);

        public static async Task<List<ProjectModel>> LoadAllProjects()
        {
            var projects = await projectData.LoadAllProjects();
            projects.OrderBy(x => x.Name);

            return projects;
        }
    }
}
