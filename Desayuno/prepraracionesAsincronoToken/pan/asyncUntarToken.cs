namespace Desayuno.prepraraciones.pan;

public class asyncUntarToken
{
    public async Task<string>  untarPan(CancellationToken token)
    {
        try
        {
            await Task.Delay(100, token);
            Console.WriteLine("Pan untado");
            return "Untar pan";
        }
        catch (Exception e)
        {
            Console.WriteLine("Pan untado cancelado");
            throw;
        }
        
    }
}