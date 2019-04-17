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
            this.Pen_Panel = new System.Windows.Forms.Panel();
            this.ColorPen_Panel = new System.Windows.Forms.Panel();
            this.WidthPen_Panel = new System.Windows.Forms.Label();
            this.Pen_Label = new System.Windows.Forms.Label();
            this.Brush_Panel = new System.Windows.Forms.Panel();
            this.Brush_Label = new System.Windows.Forms.Label();
            this.ColorBrush_Panel = new System.Windows.Forms.Panel();
            this.Draw_Panel = new System.Windows.Forms.Panel();
            this.Draw_Label = new System.Windows.Forms.Label();
            this.Pen_ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NumericUpDown)).BeginInit();
            this.Pen_Panel.SuspendLayout();
            this.Brush_Panel.SuspendLayout();
            this.Draw_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_PictureBox
            // 
            this.Main_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main_PictureBox.Location = new System.Drawing.Point(154, 12);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(1244, 697);
            this.Main_PictureBox.TabIndex = 9;
            this.Main_PictureBox.TabStop = false;
            this.Main_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_PictureBox_Paint);
            this.Main_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseDown);
            this.Main_PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseMove);
            this.Main_PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseUp);
            // 
            // Line_Button
            // 
            this.Line_Button.Location = new System.Drawing.Point(14, 14);
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(102, 23);
            this.Line_Button.TabIndex = 10;
            this.Line_Button.Text = "Line";
            this.Line_Button.UseVisualStyleBackColor = true;
            this.Line_Button.Click += new System.EventHandler(this.Line_Button_Click_1);
            // 
            // Ecclipe_Button
            // 
            this.Ecclipe_Button.Location = new System.Drawing.Point(14, 43);
            this.Ecclipe_Button.Name = "Ecclipe_Button";
            this.Ecclipe_Button.Size = new System.Drawing.Size(102, 23);
            this.Ecclipe_Button.TabIndex = 11;
            this.Ecclipe_Button.Text = "Ecclipe";
            this.Ecclipe_Button.UseVisualStyleBackColor = true;
            this.Ecclipe_Button.Click += new System.EventHandler(this.Ecclipe_Button_Click_1);
            // 
            // SolidEcclipe_Button
            // 
            this.SolidEcclipe_Button.Location = new System.Drawing.Point(14, 83);
            this.SolidEcclipe_Button.Name = "SolidEcclipe_Button";
            this.SolidEcclipe_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidEcclipe_Button.TabIndex = 12;
            this.SolidEcclipe_Button.Text = "Solid Ecclipe";
            this.SolidEcclipe_Button.UseVisualStyleBackColor = true;
            this.SolidEcclipe_Button.Click += new System.EventHandler(this.SolidEcclipe_Button_Click_1);
            // 
            // Rectangle_Button
            // 
            this.Rectangle_Button.Location = new System.Drawing.Point(14, 125);
            this.Rectangle_Button.Name = "Rectangle_Button";
            this.Rectangle_Button.Size = new System.Drawing.Size(101, 23);
            this.Rectangle_Button.TabIndex = 13;
            this.Rectangle_Button.Text = "Rectangle";
            this.Rectangle_Button.UseVisualStyleBackColor = true;
            this.Rectangle_Button.Click += new System.EventHandler(this.Rectangle_Button_Click_1);
            // 
            // SolidRectangle_Button
            // 
            this.SolidRectangle_Button.Location = new System.Drawing.Point(13, 165);
            this.SolidRectangle_Button.Name = "SolidRectangle_Button";
            this.SolidRectangle_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidRectangle_Button.TabIndex = 14;
            this.SolidRectangle_Button.Text = "Solid Rectangle";
            this.SolidRectangle_Button.UseVisualStyleBackColor = true;
            this.SolidRectangle_Button.Click += new System.EventHandler(this.SolidRectangle_Button_Click_1);
            // 
            // Width_NumericUpDown
            // 
            this.Width_NumericUpDown.Location = new System.Drawing.Point(44, 62);
            this.Width_NumericUpDown.Name = "Width_NumericUpDown";
            this.Width_NumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.Width_NumericUpDown.TabIndex = 15;
            this.Width_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DeleteAll_Button
            // 
            this.DeleteAll_Button.Location = new System.Drawing.Point(29, 408);
            this.DeleteAll_Button.Name = "DeleteAll_Button";
            this.DeleteAll_Button.Size = new System.Drawing.Size(97, 23);
            this.DeleteAll_Button.TabIndex = 16;
            this.DeleteAll_Button.Text = "Delete All";
            this.DeleteAll_Button.UseVisualStyleBackColor = true;
            this.DeleteAll_Button.Click += new System.EventHandler(this.DeleteAll_Button_Click);
            // 
            // Circle_Button
            // 
            this.Circle_Button.Location = new System.Drawing.Point(14, 205);
            this.Circle_Button.Name = "Circle_Button";
            this.Circle_Button.Size = new System.Drawing.Size(100, 23);
            this.Circle_Button.TabIndex = 17;
            this.Circle_Button.Text = "Circle";
            this.Circle_Button.UseVisualStyleBackColor = true;
            this.Circle_Button.Click += new System.EventHandler(this.Circle_Button_Click);
            // 
            // SolidCircle_Button
            // 
            this.SolidCircle_Button.Location = new System.Drawing.Point(14, 247);
            this.SolidCircle_Button.Name = "SolidCircle_Button";
            this.SolidCircle_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidCircle_Button.TabIndex = 18;
            this.SolidCircle_Button.Text = "Solid Circle ";
            this.SolidCircle_Button.UseVisualStyleBackColor = true;
            this.SolidCircle_Button.Click += new System.EventHandler(this.SolidCircle_Button_Click);
            // 
            // Polygon_Button
            // 
            this.Polygon_Button.Location = new System.Drawing.Point(14, 286);
            this.Polygon_Button.Name = "Polygon_Button";
            this.Polygon_Button.Size = new System.Drawing.Size(102, 23);
            this.Polygon_Button.TabIndex = 19;
            this.Polygon_Button.Text = "Polygon";
            this.Polygon_Button.UseVisualStyleBackColor = true;
            this.Polygon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // SolidPolygon_Button
            // 
            this.SolidPolygon_Button.Location = new System.Drawing.Point(14, 315);
            this.SolidPolygon_Button.Name = "SolidPolygon_Button";
            this.SolidPolygon_Button.Size = new System.Drawing.Size(102, 23);
            this.SolidPolygon_Button.TabIndex = 20;
            this.SolidPolygon_Button.Text = "Solid Polygon";
            this.SolidPolygon_Button.UseVisualStyleBackColor = true;
            this.SolidPolygon_Button.Click += new System.EventHandler(this.SolidPolygon_Button_Click);
            // 
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(25, 379);
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
            this.Dash_RadioButton.Location = new System.Drawing.Point(23, 16);
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
            this.Line_RadioButton.Location = new System.Drawing.Point(23, 39);
            this.Line_RadioButton.Name = "Line_RadioButton";
            this.Line_RadioButton.Size = new System.Drawing.Size(71, 17);
            this.Line_RadioButton.TabIndex = 23;
            this.Line_RadioButton.TabStop = true;
            this.Line_RadioButton.Text = "Line Style";
            this.Line_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Pen_Panel
            // 
            this.Pen_Panel.Controls.Add(this.ColorPen_Panel);
            this.Pen_Panel.Controls.Add(this.WidthPen_Panel);
            this.Pen_Panel.Controls.Add(this.Pen_Label);
            this.Pen_Panel.Controls.Add(this.Dash_RadioButton);
            this.Pen_Panel.Controls.Add(this.Line_RadioButton);
            this.Pen_Panel.Controls.Add(this.Width_NumericUpDown);
            this.Pen_Panel.Location = new System.Drawing.Point(12, 465);
            this.Pen_Panel.Name = "Pen_Panel";
            this.Pen_Panel.Size = new System.Drawing.Size(102, 118);
            this.Pen_Panel.TabIndex = 24;
            // 
            // ColorPen_Panel
            // 
            this.ColorPen_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorPen_Panel.Location = new System.Drawing.Point(12, 88);
            this.ColorPen_Panel.Name = "ColorPen_Panel";
            this.ColorPen_Panel.Size = new System.Drawing.Size(82, 19);
            this.ColorPen_Panel.TabIndex = 27;
            this.ColorPen_Panel.Click += new System.EventHandler(this.ColorPen_Panel_Click);
            // 
            // WidthPen_Panel
            // 
            this.WidthPen_Panel.AutoSize = true;
            this.WidthPen_Panel.Location = new System.Drawing.Point(3, 64);
            this.WidthPen_Panel.Name = "WidthPen_Panel";
            this.WidthPen_Panel.Size = new System.Drawing.Size(35, 13);
            this.WidthPen_Panel.TabIndex = 26;
            this.WidthPen_Panel.Text = "Width";
            // 
            // Pen_Label
            // 
            this.Pen_Label.AutoSize = true;
            this.Pen_Label.Location = new System.Drawing.Point(0, 0);
            this.Pen_Label.Name = "Pen_Label";
            this.Pen_Label.Size = new System.Drawing.Size(26, 13);
            this.Pen_Label.TabIndex = 26;
            this.Pen_Label.Text = "Pen";
            // 
            // Brush_Panel
            // 
            this.Brush_Panel.Controls.Add(this.Brush_Label);
            this.Brush_Panel.Controls.Add(this.ColorBrush_Panel);
            this.Brush_Panel.Location = new System.Drawing.Point(11, 600);
            this.Brush_Panel.Name = "Brush_Panel";
            this.Brush_Panel.Size = new System.Drawing.Size(104, 45);
            this.Brush_Panel.TabIndex = 25;
            // 
            // Brush_Label
            // 
            this.Brush_Label.AutoSize = true;
            this.Brush_Label.Location = new System.Drawing.Point(-3, 0);
            this.Brush_Label.Name = "Brush_Label";
            this.Brush_Label.Size = new System.Drawing.Size(35, 13);
            this.Brush_Label.TabIndex = 1;
            this.Brush_Label.Text = "label1";
            // 
            // ColorBrush_Panel
            // 
            this.ColorBrush_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBrush_Panel.Location = new System.Drawing.Point(7, 16);
            this.ColorBrush_Panel.Name = "ColorBrush_Panel";
            this.ColorBrush_Panel.Size = new System.Drawing.Size(90, 15);
            this.ColorBrush_Panel.TabIndex = 0;
            // 
            // Draw_Panel
            // 
            this.Draw_Panel.Controls.Add(this.Draw_Label);
            this.Draw_Panel.Controls.Add(this.Line_Button);
            this.Draw_Panel.Controls.Add(this.Ecclipe_Button);
            this.Draw_Panel.Controls.Add(this.SolidEcclipe_Button);
            this.Draw_Panel.Controls.Add(this.Rectangle_Button);
            this.Draw_Panel.Controls.Add(this.SolidRectangle_Button);
            this.Draw_Panel.Controls.Add(this.SolidPolygon_Button);
            this.Draw_Panel.Controls.Add(this.Circle_Button);
            this.Draw_Panel.Controls.Add(this.Polygon_Button);
            this.Draw_Panel.Controls.Add(this.SolidCircle_Button);
            this.Draw_Panel.Location = new System.Drawing.Point(11, 12);
            this.Draw_Panel.Name = "Draw_Panel";
            this.Draw_Panel.Size = new System.Drawing.Size(126, 352);
            this.Draw_Panel.TabIndex = 26;
            // 
            // Draw_Label
            // 
            this.Draw_Label.AutoSize = true;
            this.Draw_Label.Location = new System.Drawing.Point(-3, -2);
            this.Draw_Label.Name = "Draw_Label";
            this.Draw_Label.Size = new System.Drawing.Size(32, 13);
            this.Draw_Label.TabIndex = 21;
            this.Draw_Label.Text = "Draw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 721);
            this.Controls.Add(this.Draw_Panel);
            this.Controls.Add(this.DeleteAll_Button);
            this.Controls.Add(this.Brush_Panel);
            this.Controls.Add(this.Pen_Panel);
            this.Controls.Add(this.Select_Button);
            this.Controls.Add(this.Main_PictureBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Basic Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NumericUpDown)).EndInit();
            this.Pen_Panel.ResumeLayout(false);
            this.Pen_Panel.PerformLayout();
            this.Brush_Panel.ResumeLayout(false);
            this.Brush_Panel.PerformLayout();
            this.Draw_Panel.ResumeLayout(false);
            this.Draw_Panel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel Pen_Panel;
        private System.Windows.Forms.Label WidthPen_Panel;
        private System.Windows.Forms.Label Pen_Label;
        private System.Windows.Forms.Panel Brush_Panel;
        private System.Windows.Forms.Label Brush_Label;
        private System.Windows.Forms.Panel ColorBrush_Panel;
        private System.Windows.Forms.Panel Draw_Panel;
        private System.Windows.Forms.Label Draw_Label;
        private System.Windows.Forms.Panel ColorPen_Panel;
        private System.Windows.Forms.ColorDialog Pen_ColorDialog;
    }
}

