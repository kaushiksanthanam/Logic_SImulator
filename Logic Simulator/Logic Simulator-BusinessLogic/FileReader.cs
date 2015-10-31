using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Simulator_BusinessLogic
{
    public class FileReader
    {
        public FileReader()
        {
        }

        public List<LogicRecord> GetLogicRecords(string fileName)
        {
            List<string> allLinesInFile = File.ReadAllLines(fileName).ToList();
            List<LogicRecord> _logicRecords = new List<LogicRecord>();

            foreach (string line in allLinesInFile)
            {
                string[] splitColumns = line.Split(' ');
                LogicRecord logicRecord = new LogicRecord();
                bool success = Enum.TryParse(splitColumns[0], out logicRecord._operator);
                if (success)
                {
                    int lengthOfInput = splitColumns.Length - 1;
                    for (int i = 1; i < lengthOfInput; i++)
                    {
                        int input = int.Parse(splitColumns[i]);
                        logicRecord._inputs.Add(input);
                    }

                    logicRecord._output = int.Parse(splitColumns[splitColumns.Length - 1]);
                    _logicRecords.Add(logicRecord);
                }
            }

            return _logicRecords;
        }

        public List<int> GetInputs(string fileName)
        {
            List<int> inputs = new List<int>();

            List<string> allLines = File.ReadAllLines(fileName).ToList();
            foreach (string line in allLines)
            {
                if (line.Contains("INPUT"))
                {
                    string[] columns = line.Split(' ');
                    foreach (string col in columns)
                    {
                        int value;
                        bool success = int.TryParse(col, out value);
                        if (success)
                        {
                            if (value != -1)
                            {
                                inputs.Add(value);
                            }
                        }
                    }
                }
            }

            return inputs;
        }

        public List<int> GetOutputs(string fileName)
        {
            List<int> outputs = new List<int>();

            List<string> allLines = File.ReadAllLines(fileName).ToList();
            foreach (string line in allLines)
            {
                if (line.Contains("OUTPUT"))
                {
                    string[] columns = line.Split(' ');
                    foreach (string col in columns)
                    {
                        int value;
                        bool success = int.TryParse(col, out value);
                        if (success)
                        {
                            if (value != -1)
                            {
                                outputs.Add(value);
                            }
                        }
                    }
                }
            }

            return outputs;
        }
    }
}
