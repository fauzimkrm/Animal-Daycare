namespace Daycare
{
    partial class PickupForm
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
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.buttonPickup = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPetName = new System.Windows.Forms.Label();
            this.labelPetType = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerPickupCharge = new System.Windows.Forms.DateTimePicker();
            this.labelCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Image = global::Daycare.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(670, 10);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 60);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backButton.TabIndex = 87;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.labelCost);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.dateTimePickerPickupCharge);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.phoneLabel);
            this.panelForm.Controls.Add(this.addressLabel);
            this.panelForm.Controls.Add(this.labelEnd);
            this.panelForm.Controls.Add(this.labelStart);
            this.panelForm.Controls.Add(this.labelOwner);
            this.panelForm.Controls.Add(this.labelPetType);
            this.panelForm.Controls.Add(this.labelPetName);
            this.panelForm.Controls.Add(this.NameLabel);
            this.panelForm.Controls.Add(this.buttonPickup);
            this.panelForm.Location = new System.Drawing.Point(130, 187);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(627, 351);
            this.panelForm.TabIndex = 98;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(13, 67);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(99, 32);
            this.phoneLabel.TabIndex = 70;
            this.phoneLabel.Text = "Pemilik";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(13, 35);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(72, 32);
            this.addressLabel.TabIndex = 71;
            this.addressLabel.Text = "Jenis";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(13, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(126, 32);
            this.NameLabel.TabIndex = 72;
            this.NameLabel.Text = "Nama Pet";
            // 
            // buttonPickup
            // 
            this.buttonPickup.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonPickup.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPickup.Location = new System.Drawing.Point(511, 284);
            this.buttonPickup.Name = "buttonPickup";
            this.buttonPickup.Size = new System.Drawing.Size(113, 47);
            this.buttonPickup.TabIndex = 69;
            this.buttonPickup.Text = "PICKUP";
            this.buttonPickup.UseVisualStyleBackColor = false;
            this.buttonPickup.Click += new System.EventHandler(this.buttonPickup_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(333, 132);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(262, 37);
            this.textBoxSearch.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 64);
            this.label2.TabIndex = 95;
            this.label2.Text = "Masukkan\r\nID Daycare";
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Image = global::Daycare.Properties.Resources.home;
            this.homeButton.Location = new System.Drawing.Point(733, 13);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(50, 50);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeButton.TabIndex = 88;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonSearch.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(624, 131);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(106, 40);
            this.buttonSearch.TabIndex = 97;
            this.buttonSearch.Text = "Cari";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 54);
            this.label1.TabIndex = 94;
            this.label1.Text = "PICKUP PET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Daycare.Properties.Resources.pawprint;
            this.pictureBox7.Location = new System.Drawing.Point(815, 81);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(76, 85);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 91;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Daycare.Properties.Resources.pawprint;
            this.pictureBox1.Location = new System.Drawing.Point(-19, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Daycare.Properties.Resources.pawprint;
            this.pictureBox10.Location = new System.Drawing.Point(-8, 22);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(58, 64);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 90;
            this.pictureBox10.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = global::Daycare.Properties.Resources.cancel;
            this.exitButton.Location = new System.Drawing.Point(789, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 89;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Daycare.Properties.Resources.pawprint;
            this.pictureBox5.Location = new System.Drawing.Point(763, 455);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 111);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 92;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 70;
            this.label3.Text = "Start Daycare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 70;
            this.label4.Text = "Plan Pickup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 70;
            this.label5.Text = "Tgl Pickup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 32);
            this.label6.TabIndex = 70;
            this.label6.Text = "Biaya Charge";
            // 
            // labelPetName
            // 
            this.labelPetName.AutoSize = true;
            this.labelPetName.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetName.Location = new System.Drawing.Point(197, 3);
            this.labelPetName.Name = "labelPetName";
            this.labelPetName.Size = new System.Drawing.Size(126, 32);
            this.labelPetName.TabIndex = 72;
            this.labelPetName.Text = "Nama Pet";
            // 
            // labelPetType
            // 
            this.labelPetType.AutoSize = true;
            this.labelPetType.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetType.Location = new System.Drawing.Point(197, 35);
            this.labelPetType.Name = "labelPetType";
            this.labelPetType.Size = new System.Drawing.Size(70, 32);
            this.labelPetType.TabIndex = 72;
            this.labelPetType.Text = "Type";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.Location = new System.Drawing.Point(197, 67);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(90, 32);
            this.labelOwner.TabIndex = 72;
            this.labelOwner.Text = "Owner";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(197, 99);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(68, 32);
            this.labelStart.TabIndex = 72;
            this.labelStart.Text = "Date";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(197, 131);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(68, 32);
            this.labelEnd.TabIndex = 72;
            this.labelEnd.Text = "Date";
            // 
            // dateTimePickerPickupCharge
            // 
            this.dateTimePickerPickupCharge.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPickupCharge.Location = new System.Drawing.Point(203, 184);
            this.dateTimePickerPickupCharge.Name = "dateTimePickerPickupCharge";
            this.dateTimePickerPickupCharge.Size = new System.Drawing.Size(395, 39);
            this.dateTimePickerPickupCharge.TabIndex = 86;
            this.dateTimePickerPickupCharge.ValueChanged += new System.EventHandler(this.countCharger);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(270, 225);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(33, 38);
            this.labelCost.TabIndex = 87;
            this.labelCost.Text = "0";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 38);
            this.label7.TabIndex = 88;
            this.label7.Text = "Rp. ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PickupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickupForm";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button buttonPickup;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelPetType;
        private System.Windows.Forms.Label labelPetName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPickupCharge;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label7;
    }
}