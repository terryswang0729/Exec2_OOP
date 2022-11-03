using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void newGameBtn_Click(object sender, EventArgs e)
		{
			var game = new GuessNumber();
			game.NewGame();

		}
	}

	public class GuessNumber
	{
		private int answer;
		public void NewGame()
		{
			
		   
		}
		

	}
}
