using OOAD_Project.Models;
using OOAD_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Project.Services
{
    public class ProjectService : BaseService
    {
        public ProjectService() : base()
        {         
        }

        public List<Project> GetProjectsOfUser(int user_id)
        {
            return projectRepository.GetProjectsOfUser(user_id);
        }

        public int CreateProjectAndAddUsersToProject(Project project, int ownerId)
        {
            int _projectId = projectRepository.InsertProject(ownerId, project);

            if (_projectId != -1)
            {
                memberRepository.InsertProjectMember(_projectId, ownerId);
            }
            return _projectId;
        }

        public string[] MapProjectListToStringArray(List<Project> projects)
        {
            List<string> results = new List<string>();
            foreach (Project project in projects)
            {
                results.Add(project.title);
            }
            return results.ToArray();
        }

        public Dictionary<string, int> MapifyProject(List<Project> projects)
        {
            Dictionary<string, int> projectNameId = new Dictionary<string, int>();
            foreach (Project project in projects)
            {
                projectNameId.Add(project.title, project.id);
            }
            return projectNameId;
        }

        public bool DeleteProject(int projectId)
        {
            return projectRepository.DeleteProject(projectId);
        }
    }
}
