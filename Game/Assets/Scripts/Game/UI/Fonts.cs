using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonts
{   
    private static Font font_GameCubeCartoon_Regular;
    //private static Font font24;
    //private static Font font30;
    //private static Font font42;

    public static Font GameCubeCartoon_Regular()
    {
        if (font_GameCubeCartoon_Regular == null)
            font_GameCubeCartoon_Regular = Resources.Load<Font>("Fonts/GameCubeCartoon_Regular");
        return font_GameCubeCartoon_Regular;
    }

    //public static Font GetFont24()
    //{
    //    if (font24 == null)
    //        font24 = Resources.Load<Font>("Fonts/font24");
    //    return font24;
    //}

    //public static Font GetFont30()
    //{
    //    if (font30 == null)
    //        font30 = Resources.Load<Font>("Fonts/font30");
    //    return font30;
    //}

    //public static Font GetFont42()
    //{
    //    if (font42 == null)
    //        font42 = Resources.Load<Font>("Fonts/font42");
    //    return font42;
    //}
}
