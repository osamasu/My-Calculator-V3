using FontAwesome.Sharp;
using My_Calculator_V2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Design
{

    public partial class CalculatorFrm : Form
    {

        public CalculatorFrm()
        {
            InitializeComponent();
            LB_Equation.Text = string.Empty;
        }


        private Stack<float> NumbersStack = new Stack<float>();
        private Stack<char> OperatorsStack = new Stack<char>();

        // Create Instance and Subscribe On Event To Each Instance
        private Dictionary<char, clsCalculator> DOperations = new Dictionary<char, clsCalculator>
        {
            { '+', new clsCalculator(Add) },
            { '-',new clsCalculator(Subtract)} ,
            {'*',new clsCalculator(Multiply) },
            {'/',new clsCalculator(Divide) }
        };



        #region Native Methods
        // Native Methods ----------------------------------
        private static float Add(float Num1, float Num2)
        {
            return Num1 + Num2;
        }
        private static float Subtract(float Num1, float Num2)
        {
            return Num1 - Num2;
        }
        private static float Multiply(float Num1, float Num2)
        {
            return Num1 * Num2;
        }
        private static float Divide(float Num1, float Num2)
        {
            return Num1 / Num2;
        }
        private bool IsOperator(char input)
        {
            return input == '+' || input == '-' || input == '*' || input == '/';
        }

        // ---------------------------------------------------
        #endregion


        #region Handling GUI Winform Calc
        private bool _isPreviousOperationExist()
        {
            char LastOpMark = TB_Result.Text[TB_Result.Text.Length - 1];
            return IsOperator(LastOpMark);
        }

        private void PerformCalculation()
        {
            if (NumbersStack.Count >= 2 && OperatorsStack.Count >= 1)
            {
                float Number = NumbersStack.Pop();
                float EffectedNumber = NumbersStack.Pop();
                char Operator = OperatorsStack.Pop();

                if (DOperations.TryGetValue(Operator, out clsCalculator Calculator))
                {
                    float Result = Calculator.PerformOperation(EffectedNumber, Number);
                    NumbersStack.Push(Result);
                    clsCalculator.FinalResult = Result;
                }
                else
                    throw new ArgumentException("Invalid Operator");


                UpdateDisplay();
            }
        }

        private void _UpdateEquation()
        {
            if (NumbersStack.Count > 1 && OperatorsStack.Count >= 1)
            {
                LB_Equation.Text = TB_Result.Text;
            }
        }

        private void Operators_ClickShared(object sender, EventArgs e)
        {

            if (TB_Result.Text == string.Empty)
                return;

            IconButton OperatorClicked = (IconButton)sender;

            // Check if exist pop - make ability to change operation in calc without click delete
            if (_isPreviousOperationExist())
            {
                OperatorsStack.Pop();
                OperatorsStack.Push(char.Parse(OperatorClicked.Tag.ToString()));
            }

            // perform it if its ex: 5 + 9 ( 2 number > 1 operation )
            if (NumbersStack.Count > OperatorsStack.Count)
            {
                _UpdateEquation();
                PerformCalculation();
                OperatorsStack.Push(Convert.ToChar(OperatorClicked.Tag));
            }

            UpdateDisplay();


        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            _UpdateEquation();
            PerformCalculation();
            isDotPressed = false;
        }

        private void UpdateDisplay()
        {

            List<string> DisplayList = new List<string>();


            float[] NumbersArray = NumbersStack.Reverse().ToArray();
            char[] OperatorsArray = OperatorsStack.Reverse().ToArray();


            for (int Index = 0; Index < NumbersArray.Length; Index++)
            {
                DisplayList.Add(NumbersArray[Index].ToString());

                if (Index < OperatorsArray.Length)
                {
                    DisplayList.Add(OperatorsArray[Index].ToString());
                }
            }


            string DisplayResult = string.Join(" ", DisplayList);

            TB_Result.Text = DisplayResult;

        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (TB_Result.Text == "0")
                TB_Result.Clear();

            IconButton PressedNumber = (IconButton)sender;



            if (NumbersStack.Count == OperatorsStack.Count || isDotPressed)
            {
                if (float.TryParse(PressedNumber.Tag.ToString(), out float EnteredNumber))
                {
                    if (isDotPressed)
                    {
                        NumbersStack.Push((NumbersStack.Pop() + float.Parse($".{EnteredNumber}")));
                        isDotPressed = false;
                    }
                    else
                        NumbersStack.Push(EnteredNumber);
                }
            }
            else
            {
                float CurrentNumber = NumbersStack.Pop();
                byte EnteredNumber = Convert.ToByte(PressedNumber.Tag.ToString());

                if (CurrentNumber.ToString().Contains('.'))
                    CurrentNumber = float.Parse($"{CurrentNumber}{EnteredNumber}");

                else
                    CurrentNumber = CurrentNumber * 10 + EnteredNumber;


                NumbersStack.Push(CurrentNumber);
            }


            UpdateDisplay();
        }


        private void Keys_Pressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: Btn_Equals_Click(sender, EventArgs.Empty); break;
                case Keys.C: Btn_Clear.PerformClick(); break;
                case Keys.Decimal: Dot.PerformClick(); break;
                case Keys.NumPad0: Number_Zero.PerformClick(); break;
                case Keys.NumPad1: Btn_One.PerformClick(); break;
                case Keys.NumPad2: Btn_Two.PerformClick(); break;
                case Keys.NumPad3: Btn_Three.PerformClick(); break;
                case Keys.NumPad4: Btn_Four.PerformClick(); break;
                case Keys.NumPad5: Btn_Five.PerformClick(); break;
                case Keys.NumPad6: Btn_Six.PerformClick(); break;
                case Keys.NumPad7: Btn_Seven.PerformClick(); break;
                case Keys.NumPad8: Btn_Eight.PerformClick(); break;
                case Keys.NumPad9: Btn_Nine.PerformClick(); break;
                case Keys.Back: Btn_Delete.PerformClick(); break;
                case Keys.Add: Btn_Plus.PerformClick(); break;
                case Keys.Subtract: Btn_Mainus.PerformClick(); break;
                case Keys.Multiply: Btn_Multiply.PerformClick(); break;
                case Keys.Divide: Btn_Divide.PerformClick(); break;
            }

            e.Handled = true;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            NumbersStack.Clear();
            OperatorsStack.Clear();
            clsCalculator.FinalResult = 0.0f;
            UpdateDisplay();
        }

        bool isDotPressed = false;
        private void Dot_Click(object sender, EventArgs e)
        {

            if (!isDotPressed)
            {
                if (_isPreviousOperationExist())
                {
                    TB_Result.Text += "0.";
                    NumbersStack.Push(0);
                }
                else
                    TB_Result.Text += '.';



                isDotPressed = true;
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (TB_Result.Text == string.Empty)
                return;

            if (_isPreviousOperationExist())
            {
                OperatorsStack.Pop();
            }

            else
            {
                float Number = NumbersStack.Pop();
                string NumberInString = Number.ToString();
                if (NumberInString.Length > 1)
                {
                    NumberInString = NumberInString.Substring(0, NumberInString.Length - 1);
                    NumbersStack.Push(float.Parse(NumberInString));
                }

            }

            UpdateDisplay();
        }

        private void Btn_Divide_Click(object sender, EventArgs e) => Operators_ClickShared(sender, e);
        private void Btn_Multiply_Click(object sender, EventArgs e) => Operators_ClickShared(sender, e);
        private void Btn_Mainus_Click(object sender, EventArgs e) => Operators_ClickShared(sender, e);
        private void Btn_Plus_Click(object sender, EventArgs e) => Operators_ClickShared(sender, e);
        #endregion


        private void toolStripMenuReset_Click(object sender, EventArgs e) => Application.Restart();

        public void ApplyUICustom_DataBack(Color Btns_Colours, Color ResultBox_Colours, Color CalcBoxColour, Color CalcBack)
        {
            this.BackColor = CalcBack;

            this.Btn_One.BackColor = Btns_Colours;
            this.Btn_Two.BackColor = Btns_Colours;
            this.Btn_Three.BackColor = Btns_Colours;
            this.Btn_Four.BackColor = Btns_Colours;
            this.Btn_Five.BackColor = Btns_Colours;
            this.Btn_Six.BackColor = Btns_Colours;
            this.Btn_Seven.BackColor = Btns_Colours;
            this.Btn_Eight.BackColor = Btns_Colours;
            this.Btn_Nine.BackColor = Btns_Colours;

            Calc_Panel.BackColor = CalcBoxColour;

            panel2.BackColor = ResultBox_Colours;
            TB_Result.BackColor = ResultBox_Colours;
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DeveloperInfo = new AboutForm();
            DeveloperInfo.ShowDialog();
        }

        private void uIControlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI_Customasation UIController = new UI_Customasation(this);
            UIController._UIDataBack = ApplyUICustom_DataBack;
            UIController.ShowDialog();
        }
    }
}