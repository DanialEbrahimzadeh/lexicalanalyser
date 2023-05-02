using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Compiler__First_Stage_
{
    class phase_table_class
    {
        List<token_class> token_list;

        public phase_table_class()
        {
            token_list = new List<token_class>();
        }

        public bool search_keyword(token_class t1)
        {
            if (t1.type == "id")
                if (t1.token == "int" || t1.token == "void" || t1.token == "if" || t1.token == "double" || t1.token == "while" || t1.token == "else" || t1.token == "return")
                    return true;
            return false;
        }
        public void add_phase_table(token_class _token_class)
        {
            if (search_keyword(_token_class))
                _token_class.type = "keyword";
            token_list.Add(_token_class);
        }

        public void write_to_file(string file_name)
        {
            FileStream aFile = new FileStream(file_name, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);

            for (int i = 0; i < token_list.Count; i++)
            {
                if (token_list[i].token != "")
                {
                    string s = token_list[i].row_number + "\t" + token_list[i].col_number + "\t" + token_list[i].type;
                    if (token_list[i].type == "id" || token_list[i].type == "digit" || token_list[i].type == "keyword")
                        s += "\t" + token_list[i].token;

                    sw.WriteLine(s);
                }
            }
            sw.Close();
            aFile.Close();
        }
    }
}
