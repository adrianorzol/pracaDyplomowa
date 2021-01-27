using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zapisywanie : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnApplicationQuit()
    {

        SystemZapisywania.ZapisPostepu(GameObject.Find("WBiB").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WBZ").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WG").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WH").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WMiI").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WMW").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WNE").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WNoZ").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WNT").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WPiA").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WRiL").GetComponent<UsuwanieWydzialu>());
        SystemZapisywaniaZegara.ZapisPostepu(GameObject.Find("ZegarWBiB").GetComponent<Zegar>(), GameObject.Find("ZegarWBZ").GetComponent<Zegar>(), GameObject.Find("ZegarWG").GetComponent<Zegar>(), GameObject.Find("ZegarWH").GetComponent<Zegar>(), GameObject.Find("ZegarWMiI").GetComponent<Zegar>(), GameObject.Find("ZegarWMW").GetComponent<Zegar>(), GameObject.Find("ZegarWNE").GetComponent<Zegar>(), GameObject.Find("ZegarWNoZ").GetComponent<Zegar>(), GameObject.Find("ZegarWNT").GetComponent<Zegar>(), GameObject.Find("ZegarWPiA").GetComponent<Zegar>(), GameObject.Find("ZegarWRiL").GetComponent<Zegar>());
        SystemZapisywaniaUstawien.ZapisPostepu(GameObject.Find("Zamykanie").GetComponent<ZamykanieAplikacji>());
    }
    private void OnApplicationPause(bool pause)
    {
        SystemZapisywania.ZapisPostepu(GameObject.Find("WBiB").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WBZ").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WG").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WH").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WMiI").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WMW").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WNE").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WNoZ").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WNT").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WPiA").GetComponent<UsuwanieWydzialu>(), GameObject.Find("WRiL").GetComponent<UsuwanieWydzialu>());
        SystemZapisywaniaZegara.ZapisPostepu(GameObject.Find("ZegarWBiB").GetComponent<Zegar>(), GameObject.Find("ZegarWBZ").GetComponent<Zegar>(), GameObject.Find("ZegarWG").GetComponent<Zegar>(), GameObject.Find("ZegarWH").GetComponent<Zegar>(), GameObject.Find("ZegarWMiI").GetComponent<Zegar>(), GameObject.Find("ZegarWMW").GetComponent<Zegar>(), GameObject.Find("ZegarWNE").GetComponent<Zegar>(), GameObject.Find("ZegarWNoZ").GetComponent<Zegar>(), GameObject.Find("ZegarWNT").GetComponent<Zegar>(), GameObject.Find("ZegarWPiA").GetComponent<Zegar>(), GameObject.Find("ZegarWRiL").GetComponent<Zegar>());
        SystemZapisywaniaUstawien.ZapisPostepu(GameObject.Find("Zamykanie").GetComponent<ZamykanieAplikacji>());
    }
}
