using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textCompnent;
    public string[] lines;
    public float textSpeed;

    private int index;


    // Start is called before the first frame update
    void Start()
    {
        textCompnent.text = string.Empty;
        StartDialogue();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textCompnent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textCompnent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textCompnent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textCompnent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            gameObject.SetActive(false);


        }
    }



}
