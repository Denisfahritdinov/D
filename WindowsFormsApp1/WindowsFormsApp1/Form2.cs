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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void данные_об_имущетсве__фактически_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.данные_об_имущетсве__фактически_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fahritdinovDbDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fahritdinovDbDataSet._Данные_об_имущетсве__фактически_". При необходимости она может быть перемещена или удалена.
            this.данные_об_имущетсве__фактически_TableAdapter.Fill(this.fahritdinovDbDataSet._Данные_об_имущетсве__фактически_);

        }
    }
}
