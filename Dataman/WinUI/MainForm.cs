using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatamanLib;

namespace WinUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// on click, turn device on.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnButton_Click(object sender, EventArgs e)
		{
			Controller.PowerOn();
			OutputLabel.Text = "=       ";
		}

		/// <summary>
		/// on click, turn device off.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OffButton_Click(object sender, EventArgs e)
		{
			Controller.PowerOff();
			UpdateDisplay();
		}

		private void HelpButton_Click(object sender, EventArgs e)
		{

		}

		private void ElectroFlashButton_Click(object sender, EventArgs e)
		{

		}

		private void WipeoutButton_Click(object sender, EventArgs e)
		{

		}

		private void NumberGuesserButton_Click(object sender, EventArgs e)
		{

		}

		private void ForceOutButton_Click(object sender, EventArgs e)
		{

		}

		private void GoButton_Click(object sender, EventArgs e)
		{

		}

		private void RandomProblemButton_Click(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// on click, add / to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DivideButton_Click(object sender, EventArgs e)
		{
			Controller.AddOperator('/');
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add * to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MultiplyButton_Click(object sender, EventArgs e)
		{
			Controller.AddOperator('*');
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add - to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SubtractButton_Click(object sender, EventArgs e)
		{
			Controller.AddOperator('-');
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add + to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddButton_Click(object sender, EventArgs e)
		{
			Controller.AddOperator('+');
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add = to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EqualsButton_Click(object sender, EventArgs e)
		{
			Controller.AddOperator('=');
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 9 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NineButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(9);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 8 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EightButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(8);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 7 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SevenButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(7);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 6 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SixButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(6);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 5 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FiveButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(5);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 4 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FourButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(4);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 3 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ThreeButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(3);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 2 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TwoButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(2);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 1 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OneButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(1);
			UpdateDisplay();
		}

		/// <summary>
		/// on click, add 0 to input.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ZeroButton_Click(object sender, EventArgs e)
		{
			Controller.AddNumber(0);
			UpdateDisplay();
		}

		/// <summary>
		/// update display to match input string.
		/// </summary>
		private void UpdateDisplay()
		{
			OutputLabel.Text = DataModel.Input;
		}
	}
}
