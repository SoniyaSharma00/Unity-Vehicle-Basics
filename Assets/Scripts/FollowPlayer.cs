using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    /*public= unity editor batai control garna lai. 
      GameObject= premade class to indicate any of the game object we use in the project. yesma hamle refrence dina parxa unity editor bata.
     since hamle camera ley player lai follow garni banauni ho, hamle player game object use garem. aba unity ma pani refrence dina paryo*/

    private Vector3 offset = new Vector3(0, 6, -9);
    /* yesma offset vanni euta variable banako ho. variable ko name j pani rakhna milxa tara offset kina rakheko vanda,
     offset vaneko player ra camera ko bich ko distance ho. tesaile yei name relaible vayo.*/

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //
    //void Update(){
    /* update use garda  hamro player flikker vayo.
      kina? kina ki hamro camera ra player same time ma update vairakhexa. 
      testo huda suru ma player hidxa ani pheri camera hidxa pheri kaile  camera pahila hidxa pheri player hidna pani sakyo.
      kei kura fix vayena.(j ni huna sakyo)
      teslai fix garna ko lagi pahila player ko update huna paryo ani balla camera ko update huna paryo.*/
    
    void LateUpdate()//lateupdate ley pahila ko update vaisakesi balla update garxa. updates after our update method happens.
    {
        //transform.position = player.transform.position;
        /*yo line of code ley  camera ko position chai player ko position ma set gareko xa.
         transform.position vaneko camera ko position ani player.transform.position vaneko player ko position.*/


        //offset the camera behind the player by adding to the players position


        //transform.position = player.transform.position + (0, 6, -9);
        /* since hamle player lai Vector3 use gareko xam, directly coordinate matra rakhera error aauxa.
         tesaile hamle yesma pani vector 3 use garnu parxa.
        coordinate kina tyo vako vanda hamle unity ma camera set garda player lai dekhine gari set gareko xam.
        j coordinate teha use gareko xam hamle tei yeha pani rakhem so that camera follows player exactly like we want*/


        //transform.position = player.transform.position + new Vector3(0,6,-9);
        /* new chai kina use gareko vanda hamle player ma vector3 use garem.
          yeha pani vector3 use garna paryo tara naya vector3 use garna paryo.
        yedi new narakhni vane computer thinks ki hamle kunai method call garna khoji rako xam.
        new rakhem vane balla aee yesle chai naya storage khojeko raixa vector3 store garna lai vanera chinxa.
        that mean player lai use gareko Vector 3 chai euta seat ma gayera basxa/ euta storage linxa
        ani new vector3 ley arko naya seat ma gayera basxa / arko naya storage linxa.*/


        transform.position = player.transform.position + offset;
        /* maathi ko offset vanni variable yeha camera lai player ko paxadi hidauna laoi use gariyeo.*/



    }
}
