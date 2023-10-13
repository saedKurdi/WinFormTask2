using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using WinFormTask_2.Forms.Form1.Classes;
using WinFormTask_2.Forms.Form1.DataBase;

namespace WinFormTask_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string global_id;

        public DataBase db = new DataBase();
        Person person = new Person();

        string pattern_for_surname = @"^[A-Z][a-z]{3,}$";
        string pattern_for_name = @"^[A-Z][a-z]{2,}$";
        string pattern_for_father_name = @"^[A-Z][a-z]{3,}$";
        string pattern_for_country_name = @"^[A-Z][a-z]{3,}$";
        string pattern_for_city_name = @"^[A-Z][a-z]{3,}$";
        string number_pattern = @"^*[0-9]{7,}$";
        string pattern_for_mail = @"^*[a-zA-Z0-9]@gmail.com$";

        private void surname_textbox_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(surname_textbox.Text, pattern_for_surname))
                surname_textbox.ForeColor = System.Drawing.Color.Red;
            else
                surname_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(name_textbox.Text, pattern_for_name))
                name_textbox.ForeColor = System.Drawing.Color.Red;
            else
                name_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void father_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(father_textbox.Text, pattern_for_father_name))
                father_textbox.ForeColor = System.Drawing.Color.Red;
            else
                father_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void country_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(country_textbox.Text, pattern_for_country_name))
                country_textbox.ForeColor = System.Drawing.Color.Red;
            else
                country_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void city_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(city_textbox.Text, pattern_for_city_name))
                city_textbox.ForeColor = System.Drawing.Color.Red;
            else
                city_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(phone_textbox.Text, number_pattern))
                phone_textbox.ForeColor = System.Drawing.Color.Red;
            else
                phone_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void mail_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mail_textbox.Text, pattern_for_mail))
                mail_textbox.ForeColor = System.Drawing.Color.Red;
            else
                mail_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void search_by_email_textbox_Click(object sender, EventArgs e)
        {
            if (search_by_mail_textbox.Text == "Enter Mail")
                search_by_mail_textbox.Text = "";
        }

        private void search_by_email_textbox_Leave(object sender, EventArgs e)
        {
            if (search_by_mail_textbox.Text == "")
                search_by_mail_textbox.Text = "Enter Mail";
        }

        private void search_by_email_textbox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(search_by_mail_textbox.Text, pattern_for_mail))
                search_by_mail_textbox.ForeColor = System.Drawing.Color.Red;
            else
                search_by_mail_textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void save_button_Click(object sender, EventArgs e)
        {

            if (global_id != null)
            {
                if (!Regex.IsMatch(surname_textbox.Text, pattern_for_surname))
                {
                    MessageBox.Show("Surname Must Start With Upper Case And Must Has Minimum 4 characthers !", "Surname Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                else if (!Regex.IsMatch(name_textbox.Text, pattern_for_name))
                {
                    MessageBox.Show("Name Must Start With Upper Case And Must Has Minimum 3 characthers !", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (!Regex.IsMatch(father_textbox.Text, pattern_for_father_name))
                {
                    MessageBox.Show("Father Name Must Start With Upper Case And Must Has Minimum 4 characthers !", "FatherName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (!Regex.IsMatch(country_textbox.Text, pattern_for_country_name))
                {
                    MessageBox.Show("Country name Must Start With Upper Case and Must Has Minimum 4 characthers !", "CountryName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (!Regex.IsMatch(city_textbox.Text, pattern_for_city_name))
                {
                    MessageBox.Show("City name Must Start With Upper Case and Must Has Minimum 4 characthers !", "CityName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (!Regex.IsMatch(phone_textbox.Text, number_pattern))
                {
                    MessageBox.Show("Phone Must Had Minimum 7 characthers !", "Phone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (!Regex.IsMatch(mail_textbox.Text, pattern_for_mail))
                {
                    MessageBox.Show("Mail Must End With '@gmail.com' !", "Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (female_radio_button.Checked == false && male_radio_button.Checked == false)
                {
                    MessageBox.Show("Select Your Gender !", "Gender Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                person.Surname = surname_textbox.Text;
                person.Name = name_textbox.Text;
                person.FatherName = father_textbox.Text;
                person.Country = country_textbox.Text;
                person.City = city_textbox.Text;
                person.Phone = phone_textbox.Text;
                person.BirthDay = dateTimePicker.Value;
                person.Mail = mail_textbox.Text;
                if (male_radio_button.Checked) person.Gender = 'M';
                else if (female_radio_button.Checked) person.Gender = 'F';
                MessageBox.Show("Updated Succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_button_Click(sender, new EventArgs());
                db.AddPersonToDataBase(person);
                return;
            }


            if (!Regex.IsMatch(surname_textbox.Text, pattern_for_surname))
            {
                MessageBox.Show("Surname Must Start With Upper Case And Must Has Minimum 4 characthers !", "Surname Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            else if (!Regex.IsMatch(name_textbox.Text, pattern_for_name))
            {
                MessageBox.Show("Name Must Start With Upper Case And Must Has Minimum 2 characthers !", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.IsMatch(father_textbox.Text, pattern_for_father_name))
            {
                MessageBox.Show("Father Name Must Start With Upper Case And Must Has Minimum 4 characthers !", "FatherName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.IsMatch(country_textbox.Text, pattern_for_country_name))
            {
                MessageBox.Show("Country name Must Start With Upper Case and Must Has Minimum 4 characthers !", "CountryName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.IsMatch(city_textbox.Text, pattern_for_city_name))
            {
                MessageBox.Show("City name Must Start With Upper Case and Must Has Minimum 4 characthers !", "CityName Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.IsMatch(phone_textbox.Text, number_pattern))
            {
                MessageBox.Show("Phone Must Had Minimum 7 characthers !", "Phone Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!Regex.IsMatch(mail_textbox.Text, pattern_for_mail))
            {
                MessageBox.Show("Mail Must End With '@gmail.com' !", "Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (female_radio_button.Checked == false && male_radio_button.Checked == false)
            {
                MessageBox.Show("Select Your Gender !", "Gender Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.FindPersonByMail(mail_textbox.Text) != null)
            {
                MessageBox.Show("This Mail Already Excits in our system !", "Mail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Person newPerson = new Person(name_textbox.Text, surname_textbox.Text, father_textbox.Text, country_textbox.Text, city_textbox.Text, phone_textbox.Text, mail_textbox.Text, dateTimePicker.Value);
            if (female_radio_button.Checked)
                newPerson.Gender = 'F';
            else if (male_radio_button.Checked)
                newPerson.Gender = 'M';



            if (db.FindPersonByMail(mail_textbox.Text) != null)
            {
                MessageBox.Show("This Mail Already Excits In Our System !", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mail_textbox.Text = "";
                return;
            }

            db.AddPersonToDataBase(newPerson);
            MessageBox.Show("Saved Succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_button_Click(sender, new EventArgs());
        }



        private void clear_button_Click(object sender, EventArgs e)
        {
            search_by_mail_textbox.Text = "Enter Mail";
            search_by_mail_textbox.ForeColor = System.Drawing.Color.Black;
            surname_textbox.Text = "";
            name_textbox.Text = "";
            father_textbox.Text = "";
            country_textbox.Text = "";
            city_textbox.Text = "";
            phone_textbox.Text = "";
            mail_textbox.Text = "";
            male_radio_button.Checked = false;
            female_radio_button.Checked = false;

        }
        private void load_button_Click(object sender, EventArgs e)
        {
            string mail = search_by_mail_textbox.Text;
            person = db.FindPersonByMail(mail);

            if (person == null)
                MessageBox.Show("Can Not Find user By This Mail ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                global_id = person.ID!;
                name_textbox.Text = person.Name;
                surname_textbox.Text = person.Surname;
                father_textbox.Text = person.FatherName;
                country_textbox.Text = person.Country;
                city_textbox.Text = person.City;
                phone_textbox.Text = person.Phone;
                mail_textbox.Text = person.Mail;
                dateTimePicker.Text = person.BirthDay.ToString();
                if (person.Gender == 'M') male_radio_button.Checked = true;
                else if (person.Gender == 'F') female_radio_button.Checked = true;
            }
        }

    }
}