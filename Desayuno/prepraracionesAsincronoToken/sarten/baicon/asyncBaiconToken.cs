using System.Diagnostics;

namespace Desayuno.prepraraciones.sarten.baicon;

public class asyncBaiconToken
{
    public async Task<string> freirBaicon(CancellationToken token)
    {
        try
        {
            await Task.Delay(300, token);
            Console.WriteLine("Beicon terminado");
            return "Freir baicon";
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Baicon cancelado");
            throw;
        }
        
        
    }
}