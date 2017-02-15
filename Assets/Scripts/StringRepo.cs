using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class StringRepo : MonoBehaviour
{
    [SerializeField] private List<string> m_selves;
    [SerializeField] private List<string> m_things;
    [SerializeField] private List<string> m_opinions;

    void Start()
    {
        // selves
        m_selves.Add(" enligt marconi");
        m_selves.Add(" tycker markönigsegg");
        m_selves.Add(" /marköning");
        m_selves.Add(" /makusamaschonopp");
        m_selves.Add(" ");
        m_selves.Add(", musikfamilj givetvis");
        m_selves.Add(" "); // tomma är okej här, men i andra?
        m_selves.Add(", så göm era döttrar");
        m_selves.Add("... som en cadillac-snigel");
        m_selves.Add(". Men vi är ju bara apor på en snurrande skiva");
        m_selves.Add(". har vi nån mer gato eller?");


        // things
        m_things.Add(" svensk politik under Palme");
        m_things.Add(" att vara från en musikfamilj");
        m_things.Add(" radiohead, ändå, ");
        m_things.Add(" frölunda");
        m_things.Add(" damer, bärs, fälgar, ");
        m_things.Add(" semantik");
        m_things.Add(" jontes gymmliv");
        m_things.Add(" naturligt bredaxlad");
        m_things.Add(" danska rikskapitalister");
        m_things.Add(" feminism");
        m_things.Add(" modern konst");
        m_things.Add(" Håkan Obbels gymliv");
        



        // opinions
        m_opinions.Add(" är ju fan ännu farligare än MMA");
        m_opinions.Add(" är inget annat än fitter");
        m_opinions.Add(" är inget för markenius värja");
        m_opinions.Add(", vidrig");
        m_opinions.Add(", är dålig.");
        m_opinions.Add(". borderline Håkan..");
        m_opinions.Add(" är fan helt jävla vildmark");
        m_opinions.Add(" är nonsens");
        m_opinions.Add(" men jag är ju feminist");
        m_opinions.Add(" är ju anala tider helt enkelt. ");
        m_opinions.Add(", är det inte dags för rankat? ");
        m_opinions.Add(". Hey guys, its me again");



    }

    public string[] GetSelves()
    {
        return m_selves.ToArray();
    }

    public string[] GetThings()
    {
        return m_things.ToArray();
    }

    public string[] GetOpinions()
    {
        return m_opinions.ToArray();
    }


    public string GetRandomSelf()
    {
        return m_selves[Random.Range(0, m_selves.Count)];
    }

    public string GetRandomThing()
    {
        return m_things[Random.Range(0, m_things.Count)];
    }

    public string GetRandomOpinion()
    {
        return m_opinions[Random.Range(0, m_opinions.Count)];
    }
}