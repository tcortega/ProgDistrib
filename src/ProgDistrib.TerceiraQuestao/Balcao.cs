namespace ProgDistrib.TerceiraQuestao;

public static class Balcao
{
    public static string GetPipoca()
    {
        Thread.Sleep(2000);
        return "Pipoca Pronta!";
    }

    public static string GetRefrigerante()
    {
        Thread.Sleep(1000);
        return "Refrigerante Pronto!";
    }
}