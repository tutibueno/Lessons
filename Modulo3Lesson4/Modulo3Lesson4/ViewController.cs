using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using CoreLocation;
using MapKit;


namespace Modulo3Lesson4
{
	public partial class ViewController : UIViewController
	{

		private List<Dados> lista;


		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
			lista = DadosLista();
		}

		public List<Dados> DadosLista()
		{
			var informacaoLista = new List<Dados>()
			{
				new Dados("León, México", 21.152676, -101.711698),
				new Dados("Cancún, México", 21.052743, -86.847242),
				new Dados("Tijuana, México", 32.526384, -117.028983)
			};

			return informacaoLista;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Visor.Image = UIImage.FromFile("Rafita.jpg");
			Visor.ContentMode = UIViewContentMode.ScaleAspectFit;
			string htmlString = "<html>\n<header><title>This is title</title></header>\n<body>\nHello world\n</body>\n</html>";

			VisorWeb.LoadHtmlString(htmlString, new NSUrl("./", true));

			Seletor.ValueChanged += (sender, e) => { 
				switch (Seletor.SelectedSegment)
				{
					case 0:
						Map.MapType = MapKit.MKMapType.Standard;
						break;
					case 1:
						Map.MapType = MapKit.MKMapType.Satellite;
						break;
					case 2:
						Map.MapType = MapKit.MKMapType.Hybrid;
						break;
					default:
						break;
				}
			};

			lista.ForEach(x => Map.AddAnnotation(new MKPointAnnotation()
			{
				Title = x.Titulo,
				Coordinate = new CLLocationCoordinate2D()
				{
					Latitude = x.Latitude,
					Longitude = x.Longitude
				}
			}));



			var Leon = new CLLocationCoordinate2D(21.152676, -101.711698);
			var Cancun = new CLLocationCoordinate2D(21.052743, -86.847242);
			var Tijuana = new CLLocationCoordinate2D(32.526384, -117.028983);



		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
