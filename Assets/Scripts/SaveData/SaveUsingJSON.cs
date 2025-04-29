using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class SaveUsingJSON : MonoBehaviour
{
    // Vars
    [SerializeField] private string nameOfFile = "N/A";
    private string defaultFileText = "N/A";

    [Header("Object 1"), SerializeField] private JSONSavableObject o1;
    [Header("Object 3"), SerializeField] private JSONSavableObject o2;
    [Header("Object 2"), SerializeField] private JSONSavableObject o3;


    // Methods
    public string ReadJsonFile(string aPath)
    {
        StreamReader streamReader = null;
        string jsonTxt = null;

        if (File.Exists(Application.persistentDataPath + aPath))
        {
            streamReader = new StreamReader(Application.persistentDataPath + aPath);
            jsonTxt = streamReader.ReadToEnd();
            streamReader.Close();
            //Debug.Log(Application.persistentDataPath + aPath);
            return jsonTxt;

        }

        else
        {
            WriteJsonFile(aPath, defaultFileText);

            streamReader = new StreamReader(Application.persistentDataPath + aPath);
            jsonTxt = streamReader.ReadToEnd();
            streamReader.Close();
            Debug.Log(Application.persistentDataPath + aPath);
            return jsonTxt;
        }

    }
    public void WriteJsonFile(string aPath, string anObjStr)
    {
        StreamWriter streamWriter = new StreamWriter(Application.persistentDataPath + aPath);
        streamWriter.Write(anObjStr);
        streamWriter.Close();
        //Debug.Log(Application.persistentDataPath + aPath);
    }

    public void WriteTest()
    {
        JSONSavedObjects JSOs = new JSONSavedObjects();
        JSOs.jsonSavedObjectsARR = new List<JSONSavableObject>(){o1,o2,o3 }.ToArray();
        string jsoSrt = JsonUtility.ToJson(JSOs);

        Debug.Log(jsoSrt);
        WriteJsonFile(nameOfFile, jsoSrt);
    }
}
