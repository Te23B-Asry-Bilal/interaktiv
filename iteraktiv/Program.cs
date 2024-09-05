Console.WriteLine("Du står hemma och du har dåliga betyg och din vän ringer dig och vill spela vad väljer du att göra? plugga eller spela");
{
    String val1 = Console.ReadLine();

    if (val1.ToLower() == "plugga")
    {
    Console.WriteLine("Du du sätter dig och pluggar och du börjar känna dig hungrig vad gör du? gå till köket eller fortsätt plugga");
    }
    else if (val1.ToLower() == "spela")
    {
      Console.WriteLine("du sätter dig vid datorn och börjar spela med dina vänner efter några timmar så har det blivit mörkt och ni har tröttnat och din vän föreslår att ni går ut vad gör du? gå ut eller gå till sängen");
    }
}
{
    String val2 = Console.ReadLine();
    if (val2.ToLower() == "gå till köket")
    {
        Console.WriteLine("du går till köket och öppnar kylskåpet och du ser två maträtter den ena är hamburgare och den andra är kebab vilken väljer du? hamburgare eller kebab");
    }
    else if (val2.ToLower() == "fortsätt plugga")
    {
        Console.WriteLine("du väljer att fortsätta plugga och du blir bättre på alla ämnen och går till sängen trött. efter en bra sömn så vaknar du sjuk och kan inte bestämma dig att gå till vad gör du? gå till skolan eller stanna hemma");
    }
}
{



    String vall2 = Console.ReadLine();
    
    if (vall2.ToLower() == "gå ut")
    {
        Console.WriteLine("du och din vän kan inte komma överäns om en mötes plats din vän föreslår att träffas vid en skog medans du föreslår att träffas vid centrum vad väljer du? skog eller centrum");
    }
}
{


    String vall3 = Console.ReadLine();
     if (vall3.ToLower() == "skog")
    {
        Console.WriteLine("du väljer att lyssna på din vän och ni bestämmer er för att träffas vid skogen men sen så tänker du efter och märker att din vän lät lite nervös och så tänker du tillbaks på vad du har gjort mot din vän och kommer på att du dissade hans familj och han tog åt sig jätte mycket så du börjar tänka på att du har en pistol hemma ska du lämna pistolen eller ta med dig? ta med eller lämna");
    }
    else if (vall3.ToLower() == "centrum")
    {
        Console.WriteLine("du klär på dig dina kläder och rör dig mot centrum när du kommer fram till centrum så ser du inga personer och det dröjer 1 timme tills du ser en makerad man hålla handen i fickan som rör sig snabbt mot dig vad gör du? spring eller stanna kvar");
    }
}
{

    String skola = Console.ReadLine();

    if (skola.ToLower() == "stanna hemma")
    {
        Console.WriteLine("du stannar hemma och blir ut skickad ur skolan och dina föräldrar blir arga på dig och du blir ut skickad ur huset och blir hemlös och dör av monkey pox. GAME OVER!! du dog av monkey pox!!");
    }

    else if (skola.ToLower() == "gå till skolan")
    {
        Console.WriteLine("du går till skolan och du har pluggat så mycket så du kan allt och du blir en miljonär!!! GRATTIS DU KLARA AV SPELET!!!!!!!");
    }
}
{
    String mat = Console.ReadLine();

    if (mat.ToLower() == "hamburgare")
    {
        Console.WriteLine("Du tar hamburgaren och njuter av den och börjar känna dig väldigt sjuk men du skiter i det och lägger dig. GAME OVER!!! du dog");
    }
    else if (mat.ToLower() == "kebab")
    {
        Console.WriteLine("Du tar kebaben och börjar sluka i dig den och du känner dig mätt och belåten och du väljer att gå och lägga dig och när du vakna så har du blivit 1000 gånger smartare och du blir bäst i hela skolan och till slut blir du ingegör. GRATTIS DU KLARA SPELET!!!!");
    }
}
{


    String vall3 = Console.ReadLine();

    if (vall3.ToLower() == "ta med")
    {
        Console.WriteLine("du rör dig mot tak luckan hemma du öppnar luckan och tar ut pistolen och lägger den i fickan och börjar röra dig mot skogen. när du kommer fram så står inte din vän där fast du ser en maskerad man springa emot dig med höger hand i fickan och du greppar din pistol i fickan vad gör du? skjut eller vänta");
    }
    else if(vall3.ToLower() == "lämna")
    {
        Console.WriteLine("du tänker inte mer på saken och börjar röra dig till skogen när du kommer fram så ser du en maskerad man springa up till dig och drar ut en pistol från jackan. Pang! Pang! Pang!. GAME OVER!!! du dog");
    }
}
{
    



    String viktig = Console.ReadLine();
    if (viktig.ToLower() == "skjut")
    {
        Console.WriteLine("du drar ut ditt vapen och skjuter manen du går fram till liket och drar ut hans hand från fickan och medans du drar ut den så ramlar en pistol från hans ficka så du drar up hans mask och det visade sig att det var din vän. Polisen kommer och griper dig för mord och du hamna i fängelse. Tack för att du spela.");
    }
    else if (viktig.ToLower() == "vänta")
    {
        Console.WriteLine("du väntar och den maskerade manen sspringer upp till dig och drar ut en pistol. Pang! Pang! Pang! GAME OVER!! du dog");
    }
}
{

    String centrum = Console.ReadLine();

    if (centrum.ToLower() == "spring")
    {
        Console.WriteLine("du börjar springa och manen drar fram en psitol och börjar skjuta mot dig men han missar allt och när du kommer hem så bokar du ett flyg till ett annat land och du övelever!! Grattis du klara av spelet!!!! Tack för att du spela");
    }
    else if (centrum.ToLower() == "stanna kvar")
    {
        Console.WriteLine("du står kvar på din plats och manen springer up till dig och drar ut en pistol. PANG! PANG! PANG! GAME OVER!! du dog");
    }
}





Console.ReadLine();