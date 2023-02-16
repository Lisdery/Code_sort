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
                Width = info.Window_width,
                Height = info.Window_height
            };
            Panel start_panel = new Panel();
            scenes.Add("Start_Panel",start_panel);

            start_panel.Dock = DockStyle.Fill;
            start_panel.Parent= this;

            InitPanel("Start_Panel");

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void InitPanel (string name)
        {
            switch (name)
            {
                case "Start_Panel":
                    Panel panel = scenes[name];

                    panel.Size = new Size
                    {
                        Width = this.Width,
                        Height = this.Height,
                    };

                    panel.Location = new Point
                    {
                        X = 0,
                        Y = 0,
                    };

                    Button Determine = new()
                    {
                        Size = new Size
                        {
                            Width = info.DM_Button_width,
                            Height = info.DM_Button_height
                        },
                        Location = new Point
                        {
                            X = (Width - info.DM_Button_width) / 2,
                            Y = (Height - 100)
                        },
                        Parent = panel,
                    };
                    MessageBox.Show($"Width:{this.Width} Height: {this.Height}");
                    MessageBox.Show($"Width:{panel.Size.Width} Height: {panel.Size.Height}");
                    MessageBox.Show($"Width:{Determine.Size.Width} Height: {Determine.Size.Height}");
                    break;
            }
        }

        private void Mainwindow_Load(object sender, EventArgs e)
        {

        }
    }
}
