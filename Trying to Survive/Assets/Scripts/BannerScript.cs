using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class BannerScript : MonoBehaviour
{
    private BannerView bannerView;
    private AdRequest CreateAdRequest()
     {
         return new AdRequest.Builder()
             .Build();
     }
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        
        RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
       
        AdSize adSize = new AdSize(728, 90);
        string adUnitId = "ca-app-pub-6134849017853490/7355801135";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif
        if (this.bannerView != null)
        {
            this.bannerView.Destroy();
        }

        bannerView = new BannerView(adUnitId, adSize, 0,-620);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(this.CreateAdRequest());
        bannerView.Show();
    }
}
