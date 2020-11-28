
namespace Minecraft_Building_Generator
{
    partial class mainform
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
            this.label_city_generator = new System.Windows.Forms.Label();
            this.groupbox_coordinates = new System.Windows.Forms.GroupBox();
            this.label_startcoordinate_x = new System.Windows.Forms.Label();
            this.textbox_startcoordinate_x = new System.Windows.Forms.TextBox();
            this.label_startcoordinate_y = new System.Windows.Forms.Label();
            this.textbox_startcoordinate_y = new System.Windows.Forms.TextBox();
            this.label_startcoordinate_z = new System.Windows.Forms.Label();
            this.textbox_startcoordinate_z = new System.Windows.Forms.TextBox();
            this.label_starting_coordinates = new System.Windows.Forms.Label();
            this.comboBox_direction = new System.Windows.Forms.ComboBox();
            this.label_which_direction = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_city_design = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_generate = new System.Windows.Forms.Button();
            this.tooltip_starting_coordinates = new System.Windows.Forms.ToolTip(this.components);
            this.groupbox_coordinates.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_city_generator
            // 
            this.label_city_generator.AutoSize = true;
            this.label_city_generator.Location = new System.Drawing.Point(12, 9);
            this.label_city_generator.Name = "label_city_generator";
            this.label_city_generator.Size = new System.Drawing.Size(463, 73);
            this.label_city_generator.TabIndex = 0;
            this.label_city_generator.Text = "City Generator";
            // 
            // groupbox_coordinates
            // 
            this.groupbox_coordinates.Controls.Add(this.label_which_direction);
            this.groupbox_coordinates.Controls.Add(this.comboBox_direction);
            this.groupbox_coordinates.Controls.Add(this.label_starting_coordinates);
            this.groupbox_coordinates.Controls.Add(this.textbox_startcoordinate_z);
            this.groupbox_coordinates.Controls.Add(this.label_startcoordinate_z);
            this.groupbox_coordinates.Controls.Add(this.textbox_startcoordinate_y);
            this.groupbox_coordinates.Controls.Add(this.label_startcoordinate_y);
            this.groupbox_coordinates.Controls.Add(this.textbox_startcoordinate_x);
            this.groupbox_coordinates.Controls.Add(this.label_startcoordinate_x);
            this.groupbox_coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_coordinates.Location = new System.Drawing.Point(25, 103);
            this.groupbox_coordinates.Name = "groupbox_coordinates";
            this.groupbox_coordinates.Size = new System.Drawing.Size(398, 175);
            this.groupbox_coordinates.TabIndex = 1;
            this.groupbox_coordinates.TabStop = false;
            this.groupbox_coordinates.Text = "Coordinates";
            // 
            // label_startcoordinate_x
            // 
            this.label_startcoordinate_x.AutoSize = true;
            this.label_startcoordinate_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startcoordinate_x.Location = new System.Drawing.Point(18, 58);
            this.label_startcoordinate_x.Name = "label_startcoordinate_x";
            this.label_startcoordinate_x.Size = new System.Drawing.Size(26, 18);
            this.label_startcoordinate_x.TabIndex = 0;
            this.label_startcoordinate_x.Text = "X :";
            // 
            // textbox_startcoordinate_x
            // 
            this.textbox_startcoordinate_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startcoordinate_x.Location = new System.Drawing.Point(50, 54);
            this.textbox_startcoordinate_x.MaxLength = 5;
            this.textbox_startcoordinate_x.Name = "textbox_startcoordinate_x";
            this.textbox_startcoordinate_x.Size = new System.Drawing.Size(55, 26);
            this.textbox_startcoordinate_x.TabIndex = 1;
            // 
            // label_startcoordinate_y
            // 
            this.label_startcoordinate_y.AutoSize = true;
            this.label_startcoordinate_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startcoordinate_y.Location = new System.Drawing.Point(128, 58);
            this.label_startcoordinate_y.Name = "label_startcoordinate_y";
            this.label_startcoordinate_y.Size = new System.Drawing.Size(25, 18);
            this.label_startcoordinate_y.TabIndex = 2;
            this.label_startcoordinate_y.Text = "Y :";
            // 
            // textbox_startcoordinate_y
            // 
            this.textbox_startcoordinate_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startcoordinate_y.Location = new System.Drawing.Point(160, 54);
            this.textbox_startcoordinate_y.MaxLength = 5;
            this.textbox_startcoordinate_y.Name = "textbox_startcoordinate_y";
            this.textbox_startcoordinate_y.Size = new System.Drawing.Size(55, 26);
            this.textbox_startcoordinate_y.TabIndex = 3;
            // 
            // label_startcoordinate_z
            // 
            this.label_startcoordinate_z.AutoSize = true;
            this.label_startcoordinate_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startcoordinate_z.Location = new System.Drawing.Point(240, 58);
            this.label_startcoordinate_z.Name = "label_startcoordinate_z";
            this.label_startcoordinate_z.Size = new System.Drawing.Size(25, 18);
            this.label_startcoordinate_z.TabIndex = 4;
            this.label_startcoordinate_z.Text = "Z :";
            // 
            // textbox_startcoordinate_z
            // 
            this.textbox_startcoordinate_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startcoordinate_z.Location = new System.Drawing.Point(271, 54);
            this.textbox_startcoordinate_z.MaxLength = 5;
            this.textbox_startcoordinate_z.Name = "textbox_startcoordinate_z";
            this.textbox_startcoordinate_z.Size = new System.Drawing.Size(55, 26);
            this.textbox_startcoordinate_z.TabIndex = 5;
            // 
            // label_starting_coordinates
            // 
            this.label_starting_coordinates.AutoSize = true;
            this.label_starting_coordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_starting_coordinates.Location = new System.Drawing.Point(15, 31);
            this.label_starting_coordinates.Name = "label_starting_coordinates";
            this.label_starting_coordinates.Size = new System.Drawing.Size(155, 20);
            this.label_starting_coordinates.TabIndex = 6;
            this.label_starting_coordinates.Text = "Starting Coordinates";
            this.tooltip_starting_coordinates.SetToolTip(this.label_starting_coordinates, "Provide the X, Y, and Z value where you wish the city to start generating");
            // 
            // comboBox_direction
            // 
            this.comboBox_direction.FormattingEnabled = true;
            this.comboBox_direction.Items.AddRange(new object[] {
            "North",
            "East",
            "South",
            "West"});
            this.comboBox_direction.Location = new System.Drawing.Point(19, 122);
            this.comboBox_direction.Name = "comboBox_direction";
            this.comboBox_direction.Size = new System.Drawing.Size(121, 32);
            this.comboBox_direction.TabIndex = 7;
            // 
            // label_which_direction
            // 
            this.label_which_direction.AutoSize = true;
            this.label_which_direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_which_direction.Location = new System.Drawing.Point(15, 99);
            this.label_which_direction.Name = "label_which_direction";
            this.label_which_direction.Size = new System.Drawing.Size(177, 20);
            this.label_which_direction.TabIndex = 8;
            this.label_which_direction.Text = "Build in which direction?";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_city_design);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(491, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 335);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_city_design
            // 
            this.tab_city_design.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tab_city_design.Location = new System.Drawing.Point(4, 25);
            this.tab_city_design.Name = "tab_city_design";
            this.tab_city_design.Padding = new System.Windows.Forms.Padding(3);
            this.tab_city_design.Size = new System.Drawing.Size(594, 306);
            this.tab_city_design.TabIndex = 0;
            this.tab_city_design.Text = "City Design";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generate.Location = new System.Drawing.Point(44, 295);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(134, 35);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            // 
            // tooltip_starting_coordinates
            // 
            this.tooltip_starting_coordinates.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_starting_coordinates.ToolTipTitle = "Starting Coordinates";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1527, 511);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.groupbox_coordinates);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_city_generator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Name = "mainform";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Minecraft City Generator";
            this.groupbox_coordinates.ResumeLayout(false);
            this.groupbox_coordinates.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_city_generator;
        private System.Windows.Forms.GroupBox groupbox_coordinates;
        private System.Windows.Forms.TextBox textbox_startcoordinate_z;
        private System.Windows.Forms.Label label_startcoordinate_z;
        private System.Windows.Forms.TextBox textbox_startcoordinate_y;
        private System.Windows.Forms.Label label_startcoordinate_y;
        private System.Windows.Forms.TextBox textbox_startcoordinate_x;
        private System.Windows.Forms.Label label_startcoordinate_x;
        private System.Windows.Forms.Label label_starting_coordinates;
        private System.Windows.Forms.Label label_which_direction;
        private System.Windows.Forms.ComboBox comboBox_direction;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_city_design;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.ToolTip tooltip_starting_coordinates;
    }
}

