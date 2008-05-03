﻿namespace ViewModelComposition.Modules.Project.Services
{
    using System.Collections.ObjectModel;
using System.Collections.Generic;

    public class ProjectService : IProjectService
    {
        private Dictionary<int, ObservableCollection<BusinessEntities.Project>> projects;

        public ProjectService()
        {
            projects = new Dictionary<int, ObservableCollection<BusinessEntities.Project>>();

            ObservableCollection<BusinessEntities.Project> projectsEmployee1 = new ObservableCollection<BusinessEntities.Project>();

            BusinessEntities.Project project1 = new BusinessEntities.Project() { ProjectName = "Project 1", Role = "Architect" };
            BusinessEntities.Project project2 = new BusinessEntities.Project() { ProjectName = "Project 2", Role = "Developer" };

            projectsEmployee1.Add(project1);
            projectsEmployee1.Add(project2);

            projects.Add(1, projectsEmployee1);

            ObservableCollection<BusinessEntities.Project> projectsEmployee2 = new ObservableCollection<BusinessEntities.Project>();
            projectsEmployee2.Add(project1);
            projectsEmployee2.Add(project2);
            projectsEmployee2.Add(new BusinessEntities.Project() { ProjectName = "Project 3", Role = "Dev Lead" });

            projects.Add(2, projectsEmployee2);
        }

        public ObservableCollection<BusinessEntities.Project> RetrieveProjects(int employeeId)
        {
            if (projects.ContainsKey(employeeId))
                return projects[employeeId];

            return null;
        }
    }
}
