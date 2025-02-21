using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI fst;
    public TextMeshProUGUI wfst;
    int myscore = 0;
 

    // Update is called once per frame
    void Update()
    {
        scoretext.text = myscore.ToString();
        fst.text = "Score :-"+myscore.ToString();
        wfst.text = "Score :-"+myscore.ToString();

    }
    public void addscore(int score)
    {
        myscore = myscore + score;
    }
}
