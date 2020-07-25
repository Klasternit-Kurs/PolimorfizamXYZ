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

namespace Polimorfizam
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			double ddd = 5.25;
			int bbb = (int)ddd;
			ddd = bbb;
			MessageBox.Show(ddd.ToString());

			Osoba osss = new Osoba();
			osss.Ime = "Pera";
			Object oooo = osss;
			osss = oooo as Osoba;
			MessageBox.Show(osss.Ime);

			List<object> lstObj = new List<object>();

			lstObj.Add(12);
			lstObj.Add(new Osoba());
			lstObj.Add(new Label());
			lstObj.Add("asd");

			foreach(object oo in lstObj)
			{
				if (oo is string)
				{
					MessageBox.Show("String!");
				} else if (oo is Osoba)
				{
					MessageBox.Show("Osoba");
				}

				switch(oo)
				{
					case int i:
						MessageBox.Show("Int je!");
						break;
					case Window w:
						MessageBox.Show("Prozor je :D");
						break;
				}
			}

			int broj = 5;
			double d = broj;

			broj = (int)d;

			Object o = new object();
			

			Osoba oso = new Osoba();
			
			o = oso;

			oso = o as Osoba;

			Bicikli b = new Bicikli();
			Automobil a = new Automobil();

			List<Vozilo> vozila = new List<Vozilo>();
			vozila.Add(a);
			vozila.Add(b);

			foreach(Vozilo v in vozila)
			{
				v.KreciSe();
				MessageBox.Show(v.BrzinaKretanja.ToString());
			}

			
		}

		abstract class Vozilo
		{
			public int BrojPutnika { get; set; }
			public decimal BrzinaKretanja { get; set; }

			public abstract void KreciSe();
			
		}

		class Bicikli : Vozilo
		{
			
			public string ModelPedala { get; set; }


			public override void KreciSe()
			{
				
			}
		}

		class Automobil : Vozilo
		{
			
			public int brojSedista { get; set; }

			public override void KreciSe()
			{
				throw new NotImplementedException();
			}
		}

		class Osoba
		{
			public string Ime;
			public string Prezime;
		}
	}
}
