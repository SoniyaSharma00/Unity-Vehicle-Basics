using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private float speed = 5.0f;
    /*private vanni chai access ho.
      private rakhepaxi yo variable (speed) yo class (PlayerContoroller) ma matra use garna milxa.*/
    /* yesle speed lai assign garxa. yo variable ho,
     speed vanni variable ley jailai 5 carry garxa ani yo value hamle code ma  jaha pani rakhna milxa
    speed ko value cnahge gardini vane code ma kaha kaha variable use vaxa teha teha sabai ma tesko value change hunxa*/

    //public float speed = 5.0f;
    /* public garepaxi jata tetai use garna milne vayo.
      since hamlai speed vanni variable publicly, direct manage garnu xa. yeslai public banayem. tespaxi yo unity editor batai manage garna milxa
    unity editor ma speed vanni component aauxa ani tesko value jati set garyo yeta code ma pani tetti nai aayera basxa.
    5 chai initialize garna ko lagi rakheko ho.*/

    //public float turnSpeed;
    /* turnspeed vanni arko variable banam, unity bata control garna lai. 
      so that we can control the speed of player when it moves left,right,back.*/

    //public float horizontalInput;
    /*left ra right hidni banauna lako ho tesaile relevent word use garera variable banayem*/

    //public float forwardInput;
    /* forward ra backward hidni banauna lai naya forwardInput vanni variable use gareko ho*/


    private float speed = 5.0f;
    private float turnSpeed =25.0f;
    private float horizontalInput;
    private float forwardInput;
    /* code clean gareko ho . 
     * sabbai already set vaisakyo tesaile uta code clean garna ko lagi hamle public lai private gardiyem.*/


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // game suru vayesi yo method call hunxa. ek choti matra call hunxa. suru huda bettekai
    }

    // Update is called once per frame
    void Update()
    {
        // yo method game run huni bela samma call vairakhxa. every frame ma.
        //we'll move the vechile forward.

        //transform.Translate(0, 0, 1);
        /*yeha '.' ley method bolauni ho.Translate vanni unity ley banako method ho.
         transform component lai change garna khojeko ,Translate vanni method use garera, Z axis ma move huni banako ho.*/

        //transform.Translate(Vector3.forward);
        /*yesma vector use garera nai forward move huni banako ho.
          Vector3 vaneko euta data structure ho jasle vector number hold garxa.
          Learn Vector for more clear idea.*/

        // transform.Translate(Vector3.forward * Time.deltaTime * 15);
        /* 'Time' vanni premade class made by unity to keep track of time.
          'deltaTime' vanni method ho to get the time change between all of our different frames.we can control how much time is actually passing.
        15 ley multiply garepaxi hamro player chai 15 meters per second ma hidxa.
        Z axis ma matra multiply garexam kina vane hamle Z axis ma matra move garauna khojya ho tara 
        yesma forward vector use gareko vayera axis ko chinta garnu parena*/

        horizontalInput = Input.GetAxis("Horizontal");
        /* mathi introduce gareko horizontalInput vanni variable lai yeha assign gareko ho.
         assign chai unity ko input manager ko horizontal vanni thau gareko ho.
        yeha Input vanni methos ho ani GetAxis vanni class ho.
        GetAxis ley hamro unity editor ma input manager ma vako chij haru ko details dinxa.
        input manager ko kun thaau ko details lini tani vanda "Horizontal" vanni thaau ko details lini.
        aba hamle left ,right, A,D use garera player lai move garauna milxa.*/

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        /*yesle right tira move huni banako ho. ".right" use garera.
         ani yeta uta hidauna ko lagi horizontalInput vanni variable use gareko ho.*/

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); //rotates the car based on horizontal input.
        /*translate ley slide garyo aba hamle player lai rotate gardai move huni banauna paryo. so we used Rotate method.
         vector3 .up vaneko chai vector3 lai kun axis ma move garauni vanya ho. hamro game ma player lai y axis tira rotate garaunu parne xa. 
        Vector3.up (The Y-Axis) ----> this is the right option.
        Vector3.right (The X-Axis)
        Vector3.forward (The Z-Axis)*/



        forwardInput = Input.GetAxis("Vertical");
        /* yeha forwardInput vanni variable lai unity ko input manager ko Vertical vanni thaau gareko ho.*/


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);//moves the car forward based on vertical Input.
        /* yesma 15 ko satta speed vanni variable use garem . yesko value aba 5 huni vayo.
         * speed ko value maathi change garepaxi yeha pani change hunxa.
         forwardInput ley agadi paxadi jani key control garxa. aba hamle s,w,up,down key use garera agadi paxadi move garauna milxa*/



      





    }
}
