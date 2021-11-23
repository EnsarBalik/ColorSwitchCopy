using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Circle : MonoBehaviour
{
    public GameObject WinScene;
    public GameObject YouLose;
    public GameObject TapToStart;
    public float JumpForce = 10f;
    public Rigidbody2D rb;
    public string currentColor;
    public SpriteRenderer sr;
    public Color colorCyan;
    public Color colorRed;
    public Color colorPurple;
    public Color colorYellow;

    void Start()
    {
        rb.gravityScale = 0;
        TapToStart.SetActive(true);
        Time.timeScale = 1f;
        SetRandomColor();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * JumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "faller")
        {
            Time.timeScale = 0.5f;
            YouLose.SetActive(true);
        }
        if (col.tag == "Change")
        {
            SetRandomColorv2();
            Destroy(col.gameObject);
            return;
        }
        if (col.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(col.gameObject);
            return;
        }
        if (col.tag != currentColor)
        {
            YouLose.SetActive(true);
            Debug.Log("Game Over");
        }
        if (col.tag == "Finish")
        {
            YouLose.SetActive(false);
            WinScene.SetActive(true);
            rb.gravityScale = 0.1f;
        }
    }

    //RandomColor
    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                currentColor = "cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Red";
                sr.color = colorRed;
                break;
            case 3:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
        }
    }
    void SetRandomColorv2()
    {
        int index = Random.Range(0, 3);

        switch (index)
        {
            case 0:
                currentColor = "cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Red";
                sr.color = colorRed;
                break;
        }
    }

    public void gelenbtn(int gelenbtnn)
    {
        if (gelenbtnn == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (gelenbtnn == 2)
        {
            rb.gravityScale = 4.7f;
            TapToStart.SetActive(false);
        }
    }
}
