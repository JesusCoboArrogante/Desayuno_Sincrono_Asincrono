namespace Desayuno.prepraraciones.sarten;

public class asyncSartenToken
{
    public async Task<string>  calentarSarten(CancellationToken token)
    {
        try
        {
            Task.Delay(200,token);
            Console.WriteLine("Sarten caliente");
            return "Calentar sarten";
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Sarten cancelada");
            throw;
        }    
        
    }
}