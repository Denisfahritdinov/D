using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _инв_Должность_подстановкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._инв_Должность_подстановкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fahritdinovDbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fahritdinovDbDataSet._Данные_об_имущетсве__фактически_". При необходимости она может быть перемещена или удалена.
            this.данные_об_имущетсве__фактически_TableAdapter.Fill(this.fahritdinovDbDataSet._Данные_об_имущетсве__фактически_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fahritdinovDbDataSet.__инв_Должность_подстановка". При необходимости она может быть перемещена или удалена.
            this._инв_Должность_подстановкаTableAdapter.Fill(this.fahritdinovDbDataSet.@__инв_Должность_подстановка);

        }

        private void инвентарный_номерTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void фИО_ИНВ_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
