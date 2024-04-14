using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EXCERCISE_ARRAYS
{
    public partial class Form1 : Form
    {
        string[] Names;
        int index;

        int[,] Grades;
        int rowindex;
        int columnindex;
        public Form1()
        {
            InitializeComponent();
            Names = new string[10];
            index = 0;

            Grades= new int[2,5];
            rowindex = 0;
            columnindex = 0;
            
        }

        //One dimension 
        private void btnSaveName_Click(object sender, EventArgs e)
        {
            string data = "";
            if (index == Names.Length)
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    data += Names[i];
                }

                MessageBox.Show("Array is full:" + data);
                Names = new string[10];
                index = 0;
                return;
            }


            try
            {
                Names[index++] = txtName.Text;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Incorrect format, a string is required ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ");
            }

        }



        private void btnSaveGrades_Click(object sender, EventArgs e)
        {

            string data2 = "";
            if (rowindex == Grades.GetLength(0)&& columnindex==Grades.GetLength(1)) 
            {
                for (int i = 0; i < Grades.GetLength(0); i++)
                {
                    for (int j = 0; j < Grades.GetLength(1); j++)
                    {
                        data2 += Grades[i, j];
                    }
                }

                MessageBox.Show("Vector is full:" + data2);
                //Grades = new int [2,5];
                rowindex = 0;
                columnindex = 0;
                return;
            }
            try
            {
                Grades[rowindex, columnindex++] = Int32.Parse(txtGrades.Text);
                if (columnindex == Grades.GetLength(1))
                {
                    rowindex++;
                    columnindex = 0;
                }
            }
            catch (FormatException exe)
            {
                MessageBox.Show("Incorrect format, an integer is required. ");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message + " ");
            }

        }

        //Two dimensions 


    }
}
