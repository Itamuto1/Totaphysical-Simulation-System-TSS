using UnityEngine;
using System.IO;

public class LogSystem : MonoBehaviour
{
    public string logFileName = "TotaphysicalLog.txt";
    private string logPath;

    void Start()
    {
        logPath = Path.Combine(Application.persistentDataPath, logFileName);
        LogMessage("📘 Totaphysical Simulation Started\n");
    }

    public void LogMessage(string message)
    {
        string fullMessage = System.DateTime.Now.ToString("HH:mm:ss") + " >> " + message + "\n";
        File.AppendAllText(logPath, fullMessage);
        Debug.Log("📝 Logged: " + message);
    }

    public void LogRealmStatus(Realm realm)
    {
        string logEntry = $"Realm: {realm.realmName}, Gotomai: {realm.gotomaiLevel}, " +
                          $"Imoumi: {realm.imoumikapoFlow}, Kaboo: {realm.kabooStability}, " +
                          $"Instability: {realm.CalculateInstability():F2}";
        LogMessage(logEntry);
    }
}
