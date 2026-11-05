/// <summary>
/// Kalkulatora klase, kas nodroðina pamata aritmçtiskâs darbîbas
/// un reìistrç darbîbu vçsturi, izmantojot þurnâloðanas (logging) servisu.
/// </summary>
public class Calculator
{
    // Lauks, kurâ tiek glabâta loìçðanas (logging) servisa instance. 
    // Tas ir "readonly", kas nozîmç, ka to var iestatît tikai konstruktorâ.
    private readonly ILogger _logger;

    /// <summary>
    /// Kalkulatora klases konstruktors, kas saòem un iestata atkarîbu (dependency) - ILogger.
    /// Ðis ir klasisks Atkarîbu injekcijas (Dependency Injection) piemçrs.
    /// </summary>
    /// <param name="logger">Þurnâloðanas serviss, kas tiks izmantots ziòojumu ierakstîðanai.</param>
    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Saskaita divus veselus skaitïus un ieraksta informâciju þurnâlâ.
    /// </summary>
    /// <param name="a">Pirmais saskaitâmais.</param>
    /// <param name="b">Otrais saskaitâmais.</param>
    /// <returns>Atgrieþ abu skaitïu summu.</returns>
    public int Add(int a, int b)
    {
        // Veic saskaitîðanu un saglabâ rezultâtu mainîgajâ
        int result = a + b;

        // Paziòo þurnâlotâjam (logger) par veikto aprçíinu un tâ rezultâtu
        _logger.Log($"{a} + {b} = {result}");

        // Atgrieþ aprçíinâto rezultâtu izsaucçjam
        return result;
    }
}