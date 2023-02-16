using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_sort
{
    public partial class Mainwindow : Form
    {
        readonly Dictionary<string, Panel> scenes = new();
        public Mainwindow()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(600, 1000);

            Panel start_panel = new Panel();
            scenes.Add("Start_Panel",start_panel);

            start_panel.Dock = DockStyle.Fill;
            start_panel.Parent= this;

            InitPanel("Start_Panel");
        }

        public void InitPanel (string name)
        {
            switch (name)
            {
                case "Start_Panel":

                    break;
            }
        }
    }
}
