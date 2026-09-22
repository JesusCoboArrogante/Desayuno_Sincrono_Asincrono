namespace Desayuno.prepraraciones.sarten;

public class asyncSarten
{
    public async Task<string>  calentarSarten()
    {
       
            Task.Delay(200);
            return "Calentar sarten";   
        
    }
}