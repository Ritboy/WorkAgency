namespace curse_work
{
    partial class VakansForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zarplata_textbox = new System.Windows.Forms.TextBox();
            this.opisanie_richTextbox = new System.Windows.Forms.RichTextBox();
            this.vakans_textbox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.zanyatost_comboBox = new System.Windows.Forms.ComboBox();
            this.opyt_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sfera_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.company_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.education_comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dogovor_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Занятость*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Опыт*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ЗП";
            // 
            // zarplata_textbox
            // 
            this.zarplata_textbox.Location = new System.Drawing.Point(130, 121);
            this.zarplata_textbox.MaxLength = 6;
            this.zarplata_textbox.Name = "zarplata_textbox";
            this.zarplata_textbox.Size = new System.Drawing.Size(116, 20);
            this.zarplata_textbox.TabIndex = 4;
            this.zarplata_textbox.TextChanged += new System.EventHandler(this.zarplata_textbox_TextChanged);
            this.zarplata_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zarplata_textbox_KeyPress);
            // 
            // opisanie_richTextbox
            // 
            this.opisanie_richTextbox.Location = new System.Drawing.Point(15, 241);
            this.opisanie_richTextbox.Name = "opisanie_richTextbox";
            this.opisanie_richTextbox.Size = new System.Drawing.Size(409, 173);
            this.opisanie_richTextbox.TabIndex = 8;
            this.opisanie_richTextbox.Text = "";
            // 
            // vakans_textbox
            // 
            this.vakans_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vakans_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.vakans_textbox.Location = new System.Drawing.Point(130, 9);
            this.vakans_textbox.Name = "vakans_textbox";
            this.vakans_textbox.Size = new System.Drawing.Size(294, 20);
            this.vakans_textbox.TabIndex = 0;
            this.vakans_textbox.TextChanged += new System.EventHandler(this.vakans_textbox_TextChanged);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(93, 420);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 48;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // zanyatost_comboBox
            // 
            this.zanyatost_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zanyatost_comboBox.FormattingEnabled = true;
            this.zanyatost_comboBox.Items.AddRange(new object[] {
            "Полный рабочий день",
            "Сменный график работы",
            "Работа вахтовым методом ",
            "Частичная занятость ",
            "Временная работа / freelance",
            "Неполный рабочий день"});
            this.zanyatost_comboBox.Location = new System.Drawing.Point(130, 174);
            this.zanyatost_comboBox.Name = "zanyatost_comboBox";
            this.zanyatost_comboBox.Size = new System.Drawing.Size(294, 21);
            this.zanyatost_comboBox.TabIndex = 6;
            // 
            // opyt_comboBox
            // 
            this.opyt_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opyt_comboBox.FormattingEnabled = true;
            this.opyt_comboBox.Items.AddRange(new object[] {
            "Нет опыта",
            "От 1 года до 2 лет",
            "От 3 до 5 лет",
            "Более 6 лет"});
            this.opyt_comboBox.Location = new System.Drawing.Point(130, 147);
            this.opyt_comboBox.Name = "opyt_comboBox";
            this.opyt_comboBox.Size = new System.Drawing.Size(294, 21);
            this.opyt_comboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Отрасль *";
            // 
            // sfera_combobox
            // 
            this.sfera_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.sfera_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sfera_combobox.FormattingEnabled = true;
            this.sfera_combobox.Items.AddRange(new object[] {
            "IT, Интернет, связь, телеком",
            "Административная работа, секретариат, АХО",
            "Банки, инвестиции, лизинг",
            "Безопасность, службы охраны",
            "Бухгалтерия, финансы, аудит",
            "Государственная служба",
            "Дизайн",
            "Домашний персонал",
            "Закупки, снабжение",
            "Искусство, культура, развлечения",
            "Кадры, управление персоналом",
            "Консалтинг, стратегическое развитие",
            "Маркетинг, реклама, PR",
            "Медицина, фармацевтика, ветеринария",
            "Наука, образование, повышение квалификации",
            "Некоммерческие организации, волонтерство",
            "Продажи",
            "Промышленность, производство",
            "Рабочий персонал",
            "Сельское хозяйство",
            "СМИ, издательства",
            "Спорт, фитнес, салоны красоты, SPA",
            "Страхование",
            "Строительство, проектирование, недвижимость",
            "Сырье",
            "Топ-персонал",
            "Транспорт, логистика, ВЭД",
            "Туризм, гостиницы, общественное питание",
            "Услуги, ремонт, сервисное обслуживание",
            "Юриспруденция",
            "Другое"});
            this.sfera_combobox.Location = new System.Drawing.Point(130, 35);
            this.sfera_combobox.Name = "sfera_combobox";
            this.sfera_combobox.Size = new System.Drawing.Size(294, 21);
            this.sfera_combobox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Название вакансии*";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(12, 420);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // company_textbox
            // 
            this.company_textbox.Location = new System.Drawing.Point(130, 62);
            this.company_textbox.Name = "company_textbox";
            this.company_textbox.Size = new System.Drawing.Size(294, 20);
            this.company_textbox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Работодатель*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Образование";
            // 
            // education_comboBox
            // 
            this.education_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.education_comboBox.FormattingEnabled = true;
            this.education_comboBox.Items.AddRange(new object[] {
            "Неважно",
            "Высшее",
            "Неполное высшее",
            "Среднее специальное",
            "Среднее"});
            this.education_comboBox.Location = new System.Drawing.Point(130, 201);
            this.education_comboBox.Name = "education_comboBox";
            this.education_comboBox.Size = new System.Drawing.Size(294, 21);
            this.education_comboBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Должностные обязанности, требования и условия работы";
            // 
            // dogovor_label
            // 
            this.dogovor_label.AutoSize = true;
            this.dogovor_label.Location = new System.Drawing.Point(252, 124);
            this.dogovor_label.Name = "dogovor_label";
            this.dogovor_label.Size = new System.Drawing.Size(106, 13);
            this.dogovor_label.TabIndex = 58;
            this.dogovor_label.Text = "По договорённости";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Телефон*";
            // 
            // phone_maskedTextBox
            // 
            this.phone_maskedTextBox.Location = new System.Drawing.Point(130, 89);
            this.phone_maskedTextBox.Mask = "+0-(999) 000-0000";
            this.phone_maskedTextBox.Name = "phone_maskedTextBox";
            this.phone_maskedTextBox.Size = new System.Drawing.Size(294, 20);
            this.phone_maskedTextBox.TabIndex = 3;
            this.phone_maskedTextBox.Text = "7";
            // 
            // AddVakansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 472);
            this.Controls.Add(this.phone_maskedTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dogovor_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.education_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.company_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zarplata_textbox);
            this.Controls.Add(this.opisanie_richTextbox);
            this.Controls.Add(this.vakans_textbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.zanyatost_comboBox);
            this.Controls.Add(this.opyt_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sfera_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddVakansForm";
            this.Text = "Окно вакансии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zarplata_textbox;
        private System.Windows.Forms.RichTextBox opisanie_richTextbox;
        private System.Windows.Forms.TextBox vakans_textbox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ComboBox zanyatost_comboBox;
        private System.Windows.Forms.ComboBox opyt_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sfera_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox company_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox education_comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dogovor_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox phone_maskedTextBox;
    }
}