namespace client
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_sendmessage = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.friendListBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.friendRequestsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_reject = new System.Windows.Forms.Button();
            this.button_invite = new System.Windows.Forms.Button();
            this.button_reflesh = new System.Windows.Forms.Button();
            this.button_send_friends = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.comboBox_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(198, 26);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(375, 115);
            this.logBox.TabIndex = 14;
            this.logBox.Text = "";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(59, 123);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(133, 23);
            this.button_connect.TabIndex = 13;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(59, 78);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(133, 20);
            this.textBox_Name.TabIndex = 12;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(59, 52);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(133, 20);
            this.textBox_Port.TabIndex = 11;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(59, 26);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(133, 20);
            this.textBox_IP.TabIndex = 10;
            // 
            // textBox_Message
            // 
            this.textBox_Message.Enabled = false;
            this.textBox_Message.Location = new System.Drawing.Point(198, 160);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(257, 20);
            this.textBox_Message.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Server Logs: ";
            // 
            // button_sendmessage
            // 
            this.button_sendmessage.Enabled = false;
            this.button_sendmessage.Location = new System.Drawing.Point(461, 144);
            this.button_sendmessage.Name = "button_sendmessage";
            this.button_sendmessage.Size = new System.Drawing.Size(99, 23);
            this.button_sendmessage.TabIndex = 20;
            this.button_sendmessage.Text = "Send To All";
            this.button_sendmessage.UseVisualStyleBackColor = true;
            this.button_sendmessage.Click += new System.EventHandler(this.button_sendmessage_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Enabled = false;
            this.button_disconnect.Location = new System.Drawing.Point(59, 158);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(133, 23);
            this.button_disconnect.TabIndex = 21;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // friendListBox
            // 
            this.friendListBox.Location = new System.Drawing.Point(598, 26);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(141, 115);
            this.friendListBox.TabIndex = 22;
            this.friendListBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Friend List:";
            // 
            // friendRequestsCheckedList
            // 
            this.friendRequestsCheckedList.FormattingEnabled = true;
            this.friendRequestsCheckedList.Location = new System.Drawing.Point(767, 29);
            this.friendRequestsCheckedList.Name = "friendRequestsCheckedList";
            this.friendRequestsCheckedList.Size = new System.Drawing.Size(152, 64);
            this.friendRequestsCheckedList.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(764, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Friend Requests:";
            // 
            // button_accept
            // 
            this.button_accept.BackColor = System.Drawing.SystemColors.Control;
            this.button_accept.Enabled = false;
            this.button_accept.Location = new System.Drawing.Point(767, 99);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(65, 19);
            this.button_accept.TabIndex = 26;
            this.button_accept.Text = "Accept";
            this.button_accept.UseVisualStyleBackColor = false;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_reject
            // 
            this.button_reject.BackColor = System.Drawing.SystemColors.Control;
            this.button_reject.Enabled = false;
            this.button_reject.Location = new System.Drawing.Point(856, 99);
            this.button_reject.Name = "button_reject";
            this.button_reject.Size = new System.Drawing.Size(65, 19);
            this.button_reject.TabIndex = 27;
            this.button_reject.Text = "Reject";
            this.button_reject.UseVisualStyleBackColor = false;
            this.button_reject.Click += new System.EventHandler(this.button_reject_Click);
            // 
            // button_invite
            // 
            this.button_invite.Enabled = false;
            this.button_invite.Location = new System.Drawing.Point(767, 161);
            this.button_invite.Name = "button_invite";
            this.button_invite.Size = new System.Drawing.Size(65, 21);
            this.button_invite.TabIndex = 30;
            this.button_invite.Text = "Invite!";
            this.button_invite.UseVisualStyleBackColor = true;
            this.button_invite.Click += new System.EventHandler(this.button_invite_Click);
            // 
            // button_reflesh
            // 
            this.button_reflesh.Enabled = false;
            this.button_reflesh.Location = new System.Drawing.Point(598, 147);
            this.button_reflesh.Name = "button_reflesh";
            this.button_reflesh.Size = new System.Drawing.Size(141, 25);
            this.button_reflesh.TabIndex = 31;
            this.button_reflesh.Text = "Refresh";
            this.button_reflesh.UseVisualStyleBackColor = true;
            this.button_reflesh.Click += new System.EventHandler(this.button_reflesh_Click);
            // 
            // button_send_friends
            // 
            this.button_send_friends.Enabled = false;
            this.button_send_friends.Location = new System.Drawing.Point(461, 173);
            this.button_send_friends.Name = "button_send_friends";
            this.button_send_friends.Size = new System.Drawing.Size(99, 23);
            this.button_send_friends.TabIndex = 32;
            this.button_send_friends.Text = "Send To Friends";
            this.button_send_friends.UseVisualStyleBackColor = true;
            this.button_send_friends.Click += new System.EventHandler(this.button_send_friends_Click);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(856, 161);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(63, 21);
            this.button_delete.TabIndex = 35;
            this.button_delete.Text = "Delete!";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // comboBox_name
            // 
            this.comboBox_name.Enabled = false;
            this.comboBox_name.FormattingEnabled = true;
            this.comboBox_name.Location = new System.Drawing.Point(767, 134);
            this.comboBox_name.Name = "comboBox_name";
            this.comboBox_name.Size = new System.Drawing.Size(152, 21);
            this.comboBox_name.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 209);
            this.Controls.Add(this.comboBox_name);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_send_friends);
            this.Controls.Add(this.button_reflesh);
            this.Controls.Add(this.button_invite);
            this.Controls.Add(this.button_reject);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.friendRequestsCheckedList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.friendListBox);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_sendmessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_sendmessage;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.RichTextBox friendListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox friendRequestsCheckedList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_reject;
        private System.Windows.Forms.Button button_invite;
        private System.Windows.Forms.Button button_reflesh;
        private System.Windows.Forms.Button button_send_friends;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ComboBox comboBox_name;
    }
}

