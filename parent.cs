using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainOrgnz
{
    class parent : OrgnzForm
    {
        public  OrgnzForm part; //родительская форма
        public object[] data;

        public void EditPart(OrgnzForm pr, object[] data_tt)
        {
            part = pr;
            data = data_tt;
        }
        public void SendDataToGrid(params object[] data_tt)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].SetValues(data_tt);
            //Определяем индекс текущей строки, записываем в неё пришедшие значения 
        }

    }
}
