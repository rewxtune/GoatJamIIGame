using UnityEngine;

public class DrillZone : MonoBehaviour
{
    public bool hasBeenDug = false;
    public bool hasWater = false;

    private void Start()
    {
        // %30 ihtimalle su var
        hasWater = Random.value < 0.3f;
    }

    public bool Dig()
    {
        if (hasBeenDug)
            return false;

        hasBeenDug = true;
        return hasWater;
    }
}
