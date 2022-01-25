using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Core
{
    interface IRelationVisualisator
    {
        void DisplayRelation(DataGridView table, Table relation);
    }
}
