namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            ModuleBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            MinusPlusBtn = new Button();
            DevideBtn = new Button();
            MinusBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBox.Location = new Point(12, 6);
            TxtBox.Name = "TxtBox";
            TxtBox.ReadOnly = true;
            TxtBox.Size = new Size(444, 43);
            TxtBox.TabIndex = 0;
            TxtBox.Tag = "";
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Location = new Point(10, 61);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(76, 71);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Location = new Point(10, 138);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(76, 71);
            FourBtn.TabIndex = 2;
            FourBtn.Tag = "";
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Location = new Point(10, 215);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(76, 71);
            OneBtn.TabIndex = 3;
            OneBtn.Tag = "";
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Location = new Point(10, 292);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(76, 71);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Tag = "";
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Location = new Point(92, 292);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(76, 71);
            DotBtn.TabIndex = 8;
            DotBtn.Tag = "";
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Location = new Point(92, 215);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(76, 71);
            TwoBtn.TabIndex = 7;
            TwoBtn.Tag = "";
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Location = new Point(92, 138);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(76, 71);
            FiveBtn.TabIndex = 6;
            FiveBtn.Tag = "";
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Location = new Point(92, 61);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(76, 71);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Location = new Point(174, 292);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(76, 71);
            EqualBtn.TabIndex = 12;
            EqualBtn.Tag = "";
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Location = new Point(174, 215);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(76, 71);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Tag = "";
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Location = new Point(174, 138);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(76, 71);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Location = new Point(174, 61);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(76, 71);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // ModuleBtn
            // 
            ModuleBtn.Location = new Point(380, 292);
            ModuleBtn.Name = "ModuleBtn";
            ModuleBtn.Size = new Size(76, 71);
            ModuleBtn.TabIndex = 16;
            ModuleBtn.Text = "%";
            ModuleBtn.UseVisualStyleBackColor = true;
            ModuleBtn.Click += ModuleBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Location = new Point(380, 215);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(76, 71);
            MultiplyBtn.TabIndex = 15;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Location = new Point(380, 138);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(76, 71);
            PlusBtn.TabIndex = 14;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Location = new Point(298, 292);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(76, 71);
            MinusPlusBtn.TabIndex = 20;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // DevideBtn
            // 
            DevideBtn.Location = new Point(298, 215);
            DevideBtn.Name = "DevideBtn";
            DevideBtn.Size = new Size(76, 71);
            DevideBtn.TabIndex = 19;
            DevideBtn.Text = "/";
            DevideBtn.UseVisualStyleBackColor = true;
            DevideBtn.Click += DevideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Location = new Point(298, 138);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(76, 71);
            MinusBtn.TabIndex = 18;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(298, 61);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(158, 71);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 388);
            Controls.Add(MinusPlusBtn);
            Controls.Add(DevideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(ModuleBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button ModuleBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button MinusPlusBtn;
        private Button DevideBtn;
        private Button MinusBtn;
        private Button ClearBtn;
    }
}