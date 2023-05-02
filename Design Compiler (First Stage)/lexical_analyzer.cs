using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Compiler__First_Stage_
{
    class lexical_analyzer
    {
        public List<char> file_list;
        public int count, col, row;
        public lexical_analyzer()
        {
            file_list = new List<char>();
            count = 0;
            col = 0;
            row = 1;
        }

        public void create_list(string s)
        {
            char ch;
            int Tchar = 0;
            StreamReader reader;
            reader = new StreamReader(@s);
            do
            {
                ch = (char)reader.Read();
                file_list.Add(ch);
                Tchar++;
            } while (!reader.EndOfStream);
            reader.Close();
        }

        public bool is_white_space(char c)
        {
            if (c == ' ' || c == '\t' || c == '\n' || c == '\r')
                return true;
            return false;
        }

        public bool is_first_digit(char c)
        {
            if ((int)c >= 48 && (int)c <= 57)
                return true;
            return false;
        }

        public bool is_first_letter(char c)
        {
            if (((int)c >= 65 && (int)c <= 90) || ((int)c >= 97 && (int)c <= 122) || (int)c == 95)
                return true;
            return false;
        }

        public token_class get_next_token()
        {
            int col2 = 0;
            int row2 = 1;
            string type = "";
            string s = "";
            token_class result = new token_class();
            int state = 0;
            bool flag = true;
            while (flag && count < file_list.Count)
            {
                char c = file_list[count];
                switch (state)
                {
                    case 0:
                        if (is_white_space(c))
                            state = 1;
                        else if (is_first_letter(c))
                        {
                            col++;
                            state = 2;
                        }
                        else if (is_first_digit(c))
                        {
                            state = 3;
                            col++;
                        }
                        else if (c == ',')
                        {
                            state = 4;
                            col++;
                        }
                        else if (c == ';')
                        {
                            state = 5;
                            col++;
                        }
                        else if (c == ':')
                        {
                            state = 6;
                            col++;
                        }
                        else if (c == '>')
                        {
                            state = 7;
                            col++;
                        }
                        else if (c == '<')
                        {
                            state = 8;
                            col++;
                        }
                        else if (c == '=')
                        {
                            state = 9;
                            col++;
                        }
                        else if (c == '!')
                        {
                            state = 10;
                            col++;
                        }
                        else if (c == '*')
                        {
                            state = 11;
                            col++;
                        }
                        else if (c == '+')
                        {
                            state = 12;
                            col++;
                        }
                        else if (c == '-')
                        {
                            state = 13;
                            col++;
                        }
                        else if (c == '/')
                        {
                            state = 14;
                            col++;
                        }
                        else if (c == '{' || c == '}')
                        {
                            state = 15;
                            col++;
                        }
                        else if (c == '[' || c == ']')
                        {
                            state = 16;
                            col++;
                        }
                        else if (c == '(' || c == ')')
                        {
                            state = 17;
                            col++;
                        }
                        else
                        {
                            //error

                            state = 18;
                            col++;
                        }
                        break;
                    case 1:
                        if (is_white_space(c))
                        {
                            if (c == ' ')
                                col++;
                            else if (c == '\r')
                            {
                                count++;
                                c = file_list[count];
                                row++;

                                col = 0;
                            }
                            else if (c == '\t')
                                col += 4;
                        }
                        else
                        {

                            count--;
                            state = 0;
                        }
                        state = 0;
                        count++;
                        break;
                    case 2:
                        type = "id";
                        col2 = col;
                        row2 = row;
                        if (is_first_letter(c) || is_first_digit(c))
                        {
                            s = s.Insert(s.Count(), c.ToString());
                        }
                        else
                        {
                            type = "id";
                            count--;
                            state = 0;
                            //result = new token_class(s, "id", row, col);
                            col += s.Count() - 1;
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    case 3:
                        col2 = col;
                        row2 = row;
                        type = "digit";
                        if (is_first_digit(c))
                        {
                            s = s.Insert(s.Count(), c.ToString());
                        }
                        else if (c == '.')
                        {
                            s = s.Insert(s.Count(), c.ToString());
                            count++;
                            c = file_list[count];
                            if (is_first_digit(c))
                            {
                                s = s.Insert(s.Count(), c.ToString());
                                bool flag3 = true;
                                while (flag3)
                                {
                                    count++;
                                    c = file_list[count];
                                    if (is_first_digit(c))
                                    {
                                        s = s.Insert(s.Count(), c.ToString());
                                    }
                                    else
                                    {
                                        type = "digit";
                                        count--;
                                        //result = new token_class(s, "digit", row, col);
                                        col += s.Count() - 1;
                                        state = 0;
                                        flag3 = false;
                                        flag = false;
                                        //return result;
                                    }
                                }
                            }
                            else
                            {
                                col += s.Count() - 1;
                                type = "error";
                                flag = false;
                                //error
                            }
                        }
                        else
                        {
                            type = "digit";
                            count--;
                            state = 0;
                            //result = new token_class(s, "digit", row, col);                      
                            col += s.Count() - 1;
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    case 4:
                        type = "comma";
                        s = s.Insert(s.Count(), c.ToString());
                        state = 0;
                        //result = new token_class(s, "comma", row, col);
                        flag = false;
                        //return result;
                        col2 = col;
                        row2 = row;
                        count++;
                        break;
                    case 5:
                        type = "semicolon";
                        s = s.Insert(s.Count(), c.ToString());
                        state = 0;
                        //result = new token_class(s, "semicolon", row, col);
                        flag = false;
                        //return result;
                        col2 = col;
                        row2 = row;
                        count++;
                        break;
                    case 6:
                        s = s.Insert(s.Count(), c.ToString());
                        count++;
                        c = file_list[count];
                        col2 = col;
                        row2 = row;
                        if (c == '=')
                        {
                            type = "assignment";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "assignmend", row, col);
                            flag = false;
                            //return result;
                            col += s.Count() - 1;
                        }
                        else
                        {
                            count--;
                            col += s.Count() - 1;
                            type = "error";
                            flag = false;
                            //error
                        }
                        count++;
                        break;
                    case 7:
                        s = s.Insert(s.Count(), c.ToString());
                        count++;
                        col2 = col;
                        row2 = row;
                        c = file_list[count];
                        if (c == '=')
                        {
                            type = "greater equal";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "greater equal", row, col);
                            flag = false;
                            //return result;
                            col += s.Count() - 1;
                        }
                        else
                        {
                            type = "greater";
                            count--;
                            state = 0;
                            //result = new token_class(s, "greater", row, col);
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    case 8:
                        s = s.Insert(s.Count(), c.ToString());
                        count++;
                        col2 = col;
                        row2 = row;
                        c = file_list[count];
                        if (c == '=')
                        {
                            type = "less equal";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "less equal", row, col);
                            flag = false;
                            //return result;
                            col += s.Count() - 1;
                        }
                        else
                        {
                            type = "less";
                            count--;
                            state = 0;
                            //result = new token_class(s, "less", row, col);
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    case 9:
                        s = s.Insert(s.Count(), c.ToString());
                        count++;
                        col2 = col;
                        row2 = row;
                        c = file_list[count];
                        if (c == '=')
                        {
                            type = "equal";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "equal", row, col);
                            flag = false;
                            col += s.Count() - 1;
                        }
                        else
                        {
                            count--;
                            col += s.Count() - 1;
                            type = "error";
                            flag = false;
                            //error
                        }
                        count++;
                        break;

                    case 10:
                        s = s.Insert(s.Count(), c.ToString());
                        count++;
                        col2 = col;
                        row2 = row;
                        c = file_list[count];
                        if (c == '=')
                        {
                            type = "not equal";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "not equal", row, col);
                            flag = false;
                            //return result;
                            col += s.Count() - 1;
                        }
                        else
                        {
                            count--;
                            col += s.Count() - 1;
                            type = "error";
                            flag = false;
                            //error
                        }
                        count++;
                        break;
                    case 11:
                        type = "multiplication";
                        s = s.Insert(s.Count(), c.ToString());
                        state = 0;
                        //result = new token_class(s, "multiplicadion", row, col);
                        flag = false;
                        col2 = col;
                        row2 = row;
                        //return result;
                        count++;
                        break;
                    case 12:
                        type = "addition";
                        s = s.Insert(s.Count(), c.ToString());
                        state = 0;
                        //result = new token_class(s, "addition", row, col);
                        flag = false;
                        col2 = col;
                        row2 = row;
                        //return result;
                        count++;
                        break;
                    case 13:
                        type = "subtraction";
                        s = s.Insert(s.Count(), c.ToString());
                        state = 0;
                        //result = new token_class(s, "subtraction", row, col);
                        flag = false;
                        col2 = col;
                        row2 = row;
                        //return result;
                        count++;
                        break;
                    case 14:
                        s = s.Insert(s.Count(), c.ToString());
                        count++;
                        col2 = col;
                        row2 = row;
                        c = file_list[count];
                        bool flag2 = true;
                        int row_comment = 0, col_comment = 0;
                        if (c == '*')
                        {
                            //row2 = row;
                            //col2 = col;
                            s = s.Insert(s.Count(), c.ToString());
                            while (flag2)
                            {
                                count++;
                                c = file_list[count];
                                if (count == file_list.Count() - 1)
                                {
                                    s = s.Insert(s.Count(), c.ToString());
                                    type = "error";
                                    row += row_comment;
                                    if (row_comment == 0)
                                        col += col_comment;
                                    else
                                        col = col_comment;
                                    flag2 = false;
                                    flag = false;

                                }
                                else
                                {
                                    if (c == '\r')
                                    {
                                        s = s.Insert(s.Count(), c.ToString());
                                        count++;
                                        c = file_list[count];
                                        s = s.Insert(s.Count(), c.ToString());
                                        col_comment = 0;
                                        row_comment++;
                                    }
                                    else if (c == '\t')
                                    {
                                        col_comment += 4;
                                        s = s.Insert(s.Count(), c.ToString());
                                    }
                                    else if (c == '*')
                                    {
                                        s = s.Insert(s.Count(), c.ToString());
                                        count++;
                                        col_comment++;
                                        c = file_list[count];
                                        if (c == '/')
                                        {
                                            type = "comment";
                                            state = 0;
                                            flag2 = false;
                                            col_comment++;
                                            s = s.Insert(s.Count(), c.ToString());
                                            //result = new token_class(s, "comment", row, col);
                                            flag = false;
                                            //row2 = row;
                                            //col2 = col;
                                            row += row_comment;
                                            if (row_comment == 0)
                                                col += col_comment;
                                            else
                                                col = col_comment;
                                            //return result;
                                        }
                                        else
                                            count--;
                                    }
                                    else
                                    {
                                        s = s.Insert(s.Count(), c.ToString());
                                        col_comment++;
                                    }
                                }
                                //if (c == '\r')
                                //{
                                //    s = s.Insert(s.Count(), c.ToString());
                                //    count++;
                                //    c = file_list[count];
                                //    s = s.Insert(s.Count(), c.ToString());
                                //    col_comment = 0;
                                //    row_comment++;
                                //}
                                //else if (c == '\t')
                                //{
                                //    col_comment += 4;
                                //    s = s.Insert(s.Count(), c.ToString());
                                //}
                                //else if (c == '*')
                                //{
                                //    s = s.Insert(s.Count(), c.ToString());
                                //    count++;
                                //    col_comment++;
                                //    c = file_list[count];
                                //    if (c == '/')
                                //    {
                                //        type = "comment";
                                //        state = 0;
                                //        flag2 = false;
                                //        col_comment++;
                                //        s = s.Insert(s.Count(), c.ToString());
                                //        result = new token_class(s, "comment", row, col);
                                //        flag = false;
                                //        row += row_comment;
                                //        if (row_comment == 0)
                                //            col += col_comment;
                                //        else
                                //            col = col_comment;
                                //        return result;
                                //    }
                                //    else
                                //        count--;
                                //}
                                //else
                                //{
                                //    s = s.Insert(s.Count(), c.ToString());
                                //    col_comment++;
                                //}

                            }
                        }
                        else
                        {
                            type = "division";
                            count--;
                            state = 0;
                            //result = new token_class(s, "division", row, col);
                            flag = false;
                            //col2 = col;
                            //row2 = row;
                            //return result;
                        }
                        count++;
                        break;
                    case 15:
                        col2 = col;
                        row2 = row;
                        if (c == '{')
                        {
                            type = "open curly bracket";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "open curly bracket", row, col);
                            flag = false;
                            //return result;
                        }
                        else if (c == '}')
                        {
                            type = "close curly bracket";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "close curly bracket", row, col);
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    case 16:
                        col2 = col;
                        row2 = row;
                        if (c == '[')
                        {
                            type = "open bracket";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "open bracket", row, col);
                            flag = false;
                            //return result;
                        }
                        else if (c == ']')
                        {
                            type = "close baracket";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "close bracket", row, col);
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    case 17:
                        col2 = col;
                        row2 = row;
                        if (c == '(')
                        {
                            type = "open parenthes";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "open parenthes", row, col);
                            flag = false;
                            //return result;
                        }
                        else if (c == ')')
                        {
                            type = "close parenthes";
                            s = s.Insert(s.Count(), c.ToString());
                            state = 0;
                            //result = new token_class(s, "close parenthes", row, col);
                            flag = false;
                            //return result;
                        }
                        count++;
                        break;
                    default:
                        type = "error";
                        count++;
                        //error
                        s = s.Insert(s.Count(), c.ToString());
                        state = 0;
                        //result = new token_class(s, "error", row, col);
                        flag = false;
                        col2 = col;
                        row2 = row;
                        break;
                }
            }
            result = new token_class(s, type, row2, col2);
            return result;
        }
    }
}
