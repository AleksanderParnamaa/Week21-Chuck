namespace ChuckFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokeBtn = new System.Windows.Forms.Button();
            this.jokebox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokeBtn
            // 
            this.getJokeBtn.Location = new System.Drawing.Point(0, 0);
            this.getJokeBtn.Name = "getJokeBtn";
            this.getJokeBtn.Size = new System.Drawing.Size(75, 23);
            this.getJokeBtn.TabIndex = 0;
            this.getJokeBtn.Text = "Get Joke";
            this.getJokeBtn.UseVisualStyleBackColor = true;
            this.getJokeBtn.Click += new System.EventHandler(this.getJokeBtn_Click);
            // 
            // jokebox
            // 
            this.jokebox.Location = new System.Drawing.Point(499, 186);
            this.jokebox.Name = "jokebox";
            this.jokebox.Size = new System.Drawing.Size(200, 202);
            this.jokebox.TabIndex = 1;
            this.jokebox.Text = "Get A Joke, I dare you!";
            this.jokebox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(788, 556);
            this.Controls.Add(this.jokebox);
            this.Controls.Add(this.getJokeBtn);
            this.Name = "Form1";
            this.Text = "Chuck Norris Jokes Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokeBtn;
        private System.Windows.Forms.RichTextBox jokebox;
    }
}

