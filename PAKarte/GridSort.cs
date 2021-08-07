using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKarte
{
    public class GridSort : IComparer
    {
        private int index = 0;
        private int sortOrderMod = 1; //sort modifier

        public GridSort(SortOrder sortOrder, int index)
        {
            this.index = index;

            if (sortOrder == SortOrder.Ascending)
            {
                sortOrderMod = 1;
            }
            else
            {
                sortOrderMod = -1;
            }
        }

        public int Compare(object a, object b)
        {
            DataGridViewRow dgvr1 = (DataGridViewRow)a;
            DataGridViewRow dgvr2 = (DataGridViewRow)b;

            object dgvr1ToCompare = dgvr1.Cells[index].Value;
            object dgvr2ToCompare = dgvr2.Cells[index].Value;

            int res = dgvr1ToCompare.ToString().CompareTo(dgvr2ToCompare.ToString());

            return res * sortOrderMod;
        }
    }
}
