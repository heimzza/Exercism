using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string text, string splitText){
        var index = text.IndexOf(splitText);
        return text.Substring(index + splitText.Length);
    }

    public static string SubstringBetween(this string text, string splitText1,string splitText2){
        var index1 = text.IndexOf(splitText1);
        var index2 = text.IndexOf(splitText2);
        return text.Substring(index1 + splitText1.Length, index2 - (index1 + splitText1.Length));
    }
    
    public static string Message(this string text){
        return text.SubstringAfter("]: ");
    }

    public static string LogLevel(this string text){
        return text.SubstringBetween("[", "]");
    }
}