using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{

    [Header("GameObjects")]

    [SerializeField] GameObject PlayAgainText;
    [SerializeField] GameObject PlayAgainButton;

    [SerializeField] GameObject Button1;
    [SerializeField] GameObject Button2;
    [SerializeField] GameObject Button3;
    [SerializeField] GameObject Button4;
    [SerializeField] GameObject Button5;
    [SerializeField] GameObject Button6;
    [SerializeField] GameObject Button7;
    [SerializeField] GameObject Button8;
    [SerializeField] GameObject Button9;

    [Header("Lists And Arrays")]

    List<GameObject> buttons = new List<GameObject>();

    [Header("Scripts")]

    EnemyAIScript enemyAIScript;

    void Start()
    {

        enemyAIScript = FindAnyObjectByType<EnemyAIScript>();
        
    }

    void Update()
    {

        buttons.Add(Button1);
        buttons.Add(Button2);
        buttons.Add(Button3);
        buttons.Add(Button4);
        buttons.Add(Button5);
        buttons.Add(Button6);
        buttons.Add(Button7);
        buttons.Add(Button8);
        buttons.Add(Button9);

    }

    public void OnButtonClick(GameObject button)
    {

        button.gameObject.transform.GetComponentInChildren<TextMeshProUGUI>().text = "X";
        button.GetComponent<Button>().interactable = false;

        StartCoroutine(enemyAIScript.StartAICountdown());

        // rows

        if (Button1.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button2.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button3.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }
        else if (Button4.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button6.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }
        else if (Button7.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button8.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button9.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }

        // columns

        if (Button1.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button4.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button7.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }
        else if (Button2.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button8.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }
        else if (Button3.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button6.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button9.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }

        // diagonals

        if (Button9.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button2.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }
        else if (Button3.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button7.GetComponentInChildren<TextMeshProUGUI>().text == "X")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The player has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            gameObject.SetActive(false);

        }
    }
}
