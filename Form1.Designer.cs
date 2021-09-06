
namespace folder_browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CboStyle = new System.Windows.Forms.ComboBox();
            this.textItemCount = new System.Windows.Forms.TextBox();
            this.imlSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.imlLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.checkboxToggleIcon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 148);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(57, 58);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterExpand);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 384);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(683, 199);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 332);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // CboStyle
            // 
            this.CboStyle.FormattingEnabled = true;
            this.CboStyle.Items.AddRange(new object[] {
            "Large Icons",
            "Small Icons",
            "List",
            "Tile",
            "Details"});
            this.CboStyle.Location = new System.Drawing.Point(12, 12);
            this.CboStyle.Name = "CboStyle";
            this.CboStyle.Size = new System.Drawing.Size(283, 28);
            this.CboStyle.TabIndex = 3;
            this.CboStyle.SelectedIndexChanged += new System.EventHandler(this.CboStyle_SelectedIndexChanged);
            // 
            // textItemCount
            // 
            this.textItemCount.Location = new System.Drawing.Point(301, 12);
            this.textItemCount.Name = "textItemCount";
            this.textItemCount.Size = new System.Drawing.Size(100, 26);
            this.textItemCount.TabIndex = 4;
            this.textItemCount.Text = "20";
            // 
            // imlSmallIcons
            // 
            this.imlSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSmallIcons.ImageStream")));
            this.imlSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSmallIcons.Images.SetKeyName(0, "folder-32.png");
            // 
            // imlLargeIcons
            // 
            this.imlLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLargeIcons.ImageStream")));
            this.imlLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLargeIcons.Images.SetKeyName(0, "folder-64.png");
            // 
            // checkboxToggleIcon
            // 
            this.checkboxToggleIcon.AutoSize = true;
            this.checkboxToggleIcon.Checked = true;
            this.checkboxToggleIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxToggleIcon.Location = new System.Drawing.Point(408, 12);
            this.checkboxToggleIcon.Name = "checkboxToggleIcon";
            this.checkboxToggleIcon.Size = new System.Drawing.Size(129, 24);
            this.checkboxToggleIcon.TabIndex = 5;
            this.checkboxToggleIcon.Text = "Display Icons";
            this.checkboxToggleIcon.UseVisualStyleBackColor = true;
            this.checkboxToggleIcon.CheckedChanged += new System.EventHandler(this.checkboxToggleIcon_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 593);
            this.Controls.Add(this.checkboxToggleIcon);
            this.Controls.Add(this.textItemCount);
            this.Controls.Add(this.CboStyle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Browse Folder Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox CboStyle;
        private System.Windows.Forms.TextBox textItemCount;
        private System.Windows.Forms.ImageList imlSmallIcons;
        private System.Windows.Forms.ImageList imlLargeIcons;
        private System.Windows.Forms.CheckBox checkboxToggleIcon;
    }
}

