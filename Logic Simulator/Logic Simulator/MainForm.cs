using Logic_Simulator_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Simulator
{
    public partial class MainForm : Form
    {
        public List<int> inputs;
        public List<int> outputs;
        public List<LogicRecord> logicRecords;
        public List<string> outputFormula;

        Dictionary<int, int> inputSignalsDict;

        public MainForm()
        {
            InitializeComponent();
            SetMembers();
        }

        private void SetMembers()
        {
            inputs = new List<int>();
            outputs = new List<int>();
            logicRecords = new List<LogicRecord>();
            outputFormula = new List<string>();

            outputFormulaTextBox.Clear();
            inputStringTextBox.Clear();
            inputSignalsDict = new Dictionary<int, int>();
            outputValueTextBox.Clear();

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            string fileName = ofd.FileName;
            filePathTextBox.Text = fileName;
        }

        private void parseFileButton_Click(object sender, EventArgs e)
        {
            SetMembers();

            fileDisplayTextBox.Clear();
            outputFormulaTextBox.Clear();

            FileReader fileReader = new FileReader();
            logicRecords = fileReader.GetLogicRecords(filePathTextBox.Text);
            fileDisplayTextBox.Text = File.ReadAllText(filePathTextBox.Text);

            inputs = fileReader.GetInputs(filePathTextBox.Text);
            outputs = fileReader.GetOutputs(filePathTextBox.Text);

            Calculate();
        }

        private void Calculate()
        {
            foreach (int output in outputs)
            {
                ConstructFormula(output);
            }
        }

        private void ConstructFormula(int output)
        {
            LogicRecord logicRecord = logicRecords.Find(obj => obj._output == output);
            string formula;
            if (logicRecord._operator == Operators.BUF || logicRecord._operator == Operators.INV)
            {
                formula = "(" + logicRecord._operator + " " + logicRecord._inputs.ElementAt(0) + ")";
            }
            else
            {
                formula = GetSimplest(logicRecord._inputs.ElementAt(0)) + " " + logicRecord._operator.ToString() + " " + GetSimplest(logicRecord._inputs.ElementAt(1));
            }
            outputFormula.Add(formula);
            outputFormulaTextBox.AppendText(output + " = " + formula + "\n\n");
        }

        private string GetSimplest(int input)
        {
            LogicRecord logicRecord = logicRecords.Find(obj => obj._output == input);
            if (logicRecord == null)
            {
                return input.ToString();
            }
            else
            {
                if (logicRecord._operator == Operators.BUF || logicRecord._operator == Operators.INV)
                {
                    string part1 = GetSimplest(logicRecord._inputs.ElementAt(0));
                    string operatorPart = logicRecord._operator.ToString();
                    return "(" + operatorPart + " " + part1 + ")";
                }
                else
                {
                    string part1 = GetSimplest(logicRecord._inputs.ElementAt(0));
                    string operatorPart = logicRecord._operator.ToString();
                    string part2 = GetSimplest(logicRecord._inputs.ElementAt(1));

                    return "(" + part1 + " " + operatorPart + " " + part2 + ")";
                }
            }
        }

        private void applyInputButton_Click(object sender, EventArgs e)
        {
            outputValueTextBox.Clear();

            inputSignalsDict = new Dictionary<int, int>();
            string inputString = inputStringTextBox.Text;

            for (int i = 0; i < inputString.Length; i++)
            {
                inputSignalsDict.Add(inputs.ElementAt(i), int.Parse(inputString.ElementAt(i).ToString()));
            }

            foreach (int output in outputs)
            {
                outputValueTextBox.AppendText(output + " = " + GetSimplExp(output) + "\n\n");
            }
        }

        private int GetSimplExp(int output)
        {
            LogicRecord logicRecord = logicRecords.Find(obj => obj._output == output);
            int outputValue = -1;

            if (logicRecord == null)
            {
                bool success = inputSignalsDict.TryGetValue(output, out outputValue);
                return outputValue;
            }
            else
            {
                switch (logicRecord._operator)
                {
                    case Operators.INV:
                        return (GetSimplExp(logicRecord._inputs.ElementAt(0)) == 1) ? 0 : 1;
                    case Operators.BUF:
                        return (GetSimplExp(logicRecord._inputs.ElementAt(0)));

                    case Operators.AND:
                        return GetSimplExp(logicRecord._inputs.ElementAt(0)) & GetSimplExp(logicRecord._inputs.ElementAt(1));

                    case Operators.OR:
                        return GetSimplExp(logicRecord._inputs.ElementAt(0)) | GetSimplExp(logicRecord._inputs.ElementAt(1));

                    case Operators.NAND:
                        return ((GetSimplExp(logicRecord._inputs.ElementAt(0)) & GetSimplExp(logicRecord._inputs.ElementAt(1))) == 1) ? 0 : 1;

                    case Operators.NOR:
                        return ((GetSimplExp(logicRecord._inputs.ElementAt(0)) | GetSimplExp(logicRecord._inputs.ElementAt(1))) == 1) ? 0 : 1;

                    default:
                        return -1;
                }
            }
        }
    }
}
