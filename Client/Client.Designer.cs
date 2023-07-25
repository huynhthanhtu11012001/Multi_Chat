namespace Client
{
    partial class Client
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
            this.listview_message = new System.Windows.Forms.ListView();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listview_message
            // 
            this.listview_message.HideSelection = false;
            this.listview_message.Location = new System.Drawing.Point(13, 13);
            this.listview_message.Name = "listview_message";
            this.listview_message.Size = new System.Drawing.Size(775, 359);
            this.listview_message.TabIndex = 0;
            this.listview_message.UseCompatibleStateImageBehavior = false;
            this.listview_message.View = System.Windows.Forms.View.List;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(13, 386);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(682, 52);
            this.txt_message.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(701, 386);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 52);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Client
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.listview_message);
            this.Name = "Client";
            this.Text = "CLIENT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview_message;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_send;
    }
}

