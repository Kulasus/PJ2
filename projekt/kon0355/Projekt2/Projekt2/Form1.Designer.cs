namespace Projekt2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.bts_sortAsc = new System.Windows.Forms.Button();
            this.btn_sortDesc = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.label_filename = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_isactive = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.numericUpDown_score = new System.Windows.Forms.NumericUpDown();
            this.radioButton_isActive_true = new System.Windows.Forms.RadioButton();
            this.radioButton_isActive_false = new System.Windows.Forms.RadioButton();
            this.radioButton_isActive_null = new System.Windows.Forms.RadioButton();
            this.label_controlPanel = new System.Windows.Forms.Label();
            this.label_saveLoad = new System.Windows.Forms.Label();
            this.label_find_main = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.label_find_child = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_score)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(417, 59);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(372, 535);
            this.textBox_data.TabIndex = 8;
            // 
            // bts_sortAsc
            // 
            this.bts_sortAsc.BackColor = System.Drawing.Color.RoyalBlue;
            this.bts_sortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bts_sortAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bts_sortAsc.Location = new System.Drawing.Point(417, 17);
            this.bts_sortAsc.Name = "bts_sortAsc";
            this.bts_sortAsc.Size = new System.Drawing.Size(186, 43);
            this.bts_sortAsc.TabIndex = 9;
            this.bts_sortAsc.Text = "Sort Ascendic";
            this.bts_sortAsc.UseVisualStyleBackColor = false;
            this.bts_sortAsc.Click += new System.EventHandler(this.bts_sortAsc_Click);
            // 
            // btn_sortDesc
            // 
            this.btn_sortDesc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_sortDesc.Location = new System.Drawing.Point(603, 17);
            this.btn_sortDesc.Name = "btn_sortDesc";
            this.btn_sortDesc.Size = new System.Drawing.Size(186, 43);
            this.btn_sortDesc.TabIndex = 10;
            this.btn_sortDesc.Text = "Sort Descending";
            this.btn_sortDesc.UseVisualStyleBackColor = false;
            this.btn_sortDesc.Click += new System.EventHandler(this.btn_sortDesc_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.Location = new System.Drawing.Point(218, 485);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 37);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_load.Location = new System.Drawing.Point(218, 536);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(123, 37);
            this.btn_load.TabIndex = 16;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(63, 495);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(131, 20);
            this.textBox_filename.TabIndex = 18;
            this.textBox_filename.TextChanged += new System.EventHandler(this.textBox_filename_TextChanged);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(63, 546);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(131, 20);
            this.textBox_path.TabIndex = 19;
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.BackColor = System.Drawing.Color.Transparent;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_path.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_path.Location = new System.Drawing.Point(59, 523);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(51, 20);
            this.label_path.TabIndex = 20;
            this.label_path.Text = "Path:";
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.BackColor = System.Drawing.Color.Transparent;
            this.label_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_filename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_filename.Location = new System.Drawing.Point(59, 472);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(87, 20);
            this.label_filename.TabIndex = 21;
            this.label_filename.Text = "Filename:";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(63, 71);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(278, 20);
            this.textBox_username.TabIndex = 0;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_changed);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_username.Location = new System.Drawing.Point(59, 48);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(96, 20);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_score.Location = new System.Drawing.Point(59, 101);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(61, 20);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "Score:";
            // 
            // label_isactive
            // 
            this.label_isactive.AutoSize = true;
            this.label_isactive.BackColor = System.Drawing.Color.Transparent;
            this.label_isactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_isactive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_isactive.Location = new System.Drawing.Point(59, 154);
            this.label_isactive.Name = "label_isactive";
            this.label_isactive.Size = new System.Drawing.Size(78, 20);
            this.label_isactive.TabIndex = 5;
            this.label_isactive.Text = "IsActive:";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_create.Location = new System.Drawing.Point(23, 215);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(123, 50);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_edit.Location = new System.Drawing.Point(152, 215);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(123, 50);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // numericUpDown_score
            // 
            this.numericUpDown_score.Location = new System.Drawing.Point(63, 125);
            this.numericUpDown_score.Name = "numericUpDown_score";
            this.numericUpDown_score.Size = new System.Drawing.Size(278, 20);
            this.numericUpDown_score.TabIndex = 11;
            // 
            // radioButton_isActive_true
            // 
            this.radioButton_isActive_true.AutoSize = true;
            this.radioButton_isActive_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_isActive_true.Location = new System.Drawing.Point(63, 177);
            this.radioButton_isActive_true.Name = "radioButton_isActive_true";
            this.radioButton_isActive_true.Size = new System.Drawing.Size(59, 24);
            this.radioButton_isActive_true.TabIndex = 12;
            this.radioButton_isActive_true.TabStop = true;
            this.radioButton_isActive_true.Text = "True";
            this.radioButton_isActive_true.UseVisualStyleBackColor = true;
            // 
            // radioButton_isActive_false
            // 
            this.radioButton_isActive_false.AutoSize = true;
            this.radioButton_isActive_false.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_isActive_false.Location = new System.Drawing.Point(128, 177);
            this.radioButton_isActive_false.Name = "radioButton_isActive_false";
            this.radioButton_isActive_false.Size = new System.Drawing.Size(66, 24);
            this.radioButton_isActive_false.TabIndex = 13;
            this.radioButton_isActive_false.TabStop = true;
            this.radioButton_isActive_false.Text = "False";
            this.radioButton_isActive_false.UseVisualStyleBackColor = true;
            // 
            // radioButton_isActive_null
            // 
            this.radioButton_isActive_null.AutoSize = true;
            this.radioButton_isActive_null.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_isActive_null.Location = new System.Drawing.Point(200, 177);
            this.radioButton_isActive_null.Name = "radioButton_isActive_null";
            this.radioButton_isActive_null.Size = new System.Drawing.Size(51, 24);
            this.radioButton_isActive_null.TabIndex = 14;
            this.radioButton_isActive_null.TabStop = true;
            this.radioButton_isActive_null.Text = "null";
            this.radioButton_isActive_null.UseVisualStyleBackColor = true;
            // 
            // label_controlPanel
            // 
            this.label_controlPanel.AutoSize = true;
            this.label_controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.label_controlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_controlPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_controlPanel.Location = new System.Drawing.Point(12, 17);
            this.label_controlPanel.Name = "label_controlPanel";
            this.label_controlPanel.Size = new System.Drawing.Size(150, 25);
            this.label_controlPanel.TabIndex = 22;
            this.label_controlPanel.Text = "Control Panel:";
            // 
            // label_saveLoad
            // 
            this.label_saveLoad.AutoSize = true;
            this.label_saveLoad.BackColor = System.Drawing.Color.Transparent;
            this.label_saveLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_saveLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_saveLoad.Location = new System.Drawing.Point(12, 438);
            this.label_saveLoad.Name = "label_saveLoad";
            this.label_saveLoad.Size = new System.Drawing.Size(124, 25);
            this.label_saveLoad.TabIndex = 23;
            this.label_saveLoad.Text = "Save/Load:";
            // 
            // label_find_main
            // 
            this.label_find_main.AutoSize = true;
            this.label_find_main.BackColor = System.Drawing.Color.Transparent;
            this.label_find_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_find_main.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_find_main.Location = new System.Drawing.Point(12, 303);
            this.label_find_main.Name = "label_find_main";
            this.label_find_main.Size = new System.Drawing.Size(196, 25);
            this.label_find_main.TabIndex = 24;
            this.label_find_main.Text = "Find By Username:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_delete.Location = new System.Drawing.Point(281, 215);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 50);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_find.Location = new System.Drawing.Point(218, 345);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(123, 50);
            this.btn_find.TabIndex = 26;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(63, 362);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(131, 20);
            this.textBox_find.TabIndex = 27;
            this.textBox_find.TextChanged += new System.EventHandler(this.textBox_find_TextChanged);
            // 
            // label_find_child
            // 
            this.label_find_child.AutoSize = true;
            this.label_find_child.BackColor = System.Drawing.Color.Transparent;
            this.label_find_child.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_find_child.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_find_child.Location = new System.Drawing.Point(59, 339);
            this.label_find_child.Name = "label_find_child";
            this.label_find_child.Size = new System.Drawing.Size(96, 20);
            this.label_find_child.TabIndex = 28;
            this.label_find_child.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(808, 609);
            this.Controls.Add(this.label_find_child);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label_find_main);
            this.Controls.Add(this.label_saveLoad);
            this.Controls.Add(this.label_controlPanel);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.radioButton_isActive_null);
            this.Controls.Add(this.radioButton_isActive_false);
            this.Controls.Add(this.radioButton_isActive_true);
            this.Controls.Add(this.numericUpDown_score);
            this.Controls.Add(this.btn_sortDesc);
            this.Controls.Add(this.bts_sortAsc);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label_isactive);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Name = "Form1";
            this.Text = "MyApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Button bts_sortAsc;
        private System.Windows.Forms.Button btn_sortDesc;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_isactive;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.NumericUpDown numericUpDown_score;
        private System.Windows.Forms.RadioButton radioButton_isActive_true;
        private System.Windows.Forms.RadioButton radioButton_isActive_false;
        private System.Windows.Forms.RadioButton radioButton_isActive_null;
        private System.Windows.Forms.Label label_controlPanel;
        private System.Windows.Forms.Label label_saveLoad;
        private System.Windows.Forms.Label label_find_main;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.Label label_find_child;
    }
}

