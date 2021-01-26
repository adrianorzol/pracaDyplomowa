using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class licznikOcen : MonoBehaviour
{
    public Button przycisk;
    public Sprite sprite_1;
    public Sprite sprite_2;
    public Sprite sprite_3;
    public int licznik = 0;
    public Animator animacja;
    public Animator zlapanie;
    public bool czyZlapany = false;
    public AudioSource udany;
    public AudioSource nieudany;
    
    // Start is called before the first frame update
    void Start()
    {
        
        

        przycisk.onClick.AddListener(Klik);
    }
    
    // Update is called once per frame
    void Klik()
    {
        StartCoroutine(Rzucanie());
        
        
    }
    IEnumerator Rzucanie()
    {
        animacja.SetTrigger("Rzut");
        yield return new WaitForSeconds(1f);
        

        if (GetComponent<lapanie>().czyZlapany == false)
        {
            switch (licznik)
            {
                case 0:
                    
                    animacja.SetTrigger("Powrot");
                    GetComponent<Image>().sprite = sprite_1;
                    licznik++;
                    break;
                case 1:
                   
                    animacja.SetTrigger("Powrot");
                    GetComponent<Image>().sprite = sprite_2;
                    licznik++;
                    break;
                case 2:
                    
                    animacja.SetTrigger("Powrot");
                    GetComponent<Image>().sprite = sprite_3;
                    licznik++;
                    zlapanie.SetTrigger("Ucieczka");
                    yield return new WaitForSeconds(1.5f);
                    animacja.SetTrigger("Powrot");
                    if (GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name))
                        GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name).transform.position = new Vector3(1000f, 1000f, 1000f);
                    GameObject.Find("NieudaneZlapanie").GetComponent<CanvasGroup>().alpha = 1;
                    Destroy(GameObject.Find("Muzyka"));
                    if (GameObject.Find("Muzyka").GetComponent<AudioSource>().mute == false)
                        nieudany.Play();
                    yield return new WaitForSeconds(3f);
                    GameObject.Find("Zegar" + SceneManager.GetActiveScene().name).GetComponent<Zegar>().timerIsRunning = true;

                    SceneManager.LoadScene(sceneName: "main");
                    break;
            }


        }
        else
        {
            czyZlapany = true;
            zlapanie.SetTrigger("Zlapanie");
            
            yield return new WaitForSeconds(0.5f);
            animacja.SetTrigger("Powrot");
            if (GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name))
                GameObject.FindGameObjectWithTag(SceneManager.GetActiveScene().name).transform.position = new Vector3(0f, 0f, 0f);
            Destroy(GameObject.Find("Zegar" + SceneManager.GetActiveScene().name));
            Destroy(GameObject.Find("Muzyka"));
            if(GameObject.Find("Muzyka").GetComponent<AudioSource>().mute == false)
                udany.Play();
            GameObject.Find("UdaneZlapanie").GetComponent<CanvasGroup>().alpha = 1;
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(sceneName: "main");


        }
    }
}
