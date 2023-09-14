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
            InitForm();

            Size = new Size()
            {
                Height = info.Window_height,
                Width = info.Window_width
            };
            Panel start_panel = new Panel();
            scenes.Add("Start_Panel", start_panel);

            scenes["Start_Panel"].Parent = this;
            
            Init_Panel("Start_Panel");

        }

        private void InitForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Padding = new Padding(0, 0, 0, 0);
            Margin = new Padding(0, 0, 0, 0);
        }
        public void Init_Panel(string name)
        {
            switch (name)
            {
                case "Start_Panel":
                    Panel panel = scenes[name];
                    panel.Size = Size;
                    panel.Location = new Point(0, 0);
                    panel.Padding = new Padding(0, 0, 0, 0);
                    panel.Margin = new Padding(0, 0, 0, 0);
                    panel.Dock = DockStyle.Fill;
                    panel.AutoSize = false;
                    panel.BackColor = Color.White;

                    Button Determine_Button = new()
                    {
                        Name = "DM_button",
                        Text = "Search!",
                        Size = new Size()
                        {
                            Height = info.DM_Button_height,
                            Width = info.DM_Button_width
                        },
                        Location = new Point()
                        {
                            X = (info.Window_width - info.DM_Button_width) / 2,
                            Y = (info.Window_height - info.DM_Button_height) / 2+100
                        },
                        Parent = panel,
                        Visible = true,
                        Padding = new Padding(0, 0, 0, 0),
                        Margin = new Padding(0, 0, 0, 0),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    MessageBox.Show($"doka {Height}");

                    MessageBox.Show($"doka {Width}");

                    MessageBox.Show($"{Determine_Button.Location.X}");

                    MessageBox.Show($"{Determine_Button.Location.Y}");

                    break;
            }
        }
    }
}
