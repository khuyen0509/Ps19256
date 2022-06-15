using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class kill_monter : MonoBehaviour
{
    public GameObject PsCoin;
    public static int diemTong = 0;
    public GameObject diemtext;

    public GameObject gameOverButton;
    public GameObject gameOverText;

    public AudioSource sound_death;
    public AudioSource sound_main;
    public AudioSource sound_die;
    // Start is called before the first frame update
    void Start()
    {
        CongDiem(0);
        sound_main.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CongDiem(int diemCong)
    {
        diemTong += diemCong;
        diemtext.GetComponent<Text>().text = "Điểm : " + diemTong.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name_monter = collision.attachedRigidbody.gameObject.name;
        if (collision.gameObject.tag == "ben_trai")
        {
            //sound_main.Stop();
            //Play();
            sound_main.Stop();
            sound_death.Play();
            Destroy(GameObject.Find("nhan_vat"));//nhan vat dung nam chet
            gameOverButton.SetActive(true);//khi chết button replay hiện ra
            gameOverText.SetActive(true);//khi chết text game over  hiện ra
            Time.timeScale = 0;// timescale = 0 ,trò chơi dừng =1 trò chơi chạy lại
        }
        if (collision.gameObject.tag == "ben_tren")
        {
            CongDiem(1);
            sound_die.Play();
            Destroy(GameObject.Find(name_monter));
            Instantiate(PsCoin, collision.gameObject.transform.position, collision.gameObject.transform.localRotation);
        }

        if (collision.gameObject.tag == "roi_xuong")
        {
            
            Destroy(GameObject.Find("nhan_vat"));
            sound_death.Play();
            sound_main.Stop();
            gameOverButton.SetActive(true);//khi chết button replay hiện ra
            gameOverText.SetActive(true);//khi chết text game over  hiện ra
            Time.timeScale = 0;// timescale = 0 ,trò chơi dừng =1 trò chơi chạy lại
        }


    }
}
