using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Todo
{
    public partial class TagButton : UserControl
    {
        public TagButton(String text)
        {
            InitializeComponent();


            btn.Text = text;
        }
        public Color colorPrimary = Color.FromArgb(113, 96, 232);
        public Color colorPrimaryBorder = Color.FromArgb(120, 103, 239);
        public Color colorPrimaryDown = Color.FromArgb(107, 90, 216);
        public Color colorPrimaryOver = Color.FromArgb(123, 106, 242);



        public Color colorDull = Color.FromArgb(57, 57, 57);
        public Color colorDullBorder = Color.FromArgb(64, 64, 64);
        public Color colorDullDown = Color.FromArgb(56, 56, 56);
        public Color colorDullOver = Color.FromArgb(67, 67, 67);

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == colorPrimary)
            {
                ((Button)sender).BackColor = colorDull;
                ((Button)sender).FlatAppearance.BorderColor = colorDullBorder;
                ((Button)sender).FlatAppearance.MouseOverBackColor = colorDullOver;
                ((Button)sender).FlatAppearance.MouseDownBackColor = colorDullDown;
            }
            else
            {
                ((Button)sender).BackColor = colorPrimary;
                ((Button)sender).FlatAppearance.BorderColor = colorPrimaryBorder;
                ((Button)sender).FlatAppearance.MouseOverBackColor = colorPrimaryOver;
                ((Button)sender).FlatAppearance.MouseDownBackColor = colorPrimaryDown;

                Button1_Click(sender, e);


            }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        protected void Button1_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }



    }
}
