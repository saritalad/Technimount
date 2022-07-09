using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_ADOConsoleAPP_NewId
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectstring = "USER ID=SARITA;password=sarita;DATA SOURCE=abccomputer";
            OracleSequence(connectstring);


        }
        public static  void OracleSequence(String connectionString)
        {
            String insertString =
               "INSERT INTO SequenceTest_Table (ID, OtherColumn)" +
               "VALUES (SequenceTest_Sequence.NEXTVAL, :OtherColumn)" +
               "RETURNING ID INTO :ID";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                //Open a connection.  
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                // Prepare the database.  
                cmd.CommandText = "DROP SEQUENCE SequenceTest_Sequence";
                try { cmd.ExecuteNonQuery(); } catch { }

                cmd.CommandText = "DROP TABLE SequenceTest_Table";
                try { cmd.ExecuteNonQuery(); } catch { }

                cmd.CommandText = "CREATE TABLE SequenceTest_Table " +
                               "(ID int PRIMARY KEY, OtherColumn varchar(255))";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE SEQUENCE SequenceTest_Sequence " +
                                  "START WITH 100 INCREMENT BY 5";
                cmd.ExecuteNonQuery();

                DataTable testTable = new DataTable();
                DataColumn column = testTable.Columns.Add("ID", typeof(int));
                column.AutoIncrement = true;
                column.AutoIncrementSeed = -1;
                column.AutoIncrementStep = -1;
                testTable.PrimaryKey = new DataColumn[] { column };
                testTable.Columns.Add("OtherColumn", typeof(string));
                for (int rowCounter = 1; rowCounter <= 15; rowCounter++)
                {
                    testTable.Rows.Add(null, "Row #" + rowCounter.ToString());
                }

                Console.WriteLine("Before Update => ");
                foreach (DataRow row in testTable.Rows)
                {
                    Console.WriteLine("   {0} - {1}", row["ID"], row["OtherColumn"]);
                }
                Console.WriteLine();

                cmd.CommandText =
                  "SELECT ID, OtherColumn FROM SequenceTest_Table";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.InsertCommand = new OracleCommand(insertString, conn);
                da.InsertCommand.Parameters.Add(":ID", OracleType.Int32, 0, "ID");
                da.InsertCommand.Parameters[0].Direction = ParameterDirection.Output;
                da.InsertCommand.Parameters.Add(":OtherColumn", OracleType.VarChar, 255, "OtherColumn");
                da.InsertCommand.UpdatedRowSource = UpdateRowSource.OutputParameters;
                da.UpdateBatchSize = 10;

                da.Update(testTable);

                Console.WriteLine("After Update => ");
                foreach (DataRow row in testTable.Rows)
                {
                    Console.WriteLine("   {0} - {1}", row["ID"], row["OtherColumn"]);
                }
                // Close the connection.  
                conn.Close();
            }
        }





    }
}
