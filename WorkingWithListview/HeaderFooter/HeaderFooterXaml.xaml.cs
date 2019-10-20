using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WorkingWithListview
{
	class Monkey {
		public string Name {get;set;}
		public string Description {get;set;}
	}

	class MonkeyVM {
		public List<Monkey> Monkeys { get; set; }
		public string Intro { get { return "Monkey Header"; }}
		public string Summary { get { return " There were " + Monkeys.Count + " monkeys"; }}
	}

	public partial class HeaderFooterXaml : ContentPage
	{
		public HeaderFooterXaml ()
		{
			InitializeComponent ();

			var monkeys = new List<Monkey> {
				new Monkey {Name="Xander", Description="graphic design software"},
				new Monkey {Name="Rupert", Description="software Engineer"},
				new Monkey {Name="Tammy", Description="Designer"},
				new Monkey {Name="Blue", Description="Speaker"},
                      new Monkey {Name="احمد محمد على", Description="اخصائى حسابات"},
                new Monkey {Name="هند محمد قاسم", Description="مبرمج "},
                new Monkey {Name="نوراحمد ", Description="اخصائى اجتماعى"},
                    new Monkey {Name="Xander ALO", Description="Writer"},
                new Monkey {Name="Rupert NOUR", Description="civil Engineer "},
                new Monkey {Name="Tammy mousa", Description="Graphic Designer"},
                new Monkey {Name="Blue black ", Description="Speaker arabic"},
                    new Monkey {Name="Xander", Description="graphic design software"},
                new Monkey {Name="Rupert", Description="software Engineer"},
                new Monkey {Name="Tammy", Description="Designer"},
                new Monkey {Name="Blue", Description="Speaker"},
                    new Monkey {Name="Xander ALO", Description="Writer"},
                new Monkey {Name="Rupert NOUR", Description="civil Engineer "},
                new Monkey {Name="Tammy mousa", Description="Graphic Designer"},
                new Monkey {Name="Blue black ", Description="Speaker arabic"},
                    new Monkey {Name="Xander", Description="graphic design software"},
                new Monkey {Name="Rupert", Description="software Engineer"},
                new Monkey {Name="Tammy", Description="Designer"},
                new Monkey {Name="Blue", Description="Speaker"},
                    new Monkey {Name="Xander ALO", Description="Writer"},
                new Monkey {Name="Rupert NOUR", Description="civil Engineer "},
                new Monkey {Name="Tammy mousa", Description="Graphic Designer"},
                new Monkey {Name="Blue black ", Description="Speaker arabic"},
                    new Monkey {Name="Xander", Description="graphic design software"},
                new Monkey {Name="Rupert", Description="software Engineer"},
                new Monkey {Name="Tammy", Description="Designer"},
                new Monkey {Name="Blue", Description="Speaker"},
                    new Monkey {Name="Xander ALO", Description="Writer"},
                new Monkey {Name="Rupert NOUR", Description="civil Engineer "},
                new Monkey {Name="Tammy mousa", Description="Graphic Designer"},
                new Monkey {Name="Blue black ", Description="Speaker arabic"},
                    new Monkey {Name="Xander", Description="graphic design software"},
                new Monkey {Name="Rupert", Description="software Engineer"},
                new Monkey {Name="Tammy", Description="Designer"},
                new Monkey {Name="Blue", Description="Speaker"},
                    new Monkey {Name="Xander ALO", Description="Writer"},
                new Monkey {Name="Rupert NOUR", Description="civil Engineer "},
                new Monkey {Name="Tammy mousa", Description="Graphic Designer"},
                new Monkey {Name="Blue black ", Description="Speaker arabic"},
                    new Monkey {Name="Xander", Description="graphic design software"},
                new Monkey {Name="Rupert", Description="software Engineer"},
                new Monkey {Name="Tammy", Description="Designer"},
                new Monkey {Name="Blue", Description="Speaker"},
                    new Monkey {Name="Xander ALO", Description="Writer"},
                new Monkey {Name="Rupert NOUR", Description="civil Engineer "},
                new Monkey {Name="Tammy mousa", Description="Graphic Designer"},
                new Monkey {Name="Blue black ", Description="Speaker arabic"},
                new Monkey {Name="احمد محمد على", Description="اخصائى حسابات"},
                new Monkey {Name="هند محمد قاسم", Description="مبرمج "},
                new Monkey {Name="نوراحمد ", Description="اخصائى اجتماعى"},
				//				new Monkey {Name="f", Description="fff"},
				//				new Monkey {Name="g", Description="ggg"},
				//				new Monkey {Name="i", Description="iii"},
				//				new Monkey {Name="j", Description="jjj"},
				//				new Monkey {Name="k", Description="kkk"},
				//				new Monkey {Name="l", Description="lll"},
				//				new Monkey {Name="m", Description="mmm"},
				//				new Monkey {Name="n", Description="nnn"},
				//				new Monkey {Name="o", Description="ooo"},
			};

			BindingContext = new MonkeyVM {Monkeys = monkeys};

			// alternative way of setting the Header's binding
			//listView.SetBinding (ListView.HeaderProperty, new Binding("."));
		}
	}
}

