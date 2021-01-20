using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class licznikOcen : MonoBehaviour
{
    public Button przycisk;
    public Sprite sprite_1;
    public Sprite sprite_2;
    public Sprite sprite_3;
    public int licznik = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        

        przycisk.onClick.AddListener(Klik);
    }
    
    // Update is called once per frame
    void Klik()
    {

        if (GetComponent<lapanie>().czyZlapany == false)
        {
            switch(licznik)
            {
                case 0:
                    GetComponent<Image>().sprite = sprite_1;
                    licznik++;
                    break;
                case 1:
                    GetComponent<Image>().sprite = sprite_2;
                    licznik++;
                    break;
                case 2:
                    GetComponent<Image>().sprite = sprite_3;
                    licznik++;
                    if(GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name))
                        GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name).transform.position = new Vector3(1000f, 1000f, 1000f);
                    GameObject.Find("Zegar" + SceneManager.GetActiveScene().name).GetComponent<Zegar>().timerIsRunning = true;

                    SceneManager.LoadScene(sceneName: "main");
                    break;
            }
            
            
        }
        else
        {
            if (GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name))
                GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name).transform.position = new Vector3(0f, 0f, 0f);
            Destroy(GameObject.Find("Zegar" + SceneManager.GetActiveScene().name));
            SceneManager.LoadScene(sceneName: "main");


        }
            
    }

}
