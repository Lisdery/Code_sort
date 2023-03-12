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

using info=Code_sort.GlobalInfo;

namespace Code_sort
{
    public partial class Mainwindow : Form
    {
        readonly public Dictionary<string, Panel> scenes = new();
        public Mainwindow()
        {
            InitializeComponent();
            this.Size = new Size()
            {
                Height = info.Window_height,
                Width = info.Window_width
            };

            Panel start_panel = new Panel()
            {
                Parent = this,
                Size = this.Size,
                Padding = new Padding(0, 0, 0, 0),
                Location = new Point(0,0),
            };

            scenes.Add("Start_Panel", start_panel);

            Init_Panel("Start_Panel");
        }

        public void Init_Panel(string name)
        {
            switch (name)
            {
                case "Start_Panel":
                    Panel panel = scenes[name];

                    MessageBox.Show($"{panel.Location.X}");

                    MessageBox.Show($"{panel.Location.Y}");

                    Button Determine_Button = new()
                    {
                        Name = "DM_button",
                        Parent = panel,
                        Text = "Search!",
                        Visible = true,
                        Padding = new Padding(0,0,0,0),
                        Location = new Point()
                        {
                            X = (info.Window_height - info.DM_Button_height)/2,
                            Y = (info.Window_width - info.DM_Button_width)/2
                        },
                        Size = new Size()
                        {
                            Height = info.DM_Button_height,
                            Width = info.DM_Button_width
                        }
                    };
                    MessageBox.Show($"{panel.Size.Height}");

                    MessageBox.Show($"{panel.Size.Width}");

                    MessageBox.Show($"{Determine_Button.Location.X}");

                    MessageBox.Show($"{Determine_Button.Location.Y}");

                    break;
            }
        }
    }
}
