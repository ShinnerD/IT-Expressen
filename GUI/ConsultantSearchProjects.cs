using Interfaces.Models;
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
    public partial class ConsultantSearchProjects : Form
    {
        public IProjectModel Project { get; set; }
        public int ProjectId { get; set; }
        public List<string> ProjectSpecializations { get; set; }

        public ConsultantSearchProjects(int projectId)
        {
            InitializeComponent();
            ProjectId = projectId;
        }


    }
}
