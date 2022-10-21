using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MatematikIslemleri.Class
{
    internal class MathProccess
    {
        private static Random rdRandom = new();

        internal static void IdProccess(Label type)
        {
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new("insert into Proccess (Type) values ('" + type.Text + "') ", Connection.dbConnection);
            cmd.ExecuteNonQuery();
            Connection.dbConnection.Close();
            Connection.dbConnection.Open();
            SQLiteCommand cmd2 = new("select ID from Proccess order by ID desc", Connection.dbConnection);
            SQLiteDataReader rd = cmd2.ExecuteReader();
            while (rd.Read())
            {
                Variables.ID = Convert.ToUInt16(rd[0]);
                break;
            }
            rd.Close();
            Connection.dbConnection.Close();
        }
        internal static bool SqliteConnect(sbyte dbNumber1, char dbType, sbyte dbNumber2, sbyte conclusion, short result, bool isTrue, ushort proccessID)
        {
            try
            {
                Connection.dbConnection.Open();
                SQLiteCommand cmd = new("insert into MathProccess (_Date,Number1,Type,Number2,Conclusion,Result,IsTrue,ProccessID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", Connection.dbConnection);
                cmd.Parameters.AddWithValue("@p1", DateTime.Now.ToString("d"));
                cmd.Parameters.AddWithValue("@p2", dbNumber1);
                cmd.Parameters.AddWithValue("@p3", dbType.ToString());
                cmd.Parameters.AddWithValue("@p4", dbNumber2);
                cmd.Parameters.AddWithValue("@p5", conclusion);
                cmd.Parameters.AddWithValue("@p6", result);
                cmd.Parameters.AddWithValue("@p7", isTrue);
                cmd.Parameters.AddWithValue("@p8", proccessID);
                cmd.ExecuteNonQuery();
                Connection.dbConnection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        internal static void NewQuestion(Label number1, Label type, Label number2, TextBox result)
        {
            number1.Text = ((sbyte)rdRandom.Next(-10, 11)).ToString();
            number2.Text = ((sbyte)rdRandom.Next(-10, 11)).ToString();
            result.Text = string.Empty;
        }
        private static void TypeProccess()
        {

            if (Variables.Conclusion != Variables.resultText)
            {
                Variables.falseCount++;
                Variables.isTrue = false;
            }
            else
            {
                Variables.trueCount++;
                Variables.isTrue = true;
            }
        }
        internal static bool Control(Label number1, Label type, Label number2, TextBox resultBox, Label falseCount, Label trueCount, Label totalCount)
        {
            //NULL OR STRING CONTROL
            if (string.IsNullOrEmpty(resultBox.Text))
            {
                resultBox.Focus();
                return false;
            }
            //VALUES NUMBER IS CONTROL
            try
            {
                Variables.resultText = short.Parse(resultBox.Text);
            }
            catch (Exception)
            {
                resultBox.Text = string.Empty;
                resultBox.Focus();
                return false;
            }
            Variables.number1 = sbyte.Parse(number1.Text);
            Variables.type = char.Parse(type.Text);
            Variables.number2 = sbyte.Parse(number2.Text);
            if (Variables.type == '+')
            {
                Variables.Conclusion = (sbyte)(Variables.number1 + Variables.number2);
                TypeProccess();
            }
            else if (Variables.type == '-')
            {
                Variables.Conclusion = (sbyte)(Variables.number1 - Variables.number2);
                TypeProccess();
            }
            else if (Variables.type == 'X')
            {
                Variables.Conclusion = (sbyte)(Variables.number1 * Variables.number2);
                TypeProccess();
            }
            Variables.totalCount++;
            totalCount.Text = Variables.totalCount.ToString();
            falseCount.Text = Variables.falseCount.ToString();
            trueCount.Text = Variables.trueCount.ToString();
            return true;
        }
    }
}