namespace Ejercicio_Práctico_S6
{
	partial class Form1
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
			ArriveAt_LBL = new Label();
			groupBox1 = new GroupBox();
			State_CMBOX = new ComboBox();
			PackageID_TXT = new TextBox();
			Zip_TXT = new TextBox();
			City_TXT = new TextBox();
			Address_TXT = new TextBox();
			Zip_LBL = new Label();
			State_LBL = new Label();
			City_LBL = new Label();
			Address_LBL = new Label();
			PackageID_LBL = new Label();
			ArrivedAt_TXT = new TextBox();
			groupBox2 = new GroupBox();
			Package_LSTBOX = new ListBox();
			PackageByState_CMBOX = new ComboBox();
			Back_BTN = new Button();
			ScanNew_BTN = new Button();
			Add_BTN = new Button();
			Remove_BTN = new Button();
			Edit_BTN = new Button();
			Next_BTN = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// ArriveAt_LBL
			// 
			ArriveAt_LBL.AutoSize = true;
			ArriveAt_LBL.Location = new Point(64, 38);
			ArriveAt_LBL.Name = "ArriveAt_LBL";
			ArriveAt_LBL.Size = new Size(125, 32);
			ArriveAt_LBL.TabIndex = 0;
			ArriveAt_LBL.Text = "Arrived At:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(State_CMBOX);
			groupBox1.Controls.Add(PackageID_TXT);
			groupBox1.Controls.Add(Zip_TXT);
			groupBox1.Controls.Add(City_TXT);
			groupBox1.Controls.Add(Address_TXT);
			groupBox1.Controls.Add(Zip_LBL);
			groupBox1.Controls.Add(State_LBL);
			groupBox1.Controls.Add(City_LBL);
			groupBox1.Controls.Add(Address_LBL);
			groupBox1.Controls.Add(PackageID_LBL);
			groupBox1.Location = new Point(64, 115);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1089, 383);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Package Information";
			// 
			// State_CMBOX
			// 
			State_CMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
			State_CMBOX.FormattingEnabled = true;
			State_CMBOX.Items.AddRange(new object[] { "Alabama", "Florida", "Georgia", "Kentucky", "Mississippi", "North Carolina", "South Carolina", "Tennesse", "West Virginia" });
			State_CMBOX.Location = new Point(534, 277);
			State_CMBOX.Name = "State_CMBOX";
			State_CMBOX.Size = new Size(194, 40);
			State_CMBOX.TabIndex = 11;
			// 
			// PackageID_TXT
			// 
			PackageID_TXT.Location = new Point(210, 74);
			PackageID_TXT.Name = "PackageID_TXT";
			PackageID_TXT.ReadOnly = true;
			PackageID_TXT.Size = new Size(803, 39);
			PackageID_TXT.TabIndex = 10;
			// 
			// Zip_TXT
			// 
			Zip_TXT.Location = new Point(846, 280);
			Zip_TXT.Name = "Zip_TXT";
			Zip_TXT.PlaceholderText = "5 digits";
			Zip_TXT.Size = new Size(167, 39);
			Zip_TXT.TabIndex = 9;
			// 
			// City_TXT
			// 
			City_TXT.Location = new Point(210, 280);
			City_TXT.Name = "City_TXT";
			City_TXT.Size = new Size(219, 39);
			City_TXT.TabIndex = 8;
			// 
			// Address_TXT
			// 
			Address_TXT.Location = new Point(210, 168);
			Address_TXT.Name = "Address_TXT";
			Address_TXT.Size = new Size(803, 39);
			Address_TXT.TabIndex = 7;
			// 
			// Zip_LBL
			// 
			Zip_LBL.AutoSize = true;
			Zip_LBL.Location = new Point(787, 280);
			Zip_LBL.Name = "Zip_LBL";
			Zip_LBL.Size = new Size(53, 32);
			Zip_LBL.TabIndex = 6;
			Zip_LBL.Text = "Zip:";
			// 
			// State_LBL
			// 
			State_LBL.AutoSize = true;
			State_LBL.Location = new Point(456, 283);
			State_LBL.Name = "State_LBL";
			State_LBL.Size = new Size(72, 32);
			State_LBL.TabIndex = 5;
			State_LBL.Text = "State:";
			// 
			// City_LBL
			// 
			City_LBL.AutoSize = true;
			City_LBL.Location = new Point(49, 287);
			City_LBL.Name = "City_LBL";
			City_LBL.Size = new Size(60, 32);
			City_LBL.TabIndex = 4;
			City_LBL.Text = "City:";
			// 
			// Address_LBL
			// 
			Address_LBL.AutoSize = true;
			Address_LBL.Location = new Point(49, 175);
			Address_LBL.Name = "Address_LBL";
			Address_LBL.Size = new Size(103, 32);
			Address_LBL.TabIndex = 3;
			Address_LBL.Text = "Address:";
			// 
			// PackageID_LBL
			// 
			PackageID_LBL.AutoSize = true;
			PackageID_LBL.Location = new Point(49, 81);
			PackageID_LBL.Name = "PackageID_LBL";
			PackageID_LBL.Size = new Size(135, 32);
			PackageID_LBL.TabIndex = 2;
			PackageID_LBL.Text = "Package ID:";
			// 
			// ArrivedAt_TXT
			// 
			ArrivedAt_TXT.Location = new Point(209, 31);
			ArrivedAt_TXT.Name = "ArrivedAt_TXT";
			ArrivedAt_TXT.ReadOnly = true;
			ArrivedAt_TXT.Size = new Size(425, 39);
			ArrivedAt_TXT.TabIndex = 11;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(Package_LSTBOX);
			groupBox2.Controls.Add(PackageByState_CMBOX);
			groupBox2.Location = new Point(1199, 115);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(342, 491);
			groupBox2.TabIndex = 12;
			groupBox2.TabStop = false;
			groupBox2.Text = "Package by State";
			// 
			// Package_LSTBOX
			// 
			Package_LSTBOX.FormattingEnabled = true;
			Package_LSTBOX.ItemHeight = 32;
			Package_LSTBOX.Location = new Point(44, 126);
			Package_LSTBOX.Name = "Package_LSTBOX";
			Package_LSTBOX.Size = new Size(245, 324);
			Package_LSTBOX.TabIndex = 13;
			Package_LSTBOX.SelectedIndexChanged += Package_LSTBOX_SelectedIndexChanged;
			// 
			// PackageByState_CMBOX
			// 
			PackageByState_CMBOX.DropDownStyle = ComboBoxStyle.DropDownList;
			PackageByState_CMBOX.FormattingEnabled = true;
			PackageByState_CMBOX.Items.AddRange(new object[] { "Alabama", "Florida", "Georgia", "Kentucky", "Mississippi", "North Carolina", "South Carolina", "Tennesse", "West Virginia" });
			PackageByState_CMBOX.Location = new Point(44, 57);
			PackageByState_CMBOX.Name = "PackageByState_CMBOX";
			PackageByState_CMBOX.Size = new Size(245, 40);
			PackageByState_CMBOX.TabIndex = 12;
			PackageByState_CMBOX.SelectedIndexChanged += PackageByState_CMBOX_SelectedIndexChanged;
			// 
			// Back_BTN
			// 
			Back_BTN.Location = new Point(64, 537);
			Back_BTN.Name = "Back_BTN";
			Back_BTN.Size = new Size(164, 69);
			Back_BTN.TabIndex = 13;
			Back_BTN.Text = "<BACK";
			Back_BTN.UseVisualStyleBackColor = true;
			Back_BTN.Click += Back_BTN_Click;
			// 
			// ScanNew_BTN
			// 
			ScanNew_BTN.Location = new Point(249, 537);
			ScanNew_BTN.Name = "ScanNew_BTN";
			ScanNew_BTN.Size = new Size(160, 69);
			ScanNew_BTN.TabIndex = 14;
			ScanNew_BTN.Text = "Scan New";
			ScanNew_BTN.UseVisualStyleBackColor = true;
			ScanNew_BTN.Click += ScanNew_BTN_Click;
			// 
			// Add_BTN
			// 
			Add_BTN.Location = new Point(430, 537);
			Add_BTN.Name = "Add_BTN";
			Add_BTN.Size = new Size(162, 69);
			Add_BTN.TabIndex = 15;
			Add_BTN.Text = "Add";
			Add_BTN.UseVisualStyleBackColor = true;
			Add_BTN.Click += Add_BTN_Click;
			// 
			// Remove_BTN
			// 
			Remove_BTN.Location = new Point(615, 537);
			Remove_BTN.Name = "Remove_BTN";
			Remove_BTN.Size = new Size(160, 69);
			Remove_BTN.TabIndex = 16;
			Remove_BTN.Text = "Remove";
			Remove_BTN.UseVisualStyleBackColor = true;
			Remove_BTN.Click += Remove_BTN_Click;
			// 
			// Edit_BTN
			// 
			Edit_BTN.Location = new Point(808, 537);
			Edit_BTN.Name = "Edit_BTN";
			Edit_BTN.Size = new Size(167, 69);
			Edit_BTN.TabIndex = 17;
			Edit_BTN.Text = "Edit";
			Edit_BTN.UseVisualStyleBackColor = true;
			Edit_BTN.Click += Edit_BTN_Click;
			// 
			// Next_BTN
			// 
			Next_BTN.Location = new Point(1002, 537);
			Next_BTN.Name = "Next_BTN";
			Next_BTN.Size = new Size(151, 69);
			Next_BTN.TabIndex = 18;
			Next_BTN.Text = "NEXT>";
			Next_BTN.UseVisualStyleBackColor = true;
			Next_BTN.Click += Next_BTN_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1603, 666);
			Controls.Add(Next_BTN);
			Controls.Add(Edit_BTN);
			Controls.Add(Remove_BTN);
			Controls.Add(Add_BTN);
			Controls.Add(ScanNew_BTN);
			Controls.Add(Back_BTN);
			Controls.Add(groupBox2);
			Controls.Add(ArrivedAt_TXT);
			Controls.Add(groupBox1);
			Controls.Add(ArriveAt_LBL);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			ShowIcon = false;
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Package Hub";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label ArriveAt_LBL;
		private GroupBox groupBox1;
		private TextBox City_TXT;
		private TextBox Address_TXT;
		private Label Zip_LBL;
		private Label State_LBL;
		private Label City_LBL;
		private Label Address_LBL;
		private Label PackageID_LBL;
		private ComboBox State_CMBOX;
		private TextBox PackageID_TXT;
		private TextBox Zip_TXT;
		private TextBox ArrivedAt_TXT;
		private GroupBox groupBox2;
		private ListBox Package_LSTBOX;
		private ComboBox PackageByState_CMBOX;
		private Button Back_BTN;
		private Button ScanNew_BTN;
		private Button Add_BTN;
		private Button Remove_BTN;
		private Button Edit_BTN;
		private Button Next_BTN;
	}
}