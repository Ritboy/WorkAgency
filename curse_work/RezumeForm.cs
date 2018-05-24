using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curse_work
{
    public partial class RezumeForm : Form
    {
        public RezumeForm(string path, bool fl)
        {
            InitializeComponent();
            Path = path;
            flag = fl;
            for (int i = 0; i < Vakans.mas_vakans.Length; i++)  dolzhnost_textBox.AutoCompleteCustomSource.AddRange(Vakans.mas_vakans[i]);
            /////
            opyt_comboBox.SelectedIndex = 0;
            edu_comboBox.SelectedIndex = 0;
        }
        string Path;
        bool flag;
        int ind;
        public RezumeForm(string path, int index, bool fl)
        {
            InitializeComponent();
            Path = path;
            flag = fl;
            ind = index;
            for (int i = 0; i < Vakans.mas_vakans.Length; i++) dolzhnost_textBox.AutoCompleteCustomSource.AddRange(Vakans.mas_vakans[i]);
            Rezume type = Data.RezumeList[index];
            lastname_txtbox.Text = type.lastname;
            name_textbox.Text = type.name;
            dadname_textbox.Text = type.dadname;
            if (type.sex == "М") male_radioButton.Checked = true;
            else female_radioButton.Checked = true;
            age_textbox.Text = type.age.ToString();
            phone_maskedTextBox.Text = type.phone;
            dolzhnost_textBox.Text = type.dolzhnost;
            sfera_comboBox.Text = type.sfera;
            zp_textBox.Text = type.zarplata;
            opyt_comboBox.Text = type.opyt;
            edu_comboBox.Text = type.education;
            skills_richTextBox.Text = type.opisanie;
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            if (lastname_txtbox.Text == "" || name_textbox.Text == "" || dadname_textbox.Text == "" || age_textbox.Text == "" || dolzhnost_textBox.Text == "" || sfera_comboBox.Text == "") MessageBox.Show("Поля, отмеченные * необходимо заполнить", "Незаполненные поля",MessageBoxButtons.OK);
            else
            if (flag == true)
            {
                Rezume v = return_rezume();
                Data.RezumeList.Add(v);
                bin b = new bin();
                b.write_rezume(v, Path);
                Close();
            }
            else
            {
                bin b = new bin();
                Data.RezumeList[ind] = return_rezume();
                b.rewrite_rezume(Data.RezumeList, Path);
                Close();
            }
        }
        public Rezume return_rezume()
        {
            Rezume v = new Rezume();
            if (flag == true)
                v.id = Data.RezumeList.Count + 1;
            else
                v.id = ind + 1;
            v.lastname = lastname_txtbox.Text;
            v.name = name_textbox.Text;
            v.dadname = dadname_textbox.Text;
            v.age = Convert.ToInt32(age_textbox.Text);
            if (male_radioButton.Checked) v.sex = "М";
            else v.sex = "Ж";
            v.phone = phone_maskedTextBox.Text;
            v.dolzhnost = dolzhnost_textBox.Text;
            v.opyt = opyt_comboBox.Text;
            v.sfera = sfera_comboBox.Text;
            v.education = edu_comboBox.Text;
            if (zp_textBox.Text == "") v.zarplata = "По договорённости";
            else v.zarplata = zp_textBox.Text;
            v.opisanie = skills_richTextBox.Text;
            return v;
        }

        private void zp_textBox_TextChanged(object sender, EventArgs e)
        {
            if (zp_textBox.Text == "0") zp_textBox.Text = "";
            if (zp_textBox.Text != "") dogovor_label.Visible = false;
            else dogovor_label.Visible = true;

        }

        private void zp_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c)  || c == '\b');
        }

        private void dolzhnost_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Vakans.it.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 0;
            if (Vakans.admin.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 1;
            if (Vakans.bank.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 2;
            if (Vakans.bezopasnost.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 3;
            if (Vakans.finance.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 4;
            if (Vakans.gos.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 5;
            if (Vakans.design.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 6;
            if (Vakans.home_personal.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 7;
            if (Vakans.zakupki.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 8;
            if (Vakans.kultura_dosug.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 9;
            if (Vakans.kadry.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 10;
            if (Vakans.consulting.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 11;
            if (Vakans.marketing.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 12;
            if (Vakans.medicine.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 13;
            if (Vakans.science_education.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 14;
            if (Vakans.volonter.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 15;
            if (Vakans.sells.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 16;
            if (Vakans.industrial.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 17;
            if (Vakans.work_personal.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 18;
            if (Vakans.selhoz.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 19;
            if (Vakans.SMI.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 20;
            if (Vakans.sport.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 21;
            if (Vakans.strahovanie.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 22;
            if (Vakans.building.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 23;
            if (Vakans.resources.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 24;
            if (Vakans.top_personal.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 25;
            if (Vakans.transport.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 26;
            if (Vakans.turizm.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 27;
            if (Vakans.uslugi_remont.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 28;
            if (Vakans.urisprud.Contains(dolzhnost_textBox.Text)) sfera_comboBox.SelectedIndex = 29;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '\b' || c == '+' || c == '-');
        }

        private void age_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '\b');
        }

        private void phone_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            phone_maskedTextBox.SelectionStart = 1;
        }

        private void cancel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
