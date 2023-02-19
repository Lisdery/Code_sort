using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Code_sort
{
    public partial class Mainwindow : Form
    {
        readonly public Dictionary<string, Panel> scenes = new();
        public Mainwindow()
        {
            InitializeComponent();

            Panel start_panel = new Panel();
            scenes.Add("Start_Panel", start_panel);

            Init_Panel("Start_Panel");
            start_panel.Parent= this;
            this.Size = new System.Drawing.Size(400, 400);
        }

        public void Init_Panel(string name)
        {
            switch (name)
            {
                case "Stat_Panel":
                    Panel panel = scenes[name];
                    Button Determine_Button = new()
                    {
                    };
                    break;
            }
        }
    }
}
