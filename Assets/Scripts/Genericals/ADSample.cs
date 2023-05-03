using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
public class ADSample : MonoBehaviour, IUnityAdsInitializationListener,
IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidGameId;
    [SerializeField] string _iOSGameId;
    string _gameId;
    [SerializeField] bool _testMode = true;
    public Text myText;
    private void Awake()
    {
        myText.text = "el anuncio no se ha cargado";
        if (Advertisement.isInitialized)
        {
            Debug.Log("Advertisement is Initialized");
            //LoadRewardedAd();
        }
        else
        {
            InitializeAds();
        }
    }
    public void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? _iOSGameId : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, this);
    }
    public void OnInitializationComplete()
    {
        myText.text = "el anuncio se ha cargado";
        Debug.Log("Unity Ads initialization complete.");
        // LoadInerstitialAd();
        // LoadBannerAd();
    }
    public void OnInitializationFailed(UnityAdsInitializationError
    error, string message)
    {
        
    }
    public void LoadInerstitialAd()
    {
        Advertisement.Load("Interstitial_Android", this);
    }
    public void LoadRewardedAd()
    {
        
        Advertisement.Load("Rewarded_Android", this);
    }
    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("OnUnityAdsAdLoaded");
        Advertisement.Show(placementId, this);
    }
    public void OnUnityAdsFailedToLoad(string placementId,
    UnityAdsLoadError error, string message)
    {
       
    }
    public void OnUnityAdsShowFailure(string placementId,
    UnityAdsShowError error, string message)
    {
        Debug.Log("OnUnityAdsShowFailure");
    }
    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("OnUnityAdsShowStart");
        Time.timeScale = 0;
        Advertisement.Banner.Hide();
    }
    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("OnUnityAdsShowClick");
    }
    public void OnUnityAdsShowComplete(string placementId,
    UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("OnUnityAdsShowComplete " + showCompletionState);
        if (placementId.Equals("Rewarded_Android") &&
        UnityAdsShowCompletionState.COMPLETED.Equals(showCompletionState))
        {
            
            Debug.Log("Recompensamos al jugador");
        }
        Time.timeScale = 1;
    }
    public void LoadBannerAd()
    {
        //Esta funcion carga un Banner
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Load("Banner_Android",
    new BannerLoadOptions
    {
        loadCallback = OnBannerLoaded,
        errorCallback = OnBannerError
    }
    );
    }
    void OnBannerLoaded()
    {
        Advertisement.Banner.Show("Banner_Android");
    }
    void OnBannerError(string message)
    {
    }
}
