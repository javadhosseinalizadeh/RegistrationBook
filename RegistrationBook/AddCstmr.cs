using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessEntity;
using BussinessLogicLayer;

namespace RegistrationBook
{
    public partial class AddCstmr : UserControl
    {
        public AddCstmr()
        {
            InitializeComponent();
        }
        Crud_Cstmr_BLL bll = new Crud_Cstmr_BLL();

        bool flag = true;

        int id;

        void dgv()
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = bll.Read();
        }
        
        void Clear()  //  clear textbox
        {
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "DevComponents.DotNetBar.Controls.TextBoxX")
                {
                    (item as TextBox).Text = "";
                }
            }
        }

        private void AddCstmr_Load(object sender, EventArgs e)
        {
            dgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CRUD_Cstmr c = new CRUD_Cstmr();

            c.name =txtName.Text;
            c.family=txtFamily.Text;
            c.cstmrid=txtcstmrid.Text;
            c.mobile=txtmobile.Text;
            c.natnlid=txtNtnalid.Text;
            c.phone=txtphone.Text;
            c.how = txtHow.Text;
            c.prdctname=txtprdctName.Text;
            c.cmpnyname=txtCmpnyName.Text;
            c.price=txtPrice.Text;
            c.dscrptn=txtDscrptn.Text;


            if(flag)
            {
                //create
                MessageBox.Show(bll.Create(c));
            }
            else if(!flag)
            {
                //update
                MessageBox.Show(bll.Update(id,c));
                flag = true;
                btnAdd.Text = "جدید";
            }
            dgv();
            Clear();
        }

        //private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells["id"].Value);
        //}

        private void ویرایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Cstmr c = bll.Read(id);

            c.name = txtName.Text;
            c.family = txtFamily.Text;
            c.cstmrid = txtcstmrid.Text;
            c.mobile = txtmobile.Text;
            c.natnlid = txtNtnalid.Text;
            c.phone = txtphone.Text;
            c.how = txtHow.Text;
            c.prdctname = txtprdctName.Text;
            c.cmpnyname = txtCmpnyName.Text;
            c.price = txtPrice.Text;
            c.dscrptn = txtDscrptn.Text;

            flag = false;

            btnAdd.Text = "ویرایش";
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll.Delete(id);
            dgv();
        }

        private void txtSrch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = null;
            dataGridViewX1.DataSource = bll.Read(txtSrch.Text);
        }

        //private void siticoneDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
        //    {
        //        contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        //    }
        //}

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewX1.Rows[dataGridViewX1.CurrentRow.Index].Cells[0].Value);
        }

        private void dataGridViewX1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
    }
}
