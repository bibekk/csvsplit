using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace SplitCSV
{

    public class CSVManager
    {
        public static string m_baseDir = string.Empty;

        public static async Task writeCSV(string file_name, string filenumber, string content)
        {
            try
            {
                var dir = file_name.Split('\\');
                for (var i = 0; i < dir.Length - 1; i++)
                {
                    m_baseDir += dir[i] + "\\";
                }

                var fwo = dir[dir.Length - 1].Split('.');


                if (!Directory.Exists(m_baseDir + "\\SplittedFiles"))
                {
                    Directory.CreateDirectory(m_baseDir + "\\SplittedFiles");
                }
                string filename = m_baseDir + "\\SplittedFiles\\" + fwo[0] +"_"+ filenumber + ".csv";


                byte[] encodedText = Encoding.UTF8.GetBytes(content+ Environment.NewLine);
              

                using (FileStream sourceStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write, bufferSize: 4096, useAsync: true))
                {

                     await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
                }

               // await Task.Run();

                /*
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename, true))
                {
                   await sw.WriteLineAsync(content);
                    //sw.WriteLine(content);
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                m_baseDir = string.Empty;
            }
        }

        public static async void splitCSV(string file_name, int numberOfRows,string[] header_array)
        {
            string[] headers = header_array; // CSVRW.getHeaders(file_name);
            int totalitems = Main.totalrows; // CSVRW.getRows(file_name);
          //  foreach()
            List<string> result = CSVRW.ReadCSV(headers, file_name).ToList();
            int count = 0;

            List<string> temp = new List<string>();
            foreach (var t in result)
            {
                if (count != 0)
                {
                    temp.Add(t);
                }
                count++;
            }
            result.Clear();
            count = 0;

            int fileCounter = 0;
            
            foreach (var s in temp)
            {
                if (count == 0 || (count % (numberOfRows)) == 0)
                {
                    fileCounter++;
                    string splits = Math.Ceiling((double)totalitems / (double)numberOfRows).ToString();
                    Main.lblProgressSplit.Text ="Writing " + fileCounter.ToString() + " of " + splits;

                    await writeCSV(file_name, fileCounter.ToString(), string.Join(",", headers));
                }

                var t = s.Split('#');
                string row = string.Empty;
                for (var i = 1; i <= headers.Length; i++)
                {
                    if (i < headers.Length)
                    {
                        row += t[i] + ",";
                    }
                    else
                    {
                        row += t[i];
                    }
                }
                await writeCSV(file_name, fileCounter.ToString(), row);
                count++;
                var tt = (double)count / (double)(Main.totalrows) * 100;
                Main.progressSplit.Value = (int)tt;

                if ((int)tt == 100)
                {
                    Main.processComplete();

                }

                if (Main.flag)
                {
                    Main.processComplete(type:"Cancel");
                    break;
                }
            }

           
            
        }

       
    }
}
