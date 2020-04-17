
    namespace Button
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button.Location = new System.Drawing.Point(145, 132);
            this.button.Margin = new System.Windows.Forms.Padding(10);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(137, 52);
            this.button.TabIndex = 0;
            this.button.Text = "Push me";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.OnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 315);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(194, 174);
            this.Name = "Form1";
            this.Text = "Running button";
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Button button;
        }
    }


