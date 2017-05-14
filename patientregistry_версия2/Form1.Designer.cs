namespace patientregistry
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_patientLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            System.Windows.Forms.Label contact_telephoneLabel;
            System.Windows.Forms.Label medical_insurance_policyLabel;
            System.Windows.Forms.Label localityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label houseLabel;
            System.Windows.Forms.Label corpsLabel;
            System.Windows.Forms.Label roomLabel;
            System.Windows.Forms.Label social_statusLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label smokingLabel;
            System.Windows.Forms.Label previous_fractureLabel;
            System.Windows.Forms.Label parental_hip_fractureLabel;
            System.Windows.Forms.Label glucocorticoidsLabel;
            System.Windows.Forms.Label rheumatoid_arthritisLabel;
            System.Windows.Forms.Label secondary_osteoporosisLabel;
            System.Windows.Forms.Label alcohol_3_or_more_units_dayLabel;
            System.Windows.Forms.Label fRAXLabel;
            System.Windows.Forms.Label ___medical_cardLabel;
            System.Windows.Forms.Label transfer_hospitalLabel;
            System.Windows.Forms.Label type_of_fractureLabel;
            System.Windows.Forms.Label surgical_repairLabel;
            System.Windows.Forms.Label id_patientLabel1;
            System.Windows.Forms.Label code_hospitalLabel;
            System.Windows.Forms.Label code_interviewLabel;
            System.Windows.Forms.Label id_patientLabel2;
            System.Windows.Forms.Label sex_of_personeLabel1;
            System.Windows.Forms.Label arrival_dateLabel1;
            System.Windows.Forms.Label date_of_surgeryLabel1;
            System.Windows.Forms.Label discharge_dateLabel1;
            System.Windows.Forms.Label birth_dateLabel1;
            System.Windows.Forms.Label date_of_interviewLabel1;
            System.Windows.Forms.Label time_of_surgeryLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numberOfPatient = new System.Windows.Forms.Label();
            this.patient_informationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrDataSet = new patientregistry.registrDataSet();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientRegistrySaveButton = new System.Windows.Forms.ToolStripButton();
            this.refreshPatient = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabGeneralInf = new System.Windows.Forms.TabPage();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sex_of_personeComboBox = new System.Windows.Forms.ComboBox();
            this.social_statusComboBox = new System.Windows.Forms.ComboBox();
            this.id_patientTextBox = new System.Windows.Forms.TextBox();
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
            this.tabFactors = new System.Windows.Forms.TabPage();
            this.Fraxbtn = new System.Windows.Forms.Button();
            this.date_of_interviewDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientInformationinterviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bindingNavigatorRF = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewRF = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItemRF = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveRF = new System.Windows.Forms.ToolStripButton();
            this.id_patientTextBox2 = new System.Windows.Forms.TextBox();
            this.code_interviewTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.smokingCheckBox = new System.Windows.Forms.CheckBox();
            this.previous_fractureCheckBox = new System.Windows.Forms.CheckBox();
            this.parental_hip_fractureCheckBox = new System.Windows.Forms.CheckBox();
            this.glucocorticoidsCheckBox = new System.Windows.Forms.CheckBox();
            this.rheumatoid_arthritisCheckBox = new System.Windows.Forms.CheckBox();
            this.secondary_osteoporosisCheckBox = new System.Windows.Forms.CheckBox();
            this.alcohol_3_or_more_units_dayCheckBox = new System.Windows.Forms.CheckBox();
            this.FRAX = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorLab = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.patientInformationlabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.labDataGridView = new System.Windows.Forms.DataGridView();
            this.codeLabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAnalysisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.testResultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorDexa = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.patientInformationDEXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.dEXADataGridView = new System.Windows.Forms.DataGridView();
            this.codeDexaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfTestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttestScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bindingNavigatorTreatment = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.patientInformationtreatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.treatmentDataGridView = new System.Windows.Forms.DataGridView();
            this.codeTreatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.medicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateOfAppointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compliance3MonthDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.compliance6MonthDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.compliance12MonthDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.time_of_surgeryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientInformationhospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discharge_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_of_surgeryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrival_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.countDay = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.bindingNavigatorHospital = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.code_hospitalTextBox = new System.Windows.Forms.TextBox();
            this.id_patientTextBox1 = new System.Windows.Forms.TextBox();
            this.___medical_cardTextBox = new System.Windows.Forms.TextBox();
            this.transfer_hospitalTextBox = new System.Windows.Forms.TextBox();
            this.type_of_fractureTextBox = new System.Windows.Forms.TextBox();
            this.surgical_repairCheckBox = new System.Windows.Forms.CheckBox();
            this.patient_informationTableAdapter = new patientregistry.registrDataSetTableAdapters.patient_informationTableAdapter();
            this.tableAdapterManager = new patientregistry.registrDataSetTableAdapters.TableAdapterManager();
            this.dEXATableAdapter = new patientregistry.registrDataSetTableAdapters.DEXATableAdapter();
            this.hospitalTableAdapter = new patientregistry.registrDataSetTableAdapters.hospitalTableAdapter();
            this.interviewTableAdapter = new patientregistry.registrDataSetTableAdapters.interviewTableAdapter();
            this.labTableAdapter = new patientregistry.registrDataSetTableAdapters.labTableAdapter();
            this.sexTableAdapter = new patientregistry.registrDataSetTableAdapters.sexTableAdapter();
            this.treatmentTableAdapter = new patientregistry.registrDataSetTableAdapters.treatmentTableAdapter();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treatmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            id_patientLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            contact_telephoneLabel = new System.Windows.Forms.Label();
            medical_insurance_policyLabel = new System.Windows.Forms.Label();
            localityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            corpsLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            social_statusLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            smokingLabel = new System.Windows.Forms.Label();
            previous_fractureLabel = new System.Windows.Forms.Label();
            parental_hip_fractureLabel = new System.Windows.Forms.Label();
            glucocorticoidsLabel = new System.Windows.Forms.Label();
            rheumatoid_arthritisLabel = new System.Windows.Forms.Label();
            secondary_osteoporosisLabel = new System.Windows.Forms.Label();
            alcohol_3_or_more_units_dayLabel = new System.Windows.Forms.Label();
            fRAXLabel = new System.Windows.Forms.Label();
            ___medical_cardLabel = new System.Windows.Forms.Label();
            transfer_hospitalLabel = new System.Windows.Forms.Label();
            type_of_fractureLabel = new System.Windows.Forms.Label();
            surgical_repairLabel = new System.Windows.Forms.Label();
            id_patientLabel1 = new System.Windows.Forms.Label();
            code_hospitalLabel = new System.Windows.Forms.Label();
            code_interviewLabel = new System.Windows.Forms.Label();
            id_patientLabel2 = new System.Windows.Forms.Label();
            sex_of_personeLabel1 = new System.Windows.Forms.Label();
            arrival_dateLabel1 = new System.Windows.Forms.Label();
            date_of_surgeryLabel1 = new System.Windows.Forms.Label();
            discharge_dateLabel1 = new System.Windows.Forms.Label();
            birth_dateLabel1 = new System.Windows.Forms.Label();
            date_of_interviewLabel1 = new System.Windows.Forms.Label();
            time_of_surgeryLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_informationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabGeneralInf.SuspendLayout();
            this.tabFactors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationinterviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorRF)).BeginInit();
            this.bindingNavigatorRF.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLab)).BeginInit();
            this.bindingNavigatorLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationlabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDexa)).BeginInit();
            this.bindingNavigatorDexa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationDEXABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEXADataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTreatment)).BeginInit();
            this.bindingNavigatorTreatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationtreatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentDataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationhospitalBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHospital)).BeginInit();
            this.bindingNavigatorHospital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEXABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_patientLabel
            // 
            id_patientLabel.AutoSize = true;
            id_patientLabel.Location = new System.Drawing.Point(92, 6);
            id_patientLabel.Name = "id_patientLabel";
            id_patientLabel.Size = new System.Drawing.Size(174, 20);
            id_patientLabel.TabIndex = 0;
            id_patientLabel.Text = "№ пациента в регистре";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(123, 37);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(73, 20);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "Фамилия";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(139, 72);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(39, 20);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "Имя";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Location = new System.Drawing.Point(123, 105);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(74, 20);
            middle_nameLabel.TabIndex = 6;
            middle_nameLabel.Text = "Отчество";
            // 
            // contact_telephoneLabel
            // 
            contact_telephoneLabel.AutoSize = true;
            contact_telephoneLabel.Location = new System.Drawing.Point(23, 270);
            contact_telephoneLabel.Name = "contact_telephoneLabel";
            contact_telephoneLabel.Size = new System.Drawing.Size(161, 20);
            contact_telephoneLabel.TabIndex = 8;
            contact_telephoneLabel.Text = "Контактный телефон";
            // 
            // medical_insurance_policyLabel
            // 
            medical_insurance_policyLabel.AutoSize = true;
            medical_insurance_policyLabel.Location = new System.Drawing.Point(3, 238);
            medical_insurance_policyLabel.Name = "medical_insurance_policyLabel";
            medical_insurance_policyLabel.Size = new System.Drawing.Size(229, 20);
            medical_insurance_policyLabel.TabIndex = 14;
            medical_insurance_policyLabel.Text = "Страховой медицинский полис";
            // 
            // localityLabel
            // 
            localityLabel.AutoSize = true;
            localityLabel.Location = new System.Drawing.Point(3, 302);
            localityLabel.Name = "localityLabel";
            localityLabel.Size = new System.Drawing.Size(143, 20);
            localityLabel.TabIndex = 18;
            localityLabel.Text = "Населенный пункт";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(284, 302);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(52, 20);
            regionLabel.TabIndex = 20;
            regionLabel.Text = "Район";
            regionLabel.Click += new System.EventHandler(this.regionLabel_Click);
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(33, 344);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(54, 20);
            streetLabel.TabIndex = 22;
            streetLabel.Text = "Улица";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Location = new System.Drawing.Point(56, 375);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(38, 20);
            houseLabel.TabIndex = 24;
            houseLabel.Text = "Дом";
            houseLabel.Click += new System.EventHandler(this.houseLabel_Click);
            // 
            // corpsLabel
            // 
            corpsLabel.AutoSize = true;
            corpsLabel.Location = new System.Drawing.Point(180, 370);
            corpsLabel.Name = "corpsLabel";
            corpsLabel.Size = new System.Drawing.Size(60, 20);
            corpsLabel.TabIndex = 26;
            corpsLabel.Text = "Корпус";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(311, 373);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(77, 20);
            roomLabel.TabIndex = 28;
            roomLabel.Text = "Квартира";
            // 
            // social_statusLabel
            // 
            social_statusLabel.AutoSize = true;
            social_statusLabel.Location = new System.Drawing.Point(78, 206);
            social_statusLabel.Name = "social_statusLabel";
            social_statusLabel.Size = new System.Drawing.Size(149, 20);
            social_statusLabel.TabIndex = 30;
            social_statusLabel.Text = "Социальный статус";
            social_statusLabel.Click += new System.EventHandler(this.social_statusLabel_Click);
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(79, 46);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(65, 20);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Возраст";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(226, 46);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(41, 20);
            heightLabel.TabIndex = 8;
            heightLabel.Text = "Рост";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(355, 46);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(32, 20);
            weightLabel.TabIndex = 10;
            weightLabel.Text = "Вес";
            // 
            // smokingLabel
            // 
            smokingLabel.AutoSize = true;
            smokingLabel.Location = new System.Drawing.Point(55, 85);
            smokingLabel.Name = "smokingLabel";
            smokingLabel.Size = new System.Drawing.Size(202, 20);
            smokingLabel.TabIndex = 12;
            smokingLabel.Text = "Курение в настоящее время";
            // 
            // previous_fractureLabel
            // 
            previous_fractureLabel.AutoSize = true;
            previous_fractureLabel.Location = new System.Drawing.Point(55, 116);
            previous_fractureLabel.Name = "previous_fractureLabel";
            previous_fractureLabel.Size = new System.Drawing.Size(198, 20);
            previous_fractureLabel.TabIndex = 14;
            previous_fractureLabel.Text = "Предшествующий перелом";
            // 
            // parental_hip_fractureLabel
            // 
            parental_hip_fractureLabel.AutoSize = true;
            parental_hip_fractureLabel.Location = new System.Drawing.Point(55, 147);
            parental_hip_fractureLabel.Name = "parental_hip_fractureLabel";
            parental_hip_fractureLabel.Size = new System.Drawing.Size(205, 20);
            parental_hip_fractureLabel.TabIndex = 16;
            parental_hip_fractureLabel.Text = "Перелом бедра у родителей";
            // 
            // glucocorticoidsLabel
            // 
            glucocorticoidsLabel.AutoSize = true;
            glucocorticoidsLabel.Location = new System.Drawing.Point(55, 178);
            glucocorticoidsLabel.Name = "glucocorticoidsLabel";
            glucocorticoidsLabel.Size = new System.Drawing.Size(139, 20);
            glucocorticoidsLabel.TabIndex = 18;
            glucocorticoidsLabel.Text = "Глюкокортикоиды";
            // 
            // rheumatoid_arthritisLabel
            // 
            rheumatoid_arthritisLabel.AutoSize = true;
            rheumatoid_arthritisLabel.Location = new System.Drawing.Point(55, 209);
            rheumatoid_arthritisLabel.Name = "rheumatoid_arthritisLabel";
            rheumatoid_arthritisLabel.Size = new System.Drawing.Size(167, 20);
            rheumatoid_arthritisLabel.TabIndex = 20;
            rheumatoid_arthritisLabel.Text = "Ревматоидный артрит";
            // 
            // secondary_osteoporosisLabel
            // 
            secondary_osteoporosisLabel.AutoSize = true;
            secondary_osteoporosisLabel.Location = new System.Drawing.Point(55, 240);
            secondary_osteoporosisLabel.Name = "secondary_osteoporosisLabel";
            secondary_osteoporosisLabel.Size = new System.Drawing.Size(172, 20);
            secondary_osteoporosisLabel.TabIndex = 22;
            secondary_osteoporosisLabel.Text = "Вторичный остеопороз";
            // 
            // alcohol_3_or_more_units_dayLabel
            // 
            alcohol_3_or_more_units_dayLabel.AutoSize = true;
            alcohol_3_or_more_units_dayLabel.Location = new System.Drawing.Point(55, 271);
            alcohol_3_or_more_units_dayLabel.Name = "alcohol_3_or_more_units_dayLabel";
            alcohol_3_or_more_units_dayLabel.Size = new System.Drawing.Size(212, 20);
            alcohol_3_or_more_units_dayLabel.TabIndex = 24;
            alcohol_3_or_more_units_dayLabel.Text = "Алкоголь (3 и более ед./день)";
            // 
            // fRAXLabel
            // 
            fRAXLabel.AutoSize = true;
            fRAXLabel.Location = new System.Drawing.Point(216, 306);
            fRAXLabel.Name = "fRAXLabel";
            fRAXLabel.Size = new System.Drawing.Size(51, 20);
            fRAXLabel.TabIndex = 26;
            fRAXLabel.Text = "FRAX:";
            // 
            // ___medical_cardLabel
            // 
            ___medical_cardLabel.AutoSize = true;
            ___medical_cardLabel.Location = new System.Drawing.Point(73, 11);
            ___medical_cardLabel.Name = "___medical_cardLabel";
            ___medical_cardLabel.Size = new System.Drawing.Size(348, 20);
            ___medical_cardLabel.TabIndex = 4;
            ___medical_cardLabel.Text = "№ медицинской карты стационарного больного";
            // 
            // transfer_hospitalLabel
            // 
            transfer_hospitalLabel.AutoSize = true;
            transfer_hospitalLabel.Location = new System.Drawing.Point(10, 71);
            transfer_hospitalLabel.Name = "transfer_hospitalLabel";
            transfer_hospitalLabel.Size = new System.Drawing.Size(115, 20);
            transfer_hospitalLabel.TabIndex = 6;
            transfer_hospitalLabel.Text = "Кем направлен";
            // 
            // type_of_fractureLabel
            // 
            type_of_fractureLabel.AutoSize = true;
            type_of_fractureLabel.Location = new System.Drawing.Point(7, 151);
            type_of_fractureLabel.Name = "type_of_fractureLabel";
            type_of_fractureLabel.Size = new System.Drawing.Size(174, 20);
            type_of_fractureLabel.TabIndex = 10;
            type_of_fractureLabel.Text = "Локализация перелома";
            type_of_fractureLabel.Click += new System.EventHandler(this.type_of_fractureLabel_Click);
            // 
            // surgical_repairLabel
            // 
            surgical_repairLabel.AutoSize = true;
            surgical_repairLabel.Location = new System.Drawing.Point(10, 188);
            surgical_repairLabel.Name = "surgical_repairLabel";
            surgical_repairLabel.Size = new System.Drawing.Size(80, 20);
            surgical_repairLabel.TabIndex = 12;
            surgical_repairLabel.Text = "Операция";
            // 
            // id_patientLabel1
            // 
            id_patientLabel1.Location = new System.Drawing.Point(419, 3);
            id_patientLabel1.Name = "id_patientLabel1";
            id_patientLabel1.Size = new System.Drawing.Size(24, 20);
            id_patientLabel1.TabIndex = 2;
            id_patientLabel1.Text = "id patient:";
            id_patientLabel1.Visible = false;
            // 
            // code_hospitalLabel
            // 
            code_hospitalLabel.Location = new System.Drawing.Point(3, 3);
            code_hospitalLabel.Name = "code_hospitalLabel";
            code_hospitalLabel.Size = new System.Drawing.Size(45, 20);
            code_hospitalLabel.TabIndex = 0;
            code_hospitalLabel.Text = "code hospital:";
            code_hospitalLabel.Visible = false;
            // 
            // code_interviewLabel
            // 
            code_interviewLabel.Location = new System.Drawing.Point(428, 6);
            code_interviewLabel.Name = "code_interviewLabel";
            code_interviewLabel.Size = new System.Drawing.Size(23, 20);
            code_interviewLabel.TabIndex = 27;
            code_interviewLabel.Text = "code interview:";
            code_interviewLabel.Visible = false;
            // 
            // id_patientLabel2
            // 
            id_patientLabel2.Location = new System.Drawing.Point(6, 6);
            id_patientLabel2.Name = "id_patientLabel2";
            id_patientLabel2.Size = new System.Drawing.Size(30, 20);
            id_patientLabel2.TabIndex = 28;
            id_patientLabel2.Text = "id patient:";
            id_patientLabel2.Visible = false;
            // 
            // sex_of_personeLabel1
            // 
            sex_of_personeLabel1.AutoSize = true;
            sex_of_personeLabel1.Location = new System.Drawing.Point(120, 142);
            sex_of_personeLabel1.Name = "sex_of_personeLabel1";
            sex_of_personeLabel1.Size = new System.Drawing.Size(38, 20);
            sex_of_personeLabel1.TabIndex = 32;
            sex_of_personeLabel1.Text = "Пол";
            // 
            // arrival_dateLabel1
            // 
            arrival_dateLabel1.AutoSize = true;
            arrival_dateLabel1.Location = new System.Drawing.Point(218, 113);
            arrival_dateLabel1.Name = "arrival_dateLabel1";
            arrival_dateLabel1.Size = new System.Drawing.Size(139, 20);
            arrival_dateLabel1.TabIndex = 35;
            arrival_dateLabel1.Text = "Дата поступления";
            // 
            // date_of_surgeryLabel1
            // 
            date_of_surgeryLabel1.AutoSize = true;
            date_of_surgeryLabel1.Location = new System.Drawing.Point(7, 225);
            date_of_surgeryLabel1.Name = "date_of_surgeryLabel1";
            date_of_surgeryLabel1.Size = new System.Drawing.Size(116, 20);
            date_of_surgeryLabel1.TabIndex = 36;
            date_of_surgeryLabel1.Text = "Дата операции";
            // 
            // discharge_dateLabel1
            // 
            discharge_dateLabel1.AutoSize = true;
            discharge_dateLabel1.Location = new System.Drawing.Point(249, 324);
            discharge_dateLabel1.Name = "discharge_dateLabel1";
            discharge_dateLabel1.Size = new System.Drawing.Size(108, 20);
            discharge_dateLabel1.TabIndex = 37;
            discharge_dateLabel1.Text = "Дата выписки";
            // 
            // birth_dateLabel1
            // 
            birth_dateLabel1.AutoSize = true;
            birth_dateLabel1.Location = new System.Drawing.Point(96, 174);
            birth_dateLabel1.Name = "birth_dateLabel1";
            birth_dateLabel1.Size = new System.Drawing.Size(118, 20);
            birth_dateLabel1.TabIndex = 33;
            birth_dateLabel1.Text = "Дата рождения";
            // 
            // date_of_interviewLabel1
            // 
            date_of_interviewLabel1.AutoSize = true;
            date_of_interviewLabel1.Location = new System.Drawing.Point(144, 6);
            date_of_interviewLabel1.Name = "date_of_interviewLabel1";
            date_of_interviewLabel1.Size = new System.Drawing.Size(97, 20);
            date_of_interviewLabel1.TabIndex = 31;
            date_of_interviewLabel1.Text = "Дата опроса";
            // 
            // time_of_surgeryLabel1
            // 
            time_of_surgeryLabel1.AutoSize = true;
            time_of_surgeryLabel1.Location = new System.Drawing.Point(7, 270);
            time_of_surgeryLabel1.Name = "time_of_surgeryLabel1";
            time_of_surgeryLabel1.Size = new System.Drawing.Size(124, 20);
            time_of_surgeryLabel1.TabIndex = 38;
            time_of_surgeryLabel1.Text = "Время операции";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.numberOfPatient);
            this.splitContainer1.Panel1.Controls.Add(this.patient_informationDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.patientBindingNavigator);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.TabControl);
            this.splitContainer1.Size = new System.Drawing.Size(859, 489);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // numberOfPatient
            // 
            this.numberOfPatient.AutoSize = true;
            this.numberOfPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfPatient.Location = new System.Drawing.Point(3, 469);
            this.numberOfPatient.Name = "numberOfPatient";
            this.numberOfPatient.Size = new System.Drawing.Size(107, 16);
            this.numberOfPatient.TabIndex = 4;
            this.numberOfPatient.Text = "numberOfPatient";
            this.numberOfPatient.Click += new System.EventHandler(this.numberOfPatient_Click);
            // 
            // patient_informationDataGridView
            // 
            this.patient_informationDataGridView.AllowUserToResizeColumns = false;
            this.patient_informationDataGridView.AllowUserToResizeRows = false;
            this.patient_informationDataGridView.AutoGenerateColumns = false;
            this.patient_informationDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patient_informationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patient_informationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.patient_informationDataGridView.DataSource = this.patient_informationBindingSource;
            this.patient_informationDataGridView.Location = new System.Drawing.Point(-2, 77);
            this.patient_informationDataGridView.Name = "patient_informationDataGridView";
            this.patient_informationDataGridView.Size = new System.Drawing.Size(348, 387);
            this.patient_informationDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id patient";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "№ пациента в регистре";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "first name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "middle name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 76;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contact telephone";
            this.dataGridViewTextBoxColumn5.HeaderText = "contact telephone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "birth date";
            this.dataGridViewTextBoxColumn6.HeaderText = "birth date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "sex of persone";
            this.dataGridViewTextBoxColumn7.HeaderText = "sex of persone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "medical insurance policy";
            this.dataGridViewTextBoxColumn8.HeaderText = "medical insurance policy";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "social status";
            this.dataGridViewTextBoxColumn9.HeaderText = "social status";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "locality";
            this.dataGridViewTextBoxColumn10.HeaderText = "locality";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "region";
            this.dataGridViewTextBoxColumn11.HeaderText = "region";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "street";
            this.dataGridViewTextBoxColumn12.HeaderText = "street";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "house";
            this.dataGridViewTextBoxColumn13.HeaderText = "house";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "corps";
            this.dataGridViewTextBoxColumn14.HeaderText = "corps";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "room";
            this.dataGridViewTextBoxColumn15.HeaderText = "room";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // patient_informationBindingSource
            // 
            this.patient_informationBindingSource.DataMember = "patient information";
            this.patient_informationBindingSource.DataSource = this.registrDataSet;
            // 
            // registrDataSet
            // 
            this.registrDataSet.DataSetName = "registrDataSet";
            this.registrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patient_informationBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientRegistrySaveButton,
            this.refreshPatient});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 52);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(346, 25);
            this.patientBindingNavigator.TabIndex = 3;
            this.patientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patientRegistrySaveButton
            // 
            this.patientRegistrySaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientRegistrySaveButton.Image = global::patientregistry.Properties.Resources.save;
            this.patientRegistrySaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.patientRegistrySaveButton.Name = "patientRegistrySaveButton";
            this.patientRegistrySaveButton.Size = new System.Drawing.Size(23, 22);
            this.patientRegistrySaveButton.Text = "toolStripButton1";
            this.patientRegistrySaveButton.ToolTipText = "Сохранить";
            this.patientRegistrySaveButton.Click += new System.EventHandler(this.patientRegistrySaveButton_Click);
            // 
            // refreshPatient
            // 
            this.refreshPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshPatient.Image = global::patientregistry.Properties.Resources.w512h5121390848386recurringappointment512;
            this.refreshPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshPatient.Name = "refreshPatient";
            this.refreshPatient.Size = new System.Drawing.Size(23, 22);
            this.refreshPatient.Text = "Обновить";
            this.refreshPatient.Click += new System.EventHandler(this.toolStripButton17_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchLabel,
            this.searchTextBox,
            this.searchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(346, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(136, 24);
            this.searchLabel.Text = "Введите фамилию";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 27);
            this.searchTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.Checked = true;
            this.searchButton.CheckOnClick = true;
            this.searchButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Image = global::patientregistry.Properties.Resources.search;
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchButton.Size = new System.Drawing.Size(57, 24);
            this.searchButton.Text = "Поиск";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПациентаToolStripMenuItem,
            this.удалитьПациентаToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(346, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПациентаToolStripMenuItem
            // 
            this.добавитьПациентаToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.добавитьПациентаToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.добавитьПациентаToolStripMenuItem.Name = "добавитьПациентаToolStripMenuItem";
            this.добавитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(127, 21);
            this.добавитьПациентаToolStripMenuItem.Text = "Добавить пациента";
            this.добавитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьПациентаToolStripMenuItem_Click);
            // 
            // удалитьПациентаToolStripMenuItem
            // 
            this.удалитьПациентаToolStripMenuItem.Name = "удалитьПациентаToolStripMenuItem";
            this.удалитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.удалитьПациентаToolStripMenuItem.Text = "Удалить пациента";
            this.удалитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьПациентаToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabGeneralInf);
            this.TabControl.Controls.Add(this.tabFactors);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Controls.Add(this.tabPage5);
            this.TabControl.Controls.Add(this.tabPage6);
            this.TabControl.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.HotTrack = true;
            this.TabControl.Location = new System.Drawing.Point(3, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(499, 482);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl.TabIndex = 0;
            // 
            // tabGeneralInf
            // 
            this.tabGeneralInf.AutoScroll = true;
            this.tabGeneralInf.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneralInf.Controls.Add(birth_dateLabel1);
            this.tabGeneralInf.Controls.Add(this.birth_dateDateTimePicker);
            this.tabGeneralInf.Controls.Add(sex_of_personeLabel1);
            this.tabGeneralInf.Controls.Add(this.sex_of_personeComboBox);
            this.tabGeneralInf.Controls.Add(social_statusLabel);
            this.tabGeneralInf.Controls.Add(this.social_statusComboBox);
            this.tabGeneralInf.Controls.Add(id_patientLabel);
            this.tabGeneralInf.Controls.Add(this.id_patientTextBox);
            this.tabGeneralInf.Controls.Add(surnameLabel);
            this.tabGeneralInf.Controls.Add(this.surnameTextBox);
            this.tabGeneralInf.Controls.Add(first_nameLabel);
            this.tabGeneralInf.Controls.Add(this.first_nameTextBox);
            this.tabGeneralInf.Controls.Add(middle_nameLabel);
            this.tabGeneralInf.Controls.Add(this.middle_nameTextBox);
            this.tabGeneralInf.Controls.Add(contact_telephoneLabel);
            this.tabGeneralInf.Controls.Add(this.contact_telephoneTextBox);
            this.tabGeneralInf.Controls.Add(medical_insurance_policyLabel);
            this.tabGeneralInf.Controls.Add(this.medical_insurance_policyTextBox);
            this.tabGeneralInf.Controls.Add(localityLabel);
            this.tabGeneralInf.Controls.Add(this.localityTextBox);
            this.tabGeneralInf.Controls.Add(regionLabel);
            this.tabGeneralInf.Controls.Add(this.regionTextBox);
            this.tabGeneralInf.Controls.Add(streetLabel);
            this.tabGeneralInf.Controls.Add(this.streetTextBox);
            this.tabGeneralInf.Controls.Add(houseLabel);
            this.tabGeneralInf.Controls.Add(this.houseTextBox);
            this.tabGeneralInf.Controls.Add(corpsLabel);
            this.tabGeneralInf.Controls.Add(this.corpsTextBox);
            this.tabGeneralInf.Controls.Add(roomLabel);
            this.tabGeneralInf.Controls.Add(this.roomTextBox);
            this.tabGeneralInf.Location = new System.Drawing.Point(4, 54);
            this.tabGeneralInf.Name = "tabGeneralInf";
            this.tabGeneralInf.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralInf.Size = new System.Drawing.Size(491, 424);
            this.tabGeneralInf.TabIndex = 0;
            this.tabGeneralInf.Text = "Общая информация";
            this.tabGeneralInf.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patient_informationBindingSource, "birth date", true));
            this.birth_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(246, 166);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(193, 28);
            this.birth_dateDateTimePicker.TabIndex = 34;
            this.birth_dateDateTimePicker.ValueChanged += new System.EventHandler(this.birth_dateDateTimePicker_ValueChanged);
            // 
            // sex_of_personeComboBox
            // 
            this.sex_of_personeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "sex of persone", true));
            this.sex_of_personeComboBox.FormattingEnabled = true;
            this.sex_of_personeComboBox.Items.AddRange(new object[] {
            "женский",
            "мужской"});
            this.sex_of_personeComboBox.Location = new System.Drawing.Point(246, 134);
            this.sex_of_personeComboBox.Name = "sex_of_personeComboBox";
            this.sex_of_personeComboBox.Size = new System.Drawing.Size(192, 28);
            this.sex_of_personeComboBox.TabIndex = 33;
            // 
            // social_statusComboBox
            // 
            this.social_statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "social status", true));
            this.social_statusComboBox.FormattingEnabled = true;
            this.social_statusComboBox.Items.AddRange(new object[] {
            "пенсионер",
            "работающий",
            "неработающий"});
            this.social_statusComboBox.Location = new System.Drawing.Point(246, 198);
            this.social_statusComboBox.Name = "social_statusComboBox";
            this.social_statusComboBox.Size = new System.Drawing.Size(193, 28);
            this.social_statusComboBox.TabIndex = 31;
            // 
            // id_patientTextBox
            // 
            this.id_patientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "id patient", true));
            this.id_patientTextBox.Location = new System.Drawing.Point(275, 3);
            this.id_patientTextBox.Name = "id_patientTextBox";
            this.id_patientTextBox.Size = new System.Drawing.Size(62, 28);
            this.id_patientTextBox.TabIndex = 1;
            this.id_patientTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(245, 37);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(194, 28);
            this.surnameTextBox.TabIndex = 3;
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "first name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(245, 69);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(194, 28);
            this.first_nameTextBox.TabIndex = 5;
            this.first_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.first_nameTextBox.TextChanged += new System.EventHandler(this.first_nameTextBox_TextChanged);
            // 
            // middle_nameTextBox
            // 
            this.middle_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "middle name", true));
            this.middle_nameTextBox.Location = new System.Drawing.Point(245, 102);
            this.middle_nameTextBox.Name = "middle_nameTextBox";
            this.middle_nameTextBox.Size = new System.Drawing.Size(194, 28);
            this.middle_nameTextBox.TabIndex = 7;
            this.middle_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contact_telephoneTextBox
            // 
            this.contact_telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "contact telephone", true));
            this.contact_telephoneTextBox.Location = new System.Drawing.Point(246, 264);
            this.contact_telephoneTextBox.Name = "contact_telephoneTextBox";
            this.contact_telephoneTextBox.Size = new System.Drawing.Size(193, 28);
            this.contact_telephoneTextBox.TabIndex = 9;
            this.contact_telephoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medical_insurance_policyTextBox
            // 
            this.medical_insurance_policyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "medical insurance policy", true));
            this.medical_insurance_policyTextBox.Location = new System.Drawing.Point(245, 230);
            this.medical_insurance_policyTextBox.Name = "medical_insurance_policyTextBox";
            this.medical_insurance_policyTextBox.Size = new System.Drawing.Size(194, 28);
            this.medical_insurance_policyTextBox.TabIndex = 15;
            this.medical_insurance_policyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // localityTextBox
            // 
            this.localityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "locality", true));
            this.localityTextBox.Location = new System.Drawing.Point(146, 299);
            this.localityTextBox.Name = "localityTextBox";
            this.localityTextBox.Size = new System.Drawing.Size(139, 28);
            this.localityTextBox.TabIndex = 19;
            this.localityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "region", true));
            this.regionTextBox.Location = new System.Drawing.Point(342, 298);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(128, 28);
            this.regionTextBox.TabIndex = 21;
            this.regionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(113, 333);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(161, 28);
            this.streetTextBox.TabIndex = 23;
            this.streetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // houseTextBox
            // 
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "house", true));
            this.houseTextBox.Location = new System.Drawing.Point(100, 365);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(50, 28);
            this.houseTextBox.TabIndex = 25;
            this.houseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // corpsTextBox
            // 
            this.corpsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "corps", true));
            this.corpsTextBox.Location = new System.Drawing.Point(247, 364);
            this.corpsTextBox.Name = "corpsTextBox";
            this.corpsTextBox.Size = new System.Drawing.Size(53, 28);
            this.corpsTextBox.TabIndex = 27;
            this.corpsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomTextBox
            // 
            this.roomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_informationBindingSource, "room", true));
            this.roomTextBox.Location = new System.Drawing.Point(395, 364);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(45, 28);
            this.roomTextBox.TabIndex = 29;
            this.roomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomTextBox.TextChanged += new System.EventHandler(this.roomTextBox_TextChanged);
            // 
            // tabFactors
            // 
            this.tabFactors.AutoScroll = true;
            this.tabFactors.BackColor = System.Drawing.Color.SeaShell;
            this.tabFactors.Controls.Add(this.Fraxbtn);
            this.tabFactors.Controls.Add(date_of_interviewLabel1);
            this.tabFactors.Controls.Add(this.date_of_interviewDateTimePicker);
            this.tabFactors.Controls.Add(this.webBrowser1);
            this.tabFactors.Controls.Add(this.bindingNavigatorRF);
            this.tabFactors.Controls.Add(id_patientLabel2);
            this.tabFactors.Controls.Add(this.id_patientTextBox2);
            this.tabFactors.Controls.Add(code_interviewLabel);
            this.tabFactors.Controls.Add(this.code_interviewTextBox);
            this.tabFactors.Controls.Add(ageLabel);
            this.tabFactors.Controls.Add(this.ageTextBox);
            this.tabFactors.Controls.Add(heightLabel);
            this.tabFactors.Controls.Add(this.heightTextBox);
            this.tabFactors.Controls.Add(weightLabel);
            this.tabFactors.Controls.Add(this.weightTextBox);
            this.tabFactors.Controls.Add(smokingLabel);
            this.tabFactors.Controls.Add(this.smokingCheckBox);
            this.tabFactors.Controls.Add(previous_fractureLabel);
            this.tabFactors.Controls.Add(this.previous_fractureCheckBox);
            this.tabFactors.Controls.Add(parental_hip_fractureLabel);
            this.tabFactors.Controls.Add(this.parental_hip_fractureCheckBox);
            this.tabFactors.Controls.Add(glucocorticoidsLabel);
            this.tabFactors.Controls.Add(this.glucocorticoidsCheckBox);
            this.tabFactors.Controls.Add(rheumatoid_arthritisLabel);
            this.tabFactors.Controls.Add(this.rheumatoid_arthritisCheckBox);
            this.tabFactors.Controls.Add(secondary_osteoporosisLabel);
            this.tabFactors.Controls.Add(this.secondary_osteoporosisCheckBox);
            this.tabFactors.Controls.Add(alcohol_3_or_more_units_dayLabel);
            this.tabFactors.Controls.Add(this.alcohol_3_or_more_units_dayCheckBox);
            this.tabFactors.Controls.Add(fRAXLabel);
            this.tabFactors.Controls.Add(this.FRAX);
            this.tabFactors.Location = new System.Drawing.Point(4, 54);
            this.tabFactors.Name = "tabFactors";
            this.tabFactors.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactors.Size = new System.Drawing.Size(491, 424);
            this.tabFactors.TabIndex = 1;
            this.tabFactors.Text = "Факторы риска";
            // 
            // Fraxbtn
            // 
            this.Fraxbtn.Location = new System.Drawing.Point(344, 355);
            this.Fraxbtn.Name = "Fraxbtn";
            this.Fraxbtn.Size = new System.Drawing.Size(134, 38);
            this.Fraxbtn.TabIndex = 33;
            this.Fraxbtn.Text = "Получить FRAX";
            this.Fraxbtn.UseVisualStyleBackColor = true;
            this.Fraxbtn.Click += new System.EventHandler(this.Fraxbtn_Click);
            // 
            // date_of_interviewDateTimePicker
            // 
            this.date_of_interviewDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientInformationinterviewBindingSource, "date of interview", true));
            this.date_of_interviewDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_interviewDateTimePicker.Location = new System.Drawing.Point(247, 3);
            this.date_of_interviewDateTimePicker.Name = "date_of_interviewDateTimePicker";
            this.date_of_interviewDateTimePicker.Size = new System.Drawing.Size(115, 28);
            this.date_of_interviewDateTimePicker.TabIndex = 32;
            // 
            // patientInformationinterviewBindingSource
            // 
            this.patientInformationinterviewBindingSource.DataMember = "patient informationinterview";
            this.patientInformationinterviewBindingSource.DataSource = this.patient_informationBindingSource;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(344, 85);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(117, 246);
            this.webBrowser1.TabIndex = 31;
            // 
            // bindingNavigatorRF
            // 
            this.bindingNavigatorRF.AddNewItem = this.bindingNavigatorAddNewRF;
            this.bindingNavigatorRF.BindingSource = this.patientInformationinterviewBindingSource;
            this.bindingNavigatorRF.CountItem = null;
            this.bindingNavigatorRF.DeleteItem = this.bindingNavigatorDeleteItemRF;
            this.bindingNavigatorRF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorRF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewRF,
            this.bindingNavigatorDeleteItemRF,
            this.bindingNavigatorSaveRF});
            this.bindingNavigatorRF.Location = new System.Drawing.Point(3, 396);
            this.bindingNavigatorRF.MoveFirstItem = null;
            this.bindingNavigatorRF.MoveLastItem = null;
            this.bindingNavigatorRF.MoveNextItem = null;
            this.bindingNavigatorRF.MovePreviousItem = null;
            this.bindingNavigatorRF.Name = "bindingNavigatorRF";
            this.bindingNavigatorRF.PositionItem = null;
            this.bindingNavigatorRF.Size = new System.Drawing.Size(485, 25);
            this.bindingNavigatorRF.TabIndex = 30;
            this.bindingNavigatorRF.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewRF
            // 
            this.bindingNavigatorAddNewRF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewRF.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewRF.Image")));
            this.bindingNavigatorAddNewRF.Name = "bindingNavigatorAddNewRF";
            this.bindingNavigatorAddNewRF.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewRF.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewRF.Text = "Добавить";
            this.bindingNavigatorAddNewRF.Click += new System.EventHandler(this.bindingNavigatorAddNewRF_Click);
            // 
            // bindingNavigatorDeleteItemRF
            // 
            this.bindingNavigatorDeleteItemRF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemRF.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemRF.Image")));
            this.bindingNavigatorDeleteItemRF.Name = "bindingNavigatorDeleteItemRF";
            this.bindingNavigatorDeleteItemRF.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemRF.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItemRF.Text = "Удалить";
            // 
            // bindingNavigatorSaveRF
            // 
            this.bindingNavigatorSaveRF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveRF.Image = global::patientregistry.Properties.Resources.save;
            this.bindingNavigatorSaveRF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveRF.Name = "bindingNavigatorSaveRF";
            this.bindingNavigatorSaveRF.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveRF.Text = "Сохранить";
            this.bindingNavigatorSaveRF.Click += new System.EventHandler(this.bindingNavigatorSaveRF_Click);
            // 
            // id_patientTextBox2
            // 
            this.id_patientTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationinterviewBindingSource, "id patient", true));
            this.id_patientTextBox2.Location = new System.Drawing.Point(42, 6);
            this.id_patientTextBox2.Multiline = true;
            this.id_patientTextBox2.Name = "id_patientTextBox2";
            this.id_patientTextBox2.Size = new System.Drawing.Size(16, 20);
            this.id_patientTextBox2.TabIndex = 29;
            this.id_patientTextBox2.Visible = false;
            this.id_patientTextBox2.TextChanged += new System.EventHandler(this.id_patientTextBox2_TextChanged);
            // 
            // code_interviewTextBox
            // 
            this.code_interviewTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationinterviewBindingSource, "code interview", true));
            this.code_interviewTextBox.Location = new System.Drawing.Point(457, 6);
            this.code_interviewTextBox.Multiline = true;
            this.code_interviewTextBox.Name = "code_interviewTextBox";
            this.code_interviewTextBox.Size = new System.Drawing.Size(27, 20);
            this.code_interviewTextBox.TabIndex = 28;
            this.code_interviewTextBox.Visible = false;
            this.code_interviewTextBox.TextChanged += new System.EventHandler(this.code_interviewTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationinterviewBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(150, 40);
            this.ageTextBox.Multiline = true;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(55, 26);
            this.ageTextBox.TabIndex = 7;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationinterviewBindingSource, "height", true));
            this.heightTextBox.Location = new System.Drawing.Point(273, 40);
            this.heightTextBox.Multiline = true;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(53, 26);
            this.heightTextBox.TabIndex = 9;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationinterviewBindingSource, "weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(393, 38);
            this.weightTextBox.Multiline = true;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(57, 28);
            this.weightTextBox.TabIndex = 11;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smokingCheckBox
            // 
            this.smokingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "smoking", true));
            this.smokingCheckBox.Location = new System.Drawing.Point(321, 81);
            this.smokingCheckBox.Name = "smokingCheckBox";
            this.smokingCheckBox.Size = new System.Drawing.Size(104, 24);
            this.smokingCheckBox.TabIndex = 13;
            this.smokingCheckBox.UseVisualStyleBackColor = true;
            // 
            // previous_fractureCheckBox
            // 
            this.previous_fractureCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "previous fracture", true));
            this.previous_fractureCheckBox.Location = new System.Drawing.Point(321, 112);
            this.previous_fractureCheckBox.Name = "previous_fractureCheckBox";
            this.previous_fractureCheckBox.Size = new System.Drawing.Size(104, 24);
            this.previous_fractureCheckBox.TabIndex = 15;
            this.previous_fractureCheckBox.UseVisualStyleBackColor = true;
            // 
            // parental_hip_fractureCheckBox
            // 
            this.parental_hip_fractureCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "parental hip fracture", true));
            this.parental_hip_fractureCheckBox.Location = new System.Drawing.Point(321, 143);
            this.parental_hip_fractureCheckBox.Name = "parental_hip_fractureCheckBox";
            this.parental_hip_fractureCheckBox.Size = new System.Drawing.Size(104, 24);
            this.parental_hip_fractureCheckBox.TabIndex = 17;
            this.parental_hip_fractureCheckBox.UseVisualStyleBackColor = true;
            // 
            // glucocorticoidsCheckBox
            // 
            this.glucocorticoidsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "glucocorticoids", true));
            this.glucocorticoidsCheckBox.Location = new System.Drawing.Point(321, 174);
            this.glucocorticoidsCheckBox.Name = "glucocorticoidsCheckBox";
            this.glucocorticoidsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.glucocorticoidsCheckBox.TabIndex = 19;
            this.glucocorticoidsCheckBox.UseVisualStyleBackColor = true;
            // 
            // rheumatoid_arthritisCheckBox
            // 
            this.rheumatoid_arthritisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "rheumatoid arthritis", true));
            this.rheumatoid_arthritisCheckBox.Location = new System.Drawing.Point(321, 205);
            this.rheumatoid_arthritisCheckBox.Name = "rheumatoid_arthritisCheckBox";
            this.rheumatoid_arthritisCheckBox.Size = new System.Drawing.Size(104, 24);
            this.rheumatoid_arthritisCheckBox.TabIndex = 21;
            this.rheumatoid_arthritisCheckBox.UseVisualStyleBackColor = true;
            // 
            // secondary_osteoporosisCheckBox
            // 
            this.secondary_osteoporosisCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "secondary osteoporosis", true));
            this.secondary_osteoporosisCheckBox.Location = new System.Drawing.Point(321, 236);
            this.secondary_osteoporosisCheckBox.Name = "secondary_osteoporosisCheckBox";
            this.secondary_osteoporosisCheckBox.Size = new System.Drawing.Size(104, 24);
            this.secondary_osteoporosisCheckBox.TabIndex = 23;
            this.secondary_osteoporosisCheckBox.UseVisualStyleBackColor = true;
            // 
            // alcohol_3_or_more_units_dayCheckBox
            // 
            this.alcohol_3_or_more_units_dayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationinterviewBindingSource, "alcohol 3 or more units/day", true));
            this.alcohol_3_or_more_units_dayCheckBox.Location = new System.Drawing.Point(321, 267);
            this.alcohol_3_or_more_units_dayCheckBox.Name = "alcohol_3_or_more_units_dayCheckBox";
            this.alcohol_3_or_more_units_dayCheckBox.Size = new System.Drawing.Size(104, 24);
            this.alcohol_3_or_more_units_dayCheckBox.TabIndex = 25;
            this.alcohol_3_or_more_units_dayCheckBox.UseVisualStyleBackColor = true;
            // 
            // FRAX
            // 
            this.FRAX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationinterviewBindingSource, "FRAX", true));
            this.FRAX.Location = new System.Drawing.Point(274, 302);
            this.FRAX.Multiline = true;
            this.FRAX.Name = "FRAX";
            this.FRAX.Size = new System.Drawing.Size(64, 29);
            this.FRAX.TabIndex = 27;
            this.FRAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FRAX.TextChanged += new System.EventHandler(this.fRAXTextBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bindingNavigatorLab);
            this.tabPage3.Controls.Add(this.labDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(491, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Лабораторные тесты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorLab
            // 
            this.bindingNavigatorLab.AddNewItem = this.toolStripButton1;
            this.bindingNavigatorLab.BindingSource = this.patientInformationlabBindingSource;
            this.bindingNavigatorLab.CountItem = null;
            this.bindingNavigatorLab.DeleteItem = this.toolStripButton2;
            this.bindingNavigatorLab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.bindingNavigatorLab.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorLab.MoveFirstItem = null;
            this.bindingNavigatorLab.MoveLastItem = null;
            this.bindingNavigatorLab.MoveNextItem = null;
            this.bindingNavigatorLab.MovePreviousItem = null;
            this.bindingNavigatorLab.Name = "bindingNavigatorLab";
            this.bindingNavigatorLab.PositionItem = null;
            this.bindingNavigatorLab.Size = new System.Drawing.Size(485, 25);
            this.bindingNavigatorLab.TabIndex = 31;
            this.bindingNavigatorLab.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // patientInformationlabBindingSource
            // 
            this.patientInformationlabBindingSource.DataMember = "patient informationlab";
            this.patientInformationlabBindingSource.DataSource = this.patient_informationBindingSource;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::patientregistry.Properties.Resources.save;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Сохранить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // labDataGridView
            // 
            this.labDataGridView.AutoGenerateColumns = false;
            this.labDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.labDataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.labDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.labDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeLabDataGridViewTextBoxColumn,
            this.idPatientDataGridViewTextBoxColumn1,
            this.dateOfAnalysisDataGridViewTextBoxColumn,
            this.nameTestDataGridViewTextBoxColumn,
            this.testResultDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.normalValueDataGridViewTextBoxColumn});
            this.labDataGridView.DataSource = this.patientInformationlabBindingSource;
            this.labDataGridView.Location = new System.Drawing.Point(0, 27);
            this.labDataGridView.Name = "labDataGridView";
            this.labDataGridView.Size = new System.Drawing.Size(492, 401);
            this.labDataGridView.TabIndex = 0;
            // 
            // codeLabDataGridViewTextBoxColumn
            // 
            this.codeLabDataGridViewTextBoxColumn.DataPropertyName = "code lab";
            this.codeLabDataGridViewTextBoxColumn.HeaderText = "№";
            this.codeLabDataGridViewTextBoxColumn.Name = "codeLabDataGridViewTextBoxColumn";
            this.codeLabDataGridViewTextBoxColumn.Width = 51;
            // 
            // idPatientDataGridViewTextBoxColumn1
            // 
            this.idPatientDataGridViewTextBoxColumn1.DataPropertyName = "id patient";
            this.idPatientDataGridViewTextBoxColumn1.HeaderText = "id patient";
            this.idPatientDataGridViewTextBoxColumn1.Name = "idPatientDataGridViewTextBoxColumn1";
            this.idPatientDataGridViewTextBoxColumn1.Visible = false;
            this.idPatientDataGridViewTextBoxColumn1.Width = 97;
            // 
            // dateOfAnalysisDataGridViewTextBoxColumn
            // 
            this.dateOfAnalysisDataGridViewTextBoxColumn.DataPropertyName = "date of analysis";
            this.dateOfAnalysisDataGridViewTextBoxColumn.HeaderText = "Дата анализа";
            this.dateOfAnalysisDataGridViewTextBoxColumn.Name = "dateOfAnalysisDataGridViewTextBoxColumn";
            this.dateOfAnalysisDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameTestDataGridViewTextBoxColumn
            // 
            this.nameTestDataGridViewTextBoxColumn.DataPropertyName = "name test";
            this.nameTestDataGridViewTextBoxColumn.HeaderText = "Наименование теста";
            this.nameTestDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Ca крови",
            "Ca++ крови",
            "Ca в моче",
            "вит. D",
            "остеокальцин",
            "общий белок",
            "креатинин крови",
            "общая щелочная фосфатаза",
            "оксипиридинолин",
            "дезоксипиридолин",
            "оксипролин ",
            "N-телопептиды молекул коллагена I типа",
            "С-телопептиды молекул коллагена I типа",
            "тартратрезистентная кислая фосфатаза ",
            "карбокситерминальные пропептиды проколлагена типа I ",
            "аминотерминальные пропептиды проколлагена типа I ",
            "",
            ""});
            this.nameTestDataGridViewTextBoxColumn.Name = "nameTestDataGridViewTextBoxColumn";
            this.nameTestDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameTestDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nameTestDataGridViewTextBoxColumn.Width = 163;
            // 
            // testResultDataGridViewTextBoxColumn
            // 
            this.testResultDataGridViewTextBoxColumn.DataPropertyName = "test result";
            this.testResultDataGridViewTextBoxColumn.HeaderText = "Результат теста";
            this.testResultDataGridViewTextBoxColumn.Name = "testResultDataGridViewTextBoxColumn";
            this.testResultDataGridViewTextBoxColumn.Width = 134;
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Ед. изм.";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            this.unitsDataGridViewTextBoxColumn.Width = 82;
            // 
            // normalValueDataGridViewTextBoxColumn
            // 
            this.normalValueDataGridViewTextBoxColumn.DataPropertyName = "normal value";
            this.normalValueDataGridViewTextBoxColumn.HeaderText = "Норма";
            this.normalValueDataGridViewTextBoxColumn.Name = "normalValueDataGridViewTextBoxColumn";
            this.normalValueDataGridViewTextBoxColumn.Width = 81;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bindingNavigatorDexa);
            this.tabPage4.Controls.Add(this.dEXADataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(491, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Денситометрия";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorDexa
            // 
            this.bindingNavigatorDexa.AddNewItem = this.toolStripButton4;
            this.bindingNavigatorDexa.BindingSource = this.patientInformationDEXABindingSource;
            this.bindingNavigatorDexa.CountItem = null;
            this.bindingNavigatorDexa.DeleteItem = this.toolStripButton5;
            this.bindingNavigatorDexa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton13});
            this.bindingNavigatorDexa.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorDexa.MoveFirstItem = null;
            this.bindingNavigatorDexa.MoveLastItem = null;
            this.bindingNavigatorDexa.MoveNextItem = null;
            this.bindingNavigatorDexa.MovePreviousItem = null;
            this.bindingNavigatorDexa.Name = "bindingNavigatorDexa";
            this.bindingNavigatorDexa.PositionItem = null;
            this.bindingNavigatorDexa.Size = new System.Drawing.Size(485, 25);
            this.bindingNavigatorDexa.TabIndex = 32;
            this.bindingNavigatorDexa.Text = "bindingNavigator2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Добавить";
            // 
            // patientInformationDEXABindingSource
            // 
            this.patientInformationDEXABindingSource.DataMember = "patient informationDEXA";
            this.patientInformationDEXABindingSource.DataSource = this.patient_informationBindingSource;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Удалить";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::patientregistry.Properties.Resources.save;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Сохранить";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = global::patientregistry.Properties.Resources.line_chart1600;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Построить график BMD-динамики";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // dEXADataGridView
            // 
            this.dEXADataGridView.AutoGenerateColumns = false;
            this.dEXADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dEXADataGridView.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dEXADataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dEXADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dEXADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDexaDataGridViewTextBoxColumn,
            this.idPatientDataGridViewTextBoxColumn2,
            this.dateOfTestDataGridViewTextBoxColumn,
            this.bMDDataGridViewTextBoxColumn,
            this.ttestScoreDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn});
            this.dEXADataGridView.DataSource = this.patientInformationDEXABindingSource;
            this.dEXADataGridView.Location = new System.Drawing.Point(0, 27);
            this.dEXADataGridView.Name = "dEXADataGridView";
            this.dEXADataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dEXADataGridView.Size = new System.Drawing.Size(492, 401);
            this.dEXADataGridView.TabIndex = 0;
            // 
            // codeDexaDataGridViewTextBoxColumn
            // 
            this.codeDexaDataGridViewTextBoxColumn.DataPropertyName = "code dexa";
            this.codeDexaDataGridViewTextBoxColumn.HeaderText = "№";
            this.codeDexaDataGridViewTextBoxColumn.Name = "codeDexaDataGridViewTextBoxColumn";
            this.codeDexaDataGridViewTextBoxColumn.Width = 51;
            // 
            // idPatientDataGridViewTextBoxColumn2
            // 
            this.idPatientDataGridViewTextBoxColumn2.DataPropertyName = "id patient";
            this.idPatientDataGridViewTextBoxColumn2.HeaderText = "id patient";
            this.idPatientDataGridViewTextBoxColumn2.Name = "idPatientDataGridViewTextBoxColumn2";
            this.idPatientDataGridViewTextBoxColumn2.Visible = false;
            this.idPatientDataGridViewTextBoxColumn2.Width = 97;
            // 
            // dateOfTestDataGridViewTextBoxColumn
            // 
            this.dateOfTestDataGridViewTextBoxColumn.DataPropertyName = "date of test";
            this.dateOfTestDataGridViewTextBoxColumn.HeaderText = "Дата исследования";
            this.dateOfTestDataGridViewTextBoxColumn.Name = "dateOfTestDataGridViewTextBoxColumn";
            this.dateOfTestDataGridViewTextBoxColumn.Width = 154;
            // 
            // bMDDataGridViewTextBoxColumn
            // 
            this.bMDDataGridViewTextBoxColumn.DataPropertyName = "BMD";
            this.bMDDataGridViewTextBoxColumn.HeaderText = "BMD";
            this.bMDDataGridViewTextBoxColumn.Name = "bMDDataGridViewTextBoxColumn";
            this.bMDDataGridViewTextBoxColumn.Width = 70;
            // 
            // ttestScoreDataGridViewTextBoxColumn
            // 
            this.ttestScoreDataGridViewTextBoxColumn.DataPropertyName = "T-test score";
            this.ttestScoreDataGridViewTextBoxColumn.HeaderText = "Значение T-критерия";
            this.ttestScoreDataGridViewTextBoxColumn.Name = "ttestScoreDataGridViewTextBoxColumn";
            this.ttestScoreDataGridViewTextBoxColumn.Width = 168;
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.diagnosisDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "норма",
            "остеопения",
            "остеопороз",
            "тяжелый остеопороз"});
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            this.diagnosisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.diagnosisDataGridViewTextBoxColumn.Width = 92;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bindingNavigatorTreatment);
            this.tabPage5.Controls.Add(this.treatmentDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 54);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(491, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Лечение";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorTreatment
            // 
            this.bindingNavigatorTreatment.AddNewItem = this.toolStripButton7;
            this.bindingNavigatorTreatment.BindingSource = this.patientInformationtreatmentBindingSource;
            this.bindingNavigatorTreatment.CountItem = null;
            this.bindingNavigatorTreatment.DeleteItem = this.toolStripButton8;
            this.bindingNavigatorTreatment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.bindingNavigatorTreatment.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorTreatment.MoveFirstItem = null;
            this.bindingNavigatorTreatment.MoveLastItem = null;
            this.bindingNavigatorTreatment.MoveNextItem = null;
            this.bindingNavigatorTreatment.MovePreviousItem = null;
            this.bindingNavigatorTreatment.Name = "bindingNavigatorTreatment";
            this.bindingNavigatorTreatment.PositionItem = null;
            this.bindingNavigatorTreatment.Size = new System.Drawing.Size(485, 25);
            this.bindingNavigatorTreatment.TabIndex = 33;
            this.bindingNavigatorTreatment.Text = "bindingNavigator3";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Добавить";
            // 
            // patientInformationtreatmentBindingSource
            // 
            this.patientInformationtreatmentBindingSource.DataMember = "patient informationtreatment";
            this.patientInformationtreatmentBindingSource.DataSource = this.patient_informationBindingSource;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Удалить";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::patientregistry.Properties.Resources.save;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Сохранить";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // treatmentDataGridView
            // 
            this.treatmentDataGridView.AutoGenerateColumns = false;
            this.treatmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.treatmentDataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.treatmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeTreatmentDataGridViewTextBoxColumn,
            this.idPatientDataGridViewTextBoxColumn,
            this.educationDataGridViewCheckBoxColumn,
            this.medicamentDataGridViewTextBoxColumn,
            this.dateOfAppointmentDataGridViewTextBoxColumn,
            this.doseDataGridViewTextBoxColumn,
            this.compliance3MonthDataGridViewCheckBoxColumn,
            this.compliance6MonthDataGridViewCheckBoxColumn,
            this.compliance12MonthDataGridViewCheckBoxColumn,
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn});
            this.treatmentDataGridView.DataSource = this.patientInformationtreatmentBindingSource;
            this.treatmentDataGridView.Location = new System.Drawing.Point(-1, 27);
            this.treatmentDataGridView.Name = "treatmentDataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.treatmentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.treatmentDataGridView.Size = new System.Drawing.Size(492, 397);
            this.treatmentDataGridView.TabIndex = 0;
            // 
            // codeTreatmentDataGridViewTextBoxColumn
            // 
            this.codeTreatmentDataGridViewTextBoxColumn.DataPropertyName = "code treatment";
            this.codeTreatmentDataGridViewTextBoxColumn.HeaderText = "№";
            this.codeTreatmentDataGridViewTextBoxColumn.Name = "codeTreatmentDataGridViewTextBoxColumn";
            this.codeTreatmentDataGridViewTextBoxColumn.Width = 51;
            // 
            // idPatientDataGridViewTextBoxColumn
            // 
            this.idPatientDataGridViewTextBoxColumn.DataPropertyName = "id patient";
            this.idPatientDataGridViewTextBoxColumn.HeaderText = "id patient";
            this.idPatientDataGridViewTextBoxColumn.Name = "idPatientDataGridViewTextBoxColumn";
            this.idPatientDataGridViewTextBoxColumn.Visible = false;
            this.idPatientDataGridViewTextBoxColumn.Width = 75;
            // 
            // educationDataGridViewCheckBoxColumn
            // 
            this.educationDataGridViewCheckBoxColumn.DataPropertyName = "education";
            this.educationDataGridViewCheckBoxColumn.HeaderText = "Обучен";
            this.educationDataGridViewCheckBoxColumn.Name = "educationDataGridViewCheckBoxColumn";
            this.educationDataGridViewCheckBoxColumn.ToolTipText = "\"Школа Остеопороза\"";
            this.educationDataGridViewCheckBoxColumn.Width = 67;
            // 
            // medicamentDataGridViewTextBoxColumn
            // 
            this.medicamentDataGridViewTextBoxColumn.DataPropertyName = "medicament";
            this.medicamentDataGridViewTextBoxColumn.HeaderText = "Лекарственный препарат";
            this.medicamentDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Ca + вит. D",
            "Фосаванс",
            "Осталон",
            "Теванат",
            "Бонвива",
            "Акласта",
            "Фосамакс",
            "Форстео",
            "Деносумаб",
            "Бивалос",
            "Микальцик"});
            this.medicamentDataGridViewTextBoxColumn.Name = "medicamentDataGridViewTextBoxColumn";
            this.medicamentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.medicamentDataGridViewTextBoxColumn.Width = 195;
            // 
            // dateOfAppointmentDataGridViewTextBoxColumn
            // 
            this.dateOfAppointmentDataGridViewTextBoxColumn.DataPropertyName = "date of appointment";
            this.dateOfAppointmentDataGridViewTextBoxColumn.HeaderText = "Дата назначения";
            this.dateOfAppointmentDataGridViewTextBoxColumn.Name = "dateOfAppointmentDataGridViewTextBoxColumn";
            this.dateOfAppointmentDataGridViewTextBoxColumn.Width = 141;
            // 
            // doseDataGridViewTextBoxColumn
            // 
            this.doseDataGridViewTextBoxColumn.DataPropertyName = "dose";
            this.doseDataGridViewTextBoxColumn.HeaderText = "Доза";
            this.doseDataGridViewTextBoxColumn.Name = "doseDataGridViewTextBoxColumn";
            this.doseDataGridViewTextBoxColumn.Width = 68;
            // 
            // compliance3MonthDataGridViewCheckBoxColumn
            // 
            this.compliance3MonthDataGridViewCheckBoxColumn.DataPropertyName = "compliance 3 month";
            this.compliance3MonthDataGridViewCheckBoxColumn.HeaderText = "Компланетность спустя 3 мес.";
            this.compliance3MonthDataGridViewCheckBoxColumn.Name = "compliance3MonthDataGridViewCheckBoxColumn";
            this.compliance3MonthDataGridViewCheckBoxColumn.Width = 179;
            // 
            // compliance6MonthDataGridViewCheckBoxColumn
            // 
            this.compliance6MonthDataGridViewCheckBoxColumn.DataPropertyName = "compliance 6 month";
            this.compliance6MonthDataGridViewCheckBoxColumn.HeaderText = "Комплаентность спустя 6 мес.";
            this.compliance6MonthDataGridViewCheckBoxColumn.Name = "compliance6MonthDataGridViewCheckBoxColumn";
            this.compliance6MonthDataGridViewCheckBoxColumn.Width = 179;
            // 
            // compliance12MonthDataGridViewCheckBoxColumn
            // 
            this.compliance12MonthDataGridViewCheckBoxColumn.DataPropertyName = "compliance 12 month";
            this.compliance12MonthDataGridViewCheckBoxColumn.HeaderText = "Комплаентность спустя 12 мес. и более";
            this.compliance12MonthDataGridViewCheckBoxColumn.Name = "compliance12MonthDataGridViewCheckBoxColumn";
            this.compliance12MonthDataGridViewCheckBoxColumn.Width = 186;
            // 
            // dateOfEndOfTherapyDataGridViewTextBoxColumn
            // 
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn.DataPropertyName = "date of end of therapy";
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn.HeaderText = "Дата окончания терапии";
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn.Name = "dateOfEndOfTherapyDataGridViewTextBoxColumn";
            this.dateOfEndOfTherapyDataGridViewTextBoxColumn.Width = 192;
            // 
            // tabPage6
            // 
            this.tabPage6.AutoScroll = true;
            this.tabPage6.BackColor = System.Drawing.Color.MintCream;
            this.tabPage6.Controls.Add(time_of_surgeryLabel1);
            this.tabPage6.Controls.Add(this.time_of_surgeryDateTimePicker);
            this.tabPage6.Controls.Add(discharge_dateLabel1);
            this.tabPage6.Controls.Add(this.discharge_dateDateTimePicker);
            this.tabPage6.Controls.Add(date_of_surgeryLabel1);
            this.tabPage6.Controls.Add(this.date_of_surgeryDateTimePicker);
            this.tabPage6.Controls.Add(arrival_dateLabel1);
            this.tabPage6.Controls.Add(this.arrival_dateDateTimePicker);
            this.tabPage6.Controls.Add(this.statusStrip1);
            this.tabPage6.Controls.Add(this.bindingNavigatorHospital);
            this.tabPage6.Controls.Add(code_hospitalLabel);
            this.tabPage6.Controls.Add(this.code_hospitalTextBox);
            this.tabPage6.Controls.Add(id_patientLabel1);
            this.tabPage6.Controls.Add(this.id_patientTextBox1);
            this.tabPage6.Controls.Add(___medical_cardLabel);
            this.tabPage6.Controls.Add(this.___medical_cardTextBox);
            this.tabPage6.Controls.Add(transfer_hospitalLabel);
            this.tabPage6.Controls.Add(this.transfer_hospitalTextBox);
            this.tabPage6.Controls.Add(type_of_fractureLabel);
            this.tabPage6.Controls.Add(this.type_of_fractureTextBox);
            this.tabPage6.Controls.Add(surgical_repairLabel);
            this.tabPage6.Controls.Add(this.surgical_repairCheckBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 54);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(491, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Стационар";
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // time_of_surgeryDateTimePicker
            // 
            this.time_of_surgeryDateTimePicker.CustomFormat = "00:00";
            this.time_of_surgeryDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientInformationhospitalBindingSource, "time of surgery", true));
            this.time_of_surgeryDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.time_of_surgeryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_of_surgeryDateTimePicker.Location = new System.Drawing.Point(136, 266);
            this.time_of_surgeryDateTimePicker.Name = "time_of_surgeryDateTimePicker";
            this.time_of_surgeryDateTimePicker.Size = new System.Drawing.Size(120, 28);
            this.time_of_surgeryDateTimePicker.TabIndex = 39;
            // 
            // patientInformationhospitalBindingSource
            // 
            this.patientInformationhospitalBindingSource.DataMember = "patient informationhospital";
            this.patientInformationhospitalBindingSource.DataSource = this.patient_informationBindingSource;
            // 
            // discharge_dateDateTimePicker
            // 
            this.discharge_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientInformationhospitalBindingSource, "discharge date", true));
            this.discharge_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.discharge_dateDateTimePicker.Location = new System.Drawing.Point(365, 318);
            this.discharge_dateDateTimePicker.Name = "discharge_dateDateTimePicker";
            this.discharge_dateDateTimePicker.Size = new System.Drawing.Size(109, 28);
            this.discharge_dateDateTimePicker.TabIndex = 38;
            // 
            // date_of_surgeryDateTimePicker
            // 
            this.date_of_surgeryDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientInformationhospitalBindingSource, "date of surgery", true));
            this.date_of_surgeryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_of_surgeryDateTimePicker.Location = new System.Drawing.Point(136, 219);
            this.date_of_surgeryDateTimePicker.Name = "date_of_surgeryDateTimePicker";
            this.date_of_surgeryDateTimePicker.Size = new System.Drawing.Size(120, 28);
            this.date_of_surgeryDateTimePicker.TabIndex = 37;
            // 
            // arrival_dateDateTimePicker
            // 
            this.arrival_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientInformationhospitalBindingSource, "arrival date", true));
            this.arrival_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrival_dateDateTimePicker.Location = new System.Drawing.Point(365, 107);
            this.arrival_dateDateTimePicker.Name = "arrival_dateDateTimePicker";
            this.arrival_dateDateTimePicker.Size = new System.Drawing.Size(109, 28);
            this.arrival_dateDateTimePicker.TabIndex = 36;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countDay,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // countDay
            // 
            this.countDay.Name = "countDay";
            this.countDay.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = global::patientregistry.Properties.Resources.w512h5121371568552512;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(348, 20);
            this.toolStripSplitButton1.Text = "Посчитать количество дней, проведенных в стационаре";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // bindingNavigatorHospital
            // 
            this.bindingNavigatorHospital.AddNewItem = this.toolStripButton10;
            this.bindingNavigatorHospital.BindingSource = this.patientInformationhospitalBindingSource;
            this.bindingNavigatorHospital.CountItem = null;
            this.bindingNavigatorHospital.DeleteItem = this.toolStripButton11;
            this.bindingNavigatorHospital.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorHospital.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12});
            this.bindingNavigatorHospital.Location = new System.Drawing.Point(3, 396);
            this.bindingNavigatorHospital.MoveFirstItem = null;
            this.bindingNavigatorHospital.MoveLastItem = null;
            this.bindingNavigatorHospital.MoveNextItem = null;
            this.bindingNavigatorHospital.MovePreviousItem = null;
            this.bindingNavigatorHospital.Name = "bindingNavigatorHospital";
            this.bindingNavigatorHospital.PositionItem = null;
            this.bindingNavigatorHospital.Size = new System.Drawing.Size(485, 25);
            this.bindingNavigatorHospital.TabIndex = 34;
            this.bindingNavigatorHospital.Text = "bindingNavigator4";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Добавить";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Удалить";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = global::patientregistry.Properties.Resources.save;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Сохранить";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // code_hospitalTextBox
            // 
            this.code_hospitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationhospitalBindingSource, "code hospital", true));
            this.code_hospitalTextBox.Location = new System.Drawing.Point(46, 3);
            this.code_hospitalTextBox.Multiline = true;
            this.code_hospitalTextBox.Name = "code_hospitalTextBox";
            this.code_hospitalTextBox.Size = new System.Drawing.Size(21, 20);
            this.code_hospitalTextBox.TabIndex = 1;
            this.code_hospitalTextBox.Visible = false;
            // 
            // id_patientTextBox1
            // 
            this.id_patientTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationhospitalBindingSource, "id patient", true));
            this.id_patientTextBox1.Location = new System.Drawing.Point(449, 8);
            this.id_patientTextBox1.Multiline = true;
            this.id_patientTextBox1.Name = "id_patientTextBox1";
            this.id_patientTextBox1.Size = new System.Drawing.Size(34, 15);
            this.id_patientTextBox1.TabIndex = 3;
            this.id_patientTextBox1.Visible = false;
            // 
            // ___medical_cardTextBox
            // 
            this.___medical_cardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationhospitalBindingSource, "№ medical card", true));
            this.___medical_cardTextBox.Location = new System.Drawing.Point(200, 34);
            this.___medical_cardTextBox.Name = "___medical_cardTextBox";
            this.___medical_cardTextBox.Size = new System.Drawing.Size(114, 28);
            this.___medical_cardTextBox.TabIndex = 5;
            this.___medical_cardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transfer_hospitalTextBox
            // 
            this.transfer_hospitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationhospitalBindingSource, "transfer hospital", true));
            this.transfer_hospitalTextBox.Location = new System.Drawing.Point(153, 68);
            this.transfer_hospitalTextBox.Name = "transfer_hospitalTextBox";
            this.transfer_hospitalTextBox.Size = new System.Drawing.Size(290, 28);
            this.transfer_hospitalTextBox.TabIndex = 7;
            this.transfer_hospitalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type_of_fractureTextBox
            // 
            this.type_of_fractureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientInformationhospitalBindingSource, "type of fracture", true));
            this.type_of_fractureTextBox.Location = new System.Drawing.Point(205, 148);
            this.type_of_fractureTextBox.Name = "type_of_fractureTextBox";
            this.type_of_fractureTextBox.Size = new System.Drawing.Size(156, 28);
            this.type_of_fractureTextBox.TabIndex = 11;
            this.type_of_fractureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surgical_repairCheckBox
            // 
            this.surgical_repairCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.patientInformationhospitalBindingSource, "surgical repair", true));
            this.surgical_repairCheckBox.Location = new System.Drawing.Point(206, 186);
            this.surgical_repairCheckBox.Name = "surgical_repairCheckBox";
            this.surgical_repairCheckBox.Size = new System.Drawing.Size(99, 24);
            this.surgical_repairCheckBox.TabIndex = 13;
            this.surgical_repairCheckBox.UseVisualStyleBackColor = true;
            // 
            // patient_informationTableAdapter
            // 
            this.patient_informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.DEXATableAdapter = this.dEXATableAdapter;
            this.tableAdapterManager.diagnosisTableAdapter = null;
            this.tableAdapterManager.drugsTableAdapter = null;
            this.tableAdapterManager.fractureTableAdapter = null;
            this.tableAdapterManager.hospitalTableAdapter = this.hospitalTableAdapter;
            this.tableAdapterManager.interviewTableAdapter = this.interviewTableAdapter;
            this.tableAdapterManager.labTableAdapter = this.labTableAdapter;
            this.tableAdapterManager.patient_informationTableAdapter = this.patient_informationTableAdapter;
            this.tableAdapterManager.sexTableAdapter = this.sexTableAdapter;
            this.tableAdapterManager.treatmentTableAdapter = this.treatmentTableAdapter;
            this.tableAdapterManager.typelabtestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = patientregistry.registrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dEXATableAdapter
            // 
            this.dEXATableAdapter.ClearBeforeFill = true;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // interviewTableAdapter
            // 
            this.interviewTableAdapter.ClearBeforeFill = true;
            // 
            // labTableAdapter
            // 
            this.labTableAdapter.ClearBeforeFill = true;
            // 
            // sexTableAdapter
            // 
            this.sexTableAdapter.ClearBeforeFill = true;
            // 
            // treatmentTableAdapter
            // 
            this.treatmentTableAdapter.ClearBeforeFill = true;
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataMember = "sex";
            this.sexBindingSource.DataSource = this.registrDataSet;
            // 
            // interviewBindingSource
            // 
            this.interviewBindingSource.DataMember = "interview";
            this.interviewBindingSource.DataSource = this.registrDataSet;
            // 
            // labBindingSource
            // 
            this.labBindingSource.DataMember = "lab";
            this.labBindingSource.DataSource = this.registrDataSet;
            // 
            // dEXABindingSource
            // 
            this.dEXABindingSource.DataMember = "DEXA";
            this.dEXABindingSource.DataSource = this.registrDataSet;
            // 
            // treatmentBindingSource
            // 
            this.treatmentBindingSource.DataMember = "treatment";
            this.treatmentBindingSource.DataSource = this.registrDataSet;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "hospital";
            this.hospitalBindingSource.DataSource = this.registrDataSet;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(859, 489);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистр пациентов с остеопоротическими переломами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_informationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabGeneralInf.ResumeLayout(false);
            this.tabGeneralInf.PerformLayout();
            this.tabFactors.ResumeLayout(false);
            this.tabFactors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationinterviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorRF)).EndInit();
            this.bindingNavigatorRF.ResumeLayout(false);
            this.bindingNavigatorRF.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLab)).EndInit();
            this.bindingNavigatorLab.ResumeLayout(false);
            this.bindingNavigatorLab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationlabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDexa)).EndInit();
            this.bindingNavigatorDexa.ResumeLayout(false);
            this.bindingNavigatorDexa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationDEXABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEXADataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTreatment)).EndInit();
            this.bindingNavigatorTreatment.ResumeLayout(false);
            this.bindingNavigatorTreatment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationtreatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentDataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationhospitalBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHospital)).EndInit();
            this.bindingNavigatorHospital.ResumeLayout(false);
            this.bindingNavigatorHospital.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEXABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabGeneralInf;
        private System.Windows.Forms.TabPage tabFactors;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel searchLabel;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private registrDataSet registrDataSet;
        private System.Windows.Forms.BindingSource patient_informationBindingSource;
        private registrDataSetTableAdapters.patient_informationTableAdapter patient_informationTableAdapter;
        private registrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patient_informationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.TextBox id_patientTextBox;
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
        private registrDataSetTableAdapters.sexTableAdapter sexTableAdapter;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private System.Windows.Forms.ComboBox social_statusComboBox;
        private System.Windows.Forms.ToolStripButton patientRegistrySaveButton;
        private registrDataSetTableAdapters.interviewTableAdapter interviewTableAdapter;
        private System.Windows.Forms.BindingSource interviewBindingSource;
        private System.Windows.Forms.BindingSource patientInformationinterviewBindingSource;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.CheckBox smokingCheckBox;
        private System.Windows.Forms.CheckBox previous_fractureCheckBox;
        private System.Windows.Forms.CheckBox parental_hip_fractureCheckBox;
        private System.Windows.Forms.CheckBox glucocorticoidsCheckBox;
        private System.Windows.Forms.CheckBox rheumatoid_arthritisCheckBox;
        private System.Windows.Forms.CheckBox secondary_osteoporosisCheckBox;
        private System.Windows.Forms.CheckBox alcohol_3_or_more_units_dayCheckBox;
        private System.Windows.Forms.TextBox FRAX;
        private registrDataSetTableAdapters.labTableAdapter labTableAdapter;
        private System.Windows.Forms.BindingSource labBindingSource;
        private System.Windows.Forms.DataGridView labDataGridView;
        private System.Windows.Forms.BindingSource patientInformationlabBindingSource;
        private registrDataSetTableAdapters.DEXATableAdapter dEXATableAdapter;
        private System.Windows.Forms.BindingSource dEXABindingSource;
        private System.Windows.Forms.DataGridView dEXADataGridView;
        private System.Windows.Forms.BindingSource patientInformationDEXABindingSource;
        private registrDataSetTableAdapters.treatmentTableAdapter treatmentTableAdapter;
        private System.Windows.Forms.BindingSource treatmentBindingSource;
        private System.Windows.Forms.DataGridView treatmentDataGridView;
        private System.Windows.Forms.BindingSource patientInformationtreatmentBindingSource;
        private registrDataSetTableAdapters.hospitalTableAdapter hospitalTableAdapter;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.TextBox code_interviewTextBox;
        private System.Windows.Forms.TextBox code_hospitalTextBox;
        private System.Windows.Forms.BindingSource patientInformationhospitalBindingSource;
        private System.Windows.Forms.TextBox id_patientTextBox1;
        private System.Windows.Forms.TextBox ___medical_cardTextBox;
        private System.Windows.Forms.TextBox transfer_hospitalTextBox;
        private System.Windows.Forms.TextBox type_of_fractureTextBox;
        private System.Windows.Forms.CheckBox surgical_repairCheckBox;
        private System.Windows.Forms.TextBox id_patientTextBox2;
        private System.Windows.Forms.Label numberOfPatient;
        private System.Windows.Forms.BindingNavigator bindingNavigatorRF;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewRF;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemRF;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveRF;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLab;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDexa;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.BindingNavigator bindingNavigatorTreatment;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHospital;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel countDay;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTreatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn educationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn medicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAppointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compliance3MonthDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compliance6MonthDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn compliance12MonthDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEndOfTherapyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDexaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttestScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox sex_of_personeComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker discharge_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_of_surgeryDateTimePicker;
        private System.Windows.Forms.DateTimePicker arrival_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeLabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAnalysisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nameTestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testResultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker date_of_interviewDateTimePicker;
        private System.Windows.Forms.DateTimePicker time_of_surgeryDateTimePicker;
        private System.Windows.Forms.ToolStripButton refreshPatient;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.Button Fraxbtn;
    }
}

