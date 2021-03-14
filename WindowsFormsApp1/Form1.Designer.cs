using System.Windows.Forms;

namespace WindowsFormsApp1
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
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.toysListBox = new System.Windows.Forms.ListBox();
            this.speedGroupBox = new System.Windows.Forms.GroupBox();
            this.speedSlider = new System.Windows.Forms.TrackBar();
            this.speedValue = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.TextBox();
            this.heightGroupBox = new System.Windows.Forms.GroupBox();
            this.heightSlider = new System.Windows.Forms.TrackBar();
            this.heightValue = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.TextBox();
            this.depthGroupBox = new System.Windows.Forms.GroupBox();
            this.depthSlider = new System.Windows.Forms.TrackBar();
            this.depthValue = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.TextBox();
            this.propertiesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.speedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).BeginInit();
            this.heightGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightSlider)).BeginInit();
            this.depthGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthSlider)).BeginInit();
            this.propertiesContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 16;
            this.categoriesListBox.Location = new System.Drawing.Point(12, 12);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(174, 260);
            this.categoriesListBox.TabIndex = 1;
            this.categoriesListBox.SelectedIndexChanged += new System.EventHandler(this.categoriesListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(247, 50);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(247, 106);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // toysListBox
            // 
            this.toysListBox.DisplayMember = "Name";
            this.toysListBox.FormattingEnabled = true;
            this.toysListBox.ItemHeight = 16;
            this.toysListBox.Location = new System.Drawing.Point(385, 12);
            this.toysListBox.Name = "toysListBox";
            this.toysListBox.Size = new System.Drawing.Size(168, 260);
            this.toysListBox.TabIndex = 4;
            this.toysListBox.ValueMember = "Id";
            this.toysListBox.SelectedIndexChanged += new System.EventHandler(this.toysListBox_SelectedIndexChanged);
            // 
            // speedGroupBox
            // 
            this.speedGroupBox.Controls.Add(this.speedSlider);
            this.speedGroupBox.Controls.Add(this.speedValue);
            this.speedGroupBox.Controls.Add(this.speedLabel);
            this.speedGroupBox.Location = new System.Drawing.Point(3, 3);
            this.speedGroupBox.Name = "speedGroupBox";
            this.speedGroupBox.Size = new System.Drawing.Size(273, 135);
            this.speedGroupBox.TabIndex = 5;
            this.speedGroupBox.TabStop = false;
            this.speedGroupBox.Visible = false;
            // 
            // speedSlider
            // 
            this.speedSlider.Location = new System.Drawing.Point(21, 61);
            this.speedSlider.Name = "speedSlider";
            this.speedSlider.Size = new System.Drawing.Size(234, 56);
            this.speedSlider.TabIndex = 6;
            // 
            // speedValue
            // 
            this.speedValue.Location = new System.Drawing.Point(155, 22);
            this.speedValue.Name = "speedValue";
            this.speedValue.ReadOnly = true;
            this.speedValue.Size = new System.Drawing.Size(100, 22);
            this.speedValue.TabIndex = 1;
            // 
            // speedLabel
            // 
            this.speedLabel.Location = new System.Drawing.Point(21, 21);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.ReadOnly = true;
            this.speedLabel.Size = new System.Drawing.Size(100, 22);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Speed";
            // 
            // heightGroupBox
            // 
            this.heightGroupBox.Controls.Add(this.heightSlider);
            this.heightGroupBox.Controls.Add(this.heightValue);
            this.heightGroupBox.Controls.Add(this.heightLabel);
            this.heightGroupBox.Location = new System.Drawing.Point(3, 144);
            this.heightGroupBox.Name = "heightGroupBox";
            this.heightGroupBox.Size = new System.Drawing.Size(273, 135);
            this.heightGroupBox.TabIndex = 7;
            this.heightGroupBox.TabStop = false;
            this.heightGroupBox.Visible = false;
            this.heightGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // heightSlider
            // 
            this.heightSlider.Location = new System.Drawing.Point(21, 61);
            this.heightSlider.Name = "heightSlider";
            this.heightSlider.Size = new System.Drawing.Size(234, 56);
            this.heightSlider.TabIndex = 6;
            // 
            // heightValue
            // 
            this.heightValue.Location = new System.Drawing.Point(155, 22);
            this.heightValue.Name = "heightValue";
            this.heightValue.ReadOnly = true;
            this.heightValue.Size = new System.Drawing.Size(100, 22);
            this.heightValue.TabIndex = 1;
            this.heightValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.Location = new System.Drawing.Point(21, 21);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.ReadOnly = true;
            this.heightLabel.Size = new System.Drawing.Size(100, 22);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height";
            // 
            // depthGroupBox
            // 
            this.depthGroupBox.Controls.Add(this.depthSlider);
            this.depthGroupBox.Controls.Add(this.depthValue);
            this.depthGroupBox.Controls.Add(this.depthLabel);
            this.depthGroupBox.Location = new System.Drawing.Point(3, 285);
            this.depthGroupBox.Name = "depthGroupBox";
            this.depthGroupBox.Size = new System.Drawing.Size(273, 135);
            this.depthGroupBox.TabIndex = 8;
            this.depthGroupBox.TabStop = false;
            this.depthGroupBox.Visible = false;
            this.depthGroupBox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // depthSlider
            // 
            this.depthSlider.Location = new System.Drawing.Point(21, 61);
            this.depthSlider.Name = "depthSlider";
            this.depthSlider.Size = new System.Drawing.Size(234, 56);
            this.depthSlider.TabIndex = 6;
            // 
            // depthValue
            // 
            this.depthValue.Location = new System.Drawing.Point(155, 22);
            this.depthValue.Name = "depthValue";
            this.depthValue.ReadOnly = true;
            this.depthValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.depthValue.Size = new System.Drawing.Size(100, 22);
            this.depthValue.TabIndex = 1;
            this.depthValue.TextChanged += new System.EventHandler(this.depthValue_TextChanged);
            // 
            // depthLabel
            // 
            this.depthLabel.Location = new System.Drawing.Point(21, 21);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.ReadOnly = true;
            this.depthLabel.Size = new System.Drawing.Size(100, 22);
            this.depthLabel.TabIndex = 0;
            this.depthLabel.Text = "Depth";
            // 
            // propertiesContainer
            // 
            this.propertiesContainer.Controls.Add(this.speedGroupBox);
            this.propertiesContainer.Controls.Add(this.heightGroupBox);
            this.propertiesContainer.Controls.Add(this.depthGroupBox);
            this.propertiesContainer.Location = new System.Drawing.Point(631, 12);
            this.propertiesContainer.Name = "propertiesContainer";
            this.propertiesContainer.Size = new System.Drawing.Size(297, 429);
            this.propertiesContainer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 491);
            this.Controls.Add(this.propertiesContainer);
            this.Controls.Add(this.toysListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.categoriesListBox);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.speedGroupBox.ResumeLayout(false);
            this.speedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).EndInit();
            this.heightGroupBox.ResumeLayout(false);
            this.heightGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightSlider)).EndInit();
            this.depthGroupBox.ResumeLayout(false);
            this.depthGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthSlider)).EndInit();
            this.propertiesContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox categoriesListBox;
        private Button addButton;
        private Button removeButton;
        private ListBox toysListBox;
        private GroupBox speedGroupBox;
        private GroupBox heightGroupBox;
        private TrackBar heightSlider;
        private TextBox heightValue;
        private TextBox heightLabel;
        private TrackBar speedSlider;
        private TextBox speedValue;
        private TextBox speedLabel;
        private GroupBox depthGroupBox;
        private TrackBar depthSlider;
        private TextBox depthValue;
        private TextBox depthLabel;
        private FlowLayoutPanel propertiesContainer;
    }
}

