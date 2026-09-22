namespace Desayuno.prepraraciones;

public class asyncCafeToken
{
    public async Task<string> HacerCafe(CancellationToken token)
    {
        try
        {
            await Task.Delay(200, token);
            Console.WriteLine("Hacer cafe");
            return "Hacer cafe";
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("El cafe sea cancelado");
            throw;
        }
        
        return "Hacer cafe";
    }
}