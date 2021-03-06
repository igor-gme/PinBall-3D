using UnityEngine;

public class CollisionHelper
{
    public static bool DidCollideWithSphere(Collision collision)
    {
        if(collision.gameObject.tag == Constants.SPHERE_TAG) return true;
        else return false;
    }

    public static bool DidCollideWithSphere(string tag)
    {
        if(tag == Constants.SPHERE_TAG) return true;
        else return false;
    }

    public static bool DidCollideWith2DSpere(string tag)
    {
        if(tag == Constants.BALL_2D_TAG)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}