namespace Desayuno.prepraraciones;

public class asyncCafe
{
    public async Task<string> HacerCafe()
    {
       
            await Task.Delay(200);
            return "Hacer cafe";
        
        
    }
}