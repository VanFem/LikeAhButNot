namespace LikeAhButNot
{
    partial class ActionSelect
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
            this.cmbVKC = new System.Windows.Forms.ComboBox();
            this.radKeyboardUp = new System.Windows.Forms.RadioButton();
            this.radKeyboardDown = new System.Windows.Forms.RadioButton();
            this.radKeyboardPress = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpKeyboard = new System.Windows.Forms.GroupBox();
            this.radKeyboardGroup = new System.Windows.Forms.RadioButton();
            this.grpMouse = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMouseMoveY = new System.Windows.Forms.NumericUpDown();
            this.numMouseMoveX = new System.Windows.Forms.NumericUpDown();
            this.chkMoveMouse = new System.Windows.Forms.CheckBox();
            this.cmbMouseClickType = new System.Windows.Forms.ComboBox();
            this.radMouseUp = new System.Windows.Forms.RadioButton();
            this.radMouseClick = new System.Windows.Forms.RadioButton();
            this.radMouseDown = new System.Windows.Forms.RadioButton();
            this.radMouseGroup = new System.Windows.Forms.RadioButton();
            this.radDelayGroup = new System.Windows.Forms.RadioButton();
            this.grpDelay = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.grpKeyboard.SuspendLayout();
            this.grpMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseMoveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseMoveX)).BeginInit();
            this.grpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVKC
            // 
            this.cmbVKC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVKC.FormattingEnabled = true;
            this.cmbVKC.Location = new System.Drawing.Point(6, 19);
            this.cmbVKC.Name = "cmbVKC";
            this.cmbVKC.Size = new System.Drawing.Size(121, 21);
            this.cmbVKC.TabIndex = 0;
            // 
            // radKeyboardUp
            // 
            this.radKeyboardUp.AutoSize = true;
            this.radKeyboardUp.Location = new System.Drawing.Point(6, 46);
            this.radKeyboardUp.Name = "radKeyboardUp";
            this.radKeyboardUp.Size = new System.Drawing.Size(60, 17);
            this.radKeyboardUp.TabIndex = 1;
            this.radKeyboardUp.TabStop = true;
            this.radKeyboardUp.Text = "Key Up";
            this.radKeyboardUp.UseVisualStyleBackColor = true;
            // 
            // radKeyboardDown
            // 
            this.radKeyboardDown.AutoSize = true;
            this.radKeyboardDown.Location = new System.Drawing.Point(6, 69);
            this.radKeyboardDown.Name = "radKeyboardDown";
            this.radKeyboardDown.Size = new System.Drawing.Size(74, 17);
            this.radKeyboardDown.TabIndex = 2;
            this.radKeyboardDown.TabStop = true;
            this.radKeyboardDown.Text = "Key Down";
            this.radKeyboardDown.UseVisualStyleBackColor = true;
            // 
            // radKeyboardPress
            // 
            this.radKeyboardPress.AutoSize = true;
            this.radKeyboardPress.Location = new System.Drawing.Point(6, 92);
            this.radKeyboardPress.Name = "radKeyboardPress";
            this.radKeyboardPress.Size = new System.Drawing.Size(79, 17);
            this.radKeyboardPress.TabIndex = 3;
            this.radKeyboardPress.TabStop = true;
            this.radKeyboardPress.Text = "Press/Click";
            this.radKeyboardPress.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(312, 367);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpKeyboard
            // 
            this.grpKeyboard.Controls.Add(this.cmbVKC);
            this.grpKeyboard.Controls.Add(this.radKeyboardUp);
            this.grpKeyboard.Controls.Add(this.radKeyboardPress);
            this.grpKeyboard.Controls.Add(this.radKeyboardDown);
            this.grpKeyboard.Location = new System.Drawing.Point(88, 12);
            this.grpKeyboard.Name = "grpKeyboard";
            this.grpKeyboard.Size = new System.Drawing.Size(293, 127);
            this.grpKeyboard.TabIndex = 5;
            this.grpKeyboard.TabStop = false;
            this.grpKeyboard.Text = "Keyboard setup";
            // 
            // radKeyboardGroup
            // 
            this.radKeyboardGroup.AutoSize = true;
            this.radKeyboardGroup.Location = new System.Drawing.Point(12, 58);
            this.radKeyboardGroup.Name = "radKeyboardGroup";
            this.radKeyboardGroup.Size = new System.Drawing.Size(70, 17);
            this.radKeyboardGroup.TabIndex = 6;
            this.radKeyboardGroup.TabStop = true;
            this.radKeyboardGroup.Text = "Keyboard";
            this.radKeyboardGroup.UseVisualStyleBackColor = true;
            this.radKeyboardGroup.CheckedChanged += new System.EventHandler(this.radKeyboardGroup_CheckedChanged);
            // 
            // grpMouse
            // 
            this.grpMouse.Controls.Add(this.label2);
            this.grpMouse.Controls.Add(this.label3);
            this.grpMouse.Controls.Add(this.numMouseMoveY);
            this.grpMouse.Controls.Add(this.numMouseMoveX);
            this.grpMouse.Controls.Add(this.chkMoveMouse);
            this.grpMouse.Controls.Add(this.cmbMouseClickType);
            this.grpMouse.Controls.Add(this.radMouseUp);
            this.grpMouse.Controls.Add(this.radMouseClick);
            this.grpMouse.Controls.Add(this.radMouseDown);
            this.grpMouse.Location = new System.Drawing.Point(88, 145);
            this.grpMouse.Name = "grpMouse";
            this.grpMouse.Size = new System.Drawing.Size(293, 127);
            this.grpMouse.TabIndex = 6;
            this.grpMouse.TabStop = false;
            this.grpMouse.Text = "Mouse setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // numMouseMoveY
            // 
            this.numMouseMoveY.Location = new System.Drawing.Point(224, 72);
            this.numMouseMoveY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMouseMoveY.Name = "numMouseMoveY";
            this.numMouseMoveY.Size = new System.Drawing.Size(63, 20);
            this.numMouseMoveY.TabIndex = 5;
            this.numMouseMoveY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numMouseMoveX
            // 
            this.numMouseMoveX.Location = new System.Drawing.Point(224, 46);
            this.numMouseMoveX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMouseMoveX.Name = "numMouseMoveX";
            this.numMouseMoveX.Size = new System.Drawing.Size(63, 20);
            this.numMouseMoveX.TabIndex = 2;
            this.numMouseMoveX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkMoveMouse
            // 
            this.chkMoveMouse.AutoSize = true;
            this.chkMoveMouse.Location = new System.Drawing.Point(200, 19);
            this.chkMoveMouse.Name = "chkMoveMouse";
            this.chkMoveMouse.Size = new System.Drawing.Size(87, 17);
            this.chkMoveMouse.TabIndex = 4;
            this.chkMoveMouse.Text = "Move mouse";
            this.chkMoveMouse.UseVisualStyleBackColor = true;
            // 
            // cmbMouseClickType
            // 
            this.cmbMouseClickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMouseClickType.FormattingEnabled = true;
            this.cmbMouseClickType.Items.AddRange(new object[] {
            "Left button",
            "Right button",
            "Middle button",
            "No click"});
            this.cmbMouseClickType.Location = new System.Drawing.Point(6, 19);
            this.cmbMouseClickType.Name = "cmbMouseClickType";
            this.cmbMouseClickType.Size = new System.Drawing.Size(121, 21);
            this.cmbMouseClickType.TabIndex = 0;
            // 
            // radMouseUp
            // 
            this.radMouseUp.AutoSize = true;
            this.radMouseUp.Location = new System.Drawing.Point(6, 46);
            this.radMouseUp.Name = "radMouseUp";
            this.radMouseUp.Size = new System.Drawing.Size(60, 17);
            this.radMouseUp.TabIndex = 1;
            this.radMouseUp.TabStop = true;
            this.radMouseUp.Text = "Key Up";
            this.radMouseUp.UseVisualStyleBackColor = true;
            // 
            // radMouseClick
            // 
            this.radMouseClick.AutoSize = true;
            this.radMouseClick.Location = new System.Drawing.Point(6, 92);
            this.radMouseClick.Name = "radMouseClick";
            this.radMouseClick.Size = new System.Drawing.Size(79, 17);
            this.radMouseClick.TabIndex = 3;
            this.radMouseClick.TabStop = true;
            this.radMouseClick.Text = "Press/Click";
            this.radMouseClick.UseVisualStyleBackColor = true;
            // 
            // radMouseDown
            // 
            this.radMouseDown.AutoSize = true;
            this.radMouseDown.Location = new System.Drawing.Point(6, 69);
            this.radMouseDown.Name = "radMouseDown";
            this.radMouseDown.Size = new System.Drawing.Size(74, 17);
            this.radMouseDown.TabIndex = 2;
            this.radMouseDown.TabStop = true;
            this.radMouseDown.Text = "Key Down";
            this.radMouseDown.UseVisualStyleBackColor = true;
            // 
            // radMouseGroup
            // 
            this.radMouseGroup.AutoSize = true;
            this.radMouseGroup.Location = new System.Drawing.Point(12, 191);
            this.radMouseGroup.Name = "radMouseGroup";
            this.radMouseGroup.Size = new System.Drawing.Size(57, 17);
            this.radMouseGroup.TabIndex = 7;
            this.radMouseGroup.TabStop = true;
            this.radMouseGroup.Text = "Mouse";
            this.radMouseGroup.UseVisualStyleBackColor = true;
            this.radMouseGroup.CheckedChanged += new System.EventHandler(this.radMouseGroup_CheckedChanged);
            // 
            // radDelayGroup
            // 
            this.radDelayGroup.AutoSize = true;
            this.radDelayGroup.Location = new System.Drawing.Point(12, 302);
            this.radDelayGroup.Name = "radDelayGroup";
            this.radDelayGroup.Size = new System.Drawing.Size(52, 17);
            this.radDelayGroup.TabIndex = 8;
            this.radDelayGroup.TabStop = true;
            this.radDelayGroup.Text = "Delay";
            this.radDelayGroup.UseVisualStyleBackColor = true;
            this.radDelayGroup.CheckedChanged += new System.EventHandler(this.radDelay_CheckedChanged);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.label1);
            this.grpDelay.Controls.Add(this.numDelay);
            this.grpDelay.Location = new System.Drawing.Point(88, 278);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Size = new System.Drawing.Size(293, 53);
            this.grpDelay.TabIndex = 7;
            this.grpDelay.TabStop = false;
            this.grpDelay.Text = "Delay setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ms";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(7, 21);
            this.numDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(108, 20);
            this.numDelay.TabIndex = 0;
            this.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ActionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 402);
            this.Controls.Add(this.grpDelay);
            this.Controls.Add(this.radDelayGroup);
            this.Controls.Add(this.radMouseGroup);
            this.Controls.Add(this.grpMouse);
            this.Controls.Add(this.radKeyboardGroup);
            this.Controls.Add(this.grpKeyboard);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 440);
            this.MinimumSize = new System.Drawing.Size(414, 440);
            this.Name = "ActionSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActionSelect";
            this.grpKeyboard.ResumeLayout(false);
            this.grpKeyboard.PerformLayout();
            this.grpMouse.ResumeLayout(false);
            this.grpMouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseMoveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseMoveX)).EndInit();
            this.grpDelay.ResumeLayout(false);
            this.grpDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVKC;
        private System.Windows.Forms.RadioButton radKeyboardUp;
        private System.Windows.Forms.RadioButton radKeyboardDown;
        private System.Windows.Forms.RadioButton radKeyboardPress;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpKeyboard;
        private System.Windows.Forms.RadioButton radKeyboardGroup;
        private System.Windows.Forms.GroupBox grpMouse;
        private System.Windows.Forms.ComboBox cmbMouseClickType;
        private System.Windows.Forms.RadioButton radMouseUp;
        private System.Windows.Forms.RadioButton radMouseClick;
        private System.Windows.Forms.RadioButton radMouseDown;
        private System.Windows.Forms.RadioButton radMouseGroup;
        private System.Windows.Forms.RadioButton radDelayGroup;
        private System.Windows.Forms.GroupBox grpDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMouseMoveY;
        private System.Windows.Forms.NumericUpDown numMouseMoveX;
        private System.Windows.Forms.CheckBox chkMoveMouse;
    }
}