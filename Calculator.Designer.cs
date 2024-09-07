namespace Design
{
    partial class CalculatorFrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIControlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calc_Panel = new System.Windows.Forms.Panel();
            this.Btn_Nine = new FontAwesome.Sharp.IconButton();
            this.Btn_Eight = new FontAwesome.Sharp.IconButton();
            this.Btn_Seven = new FontAwesome.Sharp.IconButton();
            this.Btn_Six = new FontAwesome.Sharp.IconButton();
            this.Btn_Five = new FontAwesome.Sharp.IconButton();
            this.Btn_Four = new FontAwesome.Sharp.IconButton();
            this.Btn_Three = new FontAwesome.Sharp.IconButton();
            this.Btn_Two = new FontAwesome.Sharp.IconButton();
            this.Btn_One = new FontAwesome.Sharp.IconButton();
            this.Btn_Delete = new FontAwesome.Sharp.IconButton();
            this.Btn_Clear = new FontAwesome.Sharp.IconButton();
            this.Btn_Divide = new FontAwesome.Sharp.IconButton();
            this.Btn_Multiply = new FontAwesome.Sharp.IconButton();
            this.Btn_Mainus = new FontAwesome.Sharp.IconButton();
            this.Dot = new FontAwesome.Sharp.IconButton();
            this.Btn_Plus = new FontAwesome.Sharp.IconButton();
            this.Btn_Equals = new FontAwesome.Sharp.IconButton();
            this.Number_Zero = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_Equation = new System.Windows.Forms.Label();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Calc_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DoubleClickEnabled = true;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uIControlerToolStripMenuItem,
            this.toolStripMenuReset});
            this.optionsToolStripMenuItem.Image = global::My_Calculator_V2.Properties.Resources.configure;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // uIControlerToolStripMenuItem
            // 
            this.uIControlerToolStripMenuItem.Image = global::My_Calculator_V2.Properties.Resources.picasa;
            this.uIControlerToolStripMenuItem.Name = "uIControlerToolStripMenuItem";
            this.uIControlerToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.uIControlerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.uIControlerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.uIControlerToolStripMenuItem.Text = "&UI Controler";
            this.uIControlerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uIControlerToolStripMenuItem.Click += new System.EventHandler(this.uIControlerToolStripMenuItem_Click);
            // 
            // toolStripMenuReset
            // 
            this.toolStripMenuReset.Image = global::My_Calculator_V2.Properties.Resources.refresh;
            this.toolStripMenuReset.Name = "toolStripMenuReset";
            this.toolStripMenuReset.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripMenuReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.toolStripMenuReset.Size = new System.Drawing.Size(223, 26);
            this.toolStripMenuReset.Text = "Reset";
            this.toolStripMenuReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuReset.Click += new System.EventHandler(this.toolStripMenuReset_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::My_Calculator_V2.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Image = global::My_Calculator_V2.Properties.Resources.info;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.dToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.dToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.dToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.dToolStripMenuItem.Text = "&Developer Info";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // Calc_Panel
            // 
            this.Calc_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.Calc_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Calc_Panel.Controls.Add(this.Btn_Nine);
            this.Calc_Panel.Controls.Add(this.Btn_Eight);
            this.Calc_Panel.Controls.Add(this.Btn_Seven);
            this.Calc_Panel.Controls.Add(this.Btn_Six);
            this.Calc_Panel.Controls.Add(this.Btn_Five);
            this.Calc_Panel.Controls.Add(this.Btn_Four);
            this.Calc_Panel.Controls.Add(this.Btn_Three);
            this.Calc_Panel.Controls.Add(this.Btn_Two);
            this.Calc_Panel.Controls.Add(this.Btn_One);
            this.Calc_Panel.Controls.Add(this.Btn_Delete);
            this.Calc_Panel.Controls.Add(this.Btn_Clear);
            this.Calc_Panel.Controls.Add(this.Btn_Divide);
            this.Calc_Panel.Controls.Add(this.Btn_Multiply);
            this.Calc_Panel.Controls.Add(this.Btn_Mainus);
            this.Calc_Panel.Controls.Add(this.Dot);
            this.Calc_Panel.Controls.Add(this.Btn_Plus);
            this.Calc_Panel.Controls.Add(this.Btn_Equals);
            this.Calc_Panel.Controls.Add(this.Number_Zero);
            this.Calc_Panel.Controls.Add(this.panel2);
            this.Calc_Panel.Location = new System.Drawing.Point(15, 51);
            this.Calc_Panel.Name = "Calc_Panel";
            this.Calc_Panel.Size = new System.Drawing.Size(396, 480);
            this.Calc_Panel.TabIndex = 1;
            // 
            // Btn_Nine
            // 
            this.Btn_Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nine.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nine.IconChar = FontAwesome.Sharp.IconChar._9;
            this.Btn_Nine.IconColor = System.Drawing.Color.Black;
            this.Btn_Nine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Nine.Location = new System.Drawing.Point(167, 164);
            this.Btn_Nine.Name = "Btn_Nine";
            this.Btn_Nine.Size = new System.Drawing.Size(62, 61);
            this.Btn_Nine.TabIndex = 18;
            this.Btn_Nine.TabStop = false;
            this.Btn_Nine.Tag = "9";
            this.Btn_Nine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Nine.UseVisualStyleBackColor = false;
            this.Btn_Nine.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Eight
            // 
            this.Btn_Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eight.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eight.IconChar = FontAwesome.Sharp.IconChar._8;
            this.Btn_Eight.IconColor = System.Drawing.Color.Black;
            this.Btn_Eight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Eight.Location = new System.Drawing.Point(91, 164);
            this.Btn_Eight.Name = "Btn_Eight";
            this.Btn_Eight.Size = new System.Drawing.Size(62, 61);
            this.Btn_Eight.TabIndex = 17;
            this.Btn_Eight.TabStop = false;
            this.Btn_Eight.Tag = "8";
            this.Btn_Eight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Eight.UseVisualStyleBackColor = false;
            this.Btn_Eight.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Seven
            // 
            this.Btn_Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Seven.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Seven.IconChar = FontAwesome.Sharp.IconChar._7;
            this.Btn_Seven.IconColor = System.Drawing.Color.Black;
            this.Btn_Seven.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Seven.Location = new System.Drawing.Point(14, 166);
            this.Btn_Seven.Name = "Btn_Seven";
            this.Btn_Seven.Size = new System.Drawing.Size(62, 61);
            this.Btn_Seven.TabIndex = 16;
            this.Btn_Seven.TabStop = false;
            this.Btn_Seven.Tag = "7";
            this.Btn_Seven.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Seven.UseVisualStyleBackColor = false;
            this.Btn_Seven.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Six
            // 
            this.Btn_Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Six.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Six.IconChar = FontAwesome.Sharp.IconChar._6;
            this.Btn_Six.IconColor = System.Drawing.Color.Black;
            this.Btn_Six.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Six.Location = new System.Drawing.Point(167, 243);
            this.Btn_Six.Name = "Btn_Six";
            this.Btn_Six.Size = new System.Drawing.Size(62, 61);
            this.Btn_Six.TabIndex = 15;
            this.Btn_Six.TabStop = false;
            this.Btn_Six.Tag = "6";
            this.Btn_Six.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Six.UseVisualStyleBackColor = false;
            this.Btn_Six.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Five
            // 
            this.Btn_Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Five.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Five.IconChar = FontAwesome.Sharp.IconChar._5;
            this.Btn_Five.IconColor = System.Drawing.Color.Black;
            this.Btn_Five.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Five.Location = new System.Drawing.Point(91, 243);
            this.Btn_Five.Name = "Btn_Five";
            this.Btn_Five.Size = new System.Drawing.Size(62, 61);
            this.Btn_Five.TabIndex = 14;
            this.Btn_Five.TabStop = false;
            this.Btn_Five.Tag = "5";
            this.Btn_Five.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Five.UseVisualStyleBackColor = false;
            this.Btn_Five.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Four
            // 
            this.Btn_Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Four.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Four.IconChar = FontAwesome.Sharp.IconChar._4;
            this.Btn_Four.IconColor = System.Drawing.Color.Black;
            this.Btn_Four.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Four.Location = new System.Drawing.Point(14, 245);
            this.Btn_Four.Name = "Btn_Four";
            this.Btn_Four.Size = new System.Drawing.Size(62, 61);
            this.Btn_Four.TabIndex = 13;
            this.Btn_Four.TabStop = false;
            this.Btn_Four.Tag = "4";
            this.Btn_Four.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Four.UseVisualStyleBackColor = false;
            this.Btn_Four.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Three
            // 
            this.Btn_Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Three.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Three.IconChar = FontAwesome.Sharp.IconChar._3;
            this.Btn_Three.IconColor = System.Drawing.Color.Black;
            this.Btn_Three.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Three.Location = new System.Drawing.Point(167, 322);
            this.Btn_Three.Name = "Btn_Three";
            this.Btn_Three.Size = new System.Drawing.Size(62, 61);
            this.Btn_Three.TabIndex = 12;
            this.Btn_Three.TabStop = false;
            this.Btn_Three.Tag = "3";
            this.Btn_Three.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Three.UseVisualStyleBackColor = false;
            this.Btn_Three.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Two
            // 
            this.Btn_Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Two.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Two.IconChar = FontAwesome.Sharp.IconChar._2;
            this.Btn_Two.IconColor = System.Drawing.Color.Black;
            this.Btn_Two.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Two.Location = new System.Drawing.Point(91, 322);
            this.Btn_Two.Name = "Btn_Two";
            this.Btn_Two.Size = new System.Drawing.Size(62, 61);
            this.Btn_Two.TabIndex = 11;
            this.Btn_Two.TabStop = false;
            this.Btn_Two.Tag = "2";
            this.Btn_Two.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Two.UseVisualStyleBackColor = false;
            this.Btn_Two.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_One
            // 
            this.Btn_One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_One.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_One.IconChar = FontAwesome.Sharp.IconChar._1;
            this.Btn_One.IconColor = System.Drawing.Color.Black;
            this.Btn_One.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_One.Location = new System.Drawing.Point(14, 324);
            this.Btn_One.Name = "Btn_One";
            this.Btn_One.Size = new System.Drawing.Size(62, 61);
            this.Btn_One.TabIndex = 10;
            this.Btn_One.TabStop = false;
            this.Btn_One.Tag = "1";
            this.Btn_One.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_One.UseVisualStyleBackColor = false;
            this.Btn_One.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.Btn_Delete.IconColor = System.Drawing.Color.Black;
            this.Btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Delete.Location = new System.Drawing.Point(319, 164);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(62, 61);
            this.Btn_Delete.TabIndex = 9;
            this.Btn_Delete.TabStop = false;
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Clear.IconColor = System.Drawing.Color.Black;
            this.Btn_Clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Clear.Location = new System.Drawing.Point(319, 243);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(62, 61);
            this.Btn_Clear.TabIndex = 8;
            this.Btn_Clear.TabStop = false;
            this.Btn_Clear.Text = "C";
            this.Btn_Clear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Divide
            // 
            this.Btn_Divide.BackColor = System.Drawing.Color.White;
            this.Btn_Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Divide.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Divide.IconChar = FontAwesome.Sharp.IconChar.Divide;
            this.Btn_Divide.IconColor = System.Drawing.Color.Black;
            this.Btn_Divide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Divide.Location = new System.Drawing.Point(243, 164);
            this.Btn_Divide.Name = "Btn_Divide";
            this.Btn_Divide.Size = new System.Drawing.Size(62, 61);
            this.Btn_Divide.TabIndex = 7;
            this.Btn_Divide.TabStop = false;
            this.Btn_Divide.Tag = "/";
            this.Btn_Divide.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Divide.UseVisualStyleBackColor = false;
            this.Btn_Divide.Click += new System.EventHandler(this.Btn_Divide_Click);
            // 
            // Btn_Multiply
            // 
            this.Btn_Multiply.BackColor = System.Drawing.Color.White;
            this.Btn_Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Multiply.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiply.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Btn_Multiply.IconColor = System.Drawing.Color.Black;
            this.Btn_Multiply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Multiply.Location = new System.Drawing.Point(243, 243);
            this.Btn_Multiply.Name = "Btn_Multiply";
            this.Btn_Multiply.Size = new System.Drawing.Size(62, 61);
            this.Btn_Multiply.TabIndex = 6;
            this.Btn_Multiply.TabStop = false;
            this.Btn_Multiply.Tag = "*";
            this.Btn_Multiply.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Multiply.UseVisualStyleBackColor = false;
            this.Btn_Multiply.Click += new System.EventHandler(this.Btn_Multiply_Click);
            // 
            // Btn_Mainus
            // 
            this.Btn_Mainus.BackColor = System.Drawing.Color.White;
            this.Btn_Mainus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mainus.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mainus.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.Btn_Mainus.IconColor = System.Drawing.Color.Black;
            this.Btn_Mainus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Mainus.Location = new System.Drawing.Point(243, 322);
            this.Btn_Mainus.Name = "Btn_Mainus";
            this.Btn_Mainus.Size = new System.Drawing.Size(62, 61);
            this.Btn_Mainus.TabIndex = 5;
            this.Btn_Mainus.TabStop = false;
            this.Btn_Mainus.Tag = "-";
            this.Btn_Mainus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Mainus.UseVisualStyleBackColor = false;
            this.Btn_Mainus.Click += new System.EventHandler(this.Btn_Mainus_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dot.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Dot.IconColor = System.Drawing.Color.Black;
            this.Dot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dot.Location = new System.Drawing.Point(167, 402);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(62, 61);
            this.Dot.TabIndex = 4;
            this.Dot.TabStop = false;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Btn_Plus
            // 
            this.Btn_Plus.BackColor = System.Drawing.Color.White;
            this.Btn_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Plus.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Plus.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Btn_Plus.IconColor = System.Drawing.Color.Black;
            this.Btn_Plus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Plus.Location = new System.Drawing.Point(243, 401);
            this.Btn_Plus.Name = "Btn_Plus";
            this.Btn_Plus.Size = new System.Drawing.Size(62, 61);
            this.Btn_Plus.TabIndex = 3;
            this.Btn_Plus.TabStop = false;
            this.Btn_Plus.Tag = "+";
            this.Btn_Plus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Btn_Plus.UseVisualStyleBackColor = false;
            this.Btn_Plus.Click += new System.EventHandler(this.Btn_Plus_Click);
            // 
            // Btn_Equals
            // 
            this.Btn_Equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Btn_Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Equals.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Equals.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Equals.IconColor = System.Drawing.Color.Black;
            this.Btn_Equals.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Equals.Location = new System.Drawing.Point(319, 324);
            this.Btn_Equals.Name = "Btn_Equals";
            this.Btn_Equals.Size = new System.Drawing.Size(61, 139);
            this.Btn_Equals.TabIndex = 2;
            this.Btn_Equals.Tag = "=";
            this.Btn_Equals.Text = "=";
            this.Btn_Equals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Equals.UseVisualStyleBackColor = false;
            this.Btn_Equals.Click += new System.EventHandler(this.Btn_Equals_Click);
            // 
            // Number_Zero
            // 
            this.Number_Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.Number_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Number_Zero.Font = new System.Drawing.Font("Readex Pro SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Zero.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Number_Zero.IconColor = System.Drawing.Color.Black;
            this.Number_Zero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Number_Zero.Location = new System.Drawing.Point(14, 402);
            this.Number_Zero.Name = "Number_Zero";
            this.Number_Zero.Size = new System.Drawing.Size(139, 61);
            this.Number_Zero.TabIndex = 1;
            this.Number_Zero.TabStop = false;
            this.Number_Zero.Tag = "0";
            this.Number_Zero.Text = "0";
            this.Number_Zero.UseVisualStyleBackColor = false;
            this.Number_Zero.Click += new System.EventHandler(this.Number_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.LB_Equation);
            this.panel2.Controls.Add(this.TB_Result);
            this.panel2.Location = new System.Drawing.Point(14, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 100);
            this.panel2.TabIndex = 0;
            // 
            // LB_Equation
            // 
            this.LB_Equation.AutoSize = true;
            this.LB_Equation.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.LB_Equation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_Equation.Location = new System.Drawing.Point(9, 18);
            this.LB_Equation.Name = "LB_Equation";
            this.LB_Equation.Size = new System.Drawing.Size(59, 23);
            this.LB_Equation.TabIndex = 1;
            this.LB_Equation.Text = "label1";
            // 
            // TB_Result
            // 
            this.TB_Result.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TB_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Result.Font = new System.Drawing.Font("Trebuchet MS", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Result.Location = new System.Drawing.Point(12, 49);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(351, 45);
            this.TB_Result.TabIndex = 0;
            this.TB_Result.TabStop = false;
            this.TB_Result.Text = "0";
            // 
            // CalculatorFrm
            // 
            this.AcceptButton = this.Btn_Equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(220)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(424, 538);
            this.Controls.Add(this.Calc_Panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CalculatorFrm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keys_Pressed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Calc_Panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public FontAwesome.Sharp.IconButton Number_Zero;
        public System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton Btn_Equals;
        public FontAwesome.Sharp.IconButton Dot;
        public FontAwesome.Sharp.IconButton Btn_Plus;
        public FontAwesome.Sharp.IconButton Btn_Clear;
        public FontAwesome.Sharp.IconButton Btn_Divide;
        public FontAwesome.Sharp.IconButton Btn_Multiply;
        public FontAwesome.Sharp.IconButton Btn_Mainus;
        public FontAwesome.Sharp.IconButton Btn_Delete;
        public FontAwesome.Sharp.IconButton Btn_Nine;
        public FontAwesome.Sharp.IconButton Btn_Eight;
        public FontAwesome.Sharp.IconButton Btn_Seven;
        public FontAwesome.Sharp.IconButton Btn_Six;
        public FontAwesome.Sharp.IconButton Btn_Five;
        public FontAwesome.Sharp.IconButton Btn_Four;
        public FontAwesome.Sharp.IconButton Btn_Three;
        public FontAwesome.Sharp.IconButton Btn_Two;
        public FontAwesome.Sharp.IconButton Btn_One;
        public System.Windows.Forms.TextBox TB_Result;
        public System.Windows.Forms.Label LB_Equation;
        public System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem uIControlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuReset;
        public System.Windows.Forms.Panel Calc_Panel;
    }
}
