using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SystemZapisywania
{
    public static void ZapisPostepu (UsuwanieWydzialu WBiB, UsuwanieWydzialu WBZ, UsuwanieWydzialu WG, UsuwanieWydzialu WH, UsuwanieWydzialu WMiI, UsuwanieWydzialu WMW, UsuwanieWydzialu WNE, UsuwanieWydzialu WNoZ, UsuwanieWydzialu WNT, UsuwanieWydzialu WPiA, UsuwanieWydzialu WRiL)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string sciezka = Application.persistentDataPath + "wydzial.xd";
        FileStream stream = new FileStream(sciezka, FileMode.Create);

        Progres data = new Progres(WBiB, WBZ, WG, WH, WMiI, WMW, WNE, WNoZ, WNT, WPiA, WRiL);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Progres WczytaniePostepu()
    {
        string sciezka = Application.persistentDataPath + "wydzial.xd";
        if(File.Exists(sciezka))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(sciezka, FileMode.Open);

            Progres data = formatter.Deserialize(stream) as Progres;
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
