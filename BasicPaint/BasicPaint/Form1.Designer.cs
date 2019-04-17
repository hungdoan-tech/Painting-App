namespace BasicPaint
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
            this.Draw_Panel = new System.Windows.Forms.Panel();
            this.Draw_Label = new System.Windows.Forms.Label();
            this.Line_Button = new System.Windows.Forms.Button();
            this.Ecclipe_Button = new System.Windows.Forms.Button();
            this.SolidEcclipe_Button = new System.Windows.Forms.Button();
            this.Rectangle_Button = new System.Windows.Forms.Button();
            this.SolidRectangle_Button = new System.Windows.Forms.Button();
            this.SolidPolygon_Button = new System.Windows.Forms.Button();
            this.Circle_Button = new System.Windows.Forms.Button();
            this.Polygon_Button = new System.Windows.Forms.Button();
            this.SolidCircle_Button = new System.Windows.Forms.Button();
            this.DeleteAll_Button = new System.Windows.Forms.Button();
            this.Brush_Panel = new System.Windows.Forms.Panel();
            this.Brush_Label = new System.Windows.Forms.Label();
            this.ColorBrush_Panel = new System.Windows.Forms.Panel();
            this.Pen_Panel = new System.Windows.Forms.Panel();
            this.ColorPen_Panel = new System.Windows.Forms.Panel();
            this.WidthPen_Panel = new System.Windows.Forms.Label();
            this.Pen_Label = new System.Windows.Forms.Label();
            this.Dash_RadioButton = new System.Windows.Forms.RadioButton();
            this.Line_RadioButton = new System.Windows.Forms.RadioButton();
            this.Width_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Select_Button = new System.Windows.Forms.Button();
            this.Main_PictureBox = new System.Windows.Forms.PictureBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.Group_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Control_Panel = new System.Windows.Forms.Panel();
            this.Control_Label = new System.Windows.Forms.Label();
            this.Draw_Panel.SuspendLayout();
            this.Brush_Panel.SuspendLayout();
            this.Pen_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
            this.Group_ContextMenuStrip.SuspendLayout();
            this.Control_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Draw_Panel
            // 
            this.Draw_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Draw_Panel.Location = new System.Drawing.Point(12, 12);
            this.Draw_Panel.Name = "Draw_Panel";
            this.Draw_Panel.Size = new System.Drawing.Size(126, 297);
            this.Draw_Panel.TabIndex = 32;
            // 
            // Draw_Label
            // 
            this.Draw_Label.AutoSize = true;
            this.Draw_Label.Location = new System.Drawing.Point(1, 0);
            this.Draw_Label.Name = "Draw_Label";
            this.Draw_Label.Size = new System.Drawing.Size(32, 13);
            this.Draw_Label.TabIndex = 21;
            this.Draw_Label.Text = "Draw";
            // 
            // Line_Button
            // 
            this.Line_Button.Location = new System.Drawing.Point(14, 14);
            this.Line_Button.Name = "Line_Button";
            this.Line_Button.Size = new System.Drawing.Size(100, 25);
            this.Line_Button.TabIndex = 10;
            this.Line_Button.Text = "Line";
            this.Line_Button.UseVisualStyleBackColor = true;
            this.Line_Button.Click += new System.EventHandler(this.Line_Button_Click);
            // 
            // Ecclipe_Button
            // 
            this.Ecclipe_Button.Location = new System.Drawing.Point(14, 45);
            this.Ecclipe_Button.Name = "Ecclipe_Button";
            this.Ecclipe_Button.Size = new System.Drawing.Size(100, 25);
            this.Ecclipe_Button.TabIndex = 11;
            this.Ecclipe_Button.Text = "Ecclipe";
            this.Ecclipe_Button.UseVisualStyleBackColor = true;
            this.Ecclipe_Button.Click += new System.EventHandler(this.Ecclipe_Button_Click);
            // 
            // SolidEcclipe_Button
            // 
            this.SolidEcclipe_Button.Location = new System.Drawing.Point(13, 76);
            this.SolidEcclipe_Button.Name = "SolidEcclipe_Button";
            this.SolidEcclipe_Button.Size = new System.Drawing.Size(100, 25);
            this.SolidEcclipe_Button.TabIndex = 12;
            this.SolidEcclipe_Button.Text = "Solid Ecclipe";
            this.SolidEcclipe_Button.UseVisualStyleBackColor = true;
            this.SolidEcclipe_Button.Click += new System.EventHandler(this.SolidEcclipe_Button_Click);
            // 
            // Rectangle_Button
            // 
            this.Rectangle_Button.Location = new System.Drawing.Point(14, 107);
            this.Rectangle_Button.Name = "Rectangle_Button";
            this.Rectangle_Button.Size = new System.Drawing.Size(100, 25);
            this.Rectangle_Button.TabIndex = 13;
            this.Rectangle_Button.Text = "Rectangle";
            this.Rectangle_Button.UseVisualStyleBackColor = true;
            this.Rectangle_Button.Click += new System.EventHandler(this.Rectangle_Button_Click);
            // 
            // SolidRectangle_Button
            // 
            this.SolidRectangle_Button.Location = new System.Drawing.Point(14, 138);
            this.SolidRectangle_Button.Name = "SolidRectangle_Button";
            this.SolidRectangle_Button.Size = new System.Drawing.Size(100, 25);
            this.SolidRectangle_Button.TabIndex = 14;
            this.SolidRectangle_Button.Text = "Solid Rectangle";
            this.SolidRectangle_Button.UseVisualStyleBackColor = true;
            this.SolidRectangle_Button.Click += new System.EventHandler(this.SolidRectangle_Button_Click);
            // 
            // SolidPolygon_Button
            // 
            this.SolidPolygon_Button.Location = new System.Drawing.Point(13, 262);
            this.SolidPolygon_Button.Name = "SolidPolygon_Button";
            this.SolidPolygon_Button.Size = new System.Drawing.Size(100, 25);
            this.SolidPolygon_Button.TabIndex = 20;
            this.SolidPolygon_Button.Text = "Solid Polygon";
            this.SolidPolygon_Button.UseVisualStyleBackColor = true;
            this.SolidPolygon_Button.Click += new System.EventHandler(this.SolidPolygon_Button_Click);
            // 
            // Circle_Button
            // 
            this.Circle_Button.Location = new System.Drawing.Point(13, 169);
            this.Circle_Button.Name = "Circle_Button";
            this.Circle_Button.Size = new System.Drawing.Size(100, 25);
            this.Circle_Button.TabIndex = 17;
            this.Circle_Button.Text = "Circle";
            this.Circle_Button.UseVisualStyleBackColor = true;
            this.Circle_Button.Click += new System.EventHandler(this.Circle_Button_Click);
            // 
            // Polygon_Button
            // 
            this.Polygon_Button.Location = new System.Drawing.Point(13, 231);
            this.Polygon_Button.Name = "Polygon_Button";
            this.Polygon_Button.Size = new System.Drawing.Size(100, 25);
            this.Polygon_Button.TabIndex = 19;
            this.Polygon_Button.Text = "Polygon";
            this.Polygon_Button.UseVisualStyleBackColor = true;
            this.Polygon_Button.Click += new System.EventHandler(this.Polygon_Button_Click);
            // 
            // SolidCircle_Button
            // 
            this.SolidCircle_Button.Location = new System.Drawing.Point(13, 200);
            this.SolidCircle_Button.Name = "SolidCircle_Button";
            this.SolidCircle_Button.Size = new System.Drawing.Size(100, 25);
            this.SolidCircle_Button.TabIndex = 18;
            this.SolidCircle_Button.Text = "Solid Circle ";
            this.SolidCircle_Button.UseVisualStyleBackColor = true;
            this.SolidCircle_Button.Click += new System.EventHandler(this.SolidCircle_Button_Click);
            // 
            // DeleteAll_Button
            // 
            this.DeleteAll_Button.Location = new System.Drawing.Point(9, 46);
            this.DeleteAll_Button.Name = "DeleteAll_Button";
            this.DeleteAll_Button.Size = new System.Drawing.Size(100, 25);
            this.DeleteAll_Button.TabIndex = 28;
            this.DeleteAll_Button.Text = "Delete All";
            this.DeleteAll_Button.UseVisualStyleBackColor = true;
            this.DeleteAll_Button.Click += new System.EventHandler(this.DeleteAll_Button_Click);
            // 
            // Brush_Panel
            // 
            this.Brush_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Brush_Panel.Controls.Add(this.Brush_Label);
            this.Brush_Panel.Controls.Add(this.ColorBrush_Panel);
            this.Brush_Panel.Location = new System.Drawing.Point(25, 583);
            this.Brush_Panel.Name = "Brush_Panel";
            this.Brush_Panel.Size = new System.Drawing.Size(104, 45);
            this.Brush_Panel.TabIndex = 31;
            // 
            // Brush_Label
            // 
            this.Brush_Label.AutoSize = true;
            this.Brush_Label.Location = new System.Drawing.Point(1, -1);
            this.Brush_Label.Name = "Brush_Label";
            this.Brush_Label.Size = new System.Drawing.Size(34, 13);
            this.Brush_Label.TabIndex = 1;
            this.Brush_Label.Text = "Brush";
            // 
            // ColorBrush_Panel
            // 
            this.ColorBrush_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBrush_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorBrush_Panel.Location = new System.Drawing.Point(13, 16);
            this.ColorBrush_Panel.Name = "ColorBrush_Panel";
            this.ColorBrush_Panel.Size = new System.Drawing.Size(80, 15);
            this.ColorBrush_Panel.TabIndex = 0;
            this.ColorBrush_Panel.Click += new System.EventHandler(this.ColorBrush_Panel_Click);
            // 
            // Pen_Panel
            // 
            this.Pen_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pen_Panel.Controls.Add(this.ColorPen_Panel);
            this.Pen_Panel.Controls.Add(this.WidthPen_Panel);
            this.Pen_Panel.Controls.Add(this.Pen_Label);
            this.Pen_Panel.Controls.Add(this.Dash_RadioButton);
            this.Pen_Panel.Controls.Add(this.Line_RadioButton);
            this.Pen_Panel.Controls.Add(this.Width_NumericUpDown);
            this.Pen_Panel.Location = new System.Drawing.Point(25, 447);
            this.Pen_Panel.Name = "Pen_Panel";
            this.Pen_Panel.Size = new System.Drawing.Size(102, 118);
            this.Pen_Panel.TabIndex = 30;
            // 
            // ColorPen_Panel
            // 
            this.ColorPen_Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorPen_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPen_Panel.Location = new System.Drawing.Point(12, 88);
            this.ColorPen_Panel.Name = "ColorPen_Panel";
            this.ColorPen_Panel.Size = new System.Drawing.Size(80, 15);
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
            // Dash_RadioButton
            // 
            this.Dash_RadioButton.AutoSize = true;
            this.Dash_RadioButton.Location = new System.Drawing.Point(24, 16);
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
            // Select_Button
            // 
            this.Select_Button.Location = new System.Drawing.Point(9, 15);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(100, 25);
            this.Select_Button.TabIndex = 29;
            this.Select_Button.Text = "Select";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // Main_PictureBox
            // 
            this.Main_PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main_PictureBox.Location = new System.Drawing.Point(155, 12);
            this.Main_PictureBox.Name = "Main_PictureBox";
            this.Main_PictureBox.Size = new System.Drawing.Size(1061, 616);
            this.Main_PictureBox.TabIndex = 27;
            this.Main_PictureBox.TabStop = false;
            this.Main_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_PictureBox_Paint);
            this.Main_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseDown);
            this.Main_PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseMove);
            this.Main_PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseUp);
            // 
            // Group_ContextMenuStrip
            // 
            this.Group_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.ungroupToolStripMenuItem});
            this.Group_ContextMenuStrip.Name = "Group_ContextMenuStrip";
            this.Group_ContextMenuStrip.Size = new System.Drawing.Size(122, 48);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // ungroupToolStripMenuItem
            // 
            this.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            this.ungroupToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ungroupToolStripMenuItem.Text = "Ungroup";
            this.ungroupToolStripMenuItem.Click += new System.EventHandler(this.ungroupToolStripMenuItem_Click);
            // 
            // Control_Panel
            // 
            this.Control_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Control_Panel.Controls.Add(this.Control_Label);
            this.Control_Panel.Controls.Add(this.Select_Button);
            this.Control_Panel.Controls.Add(this.DeleteAll_Button);
            this.Control_Panel.Location = new System.Drawing.Point(17, 340);
            this.Control_Panel.Name = "Control_Panel";
            this.Control_Panel.Size = new System.Drawing.Size(121, 86);
            this.Control_Panel.TabIndex = 33;
            // 
            // Control_Label
            // 
            this.Control_Label.AutoSize = true;
            this.Control_Label.Location = new System.Drawing.Point(0, 0);
            this.Control_Label.Name = "Control_Label";
            this.Control_Label.Size = new System.Drawing.Size(40, 13);
            this.Control_Label.TabIndex = 30;
            this.Control_Label.Text = "Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 638);
            this.Controls.Add(this.Control_Panel);
            this.Controls.Add(this.Draw_Panel);
            this.Controls.Add(this.Brush_Panel);
            this.Controls.Add(this.Pen_Panel);
            this.Controls.Add(this.Main_PictureBox);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1249, 677);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Draw_Panel.ResumeLayout(false);
            this.Draw_Panel.PerformLayout();
            this.Brush_Panel.ResumeLayout(false);
            this.Brush_Panel.PerformLayout();
            this.Pen_Panel.ResumeLayout(false);
            this.Pen_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
            this.Group_ContextMenuStrip.ResumeLayout(false);
            this.Control_Panel.ResumeLayout(false);
            this.Control_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Draw_Panel;
        private System.Windows.Forms.Label Draw_Label;
        private System.Windows.Forms.Button Line_Button;
        private System.Windows.Forms.Button Ecclipe_Button;
        private System.Windows.Forms.Button SolidEcclipe_Button;
        private System.Windows.Forms.Button Rectangle_Button;
        private System.Windows.Forms.Button SolidRectangle_Button;
        private System.Windows.Forms.Button SolidPolygon_Button;
        private System.Windows.Forms.Button Circle_Button;
        private System.Windows.Forms.Button Polygon_Button;
        private System.Windows.Forms.Button SolidCircle_Button;
        private System.Windows.Forms.Button DeleteAll_Button;
        private System.Windows.Forms.Panel Brush_Panel;
        private System.Windows.Forms.Label Brush_Label;
        private System.Windows.Forms.Panel ColorBrush_Panel;
        private System.Windows.Forms.Panel Pen_Panel;
        private System.Windows.Forms.Panel ColorPen_Panel;
        private System.Windows.Forms.Label WidthPen_Panel;
        private System.Windows.Forms.Label Pen_Label;
        private System.Windows.Forms.RadioButton Dash_RadioButton;
        private System.Windows.Forms.RadioButton Line_RadioButton;
        private System.Windows.Forms.NumericUpDown Width_NumericUpDown;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.PictureBox Main_PictureBox;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ContextMenuStrip Group_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem;
        private System.Windows.Forms.Panel Control_Panel;
        private System.Windows.Forms.Label Control_Label;
    }
}

