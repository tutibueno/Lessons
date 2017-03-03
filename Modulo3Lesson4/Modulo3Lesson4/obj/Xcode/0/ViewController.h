// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <MapKit/MapKit.h>


@interface ViewController : UIViewController {
	MKMapView *_Map;
	UISegmentedControl *_Seletor;
	UIImageView *_Visor;
	UIWebView *_VisorWeb;
}

@property (nonatomic, retain) IBOutlet MKMapView *Map;

@property (nonatomic, retain) IBOutlet UISegmentedControl *Seletor;

@property (nonatomic, retain) IBOutlet UIImageView *Visor;

@property (nonatomic, retain) IBOutlet UIWebView *VisorWeb;

@end
