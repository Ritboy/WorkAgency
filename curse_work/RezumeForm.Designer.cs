namespace curse_work
{
    partial class RezumeForm
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
            this.dadname_textbox = new System.Windows.Forms.TextBox();
            this.lastname_txtbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dogovor_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edu_comboBox = new System.Windows.Forms.ComboBox();
            this.zp_textBox = new System.Windows.Forms.TextBox();
            this.opyt_comboBox = new System.Windows.Forms.ComboBox();
            this.sfera_comboBox = new System.Windows.Forms.ComboBox();
            this.dolzhnost_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.skills_richTextBox = new System.Windows.Forms.RichTextBox();
            this.save_but = new System.Windows.Forms.Button();
            this.cancel_but = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadname_textbox
            // 
            this.dadname_textbox.Location = new System.Drawing.Point(68, 71);
            this.dadname_textbox.Name = "dadname_textbox";
            this.dadname_textbox.Size = new System.Drawing.Size(275, 20);
            this.dadname_textbox.TabIndex = 2;
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Location = new System.Drawing.Point(68, 19);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.Size = new System.Drawing.Size(275, 20);
            this.lastname_txtbox.TabIndex = 0;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(68, 45);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(275, 20);
            this.name_textbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.phone_maskedTextBox);
            this.groupBox1.Controls.Add(this.age_textbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.female_radioButton);
            this.groupBox1.Controls.Add(this.male_radioButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dadname_textbox);
            this.groupBox1.Controls.Add(this.lastname_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личная информация";
            // 
            // phone_maskedTextBox
            // 
            this.phone_maskedTextBox.Location = new System.Drawing.Point(68, 121);
            this.phone_maskedTextBox.Mask = "+0-(999) 000-0000";
            this.phone_maskedTextBox.Name = "phone_maskedTextBox";
            this.phone_maskedTextBox.Size = new System.Drawing.Size(115, 20);
            this.phone_maskedTextBox.TabIndex = 5;
            this.phone_maskedTextBox.Text = "7";
            this.phone_maskedTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.phone_maskedTextBox_MouseClick);
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(297, 96);
            this.age_textbox.MaxLength = 3;
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(46, 20);
            this.age_textbox.TabIndex = 4;
            this.age_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Возраст*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол";
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(108, 97);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(36, 17);
            this.female_radioButton.TabIndex = 9;
            this.female_radioButton.Text = "Ж";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Checked = true;
            this.male_radioButton.Location = new System.Drawing.Point(68, 97);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(34, 17);
            this.male_radioButton.TabIndex = 3;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "М";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Имя*";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dogovor_label);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.edu_comboBox);
            this.groupBox2.Controls.Add(this.zp_textBox);
            this.groupBox2.Controls.Add(this.opyt_comboBox);
            this.groupBox2.Controls.Add(this.sfera_comboBox);
            this.groupBox2.Controls.Add(this.dolzhnost_textBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Желаемая работа, опыт и образование";
            // 
            // dogovor_label
            // 
            this.dogovor_label.AutoSize = true;
            this.dogovor_label.Location = new System.Drawing.Point(265, 73);
            this.dogovor_label.Name = "dogovor_label";
            this.dogovor_label.Size = new System.Drawing.Size(106, 13);
            this.dogovor_label.TabIndex = 8;
            this.dogovor_label.Text = "По договорённости";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Образование";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "Опыт работы\r\n(по специальности)";
            // 
            // edu_comboBox
            // 
            this.edu_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edu_comboBox.FormattingEnabled = true;
            this.edu_comboBox.Items.AddRange(new object[] {
            "Высшее",
            "Неполное высшее",
            "Среднее специальное",
            "Среднее"});
            this.edu_comboBox.Location = new System.Drawing.Point(138, 131);
            this.edu_comboBox.Name = "edu_comboBox";
            this.edu_comboBox.Size = new System.Drawing.Size(121, 21);
            this.edu_comboBox.TabIndex = 4;
            this.edu_comboBox.TabStop = false;
            // 
            // zp_textBox
            // 
            this.zp_textBox.Location = new System.Drawing.Point(138, 70);
            this.zp_textBox.Name = "zp_textBox";
            this.zp_textBox.Size = new System.Drawing.Size(121, 20);
            this.zp_textBox.TabIndex = 2;
            this.zp_textBox.TextChanged += new System.EventHandler(this.zp_textBox_TextChanged);
            this.zp_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zp_textBox_KeyPress);
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
            this.opyt_comboBox.Location = new System.Drawing.Point(138, 104);
            this.opyt_comboBox.Name = "opyt_comboBox";
            this.opyt_comboBox.Size = new System.Drawing.Size(121, 21);
            this.opyt_comboBox.TabIndex = 3;
            this.opyt_comboBox.TabStop = false;
            // 
            // sfera_comboBox
            // 
            this.sfera_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sfera_comboBox.FormattingEnabled = true;
            this.sfera_comboBox.Items.AddRange(new object[] {
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
            this.sfera_comboBox.Location = new System.Drawing.Point(138, 43);
            this.sfera_comboBox.Name = "sfera_comboBox";
            this.sfera_comboBox.Size = new System.Drawing.Size(205, 21);
            this.sfera_comboBox.TabIndex = 1;
            this.sfera_comboBox.TabStop = false;
            // 
            // dolzhnost_textBox
            // 
            this.dolzhnost_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dolzhnost_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.dolzhnost_textBox.Location = new System.Drawing.Point(138, 17);
            this.dolzhnost_textBox.Name = "dolzhnost_textBox";
            this.dolzhnost_textBox.Size = new System.Drawing.Size(205, 20);
            this.dolzhnost_textBox.TabIndex = 0;
            this.dolzhnost_textBox.TextChanged += new System.EventHandler(this.dolzhnost_textBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Зарплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Отрасль *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Желаемая должность*";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.skills_richTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Навыки и умения";
            // 
            // skills_richTextBox
            // 
            this.skills_richTextBox.Location = new System.Drawing.Point(6, 19);
            this.skills_richTextBox.Name = "skills_richTextBox";
            this.skills_richTextBox.Size = new System.Drawing.Size(425, 150);
            this.skills_richTextBox.TabIndex = 0;
            this.skills_richTextBox.Text = "";
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(12, 523);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(75, 23);
            this.save_but.TabIndex = 0;
            this.save_but.Text = "Сохранить";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // cancel_but
            // 
            this.cancel_but.Location = new System.Drawing.Point(93, 523);
            this.cancel_but.Name = "cancel_but";
            this.cancel_but.Size = new System.Drawing.Size(75, 23);
            this.cancel_but.TabIndex = 8;
            this.cancel_but.Text = "Отмена";
            this.cancel_but.UseVisualStyleBackColor = true;
            this.cancel_but.Click += new System.EventHandler(this.cancel_but_Click);
            // 
            // Rezume_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 558);
            this.Controls.Add(this.cancel_but);
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Rezume_form";
            this.Text = "Окно соискателя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dadname_textbox;
        private System.Windows.Forms.TextBox lastname_txtbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox zp_textBox;
        private System.Windows.Forms.ComboBox sfera_comboBox;
        private System.Windows.Forms.TextBox dolzhnost_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox opyt_comboBox;
        private System.Windows.Forms.RichTextBox skills_richTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox edu_comboBox;
        private System.Windows.Forms.Button save_but;
        private System.Windows.Forms.Button cancel_but;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.Label dogovor_label;
        private System.Windows.Forms.MaskedTextBox phone_maskedTextBox;
    }
}