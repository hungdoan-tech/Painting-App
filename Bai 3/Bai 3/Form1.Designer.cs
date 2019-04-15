namespace Bai_3
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
            this.components = new System.ComponentModel.Container();
            this.Main_PictureBox = new System.Windows.Forms.PictureBox();
            this.Line_Button = new System.Windows.Forms.Button();
            this.Ecclipe_Button = new System.Windows.Forms.Button();
            this.SolidEcclipe_Button = new System.Windows.Forms.Button();
            this.Rectangle_Button = new System.Windows.Forms.Button();
            this.SolidRectangle_Button = new System.Windows.Forms.Button();
            this.Width_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeleteAll_Button = new System.Windows.Forms.Button();
            this.Circle_Button = new System.Windows.Forms.Button();
            this.SolidCircle_Button = new System.Windows.Forms.Button();
            this.Polygon_Button = new System.Windows.Forms.Button();
            this.SolidPolygon_Button = new System.Windows.Forms.Button();
            this.Select_Button = new System.Windows.Forms.Button();
            this.Dash_RadioButton = new System.Windows.Forms.RadioButton();
            this.Line_RadioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_PictureBox
            // 
            this.Main_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main_PictureBox.Location = new System.Drawing.Point(141, 12);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(1257, 697);
            this.Main_PictureBox.TabIndex = 9;
            this.Main_PictureBox.TabStop = false;
            this.Main_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_PictureBox_Paint);
            this.Main_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseDown);
            this.Main_PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseMove);
            this.Main_PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseUp);
            // 
            // Line_Button
            // 
            this.Line_Button.Location = new System.Drawing.Point(13, 12);
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(102, 23);
            this.Line_Button.TabIndex = 10;
            this.Line_Button.Text = "Line";
            this.Line_Button.UseVisualStyleBackColor = true;
            this.Line_Button.Click += new System.EventHandler(this.Line_Button_Click_1);
            // 
            // Ecclipe_Button
            // 
            this.Ecclipe_Button.Location = new System.Drawing.Point(12, 52);
            this.Ecclipe_Button.Name = "Ecclipe_Button";
            this.Ecclipe_Button.Size = new System.Drawing.Size(102, 23);
            this.Ecclipe_Button.TabIndex = 11;
            this.Ecclipe_Button.Text = "Ecclipe";
            this.Ecclipe_Button.UseVisualStyleBackColor = true;
            this.Ecclipe_Button.Click += new System.EventHandler(this.Ecclipe_Button_Click_1);
            // 
            // SolidEcclipe_Button
            // 
            this.SolidEcclipe_Button.Location = new System.Drawing.Point(12, 90);
            this.SolidEcclipe_Button.Name = "SolidEcclipe_Button";
            this.SolidEcclipe_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidEcclipe_Button.TabIndex = 12;
            this.SolidEcclipe_Button.Text = "Solid Ecclipe";
            this.SolidEcclipe_Button.UseVisualStyleBackColor = true;
            this.SolidEcclipe_Button.Click += new System.EventHandler(this.SolidEcclipe_Button_Click_1);
            // 
            // Rectangle_Button
            // 
            this.Rectangle_Button.Location = new System.Drawing.Point(12, 135);
            this.Rectangle_Button.Name = "Rectangle_Button";
            this.Rectangle_Button.Size = new System.Drawing.Size(101, 23);
            this.Rectangle_Button.TabIndex = 13;
            this.Rectangle_Button.Text = "Rectangle";
            this.Rectangle_Button.UseVisualStyleBackColor = true;
            this.Rectangle_Button.Click += new System.EventHandler(this.Rectangle_Button_Click_1);
            // 
            // SolidRectangle_Button
            // 
            this.SolidRectangle_Button.Location = new System.Drawing.Point(11, 173);
            this.SolidRectangle_Button.Name = "SolidRectangle_Button";
            this.SolidRectangle_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidRectangle_Button.TabIndex = 14;
            this.SolidRectangle_Button.Text = "Solid Rectangle";
            this.SolidRectangle_Button.UseVisualStyleBackColor = true;
            this.SolidRectangle_Button.Click += new System.EventHandler(this.SolidRectangle_Button_Click_1);
            // 
            // Width_NumericUpDown
            // 
            this.Width_NumericUpDown.Location = new System.Drawing.Point(19, 547);
            this.Width_NumericUpDown.Name = "Width_NumericUpDown";
            this.Width_NumericUpDown.Size = new System.Drawing.Size(102, 20);
            this.Width_NumericUpDown.TabIndex = 15;
            // 
            // DeleteAll_Button
            // 
            this.DeleteAll_Button.Location = new System.Drawing.Point(11, 660);
            this.DeleteAll_Button.Name = "DeleteAll_Button";
            this.DeleteAll_Button.Size = new System.Drawing.Size(75, 23);
            this.DeleteAll_Button.TabIndex = 16;
            this.DeleteAll_Button.Text = "Delete All";
            this.DeleteAll_Button.UseVisualStyleBackColor = true;
            this.DeleteAll_Button.Click += new System.EventHandler(this.DeleteAll_Button_Click);
            // 
            // Circle_Button
            // 
            this.Circle_Button.Location = new System.Drawing.Point(13, 220);
            this.Circle_Button.Name = "Circle_Button";
            this.Circle_Button.Size = new System.Drawing.Size(100, 23);
            this.Circle_Button.TabIndex = 17;
            this.Circle_Button.Text = "Circle";
            this.Circle_Button.UseVisualStyleBackColor = true;
            this.Circle_Button.Click += new System.EventHandler(this.Circle_Button_Click);
            // 
            // SolidCircle_Button
            // 
            this.SolidCircle_Button.Location = new System.Drawing.Point(11, 265);
            this.SolidCircle_Button.Name = "SolidCircle_Button";
            this.SolidCircle_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidCircle_Button.TabIndex = 18;
            this.SolidCircle_Button.Text = "Solid Circle ";
            this.SolidCircle_Button.UseVisualStyleBackColor = true;
            this.SolidCircle_Button.Click += new System.EventHandler(this.SolidCircle_Button_Click);
            // 
            // Polygon_Button
            // 
            this.Polygon_Button.Location = new System.Drawing.Point(13, 312);
            this.Polygon_Button.Name = "Polygon_Button";
            this.Polygon_Button.Size = new System.Drawing.Size(102, 23);
            this.Polygon_Button.TabIndex = 19;
            this.Polygon_Button.Text = "Polygon";
            this.Polygon_Button.UseVisualStyleBackColor = true;
            this.Polygon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // SolidPolygon_Button
            // 
            this.SolidPolygon_Button.Location = new System.Drawing.Point(13, 365);
            this.SolidPolygon_Button.Name = "SolidPolygon_Button";
            this.SolidPolygon_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidPolygon_Button.TabIndex = 20;
            this.SolidPolygon_Button.Text = "Solid Polygon";
            this.SolidPolygon_Button.UseVisualStyleBackColor = true;
            this.SolidPolygon_Button.Click += new System.EventHandler(this.SolidPolygon_Button_Click);
            // 
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(13, 409);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(100, 23);
            this.Select_Button.TabIndex = 21;
            this.Select_Button.Text = "Select";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.NonSelect_Button_Click);
            // 
            // Dash_RadioButton
            // 
            this.Dash_RadioButton.AutoSize = true;
            this.Dash_RadioButton.Location = new System.Drawing.Point(19, 501);
            this.Dash_RadioButton.Name = "Dash_RadioButton";
            this.Dash_RadioButton.Size = new System.Drawing.Size(76, 17);
            this.Dash_RadioButton.TabIndex = 22;
            this.Dash_RadioButton.TabStop = true;
            this.Dash_RadioButton.Text = "Dash Style";
            this.Dash_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Line_RadioButton
            // 
            this.Line_RadioButton.AutoSize = true;
            this.Line_RadioButton.Location = new System.Drawing.Point(19, 524);
            this.Line_RadioButton.Name = "Line_RadioButton";
            this.Line_RadioButton.Size = new System.Drawing.Size(71, 17);
            this.Line_RadioButton.TabIndex = 23;
            this.Line_RadioButton.TabStop = true;
            this.Line_RadioButton.Text = "Line Style";
            this.Line_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 721);
            this.Controls.Add(this.Line_RadioButton);
            this.Controls.Add(this.Dash_RadioButton);
            this.Controls.Add(this.Select_Button);
            this.Controls.Add(this.SolidPolygon_Button);
            this.Controls.Add(this.Polygon_Button);
            this.Controls.Add(this.SolidCircle_Button);
            this.Controls.Add(this.Circle_Button);
            this.Controls.Add(this.DeleteAll_Button);
            this.Controls.Add(this.Width_NumericUpDown);
            this.Controls.Add(this.SolidRectangle_Button);
            this.Controls.Add(this.Rectangle_Button);
            this.Controls.Add(this.SolidEcclipe_Button);
            this.Controls.Add(this.Ecclipe_Button);
            this.Controls.Add(this.Line_Button);
            this.Controls.Add(this.Main_PictureBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Basic Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Main_PictureBox;
        private System.Windows.Forms.Button Line_Button;
        private System.Windows.Forms.Button Ecclipe_Button;
        private System.Windows.Forms.Button SolidEcclipe_Button;
        private System.Windows.Forms.Button Rectangle_Button;
        private System.Windows.Forms.Button SolidRectangle_Button;
        private System.Windows.Forms.NumericUpDown Width_NumericUpDown;
        private System.Windows.Forms.Button DeleteAll_Button;
        private System.Windows.Forms.Button Circle_Button;
        private System.Windows.Forms.Button SolidCircle_Button;
        private System.Windows.Forms.Button Polygon_Button;
        private System.Windows.Forms.Button SolidPolygon_Button;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.RadioButton Dash_RadioButton;
        private System.Windows.Forms.RadioButton Line_RadioButton;
        private System.Windows.Forms.Timer timer1;
    }
}

