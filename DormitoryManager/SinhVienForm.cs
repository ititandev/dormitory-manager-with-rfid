using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DormitoryManager
{
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();

           // Global.FillDataToGrid("SELECT * FROM SinhVien", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader  = Global.GetQueryData("SELECT * FROM NhanVien");
            reader.Read();
            MessageBox.Show(reader[0].ToString());
            
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dormitoryDBDataSet.HopDong' table. You can move, or remove it, as needed.
            //this.hopDongTableAdapter.Fill(this.dormitoryDBDataSet.HopDong);

        }
    }
}
