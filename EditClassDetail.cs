using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Model;

namespace CRUD
{
    public partial class EditClassDetail : Form
    {
       public  ClassRoom? room { get; set; }
        public EditClassDetail(ClassRoom? room =null)
        {
            this.room = room;
            InitializeComponent();
            textBoxClassName.Text = room?.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (room == null)
            {

                //add new classrooom
                room = new ClassRoom
                {
                    classId = 0,
                    name = textBoxClassName.Text,
                    classTotal = 12,

                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                //edit selected classroom
                room.name = textBoxClassName.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
