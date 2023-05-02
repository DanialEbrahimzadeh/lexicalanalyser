using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Compiler__First_Stage_
{
    class symble_table_class
    {
        List<string> token;

        public symble_table_class()
        {
            token = new List<string>();
            token.Add("int");
            token.Add("double");
            token.Add("void");
            token.Add("if");
            token.Add("else");
            token.Add("while");
            token.Add("return");
        }

        public bool search_symble_table(string s)
        {
            int i = 0;
            while (i < token.Count)
            {
                if (token[i] == s)
                    return true;
                i++;
            }
            return false;
        }

        public void add_symble_table(string s)
        {
            token.Add(s);
        }

        public void write_to_file(string file_name)
        {
            FileStream aFile = new FileStream(file_name, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(aFile);

            foreach (string s in token)
            {
                sw.WriteLine(s);
            }
            sw.Close();
            aFile.Close();
        }
    }
}
