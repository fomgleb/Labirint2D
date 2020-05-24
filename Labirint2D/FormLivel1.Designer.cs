namespace Labirint2D
{
    partial class FormLevel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLevel1));
            this.label_finish = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_box1 = new System.Windows.Forms.Label();
            this.label_box2 = new System.Windows.Forms.Label();
            this.label_box3 = new System.Windows.Forms.Label();
            this.label_box4 = new System.Windows.Forms.Label();
            this.label_box5 = new System.Windows.Forms.Label();
            this.label_wall = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_finish
            // 
            this.label_finish.BackColor = System.Drawing.Color.Lime;
            this.label_finish.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_finish.Location = new System.Drawing.Point(1057, 811);
            this.label_finish.Name = "label_finish";
            this.label_finish.Size = new System.Drawing.Size(122, 50);
            this.label_finish.TabIndex = 0;
            this.label_finish.Text = "Финиш";
            this.label_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_finish.MouseEnter += new System.EventHandler(this.Label_finish_MouseEnter);
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.Aqua;
            this.label_start.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.Location = new System.Drawing.Point(262, 106);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(122, 50);
            this.label_start.TabIndex = 1;
            this.label_start.Text = "Старт";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(-40, 87);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(296, 801);
            this.label.TabIndex = 2;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1185, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 811);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-44, -104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1510, 201);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(114, 871);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1367, 175);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-3, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1054, 860);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseEnter += new System.EventHandler(this.Label4_MouseEnter);
            // 
            // label_box1
            // 
            this.label_box1.BackColor = System.Drawing.Color.Yellow;
            this.label_box1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_box1.Location = new System.Drawing.Point(578, 118);
            this.label_box1.Name = "label_box1";
            this.label_box1.Size = new System.Drawing.Size(27, 27);
            this.label_box1.TabIndex = 7;
            this.label_box1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_box1.MouseEnter += new System.EventHandler(this.Label_box1_MouseEnter);
            // 
            // label_box2
            // 
            this.label_box2.BackColor = System.Drawing.Color.Yellow;
            this.label_box2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_box2.Location = new System.Drawing.Point(892, 118);
            this.label_box2.Name = "label_box2";
            this.label_box2.Size = new System.Drawing.Size(27, 27);
            this.label_box2.TabIndex = 8;
            this.label_box2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_box2.MouseEnter += new System.EventHandler(this.Label_box1_MouseEnter);
            // 
            // label_box3
            // 
            this.label_box3.BackColor = System.Drawing.Color.Yellow;
            this.label_box3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_box3.Location = new System.Drawing.Point(1109, 118);
            this.label_box3.Name = "label_box3";
            this.label_box3.Size = new System.Drawing.Size(27, 27);
            this.label_box3.TabIndex = 9;
            this.label_box3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_box3.MouseEnter += new System.EventHandler(this.Label_box1_MouseEnter);
            // 
            // label_box4
            // 
            this.label_box4.BackColor = System.Drawing.Color.Yellow;
            this.label_box4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_box4.Location = new System.Drawing.Point(1109, 320);
            this.label_box4.Name = "label_box4";
            this.label_box4.Size = new System.Drawing.Size(27, 27);
            this.label_box4.TabIndex = 10;
            this.label_box4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_box4.MouseEnter += new System.EventHandler(this.Label_box1_MouseEnter);
            // 
            // label_box5
            // 
            this.label_box5.BackColor = System.Drawing.Color.Yellow;
            this.label_box5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_box5.Location = new System.Drawing.Point(1109, 552);
            this.label_box5.Name = "label_box5";
            this.label_box5.Size = new System.Drawing.Size(27, 27);
            this.label_box5.TabIndex = 11;
            this.label_box5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_box5.MouseEnter += new System.EventHandler(this.Label_box1_MouseEnter);
            // 
            // label_wall
            // 
            this.label_wall.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label_wall.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_wall.Location = new System.Drawing.Point(982, 165);
            this.label_wall.Name = "label_wall";
            this.label_wall.Size = new System.Drawing.Size(248, 42);
            this.label_wall.TabIndex = 12;
            this.label_wall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_wall.MouseEnter += new System.EventHandler(this.Label_wall_MouseEnter);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 986);
            this.Controls.Add(this.label_box5);
            this.Controls.Add(this.label_box4);
            this.Controls.Add(this.label_box3);
            this.Controls.Add(this.label_box2);
            this.Controls.Add(this.label_box1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_finish);
            this.Controls.Add(this.label_wall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLivel1";
            this.Shown += new System.EventHandler(this.FormLevel1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_finish;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_box1;
        private System.Windows.Forms.Label label_box2;
        private System.Windows.Forms.Label label_box3;
        private System.Windows.Forms.Label label_box4;
        private System.Windows.Forms.Label label_box5;
        private System.Windows.Forms.Label label_wall;
        private System.Windows.Forms.Timer timer;
    }
}