namespace Desayuno.prepraraciones;

public class asyncZumoToken
{
    public async Task<string>  exprimirZumo(CancellationToken token)
    {
        try
        {
            await Task.Delay(200,token);
            Console.WriteLine("Zumo Imprimido");
            return "Expremir Zumo";
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Zumo cancelado");
            throw;
        }
      
    }
}