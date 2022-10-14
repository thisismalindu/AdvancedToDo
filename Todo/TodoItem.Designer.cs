namespace Todo
{
    partial class TodoItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBase = new System.Windows.Forms.Panel();
            this.completeTask = new System.Windows.Forms.Button();
            this.filters = new System.Windows.Forms.FlowLayoutPanel();
            this.subtitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBase.Controls.Add(this.completeTask);
            this.pnlBase.Controls.Add(this.filters);
            this.pnlBase.Controls.Add(this.subtitle);
            this.pnlBase.Controls.Add(this.title);
            this.pnlBase.Controls.Add(this.thumbnail);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(0, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(300, 354);
            this.pnlBase.TabIndex = 8;
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
            this.completeTask.Click += new System.EventHandler(this.completeTask_Click);
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
            // TodoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlBase);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Name = "TodoItem";
            this.Size = new System.Drawing.Size(300, 354);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel pnlBase;
        public Button completeTask;
        public FlowLayoutPanel filters;
        public Label subtitle;
        public Label title;
        public PictureBox thumbnail;
    }
}
