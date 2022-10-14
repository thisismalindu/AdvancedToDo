using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Todo
{
    public partial class DefaultButton : UserControl
    {
        public DefaultButton()
        {
            InitializeComponent();
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return btnRemoveAll.Text; }
            set { btnRemoveAll.Text = value; }
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

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }
    }
}
