using Design;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_Calculator_V2
{
    public partial class UI_Customasation : Form
    {
        public delegate void UI_CustomasationEventHandler(Color Btns_Colours, Color ResultBox_Colours, Color CalcBoxColour, Color CalcBack);

        public UI_CustomasationEventHandler _UIDataBack;


        CalculatorFrm MyCalculatorForm;

        public UI_Customasation(CalculatorFrm MyCalculatorForm)
        {
            InitializeComponent();
            this.MyCalculatorForm = MyCalculatorForm;
            Panel_CalcBackground.BackColor = MyCalculatorForm.BackColor;
            Panel_CalcContainer.BackColor = MyCalculatorForm.Calc_Panel.BackColor;
            Panel_ResultBackground.BackColor = MyCalculatorForm.panel2.BackColor;
            panel_ButtonsColour.BackColor = MyCalculatorForm.Btn_One.BackColor;
            colorDialog1.FullOpen = true;
        }

        private void Btn_Nine_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Panel_CalcBackground.BackColor = colorDialog1.Color;
                iconButton3.PerformClick();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Panel_ResultBackground.BackColor = colorDialog1.Color;
                iconButton3.PerformClick();
            }

        }

        private void IBTN_Calc_Box_Colour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Panel_CalcContainer.BackColor = colorDialog1.Color;
                iconButton3.PerformClick();
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel_ButtonsColour.BackColor = colorDialog1.Color;
                iconButton3.PerformClick();
            }
        }

        private void UI_Customasation_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            _UIDataBack?.Invoke(panel_ButtonsColour.BackColor, Panel_ResultBackground.BackColor, Panel_CalcContainer.BackColor, Panel_CalcBackground.BackColor);
            // this.Close();
        }
    }
}
