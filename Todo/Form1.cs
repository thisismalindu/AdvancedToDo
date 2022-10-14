namespace Todo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public string[] tags = {};

        public Color colorPrimary = Color.FromArgb(113, 96, 232);
        public Color colorPrimaryBorder = Color.FromArgb(120, 103, 239);
        public Color colorPrimaryDown = Color.FromArgb(107, 90, 216);
        public Color colorPrimaryOver = Color.FromArgb(123, 106, 242);



        public Color colorDull = Color.FromArgb(57, 57, 57);
        public Color colorDullBorder = Color.FromArgb(64, 64, 64);
        public Color colorDullDown = Color.FromArgb(56, 56, 56);
        public Color colorDullOver = Color.FromArgb(67, 67, 67);
        private void button1_Click(object sender, EventArgs e)
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


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            foreach (TagButton btn in flowFilters.Controls.OfType<TagButton>())
            {
                btn.BackColor = colorDull;
                btn.btn.FlatAppearance.BorderColor = colorDullBorder;
                btn.btn.FlatAppearance.MouseOverBackColor = colorDullOver;
                btn.btn.FlatAppearance.MouseDownBackColor = colorDullDown;
            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddNewItem formAddNewItem = new FormAddNewItem();
            if (formAddNewItem.ShowDialog() == DialogResult.Continue)
            {
                flowTodoList.Controls.Add(new TodoItem(formAddNewItem.txtImageLocation.Text, formAddNewItem.txtTitle.Text, formAddNewItem.txtSubtitle.Text, formAddNewItem.tags));

                foreach (string tag in formAddNewItem.tags)
                {
                    if (Array.IndexOf(tags, tag) == -1)
                    {
                        tags.Append(tag);
                        renderTags(tag);
                    }
                    
                }
            }

        }

        private void renderTags(string tag)
        {
            TagButton tagButton = new TagButton(tag);
            tagButton.ButtonClick += TagButton_ButtonClick;
            flowFilters.Controls.Add(new TagButton(tag));

            
        }


        private void TagButton_ButtonClick(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            flowTodoList.Controls.Clear();
            MessageBox.Show("Remove All");
        }

    }
}