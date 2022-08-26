
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectTeamMembers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SelectedTeamMemberList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Team";
            // 
            // teamNameText
            // 
            this.teamNameText.Location = new System.Drawing.Point(356, 131);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(244, 31);
            this.teamNameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team Name";
            // 
            // selectTeamMembers
            // 
            this.selectTeamMembers.FormattingEnabled = true;
            this.selectTeamMembers.Location = new System.Drawing.Point(356, 187);
            this.selectTeamMembers.Name = "selectTeamMembers";
            this.selectTeamMembers.Size = new System.Drawing.Size(244, 33);
            this.selectTeamMembers.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Team";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addMember_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(146, 42);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(244, 31);
            this.FirstName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(146, 90);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(244, 31);
            this.LastName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Last Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(146, 140);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(244, 31);
            this.Email.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(146, 190);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(244, 31);
            this.PhoneNumber.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone Number";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(423, 55);
            this.button3.TabIndex = 27;
            this.button3.Text = "Create Team";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CreateTeam_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 55);
            this.button2.TabIndex = 28;
            this.button2.Text = "Create Member";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CreateMember_Click);
            // 
            // SelectedTeamMemberList
            // 
            this.SelectedTeamMemberList.FormattingEnabled = true;
            this.SelectedTeamMemberList.ItemHeight = 25;
            this.SelectedTeamMemberList.Location = new System.Drawing.Point(778, 121);
            this.SelectedTeamMemberList.Name = "SelectedTeamMemberList";
            this.SelectedTeamMemberList.Size = new System.Drawing.Size(293, 379);
            this.SelectedTeamMemberList.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PhoneNumber);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(210, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 315);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(778, 546);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 55);
            this.button4.TabIndex = 31;
            this.button4.Text = "Remove Selected";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 735);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectedTeamMemberList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectTeamMembers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectTeamMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox SelectedTeamMemberList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
    }
}