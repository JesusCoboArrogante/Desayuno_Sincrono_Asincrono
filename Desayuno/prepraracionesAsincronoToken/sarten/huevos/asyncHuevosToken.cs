namespace Desayuno.prepraraciones.sarten.huevos;

public class asyncHuevosToken
{
    public async Task<string>  freirHuevo(CancellationToken token)
    {
        try
        {
            Task.Delay(300,token);
            Console.WriteLine("Huevo frito");
            return "Calentar sarten";
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Huevo cancelado");
            throw;
        } 
        
        
    }
    
}