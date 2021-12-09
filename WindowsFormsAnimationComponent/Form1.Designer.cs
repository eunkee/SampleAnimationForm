
namespace WindowsFormsTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonOnPopup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "red Center";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "blue Slide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "right move";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Salmon;
            this.redBox.Location = new System.Drawing.Point(0, 12);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(56, 50);
            this.redBox.TabIndex = 3;
            this.redBox.TabStop = false;
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blueBox.Location = new System.Drawing.Point(0, 59);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(56, 50);
            this.blueBox.TabIndex = 4;
            this.blueBox.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(313, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "left move";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // buttonOnPopup
            // 
            this.buttonOnPopup.Location = new System.Drawing.Point(409, 128);
            this.buttonOnPopup.Name = "buttonOnPopup";
            this.buttonOnPopup.Size = new System.Drawing.Size(90, 37);
            this.buttonOnPopup.TabIndex = 6;
            this.buttonOnPopup.Text = "popup On";
            this.buttonOnPopup.UseVisualStyleBackColor = true;
            this.buttonOnPopup.Click += new System.EventHandler(this.ButtonOnPopup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 178);
            this.Controls.Add(this.buttonOnPopup);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Animation Component";
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonOnPopup;
    }
}

