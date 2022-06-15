using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class dichuyen : MonoBehaviour
{

    public Animator ani;
    public bool isRight;
    public bool nen_dat;

    public GameObject gameOverButton;
    public GameObject gameOverText;

    public bool isPause = false;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            ani.SetBool("isRunning", true);

            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1F, 1F, 1F);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = true;
            ani.SetBool("isRunning", true);

            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1F, 1F, 1F);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (nen_dat == true)
            {
                
            

                if (isRight == true)
                {
                    transform.Translate(Time.deltaTime * 5, 2.5f, 0);
                }
                else
                {
                    transform.Translate(-Time.deltaTime * 5, 2.5f, 0);
                }
                nen_dat = false;
            }
        }

        if(Input.GetKey(KeyCode.P))
        {
            isPause = !isPause;
            if (isPause)
            {
                Time.timeScale = 0;

            }
            else
            {
                Time.timeScale = 1;

            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nen_dat")
        {
            nen_dat = true;
        }

        if (collision.gameObject.tag == "qua_man")
        {
            SceneManager.LoadScene("Man1");
        }

        if (collision.gameObject.tag == "qua_man1")
        {
            SceneManager.LoadScene("Start");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "roi_xuong")
        {
            gameOverButton.SetActive(true);//khi chết button replay hiện ra
            gameOverText.SetActive(true);//khi chết text game over  hiện ra
            Time.timeScale = 0;// timescale = 0 ,trò chơi dừng =1 trò chơi chạy lại
        }
    }
}
