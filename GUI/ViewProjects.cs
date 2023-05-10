using DAL.Linq;
using Domain.Services;
using Interfaces.Models;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ViewProjects : Form
    {
        IProjectService projectService = new Domain.Services.ProjectService();

        public int userId { get; set; }

        public ViewProjects(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            ProjectsForManager();
        }

        private void ProjectsForManager()
        {
            var projects = dbContext.Projects.Where(p => p.User_ID == userId);
            dgv_Viewproject.DataSource = projects.ToList();

        }

        private void dgv_Viewproject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProjectsForManager();
        }
    }
}
