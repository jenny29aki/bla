namespace patientregistry
{
    partial class addPat
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
            System.Windows.Forms.Label sex_of_personeLabel1;
            System.Windows.Forms.Label social_statusLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label contact_telephoneLabel;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label medical_insurance_policyLabel;
            System.Windows.Forms.Label localityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label corpsLabel;
            System.Windows.Forms.Label roomLabel;
            System.Windows.Forms.Label id_patientLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPat));
            this.sex_of_personeComboBox = new System.Windows.Forms.ComboBox();
            this.social_statusComboBox = new System.Windows.Forms.ComboBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.middle_nameTextBox = new System.Windows.Forms.TextBox();
            this.contact_telephoneTextBox = new System.Windows.Forms.TextBox();
            this.medical_insurance_policyTextBox = new System.Windows.Forms.TextBox();
            this.localityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.corpsTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.id_patientTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.registrDataSet1 = new patientregistry.registrDataSet();
            this.patientInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_informationTableAdapter = new patientregistry.registrDataSetTableAdapters.patient_informationTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            sex_of_personeLabel1 = new System.Windows.Forms.Label();
            social_statusLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            contact_telephoneLabel = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            medical_insurance_policyLabel = new System.Windows.Forms.Label();
            localityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            corpsLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            id_patientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sex_of_personeLabel1
            // 
            sex_of_personeLabel1.AutoSize = true;
            sex_of_personeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sex_of_personeLabel1.Location = new System.Drawing.Point(33, 126);
            sex_of_personeLabel1.Name = "sex_of_personeLabel1";
            sex_of_personeLabel1.Size = new System.Drawing.Size(30, 15);
            sex_of_personeLabel1.TabIndex = 62;
            sex_of_personeLabel1.Text = "Пол";
            // 
            // social_statusLabel
            // 
            social_statusLabel.AutoSize = true;
            social_statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            social_statusLabel.Location = new System.Drawing.Point(11, 194);
            social_statusLabel.Name = "social_statusLabel";
            social_statusLabel.Size = new System.Drawing.Size(121, 15);
            social_statusLabel.TabIndex = 60;
            social_statusLabel.Text = "Социальный статус";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(15, 39);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(62, 15);
            surnameLabel.TabIndex = 36;
            surnameLabel.Text = "Фамилия";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(31, 70);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(32, 15);
            first_nameLabel.TabIndex = 38;
            first_nameLabel.Text = "Имя";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(17, 99);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(63, 15);
            middle_nameLabel.TabIndex = 40;
            middle_nameLabel.Text = "Отчество";
            // 
            // contact_telephoneLabel
            // 
            contact_telephoneLabel.AutoSize = true;
            contact_telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            contact_telephoneLabel.Location = new System.Drawing.Point(31, 258);
            contact_telephoneLabel.Name = "contact_telephoneLabel";
            contact_telephoneLabel.Size = new System.Drawing.Size(135, 15);
            contact_telephoneLabel.TabIndex = 42;
            contact_telephoneLabel.Text = "Контактный телефон";
            // 
            // birth_dateLabel
            // 
            birth_dateLabel.AutoSize = true;
            birth_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birth_dateLabel.Location = new System.Drawing.Point(11, 157);
            birth_dateLabel.Name = "birth_dateLabel";
            birth_dateLabel.Size = new System.Drawing.Size(98, 15);
            birth_dateLabel.TabIndex = 44;
            birth_dateLabel.Text = "Дата рождения";
            // 
            // medical_insurance_policyLabel
            // 
            medical_insurance_policyLabel.AutoSize = true;
            medical_insurance_policyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            medical_insurance_policyLabel.Location = new System.Drawing.Point(11, 226);
            medical_insurance_policyLabel.Name = "medical_insurance_policyLabel";
            medical_insurance_policyLabel.Size = new System.Drawing.Size(187, 15);
            medical_insurance_policyLabel.TabIndex = 46;
            medical_insurance_policyLabel.Text = "Страховой медицинский полис";
            // 
            // localityLabel
            // 
            localityLabel.AutoSize = true;
            localityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            localityLabel.Location = new System.Drawing.Point(17, 294);
            localityLabel.Name = "localityLabel";
            localityLabel.Size = new System.Drawing.Size(115, 15);
            localityLabel.TabIndex = 48;
            localityLabel.Text = "Населенный пункт";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            regionLabel.Location = new System.Drawing.Point(288, 295);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(43, 15);
            regionLabel.TabIndex = 50;
            regionLabel.Text = "Район";
            regionLabel.Click += new System.EventHandler(this.regionLabel_Click);
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            streetLabel.Location = new System.Drawing.Point(53, 329);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(43, 15);
            streetLabel.TabIndex = 52;
            streetLabel.Text = "Улица";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            houseLabel.Location = new System.Drawing.Point(53, 368);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(32, 15);
            houseLabel.TabIndex = 54;
            houseLabel.Text = "Дом";
            // 
            // corpsLabel
            // 
            corpsLabel.AutoSize = true;
            corpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            corpsLabel.Location = new System.Drawing.Point(177, 363);
            corpsLabel.Name = "corpsLabel";
            corpsLabel.Size = new System.Drawing.Size(47, 15);
            corpsLabel.TabIndex = 56;
            corpsLabel.Text = "Корпус";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roomLabel.Location = new System.Drawing.Point(308, 366);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(64, 15);
            roomLabel.TabIndex = 58;
            roomLabel.Text = "Квартира";
            // 
            // id_patientLabel
            // 
            id_patientLabel.AutoSize = true;
            id_patientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_patientLabel.Location = new System.Drawing.Point(17, 14);
            id_patientLabel.Name = "id_patientLabel";
            id_patientLabel.Size = new System.Drawing.Size(144, 15);
            id_patientLabel.TabIndex = 34;
            id_patientLabel.Text = "№ пациента в регистре";
            // 
            // sex_of_personeComboBox
            // 
            this.sex_of_personeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sex_of_personeComboBox.FormattingEnabled = true;
            this.sex_of_personeComboBox.Items.AddRange(new object[] {
            "женский",
            "мужской"});
            this.sex_of_personeComboBox.Location = new System.Drawing.Point(137, 123);
            this.sex_of_personeComboBox.Name = "sex_of_personeComboBox";
            this.sex_of_personeComboBox.Size = new System.Drawing.Size(192, 23);
            this.sex_of_personeComboBox.TabIndex = 63;
            // 
            // social_statusComboBox
            // 
            this.social_statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.social_statusComboBox.FormattingEnabled = true;
            this.social_statusComboBox.Items.AddRange(new object[] {
            "пенсионер",
            "работающий",
            "неработающий"});
            this.social_statusComboBox.Location = new System.Drawing.Point(138, 186);
            this.social_statusComboBox.Name = "social_statusComboBox";
            this.social_statusComboBox.Size = new System.Drawing.Size(193, 23);
            this.social_statusComboBox.TabIndex = 61;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(137, 39);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(194, 21);
            this.surnameTextBox.TabIndex = 37;
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_nameTextBox.Location = new System.Drawing.Point(137, 67);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(194, 21);
            this.first_nameTextBox.TabIndex = 39;
            this.first_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_nameTextBox.Location = new System.Drawing.Point(137, 96);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(194, 21);
            this.middle_nameTextBox.TabIndex = 41;
            this.middle_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contact_telephoneTextBox
            // 
            this.contact_telephoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contact_telephoneTextBox.Location = new System.Drawing.Point(181, 255);
            this.contact_telephoneTextBox.Name = "contact_telephoneTextBox";
            this.contact_telephoneTextBox.Size = new System.Drawing.Size(193, 21);
            this.contact_telephoneTextBox.TabIndex = 43;
            this.contact_telephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medical_insurance_policyTextBox
            // 
            this.medical_insurance_policyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medical_insurance_policyTextBox.Location = new System.Drawing.Point(204, 223);
            this.medical_insurance_policyTextBox.Name = "medical_insurance_policyTextBox";
            this.medical_insurance_policyTextBox.Size = new System.Drawing.Size(194, 21);
            this.medical_insurance_policyTextBox.TabIndex = 47;
            this.medical_insurance_policyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // localityTextBox
            // 
            this.localityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localityTextBox.Location = new System.Drawing.Point(143, 292);
            this.localityTextBox.Name = "localityTextBox";
            this.localityTextBox.Size = new System.Drawing.Size(139, 21);
            this.localityTextBox.TabIndex = 49;
            this.localityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regionTextBox
            // 
            this.regionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionTextBox.Location = new System.Drawing.Point(339, 291);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(128, 21);
            this.regionTextBox.TabIndex = 51;
            this.regionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetTextBox.Location = new System.Drawing.Point(110, 326);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(161, 21);
            this.streetTextBox.TabIndex = 53;
            this.streetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // houseTextBox
            // 
            this.houseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.houseTextBox.Location = new System.Drawing.Point(97, 358);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(50, 21);
            this.houseTextBox.TabIndex = 55;
            this.houseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // corpsTextBox
            // 
            this.corpsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.corpsTextBox.Location = new System.Drawing.Point(244, 357);
            this.corpsTextBox.Name = "corpsTextBox";
            this.corpsTextBox.Size = new System.Drawing.Size(53, 21);
            this.corpsTextBox.TabIndex = 57;
            this.corpsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomTextBox
            // 
            this.roomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomTextBox.Location = new System.Drawing.Point(392, 357);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(45, 21);
            this.roomTextBox.TabIndex = 59;
            this.roomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_patientTextBox
            // 
            this.id_patientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_patientTextBox.Location = new System.Drawing.Point(167, 12);
            this.id_patientTextBox.Name = "id_patientTextBox";
            this.id_patientTextBox.Size = new System.Drawing.Size(62, 21);
            this.id_patientTextBox.TabIndex = 35;
            this.id_patientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_patientTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.id_patientTextBox_MouseClick);
            this.id_patientTextBox.Enter += new System.EventHandler(this.id_patientTextBox_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // birthDate
            // 
            this.birthDate.CustomFormat = "00.00.0000;";
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(137, 160);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(192, 20);
            this.birthDate.TabIndex = 66;
            this.birthDate.Value = new System.DateTime(2017, 5, 12, 0, 0, 0, 0);
            // 
            // registrDataSet1
            // 
            this.registrDataSet1.DataSetName = "registrDataSet";
            this.registrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInformationBindingSource
            // 
            this.patientInformationBindingSource.DataMember = "patient information";
            this.patientInformationBindingSource.DataSource = this.registrDataSet1;
            // 
            // patient_informationTableAdapter
            // 
            this.patient_informationTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 67;
            this.textBox1.Visible = false;
            // 
            // addPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(sex_of_personeLabel1);
            this.Controls.Add(this.sex_of_personeComboBox);
            this.Controls.Add(social_statusLabel);
            this.Controls.Add(this.social_statusComboBox);
            this.Controls.Add(id_patientLabel);
            this.Controls.Add(this.id_patientTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(middle_nameLabel);
            this.Controls.Add(this.middle_nameTextBox);
            this.Controls.Add(contact_telephoneLabel);
            this.Controls.Add(this.contact_telephoneTextBox);
            this.Controls.Add(birth_dateLabel);
            this.Controls.Add(medical_insurance_policyLabel);
            this.Controls.Add(this.medical_insurance_policyTextBox);
            this.Controls.Add(localityLabel);
            this.Controls.Add(this.localityTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(houseLabel);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(corpsLabel);
            this.Controls.Add(this.corpsTextBox);
            this.Controls.Add(roomLabel);
            this.Controls.Add(this.roomTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addPat";
            this.Text = "Добавление пациента";
            this.Load += new System.EventHandler(this.addPat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sex_of_personeComboBox;
        private System.Windows.Forms.ComboBox social_statusComboBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox middle_nameTextBox;
        private System.Windows.Forms.TextBox contact_telephoneTextBox;
        private System.Windows.Forms.TextBox medical_insurance_policyTextBox;
        private System.Windows.Forms.TextBox localityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.TextBox corpsTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox id_patientTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker birthDate;
        private registrDataSet registrDataSet1;
        private System.Windows.Forms.BindingSource patientInformationBindingSource;
        private registrDataSetTableAdapters.patient_informationTableAdapter patient_informationTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}