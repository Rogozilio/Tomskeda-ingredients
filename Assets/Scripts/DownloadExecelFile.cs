using System.Net;
using System;
using UnityEngine;
using RestSharp;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Http;
using System.Collections;
using UnityEngine.Networking;

public class DownloadExecelFile
{
    public DownloadExecelFile(string cookie)
    {
        //BinaryFormatter bf = new BinaryFormatter();
        //FileStream file = File.Create(Application.persistentDataPath
        //      + "/menu.xls");
        //bf.Serialize(file, response.RawBytes);
        //file.Close();

    }
    public IEnumerator GetRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        uwr.SetRequestHeader("Cookie", "PHPSESSID=hgnosg7cqh9mshsm4ou7rujgf7");
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
        }
    }
}
