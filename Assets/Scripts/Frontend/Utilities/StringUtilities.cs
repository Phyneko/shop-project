using UnityEngine;

public static class StringUtilities 
{
    public static string Bold(this string text)
    {
        return $"<b>{text}</b>";
    }

    public static string Italic(this string text)
    {
        return $"<i>{text}</i>";
    }

    public static string Underline(this string text)
    {
        return $"<u>{text}</u>";
    }

    public static string Colored(this string text, Color color)
    {
        return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{text}</color>";
    }
}
