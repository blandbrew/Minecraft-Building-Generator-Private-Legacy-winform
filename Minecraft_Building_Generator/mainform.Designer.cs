
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.label_city_generator = new System.Windows.Forms.Label();
            this.groupbox_coordinates = new System.Windows.Forms.GroupBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.dynamic_label_generated_size = new System.Windows.Forms.Label();
            this.label_size_generated = new System.Windows.Forms.Label();
            this.comboBox_how_large = new System.Windows.Forms.ComboBox();
            this.label_how_large = new System.Windows.Forms.Label();
            this.label_starting_coordinates = new System.Windows.Forms.Label();
            this.textbox_startcoordinate_z = new System.Windows.Forms.TextBox();
            this.label_startcoordinate_z = new System.Windows.Forms.Label();
            this.textbox_startcoordinate_y = new System.Windows.Forms.TextBox();
            this.label_startcoordinate_y = new System.Windows.Forms.Label();
            this.textbox_startcoordinate_x = new System.Windows.Forms.TextBox();
            this.label_startcoordinate_x = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_behaviorpack = new System.Windows.Forms.TabPage();
            this.textBox_tab_minecraftversion_3 = new System.Windows.Forms.TextBox();
            this.textBox_tab_minecraftversion_2 = new System.Windows.Forms.TextBox();
            this.label_behaviorpack_info = new System.Windows.Forms.Label();
            this.label_tab_version = new System.Windows.Forms.Label();
            this.textBox_behaviorpack_version = new System.Windows.Forms.TextBox();
            this.label_tab_behaviorpack_description = new System.Windows.Forms.Label();
            this.label_f = new System.Windows.Forms.Label();
            this.textBox_tab_behaviorpack_description = new System.Windows.Forms.TextBox();
            this.textBox_tab_UUID = new System.Windows.Forms.TextBox();
            this.textBox_tab_minecraftversion_1 = new System.Windows.Forms.TextBox();
            this.label_tab_minecraftversion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_export_complete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_coordinates.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_behaviorpack.SuspendLayout();
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
            this.groupbox_coordinates.Controls.Add(this.label1);
            this.groupbox_coordinates.Controls.Add(this.label_export_complete);
            this.groupbox_coordinates.Controls.Add(this.button_generate);
            this.groupbox_coordinates.Controls.Add(this.dynamic_label_generated_size);
            this.groupbox_coordinates.Controls.Add(this.label_size_generated);
            this.groupbox_coordinates.Controls.Add(this.comboBox_how_large);
            this.groupbox_coordinates.Controls.Add(this.label_how_large);
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
            this.groupbox_coordinates.Size = new System.Drawing.Size(398, 263);
            this.groupbox_coordinates.TabIndex = 1;
            this.groupbox_coordinates.TabStop = false;
            this.groupbox_coordinates.Text = "Coordinates";
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generate.Location = new System.Drawing.Point(19, 222);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(134, 35);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // dynamic_label_generated_size
            // 
            this.dynamic_label_generated_size.AutoSize = true;
            this.dynamic_label_generated_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dynamic_label_generated_size.Location = new System.Drawing.Point(30, 161);
            this.dynamic_label_generated_size.Name = "dynamic_label_generated_size";
            this.dynamic_label_generated_size.Size = new System.Drawing.Size(14, 20);
            this.dynamic_label_generated_size.TabIndex = 11;
            this.dynamic_label_generated_size.Text = "-";
            // 
            // label_size_generated
            // 
            this.label_size_generated.AutoSize = true;
            this.label_size_generated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_size_generated.Location = new System.Drawing.Point(15, 141);
            this.label_size_generated.Name = "label_size_generated";
            this.label_size_generated.Size = new System.Drawing.Size(164, 20);
            this.label_size_generated.TabIndex = 10;
            this.label_size_generated.Text = "Total Size Generated:";
            // 
            // comboBox_how_large
            // 
            this.comboBox_how_large.FormattingEnabled = true;
            this.comboBox_how_large.Items.AddRange(new object[] {
            "1",
            "4",
            "9",
            "16",
            "25",
            "36",
            "49",
            "64",
            "81",
            "100",
            "121",
            "144",
            "169",
            "196"});
            this.comboBox_how_large.Location = new System.Drawing.Point(191, 93);
            this.comboBox_how_large.Name = "comboBox_how_large";
            this.comboBox_how_large.Size = new System.Drawing.Size(54, 32);
            this.comboBox_how_large.TabIndex = 9;
            this.comboBox_how_large.SelectedIndexChanged += new System.EventHandler(this.comboBox_how_large_SelectedIndexChanged);
            // 
            // label_how_large
            // 
            this.label_how_large.AutoSize = true;
            this.label_how_large.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_how_large.Location = new System.Drawing.Point(15, 99);
            this.label_how_large.Name = "label_how_large";
            this.label_how_large.Size = new System.Drawing.Size(170, 20);
            this.label_how_large.TabIndex = 8;
            this.label_how_large.Text = "How many containers?";
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
            // textbox_startcoordinate_y
            // 
            this.textbox_startcoordinate_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startcoordinate_y.Location = new System.Drawing.Point(160, 54);
            this.textbox_startcoordinate_y.MaxLength = 5;
            this.textbox_startcoordinate_y.Name = "textbox_startcoordinate_y";
            this.textbox_startcoordinate_y.Size = new System.Drawing.Size(55, 26);
            this.textbox_startcoordinate_y.TabIndex = 3;
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
            // textbox_startcoordinate_x
            // 
            this.textbox_startcoordinate_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_startcoordinate_x.Location = new System.Drawing.Point(50, 54);
            this.textbox_startcoordinate_x.MaxLength = 5;
            this.textbox_startcoordinate_x.Name = "textbox_startcoordinate_x";
            this.textbox_startcoordinate_x.Size = new System.Drawing.Size(55, 26);
            this.textbox_startcoordinate_x.TabIndex = 1;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_behaviorpack);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(481, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 416);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_behaviorpack
            // 
            this.tab_behaviorpack.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tab_behaviorpack.Controls.Add(this.textBox_tab_minecraftversion_3);
            this.tab_behaviorpack.Controls.Add(this.textBox_tab_minecraftversion_2);
            this.tab_behaviorpack.Controls.Add(this.label_behaviorpack_info);
            this.tab_behaviorpack.Controls.Add(this.label_tab_version);
            this.tab_behaviorpack.Controls.Add(this.textBox_behaviorpack_version);
            this.tab_behaviorpack.Controls.Add(this.label_tab_behaviorpack_description);
            this.tab_behaviorpack.Controls.Add(this.label_f);
            this.tab_behaviorpack.Controls.Add(this.textBox_tab_behaviorpack_description);
            this.tab_behaviorpack.Controls.Add(this.textBox_tab_UUID);
            this.tab_behaviorpack.Controls.Add(this.textBox_tab_minecraftversion_1);
            this.tab_behaviorpack.Controls.Add(this.label_tab_minecraftversion);
            this.tab_behaviorpack.Location = new System.Drawing.Point(4, 25);
            this.tab_behaviorpack.Name = "tab_behaviorpack";
            this.tab_behaviorpack.Padding = new System.Windows.Forms.Padding(3);
            this.tab_behaviorpack.Size = new System.Drawing.Size(554, 387);
            this.tab_behaviorpack.TabIndex = 0;
            this.tab_behaviorpack.Text = "Behavior Pack";
            // 
            // textBox_tab_minecraftversion_3
            // 
            this.textBox_tab_minecraftversion_3.Location = new System.Drawing.Point(224, 18);
            this.textBox_tab_minecraftversion_3.Name = "textBox_tab_minecraftversion_3";
            this.textBox_tab_minecraftversion_3.Size = new System.Drawing.Size(32, 23);
            this.textBox_tab_minecraftversion_3.TabIndex = 10;
            // 
            // textBox_tab_minecraftversion_2
            // 
            this.textBox_tab_minecraftversion_2.Location = new System.Drawing.Point(186, 18);
            this.textBox_tab_minecraftversion_2.Name = "textBox_tab_minecraftversion_2";
            this.textBox_tab_minecraftversion_2.Size = new System.Drawing.Size(32, 23);
            this.textBox_tab_minecraftversion_2.TabIndex = 9;
            // 
            // label_behaviorpack_info
            // 
            this.label_behaviorpack_info.AutoSize = true;
            this.label_behaviorpack_info.Location = new System.Drawing.Point(20, 190);
            this.label_behaviorpack_info.Name = "label_behaviorpack_info";
            this.label_behaviorpack_info.Size = new System.Drawing.Size(832, 170);
            this.label_behaviorpack_info.TabIndex = 8;
            this.label_behaviorpack_info.Text = resources.GetString("label_behaviorpack_info.Text");
            // 
            // label_tab_version
            // 
            this.label_tab_version.AutoSize = true;
            this.label_tab_version.Location = new System.Drawing.Point(86, 139);
            this.label_tab_version.Name = "label_tab_version";
            this.label_tab_version.Size = new System.Drawing.Size(60, 17);
            this.label_tab_version.TabIndex = 7;
            this.label_tab_version.Text = "Version:";
            // 
            // textBox_behaviorpack_version
            // 
            this.textBox_behaviorpack_version.Location = new System.Drawing.Point(148, 136);
            this.textBox_behaviorpack_version.Name = "textBox_behaviorpack_version";
            this.textBox_behaviorpack_version.Size = new System.Drawing.Size(100, 23);
            this.textBox_behaviorpack_version.TabIndex = 6;
            // 
            // label_tab_behaviorpack_description
            // 
            this.label_tab_behaviorpack_description.AutoSize = true;
            this.label_tab_behaviorpack_description.Location = new System.Drawing.Point(59, 76);
            this.label_tab_behaviorpack_description.Name = "label_tab_behaviorpack_description";
            this.label_tab_behaviorpack_description.Size = new System.Drawing.Size(83, 17);
            this.label_tab_behaviorpack_description.TabIndex = 5;
            this.label_tab_behaviorpack_description.Text = "Description:";
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Location = new System.Drawing.Point(51, 50);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(91, 17);
            this.label_f.TabIndex = 4;
            this.label_f.Text = "UUID (ver 1):";
            // 
            // textBox_tab_behaviorpack_description
            // 
            this.textBox_tab_behaviorpack_description.Location = new System.Drawing.Point(148, 76);
            this.textBox_tab_behaviorpack_description.Multiline = true;
            this.textBox_tab_behaviorpack_description.Name = "textBox_tab_behaviorpack_description";
            this.textBox_tab_behaviorpack_description.Size = new System.Drawing.Size(287, 53);
            this.textBox_tab_behaviorpack_description.TabIndex = 3;
            // 
            // textBox_tab_UUID
            // 
            this.textBox_tab_UUID.Location = new System.Drawing.Point(148, 47);
            this.textBox_tab_UUID.Name = "textBox_tab_UUID";
            this.textBox_tab_UUID.Size = new System.Drawing.Size(287, 23);
            this.textBox_tab_UUID.TabIndex = 2;
            // 
            // textBox_tab_minecraftversion_1
            // 
            this.textBox_tab_minecraftversion_1.Location = new System.Drawing.Point(148, 18);
            this.textBox_tab_minecraftversion_1.Name = "textBox_tab_minecraftversion_1";
            this.textBox_tab_minecraftversion_1.Size = new System.Drawing.Size(32, 23);
            this.textBox_tab_minecraftversion_1.TabIndex = 1;
            // 
            // label_tab_minecraftversion
            // 
            this.label_tab_minecraftversion.AutoSize = true;
            this.label_tab_minecraftversion.Location = new System.Drawing.Point(20, 21);
            this.label_tab_minecraftversion.Name = "label_tab_minecraftversion";
            this.label_tab_minecraftversion.Size = new System.Drawing.Size(119, 17);
            this.label_tab_minecraftversion.TabIndex = 0;
            this.label_tab_minecraftversion.Text = "Minimum Version:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label_export_complete
            // 
            this.label_export_complete.AutoSize = true;
            this.label_export_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_export_complete.Location = new System.Drawing.Point(184, 231);
            this.label_export_complete.Name = "label_export_complete";
            this.label_export_complete.Size = new System.Drawing.Size(0, 18);
            this.label_export_complete.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "each container is 169x169";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(38F, 73F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 511);
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
            this.tab_behaviorpack.ResumeLayout(false);
            this.tab_behaviorpack.PerformLayout();
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
        private System.Windows.Forms.Label label_how_large;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_behaviorpack;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox_tab_minecraftversion_1;
        private System.Windows.Forms.Label label_tab_minecraftversion;
        private System.Windows.Forms.Label label_f;
        private System.Windows.Forms.TextBox textBox_tab_behaviorpack_description;
        private System.Windows.Forms.TextBox textBox_tab_UUID;
        private System.Windows.Forms.Label label_tab_behaviorpack_description;
        private System.Windows.Forms.Label label_behaviorpack_info;
        private System.Windows.Forms.Label label_tab_version;
        private System.Windows.Forms.TextBox textBox_behaviorpack_version;
        private System.Windows.Forms.TextBox textBox_tab_minecraftversion_3;
        private System.Windows.Forms.TextBox textBox_tab_minecraftversion_2;
        private System.Windows.Forms.ComboBox comboBox_how_large;
        private System.Windows.Forms.Label dynamic_label_generated_size;
        private System.Windows.Forms.Label label_size_generated;
        private System.Windows.Forms.Label label_export_complete;
        private System.Windows.Forms.Label label1;
    }
}

