namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.Label инвентарный_номерLabel;
            System.Windows.Forms.Label видLabel;
            System.Windows.Forms.Label кол_во_фактическое_Label;
            System.Windows.Forms.Label состояниеLabel;
            System.Windows.Forms.Label фИО_ИНВ_Label;
            System.Windows.Forms.Label фИО_ОТВ_Label;
            System.Windows.Forms.Label зона_ответсвеностиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fahritdinovDbDataSet = new WindowsFormsApp1.FahritdinovDbDataSet();
            this._инв_Должность_подстановкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._инв_Должность_подстановкаTableAdapter = new WindowsFormsApp1.FahritdinovDbDataSetTableAdapters._инв_Должность_подстановкаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.FahritdinovDbDataSetTableAdapters.TableAdapterManager();
            this.данные_об_имущетсве__фактически_TableAdapter = new WindowsFormsApp1.FahritdinovDbDataSetTableAdapters.Данные_об_имущетсве__фактически_TableAdapter();
            this.данные_об_имущетсве__фактически_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.инвентарный_номерTextBox = new System.Windows.Forms.TextBox();
            this.видTextBox = new System.Windows.Forms.TextBox();
            this.кол_во_фактическое_TextBox = new System.Windows.Forms.TextBox();
            this.состояниеTextBox = new System.Windows.Forms.TextBox();
            this.фИО_ИНВ_TextBox = new System.Windows.Forms.TextBox();
            this.фИО_ОТВ_TextBox = new System.Windows.Forms.TextBox();
            this.зона_ответсвеностиTextBox = new System.Windows.Forms.TextBox();
            this.данные_об_имущетсве__фактически_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.данные_об_имущетсве__фактически_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            инвентарный_номерLabel = new System.Windows.Forms.Label();
            видLabel = new System.Windows.Forms.Label();
            кол_во_фактическое_Label = new System.Windows.Forms.Label();
            состояниеLabel = new System.Windows.Forms.Label();
            фИО_ИНВ_Label = new System.Windows.Forms.Label();
            фИО_ОТВ_Label = new System.Windows.Forms.Label();
            зона_ответсвеностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fahritdinovDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._инв_Должность_подстановкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_об_имущетсве__фактически_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_об_имущетсве__фактически_BindingNavigator)).BeginInit();
            this.данные_об_имущетсве__фактически_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.данные_об_имущетсве__фактически_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // инвентарный_номерLabel
            // 
            инвентарный_номерLabel.AutoSize = true;
            инвентарный_номерLabel.Location = new System.Drawing.Point(12, 252);
            инвентарный_номерLabel.Name = "инвентарный_номерLabel";
            инвентарный_номерLabel.Size = new System.Drawing.Size(114, 13);
            инвентарный_номерLabel.TabIndex = 1;
            инвентарный_номерLabel.Text = "Инвентарный номер:";
            // 
            // видLabel
            // 
            видLabel.AutoSize = true;
            видLabel.Location = new System.Drawing.Point(12, 289);
            видLabel.Name = "видLabel";
            видLabel.Size = new System.Drawing.Size(29, 13);
            видLabel.TabIndex = 3;
            видLabel.Text = "Вид:";
            // 
            // кол_во_фактическое_Label
            // 
            кол_во_фактическое_Label.AutoSize = true;
            кол_во_фактическое_Label.Location = new System.Drawing.Point(12, 323);
            кол_во_фактическое_Label.Name = "кол_во_фактическое_Label";
            кол_во_фактическое_Label.Size = new System.Drawing.Size(116, 13);
            кол_во_фактическое_Label.TabIndex = 5;
            кол_во_фактическое_Label.Text = "Кол-во(фактическое):";
            // 
            // состояниеLabel
            // 
            состояниеLabel.AutoSize = true;
            состояниеLabel.Location = new System.Drawing.Point(12, 355);
            состояниеLabel.Name = "состояниеLabel";
            состояниеLabel.Size = new System.Drawing.Size(64, 13);
            состояниеLabel.TabIndex = 7;
            состояниеLabel.Text = "Состояние:";
            // 
            // фИО_ИНВ_Label
            // 
            фИО_ИНВ_Label.AutoSize = true;
            фИО_ИНВ_Label.Location = new System.Drawing.Point(381, 266);
            фИО_ИНВ_Label.Name = "фИО_ИНВ_Label";
            фИО_ИНВ_Label.Size = new System.Drawing.Size(66, 13);
            фИО_ИНВ_Label.TabIndex = 9;
            фИО_ИНВ_Label.Text = "ФИО(ИНВ):";
            // 
            // фИО_ОТВ_Label
            // 
            фИО_ОТВ_Label.AutoSize = true;
            фИО_ОТВ_Label.Location = new System.Drawing.Point(381, 308);
            фИО_ОТВ_Label.Name = "фИО_ОТВ_Label";
            фИО_ОТВ_Label.Size = new System.Drawing.Size(65, 13);
            фИО_ОТВ_Label.TabIndex = 11;
            фИО_ОТВ_Label.Text = "ФИО(ОТВ):";
            // 
            // зона_ответсвеностиLabel
            // 
            зона_ответсвеностиLabel.AutoSize = true;
            зона_ответсвеностиLabel.Location = new System.Drawing.Point(381, 352);
            зона_ответсвеностиLabel.Name = "зона_ответсвеностиLabel";
            зона_ответсвеностиLabel.Size = new System.Drawing.Size(113, 13);
            зона_ответсвеностиLabel.TabIndex = 13;
            зона_ответсвеностиLabel.Text = "Зона ответсвености:";
            // 
            // fahritdinovDbDataSet
            // 
            this.fahritdinovDbDataSet.DataSetName = "FahritdinovDbDataSet";
            this.fahritdinovDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _инв_Должность_подстановкаBindingSource
            // 
            this._инв_Должность_подстановкаBindingSource.DataMember = "(инв)Должность-подстановка";
            this._инв_Должность_подстановкаBindingSource.DataSource = this.fahritdinovDbDataSet;
            // 
            // _инв_Должность_подстановкаTableAdapter
            // 
            this._инв_Должность_подстановкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._инв_Должность_подстановкаTableAdapter = this._инв_Должность_подстановкаTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.FahritdinovDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.в_непригодном_состоянииTableAdapter = null;
            this.tableAdapterManager.Вид_подстановвкаTableAdapter = null;
            this.tableAdapterManager.Группа_инвентаризацииTableAdapter = null;
            this.tableAdapterManager.Данные_об_имуществе__по_документации_TableAdapter = null;
            this.tableAdapterManager.Данные_об_имущетсве__фактически_TableAdapter = this.данные_об_имущетсве__фактически_TableAdapter;
            this.tableAdapterManager.Область_ответсвености_подстановкаTableAdapter = null;
            this.tableAdapterManager.ОЛTableAdapter = null;
            this.tableAdapterManager.РасхождениеTableAdapter = null;
            this.tableAdapterManager.Расхождения_в_состоянии_имуществаTableAdapter = null;
            this.tableAdapterManager.Состояние_подстановкаTableAdapter = null;
            // 
            // данные_об_имущетсве__фактически_TableAdapter
            // 
            this.данные_об_имущетсве__фактически_TableAdapter.ClearBeforeFill = true;
            // 
            // данные_об_имущетсве__фактически_BindingSource
            // 
            this.данные_об_имущетсве__фактически_BindingSource.DataMember = "Данные об имущетсве( фактически)";
            this.данные_об_имущетсве__фактически_BindingSource.DataSource = this.fahritdinovDbDataSet;
            // 
            // инвентарный_номерTextBox
            // 
            this.инвентарный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "Инвентарный номер", true));
            this.инвентарный_номерTextBox.Location = new System.Drawing.Point(141, 249);
            this.инвентарный_номерTextBox.Name = "инвентарный_номерTextBox";
            this.инвентарный_номерTextBox.Size = new System.Drawing.Size(100, 20);
            this.инвентарный_номерTextBox.TabIndex = 2;
            this.инвентарный_номерTextBox.TextChanged += new System.EventHandler(this.инвентарный_номерTextBox_TextChanged);
            // 
            // видTextBox
            // 
            this.видTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "Вид", true));
            this.видTextBox.Location = new System.Drawing.Point(141, 289);
            this.видTextBox.Name = "видTextBox";
            this.видTextBox.Size = new System.Drawing.Size(100, 20);
            this.видTextBox.TabIndex = 4;
            // 
            // кол_во_фактическое_TextBox
            // 
            this.кол_во_фактическое_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "Кол-во(фактическое)", true));
            this.кол_во_фактическое_TextBox.Location = new System.Drawing.Point(141, 320);
            this.кол_во_фактическое_TextBox.Name = "кол_во_фактическое_TextBox";
            this.кол_во_фактическое_TextBox.Size = new System.Drawing.Size(100, 20);
            this.кол_во_фактическое_TextBox.TabIndex = 6;
            // 
            // состояниеTextBox
            // 
            this.состояниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "Состояние", true));
            this.состояниеTextBox.Location = new System.Drawing.Point(141, 352);
            this.состояниеTextBox.Name = "состояниеTextBox";
            this.состояниеTextBox.Size = new System.Drawing.Size(100, 20);
            this.состояниеTextBox.TabIndex = 8;
            // 
            // фИО_ИНВ_TextBox
            // 
            this.фИО_ИНВ_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "ФИО(ИНВ)", true));
            this.фИО_ИНВ_TextBox.Location = new System.Drawing.Point(500, 263);
            this.фИО_ИНВ_TextBox.Name = "фИО_ИНВ_TextBox";
            this.фИО_ИНВ_TextBox.Size = new System.Drawing.Size(100, 20);
            this.фИО_ИНВ_TextBox.TabIndex = 10;
            this.фИО_ИНВ_TextBox.TextChanged += new System.EventHandler(this.фИО_ИНВ_TextBox_TextChanged);
            // 
            // фИО_ОТВ_TextBox
            // 
            this.фИО_ОТВ_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "ФИО(ОТВ)", true));
            this.фИО_ОТВ_TextBox.Location = new System.Drawing.Point(500, 308);
            this.фИО_ОТВ_TextBox.Name = "фИО_ОТВ_TextBox";
            this.фИО_ОТВ_TextBox.Size = new System.Drawing.Size(100, 20);
            this.фИО_ОТВ_TextBox.TabIndex = 12;
            // 
            // зона_ответсвеностиTextBox
            // 
            this.зона_ответсвеностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_об_имущетсве__фактически_BindingSource, "Зона ответсвености", true));
            this.зона_ответсвеностиTextBox.Location = new System.Drawing.Point(500, 345);
            this.зона_ответсвеностиTextBox.Name = "зона_ответсвеностиTextBox";
            this.зона_ответсвеностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.зона_ответсвеностиTextBox.TabIndex = 14;
            // 
            // данные_об_имущетсве__фактически_BindingNavigator
            // 
            this.данные_об_имущетсве__фактически_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.BindingSource = this.данные_об_имущетсве__фактически_BindingSource;
            this.данные_об_имущетсве__фактически_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem});
            this.данные_об_имущетсве__фактически_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.данные_об_имущетсве__фактически_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.Name = "данные_об_имущетсве__фактически_BindingNavigator";
            this.данные_об_имущетсве__фактически_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.данные_об_имущетсве__фактически_BindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.данные_об_имущетсве__фактически_BindingNavigator.TabIndex = 15;
            this.данные_об_имущетсве__фактически_BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // данные_об_имущетсве__фактически_BindingNavigatorSaveItem
            // 
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("данные_об_имущетсве__фактически_BindingNavigatorSaveItem.Image")));
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem.Name = "данные_об_имущетсве__фактически_BindingNavigatorSaveItem";
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem.Click += new System.EventHandler(this.данные_об_имущетсве__фактически_BindingNavigatorSaveItem_Click);
            // 
            // данные_об_имущетсве__фактически_DataGridView
            // 
            this.данные_об_имущетсве__фактически_DataGridView.AutoGenerateColumns = false;
            this.данные_об_имущетсве__фактически_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.данные_об_имущетсве__фактически_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.данные_об_имущетсве__фактически_DataGridView.DataSource = this.данные_об_имущетсве__фактически_BindingSource;
            this.данные_об_имущетсве__фактически_DataGridView.Location = new System.Drawing.Point(0, 29);
            this.данные_об_имущетсве__фактически_DataGridView.Name = "данные_об_имущетсве__фактически_DataGridView";
            this.данные_об_имущетсве__фактически_DataGridView.Size = new System.Drawing.Size(800, 220);
            this.данные_об_имущетсве__фактически_DataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Зона ответсвености";
            this.dataGridViewTextBoxColumn7.HeaderText = "Зона ответсвености";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ФИО(ОТВ)";
            this.dataGridViewTextBoxColumn6.HeaderText = "ФИО(ОТВ)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ФИО(ИНВ)";
            this.dataGridViewTextBoxColumn5.HeaderText = "ФИО(ИНВ)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Состояние";
            this.dataGridViewTextBoxColumn4.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кол-во(фактическое)";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кол-во(фактическое)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вид";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Инвентарный номер";
            this.dataGridViewTextBoxColumn1.HeaderText = "Инвентарный номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.данные_об_имущетсве__фактически_DataGridView);
            this.Controls.Add(this.данные_об_имущетсве__фактически_BindingNavigator);
            this.Controls.Add(зона_ответсвеностиLabel);
            this.Controls.Add(this.зона_ответсвеностиTextBox);
            this.Controls.Add(фИО_ОТВ_Label);
            this.Controls.Add(this.фИО_ОТВ_TextBox);
            this.Controls.Add(фИО_ИНВ_Label);
            this.Controls.Add(this.фИО_ИНВ_TextBox);
            this.Controls.Add(состояниеLabel);
            this.Controls.Add(this.состояниеTextBox);
            this.Controls.Add(кол_во_фактическое_Label);
            this.Controls.Add(this.кол_во_фактическое_TextBox);
            this.Controls.Add(видLabel);
            this.Controls.Add(this.видTextBox);
            this.Controls.Add(инвентарный_номерLabel);
            this.Controls.Add(this.инвентарный_номерTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fahritdinovDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._инв_Должность_подстановкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_об_имущетсве__фактически_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_об_имущетсве__фактически_BindingNavigator)).EndInit();
            this.данные_об_имущетсве__фактически_BindingNavigator.ResumeLayout(false);
            this.данные_об_имущетсве__фактически_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.данные_об_имущетсве__фактически_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FahritdinovDbDataSet fahritdinovDbDataSet;
        private System.Windows.Forms.BindingSource _инв_Должность_подстановкаBindingSource;
        private FahritdinovDbDataSetTableAdapters._инв_Должность_подстановкаTableAdapter _инв_Должность_подстановкаTableAdapter;
        private FahritdinovDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FahritdinovDbDataSetTableAdapters.Данные_об_имущетсве__фактически_TableAdapter данные_об_имущетсве__фактически_TableAdapter;
        private System.Windows.Forms.BindingSource данные_об_имущетсве__фактически_BindingSource;
        private System.Windows.Forms.TextBox инвентарный_номерTextBox;
        private System.Windows.Forms.TextBox видTextBox;
        private System.Windows.Forms.TextBox кол_во_фактическое_TextBox;
        private System.Windows.Forms.TextBox состояниеTextBox;
        private System.Windows.Forms.TextBox фИО_ИНВ_TextBox;
        private System.Windows.Forms.TextBox фИО_ОТВ_TextBox;
        private System.Windows.Forms.TextBox зона_ответсвеностиTextBox;
        private System.Windows.Forms.BindingNavigator данные_об_имущетсве__фактически_BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton данные_об_имущетсве__фактически_BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView данные_об_имущетсве__фактически_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

