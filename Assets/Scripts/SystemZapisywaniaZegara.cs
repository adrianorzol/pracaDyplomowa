using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SystemZapisywaniaZegara 
{
    public static void ZapisPostepu(Zegar WBiB, Zegar WBZ, Zegar WG, Zegar WH, Zegar WMiI, Zegar WMW, Zegar WNE, Zegar WNoZ, Zegar WNT, Zegar WPiA, Zegar WRiL)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string sciezka = Application.persistentDataPath + "zegar.xd";
        FileStream stream = new FileStream(sciezka, FileMode.Create);

        ProgresZegara data = new ProgresZegara(WBiB, WBZ, WG, WH, WMiI, WMW, WNE, WNoZ, WNT, WPiA, WRiL);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ProgresZegara WczytaniePostepu()
    {
        string sciezka = Application.persistentDataPath + "zegar.xd";
        if (File.Exists(sciezka))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(sciezka, FileMode.Open);

            ProgresZegara data = formatter.Deserialize(stream) as ProgresZegara;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("Nie znaleziono pliku");
            return null;
        }
    }
}
