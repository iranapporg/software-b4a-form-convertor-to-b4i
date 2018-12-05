using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Form_Convertor
{
    public class MyListBoxItem
    {
        public MyListBoxItem(Color c, string m)
        {
            ItemColor = c;
            Message = m;
        }
        public Color ItemColor { get; set; }
        public string Message { get; set; }
    }
}
