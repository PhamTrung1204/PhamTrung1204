namespace Đồ_án_môn_DSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btn_Repeat = new System.Windows.Forms.Button();
            this.btn_Tuanhanh = new System.Windows.Forms.Button();
            this.btn_Tuavesau = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.lbl_Volume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lst_List = new System.Windows.Forms.ListBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.lbl_MediaPlayer = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_End = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(-1, -2);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(1253, 471);
            this.Player.TabIndex = 0;
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // grpControls
            // 
            this.grpControls.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpControls.Controls.Add(this.btn_Repeat);
            this.grpControls.Controls.Add(this.btn_Tuanhanh);
            this.grpControls.Controls.Add(this.btn_Tuavesau);
            this.grpControls.Controls.Add(this.btn_Delete);
            this.grpControls.Controls.Add(this.lbl_Percent);
            this.grpControls.Controls.Add(this.lbl_Volume);
            this.grpControls.Controls.Add(this.trackBar1);
            this.grpControls.Controls.Add(this.lst_List);
            this.grpControls.Controls.Add(this.btn_Open);
            this.grpControls.Controls.Add(this.btn_Pause);
            this.grpControls.Controls.Add(this.btn_Play);
            this.grpControls.Controls.Add(this.btn_Next);
            this.grpControls.Controls.Add(this.btn_Previous);
            this.grpControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpControls.Location = new System.Drawing.Point(-1, 405);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1253, 260);
            this.grpControls.TabIndex = 1;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // btn_Repeat
            // 
            this.btn_Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repeat.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Repeat.Location = new System.Drawing.Point(541, 22);
            this.btn_Repeat.Name = "btn_Repeat";
            this.btn_Repeat.Size = new System.Drawing.Size(91, 42);
            this.btn_Repeat.TabIndex = 6;
            this.btn_Repeat.Text = "Repeat";
            this.btn_Repeat.UseVisualStyleBackColor = true;
            this.btn_Repeat.Click += new System.EventHandler(this.btn_Repeat_Click);
            // 
            // btn_Tuanhanh
            // 
            this.btn_Tuanhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tuanhanh.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Tuanhanh.Location = new System.Drawing.Point(757, 22);
            this.btn_Tuanhanh.Name = "btn_Tuanhanh";
            this.btn_Tuanhanh.Size = new System.Drawing.Size(91, 42);
            this.btn_Tuanhanh.TabIndex = 5;
            this.btn_Tuanhanh.Text = "Before 10s";
            this.btn_Tuanhanh.UseVisualStyleBackColor = true;
            this.btn_Tuanhanh.Click += new System.EventHandler(this.btn_Tuanhanh_Click);
            // 
            // btn_Tuavesau
            // 
            this.btn_Tuavesau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tuavesau.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Tuavesau.Location = new System.Drawing.Point(868, 22);
            this.btn_Tuavesau.Name = "btn_Tuavesau";
            this.btn_Tuavesau.Size = new System.Drawing.Size(91, 42);
            this.btn_Tuavesau.TabIndex = 4;
            this.btn_Tuavesau.Text = "After 10s";
            this.btn_Tuavesau.UseVisualStyleBackColor = true;
            this.btn_Tuavesau.Click += new System.EventHandler(this.btn_Tuavesau_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Delete.Location = new System.Drawing.Point(6, 22);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(91, 42);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percent.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Percent.Location = new System.Drawing.Point(1157, 160);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(35, 20);
            this.lbl_Percent.TabIndex = 2;
            this.lbl_Percent.Text = "0%";
            this.lbl_Percent.Click += new System.EventHandler(this.lbl_Percent_Click);
            // 
            // lbl_Volume
            // 
            this.lbl_Volume.AutoSize = true;
            this.lbl_Volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Volume.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Volume.Location = new System.Drawing.Point(1100, 224);
            this.lbl_Volume.Name = "lbl_Volume";
            this.lbl_Volume.Size = new System.Drawing.Size(71, 20);
            this.lbl_Volume.TabIndex = 2;
            this.lbl_Volume.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1104, 117);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 104);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lst_List
            // 
            this.lst_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lst_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lst_List.FormattingEnabled = true;
            this.lst_List.ItemHeight = 16;
            this.lst_List.Location = new System.Drawing.Point(6, 80);
            this.lst_List.Name = "lst_List";
            this.lst_List.Size = new System.Drawing.Size(1023, 164);
            this.lst_List.TabIndex = 1;
            this.lst_List.SelectedIndexChanged += new System.EventHandler(this.lst_List_SelectedIndexChanged);
            // 
            // btn_Open
            // 
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Open.Location = new System.Drawing.Point(647, 22);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(91, 42);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Pause.Location = new System.Drawing.Point(328, 22);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(91, 42);
            this.btn_Pause.TabIndex = 0;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Play.Location = new System.Drawing.Point(219, 22);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(91, 42);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Next.Location = new System.Drawing.Point(434, 22);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(91, 42);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Previous.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Previous.Location = new System.Drawing.Point(112, 22);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(91, 42);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click_1);
            // 
            // lbl_MediaPlayer
            // 
            this.lbl_MediaPlayer.AutoSize = true;
            this.lbl_MediaPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MediaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MediaPlayer.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_MediaPlayer.Location = new System.Drawing.Point(12, -2);
            this.lbl_MediaPlayer.Name = "lbl_MediaPlayer";
            this.lbl_MediaPlayer.Size = new System.Drawing.Size(118, 20);
            this.lbl_MediaPlayer.TabIndex = 2;
            this.lbl_MediaPlayer.Text = "Media Player";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(98, 389);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1035, 10);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbl_Start
            // 
            this.lbl_Start.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Start.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Start.Location = new System.Drawing.Point(35, 385);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(57, 17);
            this.lbl_Start.TabIndex = 2;
            this.lbl_Start.Text = "00:00";
            this.lbl_Start.Click += new System.EventHandler(this.lbl_Start_Click);
            // 
            // lbl_End
            // 
            this.lbl_End.BackColor = System.Drawing.Color.Transparent;
            this.lbl_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_End.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_End.Location = new System.Drawing.Point(1160, 384);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(55, 18);
            this.lbl_End.TabIndex = 2;
            this.lbl_End.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1251, 677);
            this.Controls.Add(this.lbl_End);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_MediaPlayer);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.Player);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình phát nhạc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox lst_List;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label lbl_MediaPlayer;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.Label lbl_Volume;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Tuanhanh;
        private System.Windows.Forms.Button btn_Tuavesau;
        private System.Windows.Forms.Button btn_Repeat;
    }
}

