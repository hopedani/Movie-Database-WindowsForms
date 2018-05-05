namespace Assignment2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtbISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lbLocation = new System.Windows.Forms.ListBox();
            this.lbGenre = new System.Windows.Forms.ListBox();
            this.mtbDuration = new System.Windows.Forms.MaskedTextBox();
            this.mtbPrice = new System.Windows.Forms.MaskedTextBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.nudMovieID = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipISBN = new System.Windows.Forms.ToolTip(this.components);
            this.tipMovieID = new System.Windows.Forms.ToolTip(this.components);
            this.tipMovieName = new System.Windows.Forms.ToolTip(this.components);
            this.tipDate = new System.Windows.Forms.ToolTip(this.components);
            this.tipLocation = new System.Windows.Forms.ToolTip(this.components);
            this.tipGenre = new System.Windows.Forms.ToolTip(this.components);
            this.tipRating = new System.Windows.Forms.ToolTip(this.components);
            this.tipDuration = new System.Windows.Forms.ToolTip(this.components);
            this.tipPrice = new System.Windows.Forms.ToolTip(this.components);
            this.tipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.tipUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.tipDelete = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(30, 18);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(72, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN Number";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(35, 47);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(67, 13);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Movie Name";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(35, 76);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lblReleaseDate.TabIndex = 2;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(59, 104);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(71, 138);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(69, 176);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(67, 232);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price $";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(33, 206);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 13);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration(mins)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(666, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtbISBN
            // 
            this.mtbISBN.Location = new System.Drawing.Point(108, 15);
            this.mtbISBN.Mask = "0000000000000";
            this.mtbISBN.Name = "mtbISBN";
            this.mtbISBN.Size = new System.Drawing.Size(86, 20);
            this.mtbISBN.TabIndex = 12;
            this.mtbISBN.Text = "0000000000000";
            this.mtbISBN.ValidatingType = typeof(int);
            this.mtbISBN.Validating += new System.ComponentModel.CancelEventHandler(this.mtbISBN_Validating);
            this.mtbISBN.Validated += new System.EventHandler(this.mtbISBN_Validated);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(108, 44);
            this.txtMovieName.MaxLength = 50;
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(200, 20);
            this.txtMovieName.TabIndex = 13;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(108, 70);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReleaseDate.TabIndex = 14;
            // 
            // lbLocation
            // 
            this.lbLocation.FormattingEnabled = true;
            this.lbLocation.Items.AddRange(new object[] {
            "Canadian",
            "International"});
            this.lbLocation.Location = new System.Drawing.Point(108, 102);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(120, 30);
            this.lbLocation.TabIndex = 15;
            // 
            // lbGenre
            // 
            this.lbGenre.FormattingEnabled = true;
            this.lbGenre.Items.AddRange(new object[] {
            "Action",
            "Biography",
            "Comedy",
            "Drama",
            "Educational",
            "History",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "Western"});
            this.lbGenre.Location = new System.Drawing.Point(108, 138);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(120, 30);
            this.lbGenre.TabIndex = 16;
            // 
            // mtbDuration
            // 
            this.mtbDuration.Location = new System.Drawing.Point(108, 200);
            this.mtbDuration.Mask = "000";
            this.mtbDuration.Name = "mtbDuration";
            this.mtbDuration.Size = new System.Drawing.Size(31, 20);
            this.mtbDuration.TabIndex = 22;
            this.mtbDuration.Text = "000";
            this.mtbDuration.ValidatingType = typeof(int);
            this.mtbDuration.Validating += new System.ComponentModel.CancelEventHandler(this.mtbDuration_Validating);
            this.mtbDuration.Validated += new System.EventHandler(this.mtbDuration_Validated);
            // 
            // mtbPrice
            // 
            this.mtbPrice.Location = new System.Drawing.Point(108, 229);
            this.mtbPrice.Mask = "00.00";
            this.mtbPrice.Name = "mtbPrice";
            this.mtbPrice.Size = new System.Drawing.Size(38, 20);
            this.mtbPrice.TabIndex = 23;
            this.mtbPrice.Text = "0000";
            this.mtbPrice.ValidatingType = typeof(int);
            this.mtbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPrice_Validating);
            this.mtbPrice.Validated += new System.EventHandler(this.mtbPrice_Validated);
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(108, 174);
            this.nudRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 20);
            this.nudRating.TabIndex = 24;
            this.nudRating.Tag = "Stars";
            this.nudRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 176);
            this.dataGridView1.TabIndex = 25;
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(222, 18);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(50, 13);
            this.lblMovieID.TabIndex = 26;
            this.lblMovieID.Text = "Movie ID";
            // 
            // nudMovieID
            // 
            this.nudMovieID.Location = new System.Drawing.Point(278, 16);
            this.nudMovieID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMovieID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMovieID.Name = "nudMovieID";
            this.nudMovieID.Size = new System.Drawing.Size(52, 20);
            this.nudMovieID.TabIndex = 27;
            this.nudMovieID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 261);
            this.Controls.Add(this.nudMovieID);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.mtbPrice);
            this.Controls.Add(this.mtbDuration);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.mtbISBN);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblISBN);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox mtbISBN;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.ListBox lbLocation;
        private System.Windows.Forms.ListBox lbGenre;
        private System.Windows.Forms.MaskedTextBox mtbDuration;
        private System.Windows.Forms.MaskedTextBox mtbPrice;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.NumericUpDown nudMovieID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ToolTip tipISBN;
        private System.Windows.Forms.ToolTip tipMovieID;
        private System.Windows.Forms.ToolTip tipMovieName;
        private System.Windows.Forms.ToolTip tipDate;
        private System.Windows.Forms.ToolTip tipLocation;
        private System.Windows.Forms.ToolTip tipGenre;
        private System.Windows.Forms.ToolTip tipRating;
        private System.Windows.Forms.ToolTip tipDuration;
        private System.Windows.Forms.ToolTip tipPrice;
        private System.Windows.Forms.ToolTip tipAdd;
        private System.Windows.Forms.ToolTip tipUpdate;
        private System.Windows.Forms.ToolTip tipDelete;
    }
}

