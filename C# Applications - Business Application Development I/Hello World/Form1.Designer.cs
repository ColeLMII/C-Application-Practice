
namespace Hello_World
{
    partial class frmHelloWorld
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
            this.nHelloWorldButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nHelloWorldButton
            // 
            this.nHelloWorldButton.Location = new System.Drawing.Point(149, 283);
            this.nHelloWorldButton.Name = "nHelloWorldButton";
            this.nHelloWorldButton.Size = new System.Drawing.Size(75, 23);
            this.nHelloWorldButton.TabIndex = 0;
            this.nHelloWorldButton.Text = "button1";
            this.nHelloWorldButton.UseVisualStyleBackColor = true;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 356);
            this.Controls.Add(this.nHelloWorldButton);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nHelloWorldButton;
    }
}

