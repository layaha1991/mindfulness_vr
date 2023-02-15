using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowManager : MonoBehaviour
{
#region Singleton
    private static flowManager _instance;
    public static flowManager Instance
    {
        get
        {
            if(_instance is null)
            {
                Debug.LogError("flowManager is NULL");

               
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    #endregion

    // Scene

    public GameObject[] scene;

    
    //heart
    public GameObject[] heart;


    //PE
    public GameObject[] particleEffect;


    //for checking
    public bool isHeart0InEffectDone;
    public bool isHeart1InEffectDone;
    public bool isHeart2InEffectDone;

    public bool isHeart12DoneSpawn;


    public bool isfirework1Done;
    public bool isfirework2Done;

    // Animation
    public Animator[] animators;



    private void Start()
    {
        for (int i=0;i<heart.Length;i++)
        {
            heart[i].SetActive(false);
        }
        for (int i =0; i<scene.Length;i++)
        {
            scene[i].SetActive(false);
        }
        for(int i=0; i<particleEffect.Length; i++)
        {
            particleEffect[i].SetActive(false);
        }


        StartCoroutine(Flow());
    }

    IEnumerator Flow()
    {

        //Scene 0

        yield return new WaitForSeconds(3);
        scene[0].SetActive(true);
        particleEffect[0].SetActive(true);
        yield return new WaitForSeconds(3);
        particleEffect[0].transform.position = new Vector3(999, 999, 999);
        yield return new WaitForSeconds(3);
        particleEffect[0].SetActive(false);

        particleEffect[1].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        particleEffect[2].SetActive(true);

        while (isfirework1Done == false || isfirework2Done == false)
        {
            yield return new WaitForSeconds(0.2f);
        }
        yield return new WaitForSeconds(5f);
        particleEffect[1].transform.position = new Vector3(99, 99, 99);
        particleEffect[2].transform.position = new Vector3(99, 99, 99);
        yield return new WaitForSeconds(3f);
        particleEffect[1].SetActive(false);
        particleEffect[2].SetActive(false);


        //Scene 1
        scene[1].SetActive(true);
        heart[0].SetActive(true);
        animators[0].Play("Heart_0_ani_start");


        while (isHeart0InEffectDone == false )
        {
            yield return new WaitForSeconds(0.2f);
        }

        heart[1].SetActive(true);
        heart[2].SetActive(true);
        while (isHeart1InEffectDone == false || isHeart2InEffectDone == false)
        {
            yield return new WaitForSeconds(0.2f);
        }

        yield return new WaitForSeconds(1f);


        particleEffect[3].SetActive(true);
        particleEffect[4].SetActive(true);

        yield return new WaitForSeconds(3f);

        animators[0].Play("Heart_0_ani_enlarge");

        while (isHeart12DoneSpawn == false)
        {
            yield return new WaitForSeconds(0.2f);
        }

        particleEffect[3].SetActive(false);
        particleEffect[4].SetActive(false);

        yield return new WaitForSeconds(1f);
        animators[1].Play("Heart_1_ani_fade");
        animators[2].Play("Heart_2_ani_fade");

        yield return new WaitForSeconds(5f);
        heart[3].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        heart[4].SetActive(true);
        yield return new WaitForSeconds(0.7f);
        heart[5].SetActive(true);
        yield return new WaitForSeconds(0.9f);
        heart[6].SetActive(true);

        yield return new WaitForSeconds(2f);
        particleEffect[5].SetActive(true);
        yield return new WaitForSeconds(0.4f);
        particleEffect[6].SetActive(true);
        yield return new WaitForSeconds(0.5f);
        particleEffect[7].SetActive(true);
        yield return new WaitForSeconds(0.1f);
        particleEffect[8].SetActive(true);



    }



    
}
