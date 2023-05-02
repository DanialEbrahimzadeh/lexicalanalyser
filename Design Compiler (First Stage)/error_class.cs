using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Compiler__First_Stage_
{
    class error_class
    {
        List<token_class> token_list;

        public error_class()
        {
            token_list = new List<token_class>();
        }

        public void add_error(token_class _token_class)
        {
            token_list.Add(_token_class);
        }

        public void write_to_file(string file_name)
        {
            FileStream aFile = new FileStream(file_name, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);

            for (int i = 0; i < token_list.Count; i++)
            {
                string s = token_list[i].row_number + "\t" + token_list[i].col_number + "\t" + token_list[i].type + "\t" + token_list[i].token;                

                sw.WriteLine(s);
            }
            sw.Close();
            aFile.Close();
        }
    }
}
