using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableObject : GrabbableObject
{
    public float shootforce;

    private Grabber tempHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnHoverStart()
    {
        //base.OnHoverStart();


    }

    public override void OnHoverEnd()
    {
        //base.OnHoverEnd();
    }

    public override void OnGrabStart(Grabber hand)
    {
        base.OnGrabStart(hand);
        tempHand = hand;
    }

    public override void OnGrabEnd()
    {
        base.OnGrabEnd();
        GetComponent<Rigidbody>().AddForce(tempHand.transform.forward * shootforce);
        tempHand = null;


    }

}
