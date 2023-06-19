using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Initializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator OnGameStart()
    {
        yield return StartCoroutine(VersionCheck());
        yield return null;
    }

    private IEnumerator VersionCheck()
    {
        string url = "https://github.com/async-amethyst/re-series-unit-manager/tree/master/gamefiles/coredata.json";
        using(UnityWebRequest www = UnityWebRequest.Get(url))
        {
            yield return www.SendWebRequest();
            if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError || www.result == UnityWebRequest.Result.DataProcessingError)
            {
                Debug.Log("An error occured while obtaining latest game version.");
                //Insert code here putting this error message in game, something like "Latest software data could not be obtained."
            }
            else
            {
                string savePath = Application.persistentDataPath + "/tempfiles/coredata.json";
                System.IO.File.WriteAllText(savePath, www.downloadHandler.text);
            }
        }
        //Blah blah code that can check the software version to check if an update is needed.
    }
}
