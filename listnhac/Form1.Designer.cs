﻿namespace listnhac
{
    partial class frmMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedia));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnNoPlaying = new System.Windows.Forms.Button();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.colMusic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMusic = new System.Windows.Forms.Label();
            this.playMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabVideos = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvVideos = new System.Windows.Forms.DataGridView();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblVideo = new System.Windows.Forms.Label();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_trackend = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.tab.SuspendLayout();
            this.tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).BeginInit();
            this.tabVideos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).BeginInit();
            this.panelPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMenu.Controls.Add(this.splitter1);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnSelectSong);
            this.panelMenu.Controls.Add(this.btnPlaylist);
            this.panelMenu.Controls.Add(this.btnVideo);
            this.panelMenu.Controls.Add(this.lblUser);
            this.panelMenu.Controls.Add(this.btnNoPlaying);
            this.panelMenu.Controls.Add(this.picAvt);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 541);
            this.panelMenu.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 541);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSetting.Location = new System.Drawing.Point(0, 508);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(192, 31);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Settings...";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSong.FlatAppearance.BorderSize = 0;
            this.btnSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSong.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSelectSong.Location = new System.Drawing.Point(51, 225);
            this.btnSelectSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(146, 31);
            this.btnSelectSong.TabIndex = 5;
            this.btnSelectSong.Text = "SelectSong";
            this.btnSelectSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectSong.UseVisualStyleBackColor = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPlaylist.Location = new System.Drawing.Point(49, 261);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(146, 31);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "Playlists";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnVideo.Location = new System.Drawing.Point(49, 189);
            this.btnVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(146, 31);
            this.btnVideo.TabIndex = 3;
            this.btnVideo.Text = "Videos";
            this.btnVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideo.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Purple;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(46, 89);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 19);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Media App";
            // 
            // btnNoPlaying
            // 
            this.btnNoPlaying.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNoPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoPlaying.Enabled = false;
            this.btnNoPlaying.FlatAppearance.BorderSize = 0;
            this.btnNoPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoPlaying.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNoPlaying.Location = new System.Drawing.Point(49, 154);
            this.btnNoPlaying.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoPlaying.Name = "btnNoPlaying";
            this.btnNoPlaying.Size = new System.Drawing.Size(146, 31);
            this.btnNoPlaying.TabIndex = 1;
            this.btnNoPlaying.Text = "Home...";
            this.btnNoPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoPlaying.UseVisualStyleBackColor = false;
            // 
            // picAvt
            // 
            this.picAvt.BackgroundImage = global::listnhac.Properties.Resources.Screenshot_2024_11_03_221943;
            this.picAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvt.ErrorImage = null;
            this.picAvt.InitialImage = null;
            this.picAvt.Location = new System.Drawing.Point(53, 16);
            this.picAvt.Margin = new System.Windows.Forms.Padding(2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(62, 53);
            this.picAvt.TabIndex = 0;
            this.picAvt.TabStop = false;
            // 
            // tab
            // 
            this.tab.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab.Controls.Add(this.tabMusic);
            this.tab.Controls.Add(this.tabVideos);
            this.tab.Location = new System.Drawing.Point(196, 2);
            this.tab.Margin = new System.Windows.Forms.Padding(2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(554, 475);
            this.tab.TabIndex = 1;
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.btnDelete);
            this.tabMusic.Controls.Add(this.cmbSort);
            this.tabMusic.Controls.Add(this.btnExit);
            this.tabMusic.Controls.Add(this.btnAdd);
            this.tabMusic.Controls.Add(this.btnShuffle);
            this.tabMusic.Controls.Add(this.dgvMusic);
            this.tabMusic.Controls.Add(this.lblMusic);
            this.tabMusic.Controls.Add(this.playMusic);
            this.tabMusic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabMusic.Location = new System.Drawing.Point(4, 4);
            this.tabMusic.Margin = new System.Windows.Forms.Padding(2);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(2);
            this.tabMusic.Size = new System.Drawing.Size(546, 449);
            this.tabMusic.TabIndex = 0;
            this.tabMusic.Text = "Playing";
            this.tabMusic.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(332, 72);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(152, 80);
            this.cmbSort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(78, 21);
            this.cmbSort.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnExit.BackgroundImage = global::listnhac.Properties.Resources.reject;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(513, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(22, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(427, 71);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Music";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Purple;
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(10, 72);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(2);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(118, 31);
            this.btnShuffle.TabIndex = 11;
            this.btnShuffle.Text = "Shuffle and play";
            this.btnShuffle.UseVisualStyleBackColor = false;
            // 
            // dgvMusic
            // 
            this.dgvMusic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMusic,
            this.colLink});
            this.dgvMusic.Location = new System.Drawing.Point(0, 155);
            this.dgvMusic.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.RowHeadersWidth = 51;
            this.dgvMusic.RowTemplate.Height = 24;
            this.dgvMusic.Size = new System.Drawing.Size(538, 290);
            this.dgvMusic.TabIndex = 10;
            // 
            // colMusic
            // 
            this.colMusic.HeaderText = "Music";
            this.colMusic.MinimumWidth = 6;
            this.colMusic.Name = "colMusic";
            // 
            // colLink
            // 
            this.colLink.HeaderText = "Nguồn";
            this.colLink.MinimumWidth = 6;
            this.colLink.Name = "colLink";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.Location = new System.Drawing.Point(2, 11);
            this.lblMusic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(123, 51);
            this.lblMusic.TabIndex = 9;
            this.lblMusic.Text = "Music";
            // 
            // playMusic
            // 
            this.playMusic.Enabled = true;
            this.playMusic.Location = new System.Drawing.Point(43, 454);
            this.playMusic.Margin = new System.Windows.Forms.Padding(2);
            this.playMusic.Name = "playMusic";
            this.playMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playMusic.OcxState")));
            this.playMusic.Size = new System.Drawing.Size(524, 44);
            this.playMusic.TabIndex = 8;
            // 
            // tabVideos
            // 
            this.tabVideos.Controls.Add(this.button5);
            this.tabVideos.Controls.Add(this.dgvVideos);
            this.tabVideos.Controls.Add(this.btnAddVideo);
            this.tabVideos.Controls.Add(this.btnRemoveVideo);
            this.tabVideos.Controls.Add(this.comboBox1);
            this.tabVideos.Controls.Add(this.btnAll);
            this.tabVideos.Controls.Add(this.lblVideo);
            this.tabVideos.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabVideos.Location = new System.Drawing.Point(4, 4);
            this.tabVideos.Margin = new System.Windows.Forms.Padding(2);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Padding = new System.Windows.Forms.Padding(2);
            this.tabVideos.Size = new System.Drawing.Size(546, 449);
            this.tabVideos.TabIndex = 1;
            this.tabVideos.Text = "Videos";
            this.tabVideos.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button5.BackgroundImage = global::listnhac.Properties.Resources.reject;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Location = new System.Drawing.Point(523, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 24);
            this.button5.TabIndex = 19;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dgvVideos
            // 
            this.dgvVideos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideos.Location = new System.Drawing.Point(4, 146);
            this.dgvVideos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVideos.Name = "dgvVideos";
            this.dgvVideos.RowHeadersWidth = 51;
            this.dgvVideos.RowTemplate.Height = 24;
            this.dgvVideos.Size = new System.Drawing.Size(534, 298);
            this.dgvVideos.TabIndex = 18;
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVideo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVideo.Location = new System.Drawing.Point(432, 76);
            this.btnAddVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(93, 32);
            this.btnAddVideo.TabIndex = 16;
            this.btnAddVideo.Text = "Add Video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveVideo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVideo.Location = new System.Drawing.Point(352, 76);
            this.btnRemoveVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(76, 32);
            this.btnRemoveVideo.TabIndex = 15;
            this.btnRemoveVideo.Text = "Remove";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(448, 113);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Purple;
            this.btnAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(21, 72);
            this.btnAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(94, 31);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "Play all";
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(2, 11);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(122, 51);
            this.lblVideo.TabIndex = 10;
            this.lblVideo.Text = "Video";
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.Purple;
            this.panelPlay.Controls.Add(this.btnPlay);
            this.panelPlay.Controls.Add(this.btnStop);
            this.panelPlay.Controls.Add(this.btnPrevious);
            this.panelPlay.Controls.Add(this.btnNext);
            this.panelPlay.Controls.Add(this.btnPause);
            this.panelPlay.Controls.Add(this.lblTimeStart);
            this.panelPlay.Controls.Add(this.lblTimeEnd);
            this.panelPlay.Controls.Add(this.p_bar);
            this.panelPlay.Controls.Add(this.trackBar1);
            this.panelPlay.Controls.Add(this.lbl_trackend);
            this.panelPlay.Controls.Add(this.btnChon);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelPlay.Location = new System.Drawing.Point(196, 481);
            this.panelPlay.Margin = new System.Windows.Forms.Padding(2);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(554, 60);
            this.panelPlay.TabIndex = 7;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Purple;
            this.btnPlay.BackgroundImage = global::listnhac.Properties.Resources.play1;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.Purple;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlay.Location = new System.Drawing.Point(154, 19);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 30);
            this.btnPlay.TabIndex = 32;
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Purple;
            this.btnStop.BackgroundImage = global::listnhac.Properties.Resources.play_pause;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Purple;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStop.Location = new System.Drawing.Point(220, 20);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(34, 29);
            this.btnStop.TabIndex = 31;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Purple;
            this.btnPrevious.BackgroundImage = global::listnhac.Properties.Resources.rewind;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.Purple;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.Location = new System.Drawing.Point(114, 20);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(36, 29);
            this.btnPrevious.TabIndex = 30;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Purple;
            this.btnNext.BackgroundImage = global::listnhac.Properties.Resources.forward;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Purple;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(259, 20);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 30);
            this.btnNext.TabIndex = 29;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Purple;
            this.btnPause.BackgroundImage = global::listnhac.Properties.Resources.pause__1____Copy1;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.Purple;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPause.Location = new System.Drawing.Point(184, 19);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(32, 30);
            this.btnPause.TabIndex = 28;
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.ForeColor = System.Drawing.Color.White;
            this.lblTimeStart.Location = new System.Drawing.Point(9, 2);
            this.lblTimeStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(34, 13);
            this.lblTimeStart.TabIndex = 26;
            this.lblTimeStart.Text = "00:00";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.ForeColor = System.Drawing.Color.White;
            this.lblTimeEnd.Location = new System.Drawing.Point(398, 2);
            this.lblTimeEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(34, 13);
            this.lblTimeEnd.TabIndex = 25;
            this.lblTimeEnd.Text = "00:00";
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(46, 9);
            this.p_bar.Margin = new System.Windows.Forms.Padding(2);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(346, 5);
            this.p_bar.TabIndex = 21;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(435, 6);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(106, 45);
            this.trackBar1.TabIndex = 24;
            // 
            // lbl_trackend
            // 
            this.lbl_trackend.AutoSize = true;
            this.lbl_trackend.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trackend.ForeColor = System.Drawing.Color.Black;
            this.lbl_trackend.Location = new System.Drawing.Point(731, -6);
            this.lbl_trackend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_trackend.Name = "lbl_trackend";
            this.lbl_trackend.Size = new System.Drawing.Size(60, 19);
            this.lbl_trackend.TabIndex = 23;
            this.lbl_trackend.Text = "00:00";
            // 
            // btnChon
            // 
            this.btnChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChon.Location = new System.Drawing.Point(704, 24);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(8, 8);
            this.btnChon.TabIndex = 20;
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(750, 541);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMedia";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabMusic.ResumeLayout(false);
            this.tabMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMusic)).EndInit();
            this.tabVideos.ResumeLayout(false);
            this.tabVideos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).EndInit();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.Button btnNoPlaying;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSelectSong;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.TabPage tabVideos;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Label lbl_trackend;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer playMusic;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Button btnRemoveVideo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.DataGridView dgvVideos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMusic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLink;
    }
}

