using CRUD.Model;
using CRUD.Service;

namespace CRUD
{
    public partial class Form1 : Form
    {
        List<ClassRoom> lsClass=new List<ClassRoom>();
        public Form1()
        {
            InitializeComponent();
            lsClass=ClassRoomService.GetFakeData();
            ShowCLassList();
        }
        
        
        public void ShowCLassList()
        {

            classRoomBindingSource.DataSource = null;
            classRoomBindingSource.DataSource = lsClass;
            toolStripStatusLabelTotal.Text = $"{lsClass.Count} classes";
            dataGridViewClass.DataSource = classRoomBindingSource;
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = classRoomBindingSource.Current as ClassRoom;
            if(selectedRow!= null)
            {
                var rs = MessageBox.Show("Bạn có muốn xoá không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(rs == System.Windows.Forms.DialogResult.OK)
                {
                    classRoomBindingSource.RemoveCurrent();
                    ShowCLassList();
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var f = new EditClassDetail();
            if(f.ShowDialog()== DialogResult.OK)
            {
                lsClass.Add(f.room);
                ShowCLassList();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            var selectedRow= classRoomBindingSource.Current as ClassRoom;
            if (selectedRow != null)
            {
                var f = new EditClassDetail();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ShowCLassList();
                }
            }
        }
    }
}