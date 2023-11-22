using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Đồ_án_môn_DSA
{
    public partial class Form1 : Form
    {
        private LinkedList<string> playlist = new LinkedList<string>();
        private LinkedListNode<string> currentSongNode;

        public Form1()
        {
            InitializeComponent();
            progressBar1.MouseClick += progressBar1_Click;
        }
        string[] files, paths;
        private void lst_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_MediaPlayer.Text = "Preparing...";
            Player.Ctlcontrols.play();
            timer1.Start();
            trackBar1.Value = 15;
            lbl_Percent.Text = trackBar1.Value.ToString() + "%";
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            PlaySelectedSong();
        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }
        private void PlaySelectedSong()
        {
            if (lst_List.SelectedIndex >= 0 && lst_List.SelectedIndex < lst_List.Items.Count)
            {
                Player.URL = paths[lst_List.SelectedIndex];
                Player.Ctlcontrols.play();
                lbl_MediaPlayer.Text = "Playing...";
                currentSongNode = playlist.Find(paths[lst_List.SelectedIndex]);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = trackBar1.Value;
            lbl_Percent.Text = trackBar1.Value.ToString() + "%";

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
            lbl_MediaPlayer.Text = "Pause";
        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void PlayNextSong()
        {
            if (currentSongNode != null && currentSongNode.Next != null)
            {
                currentSongNode = currentSongNode.Next;
                lst_List.SelectedIndex = playlist.ToList().IndexOf(currentSongNode.Value);
                PlaySelectedSong();
            }
            else if (currentSongNode != null && currentSongNode.Next == null)
            {
                currentSongNode = currentSongNode.Next;
            }
        }
        private void btn_Previous_Click_1(object sender, EventArgs e)
        {
            if (lst_List.SelectedIndex > 0)
            {
                // Giảm chỉ mục của bài hát hiện tại
                lst_List.SelectedIndex = lst_List.SelectedIndex - 1;

                // Phát bài hát mới
                PlaySelectedSong();
            }
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả bài hát này khỏi danh sách?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lst_List.Items.Clear();
                playlist.Clear();
                Player.Ctlcontrols.stop();
                lbl_MediaPlayer.Text = "Stop";
                timer1.Stop(); // Dừng đồng hồ
                progressBar1.Value = 0;
                lbl_Start.Text = "00:00";
                lbl_End.Text = "00:00";
            }

        }



        private void btn_Tuanhanh_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.currentPosition -= 10;
        }
        private void btn_Tuavesau_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.currentPosition += 10;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lbl_Percent_Click(object sender, EventArgs e)
        {

        }
        private void lbl_Start_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double currentPosition = Player.Ctlcontrols.currentPosition;
                double totalDuration = Player.Ctlcontrols.currentItem.duration;

                progressBar1.Maximum = (int)totalDuration;
                progressBar1.Value = (int)currentPosition;

                TimeSpan currentTime = TimeSpan.FromSeconds(currentPosition);
                lbl_Start.Text = string.Format("{0:D2}:{1:D2}", currentTime.Minutes, currentTime.Seconds);

                TimeSpan totalDurationTime = TimeSpan.FromSeconds(totalDuration);
                lbl_End.Text = string.Format("{0:D2}:{1:D2}", totalDurationTime.Minutes, totalDurationTime.Seconds);

            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Nếu bài hát kết thúc, tự động chuyển đến bài hát tiếp theo
                PlayNextSong();
            }
        }

        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                Player.Ctlcontrols.currentPosition = 0;
            }
            PlaySelectedSong();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                // Thêm từng bài hát vào danh sách liên kết
                for (int i = 0; i < files.Length; i++)
                {
                    // Thêm vào danh sách liên kết
                    playlist.AddLast(paths[i]);

                    // Thêm vào danh sách hiển thị
                    lst_List.Items.Add(files[i]);
                }
            }
        }
    }
}
