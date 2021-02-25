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

        public void EditPart(OrgnzForm pr)
        {
            this.part = pr;
        }
        public void SendDataToGrid(params object[] data)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].SetValues(data);
            //Определяем индекс текущей строки, записываем в неё пришедшие значения 
        }

    }
}
