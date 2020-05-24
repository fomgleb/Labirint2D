namespace Labirint2D
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.button_start = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.box_sound = new System.Windows.Forms.CheckBox();
            this.box_music = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(347, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(119, 51);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Начать игру";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(347, 362);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(119, 51);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Выйти";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // box_sound
            // 
            this.box_sound.AutoSize = true;
            this.box_sound.BackColor = System.Drawing.Color.Transparent;
            this.box_sound.Checked = true;
            this.box_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_sound.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_sound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.box_sound.Location = new System.Drawing.Point(37, 409);
            this.box_sound.Name = "box_sound";
            this.box_sound.Size = new System.Drawing.Size(67, 23);
            this.box_sound.TabIndex = 2;
            this.box_sound.Text = "Звук";
            this.box_sound.UseVisualStyleBackColor = false;
            this.box_sound.CheckedChanged += new System.EventHandler(this.Box_sound_CheckedChanged);
            // 
            // box_music
            // 
            this.box_music.AutoSize = true;
            this.box_music.BackColor = System.Drawing.Color.Transparent;
            this.box_music.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_music.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.box_music.Location = new System.Drawing.Point(37, 377);
            this.box_music.Name = "box_music";
            this.box_music.Size = new System.Drawing.Size(92, 23);
            this.box_music.TabIndex = 3;
            this.box_music.Text = "Музыка";
            this.box_music.UseVisualStyleBackColor = false;
            this.box_music.CheckedChanged += new System.EventHandler(this.Box_music_CheckedChanged);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirint2D.Properties.Resources.fon_pyatna_temnyy_91678_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_music);
            this.Controls.Add(this.box_sound);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirint2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.CheckBox box_sound;
        private System.Windows.Forms.CheckBox box_music;
    }
}

