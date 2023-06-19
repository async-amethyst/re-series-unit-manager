using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class CustomUnitHandler
{
    public static Unit LoadUnitFromFile(string unitName)
    {
        var filesPath = Application.streamingAssetsPath + "/CustomUnits/" + unitName + ".json";
        Unit tempUnit = JsonUtility.FromJson<Unit>(filesPath);
        if(tempUnit != null) { return tempUnit;}
        else{
            return null;
        }
    }

    public static void SerializeUnitToFile(Unit unitInstance, string folderPrefix = "")
    {
        var filesPath = Application.streamingAssetsPath + "/CustomUnits/" + folderPrefix + unitInstance.Name + ".json";
        if(!File.Exists(filesPath)) {File.Create(filesPath);}
        string fileContent = JsonUtility.ToJson(unitInstance, true);
        File.WriteAllText(filesPath, fileContent);
    }
}
