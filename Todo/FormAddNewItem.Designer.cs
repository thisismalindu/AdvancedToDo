namespace Todo
{
    partial class FormAddNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.defaultButton1 = new Todo.DefaultButton();
            this.completeTask = new System.Windows.Forms.Button();
            this.filters = new System.Windows.Forms.FlowLayoutPanel();
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.defaultButton2 = new Todo.DefaultButton();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtitle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tags:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(81, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(287, 29);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtSubtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtitle.ForeColor = System.Drawing.Color.White;
            this.txtSubtitle.Location = new System.Drawing.Point(81, 50);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(287, 29);
            this.txtSubtitle.TabIndex = 7;
            this.txtSubtitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTags
            // 
            this.txtTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTags.ForeColor = System.Drawing.Color.White;
            this.txtTags.Location = new System.Drawing.Point(81, 87);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(250, 29);
            this.txtTags.TabIndex = 8;
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtImageLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageLocation.ForeColor = System.Drawing.Color.White;
            this.txtImageLocation.Location = new System.Drawing.Point(81, 124);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(219, 29);
            this.txtImageLocation.TabIndex = 9;
            // 
            // defaultButton1
            // 
            this.defaultButton1.AutoSize = true;
            this.defaultButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.defaultButton1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defaultButton1.ForeColor = System.Drawing.Color.White;
            this.defaultButton1.Location = new System.Drawing.Point(306, 124);
            this.defaultButton1.Name = "defaultButton1";
            this.defaultButton1.Size = new System.Drawing.Size(62, 29);
            this.defaultButton1.TabIndex = 10;
            this.defaultButton1.Text = "Browse";
            this.defaultButton1.ButtonClick += new System.EventHandler(this.defaultButton1_ButtonClick);
            // 
            // completeTask
            // 
            this.completeTask.AutoSize = true;
            this.completeTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.completeTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.completeTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.completeTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.completeTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.completeTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeTask.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.completeTask.ForeColor = System.Drawing.Color.White;
            this.completeTask.Location = new System.Drawing.Point(0, 323);
            this.completeTask.Margin = new System.Windows.Forms.Padding(4);
            this.completeTask.Name = "completeTask";
            this.completeTask.Size = new System.Drawing.Size(298, 29);
            this.completeTask.TabIndex = 8;
            this.completeTask.Text = "";
            this.completeTask.UseVisualStyleBackColor = false;
            // 
            // filters
            // 
            this.filters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filters.AutoScroll = true;
            this.filters.AutoSize = true;
            this.filters.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filters.Location = new System.Drawing.Point(6, 283);
            this.filters.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.filters.MaximumSize = new System.Drawing.Size(1040, 70);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(286, 33);
            this.filters.TabIndex = 7;
            // 
            // subtitle
            // 
            this.subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtitle.Location = new System.Drawing.Point(6, 261);
            this.subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(45, 15);
            this.subtitle.TabIndex = 6;
            this.subtitle.Text = "Subtitle";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Variable Display", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(6, 236);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 22);
            this.title.TabIndex = 5;
            this.title.Text = "Title";
            // 
            // thumbnail
            // 
            this.thumbnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.thumbnail.Location = new System.Drawing.Point(0, 0);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(298, 226);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 1;
            this.thumbnail.TabStop = false;
            // 
            // pnlBase
            // 
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBase.Controls.Add(this.completeTask);
            this.pnlBase.Controls.Add(this.filters);
            this.pnlBase.Controls.Add(this.subtitle);
            this.pnlBase.Controls.Add(this.title);
            this.pnlBase.Controls.Add(this.thumbnail);
            this.pnlBase.Location = new System.Drawing.Point(387, 12);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(300, 354);
            this.pnlBase.TabIndex = 11;
            // 
            // defaultButton2
            // 
            this.defaultButton2.AutoSize = true;
            this.defaultButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.defaultButton2.ForeColor = System.Drawing.Color.White;
            this.defaultButton2.Location = new System.Drawing.Point(337, 87);
            this.defaultButton2.MaximumSize = new System.Drawing.Size(31, 29);
            this.defaultButton2.Name = "defaultButton2";
            this.defaultButton2.Size = new System.Drawing.Size(31, 29);
            this.defaultButton2.TabIndex = 0;
            this.defaultButton2.Text = ">";
            this.defaultButton2.ButtonClick += new System.EventHandler(this.defaultButton2_ButtonClick);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.AutoSize = true;
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnRemoveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(205, 181);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(80, 30);
            this.btnRemoveAll.TabIndex = 13;
            this.btnRemoveAll.Text = "Cancel";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(103)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(90)))), ((int)(((byte)(216)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(106)))), ((int)(((byte)(242)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(117, 181);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.defaultButton2);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.defaultButton1);
            this.Controls.Add(this.txtImageLocation);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.txtSubtitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddNewItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Item";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Button completeTask;
        public FlowLayoutPanel filters;
        public Label subtitle;
        public Label title;
        public PictureBox thumbnail;
        public Panel pnlBase;
        public Button btnRemoveAll;
        public Button btnAdd;
        public TextBox txtTitle;
        public TextBox txtSubtitle;
        public TextBox txtTags;
        public TextBox txtImageLocation;
        public DefaultButton defaultButton1;
        public DefaultButton defaultButton2;
    }
}