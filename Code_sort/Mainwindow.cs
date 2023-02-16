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
using info = Code_sort.GlobalInfo;

namespace Code_sort
{
    public partial class Mainwindow : Form
    {
        readonly Dictionary<string, Panel> scenes = new();
        public Mainwindow()
        {
            InitializeComponent();

            this.Size = new Size()
            {
                X = info.Window_width,
                Y = info.Window_height,
            };
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
                    Panel panel = scenes[name];

                    Button Determine = new()
                    {
                        Size = new Size
                        {
                            X=
                        },
                        Location = new Point(50, 800),
                    };
                    break;
            }
        }
    }
}
