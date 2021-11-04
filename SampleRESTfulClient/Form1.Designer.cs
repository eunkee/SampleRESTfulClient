
namespace SampleRESTfulClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxGetAddress = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonGetClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGetId = new System.Windows.Forms.TextBox();
            this.textBoxGetData1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGetData3 = new System.Windows.Forms.TextBox();
            this.textBoxGetData2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPostData3 = new System.Windows.Forms.TextBox();
            this.textBoxPostData2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPostData1 = new System.Windows.Forms.TextBox();
            this.textBoxPostId = new System.Windows.Forms.TextBox();
            this.textBoxPostAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonPostClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGetAddress
            // 
            this.textBoxGetAddress.Location = new System.Drawing.Point(67, 26);
            this.textBoxGetAddress.Name = "textBoxGetAddress";
            this.textBoxGetAddress.Size = new System.Drawing.Size(420, 23);
            this.textBoxGetAddress.TabIndex = 0;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(332, 58);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "GET";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.ButtonGet_Click);
            // 
            // buttonGetClear
            // 
            this.buttonGetClear.Location = new System.Drawing.Point(413, 58);
            this.buttonGetClear.Name = "buttonGetClear";
            this.buttonGetClear.Size = new System.Drawing.Size(75, 23);
            this.buttonGetClear.TabIndex = 3;
            this.buttonGetClear.Text = "Clear";
            this.buttonGetClear.UseVisualStyleBackColor = true;
            this.buttonGetClear.Click += new System.EventHandler(this.ButtonGetClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxGetData3);
            this.groupBox1.Controls.Add(this.textBoxGetData2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxGetData1);
            this.groupBox1.Controls.Add(this.textBoxGetId);
            this.groupBox1.Controls.Add(this.textBoxGetAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonGet);
            this.groupBox1.Controls.Add(this.buttonGetClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample Get ";
            // 
            // textBoxGetId
            // 
            this.textBoxGetId.Enabled = false;
            this.textBoxGetId.Location = new System.Drawing.Point(67, 94);
            this.textBoxGetId.Name = "textBoxGetId";
            this.textBoxGetId.Size = new System.Drawing.Size(176, 23);
            this.textBoxGetId.TabIndex = 6;
            // 
            // textBoxGetData1
            // 
            this.textBoxGetData1.Enabled = false;
            this.textBoxGetData1.Location = new System.Drawing.Point(311, 94);
            this.textBoxGetData1.Name = "textBoxGetData1";
            this.textBoxGetData1.Size = new System.Drawing.Size(176, 23);
            this.textBoxGetData1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data2";
            // 
            // textBoxGetData3
            // 
            this.textBoxGetData3.Enabled = false;
            this.textBoxGetData3.Location = new System.Drawing.Point(311, 131);
            this.textBoxGetData3.Name = "textBoxGetData3";
            this.textBoxGetData3.Size = new System.Drawing.Size(176, 23);
            this.textBoxGetData3.TabIndex = 11;
            // 
            // textBoxGetData2
            // 
            this.textBoxGetData2.Enabled = false;
            this.textBoxGetData2.Location = new System.Drawing.Point(67, 131);
            this.textBoxGetData2.Name = "textBoxGetData2";
            this.textBoxGetData2.Size = new System.Drawing.Size(176, 23);
            this.textBoxGetData2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPostData3);
            this.groupBox2.Controls.Add(this.textBoxPostData2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxPostData1);
            this.groupBox2.Controls.Add(this.textBoxPostId);
            this.groupBox2.Controls.Add(this.textBoxPostAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.buttonPost);
            this.groupBox2.Controls.Add(this.buttonPostClear);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 169);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sample Post ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data2";
            // 
            // textBoxPostData3
            // 
            this.textBoxPostData3.Location = new System.Drawing.Point(311, 131);
            this.textBoxPostData3.Name = "textBoxPostData3";
            this.textBoxPostData3.Size = new System.Drawing.Size(176, 23);
            this.textBoxPostData3.TabIndex = 11;
            // 
            // textBoxPostData2
            // 
            this.textBoxPostData2.Location = new System.Drawing.Point(67, 131);
            this.textBoxPostData2.Name = "textBoxPostData2";
            this.textBoxPostData2.Size = new System.Drawing.Size(176, 23);
            this.textBoxPostData2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID";
            // 
            // textBoxPostData1
            // 
            this.textBoxPostData1.Location = new System.Drawing.Point(311, 94);
            this.textBoxPostData1.Name = "textBoxPostData1";
            this.textBoxPostData1.Size = new System.Drawing.Size(176, 23);
            this.textBoxPostData1.TabIndex = 7;
            // 
            // textBoxPostId
            // 
            this.textBoxPostId.Location = new System.Drawing.Point(67, 94);
            this.textBoxPostId.Name = "textBoxPostId";
            this.textBoxPostId.Size = new System.Drawing.Size(176, 23);
            this.textBoxPostId.TabIndex = 6;
            // 
            // textBoxPostAddress
            // 
            this.textBoxPostAddress.Location = new System.Drawing.Point(67, 26);
            this.textBoxPostAddress.Name = "textBoxPostAddress";
            this.textBoxPostAddress.Size = new System.Drawing.Size(420, 23);
            this.textBoxPostAddress.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Address";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(332, 58);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // buttonPostClear
            // 
            this.buttonPostClear.Location = new System.Drawing.Point(413, 58);
            this.buttonPostClear.Name = "buttonPostClear";
            this.buttonPostClear.Size = new System.Drawing.Size(75, 23);
            this.buttonPostClear.TabIndex = 3;
            this.buttonPostClear.Text = "Clear";
            this.buttonPostClear.UseVisualStyleBackColor = true;
            this.buttonPostClear.Click += new System.EventHandler(this.ButtonPostClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 353);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RESTful GET / POST Client Sample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGetAddress;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonGetClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGetData3;
        private System.Windows.Forms.TextBox textBoxGetData2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGetData1;
        private System.Windows.Forms.TextBox textBoxGetId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPostData3;
        private System.Windows.Forms.TextBox textBoxPostData2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPostData1;
        private System.Windows.Forms.TextBox textBoxPostId;
        private System.Windows.Forms.TextBox textBoxPostAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonPostClear;
    }
}

