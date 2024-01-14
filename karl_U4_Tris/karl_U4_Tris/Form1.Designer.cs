namespace U4_Algorithmes_Squelette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arraySortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_newRandomArray = new System.Windows.Forms.Button();
            this.textBox_unsortedArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Bubble = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Selection = new System.Windows.Forms.Button();
            this.btn_Insertion = new System.Windows.Forms.Button();
            this.btn_Merge = new System.Windows.Forms.Button();
            this.btn_compare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Bubble = new System.Windows.Forms.TextBox();
            this.textBox_Selection = new System.Windows.Forms.TextBox();
            this.textBox_Insertion = new System.Windows.Forms.TextBox();
            this.textBox_Merge = new System.Windows.Forms.TextBox();
            this.textBox_Quick = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_sortedArray = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_arrayLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_maxValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Default = new System.Windows.Forms.TextBox();
            this.btn_Default = new System.Windows.Forms.Button();
            this.btn_performance = new System.Windows.Forms.Button();
            this.btn_Quick = new System.Windows.Forms.Button();
            this.btn_trierTout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arraySortToolStripMenuItem,
            this.bubbleSortToolStripMenuItem,
            this.selectionSortToolStripMenuItem,
            this.insertionSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem,
            this.quickSortToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // arraySortToolStripMenuItem
            // 
            this.arraySortToolStripMenuItem.Name = "arraySortToolStripMenuItem";
            this.arraySortToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.arraySortToolStripMenuItem.Text = "Array.Sort()";
            this.arraySortToolStripMenuItem.Click += new System.EventHandler(this.ArraySortINFO);
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bubbleSortToolStripMenuItem.Text = "Bubble Sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.BubbleSortINFO);
            // 
            // selectionSortToolStripMenuItem
            // 
            this.selectionSortToolStripMenuItem.Name = "selectionSortToolStripMenuItem";
            this.selectionSortToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.selectionSortToolStripMenuItem.Text = "Selection Sort";
            this.selectionSortToolStripMenuItem.Click += new System.EventHandler(this.SelectionSortINFO);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.insertionSortToolStripMenuItem.Text = "Insertion Sort";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.InsertionSortINFO);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.mergeSortToolStripMenuItem.Text = "Merge Sort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.MergeSortINFO);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.quickSortToolStripMenuItem.Text = "Quick Sort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.QuickSortINFO);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.helpINFO);
            // 
            // btn_newRandomArray
            // 
            this.btn_newRandomArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newRandomArray.ForeColor = System.Drawing.Color.Red;
            this.btn_newRandomArray.Location = new System.Drawing.Point(237, 46);
            this.btn_newRandomArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newRandomArray.Name = "btn_newRandomArray";
            this.btn_newRandomArray.Size = new System.Drawing.Size(243, 64);
            this.btn_newRandomArray.TabIndex = 2;
            this.btn_newRandomArray.Text = "New Random Array";
            this.btn_newRandomArray.UseVisualStyleBackColor = true;
            this.btn_newRandomArray.Click += new System.EventHandler(this.RndArray);
            // 
            // textBox_unsortedArray
            // 
            this.textBox_unsortedArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_unsortedArray.ForeColor = System.Drawing.Color.Red;
            this.textBox_unsortedArray.Location = new System.Drawing.Point(43, 170);
            this.textBox_unsortedArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_unsortedArray.Name = "textBox_unsortedArray";
            this.textBox_unsortedArray.Size = new System.Drawing.Size(792, 30);
            this.textBox_unsortedArray.TabIndex = 3;
            this.textBox_unsortedArray.TextChanged += new System.EventHandler(this.textBox_unsortedArray_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort array in ascending order using :";
            // 
            // btn_Bubble
            // 
            this.btn_Bubble.ForeColor = System.Drawing.Color.Red;
            this.btn_Bubble.Location = new System.Drawing.Point(85, 330);
            this.btn_Bubble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Bubble.Name = "btn_Bubble";
            this.btn_Bubble.Size = new System.Drawing.Size(159, 38);
            this.btn_Bubble.TabIndex = 5;
            this.btn_Bubble.Text = "Bubble Sort";
            this.btn_Bubble.UseVisualStyleBackColor = true;
            this.btn_Bubble.Click += new System.EventHandler(this.BubbleSort);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unsorted Array";
            // 
            // btn_Selection
            // 
            this.btn_Selection.ForeColor = System.Drawing.Color.Red;
            this.btn_Selection.Location = new System.Drawing.Point(85, 393);
            this.btn_Selection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Selection.Name = "btn_Selection";
            this.btn_Selection.Size = new System.Drawing.Size(159, 38);
            this.btn_Selection.TabIndex = 7;
            this.btn_Selection.Text = "Selection Sort";
            this.btn_Selection.UseVisualStyleBackColor = true;
            this.btn_Selection.Click += new System.EventHandler(this.SelectionSort);
            // 
            // btn_Insertion
            // 
            this.btn_Insertion.ForeColor = System.Drawing.Color.Red;
            this.btn_Insertion.Location = new System.Drawing.Point(85, 455);
            this.btn_Insertion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Insertion.Name = "btn_Insertion";
            this.btn_Insertion.Size = new System.Drawing.Size(159, 38);
            this.btn_Insertion.TabIndex = 8;
            this.btn_Insertion.Text = "Insertion Sort";
            this.btn_Insertion.UseVisualStyleBackColor = true;
            this.btn_Insertion.Click += new System.EventHandler(this.InsertionSort);
            // 
            // btn_Merge
            // 
            this.btn_Merge.ForeColor = System.Drawing.Color.Red;
            this.btn_Merge.Location = new System.Drawing.Point(85, 519);
            this.btn_Merge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Merge.Name = "btn_Merge";
            this.btn_Merge.Size = new System.Drawing.Size(159, 38);
            this.btn_Merge.TabIndex = 9;
            this.btn_Merge.Text = "Merge Sort";
            this.btn_Merge.UseVisualStyleBackColor = true;
            this.btn_Merge.Click += new System.EventHandler(this.MergeSort);
            // 
            // btn_compare
            // 
            this.btn_compare.ForeColor = System.Drawing.Color.Red;
            this.btn_compare.Location = new System.Drawing.Point(668, 224);
            this.btn_compare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(167, 74);
            this.btn_compare.TabIndex = 11;
            this.btn_compare.Text = "Compare all 6 sorting algorithms";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.compareArray);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time to complete sort (ms):";
            // 
            // textBox_Bubble
            // 
            this.textBox_Bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Bubble.Location = new System.Drawing.Point(372, 334);
            this.textBox_Bubble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Bubble.Name = "textBox_Bubble";
            this.textBox_Bubble.Size = new System.Drawing.Size(165, 28);
            this.textBox_Bubble.TabIndex = 13;
            // 
            // textBox_Selection
            // 
            this.textBox_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Selection.Location = new System.Drawing.Point(372, 396);
            this.textBox_Selection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Selection.Name = "textBox_Selection";
            this.textBox_Selection.Size = new System.Drawing.Size(165, 28);
            this.textBox_Selection.TabIndex = 14;
            // 
            // textBox_Insertion
            // 
            this.textBox_Insertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Insertion.Location = new System.Drawing.Point(372, 459);
            this.textBox_Insertion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Insertion.Name = "textBox_Insertion";
            this.textBox_Insertion.Size = new System.Drawing.Size(165, 28);
            this.textBox_Insertion.TabIndex = 15;
            // 
            // textBox_Merge
            // 
            this.textBox_Merge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Merge.Location = new System.Drawing.Point(372, 522);
            this.textBox_Merge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Merge.Name = "textBox_Merge";
            this.textBox_Merge.Size = new System.Drawing.Size(165, 28);
            this.textBox_Merge.TabIndex = 16;
            // 
            // textBox_Quick
            // 
            this.textBox_Quick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Quick.Location = new System.Drawing.Point(372, 585);
            this.textBox_Quick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Quick.Name = "textBox_Quick";
            this.textBox_Quick.Size = new System.Drawing.Size(165, 28);
            this.textBox_Quick.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 28);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 28);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(16, 133);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 28);
            this.textBox3.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(652, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 322);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fastest to slowest:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(16, 226);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 28);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(16, 274);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 28);
            this.textBox6.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(16, 180);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 28);
            this.textBox4.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sorted Array";
            // 
            // textBox_sortedArray
            // 
            this.textBox_sortedArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sortedArray.ForeColor = System.Drawing.Color.Green;
            this.textBox_sortedArray.Location = new System.Drawing.Point(43, 695);
            this.textBox_sortedArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sortedArray.Name = "textBox_sortedArray";
            this.textBox_sortedArray.Size = new System.Drawing.Size(792, 30);
            this.textBox_sortedArray.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Choose array length:";
            // 
            // textBox_arrayLength
            // 
            this.textBox_arrayLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_arrayLength.Location = new System.Drawing.Point(43, 81);
            this.textBox_arrayLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_arrayLength.Name = "textBox_arrayLength";
            this.textBox_arrayLength.Size = new System.Drawing.Size(119, 28);
            this.textBox_arrayLength.TabIndex = 26;
            this.textBox_arrayLength.Text = "10";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 121);
            this.label6.MinimumSize = new System.Drawing.Size(149, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Range of values:";
            // 
            // textBox_maxValue
            // 
            this.textBox_maxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maxValue.Location = new System.Drawing.Point(397, 114);
            this.textBox_maxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_maxValue.Name = "textBox_maxValue";
            this.textBox_maxValue.Size = new System.Drawing.Size(81, 27);
            this.textBox_maxValue.TabIndex = 30;
            this.textBox_maxValue.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "0 to";
            // 
            // textBox_Default
            // 
            this.textBox_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Default.Location = new System.Drawing.Point(372, 270);
            this.textBox_Default.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Default.Name = "textBox_Default";
            this.textBox_Default.Size = new System.Drawing.Size(165, 28);
            this.textBox_Default.TabIndex = 34;
            // 
            // btn_Default
            // 
            this.btn_Default.ForeColor = System.Drawing.Color.Red;
            this.btn_Default.Location = new System.Drawing.Point(85, 267);
            this.btn_Default.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Default.Name = "btn_Default";
            this.btn_Default.Size = new System.Drawing.Size(159, 38);
            this.btn_Default.TabIndex = 32;
            this.btn_Default.Text = "Array.Sort()";
            this.btn_Default.UseVisualStyleBackColor = true;
            this.btn_Default.Click += new System.EventHandler(this.ArraySort);
            // 
            // btn_performance
            // 
            this.btn_performance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_performance.ForeColor = System.Drawing.Color.Red;
            this.btn_performance.Location = new System.Drawing.Point(652, 46);
            this.btn_performance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_performance.MaximumSize = new System.Drawing.Size(211, 89);
            this.btn_performance.MinimumSize = new System.Drawing.Size(211, 89);
            this.btn_performance.Name = "btn_performance";
            this.btn_performance.Size = new System.Drawing.Size(211, 89);
            this.btn_performance.TabIndex = 36;
            this.btn_performance.Text = "Performance Analysis (Array length set to 5000)";
            this.btn_performance.UseVisualStyleBackColor = false;
            this.btn_performance.Click += new System.EventHandler(this.performanceClick);
            // 
            // btn_Quick
            // 
            this.btn_Quick.ForeColor = System.Drawing.Color.Red;
            this.btn_Quick.Location = new System.Drawing.Point(85, 585);
            this.btn_Quick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Quick.Name = "btn_Quick";
            this.btn_Quick.Size = new System.Drawing.Size(159, 38);
            this.btn_Quick.TabIndex = 37;
            this.btn_Quick.Text = "Quick Sort";
            this.btn_Quick.UseVisualStyleBackColor = true;
            this.btn_Quick.Click += new System.EventHandler(this.QuickSort);
            // 
            // btn_trierTout
            // 
            this.btn_trierTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_trierTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_trierTout.ForeColor = System.Drawing.Color.Red;
            this.btn_trierTout.Location = new System.Drawing.Point(505, 46);
            this.btn_trierTout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_trierTout.Name = "btn_trierTout";
            this.btn_trierTout.Size = new System.Drawing.Size(125, 89);
            this.btn_trierTout.TabIndex = 38;
            this.btn_trierTout.Text = "Trier tout les algorithmes";
            this.btn_trierTout.UseVisualStyleBackColor = false;
            this.btn_trierTout.Click += new System.EventHandler(this.TrierTout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 747);
            this.Controls.Add(this.btn_trierTout);
            this.Controls.Add(this.btn_Quick);
            this.Controls.Add(this.btn_performance);
            this.Controls.Add(this.textBox_Default);
            this.Controls.Add(this.btn_Default);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_maxValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_arrayLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_sortedArray);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Quick);
            this.Controls.Add(this.textBox_Merge);
            this.Controls.Add(this.textBox_Insertion);
            this.Controls.Add(this.textBox_Selection);
            this.Controls.Add(this.textBox_Bubble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.btn_Merge);
            this.Controls.Add(this.btn_Insertion);
            this.Controls.Add(this.btn_Selection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Bubble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_unsortedArray);
            this.Controls.Add(this.btn_newRandomArray);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(918, 794);
            this.MinimumSize = new System.Drawing.Size(918, 794);
            this.Name = "Form1";
            this.Text = "Analyse des algorithmes de tri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button btn_newRandomArray;
        private System.Windows.Forms.TextBox textBox_unsortedArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bubble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Selection;
        private System.Windows.Forms.Button btn_Insertion;
        private System.Windows.Forms.Button btn_Merge;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Bubble;
        private System.Windows.Forms.TextBox textBox_Selection;
        private System.Windows.Forms.TextBox textBox_Insertion;
        private System.Windows.Forms.TextBox textBox_Merge;
        private System.Windows.Forms.TextBox textBox_Quick;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_sortedArray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_maxValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_Default;
        private System.Windows.Forms.Button btn_Default;
        private System.Windows.Forms.ToolStripMenuItem arraySortToolStripMenuItem;
        private System.Windows.Forms.Button btn_performance;
        public System.Windows.Forms.TextBox textBox_arrayLength;
        private System.Windows.Forms.Button btn_Quick;
        private System.Windows.Forms.Button btn_trierTout;
    }
}

