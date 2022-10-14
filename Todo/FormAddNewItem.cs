using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Todo
{
    public partial class FormAddNewItem : Form
    {
        public FormAddNewItem()
        {
            InitializeComponent();

        }


        public string[] tags = { };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            title.Text = txtTitle.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            subtitle.Text = txtSubtitle.Text;
        }

        private void defaultButton2_ButtonClick(object sender, EventArgs e)
        {
            filters.Controls.Clear();
            tags = txtTags.Text.Split('\u002C');
            foreach (String tag in tags)
            {
                filters.Controls.Add(new FilterButton(tag));
            }
        }

        private void defaultButton1_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG)| *.BMP; *.JPG; *.PNG | All files(*.*) | *.*";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                txtImageLocation.Text = openFileDialog.FileName;
                thumbnail.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitle.Text) || String.IsNullOrWhiteSpace(txtSubtitle.Text) || String.IsNullOrWhiteSpace(txtImageLocation.Text) || String.IsNullOrWhiteSpace(txtTags.Text))
            {
                MessageBox.Show("Please fill in the details in order to add an item.", "Insufficient Details");
            }
            else
            {

                tags = txtTags.Text.Split('\u002C');
                DialogResult = DialogResult.Continue;
                Close();
            }

        }
    }
}
