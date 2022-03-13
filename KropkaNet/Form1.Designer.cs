
namespace Toys
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
            this.addToy = new System.Windows.Forms.Button();
            this.deleteToy = new System.Windows.Forms.Button();
            this.listOfCreatedToy = new System.Windows.Forms.ListBox();
            this.listOfToy = new System.Windows.Forms.ListBox();
            this.Accelerate = new System.Windows.Forms.GroupBox();
            this.textBoxAccelerate = new System.Windows.Forms.TextBox();
            this.AccelerateIncrease = new System.Windows.Forms.Button();
            this.accelerateDecrease = new System.Windows.Forms.Button();
            this.Dive = new System.Windows.Forms.GroupBox();
            this.textBoxDive = new System.Windows.Forms.TextBox();
            this.diveIncrease = new System.Windows.Forms.Button();
            this.diveDecrease = new System.Windows.Forms.Button();
            this.Rise = new System.Windows.Forms.GroupBox();
            this.textBoxRise = new System.Windows.Forms.TextBox();
            this.riseIncrease = new System.Windows.Forms.Button();
            this.riseDecrease = new System.Windows.Forms.Button();
            this.Accelerate.SuspendLayout();
            this.Dive.SuspendLayout();
            this.Rise.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToy
            // 
            this.addToy.Location = new System.Drawing.Point(362, 12);
            this.addToy.Name = "addToy";
            this.addToy.Size = new System.Drawing.Size(113, 60);
            this.addToy.TabIndex = 0;
            this.addToy.Text = "add";
            this.addToy.UseVisualStyleBackColor = true;
            this.addToy.Click += new System.EventHandler(this.addToy_Click);
            // 
            // deleteToy
            // 
            this.deleteToy.Location = new System.Drawing.Point(362, 132);
            this.deleteToy.Name = "deleteToy";
            this.deleteToy.Size = new System.Drawing.Size(113, 60);
            this.deleteToy.TabIndex = 1;
            this.deleteToy.Text = "delete";
            this.deleteToy.UseVisualStyleBackColor = true;
            this.deleteToy.Click += new System.EventHandler(this.deleteToy_Click);
            // 
            // listOfCreatedToy
            // 
            this.listOfCreatedToy.FormattingEnabled = true;
            this.listOfCreatedToy.ItemHeight = 16;
            this.listOfCreatedToy.Location = new System.Drawing.Point(481, 12);
            this.listOfCreatedToy.Name = "listOfCreatedToy";
            this.listOfCreatedToy.Size = new System.Drawing.Size(226, 180);
            this.listOfCreatedToy.TabIndex = 2;
            this.listOfCreatedToy.SelectedIndexChanged += new System.EventHandler(this.listOfCreatedToy_SelectedIndexChanged);
            // 
            // listOfToy
            // 
            this.listOfToy.FormattingEnabled = true;
            this.listOfToy.ItemHeight = 16;
            this.listOfToy.Items.AddRange(new object[] {
            "Car",
            "Submarine",
            "Plane",
            "Computer"});
            this.listOfToy.Location = new System.Drawing.Point(130, 12);
            this.listOfToy.Name = "listOfToy";
            this.listOfToy.Size = new System.Drawing.Size(226, 180);
            this.listOfToy.TabIndex = 3;
            this.listOfToy.SelectedIndexChanged += new System.EventHandler(this.listOfToy_SelectedIndexChanged);
            // 
            // Accelerate
            // 
            this.Accelerate.Controls.Add(this.textBoxAccelerate);
            this.Accelerate.Controls.Add(this.AccelerateIncrease);
            this.Accelerate.Controls.Add(this.accelerateDecrease);
            this.Accelerate.Location = new System.Drawing.Point(481, 198);
            this.Accelerate.Name = "Accelerate";
            this.Accelerate.Size = new System.Drawing.Size(332, 146);
            this.Accelerate.TabIndex = 4;
            this.Accelerate.TabStop = false;
            this.Accelerate.Text = "Accelerate";
            // 
            // textBoxAccelerate
            // 
            this.textBoxAccelerate.Location = new System.Drawing.Point(126, 58);
            this.textBoxAccelerate.Name = "textBoxAccelerate";
            this.textBoxAccelerate.Size = new System.Drawing.Size(100, 22);
            this.textBoxAccelerate.TabIndex = 5;
            // 
            // AccelerateIncrease
            // 
            this.AccelerateIncrease.Location = new System.Drawing.Point(238, 47);
            this.AccelerateIncrease.Name = "AccelerateIncrease";
            this.AccelerateIncrease.Size = new System.Drawing.Size(88, 45);
            this.AccelerateIncrease.TabIndex = 1;
            this.AccelerateIncrease.Text = "Accelerate Increase";
            this.AccelerateIncrease.UseVisualStyleBackColor = true;
            this.AccelerateIncrease.Click += new System.EventHandler(this.AccelerateIncrease_Click);
            // 
            // accelerateDecrease
            // 
            this.accelerateDecrease.Location = new System.Drawing.Point(6, 47);
            this.accelerateDecrease.Name = "accelerateDecrease";
            this.accelerateDecrease.Size = new System.Drawing.Size(92, 45);
            this.accelerateDecrease.TabIndex = 0;
            this.accelerateDecrease.Text = "accelerate Decrease";
            this.accelerateDecrease.UseVisualStyleBackColor = true;
            this.accelerateDecrease.Click += new System.EventHandler(this.accelerateDecrease_Click);
            // 
            // Dive
            // 
            this.Dive.Controls.Add(this.textBoxDive);
            this.Dive.Controls.Add(this.diveIncrease);
            this.Dive.Controls.Add(this.diveDecrease);
            this.Dive.Location = new System.Drawing.Point(481, 369);
            this.Dive.Name = "Dive";
            this.Dive.Size = new System.Drawing.Size(332, 146);
            this.Dive.TabIndex = 5;
            this.Dive.TabStop = false;
            this.Dive.Text = "Dive";
            // 
            // textBoxDive
            // 
            this.textBoxDive.Location = new System.Drawing.Point(126, 58);
            this.textBoxDive.Name = "textBoxDive";
            this.textBoxDive.Size = new System.Drawing.Size(100, 22);
            this.textBoxDive.TabIndex = 5;
            // 
            // diveIncrease
            // 
            this.diveIncrease.Location = new System.Drawing.Point(238, 47);
            this.diveIncrease.Name = "diveIncrease";
            this.diveIncrease.Size = new System.Drawing.Size(88, 45);
            this.diveIncrease.TabIndex = 1;
            this.diveIncrease.Text = "Dive Increase";
            this.diveIncrease.UseVisualStyleBackColor = true;
            this.diveIncrease.Click += new System.EventHandler(this.diveIncrease_Click);
            // 
            // diveDecrease
            // 
            this.diveDecrease.Location = new System.Drawing.Point(6, 47);
            this.diveDecrease.Name = "diveDecrease";
            this.diveDecrease.Size = new System.Drawing.Size(92, 45);
            this.diveDecrease.TabIndex = 0;
            this.diveDecrease.Text = "dive Decrease";
            this.diveDecrease.UseVisualStyleBackColor = true;
            this.diveDecrease.Click += new System.EventHandler(this.diveDecrease_Click);
            // 
            // Rise
            // 
            this.Rise.Controls.Add(this.textBoxRise);
            this.Rise.Controls.Add(this.riseIncrease);
            this.Rise.Controls.Add(this.riseDecrease);
            this.Rise.Location = new System.Drawing.Point(481, 547);
            this.Rise.Name = "Rise";
            this.Rise.Size = new System.Drawing.Size(332, 146);
            this.Rise.TabIndex = 6;
            this.Rise.TabStop = false;
            this.Rise.Text = "Rise";
            // 
            // textBoxRise
            // 
            this.textBoxRise.Location = new System.Drawing.Point(126, 58);
            this.textBoxRise.Name = "textBoxRise";
            this.textBoxRise.Size = new System.Drawing.Size(100, 22);
            this.textBoxRise.TabIndex = 5;
            // 
            // riseIncrease
            // 
            this.riseIncrease.Location = new System.Drawing.Point(238, 47);
            this.riseIncrease.Name = "riseIncrease";
            this.riseIncrease.Size = new System.Drawing.Size(88, 45);
            this.riseIncrease.TabIndex = 1;
            this.riseIncrease.Text = "rise Increase";
            this.riseIncrease.UseVisualStyleBackColor = true;
            this.riseIncrease.Click += new System.EventHandler(this.riseIncrease_Click);
            // 
            // riseDecrease
            // 
            this.riseDecrease.Location = new System.Drawing.Point(6, 47);
            this.riseDecrease.Name = "riseDecrease";
            this.riseDecrease.Size = new System.Drawing.Size(92, 45);
            this.riseDecrease.TabIndex = 0;
            this.riseDecrease.Text = "rise Decrease";
            this.riseDecrease.UseVisualStyleBackColor = true;
            this.riseDecrease.Click += new System.EventHandler(this.riseDecrease_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 777);
            this.Controls.Add(this.Rise);
            this.Controls.Add(this.Dive);
            this.Controls.Add(this.Accelerate);
            this.Controls.Add(this.listOfToy);
            this.Controls.Add(this.listOfCreatedToy);
            this.Controls.Add(this.deleteToy);
            this.Controls.Add(this.addToy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Accelerate.ResumeLayout(false);
            this.Accelerate.PerformLayout();
            this.Dive.ResumeLayout(false);
            this.Dive.PerformLayout();
            this.Rise.ResumeLayout(false);
            this.Rise.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addToy;
        private System.Windows.Forms.Button deleteToy;
        private System.Windows.Forms.ListBox listOfCreatedToy;
        private System.Windows.Forms.ListBox listOfToy;
        private System.Windows.Forms.GroupBox Accelerate;
        private System.Windows.Forms.TextBox textBoxAccelerate;
        private System.Windows.Forms.Button AccelerateIncrease;
        private System.Windows.Forms.Button accelerateDecrease;
        private System.Windows.Forms.GroupBox Dive;
        private System.Windows.Forms.TextBox textBoxDive;
        private System.Windows.Forms.Button diveIncrease;
        private System.Windows.Forms.Button diveDecrease;
        private System.Windows.Forms.GroupBox Rise;
        private System.Windows.Forms.TextBox textBoxRise;
        private System.Windows.Forms.Button riseIncrease;
        private System.Windows.Forms.Button riseDecrease;
    }
}

