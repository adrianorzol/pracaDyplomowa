using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SystemZapisywaniaUstawien
{
    public static void ZapisPostepu(ZamykanieAplikacji ustawienia)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string sciezka = Application.persistentDataPath + "ustawienia.xd";
        FileStream stream = new FileStream(sciezka, FileMode.Create);

        ProgresUstawien data = new ProgresUstawien(ustawienia);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ProgresUstawien WczytaniePostepu()
    {
        string sciezka = Application.persistentDataPath + "ustawienia.xd";
        if (File.Exists(sciezka))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(sciezka, FileMode.Open);

            ProgresUstawien data = formatter.Deserialize(stream) as ProgresUstawien;
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
