using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

		}




		//vars 

		static public double amountBorrowed { get; set; }
		static public int interestRate { get; set; }

		static private int mortgagePeriod { get; set; }


		private void Button_Click(object sender, RoutedEventArgs e)
		{
			amountBorrowed = Convert.ToDouble(text_amount.Text);

			interestRate = Convert.ToInt32(text_interest.Text);

			mortgagePeriod = Int32.Parse(text_period.Text);


			lbl_totalAmount.Content = CalulateMortgage(amountBorrowed, interestRate, mortgagePeriod);





		}

		private string CalulateMortgage(double amountBorrowed, int interestRate, int mortgagePeriod)
		{
			double p = amountBorrowed;
			int  r = interestRate;
			int n = mortgagePeriod;

			double total = (p * r * n) / 100;
			 string totalAmount = total.ToString();




			return totalAmount;


		}
	}
}
