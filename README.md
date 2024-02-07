# CSLuokkaharjoituksia
Esimerkkejä ja harjoituksia C# luokista ja olioista.

## Luokkien periytyminen
Luokka voi periä toiselta luokalta kenttiä ja metodeja. Luokkaa, jonka ominaisuuksia peritään (inheritance) kutsutaan yliluokaksi (superclass, parent class) ja perivää luokkaa aliluokaksi (subclass, child class). Perimisen keskeinen idea on se, että yliluokassa määriteltyjä ominaisuuksi (kenttiä) ja metodeja ei tarvitse enää määritellä aliluokassa, riittää että kerrotaan niiden periytyvän yliluokasta. Yliluokalla ja aliluokalla voi olla saman nimisiä metodeja, jotka toimivat eri tavalla. Tätä kutsutaa metodien ylikirjoittamiseksi (method overload). Aiemmissa versioissa aliluokassa määritelty metodi, joka on kirjoitettu eri tavalla kuin yliluokassa, syrjäytti aliluokan saman nimisen metodin. Uusimmat kääntäjät eivät kuitenkaan toimi näin. Aliluokan metodi voi myös syrjäyttää yliluokan metodin silloin, kun yliluokan metodi on määritetty virtuaaliseksi (virtual) ja aliluokassa metodi on määritelty syrjäyttäväksi (overload). Toinen vaihtoehto on käyttää aliluokan metodin määrityksessä `new`-komentoa yliluokan metodin syrjäyttämiseksi. Jos `new` jätetään pois aliluokka syrjäyttää edelleen yliluokan (toisin kuin dokumentaatiossa lukee). Seuraavassa esimerkissä on kolme luokkaa: yliluokka lemmikinomistajalle sekä kaksi aliluokkaa kissanomistajalle ja koiranomistajalle.

```csharp
// Super/Base/Parent class definition
class Hooman
{
    // Define properties of Hooman ie. fields
    public string name = "Essi Esimerkki";
    public int age = 30;
    public string gender = "Emäntä";

    // Default constructor w/o arguments
    // No need to define, will be crated automatically
    public Hooman()
    {

    }
}

// Sub/Deriver/Child class inherits Hooman class
class CatOwner : Hooman
{
    // Define the method differently in subclass
    public new void SayOpinion()
    { Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
    }
}
```
