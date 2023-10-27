using FontAwesome.Sharp;
using My_Calculator_V2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Design
{

    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
            LB_Equation.Text = string.Empty;

        }

        public enum enOperators
        { Plus = '+', Minus = '-', Multiply = '*', Divide = '/' };

        public class clsCalculator
        {
            public Double FinalResult = new Double();
            public Double Value = new Double();

            public Stack<double> ResultHistory = new Stack<double>();

            public Queue<enOperators> OperationsQueue = new Queue<enOperators>();

            public Queue<double> NumbersQueue = new Queue<double>();

            public Byte LastIndexOperator = 0;

        }

        private clsCalculator MyCalculator = new clsCalculator();

        private void _Algorithums(ref Double Num, enOperators Operation)
        {
            switch (Operation)
            {
                case enOperators.Plus:
                    MyCalculator.Value += Num;
                    break;

                case enOperators.Minus:
                    MyCalculator.Value -= Num;
                    break;

                case enOperators.Multiply:
                    MyCalculator.Value *= Num;
                    break;

                case enOperators.Divide:
                    MyCalculator.Value /= Num;
                    break;

            }
        }

        private Double _Calculate()
        {
            Double[] ArrNumber = MyCalculator.NumbersQueue.ToArray();

            _Algorithums(ref ArrNumber[0], enOperators.Plus);

            for (Byte i = 0; i < MyCalculator.NumbersQueue.Count - 1; i++)
            {
                _Algorithums(ref ArrNumber[i + 1], MyCalculator.OperationsQueue.Peek());

                MyCalculator.OperationsQueue.Dequeue();
            }

            return MyCalculator.Value;
        }

        private enOperators Operator(char Operator)
        {
            switch (Operator)
            {
                case '+':
                    return enOperators.Plus;

                case '-':
                    return enOperators.Minus;

                case '*':
                    return enOperators.Multiply;

                case '/':
                    return enOperators.Divide;

                default:
                    return 0;
            }
        }


        private void NumberClicked(Boolean isSecondPart = false)
        {
            double Number = 1;
            if (isSecondPart == false)
            {
                double.TryParse(TB_Result.Text.Substring(0, TB_Result.Text.Length - 1), NumberStyles.Number, null, out Number);
                MyCalculator.LastIndexOperator = (Byte)TB_Result.Text.LastIndexOf(TB_Result.Text[TB_Result.Text.Length - 1]);

            }
            else
            {
                String Equation = TB_Result.Text.Substring(MyCalculator.LastIndexOperator + 1);


                double.TryParse(Equation, NumberStyles.Number, null, out Number);
            }

            MyCalculator.NumbersQueue.Enqueue(Number);
        }



        private void Operators_Click(object sender, EventArgs e)
        {
            if (TB_Result.Text == String.Empty)
                return;


            if (_isPreviousOperationExist())
            {
                MyCalculator.OperationsQueue.Dequeue();
                MyCalculator.NumbersQueue.Dequeue();
                TB_Result.Text = TB_Result.Text.Substring(0, TB_Result.Text.Length - 1);
            }

            if (MyCalculator.OperationsQueue.Count == 1)
            {
                Btn_Equals.PerformClick();
            }

            IconButton OperatorClicked = (IconButton)sender;


            TB_Result.Text += OperatorClicked.Tag;

            MyCalculator.OperationsQueue.Enqueue(Operator((char)TB_Result.Text[TB_Result.Text.Length - 1]));

            NumberClicked();
        }

        private void Btn_Equals_Click(object sender, EventArgs e)
        {

            //LB_Equation.Text = TB_Result.Text + " =";
            NumberClicked(true);

            MyCalculator.FinalResult = _Calculate();
            TB_Result.Text = MyCalculator.FinalResult.ToString();

            MyCalculator.Value = 0;
            MyCalculator.NumbersQueue.Clear();
            MyCalculator.OperationsQueue.Clear();
            MyCalculator.LastIndexOperator = 0;

        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (TB_Result.Text == "0")
                TB_Result.Clear();

            IconButton PressedNumber = (IconButton)sender;
            TB_Result.Text += PressedNumber.Tag;
        }

        private bool _isPreviousOperationExist()
        {
            return (TB_Result.Text[TB_Result.Text.Length - 1] == '+') ? true : (TB_Result.Text[TB_Result.Text.Length - 1] == '-') ? true : (TB_Result.Text[TB_Result.Text.Length - 1] == '/') ? true : (TB_Result.Text[TB_Result.Text.Length - 1] == '*');
        }

        private void Keys_Pressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Btn_Equals_Click(sender, EventArgs.Empty);
                    break;

                case Keys.C:
                    Btn_Clear.PerformClick();
                    break;

                case Keys.Decimal:
                    Dot.PerformClick();
                    break;

                case Keys.NumPad0:
                    Number_Zero.PerformClick();
                    break;

                case Keys.NumPad1:
                    Btn_One.PerformClick();
                    break;

                case Keys.NumPad2:
                    Btn_Two.PerformClick();
                    break;

                case Keys.NumPad3:
                    Btn_Three.PerformClick();
                    break;

                case Keys.NumPad4:
                    Btn_Four.PerformClick();
                    break;

                case Keys.NumPad5:
                    Btn_Five.PerformClick();
                    break;

                case Keys.NumPad6:
                    Btn_Six.PerformClick();
                    break;

                case Keys.NumPad7:
                    Btn_Seven.PerformClick();
                    break;

                case Keys.NumPad8:
                    Btn_Eight.PerformClick();
                    break;

                case Keys.NumPad9:
                    Btn_Nine.PerformClick();
                    break;

                case Keys.Back:
                    Btn_Delete.PerformClick();
                    break;

                case Keys.Add:
                    Btn_Plus.PerformClick();
                    break;

                case Keys.Subtract:
                    Btn_Mainus.PerformClick();
                    break;

                case Keys.Multiply:
                    Btn_Multiply.PerformClick();
                    break;

                case Keys.Divide:
                    Btn_Divide.PerformClick();
                    break;
            }

            e.Handled = true;
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TB_Result.Clear();
            MyCalculator = new clsCalculator();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            TB_Result.Text += '.';
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (TB_Result.Text == String.Empty)
                return;


            if (_isPreviousOperationExist())
            {
                MyCalculator.OperationsQueue.Dequeue();
                MyCalculator.NumbersQueue.Dequeue();
            }
            TB_Result.Text = TB_Result.Text.Substring(0, TB_Result.Text.Length - 1);
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

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
    }
}