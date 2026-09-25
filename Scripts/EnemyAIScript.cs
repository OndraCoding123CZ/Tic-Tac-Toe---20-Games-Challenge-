using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAIScript : MonoBehaviour
{

    [Header("Lists and Arrays")]

    GameObject[] buttons1 = new GameObject[9];
    List<GameObject> buttons2 = new List<GameObject>();

    [Header("Variables")]

    int randomIndex;
    GameObject chosenButton;

    [Header("GameObjects")]

    [SerializeField] GameObject Panel;

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

    void Start()
    {

        buttons1[0] = Button1;
        buttons1[1] = Button2;
        buttons1[2] = Button3;
        buttons1[3] = Button4;
        buttons1[4] = Button5;
        buttons1[5] = Button6;
        buttons1[6] = Button7;
        buttons1[7] = Button8;
        buttons1[8] = Button9;

    }

    void Update()
    {

        buttons2.Add(Button1);
        buttons2.Add(Button2);
        buttons2.Add(Button3);
        buttons2.Add(Button4);
        buttons2.Add(Button5);
        buttons2.Add(Button6);
        buttons2.Add(Button7);
        buttons2.Add(Button8);
        buttons2.Add(Button9);

    }

    public IEnumerator EnemyAI()
    {

        for (int i = 0; i < 9; i++)
        {

            randomIndex = UnityEngine.Random.Range(0, buttons1.Length);
            chosenButton = buttons1[randomIndex];

            if (chosenButton != null && chosenButton.transform.GetComponentInChildren<TextMeshProUGUI>().text != "X" && chosenButton.transform.GetComponentInChildren<TextMeshProUGUI>().text != "O")
            {

                chosenButton.transform.GetComponentInChildren<TextMeshProUGUI>().text = "O";
                chosenButton.GetComponent<Button>().interactable = false;

                break;

            }
        }

        // rows

        if (Button1.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button2.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button3.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }
        else if (Button4.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button6.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }
        else if (Button7.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button8.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button9.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }

        // columns

        if (Button1.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button4.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button7.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }
        else if (Button2.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button8.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }
        else if (Button3.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button6.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button9.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }

        // diagonals

        if (Button7.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button3.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }
        else if (Button3.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button7.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            PlayAgainButton.SetActive(true);
            PlayAgainText.SetActive(true);

            PlayAgainText.GetComponent<TextMeshProUGUI>().text = "The enemy has won!";
            PlayAgainButton.GetComponentInChildren<TextMeshProUGUI>().text = "PLAY AGAIN";
            PlayAgainText.transform.position = new Vector2(600, 350);

            foreach (GameObject obj in buttons2)
            {

                obj.GetComponentInChildren<TextMeshProUGUI>().text = "";
                obj.GetComponent<Button>().interactable = true;

            }

            Panel.SetActive(false);

        }

        if (Button1.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button2.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button3.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button4.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button6.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button7.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button8.GetComponentInChildren<TextMeshProUGUI>().text == "X" && Button9.GetComponentInChildren<TextMeshProUGUI>().text == "X" || Button1.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button2.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button3.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button4.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button5.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button6.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button7.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button8.GetComponentInChildren<TextMeshProUGUI>().text == "O" && Button9.GetComponentInChildren<TextMeshProUGUI>().text == "O")
        {

            Debug.Log("The result is a draw!");

        }

        yield return new WaitForSeconds(0.1f);

        buttons1[randomIndex] = null;

    }

    public IEnumerator StartAICountdown()
    {

        yield return new WaitForSeconds(2f);

        StartCoroutine(EnemyAI());

    }
}
