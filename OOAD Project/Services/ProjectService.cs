using OOAD_Project.Models;
using System.Collections.Generic;

namespace OOAD_Project.Services
{
    public class ProjectService : BaseService
    {
        public ProjectService() : base()
        {
        }

        public List<Project> GetProjectsOfUser(int user_id)
        {
            return new List<Project>(projectRepository.GetAllByUserId(user_id));
        }

        public int CreateProjectAndAddUsersToProject(Project project, int ownerId)
        {
            project.ownerId = ownerId;
            Project p = projectRepository.Save(project);

            if (p.id != -1)
            {
                memberRepository.InsertProjectMember(p.id, ownerId);
            }
            return p.id;
        }

        public string[] MapProjectListToStringArray(List<Project> projects)
        {
            List<string> results = new List<string>();
            foreach (Project project in projects)
            {
                if (!results.Contains(project.title))
                {
                    results.Add(project.title);
                }
            }
            return results.ToArray();
        }

        public Dictionary<string, int> MapifyProject(List<Project> projects)
        {
            Dictionary<string, int> projectNameId = new Dictionary<string, int>();
            foreach (Project project in projects)
            {
                if (!projectNameId.ContainsKey(project.title))
                {
                    projectNameId.Add(project.title, project.id);
                }
            }
            return projectNameId;
        }

        public bool DeleteProject(int projectId)
        {
            return projectRepository.Delete(projectId);
        }
    }
}
