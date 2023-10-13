namespace WinFormTask_2
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
            main_anket = new GroupBox();
            clear_button = new Button();
            gender_label = new Label();
            female_radio_button = new RadioButton();
            male_radio_button = new RadioButton();
            birthday_label = new Label();
            dateTimePicker = new DateTimePicker();
            mail_textbox = new TextBox();
            phone_textbox = new TextBox();
            city_textbox = new TextBox();
            country_textbox = new TextBox();
            mail_label = new Label();
            phone_label = new Label();
            city_label = new Label();
            country_label = new Label();
            father_textbox = new TextBox();
            name_textbox = new TextBox();
            surname_textbox = new TextBox();
            father_label = new Label();
            name_label = new Label();
            surname_label = new Label();
            search_by_mail_textbox = new TextBox();
            load_button = new Button();
            save_button = new Button();
            main_anket.SuspendLayout();
            SuspendLayout();
            // 
            // main_anket
            // 
            main_anket.Controls.Add(clear_button);
            main_anket.Controls.Add(gender_label);
            main_anket.Controls.Add(female_radio_button);
            main_anket.Controls.Add(male_radio_button);
            main_anket.Controls.Add(birthday_label);
            main_anket.Controls.Add(dateTimePicker);
            main_anket.Controls.Add(mail_textbox);
            main_anket.Controls.Add(phone_textbox);
            main_anket.Controls.Add(city_textbox);
            main_anket.Controls.Add(country_textbox);
            main_anket.Controls.Add(mail_label);
            main_anket.Controls.Add(phone_label);
            main_anket.Controls.Add(city_label);
            main_anket.Controls.Add(country_label);
            main_anket.Controls.Add(father_textbox);
            main_anket.Controls.Add(name_textbox);
            main_anket.Controls.Add(surname_textbox);
            main_anket.Controls.Add(father_label);
            main_anket.Controls.Add(name_label);
            main_anket.Controls.Add(surname_label);
            main_anket.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            main_anket.ForeColor = Color.Black;
            main_anket.Location = new Point(12, 40);
            main_anket.Name = "main_anket";
            main_anket.Size = new Size(378, 368);
            main_anket.TabIndex = 0;
            main_anket.TabStop = false;
            main_anket.Text = "Anket";
            // 
            // clear_button
            // 
            clear_button.Location = new Point(242, 318);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(130, 38);
            clear_button.TabIndex = 19;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gender_label.Location = new Point(15, 329);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(47, 18);
            gender_label.TabIndex = 18;
            gender_label.Text = "Gender";
            // 
            // female_radio_button
            // 
            female_radio_button.AutoSize = true;
            female_radio_button.Location = new Point(159, 325);
            female_radio_button.Name = "female_radio_button";
            female_radio_button.Size = new Size(77, 24);
            female_radio_button.TabIndex = 17;
            female_radio_button.TabStop = true;
            female_radio_button.Text = "Female";
            female_radio_button.UseVisualStyleBackColor = true;
            // 
            // male_radio_button
            // 
            male_radio_button.AutoSize = true;
            male_radio_button.Location = new Point(78, 325);
            male_radio_button.Name = "male_radio_button";
            male_radio_button.Size = new Size(63, 24);
            male_radio_button.TabIndex = 16;
            male_radio_button.TabStop = true;
            male_radio_button.Text = "Male";
            male_radio_button.UseVisualStyleBackColor = true;
            // 
            // birthday_label
            // 
            birthday_label.AutoSize = true;
            birthday_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            birthday_label.Location = new Point(15, 292);
            birthday_label.Name = "birthday_label";
            birthday_label.Size = new Size(57, 18);
            birthday_label.TabIndex = 15;
            birthday_label.Text = "Birthday";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(78, 285);
            dateTimePicker.MaxDate = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            dateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(294, 27);
            dateTimePicker.TabIndex = 14;
            dateTimePicker.Value = new DateTime(2004, 12, 1, 0, 0, 0, 0);
            // 
            // mail_textbox
            // 
            mail_textbox.Location = new Point(78, 244);
            mail_textbox.MaxLength = 30;
            mail_textbox.Name = "mail_textbox";
            mail_textbox.Size = new Size(294, 27);
            mail_textbox.TabIndex = 13;
            mail_textbox.TextChanged += mail_textbox_TextChanged;
            // 
            // phone_textbox
            // 
            phone_textbox.Location = new Point(78, 209);
            phone_textbox.MaxLength = 20;
            phone_textbox.Name = "phone_textbox";
            phone_textbox.Size = new Size(294, 27);
            phone_textbox.TabIndex = 12;
            phone_textbox.TextChanged += phone_textbox_TextChanged;
            // 
            // city_textbox
            // 
            city_textbox.Location = new Point(78, 173);
            city_textbox.MaxLength = 15;
            city_textbox.Name = "city_textbox";
            city_textbox.Size = new Size(294, 27);
            city_textbox.TabIndex = 11;
            city_textbox.TextChanged += city_textbox_TextChanged;
            // 
            // country_textbox
            // 
            country_textbox.Location = new Point(78, 140);
            country_textbox.MaxLength = 20;
            country_textbox.Name = "country_textbox";
            country_textbox.Size = new Size(294, 27);
            country_textbox.TabIndex = 10;
            country_textbox.TextChanged += country_textbox_TextChanged;
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mail_label.Location = new Point(15, 249);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(34, 18);
            mail_label.TabIndex = 9;
            mail_label.Text = "Mail";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phone_label.Location = new Point(15, 214);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(43, 18);
            phone_label.TabIndex = 8;
            phone_label.Text = "Phone";
            // 
            // city_label
            // 
            city_label.AutoSize = true;
            city_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            city_label.Location = new Point(15, 178);
            city_label.Name = "city_label";
            city_label.Size = new Size(30, 18);
            city_label.TabIndex = 7;
            city_label.Text = "City";
            // 
            // country_label
            // 
            country_label.AutoSize = true;
            country_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            country_label.Location = new Point(15, 145);
            country_label.Name = "country_label";
            country_label.Size = new Size(52, 18);
            country_label.TabIndex = 6;
            country_label.Text = "Country";
            // 
            // father_textbox
            // 
            father_textbox.Location = new Point(78, 99);
            father_textbox.MaxLength = 15;
            father_textbox.Name = "father_textbox";
            father_textbox.Size = new Size(294, 27);
            father_textbox.TabIndex = 5;
            father_textbox.TextChanged += father_textbox_TextChanged;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(78, 63);
            name_textbox.MaxLength = 15;
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(294, 27);
            name_textbox.TabIndex = 4;
            name_textbox.TextChanged += name_textbox_TextChanged;
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(78, 30);
            surname_textbox.MaxLength = 20;
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(294, 27);
            surname_textbox.TabIndex = 3;
            surname_textbox.TextChanged += surname_textbox_TextChanged;
            // 
            // father_label
            // 
            father_label.AutoSize = true;
            father_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            father_label.Location = new Point(15, 104);
            father_label.Name = "father_label";
            father_label.Size = new Size(43, 18);
            father_label.TabIndex = 2;
            father_label.Text = "Father";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Location = new Point(15, 68);
            name_label.Name = "name_label";
            name_label.Size = new Size(40, 18);
            name_label.TabIndex = 1;
            name_label.Text = "Name";
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            surname_label.Location = new Point(15, 35);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(57, 18);
            surname_label.TabIndex = 0;
            surname_label.Text = "Surname";
            // 
            // search_by_mail_textbox
            // 
            search_by_mail_textbox.Font = new Font("Candara Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            search_by_mail_textbox.Location = new Point(12, 7);
            search_by_mail_textbox.MaxLength = 30;
            search_by_mail_textbox.Name = "search_by_mail_textbox";
            search_by_mail_textbox.Size = new Size(251, 26);
            search_by_mail_textbox.TabIndex = 1;
            search_by_mail_textbox.Text = "Enter Mail";
            search_by_mail_textbox.TextAlign = HorizontalAlignment.Center;
            search_by_mail_textbox.Click += search_by_email_textbox_Click;
            search_by_mail_textbox.TextChanged += search_by_email_textbox_TextChanged;
            search_by_mail_textbox.Leave += search_by_email_textbox_Leave;
            // 
            // load_button
            // 
            load_button.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            load_button.Location = new Point(269, 7);
            load_button.Name = "load_button";
            load_button.Size = new Size(121, 27);
            load_button.TabIndex = 2;
            load_button.Text = "Load";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += load_button_Click;
            // 
            // save_button
            // 
            save_button.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            save_button.Location = new Point(12, 414);
            save_button.Name = "save_button";
            save_button.Size = new Size(378, 29);
            save_button.TabIndex = 3;
            save_button.Text = "SAVE";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 450);
            Controls.Add(save_button);
            Controls.Add(load_button);
            Controls.Add(search_by_mail_textbox);
            Controls.Add(main_anket);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anket";
            main_anket.ResumeLayout(false);
            main_anket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox main_anket;
        private Label name_label;
        private Label surname_label;
        private Label father_label;
        private TextBox father_textbox;
        private TextBox name_textbox;
        private TextBox surname_textbox;
        private TextBox search_by_mail_textbox;
        private Button load_button;
        private Label mail_label;
        private Label phone_label;
        private Label city_label;
        private Label country_label;
        private TextBox country_textbox;
        private TextBox mail_textbox;
        private TextBox phone_textbox;
        private TextBox city_textbox;
        private DateTimePicker dateTimePicker;
        private Label birthday_label;
        private Label gender_label;
        private RadioButton female_radio_button;
        private RadioButton male_radio_button;
        private Button save_button;
        private Button clear_button;
    }
}