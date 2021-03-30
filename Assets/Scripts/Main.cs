using RestSharp;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class Main : MonoBehaviour
{
    private SampleWebView _webView;
    private DownloadExecelFile _execelFile;

    private void Start()
    {
        _execelFile = new DownloadExecelFile("1");
        _webView = GetComponent<SampleWebView>();
        StartCoroutine(_execelFile.GetRequest("https://app.frontpad.ru/blocks/reports/product.php?export=1&filter_date1=27.03.2021 00:00:00&filter_date2=27.03.2021 23:59:59&cost="));
    }
    private void Update()
    {
        //if(_webView.IsCookieReady)
        //{
        //    _execelFile = new DownloadExecelFile(_webView.GetCookie());
        //}
    }
}
