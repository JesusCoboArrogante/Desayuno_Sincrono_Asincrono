namespace Desayuno.prepraraciones.pan;

public class asyncTostarToken
{
    public async Task<string> tostarPan(CancellationToken token)
    {
        try
        {
            await Task.Delay(200,token);
            Console.WriteLine("Pan tostado");
            return "Pan tostado";
        }
        catch (Exception e)
        {
            Console.WriteLine("Pan cancelado");
            throw;
        }
         
    }
}