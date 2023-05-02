using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Compiler__First_Stage_
{
    class token_class
    {
        public string token;
        public string type;
        public int row_number;
        public int col_number;


        public token_class()
        {
            token = "";
            type = "";
            row_number = 0;
            col_number = 0;
        }

        public token_class(string token1, string type1, int row1, int col1)
        {
            token = token1;
            type = type1;
            row_number = row1;
            col_number = col1;
        }
    }
}
