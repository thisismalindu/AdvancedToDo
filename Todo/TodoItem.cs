using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class TodoItem : UserControl
    {
        public string[] tags = { };

        public TodoItem(String imageLocation, String title, String subtitle, String[]tags)
        {
            InitializeComponent();
            thumbnail.ImageLocation = imageLocation;
            this.title.Text = title;
            this.subtitle.Text = subtitle;
            this.tags = tags;
            foreach(String tag in tags)
            {

                filters.Controls.Add(new FilterButton(tag));
            }

        }

        private void completeTask_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
