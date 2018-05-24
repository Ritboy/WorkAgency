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
    public partial class VakansForm : Form
    {
        // Data data = new Data();
        public VakansForm(string path, bool fl)
        {
            InitializeComponent();
            Path = path;
            flag = fl;
            for (int i = 0; i < Vakans.mas_vakans.Length; i++) vakans_textbox.AutoCompleteCustomSource.AddRange(Vakans.mas_vakans[i]);
            //заполняю комбобоксы дефолтными значениями
            opyt_comboBox.SelectedIndex = 0;
            zanyatost_comboBox.SelectedIndex = 0;
            education_comboBox.SelectedIndex = 0;
        }
        string Path;
        bool flag;
        int ind;
        public VakansForm(string path, int index, bool fl)
        {
            InitializeComponent();
            Path = path;
            flag = fl;
            ind = index;
            for (int i = 0; i < Vakans.mas_vakans.Length; i++) vakans_textbox.AutoCompleteCustomSource.AddRange(Vakans.mas_vakans[i]);
            Vakans type = Data.VakansList[index];
            company_textbox.Text = type.company;
            phone_maskedTextBox.Text = type.phone;
            vakans_textbox.Text = type.dolzhnost;
            sfera_combobox.Text = type.otrasl;
            zarplata_textbox.Text = type.zarplata;
            opyt_comboBox.Text = type.opyt;
            zanyatost_comboBox.Text = type.zanyatost;
            education_comboBox.Text = type.education;
            opisanie_richTextbox.Text = type.opisanie;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (vakans_textbox.Text == "" || sfera_combobox.Text == "" || company_textbox.Text == "" || phone_maskedTextBox.Text.Length < 17)
                MessageBox.Show("Поля, отмеченные * необходимо заполнить", "Упс", MessageBoxButtons.OK);
            else
            if (flag == true)
            {
                Vakans v = return_vakans();
                Data.VakansList.Add(v);
                bin b = new bin();
                b.write_vakans(v, Path);
                Close();
            }
            else
            {
                bin b = new bin();
                Data.VakansList[ind] = return_vakans();
                b.rewrite_vakans(Data.VakansList, Path);
                Close();
            }
        }
        public Vakans return_vakans()
        {
            Vakans v = new Vakans();
            if (flag == true)
                v.id = Data.VakansList.Count + 1;
            else
                v.id = ind+1;
            v.company = company_textbox.Text;
            v.phone = phone_maskedTextBox.Text;
            v.dolzhnost = vakans_textbox.Text;
            v.opyt = opyt_comboBox.Text;
            v.otrasl = sfera_combobox.Text;
            v.zanyatost = zanyatost_comboBox.Text;
            if (zarplata_textbox.Text == "") v.zarplata = "По договорённости";
            else v.zarplata = zarplata_textbox.Text;
            v.education = education_comboBox.Text;
            v.opisanie = opisanie_richTextbox.Text;
            return v;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vakans_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Vakans.it.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 0;
            if (Vakans.admin.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 1;
            if (Vakans.bank.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 2;
            if (Vakans.bezopasnost.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 3;
            if (Vakans.finance.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 4;
            if (Vakans.gos.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 5;
            if (Vakans.design.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 6;
            if (Vakans.home_personal.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 7;
            if (Vakans.zakupki.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 8;
            if (Vakans.kultura_dosug.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 9;
            if (Vakans.kadry.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 10;
            if (Vakans.consulting.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 11;
            if (Vakans.marketing.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 12;
            if (Vakans.medicine.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 13;
            if (Vakans.science_education.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 14;
            if (Vakans.volonter.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 15;
            if (Vakans.sells.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 16;
            if (Vakans.industrial.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 17;
            if (Vakans.work_personal.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 18;
            if (Vakans.selhoz.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 19;
            if (Vakans.SMI.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 20;
            if (Vakans.sport.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 21;
            if (Vakans.strahovanie.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 22;
            if (Vakans.building.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 23;
            if (Vakans.resources.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 24;
            if (Vakans.top_personal.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 25;
            if (Vakans.transport.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 26;
            if (Vakans.turizm.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 27;
            if (Vakans.uslugi_remont.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 28;
            if (Vakans.urisprud.Contains(vakans_textbox.Text)) sfera_combobox.SelectedIndex = 29;
        }

        private void zarplata_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(char.IsDigit(c) || c == '\b');
        }

        private void zarplata_textbox_TextChanged(object sender, EventArgs e)
        {
            if (zarplata_textbox.Text == "0") zarplata_textbox.Text = "";
            if (zarplata_textbox.Text != "") dogovor_label.Visible = false;
            else dogovor_label.Visible = true;
        }

        private void phone_maskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            phone_maskedTextBox.SelectionStart = 1;
        }
    }
}
